using System;

namespace ArithmeticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //the special character \n adds an extra blank line
            // it is called the next line character
            Console.WriteLine("Arithmetic Samples\n");

            //declare a variable of datatype double
            //syntax; datatype variablename assignment operator literal numeric value;
            //          double(datatype)  total(variablename)                   =0.0 (literal)
            double Total = 0.0;
            double Cost = 15.23;
            double Tax = 0.81;

            //arithmetic assignment operation
            //syntax;  recieving variable assignment operator binary arithmetic (addition) expression
            //total = cost+ tax\
            //action: the expression will be executed and the results will be placed into the
            //        recieving variable
            Total = Cost + Tax;

            Console.WriteLine($"The results of {Cost} + {Tax} is {Total}");

            // An alternate way of outputting your variables will be to use string
            // concatenation
            // string concantenation uses the operator +
            Console.WriteLine("The result of" + Cost + " + " + Tax + " is " + Total);

            //an Alternate way is to use placeholders
            //placeholders start at 0 and increment by 1
            //placeholder values are in a list after the string
            // ORDER IS IMPORTANT
            Console.WriteLine("The results of {0} + {1} is {2}", Cost, Tax, Total);
        }
    }
}
