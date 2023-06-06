using PPAI_IVR.Models;
using PPAI_IVR.Models.Clases;
using System.Collections.Generic;

namespace PPAI_IVR.Clases
{
    public class CategoriaLlamada
    {
        public int Id { get; set; }
        public string audioMensajeOpciones { get; set; }
        public string mensajeOpciones {get; set; }
        public string nombre {get; set; }
        public int nroOrden { get; set; }
        public List<OpcionLlamada> opcion { get; set; }



        public string getAudioMensajeOpciones()
        {
            return audioMensajeOpciones;
        }
        public DescripcionCategoriaViewModel obtenerDescripcionCategoriaYOpcion()
        {
            DescripcionCategoriaViewModel lista = new DescripcionCategoriaViewModel();            
            string nombre = getNombre();
            lista.nombreCategoria = nombre;
            OpcionLlamadaViewModel nombreOpcion = new OpcionLlamadaViewModel();
            nombreOpcion = opcion[0].getDescripcioneConSubOpcion();
            lista.OpcionLlamada = nombreOpcion;
            

            return lista;
        }
        
        public string getNombre()
        {
            return nombre;
        }

    }
}
