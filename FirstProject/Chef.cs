using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Chef
    {
        public void MakeChichen()
        {
            Console.WriteLine("makes chiken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("makes salad");
        }

        //overwrite
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("makes special");
        }
    }
}
