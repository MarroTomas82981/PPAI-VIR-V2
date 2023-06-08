using PPAI_IVR.Clases;
using PPAI_IVR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_IVR_V2.Pantalla
{
    public partial class PantallaRegistrarRegRespuestaOperador : Form
    {
        private int tiempoTranscurrido = 0;
        public GestorRegRespuestaOperador gestor;
        public PantallaRegistrarRegRespuestaOperador(GestorRegRespuestaOperador gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

       
        private void RegistrarRegRespuestaOperador_Load(object sender, EventArgs e)
        {
            // Configura el intervalo del temporizador en milisegundos (1000 ms = 1 segundo)
            timer1.Interval = 1000;
            // Suscribe el evento Tick al método Timer_Tick
            timer1.Tick += Timer_Tick;
            // Inicia el temporizador
            timer1.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Incrementa el tiempo transcurrido en 1 segundo
            tiempoTranscurrido++;
            // Actualiza el texto en tu control Label (puedes cambiar "label1" al nombre de tu propio control Label)
            lblTiempo.Text = TimeSpan.FromSeconds(tiempoTranscurrido).ToString();
        }

        public void mostrarDatosLlamada(DatosLlamadaViewModel lista)
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

        public void tomarOpcionDeValidacion(object sender, EventArgs e)
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
                CBoxAcciones.Text = "Selecione Una Opcion";
                List<string> lista = gestor.buscarAccionesRequeridas();
                mostarDatosValidacion(lista);
            }

        }

        public void mostarDatosValidacion(List<string> lista)
        {
            foreach (var val in lista)
            {
                CBoxAcciones.Items.Add(val.ToString());
            }
        }

        public void CancelarCu(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Desea cancelar el registro de llamada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void ColgarLlamada(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("¿La Llamada fue colgada por el cliente?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void tomarAccionYDescripcionRTA(object sender, EventArgs e)
        {
            if (CBoxAcciones.SelectedItem is null)
            {
                MessageBox.Show("No se selecciono Accion a realizar","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gestor.tomarAccionYDescripcionRTA(txtRespuestaOperador.Text,CBoxAcciones.SelectedItem.ToString() );
            
        }

        public void solicitarConfirmacion()
        {
            
            DialogResult result = MessageBox.Show("¿Desea confirmar la operación realizada?", "Confirmación", MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                gestor.tomarConfirmacion();
                this.Close();
            }

            
        }

        public void informarRealizacionCU(string accionSeleccionada)
        {
            MessageBox.Show("La accion: " + accionSeleccionada +" Se Registro con exito" , "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }





    }
}
