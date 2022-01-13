using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //italianchef extends chef
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("makes special as italian");
        }
    }
}
