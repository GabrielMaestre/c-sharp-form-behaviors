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
    public partial class FormPass : Form
    {
        public FormPass()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "email@gmail.com")
            {
                MessageBox.Show("Your Password is: ADM2020", "Recover Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
