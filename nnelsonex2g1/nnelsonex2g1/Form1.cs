using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nnelsonex2g1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //1a) 'Switch' with no default
            txtResultsSwitch1.Text = Ex2gCalculations.Switch01(txtInput1A.Text);

            //1b) Seperate 'if' statements
            txtResultsIf1.Text = Ex2gCalculations.If01(txtInput1A.Text);

            //1c)'Else if' statements
            txtResultsElseIf1.Text = Ex2gCalculations.ElseIf01(txtInput1A.Text);

            //1d)'Nested if' statements
            txtResultsNestedIf1.Text = Ex2gCalculations.NestedIfElse01(txtInput1A.Text);

            //1e) 'Switch' with default
            txtResultsSwitchDefault1.Text = Ex2gCalculations.SwitchDefault01(txtInput1A.Text);

            //1f) Seperate 'if' statements
            txtResultsIfDefault1.Text = Ex2gCalculations.IfDefault01(txtInput1A.Text);

            //1g)'Else if' statements
            txtResultsElseIfDefault1.Text = Ex2gCalculations.ElseIfDefault01(txtInput1A.Text);

            //1h)'Nested if' statements
            txtResultsNestedIfDefault1.Text = Ex2gCalculations.NestedIfElseDefault01(txtInput1A.Text);

            // 2a) 'Switch' with no default
            txtResultsSwitch2.Text = Ex2gCalculations.Switch02(txtInput2A.Text);

            // 2b) Separate 'if' statements
            txtResultsIf2.Text = Ex2gCalculations.If02(txtInput2A.Text);

            // 2c) if elseif
            txtResultsElseIf2.Text = Ex2gCalculations.ElseIf02(txtInput2A.Text);

            // 2d) Nested if-else
            txtResultsNestedIf2.Text = Ex2gCalculations.NestedIfElse02(txtInput2A.Text);
        }
    }
}
