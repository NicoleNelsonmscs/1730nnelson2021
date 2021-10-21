using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nnelson2f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // #1 : if
            txtResult1.Text = Ex2fCalculations.Calc01(txtInput1A.Text);

            // #2 : if {block}
            txtResult2.Text = Ex2fCalculations.Calc02(txtInput2A.Text);

            // #3 : if else
            txtResult3.Text = Ex2fCalculations.Calc03(txtInput3A.Text);

            // #4 : if else if
            txtResult4.Text = Ex2fCalculations.Calc04(txtInput4A.Text);

            // #5 : Better range test
            txtResult5.Text = Ex2fCalculations.Calc05(txtInput5A.Text);

            // #6 : nested if statements
            txtResult6.Text = Ex2fCalculations.Calc06(txtInput6A.Text,txtInput6B.Text);

            // #7 : nested if statements
            txtResult7.Text = Ex2fCalculations.Calc07(txtInput7A.Text);

            // #8 : nested if statements
            txtResult8.Text = Ex2fCalculations.Calc08(txtInput8A.Text, txtInput8B.Text);

            // #9 : nested if statements
            txtResult9.Text = Ex2fCalculations.Calc09(txtInput9A.Text, txtInput9B.Text);

            // #10 : nested if statements
            txtResult10.Text = Ex2fCalculations.Calc10(txtInput10A.Text, txtInput10B.Text);
        }
    }
}
