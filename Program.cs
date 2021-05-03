using System;

namespace homeworkweek3
{
    class Program
    {
        static void Main(string[] args)

        {
            bool again = true;

            while (again)
            {
                Console.WriteLine("Hello user, Welcome to MONTH CONVERTER. please choose a number betweem 1 and 12.");
                int month = Convert.ToInt32(Console.ReadLine());

                if (month == 1)
                    Console.WriteLine("January");
                else if (month == 2)
                    Console.WriteLine("February");
                else if (month == 3)
                    Console.WriteLine("March");
                else if (month == 4)
                    Console.WriteLine("April");
                else if (month == 5)
                    Console.WriteLine("May");
                else if (month == 6)
                    Console.WriteLine("June");
                else if (month == 7)
                    Console.WriteLine("July");
                else if (month == 8)
                    Console.WriteLine("August");
                else if (month == 9)
                    Console.WriteLine("September");
                else if (month == 10)
                    Console.WriteLine("October");
                else if (month == 11)
                    Console.WriteLine("November");
                else if (month == 12)
                    Console.WriteLine("December");

                else if (month > 1 || month < 1)
                    Console.WriteLine("Come on, only 1 through 12. Type R to restart. Press Enter to exit.");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "r")
                {
                    again = true;
                }
                if (userInput != "r")
                {
                    again = false;
                }
                
            }
                Console.WriteLine("Press Enter to Exit");
                Console.ReadLine();
            }




        }
    }

