using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Negocio;

namespace App_Ecoanimalia_Piura.Datos
{
   public class DUsuario
    {
        MySqlConnection cone;
        public int D_registrar_Usuario_Admin(Usuario usu)
        {
            
            String cadena = DConexion.cadena;
            String sql = "INSERT INTO usuario(SERIE,CODIGO, ENCARGADO,USUARIO,CONTRASENA,TIPO,NOMBRES,APELLIDOS,SEXO, DNI, DIRECCION, REFERENCIA,MOVISTAR, CLARO, NEXTEL,TELEFONO,EMAIL,FACEBOOK,OCUPACION,ESTADO)" +
"VALUES (@SERIE,@CODIGO,@ENCARGADO, @USUARIO,@CONTRASENA,@TIPO,@NOMBRES, @APELLIDOS,@SEXO,@DNI,@DIRECCION, @REFERENCIA,@MOVISTAR,@CLARO,@NEXTEL,@TELEFONO,@EMAIL,@FACEBOOK,@OCUPACION,@ESTADO)";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            int band;
            cone.Open();
            try
            {
            com.Parameters.AddWithValue("@SERIE", usu.Serie);
            com.Parameters.AddWithValue("@CODIGO",usu.Codigo);
            if (usu.Encargado == null)
            {
                com.Parameters.AddWithValue("@ENCARGADO", null);
            }
            else
            {
                com.Parameters.AddWithValue("@ENCARGADO", usu.Encargado.Serie);
            }

            if (usu.Usuario1 == null)
            {
                com.Parameters.AddWithValue("@USUARIO", null);
            }
            else
            {
                com.Parameters.AddWithValue("@USUARIO", usu.Usuario1);
            }
            if (usu.Contrasena == null)
            {
                com.Parameters.AddWithValue("@CONTRASENA", null);
            }
            else
            {
                com.Parameters.AddWithValue("@CONTRASENA", usu.Contrasena);
            }
           
            
            com.Parameters.AddWithValue("@TIPO", usu.Tipo);
            com.Parameters.AddWithValue("@NOMBRES", usu.Nombres);
            com.Parameters.AddWithValue("@APELLIDOS", usu.Apellidos);
            com.Parameters.AddWithValue("@SEXO", usu.Sexo);
            com.Parameters.AddWithValue("@DNI", usu.Dni);
            com.Parameters.AddWithValue("@DIRECCION", usu.Direccion);
            com.Parameters.AddWithValue("@REFERENCIA", usu.Referencia);
            com.Parameters.AddWithValue("@MOVISTAR", usu.Movistar);
            com.Parameters.AddWithValue("@CLARO", usu.Claro);
            com.Parameters.AddWithValue("@NEXTEL", usu.Nextel);
            com.Parameters.AddWithValue("@TELEFONO", usu.Telefono);
            com.Parameters.AddWithValue("@EMAIL", usu.Email);
            com.Parameters.AddWithValue("@FACEBOOK", usu.Facebook);
            com.Parameters.AddWithValue("@OCUPACION", usu.Ocupacion);
            com.Parameters.AddWithValue("@ESTADO", usu.Estado);
            band = com.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                band = 0;
                Console.WriteLine(""+e.Message);

            }
            cone.Close();
            return band;
        }

