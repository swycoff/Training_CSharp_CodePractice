using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1.Section5.IFandElse {

    class IfElse {
        public void ifElseDemo1() {
            //Goal : Define hour in a 24 hour time format
            int hour = 10;
            if (hour > 0 && hour < 12) {
                Console.WriteLine("It's Morning");
            } else if(hour >=12 && hour < 18) {
                Console.WriteLine("It's Afternoon");
            } else if(hour > 18) {
                Console.WriteLine("It's evening.");
            }
        }

        public void ifElseDemo2() {
            bool isGoldCustomer = true;
            float price;

            if (isGoldCustomer) {
                price = 19.95f;
            }else {
                price = 29.95f;
            }

            //Can re-write the above code as this
            //This says test the condition "(Condition)" if it's true then return the first option, if its false do the second.
            float price2 = (isGoldCustomer) ? 19.95f : 29.95f;
        }


        
    }
}
