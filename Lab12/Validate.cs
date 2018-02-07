using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Validate
    {
        public bool RepeatProgram(string choice)
        {

            Console.WriteLine("Would you like to run program again? y/n"); //validate y/n
            string yesNo = Console.ReadLine().ToLower();
            if ((yesNo == "y") || (yesNo == "n"))
            {
                if (yesNo == "n")
                {

                    return false;

                }
                else if (yesNo == "y")
                {
                    return true;
                }

            }
            else
            {
                Console.WriteLine("Invalid");
                return RepeatProgram(choice);

            }
            return RepeatProgram(choice);
        }

        public int ValidateOpponent()
        {
            Console.WriteLine("Who are you playing against today? \n[1] Rock or[2] Computer ? ");
            int oppoChoice = int.Parse(Console.ReadLine());

            if (oppoChoice == 1)
            {
                return 1;

            }
            else if (oppoChoice == 2)
            {
                return 2;
            }
            else
            {
                Console.WriteLine("Invalid");
                return ValidateOpponent();
            }
        }

    }
}
