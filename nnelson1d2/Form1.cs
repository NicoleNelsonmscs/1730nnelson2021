using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nnelson1d2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            txt1.Text = "Frank";
            txt2.Text = "";
            txt3.Text = "2.3";
            txt4.Text = "false";
            txt5A.Text = "2";
            txt5B.Text = "2";
            txt6.Text = "xyz";
            txt7.Text = "1";
            txt8A.Text = "1";
            txt8B.Text = "2";
            txt9.Text = "500";
            txt10A.Text = "3";
            txt10B.Text = "3";
        }

        private void btnFail_Click(object sender, EventArgs e)
        {
            txt1.Text = "xyz";
            txt2.Text = "xyz";
            txt3.Text = "2.4";
            txt4.Text = "true";
            txt5A.Text = "2";
            txt5B.Text = "3";
            txt6.Text = "Jones";
            txt7.Text = "0";
            txt8A.Text = "1";
            txt8B.Text = "1";
            txt9.Text = "499";
            txt10A.Text = "4";
            txt10B.Text = "3";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtResult1.Text = "Fail";
            txtResult2.Text = "Fail";
            txtResult3.Text = "Fail";
            txtResult4.Text = "Fail";
            txtResult5.Text = "Fail";
            txtResult6.Text = "Fail";
            txtResult7.Text = "Fail";
            txtResult8.Text = "Fail";
            txtResult9.Text = "Fail";
            txtResult10.Text = "Fail";

            txtResult1B.Text = "Success";
            txtResult2B.Text = "Success";
            txtResult3B.Text = "Success";
            txtResult4B.Text = "Success";
            txtResult5B.Text = "Success";
            txtResult6B.Text = "Success";
            txtResult7B.Text = "Success";
            txtResult8B.Text = "Success";
            txtResult9B.Text = "Success";
            txtResult10B.Text = "Success";

            if (txt1.Text == "Frank")
                txtResult1.Text = "Success";
            if (txt1.Text != "Frank")
                txtResult1B.Text = "Fail";

            if (txt2.Text == "")
                txtResult2.Text = "Success";
            if (txt2.Text != "")
                txtResult2B.Text = "Fail";

            decimal val3 = Convert.ToDecimal(txt3.Text);
            if (val3 == 2.3m)
                txtResult3.Text = "Success";
            if (val3 != 2.3m)
                txtResult3B.Text = "Fail";

            bool val4 = Convert.ToBoolean(txt4.Text);
            if (val4 == false)
                txtResult4.Text = "Success";
            if (val4 != false)
                txtResult4B.Text = "Fail";

            decimal val5A = Convert.ToDecimal(txt5A.Text);
            decimal val5B = Convert.ToDecimal(txt5B.Text);
            if (val5A == val5B)
                txtResult5.Text = "Success";
            if (val5A != val5B)
                txtResult5B.Text = "Fail";

            if (txt6.Text != "Jones")
                txtResult6.Text = "Success";
            if (txt6.Text == "Jones")
                txtResult6B.Text = "Fail";

            decimal val7 = Convert.ToDecimal(txt7.Text);
            if (val7 > 0)
                txtResult7.Text = "Success";
            if (val7 <= 0)
                txtResult7B.Text = "Fail";

            decimal val8A = Convert.ToDecimal(txt8A.Text);
            decimal val8B = Convert.ToDecimal(txt8B.Text);
            if (val8A < val8B)
                txtResult8.Text = "Success";
            if (val8A >= val8B)
                txtResult8B.Text = "Fail";

            decimal val9 = Convert.ToDecimal(txt9.Text);
            if (val9 >= 500)
                txtResult9.Text = "Success";
            if (val9 < 500)
                txtResult9B.Text = "Fail";

            decimal val10A = Convert.ToDecimal(txt10A.Text);
            decimal val10B = Convert.ToDecimal(txt10B.Text);
            if (val10A <= val10B)
                txtResult10.Text = "Success";
            if (val10A > val10B)
                txtResult10B.Text = "Fail";
        }
    }
}
