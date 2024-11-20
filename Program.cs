using ChooseYourFighter.KataProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourFighter
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DisemvowelTrollsTask.DisemvowelTrolls("This website is for losers LOL!"));
            //Console.ReadKey();

            //Console.WriteLine(SuperEasy("1.2"));

            //Console.WriteLine(GirlsAge("8 years old"));

            //Console.WriteLine(PinValidation("1234"));

            Console.WriteLine(GetMiddleCharacters("james"));

            Console.ReadKey();
        }
        //static string SuperDuperEasy(string number)
        //{
        //    if (double.TryParse(number, out double numValue)) return (numValue * 50 + 6).ToString();
        //    else return "Error";
        //}
        //static int SuperEasy(int number)
        //{
        //    if (!number.ToString().Any(char.IsDigit)) return number * 2;
        //    else return -1;
        //}

        //        static int GirlsAge(string age) => (int)Char.GetNumericValue(age[0]);

        static bool PinValidation(string pin)
        {
            if (pin.Length == 4 || pin.Length == 6)
            {
                foreach (char c in pin)
                {
                    if (!char.IsDigit(c)) return false;
                }
                return true;
            }
            else return false;
        }
        static string GetMiddleCharacters(string str)
        {
            int len = str.Length;
            if (!(len % 2 == 0))
            {
                return str[(len / 2)].ToString();
            }
            else
            {
                return str.Substring(len / 2 - 1, len / 2);
            }
        }
    }
}
