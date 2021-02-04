using System;

namespace COREPORTFOLIOTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           
            Purpose: 
            
            Create a new C# Console App that reads an estimated flight time and an actual flight time and then print whether the estimate time is too
            large, acceptable, or too small. If the estimated flight time is too large or too small, the program should also print the amount of the overestimate or underestimate. 
            whether the estimate time is too large, acceptable, or too small. If the estimated flight time is too large or too small, the program should also
            print the amount of the overestimate or underestimate. 

            Input:
            
            User inputs two numerical values for flight estimate and actual time of a flight. The program will take these values and find a respective margin of error 
            dependent of the two values they inputted. 

            Process:

            0. Strings, Doubles are declared using camel casing because they are variables
            1. The user will input two numerical values for flight estimate and actual.
            2. After the user inputs two values the program will look for an applicable if statement to use (range extends from 0 - infinity). Each range has a respective Margin of error.
            3. Once the program finds the applicable if statement the program will begin checking if the numbers are over estimates, under estimates , or acceptable estimate.
            4. The program is split into two sections: Small Estimate, and Large estimate.
            5. if the program detects that the (flightEstimate <= flightActual) the small estimate path will begin,.
            6. the small path has two calculations (flightTimeCalculation, flightTimeCalculation2).
            7. First the flightTimeCalculation takes the flight estimate and adds the respective margin error .
            8. Then flightTimeCalculation2 takes the the flightActual and subtracts the flightTimeCalculation.
            9. then the program checks if the flightTimeCalculaton is smaller then the margin of error.
            10. if flightTimeCalculation2 < respective MOE (or any numbers that are less that are less then moe excluding negative values) then the console writes that the Estimated time is acceptable and changes Same number to 1 instead of 0
            11. Same number makes sure that the prompt "Estimated time is acceptable" doesn't display twice for the large estimate path.
            12. if not the program will display how short the estimate was compared to the actual flight time.
            13. The large path is chosen if the small path is not chosen.
            14. The large path checks if (flightEstimate >= flightActual) for respective estimates and actuals.
            15. Then the Large path will calculate:  flightTimeCalculation = (flightEstimate - flightActual).
            16. Then flightTimeCalculation2 = (flightTimeCalculation - (respective MOE).
            17. Then if (flightTimeCalculation2 < ROE or any numbers that are less that are less then moe including negative values && sameNumber == 0) display Estimated time is acceptable (samenumber = 0 means that the "Estimated time is acceptable" has not been displayed before).
            18. if not the program will display how Large the estimate was compared to the actual flight time.
            19. This process repeats and works for every value tested.

            Output:

            This program can output 3 possible results:

            1. Estimated time is acceptable

            2. Estimated time too small by {x} minutes

            3. Estimated time too large by {x} minutes

            Author: Tylen Bryan

            last modified date: February 7, 2020

            */

            string flightTime;
            double flightEstimate;
            double flightActual;
            double flightTimeCalculation;
            double flightTimeCalculation2;
            double sameNumber = 0;

            Console.WriteLine("Flight Time Estimate \n");

            Console.WriteLine("This program is used to determine if the estimated flight time is acceptable. \n");

            Console.WriteLine("Enter estimated flight time in minutes:\n");
            flightTime = Console.ReadLine();
            flightEstimate = double.Parse(flightTime);

            Console.WriteLine("\nEnter actual flight time in minutes:\n");
            flightTime = Console.ReadLine();
            flightActual = double.Parse(flightTime);

            //small path
  
            if (flightEstimate <= 29 && flightEstimate <= flightActual) 
            {
                flightTimeCalculation = (flightEstimate + 1);
                flightTimeCalculation2 = (flightActual - flightTimeCalculation);

                if (flightTimeCalculation2 < 1) 
                {
                    sameNumber = 1; 
                    Console.WriteLine($"\nEstimated time is acceptable");
                }
                else
                {
                    Console.WriteLine($"\nEstimated time too small by {flightTimeCalculation2} minutes\n");
                }
            }



            else if (flightEstimate >= 30 && flightEstimate <= 59 && flightEstimate <= flightActual)

            {
                flightTimeCalculation = (flightEstimate + 2);
                flightTimeCalculation2 = (flightActual - flightTimeCalculation);

                if (flightActual - flightEstimate == 2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == 0) 

                {
                    sameNumber = 1;
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else
                {
                    Console.WriteLine($"\nEstimated time too small by {flightTimeCalculation2} minutes\n");
                }
            }



            else if (flightEstimate >= 60 && flightEstimate <= 89 && flightEstimate <= flightActual) 

            {
                flightTimeCalculation = (flightEstimate + 3);
                flightTimeCalculation2 = (flightActual - flightTimeCalculation);

                if (flightActual - flightEstimate == 3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == 0) 

                {
                    sameNumber = 1;
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else
                {
                    Console.WriteLine($"\nEstimated time too small by {flightTimeCalculation2} minutes\n");
                }
            }



            else if (flightEstimate >= 90 && flightEstimate <= 119 && flightEstimate <= flightActual) 

            {
                flightTimeCalculation = (flightEstimate + 4);
                flightTimeCalculation2 = (flightActual - flightTimeCalculation);

                if (flightActual - flightEstimate == 4 ||flightActual - flightEstimate == 3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == 0) 

                {
                    sameNumber = 1;
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else
                {
                    Console.WriteLine($"\nEstimated time too small by {flightTimeCalculation2} minutes\n");
                }
            }



            else if (flightEstimate >= 120 && flightEstimate <= 179 && flightEstimate <= flightActual) 

            {
                flightTimeCalculation = (flightEstimate + 6);
                flightTimeCalculation2 = (flightActual - flightTimeCalculation);

                if (flightActual - flightEstimate == 6 || flightActual - flightEstimate == 5 || flightActual - flightEstimate == 4 || flightActual - flightEstimate == 3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == 0) 

                {
                    sameNumber = 1;
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else
                {
                    Console.WriteLine($"\nEstimated time too small by {flightTimeCalculation2} minutes\n");
                }
            }



            else if (flightEstimate >= 180 && flightEstimate <= 239 && flightEstimate <= flightActual) 

            {
                flightTimeCalculation = (flightEstimate + 8);
                flightTimeCalculation2 = (flightActual - flightTimeCalculation);

                if (flightActual - flightEstimate == 8 || flightActual - flightEstimate == 7 || flightActual - flightEstimate == 6 || flightActual - flightEstimate == 5 || flightActual - flightEstimate == 4 || flightActual - flightEstimate == 3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == 0) 

                {
                    sameNumber = 1;
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else
                {
                    Console.WriteLine($"\nEstimated time too small by {flightTimeCalculation2} minutes\n");
                }
            }


            else if (flightEstimate >= 240 && flightEstimate <= 359 && flightEstimate <= flightActual)

            {
                flightTimeCalculation = (flightEstimate + 13);
                flightTimeCalculation2 = (flightActual - flightTimeCalculation);

                if (flightActual - flightEstimate == 13 || flightActual - flightEstimate == 12 || flightActual - flightEstimate == 11 || flightActual - flightEstimate == 10 || flightActual - flightEstimate == 9 || flightActual - flightEstimate == 8 || flightActual - flightEstimate == 7 || flightActual - flightEstimate == 6 || flightActual - flightEstimate == 5 || flightActual - flightEstimate == 4 || flightActual - flightEstimate == 3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == 0) 

                {
                    sameNumber = 1;
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else
                {
                    Console.WriteLine($"\nEstimated time too small by {flightTimeCalculation2} minutes\n");
                }
            }


            else if (flightEstimate >= 360 && flightEstimate <= flightActual)

            {
                flightTimeCalculation = (flightEstimate + 17);
                flightTimeCalculation2 = (flightActual - flightTimeCalculation);

                if (flightActual - flightEstimate == 17 || flightActual - flightEstimate == 16 || flightActual - flightEstimate == 15 || flightActual - flightEstimate == 14 || flightActual - flightEstimate == 13 || flightActual - flightEstimate == 12 || flightActual - flightEstimate == 11 || flightActual - flightEstimate == 10 || flightActual - flightEstimate == 9 || flightActual - flightEstimate == 8 || flightActual - flightEstimate == 7 || flightActual - flightEstimate == 6 || flightActual - flightEstimate == 5 || flightActual - flightEstimate == 4 || flightActual - flightEstimate == 3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == 0) 

                {
                    sameNumber = 1;
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else
                {
                    Console.WriteLine($"\nEstimated time too small by {flightTimeCalculation2} minutes\n");
                }
            }

            // to large path

            if (flightEstimate <= 29 && flightEstimate >= flightActual)
            {
                flightTimeCalculation = (flightEstimate - flightActual);
                flightTimeCalculation2 = (flightTimeCalculation - 1);

                if (flightTimeCalculation2 < 1 && sameNumber == 0)
                {
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else if (flightTimeCalculation2 >= 1)
                {
                    Console.WriteLine($"\nEstimated time too large by {flightTimeCalculation2} minutes \n");
                }
            }



            else if (flightEstimate >= 30 && flightEstimate <= 59 && flightEstimate >= flightActual)
            {
                flightTimeCalculation = (flightEstimate - flightActual);
                flightTimeCalculation2 = (flightTimeCalculation - 2);

                if (flightActual - flightEstimate == 2 || flightActual - flightEstimate == -2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == -1 || flightActual - flightEstimate == 0 && sameNumber == 0)
                {
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else if (flightTimeCalculation >= 2)
                {
                    Console.WriteLine($"\nEstimated time too large by {flightTimeCalculation2} minutes\n");
                }

            }



            else if (flightEstimate >= 60 && flightEstimate <= 89 && flightEstimate >= flightActual)
            {
                flightTimeCalculation = (flightEstimate - flightActual);
                flightTimeCalculation2 = (flightTimeCalculation - 3);

                if (flightActual - flightEstimate == 3 || flightActual - flightEstimate == -3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == -2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == -1 || flightActual - flightEstimate == 0 && sameNumber == 0)
                {
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else if (flightTimeCalculation >= 3)
                {
                    Console.WriteLine($"\nEstimated time too large by {flightTimeCalculation2} minutes\n");
                }
            }



            else if (flightEstimate >= 90 && flightEstimate <= 119 && flightEstimate >= flightActual)
            {
                flightTimeCalculation = (flightEstimate - flightActual);
                flightTimeCalculation2 = (flightTimeCalculation - 4);

                if (flightActual - flightEstimate == 4 || flightActual - flightEstimate == -4 || flightActual - flightEstimate == 3 || flightActual - flightEstimate == -3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == -2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == -1 || flightActual - flightEstimate == 0 && sameNumber == 0)
                {
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else if (flightTimeCalculation >= 4)
                {
                    Console.WriteLine($"\nEstimated time too large by {flightTimeCalculation2} minutes\n");
                }
            }



            else if (flightEstimate >= 120 && flightEstimate <= 179 && flightEstimate >= flightActual)
            {
                flightTimeCalculation = (flightEstimate - flightActual);
                flightTimeCalculation2 = (flightTimeCalculation - 6);

                if (flightActual - flightEstimate == 6 || flightActual - flightEstimate == -6 || flightActual - flightEstimate == 5 || flightActual - flightEstimate == -5 || flightActual - flightEstimate == 4 || flightActual - flightEstimate == -4 || flightActual - flightEstimate == 3 || flightActual - flightEstimate == -3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == -2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == -1 || flightActual - flightEstimate == 0 && sameNumber == 0)
                {
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else if (flightTimeCalculation >= 6)
                {
                    Console.WriteLine($"\nEstimated time too large by {flightTimeCalculation2} minutes\n");
                }
            }



            else if (flightEstimate >= 180 && flightEstimate <= 239 && flightEstimate >= flightActual)
            {
                flightTimeCalculation = (flightEstimate - flightActual);
                flightTimeCalculation2 = (flightTimeCalculation - 8);

                if (flightActual - flightEstimate == 8 || flightActual - flightEstimate == -8 || flightActual - flightEstimate == 7 || flightActual - flightEstimate == -7 || flightActual - flightEstimate == 6 || flightActual - flightEstimate == -6 || flightActual - flightEstimate == 5 || flightActual - flightEstimate == -5 || flightActual - flightEstimate == 4 || flightActual - flightEstimate == -4 || flightActual - flightEstimate == 3 || flightActual - flightEstimate == -3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == -2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == -1 || flightActual - flightEstimate == 0 && sameNumber == 0)
                {
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else if (flightTimeCalculation >= 8)
                {
                    Console.WriteLine($"\nEstimated time too large by {flightTimeCalculation2} minutes\n");
                }
            }



            else if (flightEstimate >= 240 && flightEstimate <= 359 && flightEstimate >= flightActual)
            {
                flightTimeCalculation = (flightEstimate - flightActual);
                flightTimeCalculation2 = (flightTimeCalculation - 13);

                if (flightActual - flightEstimate == 13 || flightActual - flightEstimate == -13 || flightActual - flightEstimate == 12 || flightActual - flightEstimate == -12 || flightActual - flightEstimate == 11 || flightActual - flightEstimate == -11 || flightActual - flightEstimate == 10 || flightActual - flightEstimate == -10|| flightActual - flightEstimate == 9 || flightActual - flightEstimate == -9 || flightActual - flightEstimate == 8 || flightActual - flightEstimate == -8 || flightActual - flightEstimate == 7 || flightActual - flightEstimate == -7 || flightActual - flightEstimate == 6 || flightActual - flightEstimate == -6 || flightActual - flightEstimate == 5 || flightActual - flightEstimate == -5 || flightActual - flightEstimate == 4 || flightActual - flightEstimate == -4 || flightActual - flightEstimate == 3 || flightActual - flightEstimate == -3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == -2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == -1 || flightActual - flightEstimate == 0 && sameNumber == 0)
                {
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else if (flightTimeCalculation >= 13)
                {
                    Console.WriteLine($"\nEstimated time too large by {flightTimeCalculation2} minutes\n");
                }
            }



            else if (flightEstimate >= 360 && flightEstimate >= flightActual)
            {
                flightTimeCalculation = (flightEstimate - flightActual);
                flightTimeCalculation2 = (flightTimeCalculation - 17);

                if (flightActual - flightEstimate == 17 || flightActual - flightEstimate == -17 || flightActual - flightEstimate == 16 || flightActual - flightEstimate == -16 || flightActual - flightEstimate == 15 || flightActual - flightEstimate == -15 || flightActual - flightEstimate == 14 || flightActual - flightEstimate == -14 || flightActual - flightEstimate == 13 || flightActual - flightEstimate == -13 || flightActual - flightEstimate == 12 || flightActual - flightEstimate == -12 || flightActual - flightEstimate == 11 || flightActual - flightEstimate == -11 || flightActual - flightEstimate == 10 || flightActual - flightEstimate == -10 || flightActual - flightEstimate == 9 || flightActual - flightEstimate == -9 || flightActual - flightEstimate == 8 || flightActual - flightEstimate == -8 || flightActual - flightEstimate == 7 || flightActual - flightEstimate == -7 || flightActual - flightEstimate == 6 || flightActual - flightEstimate == -6 || flightActual - flightEstimate == 5 || flightActual - flightEstimate == -5 || flightActual - flightEstimate == 4 || flightActual - flightEstimate == -4 || flightActual - flightEstimate == 3 || flightActual - flightEstimate == -3 || flightActual - flightEstimate == 2 || flightActual - flightEstimate == -2 || flightActual - flightEstimate == 1 || flightActual - flightEstimate == -1 || flightActual - flightEstimate == 0 && sameNumber == 0)
                {
                    Console.WriteLine($"\nEstimated time is acceptable\n");
                }
                else if (flightTimeCalculation >= 17)
                {
                    Console.WriteLine($"\nEstimated time too large by {flightTimeCalculation2} minutes\n");
                }
            }

        }
    }
}

// Test Plan
// testing for all possible values

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

//MOE = 6 Test Estimate: 130 Actual: 130 = Acceptable  (difference of 0) (WORKS) 
//MOE = 6 Test Estimate: 130 Actual: 131 = Acceptable  (difference of 1) (WORKS) 
//MOE = 6 Test Estimate: 130 Actual: 132 = Acceptable  (difference of 2) (WORKS) 
//MOE = 6 Test Estimate: 130 Actual: 133 = Acceptable  (difference of 3) (WORKS) 
//MOE = 6 Test Estimate: 130 Actual: 134 = Acceptable  (difference of 4) (WORKS) 
//MOE = 6 Test Estimate: 130 Actual: 135 = Acceptable  (difference of 5) (WORKS) 
//MOE = 6 Test Estimate: 130 Actual: 136 = Acceptable  (difference of 6) (WORKS) 
//MOE = 6 Test Estimate: 130 Actual: 137 = to small by 1  (difference of 7) (WORKS) 

//MOE = 6 Test Estimate: 130 Actual: 130 = Acceptable  (difference of 0) (WORKS) 
//MOE = 6 Test Estimate: 131 Actual: 130 = Acceptable  (difference of 1) (WORKS) 
//MOE = 6 Test Estimate: 132 Actual: 130 = Acceptable  (difference of 2) (WORKS) 
//MOE = 6 Test Estimate: 133 Actual: 130 = Acceptable  (difference of 3) (WORKS) 
//MOE = 6 Test Estimate: 134 Actual: 130 = Acceptable  (difference of 4) (WORKS) 
//MOE = 6 Test Estimate: 135 Actual: 130 = Acceptable  (difference of 5) (Works) 
//MOE = 6 Test Estimate: 136 Actual: 130 = Acceptable  (difference of 6) (Works) 
//MOE = 6 Test Estimate: 137 Actual: 130 = to large by 1  (difference of 7) (WORKS) 

// etc 

// the rest of the code tests were succesful 
