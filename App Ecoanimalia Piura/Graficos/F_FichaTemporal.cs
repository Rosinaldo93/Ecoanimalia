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
    public partial class F_FichaTemporal : Form
    {
        public F_FichaTemporal()
        {
            InitializeComponent();
        }
        public void llenar_combo_usuarios()
        {
            combo_voluntario.Items.Clear();
            combo_voluntario.DataSource = new NUsuario().N_listar_usuarios();
            combo_voluntario.SelectedIndex = 0;
        }
        public void limpiar_cajas()
        {
            lb_id.Text = "";
            lb_idPersona.Text = "";
            text_claro.Clear();
            text_direccion.Clear();
            text_dni.Clear();
            text_edad.Clear();
            text_email.Clear();
            text_facebook.Clear();
            text_horario.Clear();
            text_movistar.Clear();
            text_nextel.Clear();
            text_nombre.Clear();
            text_observa.Clear();
            text_rpm.Clear();
            text_telefono.Clear();
            text_apellido.Clear();
            radio_activo.Checked = true;
            radio_masculino.Checked = true;
            combo_tipoMascota.SelectedIndex = 0;
            combo_Tamaño.SelectedIndex = 0;

        }
        public void llenar_tiposMascotas()
        {
            combo_tipoMascota.DataSource = null;
            combo_tipoMascota.DataSource = new NTipoMascota().listar_tipoM();

        }
        public void llenar_tamañosMascotas()
        {
            combo_Tamaño.Items.Clear();
            combo_Tamaño.Items.Add("Pequeño");
            combo_Tamaño.Items.Add("Mediano");
            combo_Tamaño.Items.Add("Grande");
            combo_Tamaño.SelectedIndex = 0;
        }
        public void listar_fichas()
        {
            List<FichaTemporal> lista = new NFichaTemporal().N_Listar_FichaTemporal();
            this.grilla_listado.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                int reglon = this.grilla_listado.Rows.Add();
                this.grilla_listado.Rows[reglon].Cells["ID"].Value = lista[i].Id.ToString();
                this.grilla_listado.Rows[reglon].Cells["Tipo_Mascota"].Value = lista[i].Tipomascota.Descripcion.ToString();
                this.grilla_listado.Rows[reglon].Cells["Voluntario"].Value = lista[i].Voluntario.ToString();
                this.grilla_listado.Rows[reglon].Cells["Tamaño"].Value = lista[i].Tamano.ToString();
                this.grilla_listado.Rows[reglon].Cells["ID_Persona"].Value = lista[i].Persona.Id.ToString();
                this.grilla_listado.Rows[reglon].Cells["Nombre"].Value = lista[i].Persona.Nombre.ToString();
                this.grilla_listado.Rows[reglon].Cells["Apellidos"].Value = lista[i].Persona.Apellidos.ToString();
                this.grilla_listado.Rows[reglon].Cells["Dni"].Value = lista[i].Persona.Dni.ToString();
                this.grilla_listado.Rows[reglon].Cells["Direccion"].Value = lista[i].Persona.Direccion.ToString();
                this.grilla_listado.Rows[reglon].Cells["Sexo"].Value = lista[i].Persona.Sexo.ToString();
                this.grilla_listado.Rows[reglon].Cells["Edad"].Value = lista[i].Persona.Edad.ToString();
                this.grilla_listado.Rows[reglon].Cells["Email"].Value = lista[i].Persona.Email.ToString();
                this.grilla_listado.Rows[reglon].Cells["Facebook"].Value = lista[i].Persona.Facebook.ToString();
                this.grilla_listado.Rows[reglon].Cells["Rpm"].Value = lista[i].Persona.Rpm.ToString();
                if ((lista[i].Persona.Tel_mov == null) || (lista[i].Persona.Tel_mov == 0))
                {
                    this.grilla_listado.Rows[reglon].Cells["Movistar"].Value = "";

                }
                else
                {
                    this.grilla_listado.Rows[reglon].Cells["Movistar"].Value = lista[i].Persona.Tel_mov.ToString();

                }
                if ((lista[i].Persona.Tel_claro == null) || (lista[i].Persona.Tel_claro == 0))
                {
                    this.grilla_listado.Rows[reglon].Cells["Claro"].Value = "";

                }
                else
                {
                    this.grilla_listado.Rows[reglon].Cells["Claro"].Value = lista[i].Persona.Tel_claro.ToString();

                }
                this.grilla_listado.Rows[reglon].Cells["Nextel"].Value = lista[i].Persona.Tel_nex.ToString();
                if ((lista[i].Persona.Tel_casa == 0) || (lista[i].Persona.Tel_casa == null))
                {
                    this.grilla_listado.Rows[reglon].Cells["Telefono"].Value = "";

                }
                else
                {
                    this.grilla_listado.Rows[reglon].Cells["Telefono"].Value = lista[i].Persona.Tel_casa.ToString();

                }
                this.grilla_listado.Rows[reglon].Cells["Horario_disponible"].Value = lista[i].Persona.Hor_disp.ToString();
                this.grilla_listado.Rows[reglon].Cells["Estado"].Value = lista[i].Estado.ToString();
                this.grilla_listado.Rows[reglon].Cells["Observaciones"].Value = lista[i].Observaciones.ToString();


            }

        }


        private void F_FichaTemporal_Load(object sender, EventArgs e)
        {
            lb_id.Visible = false;
            lb_idPersona.Visible = false;
            llenar_tiposMascotas();
            llenar_tamañosMascotas();
            radio_masculino.Checked = true;
            radio_activo.Checked = true;
            listar_fichas();
            llenar_combo_usuarios();
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
            String observa = "";
            String estado = "";

            TipoMascota tipo = (TipoMascota)combo_tipoMascota.SelectedItem;
            Usuario voluntario = (Usuario)combo_voluntario.SelectedItem;
            String tamaño = combo_Tamaño.SelectedItem.ToString();

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
            if (radio_activo.Checked == true)
            {
                estado = "Activo";
            }
            else
            {
                estado = "Inactivo";
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
            if (!String.IsNullOrEmpty(text_observa.Text))
            {
                observa = text_observa.Text;
            }
            if (band1 == true || band2 == true || band3 == true)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                int confir1 = new NFichaTemporal().registrar_temporarl(tipo, tamaño, nombre, apellidos, dni, direccion, sexo, edad, email, facebook, rpm, movistar, claro, nextel, telefono, horario, observa, estado, voluntario);
                if (confir1 == 0)
                {
                    MessageBox.Show("Error Al Registrar Por favor intente nuevamente");

                }
                else
                {
                    MessageBox.Show("Registrado Correctamente");
                    limpiar_cajas();
                    listar_fichas();
                }
            }


        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiar_cajas();
        }

        private void grilla_listado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar_cajas();
            lb_id.Text = this.grilla_listado.CurrentRow.Cells[0].Value.ToString();
            String tipo = this.grilla_listado.CurrentRow.Cells[1].Value.ToString();
            for (int i = 0; i < combo_tipoMascota.Items.Count; i++)
            {
                TipoMascota ti = (TipoMascota)combo_tipoMascota.Items[i];
                if (tipo.Equals(ti.Descripcion))
                {
                    combo_tipoMascota.SelectedIndex = i;
                    break;
                }
            }
            String volu = this.grilla_listado.CurrentRow.Cells[2].Value.ToString();

            for (int i = 0; i < combo_voluntario.Items.Count; i++)
            {
                Usuario usu = (Usuario)combo_voluntario.Items[i];
                String conta = "DNI: " + usu.Dni + " - " + usu.Nombres + " " + usu.Apellidos;
                if (conta.Equals(volu))
                {
                    combo_voluntario.SelectedIndex = i;

                    break;
                }
            }


            String tam = this.grilla_listado.CurrentRow.Cells[3].Value.ToString();
            for (int i = 0; i < combo_Tamaño.Items.Count; i++)
            {
                String combo = combo_Tamaño.Items[i].ToString();
                if (tam.Equals(combo))
                {
                    combo_Tamaño.SelectedIndex = i;
                    break;
                }
            }
            lb_idPersona.Text = this.grilla_listado.CurrentRow.Cells[4].Value.ToString();
            text_nombre.Text = this.grilla_listado.CurrentRow.Cells[5].Value.ToString();
            text_apellido.Text = this.grilla_listado.CurrentRow.Cells[6].Value.ToString();
            text_dni.Text = this.grilla_listado.CurrentRow.Cells[7].Value.ToString();
            text_direccion.Text = this.grilla_listado.CurrentRow.Cells[8].Value.ToString();
            String sexo = this.grilla_listado.CurrentRow.Cells[9].Value.ToString();
            if (sexo.Equals("Masculino"))
            {
                radio_masculino.Checked = true;
            }
            else
            {
                radio_femenino.Checked = true;
            }
            text_edad.Text = this.grilla_listado.CurrentRow.Cells[10].Value.ToString();
            text_email.Text = this.grilla_listado.CurrentRow.Cells[11].Value.ToString();
            text_facebook.Text = this.grilla_listado.CurrentRow.Cells[12].Value.ToString();
            text_rpm.Text = this.grilla_listado.CurrentRow.Cells[13].Value.ToString();
            text_movistar.Text = this.grilla_listado.CurrentRow.Cells[14].Value.ToString();
            text_claro.Text = this.grilla_listado.CurrentRow.Cells[15].Value.ToString();
            text_nextel.Text = this.grilla_listado.CurrentRow.Cells[16].Value.ToString();
            text_telefono.Text = this.grilla_listado.CurrentRow.Cells[17].Value.ToString();
            text_horario.Text = this.grilla_listado.CurrentRow.Cells[18].Value.ToString();
            String estado = this.grilla_listado.CurrentRow.Cells[19].Value.ToString();
            if (estado.Equals("Activo"))
            {
                radio_activo.Checked = true;
            }
            else
            {
                radio_inactivo.Checked = true;
            }
            text_observa.Text = this.grilla_listado.CurrentRow.Cells[20].Value.ToString();


        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Boolean band1 = false, band2 = false, band3 = false;
            String mensaje = "Por Favor Complete los campos obligatorios : \n";
            int id_ficha = int.Parse(lb_id.Text);
            int id_per = int.Parse(lb_idPersona.Text);
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
            String observa = "";
            String estado = "";

            TipoMascota tipo = (TipoMascota)combo_tipoMascota.SelectedItem;
            String tamaño = combo_Tamaño.SelectedItem.ToString();
            Usuario voluntario = (Usuario)combo_voluntario.SelectedItem;
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
            if (radio_activo.Checked == true)
            {
                estado = "Activo";
            }
            else
            {
                estado = "Inactivo";
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
            if (!String.IsNullOrEmpty(text_observa.Text))
            {
                observa = text_observa.Text;
            }
            if (band1 == true || band2 == true || band3 == true)
            {
                MessageBox.Show(mensaje);
            }
            else
            {

                int confir1 = new NFichaTemporal().N_Modificar_Ficha_Temp(tipo, tamaño, nombre, apellidos, dni, direccion, sexo, edad, email, facebook, rpm, movistar, claro, nextel, telefono, horario, observa, estado, id_ficha, id_per, voluntario);
                if (confir1 == 0)
                {
                    MessageBox.Show("Error Al Modificar Por favor intente nuevamente");

                }
                else
                {
                    MessageBox.Show("Modificado Correctamente");
                    limpiar_cajas();
                    listar_fichas();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int id_temporal = int.Parse(lb_id.Text);

            if (MessageBox.Show("Seguro que dese Eliminar?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int band = new NFichaTemporal().N_eliminar_temporal(id_temporal);
                if (band == 0)
                {
                    MessageBox.Show("Error Al Eliminar Por favor intente nuevamente");
                }
                else
                {
                    MessageBox.Show("Eliminado Correctamente");

                    limpiar_cajas();
                    listar_fichas();
                }
            }
        }
    }
}
