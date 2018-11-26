using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1.Section5.IterationLoops {
    class Loops {
        public void DisplayEvenListOfNumbersFrom1to10() {
            for(var i =1; i <=10; i++) {
                if(i%2 ==0) {
                    //It's an even number
                    Console.WriteLine(i);
                }
            }
        }
        public void DisplayEvenListOfNumbersFrom10to1() {
            for (var i = 10; i >=1; i--) {
              if(i%2 == 0) {
                    //It's an even number
                    Console.WriteLine(i);
                }
            }
        }
        public void DisplayOddListOfNumbersFrom1to10() {
            for (var i = 1; i<= 10; i++) {
                if (i % 2 != 0) {
                    //It's an odd number
                    Console.WriteLine(i);
                }
            }
        }

        public void ForEachLoop1() {
            var name = "John Smith";
            //We want to display each character on a new line
            foreach(var ch in name) {
                Console.WriteLine(ch);
            }
        }

        public void ForEachLoop2() {
            var array1 = new int[4] { 1, 2, 3, 4 };
            foreach (var num in array1) {
                Console.WriteLine(num);
            }
        }

        public void WhileLoop1() {
            var i = 0; // counter variable
            while (i <= 10) {
                if( i  %2 == 0) {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
        public void WhileLoop2() {
            while (true) {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input)) {
                    break;
                }
                Console.WriteLine("@Echo: " + input);
            }
        }
        public void WhileLoop3() {
            while (true) {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input)) {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;

            }
        }
    }
}
