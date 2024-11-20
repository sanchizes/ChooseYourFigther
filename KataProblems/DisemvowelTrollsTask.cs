using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourFighter.KataProblems
{
    public class DisemvowelTrollsTask
    {
        public static string DisemvowelTrolls(string str)
        {
            char[] vowels = {'a', 'e', 'u', 'i', 'o', 'O', 'I'};
            char[] result = str.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                if (vowels.Contains(result[i]))
                {
                    result[i] = '\0';
                }
            }
            return new string(result).Replace("\0", "");
        }
    }
}
