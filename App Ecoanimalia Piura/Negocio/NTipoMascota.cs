using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Datos;

namespace App_Ecoanimalia_Piura.Negocio
{
   public class NTipoMascota
    {
        public int N_registrar_tipo(String descripcion)
        {
            TipoMascota tipoM = new TipoMascota();
            tipoM.Descripcion = descripcion;
            
            int band = new DTipoMascota().D_registrar_tipomas(tipoM);
            return band;

        }

        public int N_modificar_persona(int id,String descripcion)
        {
            TipoMascota tipoM = new TipoMascota();
            tipoM.Id = id;
            tipoM.Descripcion = descripcion;
            
            int band = new DTipoMascota().D_modificar_tipomas(tipoM);
            return band;
        }

        public int N_eliminar_persona(int id)
        {
            TipoMascota tipoM = new TipoMascota();
            tipoM.Id = id;
            int band = new DTipoMascota().D_eliminar_tipomas(tipoM);
            return band;


        }

        public List<TipoMascota> listar_tipoM()
        {
            List<TipoMascota> lista = new DTipoMascota().D_listar_tipomas();
            return lista;
        }

    }
}
