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
            //MOE = 1 Test Estimate: 5 Actual: 3 = Too Large BY 1  (WORKS)
            //MOE = 1 test Estimate: 3 Actual: 5 = Too Small BY 1  (WORKS)

            //MOE = 2 Test Estimate: 30 Actual: 32 = Acceptable  (difference of 2) (actual > Estimate) (WORKS)
            //MOE = 2 Test Estimate: 30 Actual: 31 = Acceptable  (difference of 1) (actual > Estimate) (WORKS)
            //MOE = 2 Test Estimate: 32 Actual: 30 = Acceptable  (difference of 2) (actual < Estimate) (WORKS) 
            //MOE = 2 Test Estimate: 31 Actual: 30 = Acceptable  (difference of 1) (actual < acceptable) (WORKS)    
            //MOE = 2 Test Estimate: 30 Actual: 30 = Acceptable  (difference of 0) (actual = Estimate) (WORKS)
            //MOE = 2 Test Estimate: 33 Actual: 30 = Too Large by 1 (WORKS) 
            //MOE = 2 test Estimate: 33 Actual: 36 = Too Small by 1 (WORKS)

            //MOE = 3 Test Estimate: 66 Actual: 66 = Acceptable (WORKS) (difference of 0) (acceptable < acceptable)
            //MOE = 3 Test Estimate: 65 Actual: 66 = Acceptable (WORKS) (difference of 1) (actual < Estimate) (WORKS) 
            //MOE = 3 Test Estimate: 64 Actual: 66 = Acceptable (WORKS) (difference of 2) (actual < Estimate) (WORKS) 
            //MOE = 3 Test Estimate: 63 Actual: 66 = Acceptable (WORKS) (difference of 3) (actual < Estimate) (WORKS) 
            //MOE = 3 Test Estimate: 66 Actual: 67 = Acceptable (WORKS) (difference of 1) (actual > Estimate) (WORKS)       
            //MOE = 3 Test Estimate: 66 Actual: 68 = Acceptable (WORKS) (difference of 2) (actual > Estimate) (WORKS)
            //MOE = 3 Test Estimate: 66 Actual: 69 = Acceptable (WORKS) (difference of 3) (actual > Estimate) (WORKS)
            //MOE = 3 Test Estimate: 70 Actual: 66 = Too Large by 1 (WORKS) 
            //MOE = 3 test Estimate: 66 Actual: 70 = Too Small by 1 (WORKS)

            //MOE = 4 Test Estimate: 95 Actual: 95 = Acceptable (WORKS) (difference of 0) (acceptable < acceptable)
            //MOE = 4 Test Estimate: 96 Actual: 95 = Acceptable (WORKS) (difference of 1) (actual < Estimate) (WORKS) 
            //MOE = 4 Test Estimate: 97 Actual: 95 = Acceptable (WORKS) (difference of 2) (actual < Estimate) (WORKS) 
            //MOE = 4 Test Estimate: 98 Actual: 95 = Acceptable (WORKS) (difference of 3) (actual < Estimate) (WORKS) 
            //MOE = 4 Test Estimate: 99 Actual: 95 = Acceptable (WORKS) (difference of 4) (actual < Estimate) (WORKS) 
            //MOE = 4 Test Estimate: 95 Actual: 96 = Acceptable (WORKS) (difference of 1) (actual > Estimate) (WORKS)       
            //MOE = 4 Test Estimate: 95 Actual: 97 = Acceptable (WORKS) (difference of 2) (actual > Estimate) (WORKS)
            //MOE = 4 Test Estimate: 95 Actual: 98 = Acceptable (WORKS) (difference of 3) (actual > Estimate) (WORKS)
            //MOE = 4 Test Estimate: 95 Actual: 99 = Acceptable (WORKS) (difference of 4) (actual > Estimate) (WORKS)
            //MOE = 4 Test Estimate: 95 Actual: 90 = Too Large by 1 (WORKS) 
            //MOE = 4 test Estimate: 90 Actual: 95 = Too Small by 1 (WORKS)



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






            else if (flightEstimate >= 90 && flightEstimate <= 119 && flightEstimate <= flightActual) // 60> x <89 Small or equal path

            {
                flightTimeCalculation = (flightEstimate + 4);
                flightTimeCalculation2 = (flightActual - flightTimeCalculation);

                if (flightActual - flightEstimate == 4 ||flightActual - flightEstimate == 3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == 0) // This means that if there is a difference between fa and fe of 2 or less its an acceptable path

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






            else if (flightEstimate >= 90 && flightEstimate <= 119 && flightEstimate >= flightActual)
            {
                flightTimeCalculation = (flightEstimate - flightActual);
                flightTimeCalculation2 = (flightTimeCalculation - 4);

                if (flightActual - flightEstimate == 4 || flightActual - flightEstimate == -4 || flightActual - flightEstimate == 3 || flightActual - flightEstimate == -3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == -2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == -1 || flightActual - flightEstimate == 0 && sameNumber == 0)
                {
                    Console.WriteLine($"Estimated time is acceptable\n");
                }
                else if (flightTimeCalculation >= 4)
                {
                    Console.WriteLine($"Estimated time too large by {flightTimeCalculation2} minutes\n");
                }
            }

        }
    }
}