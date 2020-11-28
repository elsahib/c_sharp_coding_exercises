namespace TechReturners {

    public class Person {

        public Person(string firstname, string lastname, string city, int age) {
            FirstNAme = firstname;
            LastName = lastname;
            City = city;
            Age = age;
        }

        public string FirstNAme 
        { get; set; }

        public string LastName
        { get; set; }

        public string City 
        { get; set; }

        public int Age
        {get; set;}
    }
}

