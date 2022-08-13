using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите ваше имя?");
            string name = Console.ReadLine();
            Console.WriteLine("Укажите вашу фамилию?");
            string surname = Console.ReadLine();
            Console.WriteLine("Откуда вы?");
            string city = Console.ReadLine();
            Console.WriteLine("Дрогой(-ая), {0} {1} из {2}, желаю вам хорошего дня и настроения!", surname, name, city);



            Console.ReadLine();
        }
    }
}
