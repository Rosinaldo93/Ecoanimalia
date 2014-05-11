using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App_Ecoanimalia_Piura.Logica;

namespace App_Ecoanimalia_Piura.Graficos
{
    public partial class F_VerDatosFichaTemporal : Form
    {
        public F_VerDatosFichaTemporal()
        {
            InitializeComponent();
        }
        public String validar_numero(int numero)
        {
            if (numero == null || numero == 0)
            {
                return "";
            }
            else
            {
                return "" + numero;
            }

        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void F_VerDatosFichaTemporal_Load(object sender, EventArgs e)
        {
            FichaTemporal FichaTempo = (FichaTemporal)F_FichaGeneral.fichatem;
            String movi = validar_numero(FichaTempo.Persona.Tel_mov);
            String claro = validar_numero(FichaTempo.Persona.Tel_claro);
            String casa = validar_numero(FichaTempo.Persona.Tel_casa);
            text_tipoMascota.Text = FichaTempo.Tipomascota.Descripcion;
            text_tamaño.Text = FichaTempo.Tamano;
            text_voluntario.Text = FichaTempo.Voluntario.Codigo + " DNI : " + FichaTempo.Voluntario.Dni + " - " + FichaTempo.Voluntario.Nombres + " " + FichaTempo.Voluntario.Apellidos;
            text_nombre.Text = FichaTempo.Persona.Nombre;
            text_apellido.Text = FichaTempo.Persona.Apellidos;
            text_dni.Text = FichaTempo.Persona.Dni;
            text_direccion.Text = FichaTempo.Persona.Direccion;
            text_sexo.Text = FichaTempo.Persona.Sexo;
            text_edad.Text = FichaTempo.Persona.Edad;
            text_estado.Text = FichaTempo.Estado;
            text_email.Text = FichaTempo.Persona.Email;
            text_facebook.Text = FichaTempo.Persona.Facebook;
            text_rpm.Text = FichaTempo.Persona.Rpm;
            text_movistar.Text = movi;
            text_claro.Text = claro;
            text_nextel.Text = FichaTempo.Persona.Tel_nex;
            text_telefono.Text = casa;
            text_observa.Text = FichaTempo.Observaciones;
            text_horario.Text = FichaTempo.Persona.Hor_disp;
        }
    }
}
