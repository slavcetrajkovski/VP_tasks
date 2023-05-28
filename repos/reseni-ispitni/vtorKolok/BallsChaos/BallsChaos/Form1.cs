using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsChaos
{
    public partial class Form1 : Form
    {
        Scene scene;
        int left;
        int top;
        int width;
        int height;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            this.DoubleBuffered = true;
            timer1.Interval = 20;
            timer1.Start();
            left = 20;
            top = 60;
            width = this.Width - (3 * left);
            height = this.Height - (int) (2.5 * top);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.AddBall(e.Location);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(pen, left, top, width, height);
            pen.Dispose();
            scene.Draw(e.Graphics);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            width = this.Width - (3 * left);
            height = this.Height - (int)(2.5 * top);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.MoveBalls(left, top, width, height);
            scene.isTouching();
            Invalidate();
            tssBalls.Text = string.Format("# Balls: {0}", scene.balls.Count);
        }

        private void serialize(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, scene);
        }

        private void deserialize(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            scene = (Scene) formatter.Deserialize(fs);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                String path = sfd.FileName;
                serialize(path);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                String path = sfd.FileName;
                serialize(path);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String path = ofd.FileName;
                deserialize(path);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String path = ofd.FileName;
                deserialize(path);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            Invalidate();
        }
    }
}
