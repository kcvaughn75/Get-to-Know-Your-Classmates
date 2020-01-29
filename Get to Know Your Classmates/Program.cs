using System;

namespace Get_to_Know_Your_Classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            char userContinue = 'y';

            while (userContinue == 'y')
            {
                Console.WriteLine("Welcome to our C# class! Which student would you like to learn more about? (enter a number 1-5): ");
                Console.WriteLine(" 1. Adam \n 2. Betty \n 3. Charlie \n 4. Debbie \n 5. Evan");

                string name = "";
                bool tryAgain = true;


                while (tryAgain)
                {
                    string userInput = Console.ReadLine();
                    tryAgain = false;
                    switch (userInput)
                    {
                        case "1":
                        case "Adam":
                            name = "Adam";
                            break;

                        case "2":
                        case "Betty":
                            name = "Betty";
                            break;

                        case "3":
                        case "Charlie":
                            name = "Charlie";
                            break;

                        case "4":
                        case "Debbie":
                            name = "Debbie";
                            break;
                        case "5":
                        case "Evan":
                            name = "Evan";
                            break;
                        default:
                            tryAgain = true;
                            Console.WriteLine("That student does not exist. Please try again.(enter a number 1-5): ");
                            break;

                    }
                }
                Console.WriteLine($"The student you've chosen is {name}. What would you like to know about {name}? (enter: [hometown] or [favorite food] or [favorite movie])");
                string studentFacts = Console.ReadLine();


                if ((name == "Adam") && (studentFacts == "hometown"))
                {
                    Console.WriteLine("Adam is from Detroit, Mi.");
                }
                if ((name == "Adam") && (studentFacts == "favorite food"))
                {
                    Console.WriteLine("Adam's favorite food is pizza.");
                }
                if ((name == "Adam") && (studentFacts == "favorite movie"))
                {
                    Console.WriteLine("Adam's favorite movie is Saving Private Ryan");
                }

                if ((name == "Betty") && (studentFacts == "hometown"))
                {
                    Console.WriteLine("Betty is from Toledo, OH.");
                }
                if ((name == "Betty") && (studentFacts == "favorite food"))
                {
                    Console.WriteLine("Betty's favorite food is snickers.");
                }
                if ((name == "betty") && (studentFacts == "favorite movie"))
                {
                    Console.WriteLine("Betty's favorite movie is Clueless");
                }

                if ((name == "Charlie") && (studentFacts == "hometown"))
                {
                    Console.WriteLine("Charlie is from Hong Kong, China.");
                }
                if ((name == "Charlie") && (studentFacts == "favorite food"))
                {
                    Console.WriteLine("Charlie's favorite food is Dim Sum.");
                }
                if ((name == "Charlie") && (studentFacts == "favorite movie"))
                {
                    Console.WriteLine("Charlie's favorite movie is any Marvel movie!");
                }

                if ((name == "Debbie") && (studentFacts == "hometown"))
                {
                    Console.WriteLine("Debbie is from New York, New York.");
                }
                if ((name == "Debbie") && (studentFacts == "favorite food"))
                {
                    Console.WriteLine("Debbie's favorite food is hamburgers.");
                }
                if ((name == "Debbie") && (studentFacts == "favorite movie"))
                {
                    Console.WriteLine("Debbie's favorite movie is Inception");
                }

                if ((name == "Evan") && (studentFacts == "hometown"))
                {
                    Console.WriteLine("Evan is from Columbus, OH.");
                }
                if ((name == "Evan") && (studentFacts == "favorite food"))
                {
                    Console.WriteLine("Evan's favorite food is Pretzels.");
                }
                if ((name == "Evan") && (studentFacts == "favorite movie"))
                {
                    Console.WriteLine("Evan's favorite movie is Star Wars: A New Hope");
                }

                if ((studentFacts != "hometown") || (studentFacts != "favorite food") || (studentFacts != "favorite movie"))
                {
                    Console.WriteLine("Please enter a valid choice:[hometown] [favorite food] [favorite movie]");
                }

                Console.WriteLine("Would you like to select another student? [y/n]");
                userContinue = char.Parse(Console.ReadLine().ToLower());
            }
            

        }
    }
}
