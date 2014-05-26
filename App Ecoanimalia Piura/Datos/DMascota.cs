using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using App_Ecoanimalia_Piura.Logica;

namespace App_Ecoanimalia_Piura.Datos
{
    public class DMascota
    {
        MySqlConnection cone;
        public int ultima_serie_ficha()
        {
            String cadena = DConexion.cadena;
            string sql = "select Max(SERIE) from mascota";
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
        public int D_registrar_mascota_ConFecha_esterilizado(Mascota masc)
        {
            String cadena = DConexion.cadena;
            String sql = "INSERT INTO mascota(SERIE, USUARIO, ID_TEMPORAL, FECHA_INGRESO, ID_TIPO, TAMANO, ESTADO, NOMBRE, RAZA, SEXO, COLOR, EDAD, ESTERILIZADO,FECHA_ESTERILIZACION)" +
                         "VALUES (@SERIE, @USUARIO, @ID_TEMPORAL, @FECHA_INGRESO, @ID_TIPO, @TAMANO, @ESTADO, @NOMBRE, @RAZA, @SEXO, @COLOR, @EDAD, @ESTERILIZADO, @FECHA_ESTERILIZACION)";

            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            Console.Write("entro ");
            com.Parameters.AddWithValue("@SERIE", masc.Serie);
            if (masc.Ser_usu == null)
            {
                com.Parameters.AddWithValue("@USUARIO", null);

            }
            else
            {
                com.Parameters.AddWithValue("@USUARIO", masc.Ser_usu.Serie);

            }
            if (masc.Fic_tem == null)
            {
                com.Parameters.AddWithValue("@ID_TEMPORAL", null);

            }
            else
            {
                com.Parameters.AddWithValue("@ID_TEMPORAL", masc.Fic_tem.Id);

            }
            int day = masc.Fecha_ingreso.Day;
            int mes = masc.Fecha_ingreso.Month;
            int annio = masc.Fecha_ingreso.Year;
            String f_ingre = "" + annio + "-" + mes + "-" + day;
            com.Parameters.AddWithValue("@FECHA_INGRESO", f_ingre);

            if (masc.Tipomascota == null)
            {
                com.Parameters.AddWithValue("@ID_TIPO", null);

            }
            else
            {
                com.Parameters.AddWithValue("@ID_TIPO", masc.Tipomascota.Id);

            }
            com.Parameters.AddWithValue("@TAMANO", masc.Tamano);
            com.Parameters.AddWithValue("@ESTADO", masc.Estado);
            if (!String.IsNullOrEmpty(masc.Nombre))
            {
                com.Parameters.AddWithValue("@NOMBRE", masc.Nombre);
            }
            else
            {
                com.Parameters.AddWithValue("@NOMBRE", null);
            }
            if (!String.IsNullOrEmpty(masc.Raza))
            {
                com.Parameters.AddWithValue("@RAZA", masc.Raza);
            }
            else
            {
                com.Parameters.AddWithValue("@RAZA", null);
            }
            com.Parameters.AddWithValue("@SEXO", masc.Sexo);
            if (!String.IsNullOrEmpty(masc.Color))
            {
                com.Parameters.AddWithValue("@COLOR", masc.Color);
            }
            else
            {
                com.Parameters.AddWithValue("@COLOR", null);
            }
            if (!String.IsNullOrEmpty(masc.Edad))
            {
                com.Parameters.AddWithValue("@EDAD", masc.Edad);
            }
            else
            {
                com.Parameters.AddWithValue("@EDAD", null);
            }
            com.Parameters.AddWithValue("@ESTERILIZADO", masc.Esterilizado);

            int dayf = masc.Fecha_esterilizacion.Day;
            int mesf = masc.Fecha_esterilizacion.Month;
            int anniof = masc.Fecha_esterilizacion.Year;
            String date = "" + annio + "-" + mesf + "-" + dayf;
            com.Parameters.AddWithValue("@FECHA_ESTERILIZACION", date);
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
        public int D_registrar_mascota_SinFecha_esterilizado(Mascota masc)
        {
            String cadena = DConexion.cadena;
            String sql = "INSERT INTO mascota(SERIE, USUARIO, ID_TEMPORAL, FECHA_INGRESO, ID_TIPO, TAMANO, ESTADO, NOMBRE, RAZA, SEXO, COLOR, EDAD, ESTERILIZADO)" +
                         "VALUES (@SERIE, @USUARIO, @ID_TEMPORAL, @FECHA_INGRESO, @ID_TIPO, @TAMANO, @ESTADO, @NOMBRE, @RAZA, @SEXO, @COLOR, @EDAD, @ESTERILIZADO)";

            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();

            com.Parameters.AddWithValue("@SERIE", masc.Serie);
            if (masc.Ser_usu == null)
            {
                com.Parameters.AddWithValue("@USUARIO", null);

            }
            else
            {
                com.Parameters.AddWithValue("@USUARIO", masc.Ser_usu.Serie);

            }
            if (masc.Fic_tem == null)
            {
                com.Parameters.AddWithValue("@ID_TEMPORAL", null);

            }
            else
            {
                com.Parameters.AddWithValue("@ID_TEMPORAL", masc.Fic_tem.Id);

            }
            int day = masc.Fecha_ingreso.Day;
            int mes = masc.Fecha_ingreso.Month;
            int annio = masc.Fecha_ingreso.Year;
            String f_ingre = "" + annio + "-" + mes + "-" + day;
            com.Parameters.AddWithValue("@FECHA_INGRESO", f_ingre);

            if (masc.Tipomascota == null)
            {
                com.Parameters.AddWithValue("@ID_TIPO", null);

            }
            else
            {
                com.Parameters.AddWithValue("@ID_TIPO", masc.Tipomascota.Id);

            }
            com.Parameters.AddWithValue("@TAMANO", masc.Tamano);
            com.Parameters.AddWithValue("@ESTADO", masc.Estado);
            if (!String.IsNullOrEmpty(masc.Nombre))
            {
                com.Parameters.AddWithValue("@NOMBRE", masc.Nombre);
            }
            else
            {
                com.Parameters.AddWithValue("@NOMBRE", null);
            }
            if (!String.IsNullOrEmpty(masc.Raza))
            {
                com.Parameters.AddWithValue("@RAZA", masc.Raza);
            }
            else
            {
                com.Parameters.AddWithValue("@RAZA", null);
            }
            com.Parameters.AddWithValue("@SEXO", masc.Sexo);
            if (!String.IsNullOrEmpty(masc.Color))
            {
                com.Parameters.AddWithValue("@COLOR", masc.Color);
            }
            else
            {
                com.Parameters.AddWithValue("@COLOR", null);
            }
            if (!String.IsNullOrEmpty(masc.Edad))
            {
                com.Parameters.AddWithValue("@EDAD", masc.Edad);
            }
            else
            {
                com.Parameters.AddWithValue("@EDAD", null);
            }
            com.Parameters.AddWithValue("@ESTERILIZADO", masc.Esterilizado);







            int band;
            try
            {
                band = com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                band = 0;
                Console.Write("el error es : " + ex.Message);
            }
            cone.Close();
            return band;
        }
        public List<Mascota> D_ListarMascotas()
        {
            String cadena = DConexion.cadena;
            string sql = "select * from  mascota";
            List<Mascota> lista = new List<Mascota>();
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Mascota mascota = new Mascota();
                mascota.Serie = Convert.ToInt32(dr[0].ToString());
                int usuario = Convert.ToInt32(dr[1].ToString());
                Usuario u = new DUsuario().D_ver_Usuarioxserie(usuario);
                mascota.Ser_usu = u;

                if (!dr.IsDBNull(2))
                {
                    int id_temporal = Convert.ToInt32(dr[2].ToString());

                    mascota.Fic_tem = new DFichaTemporal().D_Buscar_FichaTemporal(id_temporal);

                }
                else
                {
                    mascota.Fic_tem = new FichaTemporal();
                }
                mascota.Fecha_ingreso = Convert.ToDateTime(dr[3].ToString());
                int id_tipo = Convert.ToInt32(dr[4].ToString());
                TipoMascota tipo = new DTipoMascota().D_buscar_TipoMascota(id_tipo);
                mascota.Tipomascota = tipo;
                mascota.Tamano = dr[5].ToString();
                mascota.Estado = dr[6].ToString();
                mascota.Nombre = dr[7].ToString();
                mascota.Raza = dr[8].ToString();
                mascota.Sexo = dr[9].ToString();
                mascota.Color = dr[10].ToString();
                mascota.Edad = dr[11].ToString();
                mascota.Esterilizado = dr[12].ToString();
                if (!dr.IsDBNull(13))
                {
                    mascota.Fecha_esterilizacion = Convert.ToDateTime(dr[13].ToString());

                }



                lista.Add(mascota);


            }
            cone.Close();
            return lista;
        }
        public String D_Ver_FechaEsterilizacion(int serie_mascota)
        {
            String cadena = DConexion.cadena;
            string sql = "select FECHA_ESTERILIZACION from  mascota where SERIE = @SERIE";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            com.Parameters.AddWithValue("@SERIE", serie_mascota);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                String fecha = "";
                if (!dr.IsDBNull(0))
                {
                    fecha = dr[0].ToString();
                }
                else
                {
                    fecha = "";
                }
                cone.Close();
                return fecha;


            }
            cone.Close();
            return null;
        }

