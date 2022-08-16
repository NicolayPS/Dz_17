using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int>();
            account1.Input();
            Console.WriteLine(account1.GetInfo());

            Account<string> account2 = new Account<string>();
            account2.Input();
            Console.WriteLine(account2.GetInfo());

            Console.ReadKey();
        }
    }
}
