using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_word_is_a_palindrome
{
    using System;

    public class PalindromeWordChecker
    {
        public static bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            word = word.ToLower();

            string reversedWord = new string(word.Reverse().ToArray());

            return word == reversedWord;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check if it is a palindrome:");
            string word = Console.ReadLine();

            bool isPalindrome = IsPalindrome(word);

            if (isPalindrome == true)
            {
                Console.WriteLine("The word {0} is a palindrome.", word);
            }
            else
            {
                Console.WriteLine("The word {0} is not a palindrome.", word);
            }
        }
    }
 }