        public int D_modificar_Usuario_Admin(Usuario usu)
        {
            String cadena = DConexion.cadena;
            String sql = "UPDATE  usuario SET CODIGO=@CODIGO,ENCARGADO=@ENCARGADO, USUARIO=@USUARIO,CONTRASENA=@CONTRASENA,TIPO=@TIPO,NOMBRES=@NOMBRES,APELLIDOS=@APELLIDOS,SEXO=@SEXO, DNI=@DNI, DIRECCION=@DIRECCION, REFERENCIA=@REFERENCIA,MOVISTAR=@MOVISTAR, CLARO=@CLARO, NEXTEL=@NEXTEL,TELEFONO=@TELEFONO,EMAIL=@EMAIL,FACEBOOK=@FACEBOOK,OCUPACION=@OCUPACION,ESTADO=@ESTADO WHERE SERIE = @SERIE";

            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            int band;
            cone.Open();
            try
            {
                com.Parameters.AddWithValue("@CODIGO", usu.Codigo);

                if (usu.Encargado == null)
                {
                    com.Parameters.AddWithValue("@ENCARGADO", null);
                }
                else
                {
                    com.Parameters.AddWithValue("@ENCARGADO", usu.Encargado.Serie);
                }

                if (usu.Usuario1 == null)
                {
                    com.Parameters.AddWithValue("@USUARIO", null);
                }
                else
                {
                    com.Parameters.AddWithValue("@USUARIO", usu.Usuario1);
                }
                if (usu.Contrasena == null)
                {
                    com.Parameters.AddWithValue("@CONTRASENA", null);
                }
                else
                {
                    com.Parameters.AddWithValue("@CONTRASENA", usu.Contrasena);
                }


                com.Parameters.AddWithValue("@TIPO", usu.Tipo);
                com.Parameters.AddWithValue("@NOMBRES", usu.Nombres);
                com.Parameters.AddWithValue("@APELLIDOS", usu.Apellidos);
                com.Parameters.AddWithValue("@SEXO", usu.Sexo);
                com.Parameters.AddWithValue("@DNI", usu.Dni);
                com.Parameters.AddWithValue("@DIRECCION", usu.Direccion);
                com.Parameters.AddWithValue("@REFERENCIA", usu.Referencia);
                com.Parameters.AddWithValue("@MOVISTAR", usu.Movistar);
                com.Parameters.AddWithValue("@CLARO", usu.Claro);
                com.Parameters.AddWithValue("@NEXTEL", usu.Nextel);
                com.Parameters.AddWithValue("@TELEFONO", usu.Telefono);
                com.Parameters.AddWithValue("@EMAIL", usu.Email);
                com.Parameters.AddWithValue("@FACEBOOK", usu.Facebook);
                com.Parameters.AddWithValue("@OCUPACION", usu.Ocupacion);
                com.Parameters.AddWithValue("@ESTADO", usu.Estado);
                com.Parameters.AddWithValue("@SERIE", usu.Serie);
                band = com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                band = 0;

            }
            cone.Close();
            return band;
        }

        public int D_cambiar_contra_usuario(Usuario usu)
        {
            String cadena = DConexion.cadena;
            String sql = "UPDATE  usuario SET CONTRASENA=@CONTRASENA WHERE SERIE = @SERIE";

            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            int band;
            cone.Open();
            try
            {
               com.Parameters.AddWithValue("@CONTRASENA", usu.Contrasena);
               com.Parameters.AddWithValue("@SERIE", usu.Serie);
                band = com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                band = 0;

            }
            cone.Close();
            return band;
        }
        public Usuario D_ver_Encargado_xcodigo(String cod)
        {
            String cadena = DConexion.cadena;
            string sql = "select * from  usuario   where CODIGO = @CODIGO";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@CODIGO", cod);


            MySqlDataReader dr = com.ExecuteReader();

            Usuario u = new Usuario();

            while (dr.Read())
            {
                u.Serie = int.Parse(dr[0].ToString());
                u.Codigo = dr[1].ToString();
                if (!String.IsNullOrEmpty(dr[3].ToString()))
                {
                    u.Usuario1 = dr[3].ToString();
                }

                if (!String.IsNullOrEmpty(dr[4].ToString()))
                {
                    CCryptorEngine cr = new CCryptorEngine();
                    u.Contrasena = cr.Desencriptar(dr[4].ToString());
                }
                u.Tipo = dr[5].ToString();
                u.Nombres = dr[6].ToString();
                u.Apellidos = dr[7].ToString();
                u.Sexo = dr[8].ToString();
                u.Dni = dr[9].ToString();
                u.Direccion = dr[10].ToString();
                u.Referencia = dr[11].ToString();
                u.Movistar = int.Parse(dr[12].ToString());
                u.Claro = int.Parse(dr[13].ToString());
                u.Nextel = int.Parse(dr[14].ToString());
                u.Telefono = int.Parse(dr[15].ToString());
                u.Email = dr[16].ToString();
                u.Facebook = dr[17].ToString();
                u.Ocupacion = dr[18].ToString();
                u.Estado = dr[19].ToString();


                cone.Close();
                return u;

            }
            cone.Close();
            return null;
        }

