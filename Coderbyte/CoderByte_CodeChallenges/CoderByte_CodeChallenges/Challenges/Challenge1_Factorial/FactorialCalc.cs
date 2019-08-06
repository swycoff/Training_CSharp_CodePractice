using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderByte_CodeChallenges {
    public class FactorialCalc {
        public static int FirstFactorial(int num) {
            int answer = num;
            for (int i = num; i != 1; i--) {
                answer = answer * (i - 1);
            }
            return answer;
        }
    }
}
