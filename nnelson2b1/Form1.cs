using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nnelson2b1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = (amountAustralia * rateAustralia);
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");

            decimal amountBhutan = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal rateBhutan = Convert.ToDecimal(txtRateBhutan.Text);
            decimal usdBhutan= (amountBhutan * rateBhutan);
            txtUSDBhutan.Text = usdBhutan.ToString("0.00");

            decimal amountCostaRico = Convert.ToDecimal(txtAmountCostaRica.Text);
            decimal rateCostaRico = Convert.ToDecimal(txtRateCostaRica.Text);
            decimal usdCostaRico = (amountCostaRico * rateCostaRico);
            txtUSDCostaRica.Text = usdCostaRico.ToString("0.00");

            decimal amountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            decimal rateEuro = Convert.ToDecimal(txtRateEuro.Text);
            decimal usdEuro = (amountEuro * rateEuro);
            txtUSDEuro.Text = usdEuro.ToString("0.00");

            decimal totalUSD = (usdAustralia + usdBhutan + usdCostaRico + usdEuro);
            txtUSTotal.Text = totalUSD.ToString("0.00");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.717976";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.0139831";
            txtAmountCostaRica.Text = "0.00";
            txtRateCostaRica.Text = "0.00176122";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.15528";
            txtUSTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
