using System;

namespace COREPORTFOLIOTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new C# Console App project named as CorePortfolio01-YourName that reads an estimated flight time and an actual flight time and then print 
            //whether the estimate time is too large, acceptable, or too small. If the estimated flight time is too large or too small, the program should also
            //print the amount of the overestimate or underestimate. 

            string flightTime;
            double flightEstimate;
            double flightActual;
            double flightTimeCalculation;
            double flightTimeCalculation2;
            double sameNumber = 0;

            //same number stops "estimated time is acceptable from dispplaying twice


            Console.WriteLine("Flight Time Estimate \n");

            Console.WriteLine("This program is used to determine if the estimated flight time is acceptable. \n");

            Console.WriteLine("Enter estimated flight time in minutes:\n");
            flightTime = Console.ReadLine();
            flightEstimate = double.Parse(flightTime);

            Console.WriteLine("\nEnter actual flight time in minutes:\n");
            flightTime = Console.ReadLine();
            flightActual = double.Parse(flightTime);

            //MOE = 1 Test Estimate: 2 Actual: 3 = Acceptable (WORKS)
            //MOE = 1 Test Estimate: 3 Actual: 3 = Acceptable (WORKS)
            //MOE = 1 Test Estimate: 3 Actual: 2 = Acceptable (WORKS)
            //MOE = 1 Test Estimate: 5 Actual: 3 = Too Large  (WORKS)
            //MOE = 1 test Estimate: 3 Actual: 5 = Too Small  (WORKS)

            //MOE = 2 Test Estimate: 30 Actual: 32 = Acceptable (WORKS) (difference of 2) (actual < acceptable)
            //MOE = 2 Test Estimate: 30 Actual: 31 = Acceptable (WORKS) (difference of 1) (actual < acceptable)
            //MOE = 2 Test Estimate: 32 Actual: 30 = Acceptable (WORKS) (difference of 2) (acceptable < acceptable) (LARGE BY 0 MINUTES?)
            //MOE = 2 Test Estimate: 31 Actual: 30 = Acceptable (WORKS) (difference of 1) (actual < acceptable)     (NOTHING SHOWS)
            //MOE = 2 Test Estimate: 30 Actual: 30 = Acceptable (WORKS) (difference of 0) (actual = Acceptable)
            //MOE = 2 Test Estimate: 33 Actual: 30 = Too Large by 1 (WORKS) 
            //MOE = 2 test Estimate: 33 Actual: 36 = Too Small by 1 (WORKS) 

            if (flightEstimate <= 29 && flightEstimate <= flightActual) // if flight estimate is <= 29 & flightEstimate is <= Flight Actual. 
            {
                flightTimeCalculation = (flightEstimate + 1);
                flightTimeCalculation2 = (flightActual - flightTimeCalculation);

                if (flightTimeCalculation2 < 1) // This means estimated time is acceptable
                {
                    sameNumber = 1; // Same number gets rid of estimated time is acceptable
                    Console.WriteLine($"Estimated time is acceptable");
                }
                else
                {
                    Console.WriteLine($"Estimated time too small by {flightTimeCalculation2} minutes\n");
                }
            }





            else if (flightEstimate >= 30 && flightEstimate <= 59 && flightEstimate <= flightActual) // 30> x <59 Small or equal path

            {
                flightTimeCalculation = (flightEstimate + 2);
                flightTimeCalculation2 = (flightActual - flightTimeCalculation);

                if (flightActual - flightEstimate == 2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == 0) // This means that if there is a difference between fa and fe of 2 or less its an acceptable path

                {
                    sameNumber = 1;
                    Console.WriteLine($"Estimated time is acceptable\n");
                }
                else
                {
                    Console.WriteLine($"Estimated time too small by {flightTimeCalculation2} minutes\n");
                }
            }







            else if (flightEstimate >= 60 && flightEstimate <= 89 && flightEstimate <= flightActual) // 60> x <89 Small or equal path

            {
                flightTimeCalculation = (flightEstimate + 3);
                flightTimeCalculation2 = (flightActual - flightTimeCalculation);

                if (flightActual - flightEstimate == 3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == 0) // This means that if there is a difference between fa and fe of 2 or less its an acceptable path

                {
                    sameNumber = 1;
                    Console.WriteLine($"Estimated time is acceptable\n");
                }
                else
                {
                    Console.WriteLine($"Estimated time too small by {flightTimeCalculation2} minutes\n");
                }
            }






            if (flightEstimate <= 29 && flightEstimate >= flightActual)
            {
                flightTimeCalculation = (flightEstimate - flightActual);
                flightTimeCalculation2 = (flightTimeCalculation - 1);

                if (flightTimeCalculation2 < 1 && sameNumber == 0)
                {
                    Console.WriteLine($"Estimated time is acceptable\n");
                }
                else if (flightTimeCalculation2 >= 1)
                {
                    Console.WriteLine($"Estimated time too large by {flightTimeCalculation2} minutes \n");
                }
            }




            else if (flightEstimate >= 30 && flightEstimate <= 59 && flightEstimate >= flightActual)
            {
                flightTimeCalculation = (flightEstimate - flightActual);
                flightTimeCalculation2 = (flightTimeCalculation - 2);

                if (flightActual - flightEstimate == 2 || flightActual - flightEstimate == -2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == -1 || flightActual - flightEstimate == 0 && sameNumber == 0)
                {
                    Console.WriteLine($"Estimated time is acceptable\n");
                }
                else if (flightTimeCalculation >= 2)
                {
                    Console.WriteLine($"Estimated time too large by {flightTimeCalculation2} minutes\n");
                }

            }

            else if (flightEstimate >= 60 && flightEstimate <= 89 && flightEstimate >= flightActual)
            {
                flightTimeCalculation = (flightEstimate - flightActual);
                flightTimeCalculation2 = (flightTimeCalculation - 3);

                if (flightActual - flightEstimate == 3 || flightActual - flightEstimate == -3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == -2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == -1 || flightActual - flightEstimate == 0 && sameNumber == 0)
                {
                    Console.WriteLine($"Estimated time is acceptable\n");
                }
                else if (flightTimeCalculation >= 3)
                {
                    Console.WriteLine($"Estimated time too large by {flightTimeCalculation2} minutes\n");
                }
            }

        }
    }
}