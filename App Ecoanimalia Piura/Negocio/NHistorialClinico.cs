﻿using System;
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
        public int N_Modificar_Historial_Clinico(DateTime fecha, String descripcion, Decimal precio,int id_Historial)
        {
            HistorialClinico historial = new HistorialClinico();
            historial.Id = id_Historial;
            historial.Fecha = fecha;
            historial.Descripcion = descripcion;
            historial.Precio = precio;
            int band = new DHistorialClinico().D_modificar_historial(historial);
            return band;
        }
        public int N_Eliminar_Historial_Clinico(int id_Historial)
        {

            int band = new DHistorialClinico().D_eliminar_historial(id_Historial);
            return band;
        }
        public List<HistorialClinico> Historial_Clinico_ByMascota(int serie)
        {
            List<HistorialClinico> lista = new DHistorialClinico().Listar_HistorialByMascota(serie);
            return lista;
        }
    }
}
