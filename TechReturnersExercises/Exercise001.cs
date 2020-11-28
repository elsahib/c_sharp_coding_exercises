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
            // Add your code here!
            throw new NotImplementedException();
        }

        public static String GenerateInitials(String firstName, String lastName)
        {
            var firstNameInitial = firstName.Substring(0,1);
            var lastNameInitial = lastName.Substring(0,1);
            var result = firstNameInitial.ToUpper() + "." + lastNameInitial.ToUpper();
            return result;
            // Add your code here!
            throw new NotImplementedException();
        }

        public static double AddVat(double originalPrice, double vatRate)
        {
            // Add your code here!
            return vatRate >0?Math.Round(originalPrice * (vatRate/100 + 1) * 100) / 100: originalPrice;
            throw new NotImplementedException();
        }

        public static String Reverse(String sentence)
        {
            // Add your code here!
            char[] strToArray = sentence.ToCharArray();
            Array.Reverse( strToArray );
            var result  = new string( strToArray );
            return result;
            throw new NotImplementedException();
        }

        public static int CountLinuxUsers(List<User> users)
        {
            // Add your code here!
            var result  = 0;
            foreach (var item in users){
                if (item.Type == ("Linux")){result+= 1;}
            }
            return result;
            throw new NotImplementedException();
        }
    }
}
