using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App_Ecoanimalia_Piura.Negocio;
using App_Ecoanimalia_Piura.Graficos;

namespace App_Ecoanimalia_Piura.Graficos
{
    public partial class text_contra : Form
    {
        public text_contra()
        {
            InitializeComponent();
        }

        #region metodos
        public Boolean consultar()
        {
            Boolean val = new NLogin().N_consultar_admin();
            return val;
        }
       
        public void completar_combo()
        {
            combo_sexo.Items.Add("Masculino");
            combo_sexo.Items.Add("Femenino");
            combo_sexo.SelectedIndex = 0;
        }
        public void boton_aceptar()
        {
            int serie = int.Parse(lb_serie.Text);
            Boolean band1 = false, band2 = false, band3 = false, band4 = false, band5 = false, band6 = false;
            String mensaje = "Por Favor Complete los campos obligatorios : \n";
            String codigo = "";
            String usuario = "";
            String clave = "";
            String nombre = "";
            String apellidos = "";
            String dni = "";
            String direccion = "";
            String referencia = "";
            int movistar = 0;
            int claro =0;
            int telefono = 0;
            int nextel = 0;
            String email = "";
            String facebook = "";
            String ocupacion = "";
            String estado = "activo";
            String tipo = "administrador";

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
                int band = new NUsuario().N_Registrar_Usuario_admin(serie,codigo, usuario, clave, nombre, apellidos, combo, dni, direccion, referencia, movistar, claro, nextel, telefono, email, facebook, ocupacion, tipo, estado); 
                if (band == 0)
                {
                    MessageBox.Show("Error Al Registrar Por favor intente nuevamente");
                }
                else
                {
                    MessageBox.Show("Registrado Correctamente");

                    F_Login login = new F_Login();
                    login.Show();
                    this.Hide();
                }
            }
        }
        public void Ver_serie()
        {
            lb_serie.Text = "";
            lb_serie.Text = "" + new NUsuario().N_Ultima_Serie();
           
        }
        #endregion

       

        private void F_Primera_Load(object sender, EventArgs e)
        {
            
            Application.DoEvents();
            
            if (consultar() == true)
            {
                this.Opacity = 0.0f;
                this.ShowInTaskbar = false;
                this.Hide();
                F_Login login = new F_Login();
                login.Show();

            }
            else
            {
                completar_combo();
                Ver_serie();
            }
            
        }

       
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            boton_aceptar();
        }
    }
}
