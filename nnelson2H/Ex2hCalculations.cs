using System;
using System.Linq;
using System.Text;

namespace nnelson2H
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result; 
        }
   
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
    
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }

        public static string DateCalc09(string strDate, string strDateb)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            try
            {
                dateA = DateTime.Parse(strDate);
                dateB = DateTime.Parse(strDateb);
                TimeSpan dateDif = dateA - dateB;
                result = dateDif.TotalDays.ToString() + " days";
            }
            catch { }

            return result;
        }

        public static string DateCalc10(string strDate, string strDateb)
        {
            string result = "Invalid input";
            try
            {   
                DateTime dateA = DateTime.Parse(strDate);
                DateTime dateB = DateTime.Parse(strDateb);

                if (dateA <= dateB)
                    result = "On time";
                else if (dateA > dateB)
                {
                    TimeSpan timeSpan = (dateA - dateB);
                    result = timeSpan.TotalDays.ToString() + " days past due";
                }
            }
            catch { }

            return result;
        }


        //String
        public static string StringCalc01(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                s = s.Remove(0, 1);
                s = s.Insert(0, "cr");
                result = s;
            }
            catch { }

            return result;
        }
        public static string StringCalc02(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                s = s.Remove(1, 1);
                s = s.Insert(1, "rit");
                result = s;
            }
            catch { }

            return result;
        }
        public static string StringCalc03(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                s = s.Substring(2, 4).ToUpper();
                result = s;
            }
            catch { }

            return result;
        }

        public static string StringCalc04(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            char pad = '*';
            try
            {
                s = s.PadLeft(10,pad);           //ten characters, pad with star.
                result = s;
            }
            catch { }

            return result;
        }

        public static string StringCalc05(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                s = s.Replace("(", "");
                s = s.Replace(")", "");
                s = s.Replace(" ", "");
                s = s.Replace("-", "");
                result = s;
            }
            catch { }

            return result;
        }
        public static string StringCalc06(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                s = s.Replace("(", "");
                s = s.Replace(")", "");
                s = s.Replace(" ", "");
                s = s.Replace("-", "");

                if (s.Length == 10)
                {
                    s = s.Insert(3, ".");
                    s = s.Insert(7, ".");
                    result = s.ToString();
                }
                else if (s.Length == 7)
                {
                    s = s.Insert(3, ".");
                    result = s.ToString();
                }
                else
                {
                    result = "Invalid input";
                }
            }
            catch { }

            return result;
        }
        public static string StringCalc07(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                s = s.ToLower();
                if (s.Contains("pioneer"))
                {
                    result = "Found";
                }
                else 
                    result = "Not found";
            }
            catch { }

            return result;
        }

        public static string StringCalc08(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                int a = s.IndexOf(", ");
                string d = s.Substring(a,2);

                if (d == ", ")
                    a = a + 2;
                int c = s.Length - a;
                string b = s.Substring(a, c);
                result = b;
            }
            catch { }

            return result;
        }

        public static string StringCalc09(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            try
            {
                int a = s.LastIndexOf(" ");
                int b = s.Length - a;
                result = s.Substring(a,b).Trim();
            }
            catch { }

            return result;
        }

        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append(s1);
            sb.Append(", ");
            sb.Append(s2);
            sb.Append(", ");
            sb.Append(s3);
            return sb.ToString();
        }

    }
}
