using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    public class clsProfesor : clsAbsPersona
    {
        public DateTime FechaIngreso { get; set; }
        public string Profesion { get; set; }
        public string Universidad { get; set; }
        public int YearCulminacion { get; set; }
        public override string Identificacion { get; set; }
        public override string Nombres { get; set; }
        public override string Apellidos { get; set; }
        public override int Sexo { get; set; }

        public clsProfesor()
        {

        }
        public clsProfesor(string _Identificacion, string _Nombres, string _Apellidos, int _Sexo, 
            DateTime _FechaIngreso, string _Profesion, string _Universidad, int _YearCulminacion)
        {
            FechaIngreso = _FechaIngreso;
            Profesion = _Profesion;
            Universidad = _Universidad;
            YearCulminacion = _YearCulminacion;
            Identificacion = _Identificacion;
            Nombres = _Nombres;
            Apellidos = _Apellidos;
            Sexo = _Sexo;
        }
        
    }
}
