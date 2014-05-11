using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using App_Ecoanimalia_Piura.Logica;

namespace App_Ecoanimalia_Piura.Datos
{
    public class DFichaTemporal
    {
        MySqlConnection cone;

        public int D_Modificar_fichaTemporal(FichaTemporal temporal)
        {
            String cadena = DConexion.cadena;
            String sql1 = "UPDATE fichatemporal SET TIPO_MASCOTA=@TIPO_MASCOTA, ID_PERSONA=@ID_PERSONA, TAMANO=@TAMANO, ESTADO=@ESTADO, OBSERVACIONES=@OBSERVACIONES,VOLUNTARIO=@VOLUNTARIO WHERE ID = @ID";

            cone = new MySqlConnection(cadena);
            cone.Open();
            MySqlCommand com = new MySqlCommand(sql1, cone);
            MySqlTransaction trans = cone.BeginTransaction();
            com.Transaction = trans;
            //try
            //{

            com.Parameters.AddWithValue("@TIPO_MASCOTA", temporal.Tipomascota.Id);

            com.Parameters.AddWithValue("@ID_PERSONA", temporal.Persona.Id);

            if (!String.IsNullOrEmpty(temporal.Tamano))
            {
                com.Parameters.AddWithValue("@TAMANO", temporal.Tamano);
            }
            else
            {
                com.Parameters.AddWithValue("@TAMANO", null);
            }
            if (!String.IsNullOrEmpty(temporal.Estado))
            {
                com.Parameters.AddWithValue("@ESTADO", temporal.Estado);
            }
            else
            {
                com.Parameters.AddWithValue("@ESTADO", null);
            }
            if (!String.IsNullOrEmpty(temporal.Observaciones))
            {
                com.Parameters.AddWithValue("@OBSERVACIONES", temporal.Observaciones);
            }
            else
            {
                com.Parameters.AddWithValue("@OBSERVACIONES", null);

            }
            com.Parameters.AddWithValue("@VOLUNTARIO", temporal.Voluntario.Serie);
           
            com.Parameters.AddWithValue("@ID", temporal.Id);

            if (com.ExecuteNonQuery() == 1)
            {
                trans.Commit();

                int band2 = new DPersona().D_modificar_persona_fichaTemp(temporal.Persona);
                if (band2 == 1)
                {

                    cone.Close();
                    return 1;
                }
                else
                {
                    trans.Rollback();
                }

            }
            else
            {
                trans.Rollback();
            }
            cone.Close();
            return 0;
        }
        public int D_registrar_fichaTemporal(FichaTemporal temporal)
        {

            String cadena = DConexion.cadena;
            String sql1 = "INSERT INTO persona(NOMBRE, APELLIDOS, DNI, DIRECCION, SEXO, EDAD, EMAIL, FACEBOOK, RPM, TEL_MOV, TEL_CLARO, TEL_NEX, TEL_CASA, HORARIO_DISPONIBLE) " +
                          "VALUES (@NOMBRE, @APELLIDOS, @DNI, @DIRECCION, @SEXO, @EDAD, @EMAIL, @FACEBOOK, @RPM, @TEL_MOV, @TEL_CLARO, @TEL_NEX, @TEL_CASA, @HORARIO_DISPONIBLE)";
            cone = new MySqlConnection(cadena);
            cone.Open();
            MySqlCommand com = new MySqlCommand(sql1, cone);
            MySqlTransaction trans = cone.BeginTransaction();
            com.Transaction = trans;
            //try
            //{

            com.Parameters.AddWithValue("@NOMBRE", temporal.Persona.Nombre);
            com.Parameters.AddWithValue("@APELLIDOS", temporal.Persona.Apellidos);
            com.Parameters.AddWithValue("@DNI", temporal.Persona.Dni);

            if (!String.IsNullOrEmpty(temporal.Persona.Direccion))
            {
                com.Parameters.AddWithValue("@DIRECCION", temporal.Persona.Direccion);
            }
            else
            {
                com.Parameters.AddWithValue("@DIRECCION", null);

            }
            if (!String.IsNullOrEmpty(temporal.Persona.Sexo))
            {
                com.Parameters.AddWithValue("@SEXO", temporal.Persona.Sexo);
            }
            else
            {
                com.Parameters.AddWithValue("@SEXO", null);
            }

            if (!String.IsNullOrEmpty(temporal.Persona.Edad))
            {
                com.Parameters.AddWithValue("@EDAD", temporal.Persona.Edad);
            }
            else
            {
                com.Parameters.AddWithValue("@EDAD", null);
            }
            if (!String.IsNullOrEmpty(temporal.Persona.Email))
            {
                com.Parameters.AddWithValue("@EMAIL", temporal.Persona.Email);
            }
            else
            {
                com.Parameters.AddWithValue("@EMAIL", null);

            }
            if (!String.IsNullOrEmpty(temporal.Persona.Facebook))
            {
                com.Parameters.AddWithValue("@FACEBOOK", temporal.Persona.Facebook);
            }
            else
            {
                com.Parameters.AddWithValue("@FACEBOOK", null);
            }
            if (!String.IsNullOrEmpty(temporal.Persona.Rpm))
            {
                com.Parameters.AddWithValue("@RPM", temporal.Persona.Rpm);

            }
            else
            {
                com.Parameters.AddWithValue("@RPM", null);

            }
            if ((temporal.Persona.Tel_mov == 0) || (temporal.Persona.Tel_mov == null))
            {
                com.Parameters.AddWithValue("@TEL_MOV", null);
            }
            else
            {
                com.Parameters.AddWithValue("@TEL_MOV", temporal.Persona.Tel_mov);
            }
            if ((temporal.Persona.Tel_claro == 0) || (temporal.Persona.Tel_claro == null))
            {
                com.Parameters.AddWithValue("@TEL_CLARO", null);
            }
            else
            {
                com.Parameters.AddWithValue("@TEL_CLARO", temporal.Persona.Tel_claro);
            }
            if (!String.IsNullOrEmpty(temporal.Persona.Tel_nex))
            {
                com.Parameters.AddWithValue("@TEL_NEX", temporal.Persona.Tel_nex);

            }
            else
            {
                com.Parameters.AddWithValue("@TEL_NEX", null);
            }

            if ((temporal.Persona.Tel_casa == 0) || (temporal.Persona.Tel_casa == null))
            {
                com.Parameters.AddWithValue("@TEL_CASA", null);
            }
            else
            {
                com.Parameters.AddWithValue("@TEL_CASA", temporal.Persona.Tel_casa);
            }

            if (!String.IsNullOrEmpty(temporal.Persona.Hor_disp))
            {
                com.Parameters.AddWithValue("@HORARIO_DISPONIBLE", temporal.Persona.Hor_disp);

            }
            else
            {
                com.Parameters.AddWithValue("@HORARIO_DISPONIBLE", null);


            }
            if (com.ExecuteNonQuery() == 1)
            {
                trans.Commit();

                int id_persona = ultima_persona(temporal.Persona.Dni);
                temporal.Persona.Id = id_persona;

                int band2 = D_registrar_fichaT(temporal);

                if (band2 == 1)
                {

                    cone.Close();
                    return 1;
                }
                else
                {
                    trans.Rollback();
                }
            }
            else
            {
                trans.Rollback();
            }


            // }
            //catch (Exception ex)
            //{
            //    Console.Write("error es :"+ex.Message);
            //    trans.Rollback();
            //    cone.Close();
            //    return 0;
            //}

            cone.Close();
            return 0;
        }

