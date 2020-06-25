using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
          string myString = "This is a string!"; //this is an assignment

          int myInt = 42;

          //double datatype is used for decimal pint numbers.
          double myDouble = 33.666;
          //Boolean is:
          bool myBool = true;

          //subtraction is "-"
          Console.WriteLine( myInt - 10 ); //32

          //multiplication
          Console.WriteLine( myInt * 2 ); //84

          //division operator is "/"
          Console.WriteLine(myInt / 2 ); //21

          //modulus -returns remainder
          Console.WriteLine(myInt % 13 ); //

          //addition operator +
          Console.WriteLine(myInt + 8); //50

          Console.WriteLine( "3" + "3"); //33

          Console.WriteLine("3" + 3); //???

          Console.WriteLine( 3 + 6 + "3" ); //93



        }
    }
}
