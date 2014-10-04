using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDosNumeros
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1, num2, suma, diferencia, producto, division;
            Console.WriteLine("programa mayos de dos numeros:");
            Console.WriteLine("lea numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("lea numero 2");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                suma = num1 + num2;
                diferencia = num1 - num2;
                Console.WriteLine("la suma es :" + suma);
                Console.WriteLine("la diferencia es :" + diferencia);
            }
            else
            {
                producto = num1 * num2;
                division = num1 / num2;
                Console.WriteLine("la productos es :" + producto);
                Console.WriteLine("la division es :" + division);
            }
            Console.ReadKey();
        }
    }
}
