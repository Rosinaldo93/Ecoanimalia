using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App_Ecoanimalia_Piura.Negocio;

namespace App_Ecoanimalia_Piura.Graficos
{
    public partial class F_Perfil : Form
    {
        
        public F_Perfil()
        {
            InitializeComponent();
        }

        #region metodos
        public void activar_cajas()
        {
            text_codigo.Enabled = true;
            text_usuario.Enabled = true;
           // text_contrasena.Enabled = true;
           // text_contrasena.PasswordChar = char.Parse("\0");
            text_nombre.Enabled = true;
            text_apellido.Enabled = true;
            combo_sexo.Enabled = true;
            text_dni.Enabled = true;
            text_direccion.Enabled = true;
            text_movistar.Enabled = true;
            text_claro.Enabled = true;
            text_nextel.Enabled = true;
            text_telefono.Enabled = true;
            text_email.Enabled = true;
            text_facebook.Enabled = true;
            text_ocupacion.Enabled = true;
            text_referencia.Enabled = true;
        }
        public void desactivar_cajas()
        {
            text_codigo.Enabled = false;
            text_usuario.Enabled = false;
            text_contrasena.Enabled = false;
           // text_contrasena.PasswordChar = char.Parse("*");
            text_nombre.Enabled = false;
            text_apellido.Enabled = false;
            combo_sexo.Enabled = false;
            text_dni.Enabled = false;
            text_direccion.Enabled = false;
            text_movistar.Enabled = false;
            text_claro.Enabled = false;
            text_nextel.Enabled = false;
            text_telefono.Enabled = false;
            text_email.Enabled = false;
            text_facebook.Enabled = false;
            text_ocupacion.Enabled = false;
            text_referencia.Enabled = false;
        }
        public void miperfil()
        {
            lb_serie.Text = "00" + F_Login.perfil.Serie;
            text_codigo.Text = F_Login.perfil.Codigo;
            text_usuario.Text = F_Login.perfil.Usuario1;
            text_contrasena.Text = F_Login.perfil.Contrasena;
            text_apellido.Text = F_Login.perfil.Apellidos;
            text_nombre.Text = F_Login.perfil.Nombres;

            if (F_Login.perfil.Sexo.Equals("Masculino"))
            {
                combo_sexo.SelectedIndex = 0;

            }
            else
            {
                combo_sexo.SelectedIndex = 1;

            }
            lbestado.Text = F_Login.perfil.Estado;
            lbtipo.Text = F_Login.perfil.Tipo;
            text_dni.Text = F_Login.perfil.Dni;
            text_direccion.Text = "" + F_Login.perfil.Direccion;

            if (F_Login.perfil.Movistar != 0)
            {
                text_movistar.Text = "" + F_Login.perfil.Movistar;
            }
            else
            {
                text_movistar.Text = "";
            }
            if (F_Login.perfil.Claro != 0)
            {
                text_claro.Text = "" + F_Login.perfil.Claro;
            }
            else
            {
                text_claro.Text = "";
            }
            if (F_Login.perfil.Nextel != 0)
            {
                text_nextel.Text = "" + F_Login.perfil.Nextel;
            }
            else
            {
                text_nextel.Text = "";
            }
            if (F_Login.perfil.Telefono != 0)
            {
                text_telefono.Text = "" + F_Login.perfil.Telefono;
            }
            else
            {
                text_telefono.Text = "";
            }

            text_email.Text = F_Login.perfil.Email;
            text_facebook.Text = F_Login.perfil.Facebook;
            text_ocupacion.Text = F_Login.perfil.Ocupacion;
            text_referencia.Text = F_Login.perfil.Referencia;
           
        }
        public void llenar_combo()
        {
            combo_sexo.Items.Add("Masculino");
            combo_sexo.Items.Add("Femenino");
            

        }
        #endregion


        private void F_Perfil_Load(object sender, EventArgs e)
        {
            llenar_combo();
            desactivar_cajas();
            miperfil();
           
        }


