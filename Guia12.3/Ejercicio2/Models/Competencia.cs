using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Competencia
    {
        Competidor[] competidores = new Competidor[100];
        public int Contador { get; private set; }

        public Competencia()
        {
            Contador = 0;
        }

        public Competidor VerRegistro(int idx)
        {
            if (idx >= 0 && idx < Contador)
            {
                return competidores[idx];
            }
            return null;
        }

        public void AgregarCompetidor(string nombre)
        {
            competidores[Contador] = new Competidor();
            competidores[Contador].Nombre = nombre;
            Contador++;
        }

        public void CargarTiempo(int numeroCompetidor, int HH, int MM)
        {
            competidores[numeroCompetidor].Tiempo = HH*60+MM;
        }

        public void OrderListadoPorTiempo()
        {
            for (int act = 0; act < Contador-1; act++)
            {
                for (int sig = act+1; sig < Contador; sig++)
                {
                    if (competidores[act].Tiempo > competidores[sig].Tiempo)
                    {
                        Intercambiar(act, sig);
                    }
                }
            }
        }

        void Intercambiar(int act, int sig)
        {
            Competidor tmp = competidores[act];
            competidores[act] = competidores[sig];
            competidores[sig] = tmp;
        }
    }
}
