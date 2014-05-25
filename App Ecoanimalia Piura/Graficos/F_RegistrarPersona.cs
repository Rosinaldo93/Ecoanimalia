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
    public partial class F_RegistrarPersona : Form
    {
        F_FichaAdopcion adopcion;
        public F_RegistrarPersona()
        {
            InitializeComponent();
        }
        public F_RegistrarPersona(F_FichaAdopcion pointer)
        {
            this.adopcion = pointer;
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Boolean band1 = false, band2 = false, band3 = false;
            String mensaje = "Por Favor Complete los campos obligatorios : \n";

            String nombre = "";
            String apellidos = "";
            String dni = "";
            String direccion = "";
            String sexo = "";
            String edad = "";
            int movistar = 0;
            int claro = 0;
            int telefono = 0;
            String nextel = "";
            String rpm = "";
            String email = "";
            String facebook = "";
            String horario = "";
            
            if (!String.IsNullOrEmpty(text_nombre.Text))
            {
                nombre = text_nombre.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Nombre ";
                band1 = true;
            }



            if (!String.IsNullOrEmpty(text_apellido.Text))
            {
                apellidos = text_apellido.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Apellidos ";
                band2 = true;
            }
            if (!String.IsNullOrEmpty(text_dni.Text))
            {
                dni = text_dni.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Dni ";
                band3 = true;
            }
            if (!String.IsNullOrEmpty(text_direccion.Text))
            {
                direccion = text_direccion.Text;
            }



            if (radio_masculino.Checked == true)
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "Femenino";
            }
            
            if (!String.IsNullOrEmpty(text_edad.Text))
            {
                edad = text_edad.Text;
            }
            if (!String.IsNullOrEmpty(text_email.Text))
            {
                email = text_email.Text;
            }
            if (!String.IsNullOrEmpty(text_facebook.Text))
            {
                facebook = text_facebook.Text;
            }
            if (!String.IsNullOrEmpty(text_rpm.Text))
            {
                rpm = text_rpm.Text;
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
                nextel = text_nextel.Text;
            }
            if (!String.IsNullOrEmpty(text_telefono.Text))
            {
                telefono = int.Parse(text_telefono.Text);
            }
            if (!String.IsNullOrEmpty(text_horario.Text))
            {
                horario = text_horario.Text;
            }
            
            if (band1 == true || band2 == true || band3 == true)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                int confir1 = new NPersona().N_registrar_persona(nombre, apellidos, dni, direccion, sexo, edad, email, facebook, rpm, movistar, claro, nextel, telefono, horario);
                if (confir1 == 0)
                {
                    MessageBox.Show("Error Al Registrar Por favor intente nuevamente");

                }
                else
                {
                    MessageBox.Show("Registrado Correctamente");
                    adopcion.actualizar_lista_adoptante();
                    this.Close();
                    
                }
            }


        }

        private void F_RegistrarPersona_Load(object sender, EventArgs e)
        {

        }
    }
}
