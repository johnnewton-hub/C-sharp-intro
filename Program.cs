using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //we are assigning a string value to a string variable named myName-two slashes single comment/ 
            /*  begin multi line comments with this sytax
            and we end multi line with
            symbols between values or valuations are considered operators ie + adds two strings together (concatenation) */
            string myName = "John Newton";
            Console.WriteLine("Hello, " + myName);

            Console.WriteLine("Please enter your name...");

            //Assign variable 'userName' to a value entered by the user

            string userName = Console.ReadLine();
            Console.WriteLine("You have entered your name" + userName);
            Console.WriteLine("Hey {0}, you're looking great today!", userName);
        }
    }
}
