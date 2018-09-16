using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    class Capitulo9
    {
        public Capitulo9() { }


        /// <summary>
        /// Estructura para guardar los productos de una tienda.
        /// </summary>
        public struct Producto
            {
                public int Codigo;
                public string Nombre;
                public double Precio;

                public Producto(int Codigop, string Nombrep, double Preciop)
                {
                    Codigo = Codigop;
                    Nombre = Nombrep;
                    Precio = Preciop;
                }
            }
        
        public static void Ejercicio1()
            {
                Producto producto;
                producto.Codigo = 00092;
                producto.Nombre = "PAN";
                producto.Precio = 50;
                Console.WriteLine("Codigo de Barras: " + producto.Codigo + "\nNombre del Producto: "
                                  + producto.Nombre + "\nPrecio del Producto: " + producto.Precio);
                Console.ReadKey();
            }
        /// <summary>
        /// Crear estructura una dueño y otra Mascota.
        /// </summary>
        public struct Mascota
            {
                public string Nombre;
                public int Edad;
                public string Raza;

                public Mascota(string Nombrem, int Edadm, string Razam)
                {
                    Nombre = Nombrem;
                    Edad = Edadm;
                    Raza = Razam;
                }
            }

            public struct Dueño
            {
                public string Nombre;
                public int Edad;
                public Mascota mascota;

                public Dueño(string Nombred, int Edadd, string Nombrem, int Edadm, string Razam)
                {
                    Nombre = Nombred;
                    Edad = Edadd;
                    mascota = new Mascota(Nombrem, Edadm, Razam);
                }
            }

        /// <summary>
        /// Crear estructuras enlazadas para guardar la información de una mascota y su dueño.
        /// </summary>
        public static void Ejercicio3()
            {
                Dueño dueño;
                dueño.Nombre = "Joaquin Guzman Loera";
                dueño.Edad = 17;
                dueño.mascota.Nombre = "Miaaauuuuu";
                dueño.mascota.Raza = "Misuu";
                dueño.mascota.Edad = 30;



            Console.WriteLine("Nombre del Dueño: " + dueño.Nombre + "\nEdad del Dueño: "
                            + dueño.Edad + "\nNombre de la Mascota: " + dueño.mascota.Nombre
                            + "\nTipo de Mascota: " + dueño.mascota.Raza + "\nEdad de La Mascota: "
                            + dueño.mascota.Edad);
            }
        /// <summary>
        /// Ejercicio utilizando Enum (4)
        /// Enumeraciones (0,1,2)
        /// </summary>
        public enum Neumaticos
            {
                Neumaticos_Anchos,
                NeumaticosXL,
                NeumaticosUsados,
                NeumaticosRecauchutados,
                NeumaticosBajo
                
            };

            public static void Ejercicio4()
            {
                Console.Clear();
                Console.WriteLine("Lista de neumaticos disponibles: ");
                Console.WriteLine(Neumaticos.Neumaticos_Anchos.ToString());
                Console.WriteLine(Neumaticos.NeumaticosXL.ToString());
                Console.WriteLine(Neumaticos.NeumaticosUsados.ToString());
                Console.WriteLine(Neumaticos.NeumaticosRecauchutados.ToString());
                Console.WriteLine(Neumaticos.NeumaticosBajo.ToString());
                Console.ReadKey();
            }
        
    }
}
