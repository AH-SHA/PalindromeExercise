using System;
using System.Linq;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entered code into the 'Main' program to test functionality of finding a palindrome.

            Console.WriteLine("Type the SAME WORD TWICE to test whether its a palindrome.  Hit 'Enter' after each word entered.");
            
            // Requesting input from the user

            //INPUT 1
            Console.WriteLine("Type a word:");
            var word = Console.ReadLine();
            Console.WriteLine();

            //INPUT 2
            Console.WriteLine("Type the same word again :");
            var word2 = Console.ReadLine();

            //Convert 1st user entry to a character array
            char[] userArray = word.ToCharArray();

            //Convert 2nd user entry to a character array
            char[] userEntry2 = word2.ToCharArray();  //converts user input to a character array, which allows access to the .Reverse functionality
            Console.WriteLine();

            // Operation to actually reverse the charcater array
            Array.Reverse(userArray);  
            

            // Conditional Statement to check equality & convert to Boolean          

            if (userArray.SequenceEqual(userEntry2))
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }



        }
    }
}
