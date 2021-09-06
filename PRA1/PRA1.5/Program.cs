using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, digito, suma = 0;
            Console.Write("Ingresa un número: ");
            //numero = int.Parse(Console.ReadLine());

            if (int.TryParse(Console.ReadLine(), out numero))
            {

                Console.WriteLine("Numero ingresado: " + numero);
                do
                {
                    digito = numero % 10;
                    numero = numero / 10;

                    suma += digito;
                
                } while (numero != 0);

                Console.WriteLine("Suma de sus cifras: " + suma);

            }
            else
            {
                Console.WriteLine("Debes ingresar un número entero");
            }







            Console.ReadKey();
        }
    }
}
