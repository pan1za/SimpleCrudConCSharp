using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    public class Crud
    {
        List<clsEstudiante> datasetEst = new List<clsEstudiante>();
        List<clsProfesor> datasetProf = new List<clsProfesor>();
        String[] ListGenero = new string[3] { " ", "Hombre", "Mujer"};
        String[] ListFacultades = new string[5] { " ", "Ingeniería", "Medicina", "Ciencias Sociales", "Ciencias Administrativas" };
        string Identificacion, Nombres, Apellidos, Profesion, Universidad;
        int Sexo, Edad, Facultad, YearCulminacion;
        DateTime FechaIngreso;

        //---------------------------------ESTUDIANTES-------------------------------------------//
        public void crearEstudiante()
        {
            Console.WriteLine("---------CREAR UN NUEVO ESTUDIANTE---------\n");
            Console.Write("Identificación: ");
            string id =  Console.ReadLine();
            int n;
            bool result = Int32.TryParse(id, out n);
            if (result)
            {
                Identificacion = id;
            }else
            {
                Console.WriteLine("Ingrese una identifiacion valida");
                return;
            }
            Console.Write("\nNombres: ");
            Nombres = Console.ReadLine();
            Console.Write("\nApellidos: ");
            Apellidos = Console.ReadLine();
            Console.Write("\nSexo:\n1. Masculino\n2. Femenino\n");
            Sexo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEdad: ");
            Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nFacultad:\n1. Ingenieria\n2. Medicina\n3. Ciencias Sociales\n4. Ciencias administrativas\n");
            Facultad = Convert.ToInt32(Console.ReadLine());

            datasetEst.Add(new clsEstudiante(Identificacion, Nombres, Apellidos, Sexo, Edad, Facultad));
            
            Console.Clear();
            Console.WriteLine("\nEstudiante guardado");
        }

        private bool listaVaciaEst()
        {
            if (datasetEst.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void listaEst()
        {
            if (listaVaciaEst() == true)
            {
                Console.WriteLine("No se encuentra ningun estudiante en la  lista");
            }
            else
            {
                Console.WriteLine("Total de registros de estudiantes en la lista: "+ datasetEst.Count);
                Console.WriteLine("------------------------LISTA------------------------");

                foreach (clsEstudiante item in datasetEst)
                {
                    imprimirEstudiante(item);
                }
            }
            Console.WriteLine("\n");
        }

        private void imprimirEstudiante(clsEstudiante datoEst)
        {
            if (datoEst.Sexo == 1 || datoEst.Sexo == 2 || datoEst.Sexo == 3 || datoEst.Facultad == 1 || datoEst.Facultad == 2 || datoEst.Facultad == 3 || datoEst.Facultad == 4)
            {
                Console.WriteLine("Identificación: {0} | Nombres: {1} | Apellidos: {2} | Sexo: {3} | Edad: {4} | Facultad: {5} | ",
                datoEst.Identificacion, datoEst.Nombres, datoEst.Apellidos, ListGenero.GetValue(datoEst.Sexo), datoEst.Edad, ListFacultades.GetValue(datoEst.Facultad));
            }
        }

        public void eliminarEst()
        {
            string Identificacion = "";
            if (listaVaciaEst() == true)
            {
                Console.WriteLine("No se encuentra ningún dato en la lista");
            }
            else
            {   
                Console.Write("Ingrese la identificación para eliminar los datos: ");
                Identificacion = Console.ReadLine();
                bool elim = false;
                foreach (var item in datasetEst)
                {
                    if (Identificacion == item.Identificacion)
                    {
                        datasetEst.Remove(item);
                        Console.WriteLine("\nEl estudiante ha sido eliminado");
                        elim = true;
                        break;
                    } 
                }
                if (elim == false)
                {
                    Console.WriteLine("\nNo se encuentra la identificación del estudiante");
                }
            }
        }

        public void modificarEst()
        {
            if (listaVaciaEst() == true)
            {
                Console.WriteLine("No se encuentra ningun dato");
            }
            else
            {
                clsEstudiante e = new clsEstudiante();
                string buscar;
                Console.Write("Ingrese la identifiación: ");
                buscar = Console.ReadLine();
                foreach (clsEstudiante item in datasetEst)
                {
                    if (buscar == item.Identificacion)
                    {
                        Console.WriteLine("Identificación: {0} | Nombres: {1} | Apellidos: {2} | Sexo: {3} | Edad: {4} | Facultad: {5} | ",
                            item.Identificacion, item.Nombres, item.Apellidos, item.Sexo, item.Edad, item.Facultad);
                        Console.WriteLine("------------------------------------\n\n");
                        Console.Write("Identificación: ");
                        e.Identificacion = Console.ReadLine();
                        item.Identificacion = e.Identificacion;
                        Console.Write("Nombres: ");
                        e.Nombres = Console.ReadLine();
                        item.Nombres = e.Nombres;
                        Console.Write("Apellidos: ");
                        e.Apellidos = Console.ReadLine();
                        item.Apellidos = e.Apellidos;
                        Console.Write("Sexo:\n1. Masculino\n2. Femenino");
                        e.Sexo = Convert.ToInt32(Console.ReadLine());
                        item.Sexo = e.Sexo;
                        Console.Write("Edad: ");
                        e.Edad = Convert.ToInt32(Console.ReadLine());
                        item.Edad = e.Edad;
                        Console.Write("Facultad:\n1. Ingenieria\n2. Medicina\n3. Ciencias Sociales\n4. Ciencias administrativas\n");
                        e.Facultad = Convert.ToInt32(Console.ReadLine());
                        item.Facultad = e.Facultad;
                        Console.WriteLine("\n");
                        Console.WriteLine("Sus datos han sido modificados");
                    }
                }
            }
        }

        //-------------------------------------PROFESORES--------------------------------------------//

        public void crearProfesor()
        {
            Console.WriteLine("---------CREAR UN NUEVO PROFESOR---------\n");
            Console.Write("Identificación: ");
            Identificacion = Console.ReadLine();
            Console.Write("\nNombres: ");
            Nombres = Console.ReadLine();
            Console.Write("\nApellidos: ");
            Apellidos = Console.ReadLine();
            Console.Write("\nSexo:\n1. Masculino\n2. Femenino\n");
            Sexo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nFecha de ingreso: ");
            FechaIngreso = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\nProfesión: ");
            Profesion = Console.ReadLine();
            Console.Write("\nUniversidad: ");
            Universidad = Console.ReadLine();
            Console.Write("\nAño de culminación: ");
            YearCulminacion = Convert.ToInt32(Console.ReadLine());

            datasetProf.Add(new clsProfesor(Identificacion, Nombres, Apellidos, Sexo, FechaIngreso, Profesion, Universidad, YearCulminacion));

            Console.WriteLine("\nProfesor guardado");
            Console.Clear();
        }

        private bool listaVaciaProf()
        {
            if (datasetProf.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void listaProf()
        {
            if (listaVaciaProf() == true)
            {
                Console.WriteLine("No se encuentra ningun profesor en la lista");
            }
            else
            {
                Console.WriteLine("Total de registros de profesores en la lista: " + datasetProf.Count);
                Console.WriteLine("------------------------LISTA------------------------");

                foreach (clsProfesor item in datasetProf)
                {
                    imprimirProfesor(item);
                }
            }
            Console.WriteLine("\n");
        }

        private void imprimirProfesor(clsProfesor datoProf)
        {
            string genero;
            if (datoProf.Sexo == 1 || datoProf.Sexo == 2 || datoProf.Sexo == 3)
            {
                Console.WriteLine("Identificación: {0} | Nombres: {1} | Apellidos: {2} | Sexo: {3} | Fecha de ingreso: {4} | Profesión: {5} | Universidad: {6} | Año de culminación: {7} |",
                datoProf.Identificacion, datoProf.Nombres, datoProf.Apellidos, ListGenero.GetValue(datoProf.Sexo), datoProf.FechaIngreso, datoProf.Profesion, datoProf.Universidad, datoProf.YearCulminacion);
            }


        }

        public void eliminarProf()
        {
            string Identificacion = "";
            if (listaVaciaProf() == true)
            {
                Console.WriteLine("No se encuentra ningún dato en la lista");
            }
            else
            {
                Console.Write("Ingrese la identificación para eliminar los datos: ");
                Identificacion = Console.ReadLine();
                bool elim = false;
                foreach (var item in datasetProf)
                {
                    if (Identificacion == item.Identificacion)
                    {
                        /*Console.WriteLine("Identificación: {0} | Nombres: {1} | Apellidos: {2} | Sexo: {3} | Fecha de ingreso: {4} | Profesión: {5} | Universidad: {6} | Año de culminación: {7} |",
                            item.Identificacion, item.Nombres, item.Apellidos, item.Sexo, item.FechaIngreso, item.Profesion, item.Universidad, item.YearCulminacion);*/
                        datasetProf.Remove(item);
                        Console.WriteLine("\nEl profesor ha sido eliminado");
                        elim = true;
                        break;
                    }
                    if (elim == false)
                    {
                        Console.WriteLine("\nNo se encuentra la identificación del profesor");
                    }
                }
            }
        }

        public void modificarProf()
        {
            if (listaVaciaProf() == true)
            {
                Console.WriteLine("No se encuentra ningun dato");
            }
            else
            {
                clsProfesor p = new clsProfesor();
                string buscar;
                Console.Write("Ingrese la identifiación: ");
                buscar = Console.ReadLine();
                foreach (clsProfesor item in datasetProf)
                {
                    if (buscar == item.Identificacion)
                    {
                        Console.WriteLine("Identificación: {0} | Nombres: {1} | Apellidos: {2} | Sexo: {3} | Fecha de ingreso: {4} | Profesión: {5} | Universidad: {6} | Año de culminación: {7} |",
                            item.Identificacion, item.Nombres, item.Apellidos, item.Sexo, item.FechaIngreso, item.Profesion, item.Universidad, item.YearCulminacion);
                        Console.WriteLine("------------------------------------\n\n");
                        Console.Write("Identificación: ");
                        p.Identificacion = Console.ReadLine();
                        item.Identificacion = p.Identificacion;
                        Console.Write("Nombres: ");
                        p.Nombres = Console.ReadLine();
                        item.Nombres = p.Nombres;
                        Console.Write("Apellidos: ");
                        p.Apellidos = Console.ReadLine();
                        item.Apellidos = p.Apellidos;
                        Console.Write("Sexo:\n1. Masculino\n2. Femenino");
                        p.Sexo = Convert.ToInt32(Console.ReadLine());
                        item.Sexo = p.Sexo;
                        Console.Write("Fecha de ingreso: ");
                        p.FechaIngreso = Convert.ToDateTime(Console.ReadLine());
                        item.FechaIngreso = p.FechaIngreso;
                        Console.Write("Profesión: ");
                        p.Profesion = Console.ReadLine();
                        item.Profesion = p.Profesion;
                        Console.Write("Universidad: ");
                        p.Universidad = Console.ReadLine();
                        item.Universidad = p.Universidad;
                        Console.Write("Año de culminación: ");
                        p.YearCulminacion = Convert.ToInt32(Console.ReadLine());
                        item.YearCulminacion= p.YearCulminacion;
                        Console.WriteLine("\n");
                        Console.WriteLine("Sus datos han sido modificados");
                    }
                }
            }
        }

    }
}
