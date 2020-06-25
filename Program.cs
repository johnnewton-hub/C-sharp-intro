using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //logical operators 
            Console.WriteLine( true || true ); // || is OR operator
            Console.WriteLine( false || true );
            Console.WriteLine( true && true ); //true //&& is AND
            Console.WriteLine( false && true ); //False
            Console.WriteLine(false && false); // false

            //how does this behave with different data=-types?
            //Console.WriteLine( true && 1 ); it doesn't

            //comparative operators..
            Console.WriteLine( false == false ); //true
            Console.WriteLine ( 2.25 == 2.25 ); //true
           // Console.WriteLine(3.14 == "3.14"); //can't two diff types

            //greater than check
            Console.WriteLine( 6 > 7 );
            Console.WriteLine( 10 > 5 );

            Console.WriteLine( 6 < 7 ); //truef
            Console.WriteLine( 10 < 5 );//false

            //greater than or equal check

            Console.WriteLine( 5 >= 5 ); //true
            Console.WriteLine( 10 <= 5 ); // false
            Console.WriteLine(4 <= 5 ); //true 

            //not equal to check.
            Console.WriteLine(false != false ); //false
            Console.WriteLine(true != false ); //true

            Console.WriteLine( 5 != 5 ); //false
            Console.WriteLine( 5!= 10 ); //true




        }

        
    }
}
