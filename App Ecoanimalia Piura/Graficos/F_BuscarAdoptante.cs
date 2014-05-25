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
    public partial class F_BuscarAdoptante : Form
    {
        F_FichaAdopcion ficha;
        List<Persona> lista = new NPersona().N_listar_persona();
        public F_BuscarAdoptante()
        {
            InitializeComponent();
        }
        public F_BuscarAdoptante(F_FichaAdopcion pointer)
        {
            this.ficha = pointer;
            InitializeComponent();
        }


        public void listar_persona()
        {
            List<Persona> lista = new NPersona().N_listar_persona();
            
            this.grilla_adoptantes.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                int reglon = this.grilla_adoptantes.Rows.Add();
                this.grilla_adoptantes.Rows[reglon].Cells["ID_Persona"].Value = lista[i].Id.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Nombre"].Value = lista[i].Nombre.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Apellidos"].Value = lista[i].Apellidos.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Dni"].Value = lista[i].Dni.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Direccion"].Value = lista[i].Direccion.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Sexo"].Value = lista[i].Sexo.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Edad"].Value = lista[i].Edad.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Email"].Value = lista[i].Email.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Facebook"].Value = lista[i].Facebook.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Rpm"].Value = lista[i].Rpm.ToString();
                if ((lista[i].Tel_mov == null) || (lista[i].Tel_mov == 0))
                {
                    this.grilla_adoptantes.Rows[reglon].Cells["Movistar"].Value = "";

                }
                else
                {
                    this.grilla_adoptantes.Rows[reglon].Cells["Movistar"].Value = lista[i].Tel_mov.ToString();

                }
                if ((lista[i].Tel_claro == null) || (lista[i].Tel_claro == 0))
                {
                    this.grilla_adoptantes.Rows[reglon].Cells["Claro"].Value = "";

                }
                else
                {
                    this.grilla_adoptantes.Rows[reglon].Cells["Claro"].Value = lista[i].Tel_claro.ToString();

                }
                this.grilla_adoptantes.Rows[reglon].Cells["Nextel"].Value = lista[i].Tel_nex.ToString();
                if ((lista[i].Tel_casa == 0) || (lista[i].Tel_casa == null))
                {
                    this.grilla_adoptantes.Rows[reglon].Cells["Telefono"].Value = "";

                }
                else
                {
                    this.grilla_adoptantes.Rows[reglon].Cells["Telefono"].Value = lista[i].Tel_casa.ToString();

                }
                this.grilla_adoptantes.Rows[reglon].Cells["Horario_disponible"].Value = lista[i].Hor_disp.ToString();
                }

        }

        public void escribir_buscar()
        {
            List<Persona> lista = new NPersona().N_listar_persona();
            var filtro = from Persona in lista
                         where Persona.Nombre.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Persona.Apellidos.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Persona.Sexo.ToUpper().Contains(text_buscar.Text.ToUpper()) || Persona.Dni.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Persona.Direccion.ToUpper().Contains(text_buscar.Text.ToUpper()) || Persona.Edad.ToUpper().Contains(text_buscar.Text.ToUpper()) || Persona.Tel_mov.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Persona.Tel_claro.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Persona.Tel_nex.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Persona.Rpm.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Persona.Email.ToUpper().Contains(text_buscar.Text.ToUpper()) || Persona.Facebook.ToUpper().Contains(text_buscar.Text.ToUpper()) || Persona.Hor_disp.ToUpper().Contains(text_buscar.Text.ToUpper()) || Persona.Tel_casa.ToString().ToUpper().Contains(text_buscar.Text.ToUpper())
                         select Persona;
            lista = filtro.ToList<Persona>();
            this.grilla_adoptantes.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                int reglon = this.grilla_adoptantes.Rows.Add();
                this.grilla_adoptantes.Rows[reglon].Cells["ID_Persona"].Value = lista[i].Id.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Nombre"].Value = lista[i].Nombre.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Apellidos"].Value = lista[i].Apellidos.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Dni"].Value = lista[i].Dni.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Direccion"].Value = lista[i].Direccion.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Sexo"].Value = lista[i].Sexo.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Edad"].Value = lista[i].Edad.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Email"].Value = lista[i].Email.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Facebook"].Value = lista[i].Facebook.ToString();
                this.grilla_adoptantes.Rows[reglon].Cells["Rpm"].Value = lista[i].Rpm.ToString();
                if ((lista[i].Tel_mov == null) || (lista[i].Tel_mov == 0))
                {
                    this.grilla_adoptantes.Rows[reglon].Cells["Movistar"].Value = "";

                }
                else
                {
                    this.grilla_adoptantes.Rows[reglon].Cells["Movistar"].Value = lista[i].Tel_mov.ToString();

                }
                if ((lista[i].Tel_claro == null) || (lista[i].Tel_claro == 0))
                {
                    this.grilla_adoptantes.Rows[reglon].Cells["Claro"].Value = "";

                }
                else
                {
                    this.grilla_adoptantes.Rows[reglon].Cells["Claro"].Value = lista[i].Tel_claro.ToString();

                }
                this.grilla_adoptantes.Rows[reglon].Cells["Nextel"].Value = lista[i].Tel_nex.ToString();
                if ((lista[i].Tel_casa == 0) || (lista[i].Tel_casa == null))
                {
                    this.grilla_adoptantes.Rows[reglon].Cells["Telefono"].Value = "";

                }
                else
                {
                    this.grilla_adoptantes.Rows[reglon].Cells["Telefono"].Value = lista[i].Tel_casa.ToString();

                }
                this.grilla_adoptantes.Rows[reglon].Cells["Horario_disponible"].Value = lista[i].Hor_disp.ToString();
            }


        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda \n 1.- Seleccione el Adoptante en la Tabla\n 2.-Haga Click en aceptar para finalizar");
        }

        private void text_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            escribir_buscar();
        }

        private void F_BuscarAdoptante_Load(object sender, EventArgs e)
        {
            listar_persona();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.grilla_adoptantes.CurrentRow.Cells[0].Value.ToString());
                ficha.ver_adoptante(id);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No a Seleccionado al Adoptante");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
