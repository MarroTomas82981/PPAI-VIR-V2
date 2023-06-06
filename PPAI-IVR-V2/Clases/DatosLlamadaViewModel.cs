using PPAI_IVR.Clases;
using System.Collections.Generic;

namespace PPAI_IVR.Models
{
    public class DatosLlamadaViewModel : Llamada
    {
        public string nombreCliente {  get; set; }

        public DescripcionCategoriaViewModel CategoriaAMostrar { get; set; }

        public List<ValidacionesViewModel> validaciones { get; set; }
        
    }
}
