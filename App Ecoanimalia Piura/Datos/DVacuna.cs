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

          public int D_registrar_vacuna(Vacuna vacuna)
          {
              String cadena = DConexion.cadena;
              String sql = "INSERT INTO vacuna (SERIE,NUMERO_VACUNA,FECHA,OBSERVACION,PRECIO) VALUES (@SERIE,@NUMERO_VACUNA,@FECHA,@OBSERVACION,@PRECIO)";
              cone = new MySqlConnection(cadena);
              MySqlCommand com = new MySqlCommand(sql, cone);
              cone.Open();

              com.Parameters.AddWithValue("@SERIE", vacuna.Mascota.Serie);

              if (vacuna.Numero_vacuna.Equals(""))
              {
                  com.Parameters.AddWithValue("@NUMERO_VACUNA", null);
              }
              else
              {
                  com.Parameters.AddWithValue("@NUMERO_VACUNA", vacuna.Numero_vacuna);
              }


              if (vacuna.Fecha.Equals(""))
              {
                  com.Parameters.AddWithValue("@FECHA", null);
              }
              else
              {
                  com.Parameters.AddWithValue("@FECHA", vacuna.Fecha);
              }

              if (vacuna.Observacion.Equals(""))
              {
                  com.Parameters.AddWithValue("@OBSERVACION", null);
              }
              else
              {
                  com.Parameters.AddWithValue("@OBSERVACION", vacuna.Observacion);
              }

              com.Parameters.AddWithValue("@PRECIO", vacuna.Precio_Vacuna);
             

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
          public List<Vacuna> D_ListarVacunas(int serie)
          {
              String cadena = DConexion.cadena;
              String sql = "select * from vacuna WHERE SERIE = @SERIE order by NUMERO_VACUNA ";
              cone = new MySqlConnection(cadena);
              List<Vacuna> lista = new List<Vacuna>();
              MySqlCommand com = new MySqlCommand(sql, cone);
              com.Parameters.AddWithValue("@SERIE", serie);
              cone.Open();
              MySqlDataReader dr = com.ExecuteReader();

              while (dr.Read())
              {
                  Vacuna historial = new Vacuna();
                  historial.Id = int.Parse(dr[0].ToString());
                  historial.Numero_vacuna = int.Parse(dr[2].ToString());
                  historial.Fecha = Convert.ToDateTime(dr[3].ToString());
                  historial.Observacion = dr[4].ToString();
                  historial.Precio_Vacuna = Convert.ToDecimal(dr[5].ToString());
                  lista.Add(historial);
              }
              cone.Close();
              return lista;
          }
          public int D_modificar_vacuna(Vacuna vacuna)
          {
              String cadena = DConexion.cadena;
              String sql = "UPDATE  vacuna  SET NUMERO_VACUNA = @NUMERO_VACUNA,FECHA=@FECHA,OBSERVACION=@OBSERVACION,PRECIO=@PRECIO WHERE ID = @ID";
              cone = new MySqlConnection(cadena);
              MySqlCommand com = new MySqlCommand(sql, cone);
              cone.Open();

              if (vacuna.Numero_vacuna.Equals(""))
              {
                  com.Parameters.AddWithValue("@NUMERO_VACUNA", null);
              }
              else
              {
                  com.Parameters.AddWithValue("@NUMERO_VACUNA", vacuna.Numero_vacuna);
              }


              if (vacuna.Fecha.Equals(""))
              {
                  com.Parameters.AddWithValue("@FECHA", null);
              }
              else
              {
                  com.Parameters.AddWithValue("@FECHA", vacuna.Fecha);
              }

              if (vacuna.Observacion.Equals(""))
              {
                  com.Parameters.AddWithValue("@OBSERVACION", null);
              }
              else
              {
                  com.Parameters.AddWithValue("@OBSERVACION", vacuna.Observacion);
              }

              com.Parameters.AddWithValue("@PRECIO", vacuna.Precio_Vacuna);
              com.Parameters.AddWithValue("@ID", vacuna.Id);

              

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


          public int D_eliminar_vacuna(int id_vacuna)
          {
              String cadena = DConexion.cadena;
              String sql = "DELETE FROM vacuna where ID=@ID";
              cone = new MySqlConnection(cadena);
              MySqlCommand com = new MySqlCommand(sql, cone);
              cone.Open();
              com.Parameters.AddWithValue("@ID", id_vacuna);
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
