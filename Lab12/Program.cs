using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        enum RPS { rock, paper, scissors }

        static void Main(string[] args)
        {
            try
            {
                bool run = true;
                while (run)
                {
                    Rock r1 = new Rock(); //creaing rock object || making this object is calling constructor
                    AIComputer aiC = new AIComputer(); //creating AIComp object || making this object is calling constructor

                    Console.WriteLine("Hello! What is your name?");
                    string userName = Console.ReadLine();
                    //VALIDATE METHOD HERE

                    Validate v1 = new Validate();
                    int oppoChoice = v1.ValidateOpponent();

                    if (oppoChoice == 1) //if human plays against rock
                    {
                        Console.Clear();
                        HumanPlayer p1 = new HumanPlayer(); //creating a new player
                        int choice = p1.GenerateRashambo();
                        if (choice == 1)
                        {
                            Console.WriteLine($"{userName}'s Choice: {choice}");
                            Console.WriteLine($"Rock's Choice: Rock");
                            Console.WriteLine("Tie!");
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine($"{userName}'s Choice: {choice}");
                            Console.WriteLine($"Rock's Choice: Rock");
                            Console.WriteLine($"{userName} wins!");
                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine($"{userName}'s Choice: {choice}");
                            Console.WriteLine($"Rock's Choice: 1");
                            Console.WriteLine("Rock wins!");
                        }
                    }
                    if (oppoChoice == 2) //chooses AICOMP
                    {
                        Console.Clear();
                        HumanPlayer p1 = new HumanPlayer(); //making this object is calling constructor
                        int choice = p1.GenerateRashambo(); // calling Human Player Roshambo method

                        AIComputer ai1 = new AIComputer(); //creating an AI object
                        int aChoice = ai1.GenerateRashambo(); //aChoice is the AIComp's number choice (random gen)
                        if (choice == aChoice)
                        {
                            Console.WriteLine($"{userName}'s Choice: {choice}");
                            Console.WriteLine($"Computer's Choice: {aChoice}");
                            Console.WriteLine("Tie!");
                        }
                        else if ((choice == 1 && aChoice == 2) && (choice == 2 && aChoice == 1) && (choice == 3 && aChoice == 2))
                        {
                            Console.WriteLine($"{userName}'s Choice: {choice}");
                            Console.WriteLine($"Computer's Choice: {aChoice}");
                            Console.WriteLine($"{userName} wins!");
                        }
                        else
                        {
                            Console.WriteLine($"{userName}'s Choice: {choice}");
                            Console.WriteLine($"Computer's Choice: {aChoice}");
                            Console.WriteLine("Computer wins!");
                        }
                    }

                    Validate v = new Validate();
                    run = v.RepeatProgram("");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please use correct input");
            }
        }

    }
}
