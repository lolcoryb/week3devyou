using System;

namespace CapstoneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;

            while (again)
            {
                Console.WriteLine("Welcome to the Vacation Budget Planner!\r\n\r\nWhat is your name?");

                string name = Console.ReadLine();

                Console.WriteLine($"\r\nWelcome {name}! Where do you want to go?.\r\n\r\nChoose (1) Mexico (2) Jamaica\n\r");

                string destination = Console.ReadLine();
            
                { 
                if (destination != "1" && destination != "2")
                    Console.WriteLine("Please choose only 1 or 2, Type R to try again");
                string tryagain = Console.ReadLine().ToLower();

                if (tryagain == "r")
                    again = true;
                else if (tryagain != "r")
                    again = false;
                }
                
                switch (destination)
                
                {
                    case "1":
                        Console.WriteLine("Great, Mexico sounds like an amazing trip!\n\r**********\n\rHow many days do plan on spending in {destination}?\r\n");
                       
                        double days1 = Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine("\r\nHow much spending money do you plan on bringing?\r\n");
                        
                        double spending1 = Convert.ToDouble(Console.ReadLine());

                        double hours1 = (days1 * 24);

                        double minutes1 = (hours1 * 60);

                        double spendPerDay = (spending1 / days1);

                        Console.WriteLine($"\r\n{days1}? That's {hours1} hours OR   {minutes1} minutes!\r\n");
                        
                        Console.WriteLine($"\r\nSo {name}, you're planning on spending {days1} days in Mexico with {spending1:c} of spending money. You can spend {spendPerDay:c2} per day.\r\n\r\n");

                        double peso1 = (spending1 * 20.23);
                        
                        double pesoPerDay = (peso1 / days1);
                        
                        Console.WriteLine($"Lets convert that to Pesos. You'll have {peso1:f2} Pesos for the trip, or {pesoPerDay:f2} Pesos per day ");
                        
                        Console.WriteLine("\n\rEnjoy your trip to Mexico!");
                        
                        break;
                    
                    case "2":
                        Console.WriteLine("Jamaica");
                        break;

                        //}
                        //Console.WriteLine($"\r\nHow many days do plan on spending in {destination}?\r\n");
                        //double trip = Convert.ToDouble(Console.ReadLine());

                        //Console.WriteLine("\r\nHow much spending money do you plan on bringing?\r\n");
                        //double spending = Convert.ToDouble(Console.ReadLine());

                        //Console.WriteLine($"\r\nSo {name}, you're planning on spending {trip} days in Jamaica with {spending:c} of spending money. You can spend {spending / trip:c} per day.\r\n");



                }
            }
        }
    }
}
