using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Datos;

namespace App_Ecoanimalia_Piura.Negocio
{
    public class NMascota
    {

        public int N_ultima_serie()
        {
            int b = new DMascota().ultima_serie_ficha();
            return b;
        }
        public int N_Registrar_mascota_confecha_esterilizado(int serie, Usuario rescatista, FichaTemporal fitemp, DateTime fIngreso, TipoMascota tipo, string tamano, string estado, string nombre, string raza, string sexo, string color, string edad, String esterilizado, DateTime FechaEsterilizado)
        {
            Mascota masc = new Mascota();
            masc.Serie = serie;
            masc.Ser_usu = (Usuario)rescatista;
            masc.Fic_tem = (FichaTemporal)fitemp;
            masc.Fecha_ingreso = fIngreso;
            masc.Tipomascota = (TipoMascota)tipo;
            masc.Tamano = tamano;
            masc.Estado = estado;
            masc.Nombre = nombre;
            masc.Raza = raza;
            masc.Sexo = sexo;
            masc.Color = color;
            masc.Edad = edad;
            masc.Esterilizado = esterilizado;
            masc.Fecha_esterilizacion = FechaEsterilizado;

            int band = new DMascota().D_registrar_mascota_ConFecha_esterilizado(masc);
            return band;
        }
        public int N_Registrar_mascota_Sinfecha_esterilizado(int serie, Usuario rescatista, FichaTemporal fitemp, DateTime fIngreso, TipoMascota tipo, string tamano, string estado, string nombre, string raza, string sexo, string color, string edad, String esterilizado)
        {
            Mascota masc = new Mascota();
            masc.Serie = serie;
            masc.Ser_usu = (Usuario)rescatista;
            masc.Fic_tem = (FichaTemporal)fitemp;
            masc.Fecha_ingreso = fIngreso;
            masc.Tipomascota = (TipoMascota)tipo;
            masc.Tamano = tamano;
            masc.Estado = estado;
            masc.Nombre = nombre;
            masc.Raza = raza;
            masc.Sexo = sexo;
            masc.Color = color;
            masc.Edad = edad;
            masc.Esterilizado = esterilizado;


            int band = new DMascota().D_registrar_mascota_SinFecha_esterilizado(masc);
            return band;
        }

        public List<Mascota> N_Listar_Mascotas()
        {
            List<Mascota> lista = new DMascota().D_ListarMascotas();
            return lista;
        }
        public String N_Ver_FechaEsterilizacion(int serie_mascota)
        {
            String band = new DMascota().D_Ver_FechaEsterilizacion(serie_mascota);
            return band;
        }

        //public int N_modificar_mascota(int id, TipoMascota tipo, string tamano, string estado, string nombre, string raza, string sexo, string color, string edad, int esterilizado)
        //{
        //    Mascota masc = new Mascota();
        //    masc.Id = id;
        //    masc.Tipomascota = tipo;
        //    masc.Tamano = tamano;
        //    masc.Estado = estado;
        //    masc.Nombre = nombre;
        //    masc.Raza = raza;
        //    masc.Sexo = sexo;
        //    masc.Color = color;
        //    masc.Edad = edad;
        //    masc.Esterilizado = esterilizado;

        //    int band = new DMascota().D_modificar_mascota(masc);
        //    return band;
        //}

        //public int N_eliminar_mascota(string id)
        //{
        //    Mascota masc = new Mascota();
        //    masc.Serie = serie;
        //    int band = new DMascota().D_eliminar_mascota(masc);
        //    return band;
        //}


    }


}
