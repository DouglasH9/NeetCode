using System;
using System.Text;

namespace TwoPointers
{
    public static class IsPalindrome
    {
        public static bool Check(string s)
        {
            if (s.Length == 1 && char.IsLetterOrDigit(s[0]))
                return true;

            char[] lowerChars = s.ToLower().ToCharArray();
            StringBuilder palinString = new StringBuilder();

            foreach(char element in lowerChars)
            {
                if (char.IsLetter(element))
                {
                    palinString.Append(element);
                }
            }

            int rightPointer = palinString.Length - 1;
            int leftPointer = 0;

            while (rightPointer - leftPointer > 0)
            {
                
                if (palinString[rightPointer] != palinString[leftPointer])
                    return false;
                rightPointer -= 1;
                leftPointer += 1;
            }
            return true;
            
        }
    }
}

