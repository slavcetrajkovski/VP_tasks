using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FlyingBalls
{
    public partial class Form1 : Form
    {
        public Scene scene { get; set; }
        public int timerTicks { get; set; }

        public bool started { get; set; } = true;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene(this.Height, this.Width);
            timer1.Interval = 10;
            timer1.Start();
            timerTicks = 0;
            DoubleBuffered = true;
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.draw(e.Graphics);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timerTicks++;
            if (timerTicks % 10 == 0) //na izminata 1 sekunda
            {
                scene.addBall();
            }
            scene.move();
            updateStatuslabels();
            Invalidate(true);
        }

        private void updateStatuslabels()
        {
            tsslHits.Text = String.Format("Hits: {0}", scene.hits);
            tsslMisses.Text = String.Format("Misses: {0}", scene.misses);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            scene.height = this.Height;
            scene.width = this.Width;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.hit(e.Location);
            Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                String path = sfd.FileName;
                serialize(path);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene(this.Height, this.Width);
            Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                String path = ofd.FileName;
                deserilazeScene(path);
            }
        }

        private void serialize(string path)
        {

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, scene);
            }
        }

        private void deserilazeScene(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                scene = (Scene)formatter.Deserialize(fs);
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            started = !started;
            if(started)
            {
                timer1.Start();
                pauseToolStripMenuItem.Text = "Pause";
            }
            else
            {
                timer1.Stop();
                pauseToolStripMenuItem.Text = "Resume";
            }
        }
    }
}

