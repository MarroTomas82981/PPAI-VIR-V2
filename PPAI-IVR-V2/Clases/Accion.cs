namespace PPAI_IVR.Models
{
    public class Accion
    {
        private string descripcion { get; set; }



        public Accion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string getDescripcion()
        {
            return descripcion;
        }
    }
}