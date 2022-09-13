using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgettoPhotoshop
{
    internal class Filtri
    {
        public static Color Luminosità(Color c, bool aumenta=true,double n=10)
        {
            int r, g, b;
            int addendo = (int)n;
            if (aumenta)
            {
                r = c.R + addendo > 255 ? 255 : c.R + addendo ;
                g = c.G + addendo > 255 ? 255 : c.G + addendo;
                b = c.B + addendo > 255 ? 255 : c.B + addendo;
            }
            else
            {
                r = c.R - addendo < 0 ? 0 : c.R - addendo;
                g = c.G - addendo < 0 ? 0 : c.G - addendo;
                b = c.B - addendo < 0 ? 0 : c.B - addendo;
            }
            return Color.FromArgb(r,g,b); 
        }

        public static Color Sogliatura(Color c, bool t = true, double sogliatura = 127)
        {
            int r = c.R > sogliatura ? 0 : 255;
            int g = c.G > sogliatura ? 0 : 255;
            int b = c.B > sogliatura ? 0 : 255;
            return Color.FromArgb(r, g, b);
        }

        public static Color Contrasto(Color c, bool aumenta=true, double n=1.5)
        {
            int r = Convert.ToInt32(c.R + (c.R - 127.0) * n);
            int g = Convert.ToInt32(c.G + (c.G - 127.0) * n);
            int b = Convert.ToInt32(c.B + (c.B - 127.0) * n);
            r = r < 0 ? 0 : r;
            g = g < 0 ? 0 : g;
            b = b < 0 ? 0 : b;
            return Color.FromArgb(r,g,b);
        }

        public static Color InvertiColori(Color c, bool t=true,double n = 1)
        {
            return Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
        }

        public static Color ScalaGrigi(Color c, bool t=true, double n = 1)
        {
            return Color.FromArgb((c.R + c.B + c.G) / 3, (c.R + c.B + c.G) / 3, (c.R + c.B + c.G) / 3);
        }

        public static Color Blur(Color[,] c)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    r += c[i, j].R;
                    g += c[i, j].G;
                    b += c[i, j].B;
                }
            }
            return Color.FromArgb(255, r / 9, g / 9, b / 9) ;
        }

        public static Color MedianSmoothing(List<int> red, List<int> green, List<int> blue) //in input una lista ordinata di colori
        {
            int count = red.Count;
            return Color.FromArgb(255, red[count / 2], green[count / 2], blue[count / 2]); 
        }

        public static Color Soften(Color[,] c)
        {
            int[,] mat = { { 1, 2, 1 }, { 2, 4, 2 } , { 1, 2, 1 } };
            int r = 0;
            int g = 0;
            int b = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    r += c[i, j].R*mat[i, j];
                    g += c[i, j].G*mat[i, j];
                    b += c[i, j].B*mat[i, j];
                }
            }
            return Color.FromArgb(255, r / 16, g / 16, b / 16);
        }
        public static Color Sharpner(Color[,] c)
        {
            int[,] mat = { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
            int r = 0;
            int g = 0;
            int b = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    r += c[i, j].R * mat[i, j];
                    g += c[i, j].G * mat[i, j];
                    b += c[i, j].B * mat[i, j];
                }
            }
            r = r > 255 ? 255 : r;
            g = g > 255 ? 255 : g;
            b = b > 255 ? 255 : b;
            r = r < 0 ? 0 : r;
            g = g < 0 ? 0 : g;
            b = b < 0 ? 0 : b;
            return Color.FromArgb(255, r , g , b);
        }

        public static Color Laplanciano(Color[,] c)
        {
            int[,] mat = { { 2, -1, 2 }, { -1, -4, -1 }, { 2, -1, 2 } };
            int r = 0;
            int g = 0;
            int b = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    r += c[i, j].R * mat[i, j];
                    g += c[i, j].G * mat[i, j];
                    b += c[i, j].B * mat[i, j];
                }
            }
            r = r > 255 ? 255 : r;
            g = g > 255 ? 255 : g;
            b = b > 255 ? 255 : b;
            r = r < 0 ? 0 : r;
            g = g < 0 ? 0 : g;
            b = b < 0 ? 0 : b;
            return Color.FromArgb(255, r , g , b );
        }

        public static Color PrewittSx(Color[,] c)
        {
            int[,] mat = { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };
            int r = 0;
            int g = 0;
            int b = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    r += c[i, j].R * mat[i, j];
                    g += c[i, j].G * mat[i, j];
                    b += c[i, j].B * mat[i, j];
                }
            }
            r = r > 255 ? 255 : r;
            g = g > 255 ? 255 : g;
            b = b > 255 ? 255 : b;
            r = r < 0 ? 0 : r;
            g = g < 0 ? 0 : g;
            b = b < 0 ? 0 : b;
            return Color.FromArgb(255, r, g, b);
        }

        public static Color PrewittDx(Color[,] c)
        {
            int[,] mat = { { 1, 0, -1 }, { 1, 0, -1 }, { 1, 0, -1 } };
            int r = 0;
            int g = 0;
            int b = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    r += c[i, j].R * mat[i, j];
                    g += c[i, j].G * mat[i, j];
                    b += c[i, j].B * mat[i, j];
                }
            }
            r = r > 255 ? 255 : r;
            g = g > 255 ? 255 : g;
            b = b > 255 ? 255 : b;
            r = r < 0 ? 0 : r;
            g = g < 0 ? 0 : g;
            b = b < 0 ? 0 : b;
            return Color.FromArgb(255, r, g, b);
        }

        public static Color SobelSx(Color[,] c)
        {
            int[,] mat = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int r = 0;
            int g = 0;
            int b = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    r += c[i, j].R * mat[i, j];
                    g += c[i, j].G * mat[i, j];
                    b += c[i, j].B * mat[i, j];
                }
            }
            r = r > 255 ? 255 : r;
            g = g > 255 ? 255 : g;
            b = b > 255 ? 255 : b;
            r = r < 0 ? 0 : r;
            g = g < 0 ? 0 : g;
            b = b < 0 ? 0 : b;
            return Color.FromArgb(255, r, g, b);
        }

        public static Color SobelDx(Color[,] c)
        {
            int[,] mat = { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
            int r = 0;
            int g = 0;
            int b = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    r += c[i, j].R * mat[i, j];
                    g += c[i, j].G * mat[i, j];
                    b += c[i, j].B * mat[i, j];
                }
            }
            r = r > 255 ? 255 : r;
            g = g > 255 ? 255 : g;
            b = b > 255 ? 255 : b;
            r = r < 0 ? 0 : r;
            g = g < 0 ? 0 : g;
            b = b < 0 ? 0 : b;
            return Color.FromArgb(255, r, g, b);
        }


        public static Color Sepia(Color c,bool t= true, double n = 1)
        {
            int r = (int)(0.393 * c.R + 0.769 * c.G + 0.189 * c.B);
            int g = (int)(0.349 * c.R + 0.686 * c.G + 0.168 * c.B);
            int b = (int)(0.272 * c.R + 0.534 * c.G + 0.131 * c.B);
            r = r > 255 ? 255 : r;
            g = g > 255 ? 255 : g;
            b = b > 255 ? 255 : b;
            r = r < 0 ? 0 : r;
            g = g < 0 ? 0 : g;
            b = b < 0 ? 0 : b;
            return Color.FromArgb(255, r, g, b);
        }

    }
}