        public int D_modificar_mascotaConFecha_Esterilizado(Mascota masc)
        {
            String cadena = DConexion.cadena;
            String sql = "UPDATE mascota SET USUARIO=@USUARIO, ID_TEMPORAL=@ID_TEMPORAL, FECHA_INGRESO=@FECHA_INGRESO, ID_TIPO=@ID_TIPO, TAMANO=@TAMANO, ESTADO=@ESTADO, NOMBRE=@NOMBRE, RAZA=@RAZA, SEXO=@SEXO, COLOR=@COLOR, EDAD=@EDAD, ESTERILIZADO=@ESTERILIZADO,FECHA_ESTERILIZACION=@FECHA_ESTERILIZACION  WHERE SERIE=@SERIE ";

            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            Console.Write("entro ");

            if (masc.Ser_usu == null)
            {
                com.Parameters.AddWithValue("@USUARIO", null);

            }
            else
            {
                com.Parameters.AddWithValue("@USUARIO", masc.Ser_usu.Serie);

            }
            if (masc.Fic_tem == null)
            {
                com.Parameters.AddWithValue("@ID_TEMPORAL", null);

            }
            else
            {
                com.Parameters.AddWithValue("@ID_TEMPORAL", masc.Fic_tem.Id);

            }
            int day = masc.Fecha_ingreso.Day;
            int mes = masc.Fecha_ingreso.Month;
            int annio = masc.Fecha_ingreso.Year;
            String f_ingre = "" + annio + "-" + mes + "-" + day;
            com.Parameters.AddWithValue("@FECHA_INGRESO", f_ingre);

            if (masc.Tipomascota == null)
            {
                com.Parameters.AddWithValue("@ID_TIPO", null);

            }
            else
            {
                com.Parameters.AddWithValue("@ID_TIPO", masc.Tipomascota.Id);

            }
            com.Parameters.AddWithValue("@TAMANO", masc.Tamano);
            com.Parameters.AddWithValue("@ESTADO", masc.Estado);
            if (!String.IsNullOrEmpty(masc.Nombre))
            {
                com.Parameters.AddWithValue("@NOMBRE", masc.Nombre);
            }
            else
            {
                com.Parameters.AddWithValue("@NOMBRE", null);
            }
            if (!String.IsNullOrEmpty(masc.Raza))
            {
                com.Parameters.AddWithValue("@RAZA", masc.Raza);
            }
            else
            {
                com.Parameters.AddWithValue("@RAZA", null);
            }
            com.Parameters.AddWithValue("@SEXO", masc.Sexo);
            if (!String.IsNullOrEmpty(masc.Color))
            {
                com.Parameters.AddWithValue("@COLOR", masc.Color);
            }
            else
            {
                com.Parameters.AddWithValue("@COLOR", null);
            }
            if (!String.IsNullOrEmpty(masc.Edad))
            {
                com.Parameters.AddWithValue("@EDAD", masc.Edad);
            }
            else
            {
                com.Parameters.AddWithValue("@EDAD", null);
            }
            com.Parameters.AddWithValue("@ESTERILIZADO", masc.Esterilizado);


            int dayf = masc.Fecha_esterilizacion.Day;
            int mesf = masc.Fecha_esterilizacion.Month;
            int anniof = masc.Fecha_esterilizacion.Year;
            String date = "" + annio + "-" + mesf + "-" + dayf;
            com.Parameters.AddWithValue("@FECHA_ESTERILIZACION", date);
            com.Parameters.AddWithValue("@SERIE", masc.Serie);
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
        public int D_modificar_mascota_SinFecha_Esterilizado(Mascota masc)
        {
            String cadena = DConexion.cadena;
            String sql = "UPDATE mascota  SET  USUARIO=@USUARIO, ID_TEMPORAL=@ID_TEMPORAL, FECHA_INGRESO=@FECHA_INGRESO, ID_TIPO=@ID_TIPO, TAMANO=@TAMANO, ESTADO=@ESTADO, NOMBRE=@NOMBRE, RAZA=@RAZA, SEXO=@SEXO, COLOR=@COLOR, EDAD=@EDAD, ESTERILIZADO=@ESTERILIZADO,FECHA_ESTERILIZACION=@FECHA_ESTERILIZACION WHERE SERIE=@SERIE";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();


            if (masc.Ser_usu == null)
            {
                com.Parameters.AddWithValue("@USUARIO", null);

            }
            else
            {
                com.Parameters.AddWithValue("@USUARIO", masc.Ser_usu.Serie);

            }
            if (masc.Fic_tem == null)
            {
                com.Parameters.AddWithValue("@ID_TEMPORAL", null);

            }
            else
            {
                com.Parameters.AddWithValue("@ID_TEMPORAL", masc.Fic_tem.Id);

            }
            int day = masc.Fecha_ingreso.Day;
            int mes = masc.Fecha_ingreso.Month;
            int annio = masc.Fecha_ingreso.Year;
            String f_ingre = "" + annio + "-" + mes + "-" + day;
            com.Parameters.AddWithValue("@FECHA_INGRESO", f_ingre);

            if (masc.Tipomascota == null)
            {
                com.Parameters.AddWithValue("@ID_TIPO", null);

            }
            else
            {
                com.Parameters.AddWithValue("@ID_TIPO", masc.Tipomascota.Id);

            }
            com.Parameters.AddWithValue("@TAMANO", masc.Tamano);
            com.Parameters.AddWithValue("@ESTADO", masc.Estado);
            if (!String.IsNullOrEmpty(masc.Nombre))
            {
                com.Parameters.AddWithValue("@NOMBRE", masc.Nombre);
            }
            else
            {
                com.Parameters.AddWithValue("@NOMBRE", null);
            }
            if (!String.IsNullOrEmpty(masc.Raza))
            {
                com.Parameters.AddWithValue("@RAZA", masc.Raza);
            }
            else
            {
                com.Parameters.AddWithValue("@RAZA", null);
            }
            com.Parameters.AddWithValue("@SEXO", masc.Sexo);
            if (!String.IsNullOrEmpty(masc.Color))
            {
                com.Parameters.AddWithValue("@COLOR", masc.Color);
            }
            else
            {
                com.Parameters.AddWithValue("@COLOR", null);
            }
            if (!String.IsNullOrEmpty(masc.Edad))
            {
                com.Parameters.AddWithValue("@EDAD", masc.Edad);
            }
            else
            {
                com.Parameters.AddWithValue("@EDAD", null);
            }
            com.Parameters.AddWithValue("@ESTERILIZADO", masc.Esterilizado);
            com.Parameters.AddWithValue("@FECHA_ESTERILIZACION", null);

            com.Parameters.AddWithValue("@SERIE", masc.Serie);

            int band;
            try
            {
                band = com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                band = 0;
                Console.Write("el error es : " + ex.Message);
            }
            cone.Close();
            return band;
        }

        public int D_eliminar_mascota(int id_serie)
        {
            String cadena = DConexion.cadena;
            String sql = "DELETE FROM mascota where SERIE=@SERIE";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@SERIE",id_serie);
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

        public Mascota D_Buscar_MascotaxSerie(int serie)
        {
            String cadena = DConexion.cadena;
            string sql = "select * from  mascota WHERE SERIE = @SERIE";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            com.Parameters.AddWithValue("@SERIE", serie);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Mascota mascota = new Mascota();
                mascota.Serie = Convert.ToInt32(dr[0].ToString());
                int usuario = Convert.ToInt32(dr[1].ToString());
                Usuario u = new DUsuario().D_ver_Usuarioxserie(usuario);
                mascota.Ser_usu = u;

                if (!dr.IsDBNull(2))
                {
                    int id_temporal = Convert.ToInt32(dr[2].ToString());

                    mascota.Fic_tem = new DFichaTemporal().D_Buscar_FichaTemporal(id_temporal);

                }
                else
                {
                    mascota.Fic_tem = new FichaTemporal();
                }
                mascota.Fecha_ingreso = Convert.ToDateTime(dr[3].ToString());
                int id_tipo = Convert.ToInt32(dr[4].ToString());
                TipoMascota tipo = new DTipoMascota().D_buscar_TipoMascota(id_tipo);
                mascota.Tipomascota = tipo;
                mascota.Tamano = dr[5].ToString();
                mascota.Estado = dr[6].ToString();
                mascota.Nombre = dr[7].ToString();
                mascota.Raza = dr[8].ToString();
                mascota.Sexo = dr[9].ToString();
                mascota.Color = dr[10].ToString();
                mascota.Edad = dr[11].ToString();
                mascota.Esterilizado = dr[12].ToString();
                if (!dr.IsDBNull(13))
                {
                    mascota.Fecha_esterilizacion = Convert.ToDateTime(dr[13].ToString());

                }

                cone.Close();
                return mascota;
            }
            cone.Close();
            return null;
        }
        

    }
}
