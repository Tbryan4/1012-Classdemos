using System;

namespace BasicProgramingProblems4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your 3 test averages as a percentage \n");
            string inputTestScore1;
            inputTestScore1 = Console.ReadLine();
            double userscore1 = int.Parse(inputTestScore1);

            string inputTestScore2;
            inputTestScore2 = Console.ReadLine();
            double userscore2 = int.Parse(inputTestScore2);

            string inpuTestScore3;
            inpuTestScore3 = Console.ReadLine();
            double userscore3 = int.Parse(inpuTestScore3);

            double Average = (((userscore1 + userscore2 + userscore3)/300)*100);

            Console.WriteLine($"\nThree Test Scores:\n \n{inputTestScore1}% \n{inputTestScore2}% \n{inpuTestScore3}% \n" +
            $"\nYour Average is {Average}% GOOD JOB :)");



        }

    }
}
