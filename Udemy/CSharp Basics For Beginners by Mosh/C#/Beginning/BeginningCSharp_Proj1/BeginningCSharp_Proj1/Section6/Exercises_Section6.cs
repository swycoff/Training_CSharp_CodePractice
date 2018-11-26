using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1 {
    class Exercises_Section6 {



        /*
         * Exercises
Section 6, Lecture 56
Note: For any of these exercises, ignore input validation unless otherwise directed. Assume the user enters values in the format that the program expects.


1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
Depending on the number of names provided, display a message based on the above pattern.
*/
        public void Exercise1() {
            //Lists are flexible for adding an undefined amount of names.
            List<string> namesList = new List<string>();
            while (true) {
                Console.WriteLine("Enter a new name (Press Enter With No Input to Quit): ");
                string userInput = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(userInput)) {
                    break;
                }
                namesList.Add(userInput);

            }
            switch (namesList.Count) {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(namesList[0] + " Like your post");
                    break;
                case 2:
                    Console.WriteLine(namesList[0] + " and " + namesList[1] + " Like your post");
                    break;
                default:
                    Console.WriteLine(namesList[0] + " " + namesList[1] + " and " + (namesList.Count - 2) + " other people like your post");
                    break;
            }

        }

        /*2- Write a program and ask the user to enter their name. 
         * Use an array to reverse the name and then store the result in a new string. 
         * Display the reversed name on the console.
         */
        public void Exercise2() {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            char[] nameArray = new char[name.Count()];
            nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            foreach (char c in nameArray) {
                Console.Write(c);
            }
        }
        /*3- Write a program and ask the user to enter 5 numbers. 
        If a number has been previously entered, display an error message and ask the user to re-try. 
        Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
      */
        public void Exercise3() {
            List<int> numList = new List<int>();
            Console.WriteLine("Enter 5 non matching numbers");
            while (true) {
                int numberEntered = Convert.ToInt32(Console.ReadLine());
                while (numList.Contains(numberEntered)) {
                    Console.WriteLine("You already entered that number, please try again");
                    numberEntered = Convert.ToInt32(Console.ReadLine());
                }
                numList.Add(numberEntered);
                if (numList.Count == 5) {
                    Console.WriteLine("Here are your 5 unique numbers");
                    numList.Sort();
                    foreach (int num in numList) {
                        Console.Write(num + ", ");
                    }
                    break;
                }
            }
        }

    

        /*4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
         * The list of numbers may include duplicates. Display the unique numbers that the user has entered.
         */
         public void Exercise4() {
            List<int> numList = new List<int>();
            while (true) {
                Console.WriteLine("Enter a number or type 'Quit' to Exit");
                var enteredInfo = Console.ReadLine();
                if(enteredInfo.ToLower() == "quit") {
                    break;
                } else {
                    numList.Add(Convert.ToInt32(enteredInfo));
                }
            }

            //Creates a distint list and makes the value only the distinct numbers of the first list
            List<int> distinctOnly = new List<int>();
            distinctOnly = numList.Distinct().ToList();

            Console.WriteLine("The numbers entered were: ");
            foreach(int num in numList) {
                Console.Write(num + ",");
            }
            Console.WriteLine();
            Console.WriteLine("The distinct numbers entered were: ");
            foreach (int num in distinctOnly) {
                Console.Write(num + ",");
            }


        }
        /*5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
         * If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
         * otherwise, display the 3 smallest numbers in the list. 
         */
        public void Exercise5() {
            string[] elements;
            while (true) {
                Console.WriteLine("Please enter a list of 5 comma separated numbers (e.g. 5,1,9,2,10)");
                string userNumbersWithCommas = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(userNumbersWithCommas)) {
                    elements = userNumbersWithCommas.Split(',');
                    if (elements.Length != 5) {
                        Console.WriteLine("Invalid List, Please Re-Try");
                    } else {
                        break;
                    }
                }
            }
            //All the numbers the user entered
            List<int> numbers = new List<int>();            
            foreach (var number in elements) {
                numbers.Add(Convert.ToInt32(number));
            }
            //Holds only the smallest 3 numbers
            List<int> smallestNumbers = new List<int>();

  

            //We keep checking smallest numbers until we get the three smallest
            while(smallestNumbers.Count < 3) {
                //Assumes first number is the smallest as a starting comparison point
                int smallestNum = numbers[0];
                //Loops over the list of numbers and finds the smallest one in the list
                for (int i = 0; i < numbers.Count; i++) {
                    if (numbers[i] < smallestNum) {
                        smallestNum = numbers[i];
                    }
                }
                //We remove the smallest number found from the list and start the comparison again.
                numbers.Remove(smallestNum);
                //We add it to the smallest numbers list
                smallestNumbers.Add(smallestNum);
                
            }
            Console.WriteLine("These are the three smallest numbers in your list");
            foreach(int smallNum in smallestNumbers) {
                Console.Write(smallNum + ", ");
            }
            






        }



    }
}
