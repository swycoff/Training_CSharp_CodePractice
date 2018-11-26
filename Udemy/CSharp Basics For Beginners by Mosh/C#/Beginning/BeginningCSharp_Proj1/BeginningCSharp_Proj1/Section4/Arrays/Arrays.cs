using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1.Section4.Arrays {
    public class Arrays {
        public void DisplayNumbersInArray() {
            int[] array1 = new int[3] { 0, 1, 2 };
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);
            Console.ReadKey();
        }

        public void BoolArray() {
            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]); // note we set this to true
            Console.WriteLine(flags[1]); //note this defaults to false
            Console.WriteLine(flags[2]); //note this defaults to false
            Console.ReadKey();

        }

        public void StringArray() {
            var names = new string[3] { "Jack", "John", "Mary" };          
            Console.WriteLine(names[0]); // note we set this to true
            Console.WriteLine(names[1]); //note this defaults to false
            Console.WriteLine(names[2]); //note this defaults to false
            Console.ReadKey();

        }
    }
}
