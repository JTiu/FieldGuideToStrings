using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldGuideToStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bethany";
            string lastName = "Smith";
            string fullName = firstName + " Jo " + lastName;
            Console.WriteLine($"{fullName}");
            Console.ReadLine();
            string doubleEmployeeName = string.Concat(firstName, firstName, lastName, lastName);
            Console.WriteLine(doubleEmployeeName);
            Console.WriteLine("");

            string employeeSwitchCasing = string.Concat(firstName.ToUpper(), lastName.ToLower()); 
            Console.WriteLine(employeeSwitchCasing);
            Console.ReadLine();


            String s1 = "We went to a bookstore, ";
            String s2 = "a movie, ";
            String s3 = "and a restaurant.";

            var s = String.Concat(s1, s2, s3);
            Console.WriteLine(s);
            Console.ReadLine();
            int length = employeeSwitchCasing.Length;
            Console.WriteLine(length);
            Console.ReadLine();

             if (fullName.Contains("beth") || lastName.Contains("mi"))
            {
                Console.WriteLine("Yeah");
            }
            Console.ReadLine();
        }
       
    }
}
