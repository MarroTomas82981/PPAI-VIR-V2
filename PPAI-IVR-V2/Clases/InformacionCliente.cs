using System;
using System.Drawing;

namespace PPAI_IVR.Clases
{
    public class InformacionCliente
    {
        public int Id { get; set; }
        
        public string datoAValidar { get; set; }

        public OpcionValidacion opcionCorrecta { get; set; }
        
        public int ClienteId { get; set; }


        public bool EsInformaciónCorrecta(string respuestaAValidar)
        {
            return respuestaAValidar == opcionCorrecta.descripcion;
        }

        public bool esValidacion()
        {
            return true;
        }
    }
}