using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Methode_Bonus_01
{
    public struct ConsoleAvance
    {
        public void WriteTab(List<string> tableau) {
            foreach (string item in tableau)
            {
                Console.WriteLine(item);
            }
        }

        public void WriteTab(string[] tableau)
        {
            foreach (string item in tableau)
            {
                Console.WriteLine(item);
            }
        }
    }
}
