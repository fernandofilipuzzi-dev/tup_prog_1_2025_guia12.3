using Ejercicio2.Models;
using System;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        Competencia competencia = new Competencia();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarCompetidor_Click(object sender, EventArgs e)
        {
            FormRegistrarCompetidor fRegistro= new FormRegistrarCompetidor();

            if (fRegistro.ShowDialog() == DialogResult.OK)
            {
                string nombre = fRegistro.tbNombre.Text;

                competencia.AgregarCompetidor(nombre);

                fRegistro.tbNombre.Clear();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            FormRegistrarCompetidor fRegistro = new FormRegistrarCompetidor();
            
            if (fRegistro.ShowDialog() == DialogResult.OK)
            {
                string nombre = fRegistro.tbNombre.Text;

                competencia.AgregarCompetidor(nombre);

                fRegistro.tbNombre.Clear();
            }
        }

        private void btnCargarTiempos_Click(object sender, EventArgs e)
        {
            FormCargarTiempos fCargaTiempos = new FormCargarTiempos();

            int n = 0;

            fCargaTiempos.lbNumero.Text = n.ToString("000");

            while (n < competencia.Contador && fCargaTiempos.ShowDialog()==DialogResult.OK)
            {

                int hh = Convert.ToInt32(fCargaTiempos.tbHH.Text);
                int mm = Convert.ToInt32(fCargaTiempos.tbMM.Text);

                competencia.CargarTiempo(n, hh,mm);

                n++;

                #region preparando al ventana para el próximo show
                fCargaTiempos.lbNumero.Text = n.ToString("000");//la proxima
                fCargaTiempos.tbHH.Clear();
                fCargaTiempos.tbMM.Clear();
                #endregion
            }
        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            FormVerResultado fVer = new FormVerResultado();

            competencia.OrderListadoPorTiempo();

            fVer.lbxResultados.Items.Clear();
            for (int n = 0; n < competencia.Contador; n++)
            {
                Competidor c=competencia.VerRegistro(n);

                int HH;
                int MM;
                c.VerTiempoEnHHMM(out HH, out MM);

                fVer.lbxResultados.Items.Add($"{n:000} - {c.Nombre} - {HH:00}:{MM:00}");
            }

            fVer.ShowDialog();
        }
    }
}
