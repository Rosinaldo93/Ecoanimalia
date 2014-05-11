using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using App_Ecoanimalia_Piura.Datos;
using App_Ecoanimalia_Piura.Logica;

namespace App_Ecoanimalia_Piura.Datos
{
   public class DTipoMascota
    {
        MySqlConnection cone;

        public int D_registrar_tipomas(TipoMascota tipo)
        {
            String cadena = DConexion.cadena;
            String sql = "INSERT INTO tipomascota (DESCRIPCION) VALUES (@descripcion)";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();

            if (tipo.Descripcion.Equals(""))
            {
                com.Parameters.AddWithValue("@descripcion", null);
            }
            else
            {
                com.Parameters.AddWithValue("@descripcion", tipo.Descripcion);
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


        public int D_modificar_tipomas(TipoMascota tipo)
        {
            String cadena = DConexion.cadena;
            String sql = "UPDATE tipomascota set DESCRIPCION=@descripcion  WHERE ID = @id";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();


            if (tipo.Descripcion.Equals(""))
            {
                com.Parameters.AddWithValue("@descripcion", null);
            }
            else
            {
                com.Parameters.AddWithValue("@descripcion", tipo.Descripcion);
            }


            com.Parameters.AddWithValue("@id", tipo.Id);

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


        public List<TipoMascota> D_listar_tipomas()
        {
            String cadena = DConexion.cadena;
            List<TipoMascota> lista = new List<TipoMascota>();
            string sql = "select * from tipomascota";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();

            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                TipoMascota tipo = new TipoMascota();
                tipo.Id = Convert.ToInt32(dr[0]);


                if (!dr.IsDBNull(1))
                {

                    tipo.Descripcion = dr[1].ToString();
                }
                else
                {
                    tipo.Descripcion = "";
                }


              

                lista.Add(tipo);
            }
            cone.Close();
            return lista;
        }


        public int D_eliminar_tipomas(TipoMascota tipo)
        {
            String cadena = DConexion.cadena;
            String sql = "DELETE FROM tipomascota WHERE ID = @id";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@id", tipo.Id);

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
        public TipoMascota D_buscar_TipoMascota(int id)
        {
            String cadena = DConexion.cadena;
            string sql = "select * from  tipomascota   where ID = @ID";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@ID", id);
            MySqlDataReader dr = com.ExecuteReader();
            TipoMascota m = new TipoMascota();
            while (dr.Read())
            {

                m.Id = int.Parse(dr[0].ToString());
                m.Descripcion = dr[1].ToString();
                


                cone.Close();
                return m;
            }
            cone.Close();
            return m; ;
        }





    }
}
