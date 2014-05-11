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

using System.Diagnostics;

using iTextSharp.text;

using iTextSharp.text.pdf;

using System.IO; 


namespace App_Ecoanimalia_Piura.Graficos
{
    public partial class F_ListarVoluntarios : Form
    {
        public F_ListarVoluntarios()
        {
            InitializeComponent();
        }
        
        #region metodos
        public void listar_voluntarios()
        {
            this.grilla_listado.DataSource = null;
            List<Usuario> lista = new NUsuario().N_listar_soloVoluntarios();
            this.grilla_listado.DataSource = lista;
        //   this.grilla_listado.Columns[3].Visible = false;
           // this.grilla_listado.Columns[4].Visible = false;
        }
        public void escribir_buscar()
        {
            List<Usuario> lista = new NUsuario().N_listar_soloVoluntarios();
            var filtro = from Usuario in lista
                         where Usuario.Serie.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Codigo.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Usuario.Nombres.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Apellidos.ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Usuario.Tipo.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Sexo.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Dni.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Usuario.Direccion.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Referencia.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Movistar.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Usuario.Claro.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Nextel.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Telefono.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Usuario.Email.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Facebook.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Ocupacion.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Estado.ToUpper().Contains(text_buscar.Text.ToUpper())
                         select Usuario;
            this.grilla_listado.DataSource = filtro.ToList<Usuario>();


        }

        #endregion


        
        private void text_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            escribir_buscar();
        }


        private void F_ListarVoluntarios_Load(object sender, EventArgs e)
        {
            listar_voluntarios();
        }

      
    }
}
