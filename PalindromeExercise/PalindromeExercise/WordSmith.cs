using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            if (word == reversed)
            {
                return true;
            }
            else return false;
        }
    }
}
