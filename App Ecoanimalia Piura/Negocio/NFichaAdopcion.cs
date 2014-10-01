using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Datos;

namespace App_Ecoanimalia_Piura.Negocio
{
    public class NFichaAdopcion
    {

        public int N_asignar_adopcion(Persona persona, Usuario usuario, string relacion,string observacion,DateTime fecha)
        {
            FichaAdopcion adopcion = new FichaAdopcion();
            adopcion.Persona = persona;
            adopcion.Usuario = usuario;
            adopcion.Rel_res = relacion;
            adopcion.Observaciones = observacion;
            adopcion.Fec_adp = fecha;
         


            int band = new DFichaAdopcion().D_registrar_fichaA(adopcion);
            return band;
        }
        
        public int N_modificar_adopcion(int id, Persona persona, Usuario usuario,string relacion, string observacion, DateTime fecha)
        {

            FichaAdopcion adopcion = new FichaAdopcion();
            adopcion.Id = id;
            adopcion.Persona = persona;
            adopcion.Usuario = usuario;
            
            adopcion.Rel_res = relacion;
            adopcion.Observaciones = observacion;
            adopcion.Fec_adp = fecha;
            int band = new DFichaAdopcion().D_modificar_fichaA(adopcion);
            return band;
        }
        /*
        public int N_eliminar_adopcion(int id)
        {
            FichaAdopcion adopcion = new FichaAdopcion();
            adopcion.Id = id;

            int band = new DFichaAdopcion().D_eliminar_fichaA(adopcion);
            return band;
        }
        */
        public int N_max_FichaAdopcion()
        {
            int band = new DFichaAdopcion().D_max_FichaAdopcion();
            return band;
        }
        public List<FichaAdopcion> N_ListaFichaAdopcion()
        {
            return new DFichaAdopcion().D_ListaFichaAdopcion();
        }
        public FichaAdopcion D_BuscarFichaAdopcionxID(int id)
        {
            return new DFichaAdopcion().D_BuscarFichaAdopcionxID(id);
        }
        public int N_maxima_FichaAdopcion()
        {
            return new DFichaAdopcion().D_maxima_FichaAdopcion();

        }
    }
}
