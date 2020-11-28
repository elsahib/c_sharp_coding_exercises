using System;

namespace TechReturners.Exercises
{
    public class Exercise002
    {
        public static bool IsFromManchester(Person person) 
        {
            // Add your code here!
            return person.City == "Manchester";
            throw new NotImplementedException();
        }

        public static bool CanWatchFilm(Person person, int ageLimit) 
        {
            // Add your code here!
            return person.Age > ageLimit;
            throw new NotImplementedException();
        }
    }
}
