using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1 {
    public static class Operators {
        public static void divideIntegers() {
            int integerA = 10;
            int integerB = 3;
            //Because integers store whole numbers the result will be 3.
            Console.WriteLine("We are dividing {0} and {1} which are both integers", integerA, integerB);
            Console.WriteLine(integerA / integerB);
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void divideFloats() {
            int integerA = 10;
            int integerB = 3;
            var floatA = (float)integerA;
            var floatB = (float)integerB;
            Console.WriteLine("We are dividing {0} and {1} which are both floating point numbers", integerA, integerB);
            Console.WriteLine(floatA / floatB);
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void operatorPrecedence1() {
            //These default to ints
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine("Working with operator precedence.");
            Console.WriteLine(" A={0} B={1} and C={2}", a, b, c);
            Console.WriteLine("a + b *c");
            Console.WriteLine("Result: {0}", a + b * c);
            Console.WriteLine("Math dictates first b*c then add a");
            Console.WriteLine("If you want to change the precedence you can do so by adding () like (a+b) * c");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void comparisonOperators_GreaterThanLessThan() {
            //These default to ints
            var a = 1;
            var b = 2;
            Console.WriteLine("A={0} and B={1}",a,b);
            Console.WriteLine("a > b");
            Console.WriteLine(a > b);
            Console.WriteLine("The result of the > or < is always true or false");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void comparisonOperators_EqualToOrGreaterThan() {
            //These default to ints
            var a = 1;
            var b = 2;
            Console.WriteLine("A={0} and B={1}", a, b);
            Console.WriteLine("a == b");
            Console.WriteLine(a == b);
            Console.WriteLine("The result of the == comparison or != is always true or false");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void logicalOperators_And() {
            //These default to ints
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine("A={0} and B={1} and C={2}", a, b,c);
            Console.WriteLine("c > b && c > a");
            Console.WriteLine(c > b && c > a);
            Console.WriteLine("When using && both expressions tested must be true or the result will be false.");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void logicalOperators_Or() {
            //These default to ints
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine("A={0} and B={1} and C={2}", a, b, c);
            Console.WriteLine("c > b || a > b");
            Console.WriteLine(c > b || a > b);
            Console.WriteLine("When using || only one expression tested must be true for the result to be true.");
            Console.WriteLine();
            Console.ReadKey();
        }


    }
}