        public Usuario D_ver_Encargado(int serie){
            String cadena = DConexion.cadena;
            string sql = "select * from  usuario   where SERIE = @SERIE";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@SERIE", serie);


            MySqlDataReader dr = com.ExecuteReader();

            Usuario u = new Usuario();

            while (dr.Read())
            {
                u.Serie = int.Parse(dr[0].ToString());
                u.Codigo = dr[1].ToString();
                if (!String.IsNullOrEmpty(dr[3].ToString()))
                {
                    u.Usuario1 = dr[3].ToString();
                }

                if (!String.IsNullOrEmpty(dr[4].ToString()))
                {
                    CCryptorEngine cr = new CCryptorEngine();
                    u.Contrasena = cr.Desencriptar(dr[4].ToString());
                }
                u.Tipo = dr[5].ToString();
                u.Nombres = dr[6].ToString();
                u.Apellidos = dr[7].ToString();
                u.Sexo = dr[8].ToString();
                u.Dni = dr[9].ToString();
                u.Direccion = dr[10].ToString();
                u.Referencia = dr[11].ToString();
                u.Movistar = int.Parse(dr[12].ToString());
                u.Claro = int.Parse(dr[13].ToString());
                u.Nextel = int.Parse(dr[14].ToString());
                u.Telefono = int.Parse(dr[15].ToString());
                u.Email = dr[16].ToString();
                u.Facebook = dr[17].ToString();
                u.Ocupacion = dr[18].ToString();
                u.Estado = dr[19].ToString();


                cone.Close();
                return u;

            }
            cone.Close();
            return null;
        }

