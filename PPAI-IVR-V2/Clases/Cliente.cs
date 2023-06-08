using Microsoft.Build.Framework;
using PPAI_IVR.Clases;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;
using Xunit.Sdk;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace PPAI_IVR.Models.Clases
{
    public class Cliente
    {
        public int Id { get; set; }        
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; }        
        [Display(Name = "Numero de celular")]
        public int nroCelular { get; set; }       
        [Display(Name = "DNI")]
        public int Dni { get; set; }
        public List<InformacionCliente> InformacionesDelCliente { get; set; }
        


        public bool esCliente()
        {
            return true;
        }

        public string getNombre()
        {
            return NombreCompleto;
        }

        public bool  esInfoCorrecta(List<string> lista)//Datos que pasa como parametros
        {
            bool datoCant = false;
            bool datoFecha = false;
            int c = 0;
            int f = 0;

            for (int i = 0; i < InformacionesDelCliente.Count; i++)
            {
                if (InformacionesDelCliente[i].datoAValidar == "FechaNacimiento")
                {
                    f = i;
                }
                if (InformacionesDelCliente[i].datoAValidar == "Cantidad De Hijos")
                {
                    c = i;
                }
            }

            foreach (var item in lista)
            {
                

                if (datoFecha)
                {
                    datoCant = InformacionesDelCliente[c].EsInformaciónCorrecta(item);
                }
                else if (datoCant)
                {
                    datoFecha = InformacionesDelCliente[f].EsInformaciónCorrecta(item);
                }
                else
                {
                    datoCant = InformacionesDelCliente[c].EsInformaciónCorrecta(item);
                    datoFecha = InformacionesDelCliente[f].EsInformaciónCorrecta(item);
                }

            }
            return datoCant && datoFecha;
        }
    }
}