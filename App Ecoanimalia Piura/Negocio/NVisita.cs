using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Datos;


namespace App_Ecoanimalia_Piura.Negocio
{
    public class NVisita
    {
        public int N_registrar_visita(int serie, int num, string obs, DateTime fecha)
        {
            Visita vis = new Visita();
            Mascota m = new Mascota();
            m.Serie = serie;
            vis.Mascota = m;
            vis.Numero = num;
            vis.Observacion = obs;
            vis.Fecha = fecha;
            int band = new DVisita().D_registrar_visita(vis);
            return band;
        }
        public List<Visita> N_Listar_visitas(int serie_mascota)
        {
            List<Visita> lista = new DVisita().D_ListarVisitas(serie_mascota);
            return lista;
        }

        // public int N_modificar_visita(int id, Mascota mascota, int num, string obs)
        // {
        //     Visita vis = new Visita();
        //     vis.Id = id;
        //     vis.Mascota = mascota;
        //     vis.Numero = num;
        //     vis.Observacion = obs;
        //     int band = new DVisita().D_modificar_visita(vis);
        //     return band;
        // }

        //public int N_eliminar_visita(int id)
        // {
        //     Visita vis = new Visita();
        //     vis.Id = id;
        //     int band = new DVisita().D_eliminar_visita(vis);
        //     return band;
        // }
    }
}
