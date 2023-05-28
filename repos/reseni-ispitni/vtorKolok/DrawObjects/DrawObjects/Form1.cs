namespace DrawObjects
{
    public partial class Form1 : Form
    {

        public Scene Scene { get; set; }


        public string ShapeType { get; set; } = "Circle";
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();
            timer1.Interval = 500;
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            Scene.Click(e.Location, ShapeType);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.DrawAll(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.Pulse();
            Invalidate();
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeType = "Square";
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeType = "Circle";
        }
    }
}