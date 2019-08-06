using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderByte_CodeChallenges {
    public static class StringReverse {
        public static string ReverseString(string normal) {
            string reversed = "";
            List<char> stringCharList = normal.ToList<char>();
           for(int i=stringCharList.Count-1; i >=0; i--) {
                reversed += stringCharList[i];
            }
            return reversed;
        }

    
        public static string ReverseString2(string str) {
            string reverse = String.Empty;
            for (int i = str.Length - 1; i >= 0; i--) {
                reverse += str[i];
            }
            return reverse;        
    }

}
}
