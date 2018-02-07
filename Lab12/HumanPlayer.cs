using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class HumanPlayer : PlayerBase
    {
        public override int GenerateRashambo()
        {
            Console.WriteLine("[1] Rock [2] Paper [3]Scissors");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                return 1;

            }
            else if (choice == 2)
            {
                return 2;
            }
            else if (choice == 3)
            {
                return 3;
            }
            else
            {
                Console.WriteLine("Invalid");
                return GenerateRashambo();
            }
        }
        //doesnt need a name delcared because : PlayerBase already has that 

    }
}
