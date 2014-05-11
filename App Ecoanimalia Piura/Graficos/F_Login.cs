using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App_Ecoanimalia_Piura.Negocio;
using App_Ecoanimalia_Piura.Logica;





namespace App_Ecoanimalia_Piura.Graficos
{
    public partial class F_Login : Form
    {
       
        public static Usuario perfil;
        public F_Login()
        {
            InitializeComponent();
        }

        #region
        public void iniciar_sesion()
        {
            String usuario = Text_Usuario.Text;
            String clave = Text_Contra.Text;
            Boolean band = new NLogin().verificar_sesion(usuario, clave);
            if (band == true)
            {
                perfil =  new NLogin().ver_tipo(usuario, clave);
                
                MessageBox.Show("Accedio Al Sistema Bienvenido :" + perfil.Nombres+" "+perfil.Apellidos);
                this.Hide();

                F_Principal prin = new F_Principal();
                prin.Visible = true;


            }
            else
            {
                MessageBox.Show("Error : Datos Incorrectos - Intente Nuevamente");
                Text_Usuario.Focus();
                regresar_barra();
            }


        }
        public void cargar_barra()
        {
            progressBar1.Maximum = 1000000;

            progressBar1.Minimum = 0;

            progressBar1.Value = 0;
            progressBar1.Step = 25;
            for (int i = progressBar1.Minimum; i < progressBar1.Maximum; i = i + progressBar1.Step)
            {
                progressBar1.PerformStep();
            }
        } 
        public void regresar_barra()
        {
            progressBar1.Value = 0;
        }
        #endregion

        private void Btn_Sesion_Click(object sender, EventArgs e)
        {
            cargar_barra();
            iniciar_sesion();
          
        }

        private void Text_Contra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cargar_barra();
                iniciar_sesion();
            }
        }

       
    }
}
