using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int suma;
            Console.WriteLine("Hola Mundo");

            //Comentario de una línea
            Console.Write("Valor de x: ");
            x = int.Parse(Console.ReadLine());

            /*
             Comentario multilínea
             */
            bool exito; 
            do {
                Console.Write("Valor de y: ");
                 exito = int.TryParse(Console.ReadLine(), out y);

                if (!exito)
                {
                    Console.WriteLine("Error");
                }

            } while (!exito); // exito == false  ó exito != true

            suma = x + y;
            Console.WriteLine(x + "+" + y +"=" + suma);
            Console.WriteLine("{0} + {1} = {2}",x,y,x+y);

            Console.ReadKey();
        }
    }
}
