using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1.Section4.ValueAndReferenceTypes {
    class ValueAndReferenceTypeExamples {
        public void demonstrateValueTypeCopy() {
            int a = 10;
            int b = a;
            b++;
            //A should still be 10 and b will be 11.
            //This is because for a value type the value of A is copied into the variable B.  Now you have two separate variables.
            Console.WriteLine(string.Format("A is: {0}, B is: {1}", a, b));
        }

        public void DemonstrateArrayCopy_ReferenceType() {
            //Strings and Arrays are classes - so they are reference types
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            Console.WriteLine(string.Format("Array1[0] = {0}, Array1[1] = {1}, Array1[2] = {2}", array1[0], array1[1], array1[2]));
            Console.WriteLine(string.Format("Array2[0] = {0}, Array2[1] = {1}, Array2[2] = {2}", array2[0], array2[1], array2[2]));


        }
        public static void Increment(int number) {
            //notice this method doesn't return anything.  So it will add 10 to number but number really only exists in this method.
            //When you pass in number, its a value type so its actually a new variable in memory with a copy of the value of what you passed in.
            number += 10;
        }
        public static void MakeOld(Person person) {
            //because person is a reference type, the object that you pass in and the person you see above will point to the same location in memory
            //That means even though this doesn't return anything, you are still making changes to the object you passed in.
            person.Age += 10;
        }
    }
}
