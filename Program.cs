using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeStringUsingForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String reverse = "";
            Console.WriteLine("Enter A String");
            string str = Console.ReadLine();
            
            for(int i = str.Length-1; i >= 0; i--)
            {
                reverse += str[i];
            }
            if(str.ToLower() == reverse.ToLower())
            {
                Console.WriteLine(str + " --> It's A Palindrome String..");
            }
            else
            {
                Console.WriteLine(str + " --> It's Not A Palindrome String..");
            }
            Console.ReadKey();
        }
    }
}
