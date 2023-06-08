using PPAI_IVR.Models;
using PPAI_IVR.Models.Clases;
using System.Collections.Generic;

namespace PPAI_IVR.Clases
{
    public class OpcionLlamada
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int NroOrden { get; set; }

        public string mensajeSubOpcion { get; set; }

        public string audioMensajeSubOpciones { get; set; }

        public List<Validacion> validacionesRequeridas { get; set; }

        public List<SubOpcionLlamada> subOpcionesLlamada { get; set; }

        public int CategoriaLlamadaId { get; set; }

        public int LlamadaId { get; set; }

        public string getAudiomensajeSubOpciones()
        {
            return audioMensajeSubOpciones;
        }

        public OpcionLlamadaViewModel getDescripcioneConSubOpcion()
        {
            OpcionLlamadaViewModel opcion = new OpcionLlamadaViewModel();
            opcion.nombreOpcion = getNombre();
            opcion.nombreSubOpcionLlamada = subOpcionesLlamada[0].getNombre();
            
            return opcion;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public List<ValidacionesViewModel> getValidaciones(List<Validacion> validaciones)
        {
            List<ValidacionesViewModel> validacionesView = new List<ValidacionesViewModel>();


            
            foreach (var val in validaciones)            
            {
                ValidacionesViewModel validacion = new ValidacionesViewModel();
                validacion.audiomensajeValiadacion = val.getAudioMensajeValidacion();
                validacion.opcionesDeValalidacion = val.opcionValidaciones;
                validacionesView.Add(validacion);
              

            }
            return validacionesView;
        }
     }

 }