        public int ultima_serie()
        {
            String cadena = DConexion.cadena;
            string sql = "select max(serie) from usuario";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();
            int band=0;
            
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
        public Usuario D_ver_Usuarioxserie(int serie)
        {
            String cadena = DConexion.cadena;
            string sql = "select * from  usuario   where SERIE = @SERIE";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@SERIE",serie);
            

            MySqlDataReader dr = com.ExecuteReader();

            Usuario u = new Usuario();

            while (dr.Read())
            {
                u.Serie = int.Parse(dr[0].ToString());
                u.Codigo = dr[1].ToString();
                if (!String.IsNullOrEmpty(dr[2].ToString()))
                {
                    int encar = int.Parse(dr[2].ToString());
                    Usuario encargado = new DUsuario().D_ver_Encargado(encar);
                    u.Encargado = encargado;
                    
                }

                if (!String.IsNullOrEmpty(dr[3].ToString()))
                {
                    u.Usuario1 = dr[3].ToString();
                }

                if (!String.IsNullOrEmpty(dr[4].ToString()))
                {
                    CCryptorEngine cr = new CCryptorEngine();
                    u.Contrasena = cr.Desencriptar(dr[4].ToString());
                }
                u.Tipo = dr[5].ToString();
                u.Nombres = dr[6].ToString();
                u.Apellidos = dr[7].ToString();
                u.Sexo = dr[8].ToString();
                u.Dni = dr[9].ToString();
                u.Direccion = dr[10].ToString();
                u.Referencia = dr[11].ToString();
                u.Movistar = int.Parse(dr[12].ToString());
                u.Claro = int.Parse(dr[13].ToString());
                u.Nextel = int.Parse(dr[14].ToString());
                u.Telefono = int.Parse(dr[15].ToString());
                u.Email = dr[16].ToString();
                u.Facebook = dr[17].ToString();
                u.Ocupacion = dr[18].ToString();
                u.Estado = dr[19].ToString();


                cone.Close();
                return u;

            }
            cone.Close();
            return null;
        }

        public List<Usuario> D_mostrar_usuarios()
        {
            String cadena = DConexion.cadena;
            List<Usuario> lista = new List<Usuario>();
            string sql = "select * from  usuario";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();

            

            while (dr.Read())
            {
                Usuario u = new Usuario();
                u.Serie = int.Parse(dr[0].ToString());
                u.Codigo = dr[1].ToString();
                if (!String.IsNullOrEmpty(dr[2].ToString()))
                {
                    int encar = int.Parse(dr[2].ToString());
                    Usuario encargado = new DUsuario().D_ver_Encargado(encar);
                    u.Encargado = encargado;

                }

                if (!String.IsNullOrEmpty(dr[3].ToString()))
                {
                    u.Usuario1 = dr[3].ToString();
                }

                if (!String.IsNullOrEmpty(dr[4].ToString()))
                {
                    CCryptorEngine cr = new CCryptorEngine();
                    u.Contrasena = cr.Desencriptar(dr[4].ToString());
                }
                u.Tipo = dr[5].ToString();
                u.Nombres = dr[6].ToString();
                u.Apellidos = dr[7].ToString();
                u.Sexo = dr[8].ToString();
                u.Dni = dr[9].ToString();
                u.Direccion = dr[10].ToString();
                u.Referencia = dr[11].ToString();
                u.Movistar = int.Parse(dr[12].ToString());
                u.Claro = int.Parse(dr[13].ToString());
                u.Nextel = int.Parse(dr[14].ToString());
                u.Telefono = int.Parse(dr[15].ToString());
                u.Email = dr[16].ToString();
                u.Facebook = dr[17].ToString();
                u.Ocupacion = dr[18].ToString();
                u.Estado = dr[19].ToString();
                lista.Add(u); 
            }
            cone.Close();
            return lista;
        }
        public int D_Eliminar_usuario_voluntario(int serie)
        {
            String cadena = DConexion.cadena;
            String sql = "DELETE FROM usuario where SERIE=@SERIE";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@SERIE", serie);
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
        public List<Usuario> D_mostrar_solo_Voluntarios()
        {
            String cadena = DConexion.cadena;
            List<Usuario> lista = new List<Usuario>();
            string sql = "select * from usuario u where u.TIPO != 'administrador'";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();



            while (dr.Read())
            {
                Usuario u = new Usuario();
                u.Serie = int.Parse(dr[0].ToString());
                u.Codigo = dr[1].ToString();
                if (!String.IsNullOrEmpty(dr[2].ToString()))
                {
                    int encar = int.Parse(dr[2].ToString());
                    Usuario encargado = new DUsuario().D_ver_Encargado(encar);
                    u.Encargado = encargado;

                }

                if (!String.IsNullOrEmpty(dr[3].ToString()))
                {
                    u.Usuario1 = dr[3].ToString();
                }

                if (!String.IsNullOrEmpty(dr[4].ToString()))
                {
                    CCryptorEngine cr = new CCryptorEngine();
                    u.Contrasena = cr.Desencriptar(dr[4].ToString());
                }
                u.Tipo = dr[5].ToString();
                u.Nombres = dr[6].ToString();
                u.Apellidos = dr[7].ToString();
                u.Sexo = dr[8].ToString();
                u.Dni = dr[9].ToString();
                u.Direccion = dr[10].ToString();
                u.Referencia = dr[11].ToString();
                u.Movistar = int.Parse(dr[12].ToString());
                u.Claro = int.Parse(dr[13].ToString());
                u.Nextel = int.Parse(dr[14].ToString());
                u.Telefono = int.Parse(dr[15].ToString());
                u.Email = dr[16].ToString();
                u.Facebook = dr[17].ToString();
                u.Ocupacion = dr[18].ToString();
                u.Estado = dr[19].ToString();
                lista.Add(u);
            }
            cone.Close();
            return lista;
        }

    }
}
