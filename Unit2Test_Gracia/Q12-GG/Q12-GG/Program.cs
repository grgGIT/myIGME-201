using System;
using System.Collections.Generic;
using System.Globalization;
using System.Collections;

namespace Q12_GG
{
    
        public class Birthday
        {
            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();

            public Birthday()
            {
                // Add some friend's birthdays to the SortedList
                friendBirthdays.Add("Greg", new DateTime(1961, 5, 15));
                friendBirthdays.Add("Ryan", new DateTime(1997, 10, 8));
                friendBirthdays.Add("Geoff", new DateTime(2002, 12, 8));
                friendBirthdays.Add("Austin", new DateTime(1998, 11, 4));

          
                foreach (var pair in friendBirthdays)
                {
                    string name = pair.Key;
                    DateTime birthday = pair.Value;
                    string formattedBirthday = birthday.ToString("MM/dd/yyyy");
                    Console.WriteLine($"{name}: {formattedBirthday}");
                }
           

        }
			  
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Birthday birthday = new Birthday();
            
        }
    }
}
