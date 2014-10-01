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
            String sql = "INSERT INTO fichaadopcion  (ID_PERSONA,ID_USUARIO,RELACION_RESPONSABLE,OBSERVACIONES,FECHA_ADOPCION) VALUES (@ID_PERSONA,@ID_USUARIO,@RELACION_RESPONSABLE,@OBSERVACIONES,@FECHA_ADOPCION)";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();

            com.Parameters.AddWithValue("@ID_PERSONA", adopcion.Persona.Id);
            com.Parameters.AddWithValue("@ID_USUARIO", adopcion.Usuario.Serie);
            com.Parameters.AddWithValue("@RELACION_RESPONSABLE", adopcion.Rel_res);
            com.Parameters.AddWithValue("@OBSERVACIONES", adopcion.Observaciones);
            com.Parameters.AddWithValue("@FECHA_ADOPCION", adopcion.Fec_adp);


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
        public int D_max_FichaAdopcion()
        {
            String cadena = DConexion.cadena;
            string sql = "select max(ID) from fichaadopcion";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();
            int band = 0;

            while (dr.Read())
            {
                if (!String.IsNullOrEmpty(dr[0].ToString()))
                {

                    band = int.Parse(dr[0].ToString());
                    cone.Close();
                    band++;
                    return band;
                }
                else
                {
                    band++;
                    return band;
                }


            }
            cone.Close();
            return band;

        }
        public List<FichaAdopcion> D_ListaFichaAdopcion()
        {
            String cadena = DConexion.cadena;
            string sql = "SELECT * FROM fichaadopcion";
            List<FichaAdopcion> lista = new List<FichaAdopcion>();
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                FichaAdopcion ficha = new FichaAdopcion();
                ficha.Id = int.Parse(dr[0].ToString());

                int id_persona = int.Parse(dr[1].ToString());

                ficha.Persona = new DPersona().D_buscar_Persona(id_persona);
                int serie = int.Parse(dr[2].ToString());
                ficha.Usuario = new DUsuario().D_ver_Usuarioxserie(serie);
                ficha.Rel_res = dr[3].ToString();
                ficha.Observaciones = dr[4].ToString();
                ficha.Fec_adp = DateTime.Parse(dr[5].ToString());


                lista.Add(ficha);


            }
            cone.Close();
            return lista;

        }

        public FichaAdopcion D_BuscarFichaAdopcionxID(int id)
        {
            String cadena = DConexion.cadena;
            string sql = "SELECT * FROM fichaadopcion WHERE ID = @ID ";

            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@ID", id);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                FichaAdopcion ficha = new FichaAdopcion();
                ficha.Id = int.Parse(dr[0].ToString());

                int id_persona = int.Parse(dr[1].ToString());

                ficha.Persona = new DPersona().D_buscar_Persona(id_persona);
                int serie = int.Parse(dr[2].ToString());
                ficha.Usuario = new DUsuario().D_ver_Usuarioxserie(serie);
                ficha.Rel_res = dr[3].ToString();
                ficha.Observaciones = dr[4].ToString();
                ficha.Fec_adp = DateTime.Parse(dr[5].ToString());
                cone.Close();
                return ficha;




            }
            cone.Close();
            return null;

        }

        public int D_maxima_FichaAdopcion()
        {
            String cadena = DConexion.cadena;
            string sql = "select max(ID) from fichaadopcion";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();
            int band = 0;

            while (dr.Read())
            {
                band = int.Parse(dr[0].ToString());
            }
            cone.Close();
            return band;

        }

        
           public int D_modificar_fichaA(FichaAdopcion adopcion)
           {
               String cadena = DConexion.cadena;
               String sql = "UPDATE fichaadopcion  SET ID_PERSONA=@ID_PERSONA,ID_USUARIO=@ID_USUARIO,RELACION_RESPONSABLE=@RELACION_RESPONSABLE,OBSERVACIONES=@OBSERVACIONES,FECHA_ADOPCION=@FECHA_ADOPCION   WHERE ID = @ID";
               cone = new MySqlConnection(cadena);
               MySqlCommand com = new MySqlCommand(sql, cone);
               cone.Open();
               
               com.Parameters.AddWithValue("@ID_PERSONA", adopcion.Persona.Id);
               com.Parameters.AddWithValue("@ID_USUARIO", adopcion.Usuario.Serie);
               com.Parameters.AddWithValue("@RELACION_RESPONSABLE", adopcion.Rel_res);
               com.Parameters.AddWithValue("@OBSERVACIONES", adopcion.Observaciones);
               com.Parameters.AddWithValue("@FECHA_ADOPCION", adopcion.Fec_adp);
               com.Parameters.AddWithValue("@ID", adopcion.Id);

               int band;
               try
               {
                   band = com.ExecuteNonQuery();
               }
               catch (Exception ex)
               {
                   band = 0;
                   Console.WriteLine("error es  : " + ex.Message);

               }
               cone.Close();
               return band;
           }
      
        
        /*

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
        */

    }
}
