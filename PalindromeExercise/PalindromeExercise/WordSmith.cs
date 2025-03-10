using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PalindromeExercise
{
    //    Make sure the PalindromeExerciseTests project file has PalindromeExercise added as a reference.

    //→ Right click Dependencies in PalindromeExerciseTests to check and add a Project Reference if need be

    //Create a class named WordSmith in your PalindromeExercise project file.This is where you will eventually create your IsAPalindrome() method

    //In your WordSmith class, you will create a method(IsAPalindrome) that will take a parameter of type string and return a value of type bool. If the given input is a palindrome – return true, else return false. You will finish this method after you write your tests.

    //Write you test method in the UnitTest1.cs file - located in the PalindromeExerciseTests project file

    //In UnitTest1.cs, remove the Fact portion and replace it with:

    //Finish the test with Arrange, Act, Assert and make your IsAPalindrome method pass the tests

    //Once finished, save, commit, and push back to Github
    public class   WordSmith
    {
        // Create an empty constructor
        public WordSmith()
        {


        }

        //DONE - Create a method within WordSmith Class
        public bool IsAPalindrome(string word, string word2)
        {
            //Convert 1st input to Array
            char[] userArray = word.ToCharArray();

            //Convert 2nd user entry to a character array
            char[] userEntry2 = word2.ToCharArray();  //converts user input to a character array, which allows access to the .Reverse functionality


            // Operation to actually reverse the charcater array
            Array.Reverse(userArray);


            // Conditional Statement to check equality & convert to Boolean          

            if (userArray.SequenceEqual(userEntry2))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

       


        // Optional Code below to reverse a string entry, uses the LINQ method/System.Linq class
        //This code is not correct. It needs more work
        //public bool IsAPalindrome2(string word2)
        //{


        //    var reverse = word2.Reverse();  // This .Reverse() command works only because the "using.System.Linq" static class is used above.  Without LINQ, you would have to convert userWord to an array and use the array.Reverse() method.


        //    if (reverse == word2)
        //    {
        //        return true;
        //    }
        //    else
        //    { 
        //        return false;
        //    }


        //}







    }
}
