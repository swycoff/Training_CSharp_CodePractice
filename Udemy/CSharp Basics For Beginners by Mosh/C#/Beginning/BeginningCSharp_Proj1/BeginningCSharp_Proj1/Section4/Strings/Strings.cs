using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1.Section4.Strings {
    public class Strings {

        public void stringVsString() {

            //Regardless of which one you use - they behaive exactly the same.

            //This is the C#  class string keyword (System.string)
            string name = "myName";

            //This is the string class in the .NET framework
            String name2 = "myName";
        }
        public void intVsInt32() {
            //These are the same thing - just using C# or .Net
            Int32 i;
            int j;

        }

        public void stringConcat1() {
            string a = "baby's";
            string b = "are";
            string c = "cute";
            string d = a + b + c;
            Console.WriteLine(d);
            Console.ReadKey();
        }

        public void stringConcat2() {
            string a = "baby's";
            string b = "are";
            string c = "cute";
            string d = a + b + " Not " +  c;
            Console.WriteLine(d);
            Console.ReadKey();
        }

        public void stringConcat3() {
            string firstName = "Firstname";
            string lastName = "LastName";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            Console.ReadKey();
        }
        public void stringConcat4() {
            string firstName = "Firstname";
            string lastName = "LastName";
            string fullName = string.Format("{0}, {1} Is Cool", firstName, lastName);
            Console.WriteLine(fullName);
            Console.ReadKey();

        }

        public void stringConcat5() {
            string[] names = new string[3] { "John", "Jack", "Mary" };
            string allNames = string.Join(" , ", names);
            Console.WriteLine(allNames);
            Console.ReadKey();
        }

        public void EscapeFormat() {
            var text = "Hi John \nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder1\\folder6";
            Console.WriteLine("This is a regular string with escape characters.");
            Console.WriteLine(text);
            var verbetumString = @"Hi John
Look into the following paths
C:\folder1\folder2
c:\folder1\folder6";
            Console.WriteLine("This is a verbetum string");
            Console.WriteLine(verbetumString);
            Console.ReadKey();

        }
    }
}
