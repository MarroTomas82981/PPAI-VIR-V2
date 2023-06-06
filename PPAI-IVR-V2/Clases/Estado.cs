using System.Collections.Generic;
using System.Windows.Forms;

namespace PPAI_IVR.Clases
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CambioEstadoId { get; set; }
        

        public Estado(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public Estado()
        {
        }

      


        public bool esEnCurso()
        {
            return Nombre == "EnCurso";
        }

        public bool esFinalizada()
        {
            return Nombre == "Finalizada";          
        }
        public bool esIniciada()
        {
            return Nombre == "Iniciada";
           
        }        
        public string getNombre()
        {
            return this.Nombre;
        }
    }
}