using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    class ejercicio1
    {
        public static void Ejercicio_1()
        {

            List<string> Frutas = new List<string>();
            int dec, num, pos, op;
            string n; //n es la variable del nombre de la fruta
            do
            {
                Console.Clear();
                Console.WriteLine("1-)Agregar a lista");
                Console.WriteLine("2-)Mostrar lista");
                Console.WriteLine("3-)Insertar en la lista");
                Console.WriteLine("4-)Eliminar de la lista");
                Console.WriteLine("5-)Buscar en la lista");
                Console.WriteLine("6-)Vaciar lista");
                Console.WriteLine("7-)Salir");
                Console.WriteLine();
                Console.Write("Elija una opcion:  ");
                dec = Convert.ToInt32(Console.ReadLine());
                switch (dec)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Agrege el nombre de la fruta");
                        n = Console.ReadLine();
                        Frutas.Add(n);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Lista de Frutas");
                        Console.WriteLine();
                        num = 1;
                        foreach (string fruta in Frutas)
                        {
                            Console.WriteLine(num + "-)" + fruta);
                            num++;
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese la posicion a la cual insertar");
                        pos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nombre de la fruta a insertar");
                        Console.Write("Fruta: ");
                        n = Console.ReadLine();
                        Frutas.Insert(pos, n);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Ingrese  la fruta a eliminar");
                        n = Console.ReadLine();
                        Frutas.Remove(n);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Ingrese la fruta a buscar");
                        n = Console.ReadLine();
                        pos = Frutas.IndexOf(n);
                        Console.WriteLine("La fruta " + n + " Se encuentra en la posicion " + pos + 1);
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Esta seguro de querer vaciar la lista???");
                        Console.WriteLine("1-)Si        2-)No");
                        do
                        {
                            op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    Frutas.Clear();
                                    Console.WriteLine("Se vacio correctamente");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opción válida");
                                    break;
                            }
                        } while (op < 0 || op > 2);
                        break;
                    case 7:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una opcion valida");
                        Console.ReadKey();
                        break;
                }
            } while (dec != 7);

        }
    }
}
