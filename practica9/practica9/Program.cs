using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("***************************************");
                Console.WriteLine("               Practica 9");
                Console.WriteLine("***************************************");
                Console.WriteLine();
                Console.WriteLine("Seleccione ejercicio a ver");
                Console.WriteLine();
                Console.WriteLine("1-)Ejercicio 1");
                Console.WriteLine("2-)Ejercicio 2");
                Console.WriteLine("3-)Salir");
                Console.WriteLine();
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        ejercicio1.Ejercicio_1();
                        break;
                    case 2:
                        Console.Clear();
                        ejercicio2.Ejercicio_2();
                        break;
                    case 3:
                        break;
                  
                }
            } while (op != 3);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
