using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace nnelson3c
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            inputListBox4a.Items.Add("11.1");
            inputListBox4a.Items.Add("22.2");
            inputListBox4a.Items.Add("23.3");
            inputListBox4a.Items.Add("34.4");
            inputListBox4a.Items.Add("9.0");

            inputListBox5a.Items.Add("11.1");
            inputListBox5a.Items.Add("22.2");
            inputListBox5a.Items.Add("23.3");
            inputListBox5a.Items.Add("34.4");
            inputListBox5a.Items.Add("9.0");

            inputListBox6a.Items.Add("11.1");
            inputListBox6a.Items.Add("22.2");
            inputListBox6a.Items.Add("23.3");
            inputListBox6a.Items.Add("34.4");
            inputListBox6a.Items.Add("9.0");
        }
        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            //0
            try
            {
                int index = int.Parse(this.inputTextBox0a.Text);
                resultTextBox0.Text = Ex3cCalculations.Calc0(index);
            }
            catch
            {
                resultTextBox0.Text = "";
                MessageBox.Show("Invalid input");
            }

            //1
            try
            {
                resultTextBox1.Text = Ex3cCalculations.Calc1(inputTextBox1a.Text);
            }
            catch
            {
                resultTextBox1.Text = "";
                MessageBox.Show("Invalid input");
            }

            //2
            int[] numbers2 = { 11, 22, 23, 34, 10 };
            resultTextBox2.Text = Ex3cCalculations.Calc2(numbers2).ToString();

            //3
            double[] numbers3 = { 11.1, 22.2, 23.3, 34.4, 9.0 };
            try
            {
                int digit = int.Parse(this.inputTextBox3a.Text);
                resultTextBox3.Text = Ex3cCalculations.Calc3(numbers3, digit).ToString("0.0");
            }
            catch
            {
                resultTextBox3.Text = "";
                MessageBox.Show("Testing");
            }

            //4
            double[] numbers4 = new double[inputListBox4a.Items.Count];
            for (int i = 0; i < numbers4.GetLength(0); i++)
                numbers4[i] = Double.Parse(inputListBox4a.Items[i].ToString());
            resultTextBox4.Text = Ex3cCalculations.Calc3(numbers4, numbers4.GetLength(0)).ToString("0.0");

            //5
            double[] numbers5 = new double[inputListBox5a.Items.Count];
            for (int i = 0; i < numbers5.GetLength(0); i++)
                numbers5[i] = Double.Parse(inputListBox5a.Items[i].ToString());
            resultTextBox5.Text = Ex3cCalculations.Calc3(numbers5, numbers5.GetLength(0)).ToString("0.0");
            resultTextBox5.Text = Ex3cCalculations.Calc5(numbers5).ToString("0.0");

            //6
            double[] numbers6 = new double[inputListBox6a.Items.Count];
            for (int i = 0; i < inputListBox6a.Items.Count; i++)
            {
                numbers6[i] = Double.Parse(inputListBox6a.Items[i].ToString());
            }
            double[] aboveAvg = Ex3cCalculations.Calc6(numbers6);
            foreach (double number in aboveAvg)
            {
                resultListBox6.Items.Add(number);
            }
        }



        private void addItemButton4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double input = Double.Parse(this.inputTextBox4a.Text);
                this.inputListBox4a.Items.Add(input.ToString("n1"));
            }
            catch
            {

            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            inputListBox4a.Items.Add("11.1");
            inputListBox4a.Items.Add("22.2");
            inputListBox4a.Items.Add("23.3");
            inputListBox4a.Items.Add("34.4");
            inputListBox4a.Items.Add("9.0");

            inputListBox5a.Items.Add("11.1");
            inputListBox5a.Items.Add("22.2");
            inputListBox5a.Items.Add("23.3");
            inputListBox5a.Items.Add("34.4");
            inputListBox5a.Items.Add("9.0");

            inputListBox6a.Items.Add("11.1");
            inputListBox6a.Items.Add("22.2");
            inputListBox6a.Items.Add("23.3");
            inputListBox6a.Items.Add("34.4");
            inputListBox6a.Items.Add("9.0");

            inputTextBox0a.Focus();
        }

        private void inputTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
