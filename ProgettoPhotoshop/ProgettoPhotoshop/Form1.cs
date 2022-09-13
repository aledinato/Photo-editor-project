using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ProgettoPhotoshop
{
    public partial class Form1 : Form
    {
        private Foto f;
        private PictureBox picBox;
        private List<(Foto,PictureBox)> listaFoto;
        public Form1()
        {
            InitializeComponent();
            f = new Foto();
            picBox = pictureBox1;
            listaFoto = new List<(Foto,PictureBox)>();
            listaFoto.Add((f,picBox));
            var menuItem = new MenuItem("Open in another window");
            menuItem.Shortcut = Shortcut.F10;
            menuItem.Click += new EventHandler(menuItem_Click);
            var menuItem2 = new MenuItem("Close this window");
            menuItem2.Click += new EventHandler(closeTabBtn_Click);
            picBox.ContextMenu = new ContextMenu(new MenuItem[] { menuItem,menuItem2 });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void invertedColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaFiltroPuntuale(Filtri.InvertiColori);
            Cursor = DefaultCursor;
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaFiltroPuntuale(Filtri.ScalaGrigi);
            Cursor = DefaultCursor;
        }

        private void thresholdingToolStripMenuItem_Click(object sender, EventArgs e)//sogliatura
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaFiltroPuntuale(Filtri.Sogliatura,true, 127);
            Cursor = DefaultCursor;
        }
        private void aumentaToolStripMenuItem_Click(object sender, EventArgs e) //aumenta luminosità
        {
            Cursor = Cursors.WaitCursor;
            int x;
            if (int.TryParse(txtBoxSogliatura.Text, out x))
            { picBox.Image = f.ApplicaFiltroPuntuale(Filtri.Luminosità, true, x); }
            else
            { picBox.Image = f.ApplicaFiltroPuntuale(Filtri.Luminosità, true,10); }
            Cursor = DefaultCursor;
        }

        private void diminuisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int x;
            if (int.TryParse(txtBoxSogliatura.Text, out x))
            { picBox.Image = f.ApplicaFiltroPuntuale(Filtri.Luminosità, false, x); }
            else
            { picBox.Image = f.ApplicaFiltroPuntuale(Filtri.Luminosità, false,10); }
            Cursor = DefaultCursor;
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaFiltroPuntuale(Filtri.Contrasto);
            Cursor = DefaultCursor;
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaFiltroConvoluzione(Filtri.Blur);
            Cursor = DefaultCursor;
        }

        private void softenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaFiltroConvoluzione(Filtri.Soften);
            Cursor = DefaultCursor;
        }

        private void sharpnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaFiltroConvoluzione(Filtri.Sharpner);
            Cursor = DefaultCursor;
        }

        private void medianSmoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaMedianSmoothing();
            Cursor = DefaultCursor;
        }

        private void laplancianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaFiltroConvoluzione(Filtri.Laplanciano);
            Cursor = DefaultCursor;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaFiltroConvoluzione(Filtri.SobelSx);
            Cursor = DefaultCursor;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaFiltroConvoluzione(Filtri.SobelDx);
            Cursor = DefaultCursor;
        }

        private void leftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaFiltroConvoluzione(Filtri.PrewittSx);
            Cursor = DefaultCursor;
        }

        private void rightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image = f.ApplicaFiltroConvoluzione(Filtri.PrewittDx);
            Cursor = DefaultCursor;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG Images (*.jpeg)|*.jpeg|PNG Images (*.png)|*.png";
            saveFileDialog.Title = "Save an Image File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    FileStream fs = (FileStream)saveFileDialog.OpenFile();
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            f.Image.Save(fs, ImageFormat.Jpeg);
                            break;

                        case 2:
                            f.Image.Save(fs, ImageFormat.Png);
                            break;
                    }
                    fs.Close();
                }
            }
        }

        private void reverseBtn_Click(object sender, EventArgs e) //reverse
        {
            if (f.Images.Count > f.IndexImage + 1)
            {
                f.IndexImage++;
                f.Image = f.Images[f.IndexImage];
                picBox.Image=f.Image;
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e) //undo
        {
            if (f.IndexImage > 0)
            {
                f.IndexImage--;
                f.Image = f.Images[f.IndexImage];
                picBox.Image = f.Image;
            }
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            AggiuntaTabPage(f.Image);
        }

        private PictureBox SetPictureBox(Bitmap i)
        {
            PictureBox pb = new PictureBox();
            pb.Location = picBox.Location;
            pb.Margin = picBox.Margin;
            pb.Size = picBox.Size;
            pb.SizeMode = picBox.SizeMode;
            pb.Image = i;
            pb.TabIndex = picBox.TabIndex;
            pb.TabStop = picBox.TabStop;
            pb.ContextMenu = picBox.ContextMenu;
            pb.BackColor=picBox.BackColor;
            return pb;
        }

        private void AggiuntaTabPage(Bitmap bm)
        {
            int index = tabControl1.Controls.Count + 1;
            var tabPage = new TabPage("Image_" + index);
            PictureBox pb=SetPictureBox(bm);
            tabPage.Controls.Add(pb);
            f = new Foto(bm);
            listaFoto.Add((f,pb));
            picBox = pb;
            tabControl1.Controls.Add(tabPage);
            tabControl1.SelectedTab = tabPage;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = listaFoto[tabControl1.SelectedIndex];
            f = data.Item1;
            picBox = data.Item2;
            picBox.Image = f.Image;
        }

        private void closeTabBtn_Click(object sender, EventArgs e)
        {
            if (listaFoto.Count == 1)
            { 
                var result=MessageBox.Show("Are you sure to close the last window?","Alert",MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                { Application.Exit(); }
            }
            else
            {
                listaFoto.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.Controls.RemoveAt(tabControl1.SelectedIndex);
                f = listaFoto[tabControl1.SelectedIndex].Item1;
                picBox = listaFoto[tabControl1.SelectedIndex].Item2;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.Images.Clear();
            f.IndexImage = 0;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Images (*.png)|*.png|JPEG Images (*.jpeg)|*.jpeg|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var result = ofd.OpenFile();
                f.Image = new Bitmap(result);
                Name = ofd.FileName;
                picBox.Image = f.Image;
                f.Images.Add(f.Image);
            }
        }

        private void openAnotherWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AggiuntaTabPage(new Bitmap(picBox.Size.Width, picBox.Size.Height));
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            picBox.Image=f.ApplicaFiltroPuntuale(Filtri.Sepia);
            Cursor = DefaultCursor;
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)//sogliatura
        {
            int x;
            if (!int.TryParse(txtBoxSogliatura.Text, out x))
            {
                Cursor = Cursors.WaitCursor;
                txtBoxSogliatura.BackColor = Color.White;
                picBox.Image = f.ApplicaFiltroPuntuale(Filtri.Sogliatura, true, 127);
                Cursor = DefaultCursor;
            }
            else if (x < 0 || x > 255)
            { txtBoxSogliatura.BackColor = Color.Red; }
            else
            {
                Cursor = Cursors.WaitCursor;
                txtBoxSogliatura.BackColor = Color.White;
                picBox.Image = f.ApplicaFiltroPuntuale(Filtri.Sogliatura, true, x);
                Cursor = DefaultCursor;
            }
        }

        private void applyToolStripMenuItem1_Click(object sender, EventArgs e)//contrasto
        {
            double x;
            if (!double.TryParse(txtBoxSogliatura.Text, out x))
            {
                Cursor = Cursors.WaitCursor;
                contrastoTxt.BackColor = Color.White;
                picBox.Image = f.ApplicaFiltroPuntuale(Filtri.Sogliatura, true, 1.5);
                Cursor = DefaultCursor;
            }
            else if(x<0)
            { contrastoTxt.BackColor = Color.Red; }
            else
            {
                Cursor = Cursors.WaitCursor;
                contrastoTxt.BackColor = Color.White;
                picBox.Image = f.ApplicaFiltroPuntuale(Filtri.Sogliatura, true, x);
                Cursor = DefaultCursor;
            }
        }
    }
}
