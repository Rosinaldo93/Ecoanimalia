using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using App_Ecoanimalia_Piura.Logica;

namespace App_Ecoanimalia_Piura.Datos
{
   public class DVisita
    {

        MySqlConnection cone;

        //public int D_registrar_visita(Visita visita)
        //{
        //    String cadena = DConexion.cadena;
        //    String sql = "INSERT INTO visita (ID_MASCOTA,NUMERO,OBSERVACION) VALUES (@mascota,@numero,@obs)";
        //    cone = new MySqlConnection(cadena);
        //    MySqlCommand com = new MySqlCommand(sql, cone);
        //    cone.Open();

        
        //    if (visita.Mascota == null)
        //    {
        //        com.Parameters.AddWithValue("@mascota", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@mascota", visita.Mascota.Id);
        //    }


        //    if (visita.Numero.Equals(""))
        //    {
        //        com.Parameters.AddWithValue("@numero", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@numero", visita.Numero);
        //    }


        //    if (visita.Observacion.Equals(""))
        //    {
        //        com.Parameters.AddWithValue("@obs", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@obs", visita.Observacion);
        //    }

          
        //    int band;
        //    try
        //    {
        //        band = com.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {
        //        band = 0;

        //    }
        //    cone.Close();
        //    return band;
        //}


        //public int D_modificar_visita(Visita visita)
        //{
        //    String cadena = DConexion.cadena;
        //    String sql = "UPDATE visita SET ID_MASCOTA=@mascota,NUMERO=@numero,OBSERVACION=@obs  where ID=@id";
        //    cone = new MySqlConnection(cadena);
        //    MySqlCommand com = new MySqlCommand(sql, cone);
        //    cone.Open();
        //    if (visita.Mascota == null)
        //    {
        //        com.Parameters.AddWithValue("@mascota", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@mascota", visita.Mascota.Id);
        //    }


        //    if (visita.Numero.Equals(""))
        //    {
        //        com.Parameters.AddWithValue("@numero", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@numero", visita.Numero);
        //    }


        //    if (visita.Observacion.Equals(""))
        //    {
        //        com.Parameters.AddWithValue("@obs", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@obs", visita.Observacion);
        //    }

        //    com.Parameters.AddWithValue("@id", visita.Id);
        //    int band;
        //    try
        //    {
        //        band = com.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {
        //        band = 0;

        //    }
        //    cone.Close();
        //    return band;
        //}


        //public int D_eliminar_visita(Visita visita)
        //{
        //    String cadena = DConexion.cadena;
        //    String sql = "DELETE FROM visita where ID=@id";
        //    cone = new MySqlConnection(cadena);
        //    MySqlCommand com = new MySqlCommand(sql, cone);
        //    cone.Open();
        //    com.Parameters.AddWithValue("@id", visita.Id);
        //    int band;
        //    try
        //    {
        //        band = com.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {
        //        band = 0;

        //    }
        //    cone.Close();
        //    return band;
        //}

       //FALTA LISTAR

    }
}
