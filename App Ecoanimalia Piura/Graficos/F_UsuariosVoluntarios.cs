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
    public partial class F_UsuariosVoluntarios : Form
    {
        public F_UsuariosVoluntarios()
        {
            InitializeComponent();
        }
        #region metodos
        public void restablecer_cajas()
        {
            text_codigo.Text = "";
            lb_serie.Text = "";
            mostra_serie.Text = "";
            text_usuario.Text = "";
            text_contrasena.Text = "";
            text_nombre.Text = "";
            text_apellido.Text = "";
            combo_tipo.SelectedIndex = 0;
            combo_sexo.SelectedIndex = 0;
            combo_estado.SelectedIndex = 0;
            text_dni.Text = "";
            text_direccion.Text = "";
            text_movistar.Text = "";
            text_claro.Text = "";
            text_nextel.Text = "";
            text_telefono.Text = "";
            text_email.Text = "";
            text_facebook.Text = "";
            text_ocupacion.Text = "";
            text_referencia.Text = "";
        }
        public void activar_cajas()
        {
            text_codigo.Enabled = true;
            
            text_usuario.Enabled = true;
            text_contrasena.Enabled = true;
            // text_contrasena.PasswordChar = char.Parse("\0");
            text_nombre.Enabled = true;
            text_apellido.Enabled = true;
            combo_sexo.Enabled = true;
            combo_tipo.Enabled = true;
            combo_estado.Enabled = true;
            text_dni.Enabled = true;
            text_direccion.Enabled = true;
            text_movistar.Enabled = true;
            text_claro.Enabled = true;
            text_nextel.Enabled = true;
            text_telefono.Enabled = true;
            text_email.Enabled = true;
            text_facebook.Enabled = true;
            text_ocupacion.Enabled = true;
            text_referencia.Enabled = true;
        }
        public void desactivar_cajas()
        {
           
            text_codigo.Enabled = false;
            text_usuario.Enabled = false;
            text_contrasena.Enabled = false;
            // text_contrasena.PasswordChar = char.Parse("*");
            text_nombre.Enabled = false;
            text_apellido.Enabled = false;
            combo_sexo.Enabled = false;
            combo_tipo.Enabled = false;
            combo_estado.Enabled = false;
            text_dni.Enabled = false;
            text_direccion.Enabled = false;
            text_movistar.Enabled = false;
            text_claro.Enabled = false;
            text_nextel.Enabled = false;
            text_telefono.Enabled = false;
            text_email.Enabled = false;
            text_facebook.Enabled = false;
            text_ocupacion.Enabled = false;
            text_referencia.Enabled = false;
        }
       
        public void llenar_combo_sexo()
        {
            combo_sexo.Items.Add("Masculino");
            combo_sexo.Items.Add("Femenino");
            combo_sexo.SelectedIndex = 0;


        }
        public void llenar_combo_tipo()
        {
            combo_tipo.Items.Clear();
            combo_tipo.Items.Add("administrador");
            combo_tipo.Items.Add("encargado");
           if (radioacceso_nega.Checked == true)
          
           {
                combo_tipo.Items.Add("voluntario");
           }
            combo_tipo.SelectedIndex = 0;
        }
        public void llenar_combo_estado()
        {

            combo_estado.Items.Add("activo");
            combo_estado.Items.Add("Inactivo");
            combo_estado.SelectedIndex = 0;
        }
        public void listar_usuarios()
        {
           List<Usuario> lista = new NUsuario().N_listar_usuarios();
            grilla_usuarios.DataSource = lista;
            this.grilla_usuarios.Columns[4].Visible = false;

        }
        public void combo_encargado()
        {
            List<Usuario> lista = new NUsuario().N_listar_usuarios();
            
            var filtro = from c_Usuario in lista where c_Usuario.Tipo == "administrador" || c_Usuario.Tipo == "encargado" select c_Usuario;
            
            this.combo_encar.DataSource = filtro.ToList<Usuario>();
            
        }
        public void inicio()
        {
            this.radio_negativo.Checked = true;
        }
        public void Ver_serie(){
        lb_serie.Text = "";
        lb_serie.Text = ""+ new NUsuario().N_Ultima_Serie();
        mostra_serie.Text = "00" + lb_serie.Text;
        }
       

        #endregion


        

        private void F_UsuariosVoluntarios_Load(object sender, EventArgs e)
        {

            combo_encar.Enabled = false;
            text_usuario.Enabled = false;
            text_contrasena.Enabled = false;
            llenar_combo_sexo();
            
            llenar_combo_estado();
            combo_encargado();
            if (radio_negativo.Checked == true && radioacceso_nega.Checked == true)
            {
                combo_tipo.Items.Clear();
                combo_tipo.Items.Add("voluntario");
                combo_tipo.SelectedIndex = 0;
            }
            else
            {
                llenar_combo_tipo();
            }
            Ver_serie();
            inicio();
            listar_usuarios();
        }
        public void Registrar() {
            int serie = int.Parse(lb_serie.Text);
            Boolean band1 = false, band2 = false, band3 = false, band4 = false, band5 = false, band6 = false;
            String mensaje = "Por Favor Complete los campos obligatorios : \n";
            String codigo = "";
            String usuario = "";
            String clave = "";
            String nombre = "";
            String apellidos = "";
            String dni = "";
            String direccion = "";
            String referencia = "";
            int movistar = 0;
            int claro = 0;
            int telefono = 0;
            int nextel = 0;
            String email = "";
            String facebook = "";
            String ocupacion = "";


            if (!String.IsNullOrEmpty(text_codigo.Text))
            {
                codigo = text_codigo.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Codigo ";
                band1 = true;

            }
            if (radioacceso_afirma.Checked == true)
            {

                if (!String.IsNullOrEmpty(text_usuario.Text))
                {
                    usuario = text_usuario.Text;
                }
                else
                {
                    mensaje = mensaje + "\n - Casilla de Usuario ";
                    band2 = true;
                }



                if (!String.IsNullOrEmpty(text_contrasena.Text))
                {
                    clave = text_contrasena.Text;
                }
                else
                {
                    mensaje = mensaje + "\n - Casilla de Contraseña \n";
                    band3 = true;
                }

            }

            if (!String.IsNullOrEmpty(text_nombre.Text))
            {
                nombre = text_nombre.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Nombre ";
                band4 = true;
            }



            if (!String.IsNullOrEmpty(text_apellido.Text))
            {
                apellidos = text_apellido.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Apellidos ";
                band5 = true;
            }
            String sexo = combo_sexo.SelectedItem.ToString();

            String tipo = combo_tipo.SelectedItem.ToString();
            String estado = combo_estado.SelectedItem.ToString();


            Usuario encargo;
            if (radio_afirmativo.Checked == true)
            {
                encargo = (Usuario)combo_encar.SelectedItem;
            }
            else
            {
                encargo = null;
            }

            if (!String.IsNullOrEmpty(text_dni.Text))
            {
                dni = text_dni.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Dni ";
                band6 = true;
            }

            if (!String.IsNullOrEmpty(text_direccion.Text))
            {
                direccion = text_direccion.Text;
            }
            if (!String.IsNullOrEmpty(text_referencia.Text))
            {
                referencia = text_referencia.Text;
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
                nextel = int.Parse(text_nextel.Text);
            }
            if (!String.IsNullOrEmpty(text_telefono.Text))
            {
                telefono = int.Parse(text_telefono.Text);
            }
            if (!String.IsNullOrEmpty(text_email.Text))
            {
                email = text_email.Text;
            }
            if (!String.IsNullOrEmpty(text_facebook.Text))
            {
                facebook = text_facebook.Text;
            }
            if (!String.IsNullOrEmpty(text_ocupacion.Text))
            {
                ocupacion = text_ocupacion.Text;
            }
            //aqui
            if (band1 == true || band2 == true || band3 == true || band4 == true || band5 == true || band6 == true)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                if (radioacceso_afirma.Checked == true)
                {
                    int confir1 = new NUsuario().N_Registrar_Usuario_conacceso(serie,codigo, usuario, clave, nombre, apellidos, sexo, dni, direccion, referencia, movistar, claro, nextel, telefono, email, facebook, ocupacion, tipo, estado, encargo);
                    if (confir1 == 0)
                    {
                        MessageBox.Show("Error Al Registrar Por favor intente nuevamente");

                    }
                    else
                    {
                        MessageBox.Show("Registrado Correctamente");
                        Ver_serie();
                        combo_encargado();
                        restablecer_cajas();


                    }
                }
                else
                {
                    int confir2 = new NUsuario().N_Registrar_Usuario_sinacceso(serie,codigo, nombre, apellidos, sexo, dni, direccion, referencia, movistar, claro, nextel, telefono, email, facebook, ocupacion, tipo, estado, encargo);
                    if (confir2 == 0)
                    {
                        MessageBox.Show("Error Al Registrar Por favor intente nuevamente");

                    }
                    else
                    {
                        MessageBox.Show("Registrado Correctamente");
                        Ver_serie();
                        combo_encargado();
                        restablecer_cajas();


                    }
                }
                listar_usuarios();
                combo_encargado();
            }
        }
        private void boton_registrar_Click(object sender, EventArgs e)
        {
            Registrar();
       }

        private void radio_afirmativo_CheckedChanged(object sender, EventArgs e)
        {
            combo_encar.Enabled = true;
            llenar_combo_tipo();

            if (combo_encar.Items.Count != 0)
            {
                Usuario u = (Usuario)combo_encar.SelectedItem;
                if (u.Tipo.Equals("administrador"))
                {
                    combo_tipo.Items.Clear();
                    combo_tipo.Items.Add("voluntario");
                    combo_tipo.SelectedIndex = 0;
                }
                else
                {
                    llenar_combo_tipo();
                }

            }
        }


        private void radio_negativo_CheckedChanged(object sender, EventArgs e)
        {
            combo_encar.Enabled = false;
            if (radio_negativo.Checked == true && radioacceso_nega.Checked == true)
            {
                combo_tipo.Items.Clear();
                combo_tipo.Items.Add("voluntario");
                combo_tipo.SelectedIndex = 0;
            }
            else
            {
                llenar_combo_tipo();
            }
        }

        private void radioacceso_nega_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_negativo.Checked == true && radioacceso_nega.Checked == true)
            {
                combo_tipo.Items.Clear();
                combo_tipo.Items.Add("voluntario");
                combo_tipo.SelectedIndex = 0;
            }
            else
            {
                llenar_combo_tipo();
            }
            text_usuario.Enabled = false;
            text_contrasena.Enabled = false;
            text_usuario.Clear();
            text_contrasena.Clear();
            
        }

        private void radioacceso_afirma_CheckedChanged(object sender, EventArgs e)
        {
            llenar_combo_tipo();
            text_usuario.Enabled = true;
            text_contrasena.Enabled = true;
        }

        private void boton_nuevo_Click(object sender, EventArgs e)
        {
            restablecer_cajas();
            activar_cajas();
            Ver_serie();
            text_usuario.Enabled = false;
            text_contrasena.Enabled = false;
            radio_negativo.Checked = true;
            radioacceso_nega.Checked = true;
        }
        
        private void grilla_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            restablecer_cajas();

            lb_serie.Text = this.grilla_usuarios.CurrentRow.Cells[0].Value.ToString();
            mostra_serie.Text = "00" + lb_serie.Text;
            text_codigo.Text = this.grilla_usuarios.CurrentRow.Cells[1].Value.ToString();
            
            //ext_usuario.Text = this.grilla_usuarios.CurrentRow.Cells[2].Value.ToString();
            
            
            if (this.grilla_usuarios.CurrentRow.Cells[2].Value != null)
            {
                String encarga = this.grilla_usuarios.CurrentRow.Cells[2].Value.ToString();


                for (int i = 0; i < combo_encar.Items.Count; i++)
                {
                    Usuario usu = (Usuario)combo_encar.Items[i];
                    String conta = "DNI: " + usu.Dni + " - " + usu.Nombres + " " + usu.Apellidos;
                    if (conta.Equals(encarga))
                    {
                        combo_encar.SelectedIndex = i;
                        radio_afirmativo.Checked = true;
                        break;
                    }
                }
            }
            else
            {
                radio_negativo.Checked = true;
            }

            if (this.grilla_usuarios.CurrentRow.Cells[3].Value != null || this.grilla_usuarios.CurrentRow.Cells[4].Value != null)
            {
                radioacceso_afirma.Checked = true;
                text_usuario.Text = this.grilla_usuarios.CurrentRow.Cells[3].Value.ToString();
                text_contrasena.Text = this.grilla_usuarios.CurrentRow.Cells[4].Value.ToString();
               
            }
            else
            {
                radioacceso_nega.Checked = true;
            }
            
          

            
           text_nombre.Text = this.grilla_usuarios.CurrentRow.Cells[6].Value.ToString();
           text_apellido.Text = this.grilla_usuarios.CurrentRow.Cells[7].Value.ToString();
           String sex = this.grilla_usuarios.CurrentRow.Cells[8].Value.ToString();
           if (sex.Equals("Masculino"))
           {
               combo_sexo.SelectedIndex = 0;
           }
           else
           {
               combo_sexo.SelectedIndex = 1;
           }


           text_dni.Text = this.grilla_usuarios.CurrentRow.Cells[9].Value.ToString();
           text_direccion.Text = this.grilla_usuarios.CurrentRow.Cells[10].Value.ToString();
           text_referencia.Text = this.grilla_usuarios.CurrentRow.Cells[11].Value.ToString();
           text_movistar.Text = this.grilla_usuarios.CurrentRow.Cells[12].Value.ToString();
           text_claro.Text = this.grilla_usuarios.CurrentRow.Cells[13].Value.ToString();
           text_nextel.Text = this.grilla_usuarios.CurrentRow.Cells[14].Value.ToString();
           text_telefono.Text = this.grilla_usuarios.CurrentRow.Cells[15].Value.ToString();


           text_email.Text = this.grilla_usuarios.CurrentRow.Cells[16].Value.ToString();
           text_facebook.Text = this.grilla_usuarios.CurrentRow.Cells[17].Value.ToString();
           text_ocupacion.Text = this.grilla_usuarios.CurrentRow.Cells[18].Value.ToString();
            String est =this.grilla_usuarios.CurrentRow.Cells[19].Value.ToString();
            if (est.Equals("activo"))
            {
                combo_estado.SelectedIndex = 0;
            }
            else
            {
                combo_estado.SelectedIndex = 1;
            }
            llenar_combo_tipo();
            String tip = grilla_usuarios.CurrentRow.Cells[5].Value.ToString();
            if (tip.Equals("administrador"))
            {
                combo_tipo.SelectedIndex = 0;
            }
            else
            {
                if (tip.Equals("encargado"))
                {
                    combo_tipo.SelectedIndex = 1;
                }
                else
                {
                    if (tip.Equals("voluntario"))
                    {
                        combo_tipo.SelectedIndex = 2;
                    }
                }
            }
            text_contrasena.Enabled = false;
        }

        private void combo_encar_TextChanged(object sender, EventArgs e)
        {
            Usuario u = (Usuario)combo_encar.SelectedItem;
            if (u.Tipo.Equals("administrador") || u.Tipo.Equals("encargado"))
            {
                combo_tipo.Items.Clear();
                
                combo_tipo.Items.Add("voluntario");
                combo_tipo.SelectedIndex = 0;
            }
        }

        public void modificar()
        {
            int serie = int.Parse(lb_serie.Text);
            Boolean band1 = false, band2 = false, band3 = false, band4 = false, band5 = false, band6 = false;
            String mensaje = "Por Favor Complete los campos obligatorios : \n";
            String codigo = "";
            String usuario = "";
            String clave = "";
            String nombre = "";
            String apellidos = "";
            String dni = "";
            String direccion = "";
            String referencia = "";
            int movistar = 0;
            int claro = 0;
            int telefono = 0;
            int nextel = 0;
            String email = "";
            String facebook = "";
            String ocupacion = "";


            if (!String.IsNullOrEmpty(text_codigo.Text))
            {
                codigo = text_codigo.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Codigo ";
                band1 = true;

            }
            if (radioacceso_afirma.Checked == true)
            {

                if (!String.IsNullOrEmpty(text_usuario.Text))
                {
                    usuario = text_usuario.Text;
                }
                else
                {
                    mensaje = mensaje + "\n - Casilla de Usuario ";
                    band2 = true;
                }



                if (!String.IsNullOrEmpty(text_contrasena.Text))
                {
                    clave = text_contrasena.Text;
                }
                else
                {
                    mensaje = mensaje + "\n - Casilla de Contraseña \n";
                    band3 = true;
                }

            }

            if (!String.IsNullOrEmpty(text_nombre.Text))
            {
                nombre = text_nombre.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Nombre ";
                band4 = true;
            }



            if (!String.IsNullOrEmpty(text_apellido.Text))
            {
                apellidos = text_apellido.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Apellidos ";
                band5 = true;
            }
            String sexo = combo_sexo.SelectedItem.ToString();

            String tipo = combo_tipo.SelectedItem.ToString();
            String estado = combo_estado.SelectedItem.ToString();


            Usuario encargo;
            if (radio_afirmativo.Checked == true)
            {
                encargo = (Usuario)combo_encar.SelectedItem;
            }
            else
            {
                encargo = null;
            }

            if (!String.IsNullOrEmpty(text_dni.Text))
            {
                dni = text_dni.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Dni ";
                band6 = true;
            }

            if (!String.IsNullOrEmpty(text_direccion.Text))
            {
                direccion = text_direccion.Text;
            }
            if (!String.IsNullOrEmpty(text_referencia.Text))
            {
                referencia = text_referencia.Text;
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
                nextel = int.Parse(text_nextel.Text);
            }
            if (!String.IsNullOrEmpty(text_telefono.Text))
            {
                telefono = int.Parse(text_telefono.Text);
            }
            if (!String.IsNullOrEmpty(text_email.Text))
            {
                email = text_email.Text;
            }
            if (!String.IsNullOrEmpty(text_facebook.Text))
            {
                facebook = text_facebook.Text;
            }
            if (!String.IsNullOrEmpty(text_ocupacion.Text))
            {
                ocupacion = text_ocupacion.Text;
            }
            if (band1 == true || band2 == true || band3 == true || band4 == true || band5 == true || band6 == true)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                if (radioacceso_afirma.Checked == true)
                {
                    int confir1 = new NUsuario().N_Modificar_Usuario_conacceso(codigo, usuario, clave, nombre, apellidos, sexo, dni, direccion, referencia, movistar, claro, nextel, telefono, email, facebook, ocupacion, tipo, estado, encargo,serie);
                    if (confir1 == 0)
                    {
                        MessageBox.Show("Error Al Modificar Por favor intente nuevamente");

                    }
                    else
                    {
                        MessageBox.Show("Modificar Correctamente");
                        Ver_serie();
                        combo_encargado();
                        restablecer_cajas();


                    }
                }
                else
                {
                    int confir2 = new NUsuario().N_Modificar_Usuario_sinacceso(codigo, nombre, apellidos, sexo, dni, direccion, referencia, movistar, claro, nextel, telefono, email, facebook, ocupacion, tipo, estado, encargo,serie);
                    if (confir2 == 0)
                    {
                        MessageBox.Show("Error Al Modificar Por favor intente nuevamente");

                    }
                    else
                    {
                        MessageBox.Show("Modificar Correctamente");
                        Ver_serie();
                        combo_encargado();
                        restablecer_cajas();


                    }
                }
                listar_usuarios();
                combo_encargado();
            }
        }
        private void boton_modificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btn_verCl_Click(object sender, EventArgs e)
        {
           String val = text_contrasena.Text;
           if (!String.IsNullOrEmpty(text_contrasena.Text))
           {
               String opcion = Inputbox.Show("Confirmacion de Acceso", "Ingrese Su Contraseña ", FormStartPosition.CenterScreen);
               if (!String.IsNullOrEmpty(opcion))
               {

                   if (opcion.Equals(F_Login.perfil.Contrasena))
                   {
                       MessageBox.Show("Contraseña es : " + val);
                   }
                   else
                   {
                       MessageBox.Show("Error Acceso Denegado");

                   }
               }
           }
           else
           {
               MessageBox.Show("No Posee Contraseña");
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
                t.PasswordChar = '*';

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

        private void btn_editar_clave_Click(object sender, EventArgs e)
        {
            String val = text_contrasena.Text;
            if (!String.IsNullOrEmpty(text_contrasena.Text))
            {
                String opcion = Inputbox.Show("Confirmacion de Acceso", "Ingrese Su Contraseña ", FormStartPosition.CenterScreen);
                if (!String.IsNullOrEmpty(opcion))
                {

                    if (opcion.Equals(F_Login.perfil.Contrasena))
                    {
                        text_contrasena.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Error Acceso Denegado");

                    }
                }
            }
            else
            {
                MessageBox.Show("No Posee Contraseña");
            }
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            int serie = int.Parse(lb_serie.Text);
            if(MessageBox.Show("Seguro que dese Eliminar?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int band = new NUsuario().N_eliminar_usuario_voluntario(serie);
                if (band == 0)
                {
                    MessageBox.Show("Error Al Eliminar Por favor intente nuevamente");
                }
                else
                {
                    MessageBox.Show("Eliminado Correctamente");
                    
                    combo_encargado();
                    restablecer_cajas();
                    Ver_serie();
                }
                listar_usuarios();
                combo_encargado();
            }
            
            
        }
        public void escribir_buscar()
        {
            List<Usuario> lista = new NUsuario().N_listar_usuarios();
            var filtro = from Usuario in lista
                         where Usuario.Serie.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Codigo.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Usuario.Nombres.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Apellidos.ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Usuario.Tipo.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Sexo.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Dni.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Usuario.Direccion.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Referencia.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Movistar.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Usuario.Claro.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Nextel.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Telefono.ToString().ToUpper().Contains(text_buscar.Text.ToUpper()) ||
                         Usuario.Email.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Facebook.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Ocupacion.ToUpper().Contains(text_buscar.Text.ToUpper()) || Usuario.Estado.ToUpper().Contains(text_buscar.Text.ToUpper())
                         select Usuario;
            this.grilla_usuarios.DataSource = filtro.ToList<Usuario>();


        }
        private void text_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            escribir_buscar();
        }
       

       
       

        
    }
}
