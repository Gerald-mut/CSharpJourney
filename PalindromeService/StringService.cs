// File: PalindromeService/StringService.cs
using System;

namespace PalindromeService
{
    public class StringService
    {
        // TODO: Implement this method
        public bool IsPalindrome(string input)
        {
            // HINT: You'll need to clean the string (lowercase, remove non-letters)
            string CleanedString = new string(input.ToLower().Where(char.IsLetter).ToArray());
            // and then compare the string to its reverse.
            // (You can use LINQ and new string(...) to reverse it)
            string ReversedString = new string(CleanedString.Reverse().ToArray());
            return CleanedString == ReversedString
            throw new NotImplementedException(); 
        }
    }
}