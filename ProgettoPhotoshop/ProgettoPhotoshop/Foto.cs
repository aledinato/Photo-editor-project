using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace ProgettoPhotoshop
{
    internal class Foto
    {
        public Bitmap Image { get; set; }
        public List<Bitmap> Images { get; set; }
        public int IndexImage { get; set; }

        public Foto()
        { 
            Images = new List<Bitmap>();
            Image = new Bitmap(1920,1080);
            IndexImage = 0;
        }

        public Foto(Bitmap bm)
        {
            Images = new List<Bitmap>();
            Image = (Bitmap)bm.Clone();
            Images.Add(Image);
            IndexImage = 0;
        }

        public struct ColorARGB
        {
            public byte B;
            public byte G;
            public byte R;
            public byte A;

            public ColorARGB(Color color)
            {
                A = color.A;
                R = color.R;
                G = color.G;
                B = color.B;
            }

            public ColorARGB(byte a, byte r, byte g, byte b)
            {
                A = a;
                R = r;
                G = g;
                B = b;
            }

            public Color ToColor()
            {
                return Color.FromArgb(A, R, G, B);
            }
        }

        public unsafe Bitmap ApplicaFiltroPuntuale(Func<Color,bool,double,Color> filtro,bool t=true,double x=0)
        {
            int width = Image.Width;
            int height = Image.Height;
            Bitmap oldImage= (Bitmap)Image.Clone();

            BitmapData bitmapDataF = Image.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb
            );

            ColorARGB* startingPosition = (ColorARGB*)bitmapDataF.Scan0;
            ColorARGB* position;

            for (int i=0;i<height;i++)
            {
                for (int j = 0; j < width; j++)
                {
                    position = startingPosition + j + i * width;
                    ColorARGB c = new ColorARGB(position->A, position->R, position->G, position->B);
                    c = new ColorARGB(filtro(c.ToColor(), t, x));
                    position->A = c.A;
                    position->R = c.R;
                    position->G = c.G;
                    position->B = c.B;
                }
            }
            Image.UnlockBits(bitmapDataF);
            Images.Insert(IndexImage, oldImage);
            IndexImage++;
            return Image;
        }

        private unsafe Color[,] CreaMatriceColore(ColorARGB* position,int width)
        {
            Color[,] c = new Color[3, 3];
            ColorARGB* pos = position;
            for (int i = 0; i < 3; i++)
            { 
                for (int j = 0; j < 3; j++)
                {
                    pos = position + j + i * width;
                    c[i, j] = new ColorARGB(pos->A, pos->R, pos->G, pos->B).ToColor();
                }
            }
            return c;
        }

        public unsafe Bitmap ApplicaFiltroConvoluzione(Func<Color[,],Color> filtro)
        {
            int width = Image.Width;
            int height = Image.Height;
            Bitmap oldImage = (Bitmap)Image.Clone();
            BitmapData bitmapDataOld = oldImage.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb
            );

            BitmapData bitmapDataF = Image.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb
            );

            ColorARGB* startingPosition = (ColorARGB*)bitmapDataF.Scan0+1+width;
            ColorARGB* startingPositionOld = (ColorARGB*)bitmapDataOld.Scan0;
            ColorARGB* positionOld;
            ColorARGB* position;

            for (int i = 0; i < height-2; i++)
            {
                for (int j = 0; j < width-2; j++)
                {
                    positionOld = startingPositionOld + j + i * width;
                    position = startingPosition + j + i * width;
                    Color[,] c = CreaMatriceColore(positionOld,width); //leggo colore
                    Color newColor = filtro(c); //scrivo colore
                    position->A = 255;
                    position->R = newColor.R;
                    position->G = newColor.G;
                    position->B = newColor.B;
                }
            }
            Image.UnlockBits(bitmapDataF);
            oldImage.UnlockBits(bitmapDataOld);
            Images.Insert(IndexImage, oldImage);
            IndexImage++;
            return Image;
        }

        private unsafe (List<int>, List<int>, List<int>) CreaListaColore(ColorARGB* position, int width,int x,int y)
        {
            List<int> red = new List<int>();
            List<int> green = new List<int>();
            List<int> blue = new List<int>();
            ColorARGB* pos = position+2;
            for (int i = 0; i < 5; i++)
            {
                pos = pos + i * width;
                red.Add(pos->R);
                green.Add(pos->G);
                blue.Add(pos->B);

            }
            pos = position + 2 * width;
            for (int i = 0; i < 5; i++)
            {
                pos = pos + i;
                if (i != 2)
                {
                    red.Add(pos->R);
                    green.Add(pos->G);
                    blue.Add(pos->B);
                }

            }
            red.Sort();
            green.Sort();
            blue.Sort();    
            return (red,green,blue);
        }

        public unsafe Bitmap ApplicaMedianSmoothing()
        {
            int width = Image.Width;
            int height = Image.Height;
            Bitmap oldImage = (Bitmap)Image.Clone();
            BitmapData bitmapDataOld = oldImage.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb
            );

            BitmapData bitmapDataF = Image.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb
            );

            ColorARGB* startingPosition = (ColorARGB*)bitmapDataF.Scan0 + 2 + 2 * width;
            ColorARGB* startingPositionOld = (ColorARGB*)bitmapDataOld.Scan0;
            ColorARGB* positionOld;
            ColorARGB* position;

            for (int i = 0; i < height - 10; i++)
            {
                for (int j = 0; j < width - 4; j++)
                {
                    positionOld = startingPositionOld + j + i * width;
                    position = startingPosition + j + i * width;
                    var rgb=CreaListaColore(positionOld, width,i,j);//leggo colore
                    Color newColor = Filtri.MedianSmoothing(rgb.Item1,rgb.Item2,rgb.Item3); //scrivo colore
                    position->A = 255;
                    position->R = newColor.R;
                    position->G = newColor.G;
                    position->B = newColor.B;
                }
            }
            Image.UnlockBits(bitmapDataF);
            oldImage.UnlockBits(bitmapDataOld);
            Images.Insert(IndexImage, oldImage);
            IndexImage++;
            return Image;
        }

    }
}
