﻿using System;
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
    public partial class F_FichaAdopcion : Form
    {
        public F_FichaAdopcion()
        {
            InitializeComponent();
        }
        public void llenar_combo_personas()
        {
            combo_persona.DataSource = null;
            combo_persona.DataSource = new NPersona().N_listar_persona();
            combo_persona.SelectedIndex = 0;

        }
        public void llenar_combo_voluntarios()
        {
            combo_voluntarios.DataSource = null;
            combo_voluntarios.DataSource = new NUsuario().N_listar_usuarios();
            combo_voluntarios.SelectedIndex = 0;

        }
        public void llenar_combo_mascota()
        {
            combo_mascota.DataSource = null;
            combo_mascota.DataSource = new NMascota().N_Listar_Mascotas();
            combo_mascota.SelectedIndex = 0;

        }

        private void F_FichaAdopcion_Load(object sender, EventArgs e)
        {
            btn_nuevo_mascota.Enabled = false;
            btn_agregar_mascota.Enabled = false;
            btn_eliminar_mascota.Enabled = false;
            btn_modificar_mascota.Enabled = false;
            btn_cancelar_mascota.Enabled = false;
            btn_registrar_ficha.Enabled = false;
            btn_editar_ficha.Enabled = false;
            btn_eliminar_ficha.Enabled = false;
            btn_cancelar_ficha.Enabled = false;
            btn_terminar_ficha.Enabled = false;

            llenar_combo_personas();
            llenar_combo_voluntarios();
            llenar_combo_mascota();
        }
        public void ver_adoptante(int id)
        {
            for (int i = 0; i < combo_persona.Items.Count; i++)
            {
                Persona per = (Persona)combo_persona.Items[i];

                if (per.Id == id)
                {
                    combo_persona.SelectedIndex = i;
                    break;
                }
            }

        }
        public void ver_DatosFichaAdopcion(int id)
        {
            Console.Write("id es  : " + id);
            lb_id_ficha.Text = ""+id;
            FichaAdopcion ficha = new NFichaAdopcion().D_BuscarFichaAdopcionxID(id);
            Usuario usuario = ficha.Usuario;
            Persona persona = ficha.Persona;
            for (int i = 0; i < combo_persona.Items.Count; i++)
            {
                Persona per = (Persona)combo_persona.Items[i];

                if (per.Id == persona.Id)
                {
                    combo_persona.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < combo_voluntarios.Items.Count; i++)
            {
                Usuario usu = (Usuario)combo_voluntarios.Items[i];

                if (usu.Serie == usuario.Serie)
                {
                    combo_voluntarios.SelectedIndex = i;
                    break;
                }
            }
            text_relacion.Text = ficha.Rel_res;
            text_observacion_ficha.Text = ficha.Observaciones;
            fech_adopcion.Text = ficha.Fec_adp.ToString();
            btn_editar_ficha.Enabled = true;




        }
        public void ver_mascota(int serie)
        {
            for (int i = 0; i < combo_mascota.Items.Count; i++)
            {
                Mascota masc = (Mascota)combo_mascota.Items[i];

                if (masc.Serie == serie)
                {
                    combo_mascota.SelectedIndex = i;
                    break;
                }
            }

        }


        public void actualizar_lista_adoptante()
        {
            llenar_combo_personas();
        }

        private void btn_buscar_persona_Click(object sender, EventArgs e)
        {
            F_BuscarAdoptante buscar = new F_BuscarAdoptante(this);
            buscar.ShowDialog();

        }

        private void btn_buscar_voluntario_Click(object sender, EventArgs e)
        {
            String opcion = Inputbox.Show("Busqueda del Voluntario", "Ingrese Codigo del Voluntario ", FormStartPosition.CenterScreen);
            if (!String.IsNullOrEmpty(opcion))
            {
                Boolean val = false;
                for (int i = 0; i < combo_voluntarios.Items.Count; i++)
                {
                    Usuario usu = (Usuario)combo_voluntarios.Items[i];

                    if (usu.Codigo.Equals(opcion))
                    {
                        combo_voluntarios.SelectedIndex = i;
                        MessageBox.Show("Voluntario Encontrado");
                        val = true;
                        break;
                    }
                }
                if (val == false)
                {
                    MessageBox.Show("No se encontro el Voluntario");
                }
            }

        }
        public static class Inputbox
        {

            // Conserva esta cabecera
            //  Emperorxdevil 2007

            static Form f;
            static Label l;
            static TextBox t; // Elementos necesarios
            static Button b1;
            static Button b2;
            static string Valor;

            /// <summary>
            /// Objeto Estático que muestra un pequeño diálogo para introducir datos
            /// </summary>
            /// <param name="title">Título del diálogo</param>
            /// <param name="prompt">Texto de información</param>
            /// <param name="posicion">Posición de inicio</param>
            /// <returns>Devuelve la escrito en la caja de texto como string</returns>
            public static string Show(string title, string prompt, FormStartPosition posicion)
            {

                f = new Form();
                f.Text = title;
                f.ShowIcon = false;
                f.Icon = null;
                f.KeyPreview = true;
                f.ShowInTaskbar = false;
                f.MaximizeBox = false;
                f.MinimizeBox = false;
                f.Width = 200;
                f.FormBorderStyle = FormBorderStyle.FixedDialog;
                f.Height = 120;
                f.StartPosition = posicion;
                f.KeyPress += new KeyPressEventHandler(f_KeyPress);

                l = new Label();
                l.AutoSize = true;
                l.Text = prompt;


                t = new TextBox();
                t.Width = 182;
                t.Top = 40;

                b1 = new Button();
                b1.Text = "Aceptar";
                b1.Click += new EventHandler(b1_Click);


                b2 = new Button();
                b2.Text = "Cancelar";
                b2.Click += new EventHandler(b2_Click);

                f.Controls.Add(l);
                f.Controls.Add(t);
                f.Controls.Add(b1);
                f.Controls.Add(b2);

                l.Top = 10;
                t.Left = 5;
                t.Top = 30;

                b1.Left = 5;
                b1.Top = 60;

                b2.Left = 112;
                b2.Top = 60;

                f.ShowDialog();
                return (Valor);
            }

            static void f_KeyPress(object sender, KeyPressEventArgs e)
            {
                switch (Convert.ToChar(e.KeyChar))
                {

                    case ('\r'):
                        Acepta();
                        break; ;

                    case (''):
                        Cancela();
                        break; ;
                }
            }
            static void b2_Click(object sender, EventArgs e)
            {
                Cancela();
            }
            static void b1_Click(object sender, EventArgs e)
            {
                Acepta();
            }
            private static string Val
            {

                get { return (Valor); }
                set { Valor = value; }
            }
            private static void Acepta()
            {
                Val = t.Text;
                f.Dispose();
            }
            private static void Cancela()
            {
                Val = null;
                f.Dispose();
            }


        }

        private void btn_nueva_persona_Click(object sender, EventArgs e)
        {
            F_RegistrarPersona r = new F_RegistrarPersona(this);
            r.ShowDialog();
        }

        private void btn_buscar_mascota_Click(object sender, EventArgs e)
        {
            F_BuscarMascota ma = new F_BuscarMascota(this);
            ma.ShowDialog();
        }

        private void btn_registrar_ficha_Click(object sender, EventArgs e)
        {

            String relacion = "";
            String observa_ficha = "";
            Usuario voluntario = (Usuario)combo_voluntarios.SelectedItem;
            Persona persona = (Persona)combo_persona.SelectedItem;

            if (!String.IsNullOrEmpty(text_relacion.Text))
            {
                relacion = text_relacion.Text;
            }
            if (!String.IsNullOrEmpty(text_observacion_ficha.Text))
            {
                observa_ficha = text_observacion_ficha.Text;
            }

            DateTime fecha_adopcion = Convert.ToDateTime(fech_adopcion.Text);
            int respuesta = new NFichaAdopcion().N_asignar_adopcion(persona, voluntario, relacion, observa_ficha, fecha_adopcion);
            if (respuesta == 0)
            {
                MessageBox.Show("Error Al Registrar Por favor intente nuevamente");

            }
            else
            {
                MessageBox.Show("Registrado Correctamente");
                int id_ficha_adopcion = new NFichaAdopcion().N_maxima_FichaAdopcion();
                lb_id_ficha.Text = "" + id_ficha_adopcion;
                inhabilitar_cajas_ficha();
                btn_agregar_mascota.Enabled = true;
                habilitar_cajas_mascota();
                limpiar_cajas_mascota();
                btn_registrar_ficha.Enabled = false;
                btn_nueva_ficha.Enabled = false;
                btn_listar_ficha.Enabled = false;
                btn_nuevo_mascota.Enabled = true;
            }

        }
        public void habilitar_cajas_ficha()
        {
            combo_persona.Enabled = true;
            combo_voluntarios.Enabled = true;
            text_relacion.Enabled = true;
            text_observacion_ficha.Enabled = true;
            fech_adopcion.Enabled = true;
            btn_nueva_persona.Enabled = true;
            btn_buscar_persona.Enabled = true;
            btn_buscar_voluntario.Enabled = true;
        }
        public void inhabilitar_cajas_ficha()
        {
            combo_persona.Enabled = false;
            combo_voluntarios.Enabled = false;
            text_relacion.Enabled = false;
            text_observacion_ficha.Enabled = false;
            fech_adopcion.Enabled = false;
            btn_nueva_persona.Enabled = false;
            btn_buscar_persona.Enabled = false;
            btn_buscar_voluntario.Enabled = false;
        }
        public void limpiar_cajas_ficha()
        {
            combo_persona.SelectedIndex = 0;
            combo_voluntarios.SelectedIndex = 0;
            text_relacion.Text = "";
            text_observacion_ficha.Text = "";
            fech_adopcion.Value = DateTime.Now;
        }
        public void limpiar_cajas_mascota()
        {
            combo_mascota.SelectedIndex = 0;
            text_observacion_mascota.Text = "";
            text_nombre_adoptarse.Text = "";
            radio_inactivo.Checked = true;
            text_observacion_mascota.Text = "";
        }
        public void inhabilitar_cajas_mascota()
        {
            combo_mascota.Enabled = false;
            text_observacion_mascota.Enabled = false;
            text_nombre_adoptarse.Enabled = false;
            radio_inactivo.Enabled = false;
            text_observacion_mascota.Enabled = false;
            btn_buscar_mascota.Enabled = false;
            grupo_estado.Enabled = true;
        }
        public void habilitar_cajas_mascota()
        {
            combo_mascota.Enabled = true;
            text_observacion_mascota.Enabled = true;
            text_nombre_adoptarse.Enabled = true;
            radio_inactivo.Enabled = true;
            text_observacion_mascota.Enabled = true;
            btn_buscar_mascota.Enabled = true;
            grupo_estado.Enabled = true;
        }
        public void inhabilitar_cajas_mascota_botones()
        {
            btn_nuevo_mascota.Enabled = false;
            btn_agregar_mascota.Enabled = false;
            btn_modificar_mascota.Enabled = false;
            btn_eliminar_mascota.Enabled = false;
            btn_cancelar_mascota.Enabled = false;
        }

        public void listar_detalle_adopcion()
        {



        }
        private void btn_buscar_ficha_Click(object sender, EventArgs e)
        {

        }

        private void btn_nueva_ficha_Click(object sender, EventArgs e)
        {
            lb_id_ficha.Text = "";
            limpiar_cajas_ficha();
            habilitar_cajas_ficha();
            btn_registrar_ficha.Enabled = true;
            btn_cancelar_ficha.Enabled = true;
            btn_editar_ficha.Enabled = false;
            btn_editar_ficha.Text = "Editar Ficha Adopcion";


        }

        private void btn_nuevo_mascota_Click(object sender, EventArgs e)
        {
            habilitar_cajas_mascota();
            limpiar_cajas_mascota();
            btn_agregar_mascota.Enabled = true;
            btn_cancelar_ficha.Enabled = true;
        }

        private void btn_agregar_mascota_Click(object sender, EventArgs e)
        {
            Boolean band1 = false;
            String mensaje = "Por Favor Complete los campos obligatorios : \n";
            int id_ficha_adopcion = Convert.ToInt32(lb_id_ficha.Text);
            Mascota mascota = (Mascota)combo_mascota.SelectedItem;
            String nombre_adoptarse = "";
            String observa = "";
            if (!String.IsNullOrEmpty(text_nombre_adoptarse.Text))
            {
                nombre_adoptarse = text_nombre_adoptarse.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Nombre al Adoptarse ";
                band1 = true;
            }
            if (!String.IsNullOrEmpty(text_observacion_mascota.Text))
            {
                observa = text_observacion_mascota.Text;
            }
            int estado = 0;
            if (radio_activo.Checked == true)
            {
                estado = 1;
            }
            else
            {
                if (radio_inactivo.Checked == true)
                {
                    estado = 0;
                }
            }

            if (band1 == true)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                int band = new NDetalleAdopcion().N_registrar_detalleAdopcion(mascota, id_ficha_adopcion, nombre_adoptarse, estado, observa);
                if (band == 0)
                {
                    MessageBox.Show("ocurrio un error intentelo Nuevamente");
                }
                else
                {
                    MessageBox.Show("Registrado Correctamente");
                    btn_nuevo_mascota.Enabled = true;
                    limpiar_cajas_mascota();
                    inhabilitar_cajas_mascota();
                    btn_modificar_mascota.Enabled = false;
                    btn_eliminar_mascota.Enabled = false;



                }
            }

        }

        private void btn_listar_ficha_Click(object sender, EventArgs e)
        {
            F_ListarFichasAdopcion ma = new F_ListarFichasAdopcion(this);
            ma.ShowDialog();
            btn_editar_ficha.Text = "Editar Ficha Adopcion";
        }

        private void btn_cancelar_ficha_Click(object sender, EventArgs e)
        {
            inhabilitar_cajas_ficha();
            limpiar_cajas_ficha();
            limpiar_cajas_mascota();
            inhabilitar_cajas_mascota();
            inhabilitar_cajas_mascota_botones();
            btn_registrar_ficha.Enabled = false;
            grupo_estado.Enabled = false;
            btn_editar_ficha.Text = "Editar Ficha Adopcion";
        }

        private void btn_editar_ficha_Click(object sender, EventArgs e)
        {
            if (this.btn_editar_ficha.Text.Equals("Editar Ficha Adopcion"))
            {
                btn_editar_ficha.Text = "Guardar Cambios";
                btn_nueva_ficha.Enabled = true;
                btn_eliminar_ficha.Enabled =false;
                btn_cancelar_ficha.Enabled = true;
                btn_registrar_ficha.Enabled = false;
                combo_persona.Enabled = true;
                combo_voluntarios.Enabled = true;
                habilitar_cajas_ficha();

            }else{


            if (btn_editar_ficha.Text.Equals("Guardar Cambios"))
            {
                btn_modificar_mascota.Text = "Editar Ficha Adopcion";

                int id_ficha_adopcion = Convert.ToInt32(lb_id_ficha.Text);
                String relacion = "";
                String observa_ficha = "";
                Usuario voluntario = (Usuario)combo_voluntarios.SelectedItem;
                Persona persona = (Persona)combo_persona.SelectedItem;

                if (!String.IsNullOrEmpty(text_relacion.Text))
                {
                    relacion = text_relacion.Text;
                }
                if (!String.IsNullOrEmpty(text_observacion_ficha.Text))
                {
                    observa_ficha = text_observacion_ficha.Text;
                }

                DateTime fecha_adopcion = Convert.ToDateTime(fech_adopcion.Text);
                int respuesta = new NFichaAdopcion().N_modificar_adopcion(id_ficha_adopcion, persona, voluntario, relacion, observa_ficha, fecha_adopcion);
                if (respuesta == 0)
                {
                    MessageBox.Show("Error Al Guardar los Cambios Por favor intente nuevamente");

                }
                else
                {
                    MessageBox.Show("Cambios guardados correctamente");
                    

                    inhabilitar_cajas_ficha();
                    
                    
                    limpiar_cajas_mascota();
                    btn_editar_ficha.Enabled = false;
                    btn_nueva_ficha.Enabled = true;
                    btn_registrar_ficha.Enabled = false;
                    btn_eliminar_ficha.Enabled = false;
                    
                }

            }
            }
        }
    }
}
