using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nnelson1f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRico.BackgroundImage = picCostaRicoDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Text = "0.00";
            txtExchangeRate.Text = "0.717976";
            txtUSDollar.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRico.BackgroundImage = picCostaRicoDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Text = "0.00";
            txtExchangeRate.Text = "0.717976";
            txtUSDollar.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCostaRico.BackgroundImage = picCostaRicoDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnBhutan.Text + ": ";
            txtCurrency.Text = "0.00";
            txtExchangeRate.Text = "0.0139831";
            txtUSDollar.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnCostaRico_Click(object sender, EventArgs e)
        {
            btnCostaRico.BackgroundImage = picCostaRico.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnCostaRico.Text + ": ";
            txtCurrency.Text = "0.00";
            txtExchangeRate.Text = "0.00176122";
            txtUSDollar.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRico.BackgroundImage = picCostaRicoDim.Image;
            lblCurrency.Text = btnEuro.Text + ": ";
            txtCurrency.Text = "0.00";
            txtExchangeRate.Text = "1.15528";
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollar.Text = (
                Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtExchangeRate.Text)
                ).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtTotalUSD.Text) +
                Convert.ToDecimal(txtUSDollar.Text)
                ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollar.Text;
            txtCurrency.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRico.BackgroundImage = picCostaRicoDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Text = "0.00";
            txtExchangeRate.Text = "0.717976";
            txtUSDollar.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblEquation.Text = "";
            txtCurrency.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
