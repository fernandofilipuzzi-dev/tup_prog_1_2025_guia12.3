using Ejercicio1.Models;
using Ejercicio1_Tenis;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        Torneo torneo = new Torneo();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Jugador jugador1 = new Jugador();
            jugador1.Nombre = tbNombre1.Text;
            torneo.Jugador1 = jugador1;

            Jugador jugador2 = new Jugador();
            jugador2.Nombre = tbNombre2.Text;
            torneo.Jugador2 = jugador2;


            groupBox1.Enabled = false;
        }

        private void btnAnotar_Click(object sender, EventArgs e)
        {

            FormSolicitarSet fSolicitarSets = new FormSolicitarSet();

            fSolicitarSets.lbNroSet.Text = $"{torneo.NumeroSetsRegistrados + 1}";

            int n = 0;
            while (n < 3 && fSolicitarSets.ShowDialog() == DialogResult.OK)
            {
                int resultado1 = Convert.ToInt32(fSolicitarSets.nudResultado1.Value);
                int resultado2 = Convert.ToInt32(fSolicitarSets.nudResultado2.Value);

                torneo.AnotarResultadosSet(resultado1, resultado2);

                fSolicitarSets.lbNroSet.Text = $"{torneo.NumeroSetsRegistrados + 1}";
                fSolicitarSets.nudResultado1.Value = 0;
                fSolicitarSets.nudResultado2.Value = 0;

                n++;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FormResultado fVer = new FormResultado();

            Jugador jugador = torneo.DeterminarGanador();
            if (jugador != null)
                fVer.tbResultado.Text = $"El ganador es: {jugador.Nombre}";
            else
                fVer.tbResultado.Text = $"No hubo ganador";


            fVer.ShowDialog();
        }
    }
}
