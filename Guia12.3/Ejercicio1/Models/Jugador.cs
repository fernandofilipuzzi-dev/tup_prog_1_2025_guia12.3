using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Jugador
    {
        public string Nombre { get; set; }
        public int SetGanados { get; set; }

        public void RegistrarResultadoSet(int valorSet)
        {
            SetGanados += valorSet;
        }
    }
}
