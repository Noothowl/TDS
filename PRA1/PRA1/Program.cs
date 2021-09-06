using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA1
{
    class Program
    {
        static void Main(string[] args)
        {

            string texto;
            int largo;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("Ingresa un texto: ");
            texto = Console.ReadLine();
            largo = texto.Length;

            Console.WriteLine("Largo: " + largo);

            if (largo % 2 == 0)
            {//Es par, color es blanco
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {//Es impar, color rojo
                Console.ForegroundColor = ConsoleColor.Red;
            }


            for (int i = 0; i < largo; i++)
            {
                Console.WriteLine(texto);
            }

            Console.ReadKey();

            Console.ResetColor();
            Console.Clear();
            Console.ReadKey();


        }
    }
}
