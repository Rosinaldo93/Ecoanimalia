using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Datos;

namespace App_Ecoanimalia_Piura.Negocio
{
    class NDetalleAdopcion
    {
        public int N_registrar_detalleAdopcion(Mascota mascota, int id_fichaAdopcion,String nombre_adoptarse,int estado,String observacion)
        {
            DetalleAdopcion detalle = new DetalleAdopcion();
            detalle.Mascota = mascota;
            FichaAdopcion f = new FichaAdopcion();
            f.Id = id_fichaAdopcion;
            detalle.Fichaadopcion = f;
            detalle.Nombre_adoptarse = nombre_adoptarse;
            detalle.Estado = estado;
            detalle.Observacion = observacion;
            int band = new DDetalleAdopcion().D_registrar_DetalleAdopcion(detalle);
            return band;

        }
        public List<DetalleAdopcion> N_Listar_DetalleAdopcion_sinficha(int id_adopcion)
        {
            List<DetalleAdopcion> lista = new DDetalleAdopcion().D_Listar_DetalleAdopcion_sinficha(id_adopcion);
            return lista;
        }
    }
}