        private void btn_modiperfil_Click(object sender, EventArgs e)
        {
            if (btn_modiperfil.Text.Equals("Guardar"))
            {
                //ejecuta consulta ;

                Boolean band1 = false, band2 = false, band3 = false, band4 = false, band5 = false, band6 = false;
                String mensaje = "Por Favor Complete los campos obligatorios : \n";
                int serie = F_Login.perfil.Serie;
                String codigo = "";
                String usuario = "";
                String clave = "";
                String nombre = "";
                String apellidos = "";
                String dni = "";
                String direccion = "";
                String referencia = "";
                int movistar = 0;
                int claro = 0;
                int telefono = 0;
                int nextel = 0;
                String email = "";
                String facebook = "";
                String ocupacion = "";
                String estado = F_Login.perfil.Estado;
                String tipo = F_Login.perfil.Tipo;

                if (!String.IsNullOrEmpty(text_codigo.Text))
                {
                    codigo = text_codigo.Text;
                }
                else
                {
                    mensaje = mensaje + "\n - Casilla de Codigo ";
                    band1 = true;

                }

                if (!String.IsNullOrEmpty(text_usuario.Text))
                {
                    usuario = text_usuario.Text;
                }
                else
                {
                    mensaje = mensaje + "\n - Casilla de Usuario ";
                    band2 = true;
                }
                if (!String.IsNullOrEmpty(text_contrasena.Text))
                {
                    clave = text_contrasena.Text;
                }
                else
                {
                    mensaje = mensaje + "\n - Casilla de Contraseña \n";
                    band3 = true;
                }


                if (!String.IsNullOrEmpty(text_nombre.Text))
                {
                    nombre = text_nombre.Text;
                }
                else
                {
                    mensaje = mensaje + "\n - Casilla de Nombre ";
                    band4 = true;
                }



                if (!String.IsNullOrEmpty(text_apellido.Text))
                {
                    apellidos = text_apellido.Text;
                }
                else
                {
                    mensaje = mensaje + "\n - Casilla de Apellidos ";
                    band5 = true;
                }
                String combo = "Masculino";
                if (combo_sexo.SelectedIndex != 0)
                {
                    combo = "Femenino";
                }

                if (!String.IsNullOrEmpty(text_dni.Text))
                {
                    dni = text_dni.Text;
                }
                else
                {
                    mensaje = mensaje + "\n - Casilla de Dni ";
                    band6 = true;
                }

                if (!String.IsNullOrEmpty(text_direccion.Text))
                {
                    direccion = text_direccion.Text;
                }
                if (!String.IsNullOrEmpty(text_referencia.Text))
                {
                    referencia = text_referencia.Text;
                }
                if (!String.IsNullOrEmpty(text_movistar.Text))
                {
                    movistar = int.Parse(text_movistar.Text);
                }
                if (!String.IsNullOrEmpty(text_claro.Text))
                {
                    claro = int.Parse(text_claro.Text);
                }
                if (!String.IsNullOrEmpty(text_nextel.Text))
                {
                    nextel = int.Parse(text_nextel.Text);
                }
                if (!String.IsNullOrEmpty(text_telefono.Text))
                {
                    telefono = int.Parse(text_telefono.Text);
                }
                if (!String.IsNullOrEmpty(text_email.Text))
                {
                    email = text_email.Text;
                }
                if (!String.IsNullOrEmpty(text_facebook.Text))
                {
                    facebook = text_facebook.Text;
                }
                if (!String.IsNullOrEmpty(text_ocupacion.Text))
                {
                    ocupacion = text_ocupacion.Text;
                }
                if (band1 == true || band2 == true || band3 == true || band4 == true || band5 == true || band6 == true)
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    int band = new NUsuario().N_Modificar_Usuario_perfil_admin(codigo, usuario, clave, nombre, apellidos, combo, dni, direccion, referencia, movistar, claro, nextel, telefono, email, facebook, ocupacion, tipo, estado,serie);
                    if (band == 0)
                    {
                        MessageBox.Show("Error Al Modificar Por favor intente nuevamente");
                    }
                    else
                    {
                        MessageBox.Show("Modificado Correctamente");
                        int ser = int.Parse(lb_serie.Text);
                        F_Login.perfil = new NUsuario().N_ver_Usuarioxserie(ser);
                        btn_modiperfil.Text = "Modificar Mi Perfil";
                        desactivar_cajas();
                        miperfil();
                        
                    }
                }
                }
            else
            {
                activar_cajas();
                btn_modiperfil.Text = "Guardar";
            }
        }

        private void btn_contra_Click(object sender, EventArgs e)
        {
            F_CambiarContra cam = new F_CambiarContra();
            cam.Visible = true;
        }
    }
}
