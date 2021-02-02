using System;

namespace BasicProgrammingProblems2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value in squarefeet \n");
            string inputSquareFeet;
            inputSquareFeet = Console.ReadLine();
            Double UserSquareFeet = double.Parse(inputSquareFeet);
            Double landSquareFeet= 4356000;
            Double landAcres = (UserSquareFeet * (landSquareFeet));
            Console.WriteLine($" \n{inputSquareFeet} square foot is " +
            $"{landAcres} Acres \n");
        }
    }
}
