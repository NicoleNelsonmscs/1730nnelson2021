using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nnelson1e2
{
    public partial class frmAverageTestGrades : Form
    {
        public frmAverageTestGrades()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (
                (Convert.ToDecimal(txtTest1.Text) +
                Convert.ToDecimal(txtTest2.Text) +
                Convert.ToDecimal(txtTest3.Text))
                / 3
                ).ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text = "0";
            txtTest2.Text = "0";
            txtTest3.Text = "0";
            txtAverage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
