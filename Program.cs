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
            Console.WriteLine("You have entered your name " + userName);
            //instead of using traditional concatentation using addition operators
            // we can use string interpolation (placeholders) to embed values in a string
            Console.WriteLine("Hey {0}, you're looking great today!", userName);
            //@link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            //Let's play with strings!
            Console.WriteLine("makemeuppercase".ToUpper()); //convert to uppercase
            Console.WriteLine("makemeLOWERrcase".ToLower()); //convert to lower case
            Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(3, 3));
            /*above starts with the third character (starts at 0), and the second number tells us how many letters to
            stubstring takes two arguments: start postion and number of characters*/
            Console.WriteLine("xyz".Length); //get the number os characters for the string


        }
    }
}
