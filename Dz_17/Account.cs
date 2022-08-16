using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_17
{
    class Account<T>
    {
        public T Num { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }

        public string GetInfo()
        {
            return $"\nНомер счета:{Num} \nБаланс на счете:{Balance} \nВладелец:{Name}\n";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Num = (T)Convert.ChangeType(Console.ReadLine(),typeof(T));
            Console.WriteLine("Введите баланс");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Ф.И.О.");
            Name = Convert.ToString(Console.ReadLine());
        }
    }
}
