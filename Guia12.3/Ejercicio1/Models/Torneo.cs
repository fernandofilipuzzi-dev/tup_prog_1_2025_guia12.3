
using Ejercicio1.Models;

namespace Ejercicio1.Models
{
    internal class Torneo
    {
        public Jugador Jugador1 { get; set; }
        public Jugador Jugador2 { get; set; }

        public int NumeroSetsRegistrados { get; private set; } = 0;

        public void AnotarResultadosSet(int valorSet1, int valorSet2)
        { 
            if(valorSet1>valorSet2)
                Jugador1.SetGanados++;
            if (valorSet1 < valorSet2)
                Jugador2.SetGanados++;

            NumeroSetsRegistrados++;
        }

        public Jugador DeterminarGanador()
        {
            if (Jugador1.SetGanados > Jugador2.SetGanados)
                return Jugador1;
            if (Jugador2.SetGanados > Jugador1.SetGanados)
                return Jugador2;
            return null;
        }
    }
}
