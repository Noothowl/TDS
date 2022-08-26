using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA2_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            int[,] matriz=new int[0,0];
            int d0, d1;
            int f, c;
            bool matrizCreada = false;

            
            do
            {
                ImprimirMenu();
                int.TryParse(Console.ReadLine(), out op);
                switch (op)
                {
                    case 1:
                        
                        Console.WriteLine("Creando Matriz");
                        Console.WriteLine("**************");
                        

                        Console.Write("Valor primera dimensión:");
                        d0 = PedirDimension();
                        Console.Write("Valor segunda dimensión:");
                        d1 = PedirDimension();

                        matriz = new int[d0, d1];
                        Console.WriteLine("Matriz de {0}x{1} creada exitosamente.",d0,d1);
                        matrizCreada = true;
                        Console.ReadKey();

                        break;
                    case 2:
                        if (matrizCreada)
                        {
                            LlenarMatriz(matriz);
                            Console.WriteLine("Matriz llenada exitosamente.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Error("Es necesario construir la matriz antes de continuar.");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        if (matrizCreada)
                        {
                            ImprimirMatriz(matriz);
                        }
                        else
                        {
                            Error("Es necesario construir la matriz antes de continuar.");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        if (matrizCreada)
                        {

                        }
                        else
                        {
                            Error("Es necesario construir la matriz antes de continuar.");
                            Console.ReadKey();
                        }
                        break;
                    case 5: break;
                    default:
                        Error("Opción no válida");
                        Console.ReadKey();
                        break;
                }

            } while (op != 5);
        }

        private static void ImprimirMatriz(int[,] matriz)
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void LlenarMatriz(int[,] matriz)
        {
            Random rand = new Random();
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    matriz[f, c] = rand.Next(10, 100);
                }
            }
        }

        private static int PedirDimension()
        {
            int d;
            bool exito;
            do
            {
                exito = int.TryParse(Console.ReadLine(), out d);
                if (!exito || d<=0)
                {
                    Error("Valor no válido. Ingresa nuevamente");
                }
            } while (!exito || d<=0);
            return d;
        }

        private static void Error(string m)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(m);
            Console.ResetColor();
        }

        private static void ImprimirMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("MENU");
            Console.WriteLine("******");
            Console.WriteLine("1.Construir Matriz");
            Console.WriteLine("2.Llenar Matriz con números al azar");
            Console.WriteLine("3.Imprimir Matriz");
            Console.WriteLine("4.Imprimir Matriz sin diagonales");
            Console.WriteLine("5.Salir");
            Console.Write("Opción: ");

        }
    }
}
