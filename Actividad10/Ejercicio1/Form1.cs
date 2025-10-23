using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        CentroDeAtencion centro = new CentroDeAtencion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportarSolicitudes_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                FileStream fs = null;

                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                    centro.ImportarCsvSolicitudesEntrantes(fs);

                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                finally { if (fs != null) { fs.Close(); } }
                VerSolistudesPendientes();
            }
        }
        protected void VerSolistudesPendientes()
        {
            lbsVerSolicitudesImportadas.Items.Clear();

            LinkedListNode<Solicitud> nodo = centro.GetSolicitudPedientes();
            while (nodo != null)
            {
                lbsVerSolicitudesImportadas.Items.Add(nodo.Value);
                nodo = nodo.Next;
            }
        }
        protected void VerSolicitudesAAtender()
        {

            lbsColaSolicitudesAAtender.Items.Clear();
            lbsColaSolicitudesAAtender.Items.AddRange(centro.VerdDescripcioColaAtencion());
        }

        private void lbsVerSolicitudesImportadas_SelectedValueChanged(object sender, EventArgs e)
        {
            Solicitud seleccionada = lbsVerSolicitudesImportadas.SelectedItem as Solicitud;

            if (seleccionada != null)
            {

                lbSolicitudSeleccionado.Text = seleccionada.ToString();
            }

        }

        private void btnConfirmarAtencion_Click(object sender, EventArgs e)
        {
            Solicitud seleccionada = lbsVerSolicitudesImportadas.SelectedItem as Solicitud;
            if (seleccionada !=null)
            {

                centro.Atender(seleccionada);
                VerSolistudesPendientes();
                VerSolicitudesAAtender();

                lbsVerSolicitudesImportadas.SelectedItem = null;
                lbSolicitudSeleccionado.Text = seleccionada.ToString() ;

            }


        }
    }
}
