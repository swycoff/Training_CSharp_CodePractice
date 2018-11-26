using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1.Section5.Exercises {
    public class Exercise_Lecture49 {

        public void Exercise1() {
            int countNumDivBy3 = 0;
            for(int i = 1; i <=100; i++) {
                if(i%3 == 0) {
                    countNumDivBy3++;
                }
            }
            Console.WriteLine("The total numbers between 1 and 100 equally divisable by 3 is: " + countNumDivBy3);
        }
        public void Exercise2() {
            string number;
            int sum = 0;
            while (true) {
                Console.WriteLine("Please enter a number or type 'ok' to exit: ");
                number = Console.ReadLine();
                if (number.ToLower() == "ok") {
                    break;
                }
                    sum += Convert.ToInt32(number);
            }
            Console.WriteLine("The sum of all numbers entered is: " + sum);
         
        }

        public void Exercise3() {
            //Compute factorials from number entered by the user
            int numberFromUser = 0;
            Console.WriteLine("Please enter a non negative integer number: ");
            numberFromUser = Convert.ToInt32(Console.ReadLine());

            int factorialTotal = numberFromUser;
            for (int i = numberFromUser-1; i != 0; i--){
                factorialTotal *= i;
            }
            Console.WriteLine("{0}! = {1}", numberFromUser, factorialTotal);
        }

        public void Exercise4() {
            System.Random rnd = new System.Random();
            int number = rnd.Next(1, 11);
            int chances = 4;
            int yourGuessNumberRound = 1;
            int yourGuess = 0;
            while(yourGuessNumberRound <= chances) {
                Console.WriteLine("Guess the number between 1 and 10: ");
                yourGuess = Convert.ToInt32(Console.ReadLine());
                if(yourGuess == number) {
                    Console.WriteLine("You won");
                    return;
                }
                yourGuessNumberRound++;
            }
            Console.WriteLine("You Lost");
        }

        public void Exercise5() {
            //Goal is to find the highest number that the user entered.
            string userNumbers = "";
            Console.WriteLine("Enter a series of numbers separated by commas:");
            userNumbers = Console.ReadLine();
            //returns a string array
            var numbers = userNumbers.Split(',');
       
            // Assume the first number is the max  (its a starting point for comparing two numbers
            var max = Convert.ToInt32(numbers[0]);

            foreach(var number in numbers) {
                int num = Convert.ToInt32(number);
                if(num > max) {
                    max = num;
                }
            }
            Console.WriteLine("Max is " + max);
        }
    }
}
