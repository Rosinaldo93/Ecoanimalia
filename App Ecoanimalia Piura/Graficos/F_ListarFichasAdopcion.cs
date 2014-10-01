using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Negocio;

namespace App_Ecoanimalia_Piura.Graficos
{
    public partial class F_ListarFichasAdopcion : Form
    {
        F_FichaAdopcion ficha;
        public F_ListarFichasAdopcion()
        {
            InitializeComponent();
        }

        public F_ListarFichasAdopcion(F_FichaAdopcion pointer)
        {
            this.ficha = pointer;
            InitializeComponent();
        }
        public void listado_fechaAdopcion()
        {
            List<FichaAdopcion> lista = new NFichaAdopcion().N_ListaFichaAdopcion();
            this.grilla_fichaAdopcion.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                int reglon = this.grilla_fichaAdopcion.Rows.Add();
                this.grilla_fichaAdopcion.Rows[reglon].Cells["ID"].Value = lista[i].Id;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["ID_PERSONA"].Value = lista[i].Persona.Id;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["SERIE"].Value = lista[i].Usuario.Serie;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["Codigo_usuario"].Value = lista[i].Usuario.Codigo;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["Voluntario"].Value = lista[i].Usuario.Nombres + " " + lista[i].Usuario.Apellidos;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["DNI_ADOPTANTE"].Value = lista[i].Persona.Dni;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["Adoptante"].Value = lista[i].Persona.Nombre + " " + lista[i].Persona.Apellidos;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["Relacion"].Value = lista[i].Rel_res;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["Observaciones"].Value = lista[i].Observaciones;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["Fecha"].Value = lista[i].Fec_adp.ToShortDateString();

            }
        }



        private void F_ListarFichasAdopcion_Load(object sender, EventArgs e)
        {
            listado_fechaAdopcion();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.grilla_fichaAdopcion.CurrentRow.Cells[0].Value.ToString());
                ficha.ver_DatosFichaAdopcion(id);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No a Seleccionado la Ficha");
            }
        }

        private void text_buscar_fichaAdopcion_KeyUp(object sender, KeyEventArgs e)
        {
            List<FichaAdopcion> lista = new NFichaAdopcion().N_ListaFichaAdopcion();
            var filtro = from FichaAdopcion in lista
                         where FichaAdopcion.Usuario.Serie.ToString().ToUpper().Contains(text_buscar_fichaAdopcion.Text.ToUpper()) || FichaAdopcion.Usuario.Codigo.ToString().ToUpper().Contains(text_buscar_fichaAdopcion.Text.ToUpper()) ||
                         FichaAdopcion.Usuario.Nombres.ToString().ToUpper().Contains(text_buscar_fichaAdopcion.Text.ToUpper()) || FichaAdopcion.Usuario.Apellidos.ToString().ToUpper().Contains(text_buscar_fichaAdopcion.Text.ToUpper()) ||
                         FichaAdopcion.Persona.Nombre.ToString().ToUpper().Contains(text_buscar_fichaAdopcion.Text.ToUpper()) || FichaAdopcion.Persona.Apellidos.ToString().ToUpper().Contains(text_buscar_fichaAdopcion.Text.ToUpper()) ||
                         FichaAdopcion.Persona.Dni.ToString().ToUpper().Contains(text_buscar_fichaAdopcion.Text.ToUpper()) || FichaAdopcion.Rel_res.ToString().ToUpper().Contains(text_buscar_fichaAdopcion.Text.ToUpper()) ||
                         FichaAdopcion.Observaciones.ToString().ToUpper().Contains(text_buscar_fichaAdopcion.Text.ToUpper()) || FichaAdopcion.Fec_adp.ToShortDateString().ToUpper().Contains(text_buscar_fichaAdopcion.Text.ToUpper())
                         select FichaAdopcion;
            lista = filtro.ToList<FichaAdopcion>();
            this.grilla_fichaAdopcion.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                int reglon = this.grilla_fichaAdopcion.Rows.Add();
                this.grilla_fichaAdopcion.Rows[reglon].Cells["ID"].Value = lista[i].Id;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["ID_PERSONA"].Value = lista[i].Persona.Id;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["SERIE"].Value = lista[i].Usuario.Serie;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["Codigo_usuario"].Value = lista[i].Usuario.Codigo;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["Voluntario"].Value = lista[i].Usuario.Nombres + " " + lista[i].Usuario.Apellidos;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["DNI_ADOPTANTE"].Value = lista[i].Persona.Dni;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["Adoptante"].Value = lista[i].Persona.Nombre + " " + lista[i].Persona.Apellidos;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["Relacion"].Value = lista[i].Rel_res;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["Observaciones"].Value = lista[i].Observaciones;
                this.grilla_fichaAdopcion.Rows[reglon].Cells["Fecha"].Value = lista[i].Fec_adp.ToShortDateString();

            }
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda \n 1.- Seleccione un de la Lista\n 2.-Haga Click en aceptar para finalizar");
        }

        



    }
}
