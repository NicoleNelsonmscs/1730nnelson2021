using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nnelson2f1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);

            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2 if {block}
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            string status = "Standard rate: ";

            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: "+ discountPercent.ToString("n2");
            }
            return status ;
        }

        public static string Calc03(string input)
        {
            // #3 if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);

            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            //#4 if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);

            if (subtotal >= 100m && subtotal < 200m)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;

            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            //#5 Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);

            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            //#6 Nested if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            discountPercent = 0m;
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;

            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else        //customerType isn't R
                discountPercent = 0.4m;

            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            //#7 Validate input: non-empty string
            decimal ethereum = 0m;
            if (input != "")
            {
                decimal dollars = decimal.Parse(input);
                ethereum = 200m * dollars;
                return ethereum.ToString("n2");
            }
            return "Invalid input";
        }
        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal total = 0m;
            if(inputA != "" && inputB != "")
            {
                total = decimal.Parse(inputA) * decimal.Parse(inputB);
                    if(total < 50)
                    {
                        total = (decimal.Parse(inputA) * decimal.Parse(inputB)) + 5;
                    }
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            decimal bill = 0m;
            if(inputA != "" && inputB != "" && decimal.Parse(inputB) > decimal.Parse(inputA))
            {
                decimal difference = decimal.Parse(inputB) - decimal.Parse(inputA);
                bill = difference * 0.1m;
                return bill.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            double result = 0.0;
            if(inputA != "" && inputB != "" && decimal.Parse(inputB) > 0 && decimal.Parse(inputA) > 0)
            {
                if (double.Parse(inputB) > double.Parse(inputA))
                {
                   result = double.Parse(inputB) / double.Parse(inputA);
                   return result.ToString("n2");
                }
                result = double.Parse(inputA) / double.Parse(inputB);
                return result.ToString("n2");
            }
            return "Invalid input";
        }
    }
}
