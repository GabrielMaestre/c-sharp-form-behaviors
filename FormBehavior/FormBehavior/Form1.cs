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
    }
}
