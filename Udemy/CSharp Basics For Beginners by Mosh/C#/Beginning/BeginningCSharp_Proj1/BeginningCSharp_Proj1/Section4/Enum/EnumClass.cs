using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp_Proj1.Section4.Enum {
    public enum ShippingMethod {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    public class EnumClass {
        public void DisplayEnumValue() {
            Console.WriteLine(ShippingMethod.RegularAirMail);
            Console.WriteLine(ShippingMethod.RegisteredAirMail);
            Console.WriteLine(ShippingMethod.Express);
            Console.ReadKey();
        }
        public void CastNumberToShippingMethod(int i) {
            Console.WriteLine((ShippingMethod)i);
            Console.ReadKey();
        }
        public void CastShippingMethodToIntValue() {
            Console.WriteLine((int)ShippingMethod.Express);
            Console.ReadKey();
        }
        public void ParseStringToShippingMethod() {
            //Parsing means to take a string and convert it to something else.
            string shipMethod = "Express";
            Console.WriteLine("Before Parsing String: " + shipMethod);

            //Class called Enum that has a number of static members
            //Type is one parameter - Type is a class in C# that  represents meta data about other types
            //Whenever you see type, you can use TypeOf operator
            //The second is a string - which we pass the string we want to convert
            //The third is that it returns an object, so we need to cast it to the object type we want it to be (the enum)
            //Hovering over Var you will see that the type of shipType is Enum.ShippingMethod
            var shipType = (ShippingMethod)System.Enum.Parse(typeof(ShippingMethod), shipMethod);
            Console.WriteLine("This is the converted string to a type Enum ShippingMethod: " + shipType);
            Console.ReadKey();
      
        }

    }
}