        public int ultima_persona(String dni)
        {
            int val = 0;
            String cadena = DConexion.cadena;
            string sql = "select id from  persona   where DNI = @DNI";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@DNI", dni);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                val = int.Parse(dr[0].ToString());
                cone.Close();
                return val;
            }
            cone.Close();
            return val;


        }

        public int D_registrar_fichaT(FichaTemporal temporal)
        {
            String cadena = DConexion.cadena;
            String sql = "INSERT INTO fichatemporal (TIPO_MASCOTA,ID_PERSONA,TAMANO,ESTADO,OBSERVACIONES,VOLUNTARIO) VALUES (@tipo,@persona,@tamano,@estado,@observaciones,@VOLUNTARIO)";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@tipo", temporal.Tipomascota.Id);
            com.Parameters.AddWithValue("@persona", temporal.Persona.Id);



            if (String.IsNullOrEmpty(temporal.Tamano))
            {
                com.Parameters.AddWithValue("@tamano", null);
            }
            else
            {
                com.Parameters.AddWithValue("@tamano", temporal.Tamano);
            }

            if (String.IsNullOrEmpty(temporal.Estado))
            {
                com.Parameters.AddWithValue("@estado", null);
            }
            else
            {
                com.Parameters.AddWithValue("@estado", temporal.Estado);
            }
            if (String.IsNullOrEmpty(temporal.Observaciones))
            {
                com.Parameters.AddWithValue("@observaciones", null);
            }
            else
            {
                com.Parameters.AddWithValue("@observaciones", temporal.Observaciones);
            }
            com.Parameters.AddWithValue("@VOLUNTARIO", temporal.Voluntario.Serie);


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


        //public int D_modificar_fichaT(FichaTemporal temporal)
        //{
        //    String cadena = DConexion.cadena;
        //    String sql = "UPDATE fichatemporal SET TIPO_MASCOTA=@tipo,ID_PERSONA=@persona,TAMANO=@tamano,ESTADO=@estado  where ID=@id";
        //    cone = new MySqlConnection(cadena);
        //    MySqlCommand com = new MySqlCommand(sql, cone);
        //    cone.Open();
        //    if (temporal.Tipomascota == null)
        //    {
        //        com.Parameters.AddWithValue("@tipo", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@tipo", temporal.Tipomascota.Id);
        //    }


        //    if (temporal.Persona == null)
        //    {
        //        com.Parameters.AddWithValue("@persona", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@persona", temporal.Persona.Id);
        //    }


        //    if (temporal.Tamano.Equals(""))
        //    {
        //        com.Parameters.AddWithValue("@tamano", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@tamano", temporal.Tamano);
        //    }

        //    if (temporal.Estado.Equals(""))
        //    {
        //        com.Parameters.AddWithValue("@estado", null);
        //    }
        //    else
        //    {
        //        com.Parameters.AddWithValue("@estado", temporal.Estado);
        //    }


        //    com.Parameters.AddWithValue("@id", temporal.Id);
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


        public int D_eliminar_fichaT(int  id)
        {
            String cadena = DConexion.cadena;
            String sql = "DELETE FROM fichatemporal where ID=@id";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            com.Parameters.AddWithValue("@id",id);
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

        //FALTA LISTAR

        public List<FichaTemporal> D_Listar_FichaTemporal()
        {

            String cadena = DConexion.cadena;
            string sql = "select * from  fichatemporal";
            List<FichaTemporal> lista = new List<FichaTemporal>();
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                FichaTemporal tem = new FichaTemporal();
                tem.Id = int.Parse(dr[0].ToString());
                int id_tipo = int.Parse(dr[1].ToString());
                tem.Tipomascota = new DTipoMascota().D_buscar_TipoMascota(id_tipo);
                int id_persona = int.Parse(dr[2].ToString());
                tem.Persona = new DPersona().D_buscar_Persona(id_persona);
                tem.Tamano = dr[3].ToString();
                tem.Estado = dr[4].ToString();
                tem.Observaciones = dr[5].ToString();
                int serie = int.Parse(dr[6].ToString());
                tem.Voluntario = new DUsuario().D_ver_Encargado(serie);
                lista.Add(tem);


            }
            cone.Close();
            return lista;
        }
        public FichaTemporal D_Buscar_FichaTemporal(int id_temporal)
        {
            String cadena = DConexion.cadena;
            string sql = "select * from  fichatemporal where ID = @ID";
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            com.Parameters.AddWithValue("@ID",id_temporal);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                FichaTemporal tem = new FichaTemporal();
                tem.Id = int.Parse(dr[0].ToString());
                int id_tipo = int.Parse(dr[1].ToString());
                tem.Tipomascota = new DTipoMascota().D_buscar_TipoMascota(id_tipo);
                int id_persona = int.Parse(dr[2].ToString());
                tem.Persona = new DPersona().D_buscar_Persona(id_persona);
                tem.Tamano = dr[3].ToString();
                tem.Estado = dr[4].ToString();
                tem.Observaciones = dr[5].ToString();
                int serie = int.Parse(dr[6].ToString());
                tem.Voluntario = new DUsuario().D_ver_Encargado(serie);
                cone.Close();
                return tem;


            }
            cone.Close();
            return null; 
        }
        public List<FichaTemporal> D_Listar_FichaTemporal_activos()
        {

            String cadena = DConexion.cadena;
            string sql = "select * from  fichatemporal where ESTADO = 'Activo'";
            List<FichaTemporal> lista = new List<FichaTemporal>();
            cone = new MySqlConnection(cadena);
            MySqlCommand com = new MySqlCommand(sql, cone);
            cone.Open();
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                FichaTemporal tem = new FichaTemporal();
                tem.Id = int.Parse(dr[0].ToString());
                int id_tipo = int.Parse(dr[1].ToString());
                tem.Tipomascota = new DTipoMascota().D_buscar_TipoMascota(id_tipo);
                int id_persona = int.Parse(dr[2].ToString());
                tem.Persona = new DPersona().D_buscar_Persona(id_persona);
                tem.Tamano = dr[3].ToString();
                tem.Estado = dr[4].ToString();
                tem.Observaciones = dr[5].ToString();
                int serie = int.Parse(dr[6].ToString());
                tem.Voluntario = new DUsuario().D_ver_Encargado(serie);
                lista.Add(tem);


            }
            cone.Close();
            return lista;
        }
       

    }
}
