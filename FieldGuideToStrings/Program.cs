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
            string firstName = "BeThAnY";
            string lastName = "Smith";
            string fullName = firstName + " Jo " + lastName;
            Console.WriteLine($"{fullName}");

            string doubleEmployeeName = string.Concat(firstName, firstName, lastName, lastName);
            Console.WriteLine(doubleEmployeeName);
            Console.WriteLine("");

            string employeeSwitchCasing = string.Concat(firstName.ToUpper(), lastName.ToLower());
            Console.WriteLine(employeeSwitchCasing);



            string s1 = "We went to a b\to\to\tkstore, ";
            string s2 = "a movie, ";

            string s3 = "and a restaurant.";
            string s4 = "a movie, ";
            var s = String.Concat(s1, s2, s3);
            Console.WriteLine(s);

            int length = employeeSwitchCasing.Length;
            Console.WriteLine(length);


            if (fullName.Contains("beth") || lastName.Contains("mi"))
            {
                Console.WriteLine("Yeah");
            }

            string subString = fullName.Substring(5, 2);
            Console.WriteLine(subString.ToUpper());

            string nameUsingInterpolation = $"{firstName.ToUpper()}-{firstName.ToLower()}-{length}-----{employeeSwitchCasing.ToUpper().Trim()}";
            Console.WriteLine(nameUsingInterpolation);


            //equality check

            Console.WriteLine("Are equal?\t" + (s1 == s2));
            Console.WriteLine("Are equal?\t" + (s2 == s4));
            Console.WriteLine("Are equal?\t" + (s2 == "a movie, "));
            Console.WriteLine("Are equal?\t" + s2.Equals("a mmmovie, "));
            Console.WriteLine("Are equal?\t" + s2.Equals("a movie, "));

            string name = "'JT";
            string anotherName = name;
            name += " Tiu'";
            Console.WriteLine("\nname: " + name.ToLower() + "\tanotherName : " + anotherName);
            

            string indexes = string.Empty;
            for (int i = 0; i < 25; i++)
            {
                indexes += i.ToString();
            }
           
            string first = "James\n";
            string last = "Jones\n";
            StringBuilder builder = new StringBuilder();
            builder.Append("Last name: \n");
            builder.Append(last);
            builder.Append("First name: \n");
            builder.Append(first);
            string result = builder.ToString();
            Console.WriteLine(result);

                 Console.ReadLine();

        }
    }
}
