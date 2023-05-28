﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingObjects2
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            BackColor = Color.Cyan;
            DoubleBuffered = true;
            timer1.Interval = 50;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                scene.AddShape(e.Location, Scene.ShapeType.CIRCLE);
            }else if(e.Button == MouseButtons.Right)
            {
                scene.AddShape(e.Location, Scene.ShapeType.TRIANGLE);
            }
            
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.Pulse();
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            scene.findShape(e.Location);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scene.Move(e.Location);
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            scene.Unselect(e.Location);
        }
    }
}
