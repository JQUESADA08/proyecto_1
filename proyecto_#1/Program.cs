using proyecto__1.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Cuando estudiantes vas a agregar?");
                int cant = int.Parse(Console.ReadLine());

                Estudiante[] listaEstudiante = new Estudiante[cant];

                int contador = 0;
                int op = 0;
                int cedula = 0;
                string nombre = "";
                int edad = 0;
                int edadDesde = 0;
                int edadHasta = 0;
                string direccionBuscar = "";

                while (op != 10)
                {
                    Console.WriteLine("Escoja una opcion");
                    Console.WriteLine("1-Agregar estudiante");
                    Console.WriteLine("2-Mostrar lista estudiantes");
                    Console.WriteLine("3-Buscar estudiante por cedula");
                    Console.WriteLine("4-Buscar estudiante por nombre");
                    Console.WriteLine("5-Eliminar estudiante");
                    Console.WriteLine("6-Actualizar informacion del estudiante");
                    Console.WriteLine("7-Buscar estudiante por edad");
                    Console.WriteLine("8-Buscar estudiante por rango edad");
                    Console.WriteLine("9-Buscar estudiante por direccion");

                    Console.WriteLine("10-Salir");
                    op = int.Parse(Console.ReadLine());//Esta a la espera que le ingreses un valor


                    switch (op)
                    {
                        case 1:
                            if (contador < cant)
                            {
                                Estudiante nuevoEstudiante = new Estudiante();//la clase estudiante se instancia aca(crear un nuevo objeto)

                                Console.WriteLine("Ingrese Nombre:");
                                nuevoEstudiante.Nombre = Console.ReadLine();

                                Console.WriteLine("Ingrese Apellidos");
                                nuevoEstudiante.Apellidos = Console.ReadLine();

                                Console.WriteLine("Ingrese Cedula:");
                                nuevoEstudiante.Cedula = int.Parse(Console.ReadLine());

                                Console.WriteLine("Ingrese Edad:");
                                nuevoEstudiante.Edad = int.Parse(Console.ReadLine());

                                Console.WriteLine("Ingrese Numero de telefono:");
                                nuevoEstudiante.NumeroTelefono = int.Parse(Console.ReadLine());

                                Console.WriteLine("Ingrese su Direccion:");
                                nuevoEstudiante.Direccion = Console.ReadLine();

                                listaEstudiante[contador] = nuevoEstudiante;
                                contador = contador + 1;
                            }
                            else
                            {
                                Console.WriteLine("Has excedido el espacio solicitado para registro de estudiantes");

                            }
                            break;
                        //Mostrar lista estudiantes
                        case 2:

                            for (int i = 0; i < listaEstudiante.Length; i++)
                            {

                                if (listaEstudiante[i] != null)
                                {
                                    Console.WriteLine(listaEstudiante[i].Cedula + " " + listaEstudiante[i].Nombre + " " + listaEstudiante[i].Apellidos + " " + listaEstudiante[i].Edad + " " + listaEstudiante[i].NumeroTelefono + " " + listaEstudiante[i].Direccion);


                                }
                            }

                            break;
                        //Buscar estudiante por cedula
                        case 3:
                            Console.WriteLine("Ingrese el numero de cedula del estudiante a buscar:");
                            cedula = int.Parse(Console.ReadLine());
                            for (int i = 0; i < listaEstudiante.Length; i++)
                            {
                                if (listaEstudiante[i] != null)
                                {
                                    if (cedula == listaEstudiante[i].Cedula)
                                    {
                                        Console.WriteLine(listaEstudiante[i].Cedula + " " + listaEstudiante[i].Nombre + " " + listaEstudiante[i].Apellidos + " " + listaEstudiante[i].Edad + " " + listaEstudiante[i].NumeroTelefono + " " + listaEstudiante[i].Direccion);
                                    }
                                }
                            }

                            break;
                        //Buscar estudiante por nombre
                        case 4:
                            Console.WriteLine("Ingrese el nombre del estudiante a buscar:");
                            nombre = Console.ReadLine();
                            for (int i = 0; i < listaEstudiante.Length; i++)
                            {
                                if (listaEstudiante[i] != null)
                                {
                                    if (nombre == listaEstudiante[i].Nombre)
                                    {
                                        Console.WriteLine(listaEstudiante[i].Cedula + " " + listaEstudiante[i].Nombre + " " + listaEstudiante[i].Apellidos + " " + listaEstudiante[i].Edad + " " + listaEstudiante[i].NumeroTelefono + " " + listaEstudiante[i].Direccion);
                                    }
                                }
                            }
                            break;

                        case 5:
                            Console.WriteLine("Ingrese el numero de cedula del estudiante a eliminar:");
                            cedula = int.Parse(Console.ReadLine());
                            for (int i = 0; i < listaEstudiante.Length; i++)
                            {
                                if (listaEstudiante[i] != null)
                                {
                                    if (cedula == listaEstudiante[i].Cedula)
                                    {
                                        listaEstudiante[i] = null;//le damos un valor vacio
                                        contador = contador - 1;
                                    }
                                }
                            }

                            break;

                        case 6:
                            Console.WriteLine("Ingrese el numero de cedula del estudiante a modificar:");
                            cedula = int.Parse(Console.ReadLine());
                            for (int i = 0; i < listaEstudiante.Length; i++)
                            {
                                if (listaEstudiante[i] != null)
                                {
                                    if (cedula == listaEstudiante[i].Cedula)
                                    {
                                        Console.WriteLine("Ingrese el nuevo nombre:");
                                        listaEstudiante[i].Nombre = Console.ReadLine();
                                        Console.WriteLine("Ingrese el nuevo apellido:");
                                        listaEstudiante[i].Apellidos = Console.ReadLine();
                                        Console.WriteLine("Ingrese la nuevo edad:");
                                        listaEstudiante[i].Edad = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese el nuevo direccion:");
                                        listaEstudiante[i].Direccion = Console.ReadLine();
                                        Console.WriteLine("Ingrese el nuevo numero de telefono:");
                                        listaEstudiante[i].NumeroTelefono = int.Parse(Console.ReadLine());
                                        break;
                                    }
                                }
                            }
                            break;

                        case 7:
                            Console.WriteLine("Ingrese la edad del estudiante a buscar:");
                            edad = int.Parse(Console.ReadLine());
                            for (int i = 0; i < listaEstudiante.Length; i++)
                            {
                                if (listaEstudiante[i] != null)
                                {

                                    if (edad == listaEstudiante[i].Edad)
                                    {
                                        Console.WriteLine(listaEstudiante[i].Cedula + " " + listaEstudiante[i].Nombre + " " + listaEstudiante[i].Apellidos + " " + listaEstudiante[i].Edad + " " + listaEstudiante[i].NumeroTelefono + " " + listaEstudiante[i].Direccion);
                                    }
                                }
                            }
                            break;

                        case 8:
                            Console.WriteLine("Ingrese la edad desde donde se comenzara a buscar:");
                            edadDesde = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese la edad hasta donde se comenzara a buscar:");
                            edadHasta = int.Parse(Console.ReadLine());

                            if (edadDesde < edadHasta)
                            {
                                for (int i = 0; i < listaEstudiante.Length; i++)
                                {
                                    if (listaEstudiante[i] != null)
                                    {
                                        if (edadDesde <= listaEstudiante[i].Edad && edadHasta >= listaEstudiante[i].Edad)
                                        {
                                            Console.WriteLine(listaEstudiante[i].Cedula + " " + listaEstudiante[i].Nombre + " " + listaEstudiante[i].Apellidos + " " + listaEstudiante[i].Edad + " " + listaEstudiante[i].NumeroTelefono + " " + listaEstudiante[i].Direccion);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error!! rango ingresado no es correcto.");
                            }

                            break;

                        case 9:
                            Console.WriteLine("Ingrese la direccion del estudiante a buscar:");
                            direccionBuscar = Console.ReadLine();
                            for (int i = 0; i < listaEstudiante.Length; i++)
                            {
                                if (listaEstudiante[i] != null)
                                {
                                    if (direccionBuscar == listaEstudiante[i].Direccion)
                                    {
                                        Console.WriteLine(listaEstudiante[i].Cedula + " " + listaEstudiante[i].Nombre + " " + listaEstudiante[i].Apellidos + " " + listaEstudiante[i].Edad + " " + listaEstudiante[i].NumeroTelefono + " " + listaEstudiante[i].Direccion);
                                    }
                                }
                            }
                            break;

                        case 10:
                            Console.WriteLine("Saliendo...");
                            Console.ReadKey();
                            break;

                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error !! Se ha encontrado un error de tipo " + ex.Message);
            }
        }
    }
}
