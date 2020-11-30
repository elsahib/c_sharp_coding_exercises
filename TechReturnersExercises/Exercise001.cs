using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word)
        {
            var firstLetter = word.Substring(0, 1);
            var restOfTxt = word.Substring(1);
            var result = firstLetter.ToUpper() + restOfTxt;
            return result;
        }

        public static String GenerateInitials(String firstName, String lastName)
        {
            var firstNameInitial = firstName.Substring(0,1);
            var lastNameInitial = lastName.Substring(0,1);
            var result = firstNameInitial.ToUpper() + "." + lastNameInitial.ToUpper();
            return result;
        }

        public static double AddVat(double originalPrice, double vatRate)
        {
            return vatRate >0?Math.Round(originalPrice * (vatRate/100 + 1) * 100) / 100: originalPrice;
        }

        public static String Reverse(String sentence)
        {
            char[] strToArray = sentence.ToCharArray();
            Array.Reverse( strToArray );
            var result  = new string( strToArray );
            return result;
        }

        public static int CountLinuxUsers(List<User> users)
        {
            var result  = 0;
            foreach (var item in users){
                if (item.Type == ("Linux")){result+= 1;}
            }
            return result;
        }
    }
}
