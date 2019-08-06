using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderByte_CodeChallenges {
    public static class AlphabetPosition {
        public static void LetterChanges(string stringToEdit) {
            string newString = String.Empty;
            //First Change Letters to the next letter in the alphabet / then convert vowels to upper case
            foreach(char c in stringToEdit) {
                string vowel = "aeiou";
                if((c >=65 && c <= 90) || (c >= 97 && c <= 122) || (c >= 97 && c <= 122)) {  //checks to see if its a character based on ASCII code
                    char newChar= (char)(c + 1);   //a char will implicitly cast to an int when you do +1, then we cast it back to a char.  Adding 1 means moving it to the next letter in the alphabet
                    if (vowel.IndexOf(newChar) >0){  //in the vowel string, we see if there is an index of our current character (is it a vowel), if it is it will return an index > 0
                        newString += newChar.ToString().ToUpper();
                    }else { //If its not a vowel we just add the lowercase character to our string.
                        newString += newChar;
                    }
                } else { //This means it wasn't a character in the alphabet and we just add it to the string (IE special character or number etc.)
                    newString += c;
                }                
            }
        }


    //    https://www.geeksforgeeks.org/program-check-input-character-alphabet-digit-special-character/

    //    // CHECKING FOR ALPHABET 
    //if ((input_char >= 65 && input_char <= 90) 
    //    || (input_char >= 97 && input_char <= 122)) 
    //    cout << " Alphabet "; 
  
    //// CHECKING FOR DIGITS 
    //else if (input_char >= 48 && input_char <= 57) 
    //    cout << " Digit "; 
  
    //// OTHERWISE SPECIAL CHARACTER 
    //else
    //    cout << " Special Character "; 
//}

}
}
