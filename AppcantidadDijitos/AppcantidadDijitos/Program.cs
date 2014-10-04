using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppcantidadDijitos
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1;
            int num;
            Console.WriteLine("cadena de numeros");
            Console.WriteLine("");
            Console.WriteLine("dijite un numero entre 1 y 99");
            num1 = Console.ReadLine();
            num = int.Parse(num1);
            if (num1.Length <= 2 && num > 0)
            {
                Console.WriteLine("el numero es positivo");
                if (num1.Length == 2)
                {
                    Console.WriteLine("el numero tiene dos dijitos");
                }
                else
                {
                    Console.WriteLine("el numero tiene un dijito");
                }
            }
            else
            {
                Console.WriteLine("el numero no es permitido con caracteres o esta fuera de rango");
            }
            Console.ReadKey();
        }
    }
}
