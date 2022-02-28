using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public class Menu : Crud
    {
        string opcion_menu = "";
        string opcion_menu_estudiante = "";
        string opcion_menu_profesor = "";
        public void iniciar()
        {
            //do
            //{
                cabecera();

            //} while (opcion_menu != "c");
        }

        private void cabecera()
        {
            Console.Clear();
            Console.WriteLine("       ******  BIENVENIDO  ******");
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("ESCOJA UNA OPCIÓN\n");

            Console.WriteLine("a. Estudiantes");
            Console.WriteLine("b. Profesores");
            Console.WriteLine("c. Salir\n");
            opcion_menu = Console.ReadLine();
            seleccion_menu(opcion_menu);
        }

        private void seleccion_menu(string opc)
        {
            if (opc == "")
                return;
            switch (opc)
            {
                case "a":
                    Console.Clear();
                    menu_estudiante();
                    Console.ReadLine();
                    break;
                case "b":
                    Console.Clear();
                    menu_profesor();
                    Console.ReadKey();
                    break;
                case "c":
                    Console.Clear();
                    Console.WriteLine("Saliendo del programa...");
                    Console.ReadKey();
                    break;
                case "r":
                    Console.Clear();
                    iniciar();
                    //Console.ReadKey();
                    break;
                default:
                    Console.Clear(); 
                    Console.WriteLine("Selección no válida\n");
                    Console.WriteLine("Presione Enter para regresar al menú principal");
                    Console.ReadKey();
                    cabecera();
                    break;
            }
        }

        private void menu_estudiante()
        {
            Console.Clear();
            Console.WriteLine("---------SECCIÓN ESTUDIANTES---------\n");
            Console.WriteLine("ESCOJA UNA OPCIÓN");
            Console.WriteLine("\n1. Insertar");
            Console.WriteLine("2. Eliminar");
            Console.WriteLine("3. Modificar");
            Console.WriteLine("4. Listar todos");
            Console.WriteLine("5. Regresar al menú principal\n");
            opcion_menu_estudiante = Console.ReadLine();
            seleccion_menu_estudiante(opcion_menu_estudiante);
        }

        private void seleccion_menu_estudiante(string opc2)
        {
            if (opc2 == "")
                return;
            switch (opc2)
            {
                case "1":
                    Console.Clear();
                    crearEstudiante();
                    retornar_menu();
                    break;
                case "2":
                    Console.Clear();
                    eliminarEst();
                    retornar_menu();
                    break;
                case "3":
                    Console.Clear();
                    modificarEst();
                    retornar_menu();
                    break;
                case "4":
                    Console.Clear();
                    listaEst();
                    retornar_menu();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Presione Enter para regresar al menú principal");
                    Console.ReadLine();
                    cabecera();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Selección no válida\n");
                    Console.WriteLine("Presione Enter para regresar");
                    Console.ReadKey();
                    menu_estudiante();
                    break;
            }
        }

        private void menu_profesor()
        {
            Console.Clear();
            Console.WriteLine("---------SECCIÓN PROFESORES---------\n");
            Console.WriteLine("ESCOJA UNA OPCIÓN");
            Console.WriteLine("\n1. Insertar");
            Console.WriteLine("2. Eliminar");
            Console.WriteLine("3. Modificar");
            Console.WriteLine("4. Listar todos");
            Console.WriteLine("5. Regresar al menú principal\n");
            opcion_menu_profesor = Console.ReadLine();
            seleccion_menu_profesor(opcion_menu_profesor);
        }

        private void seleccion_menu_profesor(string opc3)
        {
            if (opc3 == "")
                return;
            switch (opc3)
            {
                case "1":
                    Console.Clear();
                    crearProfesor();
                    retornar_menu();
                    break;
                case "2":
                    Console.Clear();
                    eliminarProf();
                    retornar_menu();
                    break;
                case "3":
                    Console.Clear();
                    modificarProf();
                    retornar_menu();
                    break;
                case "4":
                    Console.Clear();
                    listaProf();
                    retornar_menu();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Presione Enter para regresar al menú principal");
                    Console.ReadLine();
                    cabecera();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Selección no válida\n");
                    Console.WriteLine("Presione Enter para regresar");
                    Console.ReadKey();
                    menu_profesor();
                    break;
            }
        }


        private void retornar_menu()
        {
            string opcR;
            Console.WriteLine("\nIngrese r para retornar al menú principal");
            opcR = Console.ReadLine();
            seleccion_menu(opcR);
        }

    }
}
