using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class AIComputer : PlayerBase
    {
       

        public override int GenerateRashambo()
        {
            Random r = new Random();
            int num = r.Next(1, 3);
            return num;
        }


    }
}
