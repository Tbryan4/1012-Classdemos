using System;

namespace BasicProgrammingProblems3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cookies did you eat? \n" );
            string inputCookiesAte;
            inputCookiesAte = Console.ReadLine();
            int userCookiesAte = int.Parse(inputCookiesAte);
            int CaloriesPerBag = 175;
            int totalCaloriesconsumed = (userCookiesAte * CaloriesPerBag);
            Console.WriteLine($"\n{inputCookiesAte} Cookies is " +
            $"{totalCaloriesconsumed} calories");

        }
    }
}
