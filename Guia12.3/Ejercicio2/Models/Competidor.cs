using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Competidor
    {
        public string Nombre { get; set; }
        public int Tiempo { get; set; }

        public void VerTiempoEnHHMM(out int HH, out int MM)
        {
            HH = Tiempo / 60;
            MM = Tiempo % 60;
        }
    }
}
