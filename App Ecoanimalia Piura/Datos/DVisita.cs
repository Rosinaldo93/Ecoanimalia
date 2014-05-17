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

        public int D_registrar_visita(Visita visita)
        {
            String cadena = DConexion.cadena;
            String sql = "INSERT INTO visita (SERIE,NUMERO,OBSERVACION,FECHA) VALUES(@SERIE,@NUMERO,@OBSERVACION,@FECHA)";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();


            if (visita.Mascota == null)
            {
                com.Parameters.AddWithValue("@SERIE", null);
            }
            else
            {
                com.Parameters.AddWithValue("@SERIE", visita.Mascota.Serie);
            }


            if (visita.Numero.Equals(""))
            {
                com.Parameters.AddWithValue("@NUMERO", null);
            }
            else
            {
                com.Parameters.AddWithValue("@NUMERO", visita.Numero);
            }


            if (visita.Observacion.Equals(""))
            {
                com.Parameters.AddWithValue("@OBSERVACION", null);
            }
            else
            {
                com.Parameters.AddWithValue("@OBSERVACION", visita.Observacion);
            }
            if (visita.Fecha.Equals(""))
            {
                com.Parameters.AddWithValue("@FECHA", null);
            }
            else
            {
                com.Parameters.AddWithValue("@FECHA", visita.Fecha);
            }



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
        public List<Visita> D_ListarVisitas(int serie)
        {
            String cadena = DConexion.cadena;
            String sql = "select * from visita WHERE SERIE = @SERIE order by NUMERO ";
            cone = new MySqlConnection(cadena);
            List<Visita> lista = new List<Visita>();
            MySqlCommand com = new MySqlCommand(sql, cone);
            com.Parameters.AddWithValue("@SERIE", serie);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                Visita visita = new Visita();
                visita.Id = int.Parse(dr[0].ToString());
                visita.Numero = int.Parse(dr[2].ToString());
                visita.Observacion = dr[3].ToString();
                visita.Fecha = Convert.ToDateTime(dr[4].ToString());
                lista.Add(visita);
            }
            cone.Close();
            return lista;
        }

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



    }
}
