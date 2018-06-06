using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace paragit.Models
{
    public static class DataInicio
    {
        public static void AgregarDataInicio(IApplicationBuilder ab)
        {
            AppDbContext contexto = ab.ApplicationServices.GetRequiredService<AppDbContext>();
            if (!contexto.TipoArchivo.Any())
            {
                contexto.TipoArchivo.AddRange(CatTArchivo.Select(c => c.Value));
            }
            if (!contexto.Categoria.Any())
            {
                contexto.Categoria.AddRange(CatTcategoria.Select(c => c.Value));
            }
            if (!contexto.Estado.Any())
            {
                contexto.Estado.AddRange(CtEstado.Select(c => c.Value));
            }
            if (!contexto.Nacionalidad.Any())
            {
                contexto.Nacionalidad.AddRange(catnacion.Select(c => c.Value));
            }
            if (!contexto.Ocupacion.Any())
            {
                contexto.Ocupacion.AddRange(catocupacion.Select(c => c.Value));
            }
            if(!contexto.NivelAcademico.Any())
            {
                contexto.NivelAcademico.AddRange(catnivelaca.Select(c => c.Value));
            }
            if(!contexto.ModoInfo.Any())
            {
                contexto.ModoInfo.AddRange(Minfoo.Select(c => c.Value));
            }
            if(!contexto.ModoNoti.Any())
            {
                contexto.ModoNoti.AddRange(Mnotii.Select(c => c.Value));
            }

            if(!contexto.Empleado.Any())
            {
                contexto.AddRange
                    (
                     new Empleado { id_empleado = "1",nom_empleado= "Jose Luis", ape_empleado= "Reyes Lainez", fnac_empleado=Convert.ToDateTime("01/06/1978"), sexo="Masculino", nacionalidad = catnacion ["Salvadoreño"], estado=CtEstado["Casado/a"], Categoria=CatTcategoria["Administrador General"] },
                     new Empleado { id_empleado = "2", nom_empleado = "Rafael Humberto", ape_empleado = "Velazquez Calderon", fnac_empleado = Convert.ToDateTime("10/05/1999"), sexo = "Masculino", nacionalidad = catnacion["Salvadoreño"], estado = CtEstado["Soltero/a"], Categoria = CatTcategoria["Administrador General"] },
                     new Empleado { id_empleado = "3", nom_empleado = "Rene Alexander", ape_empleado = "Perez Peña", fnac_empleado = Convert.ToDateTime("12/09/1967"), sexo = "Masculino", nacionalidad = catnacion["Guatemalteco"], estado = CtEstado["Casado/a"], Categoria = CatTcategoria["Administrador 1"] },
                     new Empleado { id_empleado = "4", nom_empleado = "Sara Gabriela", ape_empleado = "Callejas Ramirez", fnac_empleado = Convert.ToDateTime("31/10/1995"), sexo = "Femenino", nacionalidad = catnacion["Salvadoreño"], estado = CtEstado["Soltero/a"], Categoria = CatTcategoria["Usuario 1"] }
                    );
            }
            if(!contexto.Usuario.Any())
            {
                contexto.AddRange(
                    new Usuario { id_usuario = "1", nombre = "Herbert", apellido = "Melara", fech_nacimiento = Convert.ToDateTime("01/01/1971"), sexo = "Masculino", clave = "mil", Nivelacademico = catnivelaca["Licenciado"], },
                    new Usuario { id_usuario = "2", nombre = "Luis", apellido = "Carcamo", fech_nacimiento = Convert.ToDateTime("01/12/1970"), sexo = "Masculino", clave = "12-doce", Nivelacademico = catnivelaca["Licenciado"], },
                    new Usuario { id_usuario = "3", nombre = "Rene", apellido = "peña", fech_nacimiento = Convert.ToDateTime("25/12/1980"), sexo = "masculino" , clave = "123", Nivelacademico = catnivelaca["Licenciado"], }

            );

            }
            

            contexto.SaveChanges();
        }

        public static Dictionary<string, TipoArchivo> CatTipoArchivo;
        public static Dictionary<string, TipoArchivo> CatTArchivo
        {
            get
            {
                if (CatTipoArchivo == null)
                {
                    var TArchivo = new TipoArchivo[]
                        {
                        new TipoArchivo { nom_tipo_archivo = "Memorandum" },
                        new TipoArchivo { nom_tipo_archivo = "Oficio" },
                        new TipoArchivo { nom_tipo_archivo = "Planes" },
                        new TipoArchivo { nom_tipo_archivo = "Presupuesto" },
                        new TipoArchivo { nom_tipo_archivo = "Planillas" },
                        new TipoArchivo { nom_tipo_archivo = "Manifiestos" },
                        new TipoArchivo { nom_tipo_archivo = "Declaratoria" },
                        new TipoArchivo { nom_tipo_archivo = "Actas" },
                        new TipoArchivo { nom_tipo_archivo = "Documentacion Varia" },
                        };
                    CatTipoArchivo = new Dictionary<string, TipoArchivo>();
                    foreach (TipoArchivo TtArchivo in TArchivo)
                    {
                        CatTipoArchivo.Add(TtArchivo.nom_tipo_archivo, TtArchivo);
                    }
                }//fin if tipoarchivo.
                return CatTipoArchivo;
            }
        }

        public static Dictionary<string, Categoria> Catcategoria;
        public static Dictionary<string, Categoria> CatTcategoria
        {
            get
            {
                if (Catcategoria == null)
                {
                    var liscatcategoria = new Categoria[]
                    {
                     new Categoria { categoria = "Administrador General" },
                     new Categoria { categoria = "Administrador 1"},
                     new Categoria { categoria = "Usuario 1"},
                     new Categoria { categoria = "Usuario 2"},
                     new Categoria { categoria = "Usuario3"},
                    };
                    Catcategoria = new Dictionary<string, Categoria>();
                    foreach (Categoria ccategoria in liscatcategoria)
                    {
                        Catcategoria.Add(ccategoria.categoria, ccategoria);
                    }
                }

                return Catcategoria;
            }
        }


        public static Dictionary<string, Estado> CatEstado;
        public static Dictionary<string, Estado> CtEstado
        {
            get
            {
                if (CatEstado == null)
                {
                    var listCatEstado = new Estado[]
                    {
                    new Estado { nom_estado = "Soltero/a"},
                    new Estado { nom_estado = "Casado/a"},
                    new Estado { nom_estado = "Divorsiado/a"},
                    new Estado { nom_estado ="Viudo/a"},
                    };
                    CatEstado = new Dictionary<string, Estado>();
                    foreach (Estado cestado in listCatEstado)
                    {
                        CatEstado.Add(cestado.nom_estado, cestado);
                    }

                }
                return CatEstado;
            }
        }

        public static Dictionary<string, Nacionalidad> CatNacionalidad;
        public static Dictionary<string, Nacionalidad> catnacion
        {
            get
            {
                if (CatNacionalidad == null)
                {
                    var listCatNacionalidad = new Nacionalidad[]
                    {
                        new Nacionalidad { nacionalidad = "Salvadoreño" },
                        new Nacionalidad { nacionalidad = "Guatemalteco" },
                    };
                    CatNacionalidad = new Dictionary<string, Nacionalidad>();
                    foreach (Nacionalidad cnacion in listCatNacionalidad)
                    {
                        CatNacionalidad.Add(cnacion.nacionalidad, cnacion);
                    }
                }
                return CatNacionalidad;
            }
        }
        public static Dictionary<string, Ocupacion> CatOcupacion;
        public static Dictionary<string, Ocupacion> catocupacion
        {
            get
            {
                if (CatOcupacion == null)
                {
                    var listocupacion = new Ocupacion[]
                    {
                        new Ocupacion { ocupacion="Empleado"},
                        new Ocupacion { ocupacion = "Comerciante" },
                    };
                    CatOcupacion = new Dictionary<string, Ocupacion>();
                    foreach (Ocupacion ocupa in listocupacion)
                    {
                        CatOcupacion.Add(ocupa.ocupacion, ocupa);
                    }
                }
                return CatOcupacion;
            }
        }
        public static Dictionary<string, NivelAcademico> CatNivelAcademico;
        public static Dictionary<string, NivelAcademico> catnivelaca
        {
            get
            {
                if (CatNivelAcademico == null)
                {
                    var liscatnivelaca = new NivelAcademico[]
                        {
                            new NivelAcademico { nivel_academico = "Escolaridad basica" },
                            new NivelAcademico {nivel_academico = "Bachillerato" },
                            new NivelAcademico {nivel_academico = "Tecnico" },
                            new NivelAcademico { nivel_academico = "Licenciado" },
                         };
                    CatNivelAcademico = new Dictionary<string, NivelAcademico>();
                    foreach (NivelAcademico nivaca in liscatnivelaca)
                    {
                        CatNivelAcademico.Add(nivaca.nivel_academico, nivaca);
                    }

                }
                return CatNivelAcademico;
            }
        }
        public static Dictionary<string, CatModoInformacion> Minfo;
        public static Dictionary<string, CatModoInformacion>Minfoo
        {
            get
            {
                if(Minfo == null)
                {
                    var ListaModoInfo = new CatModoInformacion[]
                    {
                        new CatModoInformacion { modo_info="En CD"},
                        new CatModoInformacion {modo_info="En Usb" },
                        new CatModoInformacion {modo_info="En Documentos Certificados" },
                        new CatModoInformacion {modo_info="Por Correspondencia" },
                        new CatModoInformacion {modo_info="Por Correo Electronico" }
                    };
                    Minfo = new Dictionary<string, CatModoInformacion>();
                    foreach(CatModoInformacion minfo in ListaModoInfo)
                    {
                        Minfo.Add(minfo.modo_info, minfo);
                    }
                }
                return Minfo;
            }
        }
        public static Dictionary<string, CatModoNotificacion> Mnoti;
        public static Dictionary<string, CatModoNotificacion> Mnotii
        {
            get
            {
                if (Mnoti == null)
                {
                    var ListaModoNoti = new CatModoNotificacion[]
                    {
                        new CatModoNotificacion {modo_noti= "Por Telefono" },
                        new CatModoNotificacion {modo_noti="Por correo electronico" },
                        new CatModoNotificacion {modo_noti="Por correspondencia" },
                        new CatModoNotificacion {modo_noti="Por medio de la Batiseñal" } 
                    };
                    Mnoti = new Dictionary<string, CatModoNotificacion>();
                    foreach (CatModoNotificacion mnoti in ListaModoNoti)
                    {
                        Mnoti.Add(mnoti.modo_noti, mnoti);
                    }
                }
                return Mnoti;
            }
        }
    }
}
