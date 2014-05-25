using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Datos;

namespace App_Ecoanimalia_Piura.Datos
{
    public class DPersona
    {
        MySqlConnection cone;

        public int D_registrar_persona(Persona persona)
        {
            String cadena = DConexion.cadena;
            String sql = "INSERT INTO persona (NOMBRE,APELLIDOS,DIRECCION,SEXO,EDAD,EMAIL,FACEBOOK,TEL_MOV,TEL_CLARO,TEL_NEX,TEL_CASA,HORARIO_DISPONIBLE) VALUES (@nombre,@apellidos,@direccion,@sexo,@edad,@email,@facebook,@tel_mov,@tel_claro,@tel_nex,@tel_casa,@hor_dis)";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();

            if (persona.Nombre.Equals(""))
            {
                com.Parameters.AddWithValue("@nombre", null);
            }
            else
            {
                com.Parameters.AddWithValue("@persona", persona.Nombre);
            }


            if (persona.Apellidos.Equals(""))
            {
                com.Parameters.AddWithValue("@apellidos", null);
            }
            else
            {
                com.Parameters.AddWithValue("@apellidos", persona.Apellidos);
            }

            if (persona.Direccion.Equals(""))
            {
                com.Parameters.AddWithValue("@direccion", null);
            }
            else
            {
                com.Parameters.AddWithValue("@direccion", persona.Direccion);
            }


            if (persona.Sexo.Equals(""))
            {
                com.Parameters.AddWithValue("@sexo", null);
            }
            else
            {
                com.Parameters.AddWithValue("@sexo", persona.Sexo);
            }
            // com.Parameters.AddWithValue("@sexo", persona.Sexo);


            if (persona.Edad.Equals(""))
            {
                com.Parameters.AddWithValue("@edad", null);
            }
            else
            {
                com.Parameters.AddWithValue("@edad", persona.Edad);
            }


            if (persona.Email.Equals(""))
            {
                com.Parameters.AddWithValue("@email", null);
            }
            else
            {
                com.Parameters.AddWithValue("@email", persona.Email);
            }

            if (persona.Facebook.Equals(""))
            {
                com.Parameters.AddWithValue("@facebook", null);
            }
            else
            {
                com.Parameters.AddWithValue("@facebook", persona.Facebook);
            }


            com.Parameters.AddWithValue("@tel_mov", persona.Tel_mov);
            com.Parameters.AddWithValue("@tel_claro", persona.Tel_claro);
            com.Parameters.AddWithValue("@tel_nex", persona.Tel_nex);
            com.Parameters.AddWithValue("@tel_casa", persona.Tel_casa);

            if (persona.Hor_disp.Equals(""))
            {
                com.Parameters.AddWithValue("@hor_dis", null);
            }
            else
            {
                com.Parameters.AddWithValue("@hor_dis", persona.Hor_disp);
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


        public int D_modificar_persona_fichaTemp(Persona persona)
        {
            String cadena = DConexion.cadena;
            String sql = "UPDATE persona set NOMBRE=@NOMBRE,APELLIDOS=@APELLIDOS,DNI=@DNI,DIRECCION=@DIRECCION,SEXO=@SEXO,EDAD=@EDAD,EMAIL=@EMAIL,FACEBOOK=@FACEBOOK,RPM=@RPM,TEL_MOV=@TEL_MOV,TEL_CLARO=@TEL_CLARO,TEL_NEX=@TEL_NEX,TEL_CASA=@TEL_CASA,HORARIO_DISPONIBLE=@HORARIO_DISPONIBLE WHERE ID = @ID";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();


            if (String.IsNullOrEmpty(persona.Nombre))
            {
                com.Parameters.AddWithValue("@NOMBRE", null);
            }
            else
            {
                com.Parameters.AddWithValue("@NOMBRE", persona.Nombre);
            }


            if (String.IsNullOrEmpty(persona.Apellidos))
            {
                com.Parameters.AddWithValue("@APELLIDOS", null);
            }
            else
            {
                com.Parameters.AddWithValue("@APELLIDOS", persona.Apellidos);
            }
            if (String.IsNullOrEmpty(persona.Dni))
            {
                com.Parameters.AddWithValue("@DNI", null);
            }
            else
            {
                com.Parameters.AddWithValue("@DNI", persona.Dni);
            }


            if (String.IsNullOrEmpty(persona.Direccion))
            {
                com.Parameters.AddWithValue("@DIRECCION", null);
            }
            else
            {
                com.Parameters.AddWithValue("@DIRECCION", persona.Direccion);
            }


            if (String.IsNullOrEmpty(persona.Sexo))
            {
                com.Parameters.AddWithValue("@SEXO", null);
            }
            else
            {
                com.Parameters.AddWithValue("@SEXO", persona.Sexo);
            }


            if (String.IsNullOrEmpty(persona.Edad))
            {
                com.Parameters.AddWithValue("@EDAD", null);
            }
            else
            {
                com.Parameters.AddWithValue("@EDAD", persona.Edad);
            }


            if (String.IsNullOrEmpty(persona.Email))
            {
                com.Parameters.AddWithValue("@EMAIL", null);
            }
            else
            {
                com.Parameters.AddWithValue("@EMAIL", persona.Email);
            }

            if (String.IsNullOrEmpty(persona.Facebook))
            {
                com.Parameters.AddWithValue("@FACEBOOK", null);
            }
            else
            {
                com.Parameters.AddWithValue("@FACEBOOK", persona.Facebook);
            }


            if (String.IsNullOrEmpty(persona.Rpm))
            {
                com.Parameters.AddWithValue("@RPM", null);
            }
            else
            {
                com.Parameters.AddWithValue("@RPM", persona.Rpm);
            }


            if ((persona.Tel_mov == 0) || (persona.Tel_mov == null))
            {
                com.Parameters.AddWithValue("@TEL_MOV", null);

            }
            else
            {
                com.Parameters.AddWithValue("@TEL_MOV", persona.Tel_mov);

            }

            if ((persona.Tel_claro == 0) || (persona.Tel_claro == null))
            {
                com.Parameters.AddWithValue("@TEL_CLARO", null);

            }
            else
            {
                com.Parameters.AddWithValue("@TEL_CLARO", persona.Tel_claro);

            }
            if (String.IsNullOrEmpty(persona.Tel_nex))
            {
                com.Parameters.AddWithValue("@TEL_NEX", null);

            }
            else
            {
                com.Parameters.AddWithValue("@TEL_NEX", persona.Tel_nex);

            }
            if ((persona.Tel_casa == 0) || (persona.Tel_casa == null))
            {
                com.Parameters.AddWithValue("@TEL_CASA", null);

            }
            else
            {
                com.Parameters.AddWithValue("@TEL_CASA", persona.Tel_casa);

            }

            if (String.IsNullOrEmpty(persona.Hor_disp))
            {
                com.Parameters.AddWithValue("@HORARIO_DISPONIBLE", null);
            }
            else
            {
                com.Parameters.AddWithValue("@HORARIO_DISPONIBLE", persona.Hor_disp);
            }

            com.Parameters.AddWithValue("@ID", persona.Id);

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


        public List<Persona> D_listar_persona(){
            String cadena = DConexion.cadena;
            List<Persona> lista = new List<Persona>();
            string sql = "select * from persona";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();

            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Persona persona = new Persona();
                persona.Id = Convert.ToInt32(dr[0]);


                if (!dr.IsDBNull(1))
                {

                    persona.Nombre = dr[1].ToString();
                }
                else
                {
                    persona.Nombre = "";
                }


                if (!dr.IsDBNull(2))
                {

                    persona.Apellidos = dr[2].ToString();
                }
                else
                {
                    persona.Apellidos = "";
                }
                if (!dr.IsDBNull(3))
                {

                    persona.Dni = dr[3].ToString();
                }
                else
                {
                    persona.Dni = "";
                }



                if (!dr.IsDBNull(4))
                {

                    persona.Direccion = dr[4].ToString();
                }
                else
                {
                    persona.Direccion = "";
                }


                if (!dr.IsDBNull(5))
                {
                    persona.Sexo = dr[5].ToString();
                }
                else
                {
                    persona.Sexo = "";
                }

                if (!dr.IsDBNull(6))
                {
                    persona.Edad = dr[6].ToString();
                }
                else
                {
                    persona.Edad = "";
                }


                if (!dr.IsDBNull(7))
                {
                    persona.Email = dr[7].ToString();
                }
                else
                {
                    persona.Email = "";
                }


                if (!String.IsNullOrEmpty(dr[8].ToString()))
                {
                    persona.Facebook = dr[8].ToString();
                }
                else
                {

                    persona.Facebook = "";
                }
                if (!String.IsNullOrEmpty(dr[9].ToString()))
                {
                    persona.Rpm = dr[9].ToString();
                }
                else
                {

                    persona.Rpm = "";
                }


                if (!String.IsNullOrEmpty(dr[10].ToString()))
                {
                    persona.Tel_mov = Convert.ToInt32(dr[10]);
                }
                else
                {

                    persona.Tel_mov = 0;
                }

                if (!String.IsNullOrEmpty(dr[11].ToString()))
                {
                    persona.Tel_claro = Convert.ToInt32(dr[11]);
                }
                else
                {

                    persona.Tel_claro = 0;
                }

                if (!String.IsNullOrEmpty(dr[12].ToString()))
                {
                    persona.Tel_nex = dr[12].ToString();
                }
                else
                {

                    persona.Tel_nex = "";
                }

                if (!String.IsNullOrEmpty(dr[13].ToString()))
                {
                    persona.Tel_casa = Convert.ToInt32(dr[13]);
                }
                else
                {

                    persona.Tel_casa = 0;
                }

                if (!dr.IsDBNull(14))
                {

                    persona.Hor_disp = dr[14].ToString();
                }
                else
                {
                    persona.Hor_disp = "";
                }
                lista.Add(persona);
            }
            cone.Close();
            return lista;

        
        }


        public int D_eliminar_persona(Persona persona)
        {
            String cadena = DConexion.cadena;
            String sql = "DELETE FROM persona WHERE ID = @id";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@id", persona.Id);
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

        public Persona D_buscar_Persona(int id)
        {
            String cadena = DConexion.cadena;
            string sql = "select * from  persona   where ID = @ID";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@ID", id);
            MySqlDataReader dr = com.ExecuteReader();
            Persona p = new Persona();
            while (dr.Read())
            {

                p.Id = int.Parse(dr[0].ToString());
                p.Nombre = dr[1].ToString();
                p.Apellidos = dr[2].ToString();
                p.Dni = dr[3].ToString();
                p.Direccion = dr[4].ToString();
                p.Sexo = dr[5].ToString();
                p.Edad = dr[6].ToString();
                p.Email = dr[7].ToString();
                p.Facebook = dr[8].ToString();
                p.Rpm = dr[9].ToString();
                if (!String.IsNullOrEmpty(dr[10].ToString()))
                {
                    p.Tel_mov = int.Parse(dr[10].ToString());
                }
                if (!String.IsNullOrEmpty(dr[11].ToString()))
                {
                    p.Tel_claro = int.Parse(dr[11].ToString());
                }

                p.Tel_nex = dr[12].ToString();
                if (!String.IsNullOrEmpty(dr[13].ToString()))
                {
                    p.Tel_casa = int.Parse(dr[13].ToString());
                }


                p.Hor_disp = dr[14].ToString();


                cone.Close();
                return p;
            }
            cone.Close();
            return p;
        }
        public Persona D_buscar_PersonaxDni(int dni)
        {
            String cadena = DConexion.cadena;
            string sql = "select * from  persona   where DNI = @DNI";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@DNI", dni);
            MySqlDataReader dr = com.ExecuteReader();
            Persona p = new Persona();
            while (dr.Read())
            {

                p.Id = int.Parse(dr[0].ToString());
                p.Nombre = dr[1].ToString();
                p.Apellidos = dr[2].ToString();
                p.Dni = dr[3].ToString();
                p.Direccion = dr[4].ToString();
                p.Sexo = dr[5].ToString();
                p.Edad = dr[6].ToString();
                p.Email = dr[7].ToString();
                p.Facebook = dr[8].ToString();
                p.Rpm = dr[9].ToString();
                p.Tel_mov = int.Parse(dr[10].ToString());
                p.Tel_claro = int.Parse(dr[11].ToString());
                p.Tel_nex = dr[12].ToString();
                p.Tel_casa = int.Parse(dr[13].ToString());
                p.Hor_disp = dr[14].ToString();


                cone.Close();
                return p;
            }
            cone.Close();
            return p;
        }




    }
}
