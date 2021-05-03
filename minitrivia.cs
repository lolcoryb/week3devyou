using System;

namespace MiniTrivia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to MINI TRIVIA! Please choose between the following categories...\r\n\r\n MUSIC \r\n\r\n SPORTS \r\n\r\n MOVIES\n\r");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "music")
            { 
                Console.WriteLine("\n\rMUSIC\n\r\n\rWhat two artists make up the group Run The Jewels? is it\n\rA. Killer Mike & El-P\n\rB. Erik B & Rakim\n\rC. Yasiin Bey & Talib Kwali\n\rD. Big Boi & Andre 3000\n\r");
                string answerMusic = Console.ReadLine().ToLower();
                if (answerMusic == "a")
                    Console.WriteLine("\n\rCorrect! Killer Mike & El-P!\n\r");
                else if (userInput != "a")
                    Console.WriteLine("\n\rOh, I'm sorry but you're incorrect. The correct answer is A, Killer Mike & El-P.\n\r");
            }

            else if (userInput == "sports")
            { Console.WriteLine("\n\rSPORTS\n\r\n\rWhich sport is played with a football? is it\n\rA. Football\n\rB. Hockey\n\rC. Formula 1\n\rD. Curling\n\r");
            string answerSports = Console.ReadLine().ToLower();
            if (answerSports == "a")
                Console.WriteLine("\n\rYup! Football is played with a football! Who could have guessed?\n\r");
            else
                Console.WriteLine("\n\rI'm not sure how you got that wrong, but you did. Maybe next time.\n\r");
            }

            else if (userInput == "movies")
            {
                Console.WriteLine("\n\rMOVIES\n\r\n\rIn The Fast and the Furious, what is the most important thing to Dominic Toretto(Vin Diesel)?\n\rA.Family\n\rB.Cars\n\rC.Corona\n\rD.Living life a quarter mile at a time\n\r");
                string answerMovies = Console.ReadLine().ToLower();
                if (answerMovies == "a")
                    Console.WriteLine("\n\rCorrect!\n\r");
                else
                    Console.WriteLine("\n\rWRONG.\n\r");
            }
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
