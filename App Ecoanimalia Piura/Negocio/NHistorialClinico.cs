using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Datos;

namespace App_Ecoanimalia_Piura.Negocio
{
    class NHistorialClinico
    {
        public int N_Insertar_Historial_Clinico(int seria_mascota, DateTime fecha, String descripcion, Decimal precio)
        {
            HistorialClinico historial = new HistorialClinico();
            Mascota m = new Mascota();
            m.Serie = seria_mascota;
            historial.Mascota = m;
            historial.Fecha = fecha;
            historial.Descripcion = descripcion;
            historial.Precio = precio;
            int band = new DHistorialClinico().D_registrar_historial(historial);
            return band;
        }
        public List<HistorialClinico> Historial_Clinico_ByMascota(int serie)
        {
            List<HistorialClinico> lista = new DHistorialClinico().Listar_HistorialByMascota(serie);
            return lista;
        }
    }
}
