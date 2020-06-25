using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine( "Please tell us if you want to add or subtract");

            string userOperator = Console.ReadLine();
            //check if user typed: add

            if ( userOperator == "add" )
            {
                Console.WriteLine( "Please enter the first number:" );
                int firstNum = Int32.Parse ( Console.ReadLine()); /*convert to integer
                https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int*/
                int secondNum = Int32.Parse( Console.ReadLine() );

                //calculate the result.
                int result = firstNum + secondNum;
                Console.WriteLine( "{0} + {1} = {2}", firstNum, secondNum, result );

            }

        }   

        
    }
}
