using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Person person1 = new Person("Simon", 23, 30493020);
            Person person2 = new Person("Mads", 21, 59403291);

            System.Console.WriteLine($"Person 1 name is {person1.Name}, he is {person1.Age} years old and his telephonenumber is {person1.TelephoneNumber}");
            System.Console.WriteLine($"Person 2 name is {person2.Name}, he is {person2.Age} years old and his telephonenumber is {person2.TelephoneNumber}");
            
            person1.IncreaseAge(); // Her bliver der kaldt IncreaseAge
            person1.IncreaseAge(); // Her bliver der kaldt IncreaseAge
            person2.IncreaseAge(); // Her bliver der kaldt IncreaseAge

            System.Console.WriteLine($"We went to the future and {person1.Name} is now {person1.Age} years old");
            System.Console.WriteLine($"We also went to another time periode, where {person2.Name} is now {person2.Age} years old");


            // The LAST line of code should be ABOVE this line
        }
    }
}