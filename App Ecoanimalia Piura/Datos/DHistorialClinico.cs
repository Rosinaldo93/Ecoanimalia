using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using App_Ecoanimalia_Piura.Logica;

namespace App_Ecoanimalia_Piura.Datos
{
   public  class DHistorialClinico
    {
        MySqlConnection cone;

        public int D_registrar_historial(HistorialClinico clinico)
        {
            String cadena = DConexion.cadena;
            String sql = "INSERT INTO historialclinico (SERIE,FECHA,DESCRIPCION,PRECIO) VALUES (@SERIE,@FECHA,@DESCRIPCION,@PRECIO)";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();

            com.Parameters.AddWithValue("@SERIE", clinico.Mascota.Serie);
            com.Parameters.AddWithValue("@FECHA", clinico.Fecha);
            com.Parameters.AddWithValue("@DESCRIPCION", clinico.Descripcion);
            com.Parameters.AddWithValue("@PRECIO", clinico.Precio);



            int band;
            try
            {
                band = com.ExecuteNonQuery();
            }
            catch (Exception ex )
            {
                band = 0;
                Console.Write("error es : " + ex.Message);
            }
            cone.Close();
            return band;
        }


        public int D_modificar_historial(HistorialClinico clinico)
        {
            String cadena = DConexion.cadena;
            String sql = "UPDATE historialclinico SET FECHA=@FECHA,DESCRIPCION=@DESCRIPCION,PRECIO=@PRECIO  where ID=@ID";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@FECHA", clinico.Fecha);
            com.Parameters.AddWithValue("@DESCRIPCION", clinico.Descripcion);
            com.Parameters.AddWithValue("@PRECIO", clinico.Precio);


            com.Parameters.AddWithValue("@ID", clinico.Id);
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


        public int D_eliminar_historial(HistorialClinico clinico)
        {
            String cadena = DConexion.cadena;
            String sql = "DELETE FROM historialclinico where ID=@id";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@id", clinico.Id);
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
        public List<HistorialClinico> Listar_HistorialByMascota(int serie)
        {
            String cadena = DConexion.cadena;
            String sql = "select * from historialclinico WHERE SERIE = @SERIE ";
            cone = new MySqlConnection(cadena);
            List<HistorialClinico> lista = new List<HistorialClinico>();
            MySqlCommand com = new MySqlCommand(sql, cone);
            com.Parameters.AddWithValue("@SERIE", serie);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                HistorialClinico historial = new HistorialClinico();
                historial.Id = int.Parse(dr[0].ToString());
                historial.Fecha = Convert.ToDateTime(dr[2].ToString());
                historial.Descripcion = dr[3].ToString();
                historial.Precio = Convert.ToDecimal(dr[4].ToString());
                lista.Add(historial);
            }
            cone.Close();
            return lista;
        }

    }
}
