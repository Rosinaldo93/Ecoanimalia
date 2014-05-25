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
    public partial class F_BuscarMascota : Form
    {
        F_FichaAdopcion adopta;
        public F_BuscarMascota()
        {
            InitializeComponent();
        }

        public F_BuscarMascota(F_FichaAdopcion pointer)
        {
            this.adopta = pointer;
            InitializeComponent();
        }
        public void listar_mascotas()
        {
            List<Mascota> lista = new NMascota().N_Listar_Mascotas();
            this.grilla_mascota.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                int reglon = this.grilla_mascota.Rows.Add();
                this.grilla_mascota.Rows[reglon].Cells["SERIE"].Value = lista[i].Serie;
                this.grilla_mascota.Rows[reglon].Cells["ID_RESCATISTA"].Value = lista[i].Ser_usu.Serie;
                this.grilla_mascota.Rows[reglon].Cells["SERIE_FORMATO"].Value = "00-00" + lista[i].Serie;
                this.grilla_mascota.Rows[reglon].Cells["COD_RESCATISTA"].Value = lista[i].Ser_usu.Codigo;
                this.grilla_mascota.Rows[reglon].Cells["RESCATISTA"].Value = lista[i].Ser_usu.Nombres + " " + lista[i].Ser_usu.Apellidos;
                if ((!String.IsNullOrEmpty(lista[i].Fic_tem.Id.ToString())) || (lista[i].Fic_tem.Id != 0))
                {
                    this.grilla_mascota.Rows[reglon].Cells["TEMPORAL"].Value = lista[i].Fic_tem.Id;
                    
                }
                else
                {
                    this.grilla_mascota.Rows[reglon].Cells["TEMPORAL"].Value = "";

                }
                this.grilla_mascota.Rows[reglon].Cells["FECHA_INGRE"].Value = lista[i].Fecha_ingreso.ToShortDateString();
                this.grilla_mascota.Rows[reglon].Cells["ID_TIPO"].Value = lista[i].Tipomascota.Id;
                this.grilla_mascota.Rows[reglon].Cells["TIPO"].Value = lista[i].Tipomascota.Descripcion;
                this.grilla_mascota.Rows[reglon].Cells["TAMANO"].Value = lista[i].Tamano;
                this.grilla_mascota.Rows[reglon].Cells["ESTADO"].Value = lista[i].Estado;
                this.grilla_mascota.Rows[reglon].Cells["NOMBRE"].Value = lista[i].Nombre;
                this.grilla_mascota.Rows[reglon].Cells["RAZA"].Value = lista[i].Raza;
                this.grilla_mascota.Rows[reglon].Cells["SEXO"].Value = lista[i].Sexo;
                this.grilla_mascota.Rows[reglon].Cells["COLOR"].Value = lista[i].Color;
                this.grilla_mascota.Rows[reglon].Cells["EDAD"].Value = lista[i].Edad;
                this.grilla_mascota.Rows[reglon].Cells["ESTERILIZADO"].Value = lista[i].Esterilizado;

            }
        }


        public void escribir_buscar()
        {
            List<Mascota> lista = new NMascota().N_Listar_Mascotas();
            var filtro = from Mascota in lista
                         where Mascota.Nombre.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || ("00-00" + Mascota.Serie.ToString().ToUpper()).Contains(text_buscar.Text.ToUpper()) ||
                         Mascota.Ser_usu.Codigo.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Mascota.Tipomascota.Descripcion.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Mascota.Tamano.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Mascota.Estado.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Mascota.Raza.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Mascota.Sexo.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Mascota.Color.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Mascota.Edad.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Mascota.Esterilizado.ToString().ToUpper().Contains(text_buscar.Text.ToUpper())
                         select Mascota;
            lista = filtro.ToList<Mascota>();
            
            this.grilla_mascota.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                int reglon = this.grilla_mascota.Rows.Add();
                this.grilla_mascota.Rows[reglon].Cells["SERIE"].Value = lista[i].Serie;
                this.grilla_mascota.Rows[reglon].Cells["ID_RESCATISTA"].Value = lista[i].Ser_usu.Serie;
                this.grilla_mascota.Rows[reglon].Cells["SERIE_FORMATO"].Value = "00-00" + lista[i].Serie;
                this.grilla_mascota.Rows[reglon].Cells["COD_RESCATISTA"].Value = lista[i].Ser_usu.Codigo;
                this.grilla_mascota.Rows[reglon].Cells["RESCATISTA"].Value = lista[i].Ser_usu.Nombres + " " + lista[i].Ser_usu.Apellidos;
                if ((!String.IsNullOrEmpty(lista[i].Fic_tem.Id.ToString())) || (lista[i].Fic_tem.Id != 0))
                {
                    this.grilla_mascota.Rows[reglon].Cells["TEMPORAL"].Value = lista[i].Fic_tem.Id;

                }
                else
                {
                    this.grilla_mascota.Rows[reglon].Cells["TEMPORAL"].Value = "";

                }
                this.grilla_mascota.Rows[reglon].Cells["FECHA_INGRE"].Value = lista[i].Fecha_ingreso.ToShortDateString();
                this.grilla_mascota.Rows[reglon].Cells["ID_TIPO"].Value = lista[i].Tipomascota.Id;
                this.grilla_mascota.Rows[reglon].Cells["TIPO"].Value = lista[i].Tipomascota.Descripcion;
                this.grilla_mascota.Rows[reglon].Cells["TAMANO"].Value = lista[i].Tamano;
                this.grilla_mascota.Rows[reglon].Cells["ESTADO"].Value = lista[i].Estado;
                this.grilla_mascota.Rows[reglon].Cells["NOMBRE"].Value = lista[i].Nombre;
                this.grilla_mascota.Rows[reglon].Cells["RAZA"].Value = lista[i].Raza;
                this.grilla_mascota.Rows[reglon].Cells["SEXO"].Value = lista[i].Sexo;
                this.grilla_mascota.Rows[reglon].Cells["COLOR"].Value = lista[i].Color;
                this.grilla_mascota.Rows[reglon].Cells["EDAD"].Value = lista[i].Edad;
                this.grilla_mascota.Rows[reglon].Cells["ESTERILIZADO"].Value = lista[i].Esterilizado;

            }


        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda \n 1.- Seleccione una Mascota de la Lista\n 2.-Haga Click en aceptar para finalizar");
        
        }

        private void F_BuscarMascota_Load(object sender, EventArgs e)
        {
            listar_mascotas();
        }

        private void text_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            escribir_buscar();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int id = Convert.ToInt32(this.grilla_mascota.CurrentRow.Cells[0].Value.ToString());
                adopta.ver_mascota(id);
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
