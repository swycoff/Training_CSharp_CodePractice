using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1.Section5.Exercises {
    public enum ImageOrientation {
        Portrait,
        Landscape
    }
    public class Exercise_Lecture43 {

        public void exercise1Execute() {
            /* Write a program and ask the user to enter a number. 
             * The number should be between 1 to 10.If the user enters a valid number, display "Valid"
             * on the console.Otherwise, display "Invalid". (This logic is used a lot in applications 
             * where values entered into input boxes need to be validated.)
                */
            Console.WriteLine("Please enter a number between 1 and 10");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number >= 1 && number <= 10) {
                Console.WriteLine("Valid");
                Console.ReadKey();
            } else {
                Console.WriteLine("Invalid");
                Console.ReadKey();

            }
        }

        public void Exercise2Execute() {
            // Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //one way
            if(number1 > number2) {
                Console.WriteLine("The number {0} is greater than the number {1}", number1, number2);
                Console.ReadKey();
            } else {
                Console.WriteLine("The number {0} is greater than the number {1}", number2, number1);
                Console.ReadKey();
            }

            //Alternate way
            int max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("The max is: " + max);
            Console.ReadKey();
        }

        public void Exercise3Execute() {
            //3 - Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.
            Console.WriteLine("Enter the width of an image");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of an image");
            int height = Convert.ToInt32(Console.ReadLine());
            if(height > width) {
                Console.WriteLine("This image is in portrait");
                Console.ReadKey();
            }else {
                Console.WriteLine("This image is in landscape");
                Console.ReadKey();
            }
        }

        public void Exercise3ExecuteAlternate() {
            //3 - Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.
            Console.Write("Enter the width of an image");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height of an image");
            int height = Convert.ToInt32(Console.ReadLine());
            var orientation = (width > height) ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is: " + orientation);
        }

        public void Exercise4Execute() {
            /*- Your job is to write a program for a speed camera. 
             * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
             * Write a program that asks the user to enter the speed limit. 
             * Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit,
             * program should display Ok on the console. If the value is above the speed limit, the program 
             * should calculate the number of demerit points. For every 5km/hr above the speed limit, 
             * 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, 
             * the program should display License Suspended.
              */
            Console.WriteLine("Enter the speed limit");
            int SpeedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cars speed");
            int CarSpeed = Convert.ToInt32(Console.ReadLine());
            int demerit = 0;
            if (CarSpeed <= SpeedLimit) {
                Console.WriteLine("OK");
                Console.ReadKey();
            } else {
                //Car speed is > speed limit
                if ((CarSpeed - SpeedLimit) > 5) {
                    demerit = (CarSpeed - SpeedLimit) / 5;
                    Console.WriteLine("Demerit = " + demerit);
                    Console.ReadKey();
                }
                if (demerit > 12) {
                    Console.WriteLine("License Suspended");
                    Console.ReadKey();
                }
            }
        }
        public void Exercise4ExecuteAlternate() {
            /*- Your job is to write a program for a speed camera. 
             * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
             * Write a program that asks the user to enter the speed limit. 
             * Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit,
             * program should display Ok on the console. If the value is above the speed limit, the program 
             * should calculate the number of demerit points. For every 5km/hr above the speed limit, 
             * 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, 
             * the program should display License Suspended.
              */
            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
}
