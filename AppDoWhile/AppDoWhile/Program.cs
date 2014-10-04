using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma=0, valor;
            Console.WriteLine("programa que suma valores");
            do
            {
                Console.WriteLine("digite el valor");
                valor = int.Parse(Console.ReadLine());
                if (valor == 9999)
                {
                    break;
                }
                else
                {
                    suma = suma + valor;
                }
            }
            while (valor != 9999);
            Console.WriteLine("el valor acumulado es :"+suma);
            if (suma == 0) 
            {
                Console.WriteLine("el valor acumulado es igual a cero");
            }
            else if (suma > 0)
            {
                Console.WriteLine("el valor acumulado es mayor a cero");
            }
            else
            {
                Console.WriteLine("el valor acumulado es menor a cero");
            }
            Console.ReadKey();
        }
    }
}
