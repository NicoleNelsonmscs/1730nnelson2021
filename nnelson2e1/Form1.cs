using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nnelson2e1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            result01TextBox.Text = "";
            result02TextBox.Text = "";
            result03TextBox.Text = "";
            result04TextBox.Text = "";
            result05TextBox.Text = "";
            result06TextBox.Text = "";
            result07TextBox.Text = "";
            result08TextBox.Text = "";
            result09TextBox.Text = "";
            sideEffect03TextBox.Text = "";
            sideEffect04TextBox.Text = "";
            sideEffect05TextBox.Text = "";
            sideEffect06TextBox.Text = "";
            sideEffect09TextBox.Text = "";

            //#01

            decimal subtotal = Convert.ToDecimal(input01ATextBox.Text);
            //result01TextBox.Text = (subtotal >= 250 && subtotal < 500).ToString();
            result01TextBox.Text = (LogicalOperations.q01(subtotal)).ToString();

            //#02

            int timeInService = Convert.ToInt32(input02ATextBox.Text);
            //result02TextBox.Text = (timeInService <= 4 || timeInService >= 12).ToString();
            result02TextBox.Text = (LogicalOperations.q02(timeInService)).ToString();

            //#3 - 6 initialization

            bool isValid = Convert.ToBoolean(input03ATextBox.Text);
            int years = Convert.ToInt32(input03CTextBox.Text);

            //#03 

            int counter = Convert.ToInt32(input03BTextBox.Text);
            //result03TextBox.Text = (isValid == true && counter++ < years).ToString();
            result03TextBox.Text = (LogicalOperations.q03(isValid,years,counter)).ToString();
            sideEffect03TextBox.Text = counter.ToString();

            //#04 

            counter = Convert.ToInt32(input03BTextBox.Text);
            //result04TextBox.Text = (isValid == true & counter++ < years).ToString();
            result04TextBox.Text = (LogicalOperations.q04(isValid,years,counter)).ToString();
            sideEffect04TextBox.Text = counter.ToString();

            //#05

            counter = Convert.ToInt32(input03BTextBox.Text);
            //result05TextBox.Text = (isValid == true || counter++ < years).ToString();
            result05TextBox.Text = (LogicalOperations.q05(isValid,years,counter)).ToString();
            sideEffect05TextBox.Text = counter.ToString();


            //#06

            counter = Convert.ToInt32(input03BTextBox.Text);
            //result06TextBox.Text = (isValid == true | counter++ < years).ToString();
            result06TextBox.Text = (LogicalOperations.q06(isValid,years,counter)).ToString();
            sideEffect06TextBox.Text = counter.ToString();

            //#07

            DateTime startDate = Convert.ToDateTime(input07ATextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(input07BTextBox.Text);
            DateTime date = Convert.ToDateTime(input07CTextBox.Text);
            isValid = Convert.ToBoolean(input07DTextBox.Text);
            //result07TextBox.Text = (date > startDate && date < expirationDate || isValid).ToString();
            result07TextBox.Text = (LogicalOperations.q07(startDate,expirationDate,date,isValid)).ToString();

            //#08

            decimal thisYTD = Convert.ToDecimal(input08ATextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input08BTextBox.Text);
            string empType = input08CTextBox.Text;
            int startYear = Convert.ToInt32(input08DTextBox.Text);
            int currentYear = Convert.ToInt32(input08ETextBox.Text);
            //result08TextBox.Text = (
            //    ((thisYTD > lastYTD) || empType == "Part time") && startYear < currentYear
            //    ).ToString();
            result08TextBox.Text = (
                (LogicalOperations.q08(thisYTD, lastYTD, empType, startYear, currentYear))
                ).ToString();

            //#09

            counter = Convert.ToInt32(input09ATextBox.Text);
            years = Convert.ToInt32(input09BTextBox.Text);
            //result09TextBox.Text = (
            //    !(counter++ >= years)
            //    ).ToString();
            result09TextBox.Text = (
                LogicalOperations.q09(counter,years)
                ).ToString();
            sideEffect09TextBox.Text = counter.ToString();

            //#10

            int a = Convert.ToInt32(input10ATextBox.Text);
            int b = Convert.ToInt32(input10BTextBox.Text);
            int c = Convert.ToInt32(input10CTextBox.Text);
            int d = Convert.ToInt32(input10DTextBox.Text);
            //result10TextBox.Text = (
            //    a + b * c - d
            //    ).ToString();
            //int x = b * c;
            //int y = a + x;
            //int z = y - d;
            //result10TextBox.Text = z.ToString();
            //result10TextBox.Text = (
            //        a > b && b < c || c < d
            //    ).ToString();
            //bool v = a > b;
            //bool w = b < c;
            //bool x = c < d;
            //bool y = v && w;
            //bool z = y || x;
            //result10TextBox.Text = z.ToString()
            result10TextBox.Text = (LogicalOperations.q10(a,b,c,d)).ToString();
        }
    }
}
