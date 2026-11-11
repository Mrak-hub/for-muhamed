using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        private Pen currentPen = new Pen(Color.Black, 3f);

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);

            if (canvas != null)
            {
                canvas.Image = new Bitmap(canvas.Width, canvas.Height);

                canvas.MouseDown += Canvas_MouseDown;
                canvas.MouseMove += Canvas_MouseMove;
                canvas.MouseUp += Canvas_MouseUp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.colorPanel != null)
            {
                foreach (Control control in this.colorPanel.Controls)
                {
                    if (control is Button button)
                    {
                        button.Click += ColorButton_Click;
                    }
                }
            }
        }
        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                currentPen.Color = clickedButton.BackColor;
            }
        }


        private void PBox_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                currentPen.Color = clickedPanel.BackColor;
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && canvas != null && canvas.Image != null)
            {
                using (Graphics g = Graphics.FromImage(canvas.Image))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    g.DrawLine(currentPen, previousPoint, e.Location);
                }

                canvas.Invalidate();

                previousPoint = e.Location;
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Black;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Red;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Green;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Blue; 
        }

        private void button32_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentPen.Color = colorDialog.Color;
            }
        }

        private void colorPanel_Paint(object sender, PaintEventArgs e) { }
        private void ribbon_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void btnSelect_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void btnPaste_Click(object sender, EventArgs e) { }
        private void на180ToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void на15ToolStripMenuItem_Click(object sender, EventArgs e) { }
    }
}