using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данила, ты что крейзи?");
            Console.WriteLine("Текст");

            string name = "Данила крейзи";
            Console.WriteLine($"Меня зовут {name}");

            Console.WriteLine("Тут надо написать своё хобби: ");
            string hobby = Console.ReadLine();
            Console.WriteLine($"Моё хобби: {hobby}");




            Console.ReadKey();
        }
    }
}
