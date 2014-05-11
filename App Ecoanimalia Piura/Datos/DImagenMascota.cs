using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using App_Ecoanimalia_Piura.Datos;
using App_Ecoanimalia_Piura.Logica;
using System.Windows.Forms;

namespace App_Ecoanimalia_Piura.Datos
{
    public class DImagenMascota
    {
        MySqlConnection cone;

        public List<ImagenMascota> D_listar_imagenes(int id_serie_mascota)
        {
            String cadena = DConexion.cadena;
            String sql = "select * from imagenmascota WHERE SERIE = @SERIE";
            cone = new MySqlConnection(cadena);
            List<ImagenMascota> list = new List<ImagenMascota>();
            MySqlCommand com = new MySqlCommand(sql, cone);
            com.Parameters.AddWithValue("@SERIE",id_serie_mascota);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                ImagenMascota img = new ImagenMascota();
                img.Id = int.Parse(dr[0].ToString());
                img.Descripcion = dr[2].ToString();
                list.Add(img);
            }
            cone.Close();
            return list;
        }
        public int D_registrar_imgmasc(ImagenMascota imagen)
        {
            int band = 0;
            try
            {
                String cadena = DConexion.cadena;
                String sql = "INSERT INTO imagenmascota (DESCRIPCION,IMAGEN,SERIE) VALUES (@DESCRIPCION,@IMAGEN,@SERIE)";
                cone = new MySqlConnection(cadena);

                MySqlCommand com = new MySqlCommand(sql, cone);
                cone.Open();

                com.Parameters.AddWithValue("@DESCRIPCION", imagen.Descripcion);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                imagen.Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                com.Parameters.AddWithValue("@IMAGEN", ms.GetBuffer());
                com.Parameters.AddWithValue("@SERIE", imagen.Mascota.Serie);

                try
                {
                    band = com.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    band = 0;

                }
            }
            catch (MySqlException ex)
            {
                Console.Write("error es : " + ex.Message);
            }
            cone.Close();
            return band;
        }

        public void VerImagen(PictureBox imagen, int id)
        {
            String cadena = DConexion.cadena;
            String sql = "select IMAGEN FROM imagenmascota where ID=@ID";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            com.Parameters.AddWithValue("@ID", id);
            MySqlDataAdapter dp = new MySqlDataAdapter(com);
            DataSet ds = new DataSet("IMAGEN");
            dp.Fill(ds, "IMAGEN");
            byte[] datos = new byte[0];
            DataRow dr = ds.Tables["IMAGEN"].Rows[0];
            datos = (byte[])dr["IMAGEN"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);

            imagen.Image = System.Drawing.Bitmap.FromStream(ms);


        }


        public int D_modificar_imgmasc_descrip(ImagenMascota imagen)
        {
            String cadena = DConexion.cadena;
            String sql = "UPDATE imagenmascota SET DESCRIPCION=@descripcion  where ID=@id";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
           
            com.Parameters.AddWithValue("@descripcion", imagen.Descripcion);

            com.Parameters.AddWithValue("@id", imagen.Id);
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


        public int D_eliminar_imgmasc(ImagenMascota imagen)
        {
            String cadena = DConexion.cadena;
            String sql = "DELETE FROM imagenmascota where ID=@id";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@id", imagen.Id);
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

        //FALTA EL LISTAR 
    }
}
