using PPAI_IVR.Clases;
using System;
using System.Collections.Generic;
using PPAI_IVR_V2.Pantalla;
using System.Collections;
using System.Windows.Forms;

namespace PPAI_IVR.Models
{
    public class GestorRegRespuestaOperador
    {
        public DateTime FechaHoraActual { get; set; }
        public Llamada LlamadaEnCurso { get; set; }
        public Estado EstadoEnCurso { get; set; }
        public Estado EstadoFinalizada { get; set; }
        public CategoriaLlamada CategoriaSeleccionada { get; set; }
        public string respuestaOperador { get; set; }
        public bool confimacion { get;set; }     
        private PantallaRegistrarRegRespuestaOperador pantalla { get; set; }
        private List<Estado> TodosLosEestados { get; set; }
        private List<Accion> AccionesLlamada { get; set; }
        private string descripcionRespuesta { get; set; }
        private string accionSeleccionada { get; set; }


        public PantallaRegistrarRegRespuestaOperador Pantalla { get => pantalla; set => pantalla = value; }

        public GestorRegRespuestaOperador()
        {
            this.pantalla = new PantallaRegistrarRegRespuestaOperador(this);
        }

        public void tomarRespuestaOperador(Llamada llamada, CategoriaLlamada categoriaLlamada, List<Estado> estados, List<Accion> acciones)
        {
            LlamadaEnCurso = llamada;
            CategoriaSeleccionada = categoriaLlamada;
            TodosLosEestados = estados;
            AccionesLlamada = acciones;
            ObtenerFechaHoraActual();
            buscarEstadoEnCurso();
            LlamadaEnCurso.EsTomadaPorOperador(EstadoEnCurso, FechaHoraActual);
            buscarDatosLlamadaActual();
        }

        public DateTime ObtenerFechaHoraActual()
        {
            DateTime fechaHoraActual = DateTime.Now;
            FechaHoraActual = fechaHoraActual;
            return fechaHoraActual;
        }

        public void buscarEstadoEnCurso()
        {
            foreach (var est in TodosLosEestados)
            {
                if (est.esEnCurso())
                {
                    EstadoEnCurso = est;
                }
            }     
        }

        public void asignarEstadoEnCurso()
        {
            esTomadaPorOperador();
        }

        public void esTomadaPorOperador() 
        {
            LlamadaEnCurso.EsTomadaPorOperador(EstadoEnCurso, FechaHoraActual);
        }

        public void buscarDatosLlamadaActual()
        {
            DatosLlamadaViewModel lista = new DatosLlamadaViewModel();
            string nombreClienteLlamada = LlamadaEnCurso.obtenerNombreClienteLlamada();
            lista.nombreCliente = nombreClienteLlamada;
            DescripcionCategoriaViewModel descripciones = CategoriaSeleccionada.obtenerDescripcionCategoriaYOpcion();
            lista.CategoriaAMostrar = descripciones;
            List<ValidacionesViewModel> validaciones = new List<ValidacionesViewModel>();
            validaciones = LlamadaEnCurso.ObtenerValidaciones(LlamadaEnCurso.OpcionLlamada.validacionesRequeridas);
            lista.validaciones = validaciones;
           
            pantalla.mostrarDatosLlamada(lista);
        }

        public bool tomarOpcionDeValidacion(string fechanacAValidar, string CantHijosAValidar)
        {
            List<string> lista = new List<string>();
            lista.Add(fechanacAValidar);
            lista.Add(CantHijosAValidar);
            return LlamadaEnCurso.validarInformacionCliente(lista);
        }      

        public List<string> buscarAccionesRequeridas()
        {
            List<string> listaAcciones = new List<string>();
            foreach (var item in AccionesLlamada)
            {
                listaAcciones.Add(item.getDescripcion());
            }
            return listaAcciones;
        }

        public void tomarAccionYDescripcionRTA(string respuesta, string accionRequerida)
        {
            respuestaOperador = respuesta;
            accionSeleccionada = accionRequerida;
            pantalla.solicitarConfirmacion();
        }

        public void tomarConfirmacion()
        {
            llamarACU28();
            buscarEstadoFinalizada();
            DateTime fechaHora = ObtenerFechaHoraActual();
            finalizarLlamada(fechaHora);

            MessageBox.Show(" Descripción operador: " + LlamadaEnCurso.DescripcionOperador +
               "\n Duración de la llamada: " + LlamadaEnCurso.Duracion.ToString("hh':'mm':'ss"));               
        }


        public void llamarACU28()
        {
            pantalla.informarRealizacionCU(accionSeleccionada);
        }

        public void buscarEstadoFinalizada()
        {            
            foreach (var est in TodosLosEestados)
            {
                if (est.esFinalizada())
                {
                    EstadoFinalizada = est;
                }
            }
        }

        public void finalizarLlamada( DateTime fechaHora )
        {
            LlamadaEnCurso.finalizar(fechaHora, EstadoEnCurso);
        }       

        public void FinCU()
        {
            pantalla.Close();
        }      

       
    }
}
