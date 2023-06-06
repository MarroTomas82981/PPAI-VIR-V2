using PPAI_IVR.Clases;
using System.Collections.Generic;

namespace PPAI_IVR.Models
{
    public class ValidacionesViewModel : Validacion
    {
        public  string audiomensajeValiadacion { get; set; }

        public List<OpcionValidacion> opcionesDeValalidacion { get; set; }

    }
}