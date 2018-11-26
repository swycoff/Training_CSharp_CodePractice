using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BeginningCSharp_Proj1 {
    class Exercises_Section9 {

        /*1- Write a program that reads a text file and displays the number of words.

2- Write a program that reads a text file and displays the longest word in the file. 
*/
        public void Exercise1() {
           var path = @"C:\Users\siwycoff\Documents\GitHub\Training_CSharp_CodePractice\Udemy\CSharp Basics For Beginners by Mosh\C#\Beginning\BeginningCSharp_Proj1\BeginningCSharp_Proj1\Files\TextFile1.txt";
            string text = File.ReadAllText(path);
            var stringArray = text.Split(' ');
            Console.WriteLine(stringArray.Count());
        }

        public void Exercise2() {
            var path = @"C:\Users\siwycoff\Documents\GitHub\Training_CSharp_CodePractice\Udemy\CSharp Basics For Beginners by Mosh\C#\Beginning\BeginningCSharp_Proj1\BeginningCSharp_Proj1\Files\TextFile1.txt";
            string text = File.ReadAllText(path);
            var stringArray = text.Split(' ');
            string longestWord = stringArray[0];
            for(int i=0; i<stringArray.Count() -1; i++) {
                if (stringArray[i].Count() < stringArray[i + 1].Count()) {
                    longestWord = stringArray[i + 1];
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}
