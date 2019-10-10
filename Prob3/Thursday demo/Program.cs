using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thursday_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region region 1
            for (int printerPrints = 0; printerPrints < 2; printerPrints++)
            {
                // cond2 = red light is flashing
                for (int cond2 = 0; cond2 < 2; cond2++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (printerPrints == 0 && cond2 == 0 && i == 0)
                        {
                            // call action methods
                            Console.WriteLine("Printer prints: ");
                        }
                        if (printerPrints == 0 && cond2 == 0 && i == 1)
                        {
                            // call action methods
                        }
                    }
                }
            }
            #endregion

            #region region 2
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        // print out conditions
                        // call action methods for NO, No, NO
                        break;
                    case 1:
                        // so forth
                    default:
                        break;
                }
            }
            #endregion
        }
    }
}
