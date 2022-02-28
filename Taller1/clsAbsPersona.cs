using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    public abstract class clsAbsPersona
    {
        public abstract string Identificacion { get; set; }
        public abstract string Nombres { get; set; }
        public abstract string Apellidos { get; set; }
        public abstract int Sexo { get; set; }
    }
}
