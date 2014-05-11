using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using App_Ecoanimalia_Piura.Logica;

namespace App_Ecoanimalia_Piura.Datos
{
    public class DVacuna
    {
          MySqlConnection cone;

        //public int D_registrar_vacuna(Vacuna vacuna)
        //{
        //    String cadena = DConexion.cadena;
        //    String sql = "INSERT INTO vacuna (ID_MASCOTA,NUMERO_VACUNA,FECHA,OBSERVACION) VALUES (@mascota,@vacuna,@fecha,@obs)";
        //    cone = new MySqlConnection(cadena);
        //    MySqlCommand com = new MySqlCommand(sql, cone);
        //    cone.Open();

        //    com.Parameters.AddWithValue("@mascota", vacuna.Mascota.Id);

        //    if (vacuna.Numero_vacuna.Equals(""))
        //    {
        //        com.Parameters.AddWithValue("@vacuna", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@vacuna", vacuna.Numero_vacuna);
        //    }


        //    if (vacuna.Fecha.Equals(""))
        //    {
        //        com.Parameters.AddWithValue("@fecha", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@fecha", vacuna.Fecha);
        //    }

        //    if (vacuna.Observacion.Equals(""))
        //    {
        //        com.Parameters.AddWithValue("@obs", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@obs", vacuna.Observacion);
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


        //public int D_modificar_vacuna(Vacuna vacuna)
        //{
        //    String cadena = DConexion.cadena;
        //    String sql = "UPDATE vacuna SET ID_MASCOTA=@mascota,NUMERO_VACUNA=@vacuna,FECHA=@fecha,OBSERVACION=@obs  where ID=@id";
        //    cone = new MySqlConnection(cadena);
        //    MySqlCommand com = new MySqlCommand(sql, cone);
        //    cone.Open();
        //    com.Parameters.AddWithValue("@mascota",vacuna.Mascota.Id);
        //    if (vacuna.Numero_vacuna.Equals(""))
        //    {
        //        com.Parameters.AddWithValue("@vacuna", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@vacuna", vacuna.Numero_vacuna);
        //    }


        //    if (vacuna.Fecha.Equals(""))
        //    {
        //        com.Parameters.AddWithValue("@fecha", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@fecha", vacuna.Fecha);
        //    }

        //    if (vacuna.Observacion.Equals(""))
        //    {
        //        com.Parameters.AddWithValue("@obs", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@obs", vacuna.Observacion);
        //    }

        //    com.Parameters.AddWithValue("@id", vacuna.Id);
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


        //public int D_eliminar_vacuna(Vacuna vacuna)
        //{
        //    String cadena = DConexion.cadena;
        //    String sql = "DELETE FROM vacuna where ID=@id";
        //    cone = new MySqlConnection(cadena);
        //    MySqlCommand com = new MySqlCommand(sql, cone);
        //    cone.Open();
        //    com.Parameters.AddWithValue("@id", vacuna.Id);
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

        ////FALTA LISTAR


       
    }
}
