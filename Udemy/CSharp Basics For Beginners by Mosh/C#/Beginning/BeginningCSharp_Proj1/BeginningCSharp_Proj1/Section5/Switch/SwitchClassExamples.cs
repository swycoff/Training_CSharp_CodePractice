using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1.Section5.Switch {
    class SwitchClassExamples {

        public void swtichExample1() {
            var season = Season.Fall;
            switch (season) {
                case Season.Fall:
                    Console.WriteLine("The season is Fall");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer is the perfect time to go to the beach");
                    break;
                default:
                    Console.WriteLine("I don't understand the input");
                    break;
            }
        }

        public void swtichExample2() {
            var season = Season.Fall;
            switch (season) {
                //This means that if it is fall OR Summer it will display we have a promotion - it falls through
                case Season.Fall:          
                case Season.Summer:
                    Console.WriteLine("We have a promotion");
                    break;
                default:
                    Console.WriteLine("I don't understand the input");
                    break;
            }
        }

    }
}
