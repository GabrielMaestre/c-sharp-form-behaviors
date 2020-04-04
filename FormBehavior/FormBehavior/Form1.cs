using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBehavior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int X, Y;

        Point lastPoint;

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlItems1.BackColor = Color.FromArgb(30, 0, 0, 0);
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {
            Pen Caneta = new Pen(Color.White, 4);

            int x = this.pnl1.Width;

            int y = this.pnl1.Height;

            Rectangle rect = new Rectangle(0, 0, x, y);
            
            e.Graphics.DrawRectangle(Caneta, rect);
        }
        

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pnl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pnl1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pnlItems1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pnlItems1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(4);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
