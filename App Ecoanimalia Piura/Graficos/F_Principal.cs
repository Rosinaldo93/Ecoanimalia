using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_Ecoanimalia_Piura.Graficos
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            F_Perfil p = new F_Perfil();
            p.Visible = true;
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            if (F_Login.perfil.Tipo.Equals("administrador"))
            {
                F_UsuariosVoluntarios op1 = new F_UsuariosVoluntarios();
                op1.Visible = true;
            }
            else
            {
                F_ListarVoluntarios lis = new F_ListarVoluntarios();
                lis.Visible = true;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_fichaTemporal_Click(object sender, EventArgs e)
        {
            F_FichaTemporal tem = new F_FichaTemporal();
            tem.Visible = true;
        }

        private void btn_fichaGeneral_Click(object sender, EventArgs e)
        {
            F_FichaGeneral general = new F_FichaGeneral();
            general.Visible = true;
        }

        private void btn_ficha_adopcion_Click(object sender, EventArgs e)
        {
            F_FichaAdopcion adopcion = new F_FichaAdopcion();
            adopcion.Visible = true;
        }
    }
}
