using PPAI_IVR.Clases;
using PPAI_IVR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_IVR_V2.Pantalla
{
    public partial class PantallaRegistrarRegRespuestaOperador : Form
    {
        public GestorRegRespuestaOperador gestor;
        public PantallaRegistrarRegRespuestaOperador(GestorRegRespuestaOperador gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

       
        private void RegistrarRegRespuestaOperador_Load(object sender, EventArgs e)
        {

        }

        internal void mostrarDatosLlamada(DatosLlamadaViewModel lista)
        {
            lblNombreCliente.Text = lista.nombreCliente.ToString();

            lblCategoriaLlamada.Text = lista.CategoriaAMostrar.nombreCategoria.ToString();

            lblOpcion.Text = lista.CategoriaAMostrar.OpcionLlamada.nombreOpcion.ToString();

            lblSubOpcion.Text = lista.CategoriaAMostrar.OpcionLlamada.nombreSubOpcionLlamada.ToString();


           txtValidacion1.Text = lista.validaciones[0].audiomensajeValiadacion.ToString();
            CboxRespuestaVal1.Text = "Selecione Una Opcion";
            foreach (var val in lista.validaciones[0].opcionesDeValalidacion)
            {
                CboxRespuestaVal1.Items.Add(val.descripcion.ToString());
            }
            
            txtValidacion2.Text = lista.validaciones[1].audiomensajeValiadacion.ToString();
            CBoxValidacion2.Text = "Selecciona una opcion";
            foreach (var val in lista.validaciones[1].opcionesDeValalidacion)
            {
                CBoxValidacion2.Items.Add(val.descripcion.ToString());
            }
        }

        private void tomarOpcionDeValidacion(object sender, EventArgs e)
        {

            if ((CBoxValidacion2.SelectedItem is null) || (CboxRespuestaVal1.SelectedItem is null))
            {
                MessageBox.Show("No Se han seleccionado validaciones", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string fechanacAValidar = CBoxValidacion2.SelectedItem.ToString();
            string CantHijosAValidar = CboxRespuestaVal1.SelectedItem.ToString();

            if (!gestor.tomarOpcionDeValidacion(fechanacAValidar,CantHijosAValidar))
            {
                MessageBox.Show("Las validaciones son incorrectas", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                gbRespuestaOperador.Visible = true;
                btnRegistrarRtaOperador.Enabled = true;
                List<string> lista = gestor.buscarAcciones();
                mostarDatosValidacion(lista);
            }


        }

        private void mostarDatosValidacion(List<string> lista)
        {
            foreach (var val in lista)
            {
                CBoxAcciones.Items.Add(val.ToString());
            }
        }

        private void CancelarCu(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Desea cancelar el registro de llamada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ColgarLlamada(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Llamada fue colgada por el cliente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void tomarAccionYDescripcionRTA(object sender, EventArgs e)
        {
            if (CBoxAcciones.SelectedItem is null)
            {
                MessageBox.Show("No se selecciono Accion a realizar","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gestor.tomarAccionYDescripcionRTA(txtRespuestaOperador.Text,CBoxAcciones.SelectedItem.ToString() );
            
        }

        internal void solicitarConfirmacion()
        {
            
            DialogResult result = MessageBox.Show("¿Desea confirmar la operación realizada?", "Confirmación", MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                gestor.tomarConfirmacion();
            }

            
        }

        internal void informarRealizacionCU(string accionSeleccionada)
        {
            MessageBox.Show("La accion:" + accionSeleccionada +" Se Registro con exito" , "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
