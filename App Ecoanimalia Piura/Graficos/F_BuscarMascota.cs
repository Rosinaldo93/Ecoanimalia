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
    public partial class F_BuscarMascota : Form
    {
        public F_BuscarMascota()
        {
            InitializeComponent();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda \n 1.- Seleccione una Mascota de la Lista\n 2.-Haga Click en aceptar para finalizar");
        
        }

        private void F_BuscarMascota_Load(object sender, EventArgs e)
        {

        }
    }
}
