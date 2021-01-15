using System;

namespace InputOutputMath
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  implement a tempertature converter from 
             *  Celsius to farenheit
             * 
             *  jan 2021
             * 
             /*

            //  input: Celsius temperature
            //  string  inputtemp   
            //  double theCelsiusTemperature

            //  output: Fahrenheit temperature
            //  double  theFahrennheitTemperature   

            //  expression (calculate):   (ct * (9.0/5.0))+ 32
            //  check with ct  = 0 expect ft = 32
            //  check with ct  = 100 ft = 212
            //  check with ct  = -40 expect ft = -40

            // prompt for a celsius temperature
            // .Write() keeps your cursor on the same line
           */

            Console.Write("Enter a Celsius temperature");

            //  console.writeline automically moves cursour to next line
            //  console.write keeps it at the same line
            //  how does the program pulls in the entry from the user
            //  to obtain the key strokes that the user types (input)
            //  .ReadLine()
            //  important!!!
            //  data comes into the program as a string
            //  DOES NOT matter if you enter a number, it is treated as a string

            // line 45 declares a variable (datatype variable name)
            string inputTemp;
            // line 48 assignment statement :  string inputTemp; expression on the right is placed into the variable on the left
            // expression (action):    Console.ReadLine(); reads the user input
            inputTemp = Console.ReadLine();

            //you could do both statements on one line
            // string inputtemp = Console.ReadLine 

            // currently the celsius value is a string
            // the value needs to be converted to a number to be
            // used in a math calculation
            // convert the data to a different datatype
            // to do this; you will use a technique called parsing
            // syntax:  datatypeTo.Parse(string value)

            // WARNING: I AM ASSUMING THE USER WILL ENTER VALID DATA
            //          if the user does not enter a number this program
            //          will abort on the execution of this line

            double thecelsiusTemperature = double.Parse(inputTemp);

            //calculation using the conversion expression

            double theFahrenheitTemperature =
            (thecelsiusTemperature *(9.0/5.0)) + 32;

            //output
            //.writeline() which automatically goes to the next line.
            //after Console.WriteLine($"The Celsius temperature of {thecelsiusTemperature} click enter for it to set up the next part of the code
            Console.WriteLine($"The Celsius temperature of {thecelsiusTemperature} is " +
                $"{theFahrenheitTemperature} in Fahrenheit");
        }
    }
}
