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

namespace BlowingBaloons
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            scene = new Scene();
            timer1.Interval = 100;
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.addBalloons(e.Location);
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.blowBalloons();
            scene.explosion();
            tssTotal.Text = string.Format("Total: {0}", scene.balloons.Count);
            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            Invalidate();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = saveFileDialog.FileName;
                serialize(path);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = saveFileDialog.FileName;
                serialize(path);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = openFileDialog.FileName;
                desirialize(path);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = openFileDialog.FileName;
                desirialize(path);
            }
        }

        void serialize(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, scene);
        }

        void desirialize(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            scene = (Scene) formatter.Deserialize(fs);
        }

        
    }
}
