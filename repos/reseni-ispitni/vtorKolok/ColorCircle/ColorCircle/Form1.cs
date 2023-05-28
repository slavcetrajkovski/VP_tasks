using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ColorCircle
{
    public partial class Form1 : Form
    {
        Scene scene;
        Color color;
        int radius;
        Point center;
        Point radiusMove;

        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            this.DoubleBuffered = true;
            color = Color.Blue;
            radius = 25;
            tssCircles.Text = String.Format("Circles: 0");
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
            if (!center.IsEmpty)
            {
                Pen p = new Pen(Color.Black, 3);
                p.DashStyle = DashStyle.Dot;
                e.Graphics.DrawEllipse(p, center.X - radius, center.Y - radius, radius * 2, radius * 2);
                p.Dispose();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) {
                if (center.IsEmpty)
                {
                    center = e.Location;
                }
                else
                {
                    scene.AddCircle(center, radius, color);
                    updateLabel();
                    center = Point.Empty;
                    Invalidate();
                }
              
            } 
            if(e.Button == MouseButtons.Right)
            {
                scene.findSelected(e.Location);
            }

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                scene.deleteSelected();
                updateLabel();
                Invalidate();
            }
            if(e.KeyCode == Keys.Escape)
            {
                center = Point.Empty;
                Invalidate();
            }
        }

        void updateLabel()
        {
            tssCircles.Text = string.Format("Circles: {0}", scene.circles.Count);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                color = cd.Color;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            radiusMove = e.Location;
            radius = (int)Math.Sqrt(Math.Pow(radiusMove.X - center.X, 2) + Math.Pow(radiusMove.Y - center.Y, 2));
            Invalidate();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            updateLabel();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            updateLabel();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
            updateLabel();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
            updateLabel();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        void saveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                String path = sfd.FileName;
                serialize(path);
            }
        }

        void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = openFileDialog.FileName;
                desirialize(path);
            }
        }

        void desirialize(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            scene = (Scene)formatter.Deserialize(fs);

        }

        void serialize(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, scene);
        }
    }
}
