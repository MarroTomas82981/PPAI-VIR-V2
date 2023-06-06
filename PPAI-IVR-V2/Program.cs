
using PPAI_IVR.Clases;
using PPAI_IVR.Models;
using PPAI_IVR.Models.Clases;
using PPAI_IVR_V2.Pantalla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_IVR_V2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



           
            OpcionValidacion validacionCorrectaH = new OpcionValidacion
            {
                Id = 3,
                descripcion = "4 hijos",
                correcta = true
            };
            OpcionValidacion validacionCorrectaF = new OpcionValidacion
            {
                Id = 6,
                descripcion = "2000-12-22",
                correcta = true
            };
            OpcionLlamada OpcionLlamadaSeleccionada = new OpcionLlamada
            {
                Nombre = "Solicitar cancelación de la tarjeta de crédito",
                NroOrden = 1,
                subOpcionesLlamada = new List<SubOpcionLlamada>{

                            new SubOpcionLlamada{
                                Id = 1,
                                nombre = "Comunicarse con un Operador",
                                nroOrden = 2
                            }
                        },
                validacionesRequeridas = new List<Validacion>
                        {
                            new Validacion
                            {
                                Id = 1,
                                NroOrden = 1,
                                audioMensajeValidacion = "¿Cual es la cantidad de hijos?",

                                opcionValidaciones = new List<OpcionValidacion>
                                {
                                    validacionCorrectaH,
                                    new OpcionValidacion
                                    {
                                        Id = 2,
                                        descripcion = "5 hijos",
                                        correcta = false
                                    },new OpcionValidacion
                                    {
                                        Id = 3,
                                        descripcion = "2 hijos",
                                        correcta = false
                                    }
                                },
                                Nombre = "Primera Opcion"
                            },
                            new Validacion
                            {
                                NroOrden= 2,
                                Id = 2,
                                audioMensajeValidacion = "¿Cual es su fecha de nacimiento?",
                                opcionValidaciones = new List<OpcionValidacion>
                                {
                                    validacionCorrectaF,
                                    new OpcionValidacion
                                    {
                                        Id = 4,
                                        descripcion = "2000-10-22",
                                        correcta = false
                                    },new OpcionValidacion
                                    {
                                        Id = 5,
                                        descripcion = "2000-05-17",
                                        correcta = false
                                    }
                                },
                                Nombre = "Segunda Opcion"
                            },

                        }
            };

            List<CambioEstado> cambioEstados = new List<CambioEstado>
                    {
                        new CambioEstado
                        {
                            FechaHoraInicio = DateTime.Now,
                            EstadoActual = new Estado
                            {
                                Nombre = "Iniciada",
                                Id = 1
                            }
                        }
                    };
            Llamada llamadaEnCurso = new Llamada
            {
                Cliente = new Cliente
                {
                    Id = 1,
                    NombreCompleto = "Antonio Lopez",
                    InformacionesDelCliente = new List<InformacionCliente>
                    {
                        new InformacionCliente  {
                        datoAValidar = "Cantidad De Hijos",
                        opcionCorrecta =validacionCorrectaH,
                        Id = 2

                        },
                        new InformacionCliente
                        {                             
                        datoAValidar = "FechaNacimiento" ,
                        opcionCorrecta =validacionCorrectaF,
                        Id = 1 
                        }
            }

                },
                CambiosDeEstados = cambioEstados,
                OpcionLlamada = OpcionLlamadaSeleccionada


            };
            CategoriaLlamada categoriaSeleccionada = new CategoriaLlamada
            {
                Id = 1,
                nombre = "Robo",
                nroOrden = 5,
                opcion = new List<OpcionLlamada>
                {
                    OpcionLlamadaSeleccionada
                }


            };


            Estado Iniciada = new Estado(1, "Iniciada");
            Estado EnCurso = new Estado(2, "EnCurso");
            Estado Cancelada = new Estado(3, "Cancelada");
            Estado Finalizada = new Estado(4, "Finalizada");


            List<Estado> Estados = new List<Estado>{
        Iniciada,
        EnCurso,
        Cancelada,
        Finalizada
            };

            Accion accion1 = new Accion("Comunicar saldo");
            Accion accion2 = new Accion("Dar de baja a tarjeta");
            Accion accion3 = new Accion("Denunciar robo");
            List<Accion> acciones = new List<Accion>();
            acciones.Add(accion1);
            acciones.Add(accion2);
            acciones.Add(accion3);

            GestorRegRespuestaOperador gestor = new GestorRegRespuestaOperador();
            gestor.tomarRespuestaOperador(llamadaEnCurso, categoriaSeleccionada,  Estados,  acciones);



            Application.Run(gestor.Pantalla);
        }
    }
}
