using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using App_Ecoanimalia_Piura.Logica;

namespace App_Ecoanimalia_Piura.Datos
{
    class DDetalleAdopcion
    {
        MySqlConnection cone;
        public int D_registrar_DetalleAdopcion(DetalleAdopcion detalle)
        {
            String cadena = DConexion.cadena;
            String sql = "INSERT INTO detalleadopcion  (SERIE,ID_FICHA_ADOPCION,NOMBRE_ADOPTARSE,ESTADO,OBSERVACION) VALUES (@SERIE,@ID_FICHA_ADOPCION,@NOMBRE_ADOPTARSE,@ESTADO,@OBSERVACION)";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            Console.WriteLine("enviando " + detalle.Mascota.Serie + " - " + detalle.Fichaadopcion.Id + " - " + detalle.Nombre_adoptarse + " - " + detalle.Estado + " - " + detalle.Observacion);
            com.Parameters.AddWithValue("@SERIE", detalle.Mascota.Serie);
            com.Parameters.AddWithValue("@ID_FICHA_ADOPCION", detalle.Fichaadopcion.Id);
            com.Parameters.AddWithValue("@NOMBRE_ADOPTARSE", detalle.Nombre_adoptarse);
            com.Parameters.AddWithValue("@ESTADO", detalle.Estado);
            com.Parameters.AddWithValue("@OBSERVACION", detalle.Observacion);


            int band;
            try
            {
                band = com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(" " + ex.Message);
                band = 0;

            }
            Console.WriteLine(" entro ");
            cone.Close();
            return band;
        }

        public List<DetalleAdopcion> D_Listar_DetalleAdopcion_sinficha(int id_adopcion)
        {
            String cadena = DConexion.cadena;
            String sql = "select * from detalleadopcion WHERE ID_FICHA_ADOPCION = @ID_FICHA_ADOPCION";
            cone = new MySqlConnection(cadena);
            List<DetalleAdopcion> lista = new List<DetalleAdopcion>();
            MySqlCommand com = new MySqlCommand(sql, cone);
            com.Parameters.AddWithValue("@ID_FICHA_ADOPCION", id_adopcion);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                DetalleAdopcion detalle = new DetalleAdopcion();
                detalle.Id = int.Parse(dr[0].ToString());
                int serie_mascota = int.Parse(dr[1].ToString());
                detalle.Mascota = new DMascota().D_Buscar_MascotaxSerie(serie_mascota);
                detalle.Nombre_adoptarse = dr[3].ToString();
                detalle.Estado = Convert.ToInt32(dr[4].ToString());
                if (!dr.IsDBNull(5))
                {
                    detalle.Observacion = dr[5].ToString();
                }
                else
                {
                    detalle.Observacion = "";
                }
                lista.Add(detalle);
            }
            cone.Close();
            return lista;
        }
    }
}
