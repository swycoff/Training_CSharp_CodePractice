using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {

            int a = 1;
            int b = a++;
            Console.WriteLine("A = {0}" ,a);
            Console.WriteLine("B = {0}" ,b);
            Console.ReadKey();
        }
    }
}
