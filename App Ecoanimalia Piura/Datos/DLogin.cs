using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using App_Ecoanimalia_Piura.Datos;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Negocio;

namespace App_Ecoanimalia_Piura.Datos
{
     
    
    public class DLogin
    {
        MySqlConnection cone;
        #region metodos
        public Boolean iniciar_sesion(Usuario login)
        {
            String cadena = DConexion.cadena;
            string sql = "select count(*) from  usuario   where contrasena = @contra and USUARIO = @usuario and ESTADO = 'activo'";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@contra", login.Contrasena);
            com.Parameters.AddWithValue("@usuario", login.Usuario1);

            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                int band = Convert.ToInt32(dr[0]);
                if (band == 1)
                {
                    cone.Close();
                    return true;
                }
                else
                {
                    cone.Close();
                    return false;
                }

            }
            cone.Close();
            return false;



        }
        public Usuario D_ver_tipo(Usuario login)
        {
            String cadena = DConexion.cadena;
            string sql = "select * from  usuario   where CONTRASENA = @contra and USUARIO = @usuario and ESTADO = 'activo'";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@contra", login.Contrasena);
            com.Parameters.AddWithValue("@usuario", login.Usuario1);

            MySqlDataReader dr = com.ExecuteReader();

            Usuario u = new Usuario();

            while (dr.Read())
            {
                u.Serie = int.Parse(dr[0].ToString());
                u.Codigo = dr[1].ToString();
                if (!String.IsNullOrEmpty(dr[2].ToString()))
                {
                    Usuario encargado = new Usuario();
                    //encargado.
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
      
        
        
       


        public Boolean D_consultar_admin()
        {
            String cadena = DConexion.cadena;
            string sql = "SELECT  COUNT(*) FROM usuario where  TIPO = 'administrador' and ESTADO = 'activo' ";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();


            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                int band = Convert.ToInt32(dr[0]);
                if (band >= 1)
                {
                    cone.Close();
                    return true;
                }
                else
                {
                    cone.Close();
                    return false;
                }

            }
            cone.Close();
            return false;

        }
        #endregion

    }
}
