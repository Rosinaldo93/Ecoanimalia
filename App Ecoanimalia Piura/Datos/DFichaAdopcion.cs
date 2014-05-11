using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using App_Ecoanimalia_Piura.Logica;

namespace App_Ecoanimalia_Piura.Datos
{
 public class DFichaAdopcion
    {
        MySqlConnection cone;

        public int D_registrar_fichaA(FichaAdopcion adopcion)
        {
            String cadena = DConexion.cadena;
            String sql = "INSERT INTO fichaadopcion  (ID_PERSONA,ID_USUARIO,ESTADO,RELACION_RESPONSABLE,OBSERVACIONES,FECHA_ADOPCION) VALUES (@persona,@usuario,@estado,@,@rel_res,@obs,@fecha)";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
  
            com.Parameters.AddWithValue("@persona", adopcion.Persona.Id);
         //AQUI CHECA COMO HACES XK ES USUARIO   com.Parameters.AddWithValue("@usuario", adopcion.Usuario.);
            com.Parameters.AddWithValue("@estado", adopcion.Estado);
            com.Parameters.AddWithValue("@rel_res", adopcion.Rel_res);
            com.Parameters.AddWithValue("@obs", adopcion.Observaciones);
            com.Parameters.AddWithValue("@fecha", adopcion.Fec_adp);


            int band;
            try
            {
                band = com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                band = 0;

            }
            cone.Close();
            return band;
        }


        public int D_modificar_fichaA(FichaAdopcion adopcion)
        {
            String cadena = DConexion.cadena;
            String sql = "UPDATE fichaadopcion SET ID_PERSONA=@persona,ID_USUARIO=@usuario,ESTADO=@estado,RELACION_RESPONSABLE=@rel_res,OBSERVACIONES=@obs,FECHA_ADOPCION=@fecha  where ID=@id";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@persona", adopcion.Persona.Id);
            //AQUI CHECA COMO HACES XK ES USUARIO   com.Parameters.AddWithValue("@usuario", adopcion.Usuario.);
            com.Parameters.AddWithValue("@estado", adopcion.Estado);
            com.Parameters.AddWithValue("@rel_res", adopcion.Rel_res);
            com.Parameters.AddWithValue("@obs", adopcion.Observaciones);
            com.Parameters.AddWithValue("@fecha", adopcion.Fec_adp);

            com.Parameters.AddWithValue("@id", adopcion.Id);
            int band;
            try
            {
                band = com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                band = 0;

            }
            cone.Close();
            return band;
        }


        public int D_eliminar_fichaA(FichaAdopcion adopcion)
        {
            String cadena = DConexion.cadena;
            String sql = "DELETE FROM fichaadopcion where ID=@id";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@id", adopcion.Id);
            int band;
            try
            {
                band = com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                band = 0;

            }
            cone.Close();
            return band;
        }

    }
}
