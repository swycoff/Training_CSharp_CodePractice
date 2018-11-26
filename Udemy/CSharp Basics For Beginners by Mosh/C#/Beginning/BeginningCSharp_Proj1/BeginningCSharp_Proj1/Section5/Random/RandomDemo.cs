using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1.Section5.Random {
    public class RandomDemo {
        public void randomDemo1() {
            var random = new System.Random();
            //returns a random integer
            int one = random.Next();
            Console.WriteLine(one);

            //create a byte array of any size and fill it with random numbers
            byte[] byteArray1 = new byte[10];
            random.NextBytes(byteArray1);
            Console.WriteLine(String.Join(",", byteArray1));

            //creates a random double number between 0 and 1
            var doubleNum = random.NextDouble();
            Console.WriteLine(doubleNum);
        }
        public void randomDemo2() {
            var random = new System.Random();
            for(var i = 0; i < 10; i++) {
                Console.WriteLine(random.Next());
            }
        }
        public void randomDemo3() {
            var random = new System.Random();
            for (var i = 0; i < 10; i++) {
                Console.WriteLine(random.Next(1, 10));
            }
        }
        public void randomDemo4() {
           //ASCII Intro
           //ascii-code.com
           //All characters are associated to a number
           //This number is eventually what the computer understands
                Console.WriteLine((int)'a');

            var random = new System.Random();
            for (var i = 0; i < 10; i++) {
                Console.Write((char)random.Next(97, 122));
            }

        }
        public void randomDemo5() {
  
            var random = new System.Random();
            for (var i = 0; i < 10; i++) {
                //We have 26 characters in the alphabet
                //'a' is represented to the computer as a number, so if we add that number to a random number, we will get a random character.
                Console.Write((char)('a' + random.Next(0, 26)));
                
            }
            Console.WriteLine();
        }
        public void randomDemo6() {
            const int pwdLength = 10;

            //Strings are immutable
            //So let's store our results in an array
            char[] buffer = new char[pwdLength];
            
            var random = new System.Random();
            for (var i = 0; i < pwdLength; i++) {
                //We have 26 characters in the alphabet
                //'a' is represented to the computer as a number, so if we add that number to a random number, we will get a random character.
                buffer[i] = (char)('a' + random.Next(0, 26));          
            }
            //A different way to create a string (something for your toolbox)
            //the string keyword maps to a string class in the .net framework.
            //We can create a new string class instance.
            var password = new string(buffer);

            //Now create the string 
            Console.WriteLine(password);
        }
    }
}
