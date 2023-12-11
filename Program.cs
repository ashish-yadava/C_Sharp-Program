using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "";
            Console.WriteLine("Enter a string");
            str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string str_reverse = new string(arr);

            if (str.ToLower() == str_reverse.ToLower()) //(str.Equals(str_reverse)) 
            {
                Console.WriteLine(str + " --> It's A Palindrome String..");
            }
            else
            {
                Console.WriteLine(str + " --> It's Not A Palindrome String");
            }
            Console.ReadLine();
        }
    }
}
