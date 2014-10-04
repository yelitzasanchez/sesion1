using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAreaCuadrado
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float lado, area, perimetro;
            Console.WriteLine("programa de calcular el area y perimetro del cuadrado");
            Console.WriteLine("dijite el lado");
            lado = float.Parse(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("el area del cuadrado es :" + area);
            perimetro = 4 * lado;
            Console.WriteLine("el perimetro es :" + perimetro);
            Console.ReadKey();
        }
    }
}
