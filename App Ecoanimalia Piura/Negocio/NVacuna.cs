using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Datos;


namespace App_Ecoanimalia_Piura.Negocio
{
   public class NVacuna
    {

       public int N_Registrar_vacuna(int serie_mascota, int numero_vacuna, DateTime fecha, String obs,Decimal precio)
       {
           Vacuna vac = new Vacuna();
           Mascota m = new Mascota();
           m.Serie = serie_mascota;
           vac.Mascota = m;
           vac.Numero_vacuna = numero_vacuna;
           vac.Fecha = fecha;
           vac.Observacion = obs;
           vac.Precio_Vacuna = precio;
           int band = new DVacuna().D_registrar_vacuna(vac);
           return band;
       }
       public List<Vacuna> N_Listar_Vacunas(int serie)
       {
           List<Vacuna> lista = new DVacuna().D_ListarVacunas(serie);
           return lista;
       }
       public int N_modificar_vacuna(int id,int numV, DateTime fecha, string obs,decimal precio)
       {
           Vacuna vac = new Vacuna();
           vac.Id = id;
           vac.Numero_vacuna = numV;
           vac.Fecha = fecha;
           vac.Observacion = obs;
           vac.Precio_Vacuna = precio;
           int band = new DVacuna().D_modificar_vacuna(vac);
           return band;
       }

        //public int N_eliminar_vacuna(int id)
        //{
        //    Vacuna vac = new Vacuna();
        //    vac.Id = id;
        //    int band = new DVacuna().D_eliminar_vacuna(vac);
        //    return band;
        //}
    }
}
