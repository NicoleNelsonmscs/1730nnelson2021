using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nnelsonex3b
{
    public class Ex3bCalculations
    {
        //0
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;

            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }
        //1
        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
        }
        //2
        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
        //4
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = 0.0;
            celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
        //5
        public static void CelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            fahrenheit = celsius * 1.8 + 32;
        }
        //6
        public static decimal GrossPay(decimal hours, decimal rate)
        {
            decimal moneyEarned = 0;

            if (hours <= 40m)
            {
                moneyEarned = (hours * rate);
            }
            if (hours > 40m)
            {
                moneyEarned = (hours * rate + (hours - 40m) * rate * 0.5m);
            }

            return moneyEarned;
        }
        //7
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }

            return total;
        }
        //8
        public static decimal GrossPay(string strNumbers, decimal rate)
        {
            decimal totalHours = 0;
            int startIndex = 0;
            decimal moneyEarned = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = Decimal.Parse(strNumber);
                totalHours += number;
                startIndex = endIndex + 1;
            }


            if (totalHours <= 40m)
            {
                moneyEarned = (totalHours * rate);
            }
            if (totalHours > 40m)
            {
                moneyEarned = (totalHours * rate + (totalHours - 40m) * rate * 0.5m);
            }

            return moneyEarned;
        }
        //3
        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
        }
    }
}