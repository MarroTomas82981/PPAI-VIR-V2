using System;

namespace PPAI_IVR.Clases
{
    public class CambioEstado
    {
        public int Id { get; set; }

        public DateTime FechaHoraInicio { get; set; }

        public Estado EstadoActual { get; set; }


        public CambioEstado()
        {
            
        }

        public bool esEstadoInicial()
        {
            return false;
        }

        public bool esUltimoEstado()
        {
            return false;
        }

        public DateTime getFechaHoraInicio()
        {
            return FechaHoraInicio;
        }

        public string getNombreEstado()
        {
            return "Estado";
        }
       
    }
}