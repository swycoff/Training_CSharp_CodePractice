using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1 {
    public class Exercises_Section8 {

        /*Exercises
Section 8, Lecture 68

Note: For all these exercises, ignore input validation unless otherwise specified. Assume the user provides input in the format that the program expects.
1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
Work out if the numbers are consecutive.
For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message:
"Consecutive"; otherwise, display "Not Consecutive".

2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
If the user simply presses Enter, without supplying an input, exit immediately; otherwise, 
check to see if there are duplicates. If so, display "Duplicate" on the console.

 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
 A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time".
 If the user doesn't provide any values, consider it as invalid time.

4- Write a program and ask the user to enter a few words separated by a space. 
Use the words to create a variable name with PascalCase. For example, if the user types: 
"number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. 
So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

5- Write a program and ask the user to enter an English word. 
Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", 
the program should display 6 on the console.
*/

        public void Exercise1() {
            Console.WriteLine("Enter a few numbers separated by a hyphen -");
            string inputText = Console.ReadLine();
            string[] inputArray = inputText.Split('-');
            List<int> intList = new List<int>();
            foreach(string stringNum in inputArray) {
                intList.Add(Convert.ToInt32(stringNum));
            }

            bool consASC = true;
            bool consDESC = true;
        
            for(int i = 0; i < intList.Count -1; i++) {
                if(intList[i] == (intList[i + 1] - 1) && consASC) {
                    //This is going acending order
                    Console.WriteLine("i (place in list) = " + i);
                    Console.WriteLine("The item in this place is a value of: " + intList[i]);
                    Console.WriteLine("The item in the next spot up in the list is a  place is a value of: " + intList[i+1]);
                    consDESC = false;
                } else if(intList[i] == (intList[i +1] + 1) && consDESC) {
                    //This is going in decending order
                    Console.WriteLine("i (place in list) = " + i);
                    Console.WriteLine("The item in this place is a value of: " + intList[i]);
                    Console.WriteLine("The item in the next spot up in the list is a  place is a value of: " + intList[i + 1]);
                    consASC = false;
                } else {
                    Console.WriteLine("Not Consecutive");
                    return;
                }                
            }
            Console.WriteLine("Consecutive");
        }

        public void Exercise2() {
            string[] stringNum;
            List<int> listInt = new List<int>();
            Console.WriteLine("Enter a few numbers separated by a hyphen (-)");
            string userInput = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(userInput)) {
                return;
            } else {
                //Check for duplicates
                stringNum = userInput.Split('-');
                foreach(string num in stringNum) {
                    if (listInt.Contains(Convert.ToInt32(num))) {
                        Console.WriteLine("Duplicate");
                        return;
                    }else {
                        listInt.Add(Convert.ToInt32(num));
                    }
                }
            }
        }

        public void Exercise3() {
            Console.WriteLine("enter a time value in the 24 - hour time format(e.g. 19:00)");
            string userInput = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(userInput)) {
                Console.WriteLine("Invalid Time");
                return;
            } 
            try {
                DateTime time = Convert.ToDateTime(userInput);
                Console.WriteLine("OK");
            } catch (FormatException e) {
                Console.WriteLine("Invalid Time");
                return;
            }

        }
        public void Exercise4() {
            Console.WriteLine("Enter a few words with spaces inbetween them");
            string userInput = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(userInput)) {
                Console.WriteLine("Enter a few words with spaces inbetween them");
            }
            string userInputLower = userInput.ToLower();
            //splits each word into a spot in the array
            var stringArray = userInputLower.Split(' ');
            
            var finalString = "";

            foreach(string st in stringArray) {
                var charArray = st.ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);
                foreach(char c in charArray) {
                    finalString = finalString + c;
                }                
            }
            Console.WriteLine(finalString);

        }
        public void Exercise5() {
            Console.WriteLine("Enter an English Word");
            string userInput =  Console.ReadLine();
            userInput = userInput.ToLower();
            var stringArray = userInput.ToCharArray();
            int vowelCount = 0;
            foreach(char c in stringArray) {
                if(c == 'a' || c == 'e' || c== 'i' || c=='o' || c == 'u') {
                    vowelCount++;
                }
            }
            Console.WriteLine("The number of vowels you entered is: " + vowelCount);
        }
    }
}
