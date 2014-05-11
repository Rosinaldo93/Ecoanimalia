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
    public partial class F_CambiarContra : Form
    {
        public F_CambiarContra()
        {
            InitializeComponent();
        }


        private void btn_cambiar_Click(object sender, EventArgs e)
        {
            String actual = text_actual.Text;
            String nueva = text_nueva.Text;
            String confirmar = text_confirma.Text;
            if (F_Login.perfil.Contrasena.Equals(actual))
            {
                if (nueva.Equals(confirmar))
                {
                    int band = new NUsuario().N_cambiar_contra_usuario(F_Login.perfil.Serie, nueva);
                    if (band == 0)
                    {
                        MessageBox.Show("Error Por favor intente nuevamente");
                    }
                    else
                    {
                        MessageBox.Show("Guardado Correctamente");
                        int ser = F_Login.perfil.Serie;
                        F_Login.perfil = new NUsuario().N_ver_Usuarioxserie(ser);
                        this.Dispose();
                    }
                    //cambio realizado
              
                
                }
                else
                {

                    MessageBox.Show("Contraseñas No Coinciden");

                }
            }
            else
            {

                MessageBox.Show("Contraseña Actual Incorrecta");
            }
        }
    }
}
