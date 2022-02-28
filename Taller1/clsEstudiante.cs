using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    public class clsEstudiante : clsAbsPersona
    {
        public int Edad { get; set; }
        public int Facultad { get; set; }
        public override string Identificacion { get; set; }
        public override string Nombres { get; set; }
        public override string Apellidos { get; set; }
        public override int Sexo { get; set; }
        
        public clsEstudiante()
        {

        }
        public clsEstudiante(string _Identificacion, string _Nombres, string _Apellidos, int _Sexo,
            int _Edad, int _Facultad)
        {
            Edad = _Edad;
            Facultad = _Facultad; 
            Identificacion = _Identificacion;
            Nombres = _Nombres;
            Apellidos = _Apellidos;
            Sexo = _Sexo;
        }

        
    }
}
