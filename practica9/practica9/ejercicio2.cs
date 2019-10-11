using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    class ejercicio2
    {
        public struct Alumnos
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private decimal cum;


            public void setCum(decimal cum)
            {
                if (cum >= 0)
                {
                    if (cum <= 10)
                    {
                        this.cum = cum;
                    }


                }
            }

            public decimal getCum()
            {
                return cum;
            }


        }



        public static void Ejercicio_2()
        {

            Dictionary<string, Alumnos> datosA = new Dictionary<string, Alumnos>();


            int op;
            do
            {
                Console.WriteLine();
                Console.WriteLine("=========================");
                Console.WriteLine("  1-)Agregar Alumno ");
                Console.WriteLine("  2-)Mostrar Alumnos ");
                Console.WriteLine("  3-)Eliminar Alumno ");
                Console.WriteLine("  4-)Buscar Alumno ");
                Console.WriteLine("  6-)Vaciar Diccionario ");
                Console.WriteLine("  7-)Salir ");
                Console.WriteLine("=========================");
                op = Convert.ToInt32(Console.ReadLine());
                int cant;

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Cuantos alumnos desea ingresar: ");
                        cant = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        for (int i = 0; i < cant; i++)
                        {
                            Alumnos A = new Alumnos();
                            Console.WriteLine("Alumno numero{0}", i + 1);
                            do
                            {
                                Console.Write("Ingrese el carnet del alumno: ");
                                A.carnet = Console.ReadLine();
                                if (datosA.ContainsKey(A.carnet))
                                {
                                    Console.WriteLine("El carnet: {0} ya existe...", A.carnet);
                                }

                            } while (datosA.ContainsKey(A.carnet));


                            Console.Write("Ingrese el nombre del Alumno: ");
                            A.nombre = Console.ReadLine();
                            Console.Write("Ingrese la carrera del Alumno: ");
                            A.carrera = Console.ReadLine();
                            Console.WriteLine("Ingrese el CUM del Alumno: ");
                            A.setCum(Convert.ToDecimal(Console.ReadLine()));
                            datosA.Add(A.carnet, A);

                        }
                        break;
                    case 2:
                        Console.Clear();
                        foreach (KeyValuePair<string, Alumnos> datos in datosA)
                        {
                            Console.WriteLine(datos);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        string e;
                        Console.WriteLine("Ingrese el carnet del alumno que desea eliminar");
                        e = Console.ReadLine();
                        datosA.Remove(e);
                        foreach (KeyValuePair<string, Alumnos> datos in datosA)
                        {
                            Console.WriteLine(datos);
                        }

                        break;
                    case 4:
                        Console.Clear();
                        string b;
                        Console.WriteLine("Ingrese el alumno que desea buscar");
                        b = Console.ReadLine();

                        do
                        {

                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("El alumno se encuentra en la lista.");


                        } while ((datosA.ContainsKey(b)));
                        break;
                    case 5:
                        int dec;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Esta seguro de vaciar los datos??");
                            Console.WriteLine("1-)Si        2-)No");
                            Console.WriteLine();
                            dec = Convert.ToInt32(Console.ReadLine());
                            switch (dec)
                            {
                                case 1:
                                    datosA.Clear();
                                    Console.WriteLine("Los datos han sido eliminados");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    break;
                                default:
                                    break;
                            }

                        } while (dec < 0 || dec > 2);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Presione <Enter> para salir");
                        break;
                }
            } while (op != 7);
        }
    }
}
