using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate object
            Employee e = new Employee();

            e.Name = "Michael R. Hart";
            e.Id = 509509;
            e.Pay = 1234.50;

            e.PrintState();
        }
    }
}
