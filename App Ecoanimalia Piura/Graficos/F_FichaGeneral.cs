using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using App_Ecoanimalia_Piura.Logica;
using App_Ecoanimalia_Piura.Negocio;


namespace App_Ecoanimalia_Piura.Graficos
{
    public partial class F_FichaGeneral : Form
    {

        static List<ImagenMascota> lista_imagenes = new List<ImagenMascota>();
        static int contador = 0;
        public static FichaTemporal fichatem;
        public F_FichaGeneral()
        {
            InitializeComponent();
        }

        #region Fotos
        #region metodos_Vista_fotos
        public void listar_imagenes(int serie_mascota)
        {
            lista_imagenes.Clear();
            lista_imagenes = new NImagenMascota().N_listar_imagenes(serie_mascota);
            if (lista_imagenes.Count != 0)
            {
                NImagenMascota ima = new NImagenMascota();
                ima.N_Ver_Imagen(pictureBox1, lista_imagenes[contador].Id);
                text_descripcion_imagen.Text = lista_imagenes[contador].Descripcion;

            }
            else
            {
                btn_anterior.Enabled = false;
                btn_siguiente.Enabled = false;
                text_descripcion_imagen.Clear();
            }



        }
        public void inicio()
        {
            if (lista_imagenes.Count != 0)
            {
                contador = 0;
                int val1 = (contador + 1);
                btn_siguiente.Enabled = true;
                if (lista_imagenes.Count - val1 == 0)
                {
                    btn_siguiente.Enabled = false;
                }
                btn_anterior.Enabled = false;
            }
        }
        public void cargar_inciobotones()
        {
            if (lista_imagenes.Count != 0)
            {
                btn_cargarImagen.Enabled = false;
                text_descripcion_imagen.Enabled = false;
                btn_guardad_imagen.Enabled = false;
                btn_cancelar_foto.Enabled = false;
                text_descripcion_imagen.Enabled = true;
            }
            else
            {
                btn_eliminar_imagen.Enabled = false;
                btn_modificar_descrip.Enabled = false;
                btn_cargarImagen.Enabled = false;
                text_descripcion_imagen.Enabled = false;
                btn_guardad_imagen.Enabled = false;
                btn_cancelar_foto.Enabled = false;
            }
        }
        #endregion

        #region eventos fotos
        private void btn_cargarImagen_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
            btn_cargarImagen.Text = "Foto Cargada";

        }

        private void btn_guardad_imagen_Click(object sender, EventArgs e)
        {

            if (btn_cargarImagen.Text.Equals("Foto Cargada"))
            {
                FileInfo info = new FileInfo(openFileDialog1.FileName);
                long archivoEnBytes = info.Length;
                long archivoenKB = info.Length / 1024;
                //MessageBox.Show("archivo pesa " + archivoenKB + " kb ");
                if (archivoenKB <= 500)
                {

                    String descripcion = this.text_descripcion_imagen.Text;
                    int id_mascota = Convert.ToInt32(this.lb_serie_mascota.Text);
                    int band_imagen = new NImagenMascota().N_Registrar_imagen(descripcion, pictureBox1, id_mascota);
                    if (band_imagen == 0)
                    {
                        MessageBox.Show("Error al Guardar la Imagen - Formato Invalido");

                    }
                    else
                    {
                        MessageBox.Show("Imagen Guardada");
                        btn_cargarImagen.Text = "Seleccionar Foto";
                        btn_cargarImagen.Enabled = false;
                        btn_guardad_imagen.Enabled = false;
                        btn_cancelar_foto.Enabled = false;
                        btn_modificar_descrip.Enabled = true;
                        btn_eliminar_imagen.Enabled = true;
                        this.text_descripcion_imagen.Clear();

                        contador = 0;



                        int val1 = (contador + 1);
                        int idmascota = Convert.ToInt32(this.lb_serie_mascota.Text);
                        listar_imagenes(idmascota);
                        btn_siguiente.Enabled = true;
                        if (lista_imagenes.Count - val1 == 0)
                        {
                            btn_siguiente.Enabled = false;
                        }
                        btn_anterior.Enabled = false;


                    }
                }
                else
                {
                    MessageBox.Show("La Foto Excede de 500 kb\ntamaño de la foto cargada : " + archivoenKB + " kb");
                }
            }
            else
            {
                MessageBox.Show("No a Cargado Ninguna Foto");
            }


        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            contador++;
            if (lista_imagenes.Count > contador)
            {
                int id_mascota = Convert.ToInt32(this.lb_serie_mascota.Text);
                listar_imagenes(id_mascota);
                btn_anterior.Enabled = true;
            }
            else
            {
                btn_siguiente.Enabled = false;
                contador--;
            }
            if (lista_imagenes.Count - contador == 1)
            {
                btn_siguiente.Enabled = false;
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {

            contador--;
            if (contador >= 0)
            {

                btn_siguiente.Enabled = true;
                int id_mascota = Convert.ToInt32(this.lb_serie_mascota.Text);
                listar_imagenes(id_mascota);
            }
            else
            {
                btn_anterior.Enabled = false;
                contador++;
            }
            if (contador == 0)
            {
                btn_anterior.Enabled = false;
            }



        }

        private void btn_nueva_imagen_Click(object sender, EventArgs e)
        {
            btn_cargarImagen.Text = "Seleccionar Foto";
            btn_cargarImagen.Enabled = true;

            text_descripcion_imagen.Clear();
            text_descripcion_imagen.Enabled = true;
            this.pictureBox1.Image = null;


            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = false;


            btn_modificar_descrip.Enabled = false;
            btn_eliminar_imagen.Enabled = false;


            btn_guardad_imagen.Enabled = true;

            btn_cancelar_foto.Enabled = true;
        }

        private void btn_eliminar_imagen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que dese Eliminar?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int cont = lista_imagenes[contador].Id;
                int val = new NImagenMascota().N_eliminar_imagen(cont);
                if (val == 0)
                {
                    MessageBox.Show("Error al Eliminar la Foto");

                }
                else
                {
                    MessageBox.Show("Foto Eliminada");
                    this.pictureBox1.Image = null;
                    contador = 0;
                    int id_mascota = Convert.ToInt32(this.lb_serie_mascota.Text);
                    listar_imagenes(id_mascota);

                    if (lista_imagenes.Count == 0)
                    {
                        btn_anterior.Enabled = false;
                        btn_siguiente.Enabled = false;
                        btn_eliminar_imagen.Enabled = false;
                        btn_modificar_descrip.Enabled = false;
                        text_descripcion_imagen.Enabled = false;
                    }
                    else
                    {
                        if (lista_imagenes.Count == 1)
                        {
                            btn_anterior.Enabled = false;
                            btn_siguiente.Enabled = false;
                            btn_eliminar_imagen.Enabled = true;
                            btn_modificar_descrip.Enabled = true;
                            text_descripcion_imagen.Enabled = true;
                        }
                        else
                        {
                            btn_anterior.Enabled = false;
                            btn_siguiente.Enabled = true;
                            btn_eliminar_imagen.Enabled = true;
                            btn_modificar_descrip.Enabled = true;
                            text_descripcion_imagen.Enabled = true;
                        }
                    }
                }
            }


        }


        private void btn_modificar_descrip_Click(object sender, EventArgs e)
        {

            int id_fot = lista_imagenes[contador].Id;
            String descrip = text_descripcion_imagen.Text;
            int bandactual = new NImagenMascota().N_modificar_imagen_descripcion(id_fot, descrip);
            if (bandactual == 0)
            {
                MessageBox.Show("Error al Modificar la Descripcion");
            }
            else
            {
                MessageBox.Show("Modificado Correctamente");
                // contador = 0;
                int id_mascota = Convert.ToInt32(this.lb_serie_mascota.Text);
                listar_imagenes(id_mascota);
                // inicio();


            }
        }

        private void btn_cancelar_foto_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            openFileDialog1.Reset();

            text_descripcion_imagen.Clear();
            text_descripcion_imagen.Enabled = true;
            btn_cargarImagen.Text = "Seleccionar Foto";
            btn_cargarImagen.Enabled = false;
            btn_guardad_imagen.Enabled = false;
            btn_cancelar_foto.Enabled = false;
            contador = 0;
            int id_mascota = Convert.ToInt32(this.lb_serie_mascota.Text);
            listar_imagenes(id_mascota);
            if (lista_imagenes.Count == 0)
            {
                btn_anterior.Enabled = false;
                btn_siguiente.Enabled = false;
                btn_eliminar_imagen.Enabled = false;
                btn_modificar_descrip.Enabled = false;
            }
            else
            {
                if (lista_imagenes.Count == 1)
                {
                    btn_anterior.Enabled = false;
                    btn_siguiente.Enabled = false;
                    btn_eliminar_imagen.Enabled = true;
                    btn_modificar_descrip.Enabled = true;
                }
                else
                {
                    btn_anterior.Enabled = false;
                    btn_siguiente.Enabled = true;
                    btn_eliminar_imagen.Enabled = true;
                    btn_modificar_descrip.Enabled = true;
                }
            }




        }

        private void btn_salir_foto_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
        #endregion

        #region Mascota
        #region inicio mascotas
        public void inicio_listar()
        {
            List<Mascota> lista = new NMascota().N_Listar_Mascotas();
            this.grilla_general.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                int reglon = this.grilla_general.Rows.Add();
                this.grilla_general.Rows[reglon].Cells["SERIE"].Value = lista[i].Serie;
                this.grilla_general.Rows[reglon].Cells["ID_RESCATISTA"].Value = lista[i].Ser_usu.Serie;
                this.grilla_general.Rows[reglon].Cells["SERIE_FORMATO"].Value = "00-00" + lista[i].Serie;
                this.grilla_general.Rows[reglon].Cells["COD_RESCATISTA"].Value = lista[i].Ser_usu.Codigo;
                this.grilla_general.Rows[reglon].Cells["RESCATISTA"].Value = lista[i].Ser_usu.Nombres + " " + lista[i].Ser_usu.Apellidos;
                if ((!String.IsNullOrEmpty(lista[i].Fic_tem.Id.ToString())) || (lista[i].Fic_tem.Id != 0))
                {
                    this.grilla_general.Rows[reglon].Cells["TEMPORAL"].Value = lista[i].Fic_tem.Id;
                    combo_temporal.Enabled = true;
                }
                else
                {
                    this.grilla_general.Rows[reglon].Cells["TEMPORAL"].Value = "";

                }
                this.grilla_general.Rows[reglon].Cells["FECHA_INGRE"].Value = lista[i].Fecha_ingreso.ToShortDateString();
                this.grilla_general.Rows[reglon].Cells["ID_TIPO"].Value = lista[i].Tipomascota.Id;
                this.grilla_general.Rows[reglon].Cells["TIPO"].Value = lista[i].Tipomascota.Descripcion;
                this.grilla_general.Rows[reglon].Cells["TAMANO"].Value = lista[i].Tamano;
                this.grilla_general.Rows[reglon].Cells["ESTADO"].Value = lista[i].Estado;
                this.grilla_general.Rows[reglon].Cells["NOMBRE"].Value = lista[i].Nombre;
                this.grilla_general.Rows[reglon].Cells["RAZA"].Value = lista[i].Raza;
                this.grilla_general.Rows[reglon].Cells["SEXO"].Value = lista[i].Sexo;
                this.grilla_general.Rows[reglon].Cells["COLOR"].Value = lista[i].Color;
                this.grilla_general.Rows[reglon].Cells["EDAD"].Value = lista[i].Edad;
                this.grilla_general.Rows[reglon].Cells["ESTERILIZADO"].Value = lista[i].Esterilizado;

            }
        }
        #endregion
        #region eventos mascota
        private void btn_modificar_ficha_Click(object sender, EventArgs e)
        {
            btn_eliminar_ficha.Enabled = false;
            if (btn_modificar_ficha.Text.Equals("Editar"))
            {
                btn_modificar_ficha.Text = "Guardar Cambios";
                habilitar_cajas();
                btn_cancelar_registro.Enabled = true;
                if (radio_conoce_no.Checked == true)
                {
                    fecha_esterilizacion.Enabled = false;
                }
                if (radio_conoce_si.Checked == true)
                {
                    fecha_esterilizacion.Enabled = true;
                }


            }
            else
            {
                if (btn_modificar_ficha.Text.Equals("Guardar Cambios"))
                {
                    Boolean band1 = false, band2 = false, band3 = false, band4 = false, band5 = false;
                    String mensaje = "Por Favor Complete los campos obligatorios : \n";
                    String esterilizado = "";
                    String nom_rescatista = "";
                    String nom_mascota = "";
                    String estado = "";
                    String raza = "";
                    String color = "";
                    String edad = "";
                    String sexo = "";
                    int serie = int.Parse(lb_serie_mascota.Text);
                    int serie_resca = 0;
                    Usuario rescatista = null;
                    if ((!String.IsNullOrEmpty(text_nombre_rescatista.Text)) && (!String.IsNullOrEmpty(lb_id_usuario.Text)))
                    {
                        serie_resca = int.Parse(lb_id_usuario.Text);
                        nom_rescatista = text_nombre_rescatista.Text;
                        rescatista = new Usuario();
                        rescatista.Serie = serie_resca;

                    }
                    else
                    {
                        mensaje = mensaje + "\n - No a Buscado el Rescatista ";
                        band1 = true;

                    }

                    DateTime fingreso = Convert.ToDateTime(fecha_ingreso.Text);
                    if (!String.IsNullOrEmpty(text_nombre.Text))
                    {
                        nom_mascota = text_nombre.Text;
                    }
                    else
                    {
                        mensaje = mensaje + "\n - Casilla de Nombre de Mascota ";
                        band2 = true;
                    }

                    if (radio_recuperacion.Checked == true)
                    {
                        estado = "En Recuperacion";

                    }
                    else
                    {
                        if (radio_apto.Checked == true)
                        {
                            estado = "Apto";
                        }
                        else
                        {
                            if (radio_adoptado.Checked == true)
                            {
                                estado = "Adoptado";
                            }

                        }
                    }
                    if (!String.IsNullOrEmpty(this.text_raza.Text))
                    {
                        raza = text_raza.Text;
                    }
                    else
                    {
                        mensaje = mensaje + "\n - Casilla de raza";
                        band3 = true;
                    }



                    if (!String.IsNullOrEmpty(text_color.Text))
                    {
                        color = text_color.Text;
                    }
                    else
                    {
                        mensaje = mensaje + "\n - Casilla de Color ";
                        band4 = true;
                    }
                    if (radio_macho.Checked == true)
                    {
                        sexo = "Macho";
                    }
                    else
                    {
                        sexo = "Hembra";
                    }
                    String tamaño = combo_tamaño.SelectedItem.ToString();
                    TipoMascota tipoM = (TipoMascota)combo_tipo.SelectedItem;

                    Object f_esterilizado = null;
                    if (!String.IsNullOrEmpty(text_edad.Text))
                    {
                        edad = text_edad.Text;
                    }
                    if (radio_afirmativo.Checked == true)
                    {
                        esterilizado = "Si";
                        if (radio_conoce_si.Checked == true)
                        {
                            f_esterilizado = Convert.ToDateTime(fecha_esterilizacion.Text);
                        }
                        else
                        {
                            if (radio_conoce_no.Checked == true)
                            {
                                f_esterilizado = null;
                            }
                        }

                    }
                    else
                    {
                        if (radio_negativo.Checked == true)
                        {
                            esterilizado = "No";
                            f_esterilizado = null;
                        }
                    }
                    FichaTemporal fTemporal;
                    if (radio_temporal_si.Checked == true)
                    {
                        if (combo_temporal.Items.Count > 0)
                        {

                            fTemporal = (FichaTemporal)combo_temporal.SelectedItem;
                        }
                        else
                        {
                            fTemporal = null;
                        }
                    }
                    else
                    {
                        fTemporal = null;
                    }
                    if (band1 == true || band2 == true || band3 == true || band4 == true || band5 == true)
                    {
                        MessageBox.Show(mensaje);
                    }
                    else
                    {

                        if (f_esterilizado != null)
                        {
                            DateTime t = Convert.ToDateTime(f_esterilizado);
                            int confir1 = new NMascota().N_modificar_mascota_confecha_esterilizado(serie, rescatista, fTemporal, fingreso, tipoM, tamaño, estado, nom_mascota, raza, sexo, color, edad, esterilizado, t);
                            if (confir1 == 0)
                            {
                                MessageBox.Show("Error Al Guardar Por favor intente nuevamente");
                            }
                            else
                            {

                                MessageBox.Show("Cambios Guardados Correctamente");
                                
                                invalidar_todo();
                                
                                btn_registrar_ficha.Enabled = false;
                                btn_cancelar_registro.Enabled = false;
                                btn_nuevo_ficha.Enabled = true;
                                btn_modificar_ficha.Text = "Editar";
                                tab_Historial.Parent = Tab_Mascota;
                                tab_vacunas.Parent = Tab_Mascota;
                                tab_Visitas.Parent = Tab_Mascota;
                                tab_fotos.Parent = Tab_Mascota;
                                group_conoce.Enabled = false;
                                group_esterilizado.Enabled = false;
                                
                                inicio_listar();
                                combo_temporal.Enabled = false;
                                group_temporal.Enabled = false;

                            }

                        }
                        else
                        {
                            int confir1 = new NMascota().N_Modificar_mascota_Sinfecha_esterilizado(serie, rescatista, fTemporal, fingreso, tipoM, tamaño, estado, nom_mascota, raza, sexo, color, edad, esterilizado);
                            if (confir1 == 0)
                            {
                                MessageBox.Show("Error Al Guardar Por favor intente nuevamente");
                            }
                            else
                            {
                                MessageBox.Show("Cambios Guardados Correctamente");

                                invalidar_todo();

                                btn_registrar_ficha.Enabled = false;
                                btn_cancelar_registro.Enabled = false;
                                btn_nuevo_ficha.Enabled = true;
                                btn_modificar_ficha.Text = "Editar";
                                tab_Historial.Parent = Tab_Mascota;
                                tab_vacunas.Parent = Tab_Mascota;
                                tab_Visitas.Parent = Tab_Mascota;
                                tab_fotos.Parent = Tab_Mascota;
                                group_conoce.Enabled = false;
                                group_esterilizado.Enabled = false;
                               
                                inicio_listar();
                                combo_temporal.Enabled = false;
                                group_temporal.Enabled = false;
                            }
                        }
                    }
                }
            }
        }


        private void radio_negativo_CheckedChanged(object sender, EventArgs e)
        {
            if (group_esterilizado.Enabled == false)
            {
                group_conoce.Enabled = false;
                fecha_esterilizacion.Enabled = false;
            }
            else
            {
                group_conoce.Enabled = false;
                radio_conoce_no.Checked = true;
                fecha_esterilizacion.Enabled = false;


            }
        }

        private void radio_afirmativo_CheckedChanged(object sender, EventArgs e)
        {
            if (group_esterilizado.Enabled == false)
            {
                group_conoce.Enabled = false;
                fecha_esterilizacion.Enabled = false;
            }
            else
            {
                
                group_conoce.Enabled = true;
            }
        }

        private void radio_conoce_no_CheckedChanged(object sender, EventArgs e)
        {
            if (group_esterilizado.Enabled == false)
            {
                group_conoce.Enabled = false;
                fecha_esterilizacion.Enabled = false;
            }
            else
            {
                if (radio_conoce_no.Checked == true)
                {
                    fecha_esterilizacion.Enabled = false;
                }
            }
        }

        private void radio_conoce_si_CheckedChanged(object sender, EventArgs e)
        {
            if (group_esterilizado.Enabled == false)
            {
                group_conoce.Enabled = false;
                fecha_esterilizacion.Enabled = false;
            }
            else
            {
                if (radio_negativo.Checked == true)
                {
                    radio_conoce_no.Checked = true;
                    
                }
                if (radio_conoce_si.Checked == true)
                {
                    fecha_esterilizacion.Enabled = true;
                }
            }
        }

        private void radio_temporal_no_CheckedChanged(object sender, EventArgs e)
        {
            combo_temporal.Enabled = false;
            btn_verDatos.Enabled = false;
        }

        private void radio_temporal_si_CheckedChanged(object sender, EventArgs e)
        {
            combo_temporal.Enabled = true;
            btn_verDatos.Enabled = true;
        }


        private void btn_verDatos_Click(object sender, EventArgs e)
        {

            fichatem = (FichaTemporal)combo_temporal.SelectedItem;


            F_VerDatosFichaTemporal ver = new F_VerDatosFichaTemporal();
            ver.Visible = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            text_nombre_rescatista.Clear();
            lb_id_usuario.Text = "";
            if (!String.IsNullOrEmpty(text_codigo.Text))
            {
                String cod = text_codigo.Text;
                Usuario u = new NUsuario().N_ver_Usuarioxcodigo(cod);
                if (u == null)
                {
                    MessageBox.Show("No se Encontro el Rescatista");
                    text_nombre_rescatista.Text = "";

                }
                else
                {
                    text_nombre_rescatista.Text = u.Nombres + " " + u.Apellidos;
                    lb_id_usuario.Text = "" + u.Serie;
                    MessageBox.Show("Busqueda Satisfatoria");
                }
            }
            else
            {
                MessageBox.Show("Por favor Ingrese el Codigo");
            }
        }
        #endregion
        #region metodos vista ficha
        public void activar_tabs()
        {
            tab_Historial.Parent = Tab_Mascota;
            tab_vacunas.Parent = Tab_Mascota;
            tab_Visitas.Parent = Tab_Mascota;
            tab_fotos.Parent = Tab_Mascota;
        }

        public void habilitar_cajas()
        {
            text_codigo.Enabled = true;
            text_nombre_rescatista.Enabled = true;
            fecha_ingreso.Enabled = true;
            text_nombre.Enabled = true;
            group_estado.Enabled = true;
            text_raza.Enabled = true;
            text_color.Enabled = true;
            group_sexo.Enabled = true;
            combo_tamaño.Enabled = true;
            combo_tipo.Enabled = true;
            text_edad.Enabled = true;
            group_esterilizado.Enabled = true;
            group_conoce.Enabled = true;
            fecha_esterilizacion.Enabled = true;
            group_temporal.Enabled = true;
            combo_temporal.Enabled = false;
            if (radio_temporal_si.Checked == true)
            {
                btn_verDatos.Enabled = true;
                combo_temporal.Enabled = true;

            }
            else
            {
                btn_verDatos.Enabled = false;
                combo_temporal.Enabled = false;
            }


        }


        private void btn_nuevo_ficha_Click(object sender, EventArgs e)
        {
            lb_etiqueta_nombre.Visible = false;
            lb_etiqueta_mascota.Visible = false;
            lb_etiqueta_mascota.Text = "";
            lb_id_usuario.Text = "";
            lb_serie_mascota.Text = "";
            habilitar_cajas();
            tab_Historial.Parent = null;
            tab_vacunas.Parent = null;
            tab_Visitas.Parent = null;
            tab_fotos.Parent = null;
            Ver_serie_mascota();
            limpiar_cajas();
            btn_registrar_ficha.Enabled = true;
            btn_cancelar_registro.Enabled = true;
            btn_eliminar_ficha.Enabled = false;
            btn_modificar_ficha.Enabled = false;
            if (radio_negativo.Checked == true)
            {
                group_conoce.Enabled = false;
                radio_conoce_no.Checked = true;
                fecha_esterilizacion.Enabled = false;
            }
        }
        public void limpiar_cajas()
        {
            text_codigo.Clear();
            lb_id_usuario.Text = "";
            text_nombre_rescatista.Clear();

            fecha_ingreso.Value = DateTime.Now;
            text_nombre.Clear();
            radio_recuperacion.Checked = true;
            text_raza.Clear();
            text_color.Clear();
            radio_macho.Checked = true;
            llenar_combo_tipoMascota();
            llenar_combo_tamaño();
            text_edad.Clear();
            radio_negativo.Checked = true;
            radio_conoce_no.Checked = true;
            fecha_esterilizacion.Value = DateTime.Now;
            radio_temporal_no.Checked = true;
        }

        private void btn_registrar_ficha_Click(object sender, EventArgs e)
        {
            Boolean band1 = false, band2 = false, band3 = false, band4 = false, band5 = false;
            String mensaje = "Por Favor Complete los campos obligatorios : \n";
            String esterilizado = "";
            String nom_rescatista = "";
            String nom_mascota = "";
            String estado = "";
            String raza = "";
            String color = "";
            String edad = "";
            String sexo = "";
            int serie = int.Parse(lb_serie_mascota.Text);
            int serie_resca = 0;
            Usuario rescatista = null;
            if ((!String.IsNullOrEmpty(text_nombre_rescatista.Text)) && (!String.IsNullOrEmpty(lb_id_usuario.Text)))
            {
                serie_resca = int.Parse(lb_id_usuario.Text);
                nom_rescatista = text_nombre_rescatista.Text;
                rescatista = new Usuario();
                rescatista.Serie = serie_resca;

            }
            else
            {
                mensaje = mensaje + "\n - No a Buscado el Rescatista ";
                band1 = true;

            }

            DateTime fingreso = Convert.ToDateTime(fecha_ingreso.Text);
            if (!String.IsNullOrEmpty(text_nombre.Text))
            {
                nom_mascota = text_nombre.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Nombre de Mascota ";
                band2 = true;
            }

            if (radio_recuperacion.Checked == true)
            {
                estado = "En Recuperacion";

            }
            else
            {
                if (radio_apto.Checked == true)
                {
                    estado = "Apto";
                }
                else
                {
                    if (radio_adoptado.Checked == true)
                    {
                        estado = "Adoptado";
                    }

                }
            }
            if (!String.IsNullOrEmpty(this.text_raza.Text))
            {
                raza = text_raza.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de raza";
                band3 = true;
            }



            if (!String.IsNullOrEmpty(text_color.Text))
            {
                color = text_color.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Color ";
                band4 = true;
            }
            if (radio_macho.Checked == true)
            {
                sexo = "Macho";
            }
            else
            {
                sexo = "Hembra";
            }
            String tamaño = combo_tamaño.SelectedItem.ToString();
            TipoMascota tipoM = (TipoMascota)combo_tipo.SelectedItem;

            Object f_esterilizado = null;
            if (!String.IsNullOrEmpty(text_edad.Text))
            {
                edad = text_edad.Text;
            }
            if (radio_afirmativo.Checked == true)
            {
                esterilizado = "Si";
                if (radio_conoce_si.Checked == true)
                {
                    f_esterilizado = Convert.ToDateTime(fecha_esterilizacion.Text);
                }
                else
                {
                    if (radio_conoce_no.Checked == true)
                    {
                        f_esterilizado = null;
                    }
                }

            }
            else
            {
                if (radio_negativo.Checked == true)
                {
                    esterilizado = "No";
                }
            }
            FichaTemporal fTemporal;
            if (radio_temporal_si.Checked == true)
            {
                if (combo_temporal.Items.Count > 0)
                {

                    fTemporal = (FichaTemporal)combo_temporal.SelectedItem;
                }
                else
                {
                    fTemporal = null;
                }
            }
            else
            {
                fTemporal = null;
            }
            if (band1 == true || band2 == true || band3 == true || band4 == true || band5 == true)
            {
                MessageBox.Show(mensaje);
            }
            else
            {

                if (f_esterilizado != null)
                {
                    DateTime t = Convert.ToDateTime(f_esterilizado);
                    int confir1 = new NMascota().N_Registrar_mascota_confecha_esterilizado(serie, rescatista, fTemporal, fingreso, tipoM, tamaño, estado, nom_mascota, raza, sexo, color, edad, esterilizado, t);
                    if (confir1 == 0)
                    {
                        MessageBox.Show("Error Al Registrar Por favor intente nuevamente");

                    }
                    else
                    {
                        MessageBox.Show("Registrado Correctamente");
                        limpiar_cajas();
                        invalidar_todo();
                        btn_registrar_ficha.Enabled = false;
                        btn_cancelar_registro.Enabled = false;
                        btn_nuevo_ficha.Enabled = true;
                        tab_Historial.Parent = Tab_Mascota;
                        tab_vacunas.Parent = Tab_Mascota;
                        tab_Visitas.Parent = Tab_Mascota;
                        tab_fotos.Parent = Tab_Mascota;
                        
                        inicio_listar();
                        combo_temporal.Enabled = false;
                        group_temporal.Enabled = false;
                    }

                }
                else
                {
                    int confir1 = new NMascota().N_Registrar_mascota_Sinfecha_esterilizado(serie, rescatista, fTemporal, fingreso, tipoM, tamaño, estado, nom_mascota, raza, sexo, color, edad, esterilizado);
                    if (confir1 == 0)
                    {
                        MessageBox.Show("Error Al Registrar Por favor intente nuevamente");

                    }
                    else
                    {
                        MessageBox.Show("Registrado Correctamente");
                        limpiar_cajas();
                        invalidar_todo();
                        btn_registrar_ficha.Enabled = false;
                        btn_cancelar_registro.Enabled = false;
                        btn_nuevo_ficha.Enabled = true;
                        tab_Historial.Parent = Tab_Mascota;
                        tab_vacunas.Parent = Tab_Mascota;
                        tab_Visitas.Parent = Tab_Mascota;
                        tab_fotos.Parent = Tab_Mascota;
                        
                        inicio_listar();
                        combo_temporal.Enabled = false;
                        group_temporal.Enabled = false;
                    }
                }
            }



            //
        }

        private void btn_cancelar_registro_Click(object sender, EventArgs e)
        {
            lb_id_usuario.Text = "";
            lb_serie_mascota.Text = "";
            invalidar_todo();
            radio_recuperacion.Checked = true;
            radio_conoce_no.Checked = true;
            radio_macho.Checked = true;
            radio_temporal_no.Checked = true;
            radio_conoce_no.Checked = true;
            radio_negativo.Checked = true;
            btn_verDatos.Enabled = false;
            btn_modificar_ficha.Enabled = false;
            btn_eliminar_ficha.Enabled = false;
            btn_registrar_ficha.Enabled = false;
            btn_cancelar_registro.Enabled = false;
            btn_nuevo_ficha.Enabled = true;
            tab_Historial.Parent = null;
            tab_vacunas.Parent = null;
            tab_Visitas.Parent = null;
            tab_fotos.Parent = null;
            limpiar_cajas();
            Ver_serie_mascota();
            btn_modificar_ficha.Text = "Editar";
            radio_temporal_no.Checked = true;
            combo_temporal.Enabled = false;
            
            group_temporal.Enabled = false;
            

        }
        public void llenar_combo_tipoMascota()
        {
            combo_tipo.DataSource = null;
            combo_tipo.DataSource = new NTipoMascota().listar_tipoM();
            combo_tipo.SelectedIndex = 0;
        }
        public void llenar_combo_tamaño()
        {
            combo_tamaño.Items.Clear();
            combo_tamaño.Items.Add("Pequeño");
            combo_tamaño.Items.Add("Mediano");
            combo_tamaño.Items.Add("Grande");
            combo_tamaño.SelectedIndex = 0;
        }
        public void llenar_combo_temporales()
        {
            combo_temporal.DataSource = null;
            combo_temporal.DataSource = new NFichaTemporal().N_Listar_FichaTemporal_Activos();
            combo_temporal.SelectedIndex = 0;
        }
        public void Ver_serie_mascota()
        {
            lb_serie_mascota.Text = "";
            lb_serie_mascota.Text = "" + new NMascota().N_ultima_serie();
            mostra_serie_masco.Text = "00-00" + lb_serie_mascota.Text;
        }
        public void invalidar_todo()
        {
            text_codigo.Enabled = false;
            text_nombre_rescatista.Enabled = false;
            fecha_ingreso.Enabled = false;
            text_nombre.Enabled = false;
            group_estado.Enabled = false;
            text_raza.Enabled = false;
            text_color.Enabled = false;
            group_sexo.Enabled = false;
            combo_tamaño.Enabled = false;
            combo_tipo.Enabled = false;
            text_edad.Enabled = false;
            group_esterilizado.Enabled = false;
            group_conoce.Enabled = false;
            fecha_esterilizacion.Enabled = false;
            group_temporal.Enabled = false;
            combo_temporal.Enabled = false;
            btn_verDatos.Enabled = false;

        }
        #endregion
        #endregion

        #region historial clinico
        #region metodo vista historial clinico
        public void Lista_HistorialClinicobyMascota(int serie)
        {
            List<HistorialClinico> lista_historial = new NHistorialClinico().Historial_Clinico_ByMascota(serie);
            this.grilla_historial.Rows.Clear();
            for (int i = 0; i < lista_historial.Count; i++)
            {
                int reglon = this.grilla_historial.Rows.Add();
                this.grilla_historial.Rows[reglon].Cells["ID"].Value = lista_historial[i].Id.ToString();
                this.grilla_historial.Rows[reglon].Cells["FECHA"].Value = lista_historial[i].Fecha.ToShortDateString();
                this.grilla_historial.Rows[reglon].Cells["DESCRIPCION"].Value = lista_historial[i].Descripcion;
                this.grilla_historial.Rows[reglon].Cells["PRECIO"].Value = lista_historial[i].Precio;

            }
        }
        public void Inhabilitar_CajasHistorial()
        {
            fecha_historial.Enabled = false;
            this.text_descripcion_histo.Enabled = false;
            text_precio_histo.Enabled = false;

        }
        public void Habilitar_CajasHistorial()
        {
            fecha_historial.Enabled = true;
            this.text_descripcion_histo.Enabled = true;
            text_precio_histo.Enabled = true;

        }
        public void limpieza_cajasHistorial()
        {
            fecha_historial.Value = DateTime.Now;
            this.text_descripcion_histo.Clear();
            text_precio_histo.Clear();
        }
        #endregion
        #region eventos historial clinico
        private void btn_registrar_histo_Click(object sender, EventArgs e)
        {
            Boolean band1 = false;
            String mensaje = "Por Favor Complete los campos obligatorios : \n";
            String descripcion = "";
            Decimal precio;
            DateTime f_historial = Convert.ToDateTime(fecha_historial.Text);
            if (!String.IsNullOrEmpty(text_descripcion_histo.Text))
            {
                descripcion = text_descripcion_histo.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Descripcion";
                band1 = true;
            }
            if (!String.IsNullOrEmpty(text_precio_histo.Text))
            {
                precio = Convert.ToDecimal(this.text_precio_histo.Text);
            }
            else
            {
                precio = 0;
            }
            if (band1 == true)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                if (!String.IsNullOrEmpty(this.lb_serie_mascota.Text))
                {
                    int serie = int.Parse(lb_serie_mascota.Text);
                    int respuesta = new NHistorialClinico().N_Insertar_Historial_Clinico(serie, f_historial, descripcion, precio);
                    if (respuesta == 0)
                    {
                        MessageBox.Show("Error Al Registrar Por favor intente nuevamente");

                    }
                    else
                    {
                        MessageBox.Show("Registrado Correctamente");
                        Lista_HistorialClinicobyMascota(serie);
                        limpieza_cajasHistorial();
                        Inhabilitar_CajasHistorial();
                        btn_registrar_histo.Enabled = false;
                        btn_cancelar_histo.Enabled = false;
                        btn_nuevo_histo.Enabled = true;

                    }
                }
                else
                {
                    MessageBox.Show("Ocurrio Un Error - Intente Nuevamente");
                }
            }

        }
        private void btn_nuevo_histo_Click(object sender, EventArgs e)
        {
            lb_id_historial.Text = "";
            Habilitar_CajasHistorial();
            btn_registrar_histo.Enabled = true;
            btn_cancelar_histo.Enabled = true;
            btn_eliminar_histo.Enabled = false;
            btn_modificar_histo.Enabled = false;
            limpieza_cajasHistorial();
        }
        private void btn_cancelar_histo_Click(object sender, EventArgs e)
        {
            btn_registrar_histo.Enabled = false;
            btn_cancelar_histo.Enabled = false;
            btn_nuevo_histo.Enabled = true;
            limpieza_cajasHistorial();
            Inhabilitar_CajasHistorial();
            btn_modificar_histo.Text = "Editar";
            btn_eliminar_histo.Enabled = false;
            lb_id_historial.Text = "";
            btn_modificar_histo.Enabled = false;
        }
        private void btn_modificar_histo_Click(object sender, EventArgs e)
        {
            btn_eliminar_histo.Enabled = false;
            if (btn_modificar_histo.Text.Equals("Editar"))
            {
                btn_modificar_histo.Text = "Guardar Cambios";
                Habilitar_CajasHistorial();
                btn_cancelar_histo.Enabled = true;

            }
            else
            {
                if (btn_modificar_histo.Text.Equals("Guardar Cambios"))
                {
                    Boolean band1 = false;
                    String mensaje = "Por Favor Complete los campos obligatorios : \n";
                    String descripcion = "";
                    Decimal precio;
                    int id_historial = Convert.ToInt32(lb_id_historial.Text);
                    DateTime f_historial = Convert.ToDateTime(fecha_historial.Text);
                    if (!String.IsNullOrEmpty(text_descripcion_histo.Text))
                    {
                        descripcion = text_descripcion_histo.Text;
                    }
                    else
                    {
                        mensaje = mensaje + "\n - Casilla de Descripcion";
                        band1 = true;
                    }
                    if (!String.IsNullOrEmpty(text_precio_histo.Text))
                    {
                        precio = Convert.ToDecimal(this.text_precio_histo.Text);
                    }
                    else
                    {
                        precio = 0;
                    }
                    if (band1 == true)
                    {
                        MessageBox.Show(mensaje);
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(this.lb_serie_mascota.Text))
                        {
                            int serie = int.Parse(lb_serie_mascota.Text);
                            int respuesta = new NHistorialClinico().N_Modificar_Historial_Clinico(f_historial, descripcion, precio, id_historial);
                            if (respuesta == 0)
                            {
                                MessageBox.Show("Error Al Guardar Por favor intente nuevamente");

                            }
                            else
                            {
                                MessageBox.Show("Cambios Guardados Correctamente");
                                Lista_HistorialClinicobyMascota(serie);
                                limpieza_cajasHistorial();
                                btn_registrar_histo.Enabled = false;
                                btn_cancelar_histo.Enabled = false;
                                btn_nuevo_histo.Enabled = true;
                                Inhabilitar_CajasHistorial();
                                this.lb_id_historial.Text = "";
                                this.btn_modificar_histo.Text = "Editar";
                                btn_modificar_histo.Enabled = false;

                            }
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio Un Error - Intente Nuevamente");
                        }
                    }
                }

            }
        }

        private void btn_eliminar_histo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que dese Eliminar?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id_historial = Convert.ToInt32(lb_id_historial.Text);
                int serie = int.Parse(lb_serie_mascota.Text);
                int respuesta = new NHistorialClinico().N_Eliminar_Historial_Clinico(id_historial);
                if (respuesta == 0)
                {
                    MessageBox.Show("Error Al Eliminar Por favor intente nuevamente");
                }
                else
                {
                    MessageBox.Show("Eliminado Correctamente");
                    Lista_HistorialClinicobyMascota(serie);
                    limpieza_cajasHistorial();
                    btn_registrar_histo.Enabled = false;
                    btn_cancelar_histo.Enabled = false;
                    btn_nuevo_histo.Enabled = true;
                    Inhabilitar_CajasHistorial();
                    this.lb_id_historial.Text = "";
                    this.btn_modificar_histo.Text = "Editar";
                    btn_modificar_histo.Enabled = false;
                    btn_eliminar_histo.Enabled = false;
                }
            }
        }


        private void grilla_historial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inhabilitar_CajasHistorial();
            lb_id_historial.Text = this.grilla_historial.CurrentRow.Cells[0].Value.ToString();
            fecha_historial.Text = this.grilla_historial.CurrentRow.Cells[1].Value.ToString();
            text_descripcion_histo.Text = this.grilla_historial.CurrentRow.Cells[2].Value.ToString();
            text_precio_histo.Text = this.grilla_historial.CurrentRow.Cells[3].Value.ToString();
            btn_registrar_histo.Enabled = false;
            btn_cancelar_histo.Enabled = false;
            btn_nuevo_histo.Enabled = true;
            btn_modificar_histo.Text = "Editar";
            btn_modificar_histo.Enabled = true;
            btn_eliminar_histo.Enabled = true;
        }

        #endregion
        #endregion

        #region vacunas
        #region metodos vacunas
        public void inhabilitar_cajas_Vacuna()
        {
            this.text_numero_vacuna.Enabled = false;
            this.text_observacion_vacuna.Enabled = false;
            this.text_precio_vacuna.Enabled = false;
            this.fecha_vacuna.Enabled = false;
        }
        public void habilitar_cajas_vacuna()
        {
            this.text_numero_vacuna.Enabled = true;
            this.text_observacion_vacuna.Enabled = true;
            this.text_precio_vacuna.Enabled = true;
            this.fecha_vacuna.Enabled = true;
        }
        public void limpiar_cajas_vacuna()
        {
            this.lb_id_vacuna.Text = "";
            this.text_numero_vacuna.Clear();
            this.text_observacion_vacuna.Clear();
            this.text_precio_vacuna.Clear();
            this.fecha_vacuna.Value = DateTime.Now;
        }
        public void Listar_Vacunas(int serie_mascota)
        {
            List<Vacuna> lista_vacuna = new NVacuna().N_Listar_Vacunas(serie_mascota);
            this.grilla_vacuna.Rows.Clear();
            for (int i = 0; i < lista_vacuna.Count; i++)
            {
                int reglon = this.grilla_vacuna.Rows.Add();
                this.grilla_vacuna.Rows[reglon].Cells["ID_VACUNA"].Value = lista_vacuna[i].Id.ToString();
                this.grilla_vacuna.Rows[reglon].Cells["NUMERO_VACUNA"].Value = lista_vacuna[i].Numero_vacuna;
                this.grilla_vacuna.Rows[reglon].Cells["FECH_VACUNA"].Value = lista_vacuna[i].Fecha.ToShortDateString();
                this.grilla_vacuna.Rows[reglon].Cells["OBSERVACION"].Value = lista_vacuna[i].Observacion;
                this.grilla_vacuna.Rows[reglon].Cells["PRECIO_VACUNA"].Value = lista_vacuna[i].Precio_Vacuna;

            }
        }
        #endregion
        #region eventos vacunas
        private void btn_nueva_vacuna_Click(object sender, EventArgs e)
        {
            habilitar_cajas_vacuna();
            limpiar_cajas_vacuna();
            btn_registrar_vacunas.Enabled = true;
            btn_Eliminar_vacunas.Enabled = false;
            btn_modificar_vacunas.Enabled = false;
            btn_cancelar_vacuna.Enabled = true;
            btn_nueva_vacuna.Enabled = true;
        }

        private void btn_registrar_vacunas_Click(object sender, EventArgs e)
        {
            Boolean band1 = false, band2 = false;
            String mensaje = "Por Favor Complete los campos obligatorios : \n";
            int Numero_vacuna = 0;
            String observacion = "";
            Decimal precio_vacuna;
            DateTime fecha_vacu = Convert.ToDateTime(fecha_vacuna.Text);
            if (!String.IsNullOrEmpty(text_observacion_vacuna.Text))
            {
                observacion = text_observacion_vacuna.Text;
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de Descripcion";
                band1 = true;
            }
            if (!String.IsNullOrEmpty(text_precio_vacuna.Text))
            {
                precio_vacuna = Convert.ToDecimal(this.text_precio_vacuna.Text);
            }
            else
            {
                precio_vacuna = 0;
            }
            if (!String.IsNullOrEmpty(text_numero_vacuna.Text))
            {
                Numero_vacuna = Convert.ToInt32(text_numero_vacuna.Text);
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de N°Vacuna";
                band2 = true;
            }


            if (band1 == true || band2 == true)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                if (!String.IsNullOrEmpty(this.lb_serie_mascota.Text))
                {
                    int serie_mascota = int.Parse(lb_serie_mascota.Text);
                    int respuesta2 = new NVacuna().N_Registrar_vacuna(serie_mascota, Numero_vacuna, fecha_vacu, observacion, precio_vacuna);
                    if (respuesta2 == 0)
                    {
                        MessageBox.Show("Error Al Registrar Por favor intente nuevamente");

                    }
                    else
                    {

                        MessageBox.Show("Registrado Correctamente");
                        limpiar_cajas_vacuna();
                        inhabilitar_cajas_Vacuna();
                        btn_registrar_vacunas.Enabled = false;
                        btn_cancelar_vacuna.Enabled = false;
                        btn_nueva_vacuna.Enabled = true;
                        int serie = Convert.ToInt32(this.lb_serie_mascota.Text);
                        Listar_Vacunas(serie);
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrio Un Error - Intente Nuevamente");
                }
            }
        }

        private void grilla_vacuna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            inhabilitar_cajas_Vacuna();
            limpiar_cajas_vacuna();
            lb_id_vacuna.Text = this.grilla_vacuna.CurrentRow.Cells[0].Value.ToString();
            text_numero_vacuna.Text = this.grilla_vacuna.CurrentRow.Cells[1].Value.ToString();
            fecha_vacuna.Text = this.grilla_vacuna.CurrentRow.Cells[2].Value.ToString();
            text_observacion_vacuna.Text = this.grilla_vacuna.CurrentRow.Cells[3].Value.ToString();
            this.text_precio_vacuna.Text = this.grilla_vacuna.CurrentRow.Cells[4].Value.ToString();
            btn_registrar_vacunas.Enabled = false;
            btn_cancelar_vacuna.Enabled = false;
            btn_nueva_vacuna.Enabled = true;
            btn_modificar_vacunas.Text = "Editar";
            btn_modificar_vacunas.Enabled = true;
            btn_Eliminar_vacunas.Enabled = true;
        }

        private void btn_cancelar_vacuna_Click(object sender, EventArgs e)
        {
            btn_registrar_vacunas.Enabled = false;
            btn_cancelar_vacuna.Enabled = false;
            btn_nueva_vacuna.Enabled = true;
            limpiar_cajas_vacuna();
            inhabilitar_cajas_Vacuna();
            btn_modificar_vacunas.Text = "Editar";
            btn_Eliminar_vacunas.Enabled = false;
            this.lb_id_vacuna.Text = "";
            btn_modificar_vacunas.Enabled = false;
        }

        private void btn_modificar_vacunas_Click(object sender, EventArgs e)
        {
            btn_Eliminar_vacunas.Enabled = false;
            if (btn_modificar_vacunas.Text.Equals("Editar"))
            {
                btn_modificar_vacunas.Text = "Guardar Cambios";
                habilitar_cajas_vacuna();
                btn_cancelar_vacuna.Enabled = true;

            }
            else
            {
                if (btn_modificar_vacunas.Text.Equals("Guardar Cambios"))
                {
                    Boolean band1 = false, band2 = false;
                    String mensaje = "Por Favor Complete los campos obligatorios : \n";
                    int Numero_vacuna = 0;
                    String observacion = "";
                    Decimal precio_vacuna;
                    DateTime fecha_vacu = Convert.ToDateTime(fecha_vacuna.Text);
                    if (!String.IsNullOrEmpty(text_observacion_vacuna.Text))
                    {
                        observacion = text_observacion_vacuna.Text;
                    }
                    else
                    {
                        mensaje = mensaje + "\n - Casilla de Descripcion";
                        band1 = true;
                    }
                    if (!String.IsNullOrEmpty(text_precio_vacuna.Text))
                    {
                        precio_vacuna = Convert.ToDecimal(this.text_precio_vacuna.Text);
                    }
                    else
                    {
                        precio_vacuna = 0;
                    }
                    if (!String.IsNullOrEmpty(text_numero_vacuna.Text))
                    {
                        Numero_vacuna = Convert.ToInt32(text_numero_vacuna.Text);
                    }
                    else
                    {
                        mensaje = mensaje + "\n - Casilla de N°Vacuna";
                        band2 = true;
                    }


                    if (band1 == true || band2 == true)
                    {
                        MessageBox.Show(mensaje);
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(this.lb_serie_mascota.Text))
                        {
                            int id_vacunas = Convert.ToInt32(lb_id_vacuna.Text);
                            int respuesta2 = new NVacuna().N_modificar_vacuna(id_vacunas, Numero_vacuna, fecha_vacu, observacion, precio_vacuna);
                            if (respuesta2 == 0)
                            {
                                MessageBox.Show("Error Al Guardar Por favor intente nuevamente");

                            }
                            else
                            {
                                MessageBox.Show("Cambios Guardados Correctamente");
                                limpiar_cajas_vacuna();
                                lb_id_vacuna.Text = "";
                                inhabilitar_cajas_Vacuna();
                                btn_registrar_vacunas.Enabled = false;
                                btn_cancelar_vacuna.Enabled = false;
                                btn_nueva_vacuna.Enabled = true;
                                btn_modificar_vacunas.Text = "Editar";
                                btn_modificar_vacunas.Enabled = false;
                                int serie = Convert.ToInt32(this.lb_serie_mascota.Text);
                                Listar_Vacunas(serie);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio Un Error - Intente Nuevamente");
                        }
                    }
                }
            }
        }

        private void btn_Eliminar_vacunas_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que dese Eliminar?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id_vacunas = Convert.ToInt32(lb_id_vacuna.Text);
                int serie = int.Parse(lb_serie_mascota.Text);
                int respuesta2 = new NVacuna().N_eliminar_vacuna(id_vacunas);
                if (respuesta2 == 0)
                {
                    MessageBox.Show("Error Al Eliminar Por favor intente nuevamente");
                }
                else
                {
                    MessageBox.Show("Eliminado Correctamente");
                    Listar_Vacunas(serie);
                    limpiar_cajas_vacuna();
                    btn_registrar_vacunas.Enabled = false;
                    btn_cancelar_vacuna.Enabled = false;
                    btn_nueva_vacuna.Enabled = true;
                    inhabilitar_cajas_Vacuna();
                    this.lb_id_vacuna.Text = "";
                    btn_modificar_vacunas.Text = "Editar";
                    btn_modificar_vacunas.Enabled = false;
                    btn_Eliminar_vacunas.Enabled = false;
                }
            }
        }
        #endregion
        #endregion


        public void habilitar_cajas_visita()
        {
            text_numero_visita.Enabled = true;
            fecha_visita.Enabled = true;
            text_observacion_visita.Enabled = true;
        }
        public void limpiar_cajas_visita()
        {
            this.lb_id_visita.Text = "";
            text_numero_visita.Clear();
            this.fecha_visita.Value = DateTime.Now;
            text_observacion_visita.Clear();

        }
        public void inhabilitar_cajas_visita()
        {
            text_numero_visita.Enabled = false;
            fecha_visita.Enabled = false;
            text_observacion_visita.Enabled = false;
        }
        public void listar_visitar_mascota(int serie_mascota)
        {
            List<Visita> lista_visita = new NVisita().N_Listar_visitas(serie_mascota);
            this.grilla_visita.Rows.Clear();
            for (int i = 0; i < lista_visita.Count; i++)
            {
                int reglon = this.grilla_visita.Rows.Add();
                this.grilla_visita.Rows[reglon].Cells["ID_VISITA"].Value = lista_visita[i].Id.ToString();
                this.grilla_visita.Rows[reglon].Cells["NUMERO_VISITA"].Value = lista_visita[i].Numero;
                this.grilla_visita.Rows[reglon].Cells["OBSERVACION_VISITA"].Value = lista_visita[i].Observacion;
                this.grilla_visita.Rows[reglon].Cells["FECHA_VISI"].Value = lista_visita[i].Fecha.ToShortDateString();
            }
        }

        private void F_FichaGeneral_Load(object sender, EventArgs e)
        {

            lb_etiqueta_nombre.Visible = false;
            lb_etiqueta_mascota.Visible = false;
            llenar_combo_tipoMascota();
            llenar_combo_temporales();
            llenar_combo_tamaño();



            //radio_recuperacion.Checked = true;
            //radio_conoce_no.Checked = true;
            //radio_macho.Checked = true;
            //radio_temporal_no.Checked = true;
            //radio_negativo.Checked = true;

            //btn_modificar_ficha.Enabled = false;
            //btn_eliminar_ficha.Enabled = false;
            //btn_registrar_ficha.Enabled = false;
            //btn_cancelar_registro.Enabled = false;
            tab_Historial.Parent = null;
            tab_vacunas.Parent = null;
            tab_Visitas.Parent = null;
            tab_fotos.Parent = null;
            Ver_serie_mascota();
            inicio_listar();
            combo_temporal.Enabled = false;
            Inhabilitar_CajasHistorial();
            //vacunas
            btn_cancelar_vacuna.Enabled = false;
            btn_registrar_vacunas.Enabled = false;
            btn_Eliminar_vacunas.Enabled = false;
            btn_modificar_vacunas.Enabled = false;
            btn_nueva_vacuna.Enabled = true;
            //visita



        }

        private void grilla_general_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            invalidar_todo();
            btn_modificar_ficha.Text = "Editar";
            limpiar_cajas();
            contador = 0;
            btn_modificar_ficha.Enabled = true;
            this.lb_serie_mascota.Text = this.grilla_general.CurrentRow.Cells[2].Value.ToString();
            this.mostra_serie_masco.Text = this.grilla_general.CurrentRow.Cells[0].Value.ToString();
            this.lb_id_usuario.Text = this.grilla_general.CurrentRow.Cells[1].Value.ToString();
            this.text_codigo.Text = this.grilla_general.CurrentRow.Cells[3].Value.ToString();
            this.text_nombre_rescatista.Text = this.grilla_general.CurrentRow.Cells[4].Value.ToString();
            this.pictureBox1.Image = null;
            
            String id_tempo = this.grilla_general.CurrentRow.Cells[5].Value.ToString();
            if (!String.IsNullOrEmpty(id_tempo))
            {
                int id_verdadero = Convert.ToInt32(id_tempo);
                for (int i = 0; i < combo_temporal.Items.Count; i++)
                {
                    FichaTemporal ficha = (FichaTemporal)combo_temporal.Items[i];
                    if (ficha.Id == id_verdadero)
                    {
                        combo_temporal.SelectedIndex = i;
                        radio_temporal_si.Checked = true;
                        combo_temporal.Enabled = false;
                        break;
                    }
                }

            }
            else
            {
                radio_temporal_no.Checked = true;
            }


            this.fecha_ingreso.Text = this.grilla_general.CurrentRow.Cells[6].Value.ToString();
            int id_tipo = Convert.ToInt32(this.grilla_general.CurrentRow.Cells[7].Value.ToString());
            for (int i = 0; i < combo_tipo.Items.Count; i++)
            {
                TipoMascota tipo = (TipoMascota)combo_tipo.Items[i];
                if (tipo.Id == id_tipo)
                {
                    combo_tipo.SelectedIndex = i;
                    break;
                }
            }
            String tamano = this.grilla_general.CurrentRow.Cells[9].Value.ToString();
            if (tamano.Equals("Pequeño"))
            {
                combo_tamaño.SelectedIndex = 0;
            }
            else
            {
                if (tamano.Equals("Mediano"))
                {
                    combo_tamaño.SelectedIndex = 1;
                }
                else
                {
                    if (tamano.Equals("Grande"))
                    {
                        combo_tamaño.SelectedIndex = 2;
                    }
                }
            }

            String estado = this.grilla_general.CurrentRow.Cells[10].Value.ToString();
            if (estado.Equals("En Recuperacion"))
            {
                radio_recuperacion.Checked = true;
            }
            else
            {
                if (estado.Equals("Apto"))
                {
                    radio_apto.Checked = true;
                }
                else
                {
                    if (estado.Equals("Adoptado"))
                    {
                        radio_adoptado.Checked = true;
                    }

                }
            }
            this.text_nombre.Text = this.grilla_general.CurrentRow.Cells[11].Value.ToString();
            this.text_raza.Text = this.grilla_general.CurrentRow.Cells[12].Value.ToString();
            lb_etiqueta_nombre.Visible = true;
            lb_etiqueta_mascota.Visible = true;
            lb_etiqueta_mascota.Text = "" + text_nombre.Text;
            String sexo = this.grilla_general.CurrentRow.Cells[13].Value.ToString();
            if (sexo.Equals("Macho"))
            {
                radio_macho.Checked = true;
            }
            else
            {
                if (sexo.Equals("Hembra"))
                {
                    radio_hembra.Checked = true;
                }
            }
            this.text_color.Text = this.grilla_general.CurrentRow.Cells[14].Value.ToString();
            this.text_edad.Text = this.grilla_general.CurrentRow.Cells[15].Value.ToString();
            String esterilizado = this.grilla_general.CurrentRow.Cells[16].Value.ToString();
            if (esterilizado.Equals("Si"))
            {
                radio_afirmativo.Checked = true;
                int id_serie = Convert.ToInt32(lb_serie_mascota.Text);
                String fech = new NMascota().N_Ver_FechaEsterilizacion(id_serie);
                if (!String.IsNullOrEmpty(fech))
                {
                    radio_conoce_si.Checked = true;
                    this.fecha_esterilizacion.Text = fech;
                }
                else
                {
                    radio_conoce_no.Checked = true;
                }
            }
            else
            {
                if (esterilizado.Equals("No"))
                {
                    radio_negativo.Checked = true;
                }
            }
            //historial clinico
            int idserieMascota = Convert.ToInt32(this.lb_serie_mascota.Text);
            activar_tabs();
            Lista_HistorialClinicobyMascota(idserieMascota);
            #region inicio_fotos
            listar_imagenes(idserieMascota);
            inicio();
            cargar_inciobotones();
            #endregion
            btn_registrar_ficha.Enabled = false;
            btn_cancelar_registro.Enabled = false;
            #region opciones historial clinico
            limpieza_cajasHistorial();
            Inhabilitar_CajasHistorial();
            btn_nuevo_histo.Enabled = true;
            btn_registrar_histo.Enabled = false;
            btn_modificar_histo.Enabled = false;
            btn_eliminar_histo.Enabled = false;
            btn_cancelar_histo.Enabled = false;

            #endregion
            #region vacunas
            Listar_Vacunas(idserieMascota);
            #endregion
            #region visitas
            listar_visitar_mascota(idserieMascota);
            #endregion
            btn_verDatos.Enabled = true;
            btn_eliminar_ficha.Enabled = true;


        }



        private void btn_nuevo_visita_Click(object sender, EventArgs e)
        {
            habilitar_cajas_visita();
            limpiar_cajas_visita();
            btn_registrar_visita.Enabled = true;
            btn_eliminar_visita.Enabled = false;
            btn_modificar_visita.Enabled = false;
            btn_cancelar_visita.Enabled = true;
            btn_nuevo_visita.Enabled = true;
        }

        private void btn_registrar_visita_Click(object sender, EventArgs e)
        {
            Boolean band1 = false;
            String mensaje = "Por Favor Complete los campos obligatorios : \n";
            int Numero_visita = 0;
            String observacion_visita = "";
            DateTime fecha_visi = Convert.ToDateTime(fecha_visita.Text);
            if (!String.IsNullOrEmpty(text_observacion_visita.Text))
            {
                observacion_visita = text_observacion_visita.Text;
            }
            if (!String.IsNullOrEmpty(text_numero_visita.Text))
            {
                Numero_visita = Convert.ToInt32(text_numero_visita.Text);
            }
            else
            {
                mensaje = mensaje + "\n - Casilla de N°Visita";
                band1 = true;
            }


            if (band1 == true)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                if (!String.IsNullOrEmpty(this.lb_serie_mascota.Text))
                {
                    int serie_mascota = int.Parse(lb_serie_mascota.Text);
                    int respuesta3 = new NVisita().N_registrar_visita(serie_mascota, Numero_visita, observacion_visita, fecha_visi);
                    if (respuesta3 == 0)
                    {
                        MessageBox.Show("Error Al Registrar Por favor intente nuevamente");

                    }
                    else
                    {
                        MessageBox.Show("Registrado Correctamente");
                        limpiar_cajas_visita();
                        inhabilitar_cajas_visita();
                        btn_registrar_visita.Enabled = false;
                        btn_cancelar_visita.Enabled = false;
                        btn_nueva_vacuna.Enabled = true;
                        int serie_masco = Convert.ToInt32(this.lb_serie_mascota.Text);
                        listar_visitar_mascota(serie_masco);

                    }
                }
                else
                {
                    MessageBox.Show("Ocurrio Un Error - Intente Nuevamente");
                }
            }
        }

        private void grilla_visita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            inhabilitar_cajas_visita();
            limpiar_cajas_visita();
            lb_id_visita.Text = this.grilla_visita.CurrentRow.Cells[0].Value.ToString();
            text_numero_visita.Text = this.grilla_visita.CurrentRow.Cells[1].Value.ToString();
            text_observacion_visita.Text = this.grilla_visita.CurrentRow.Cells[2].Value.ToString();
            fecha_visita.Text = this.grilla_visita.CurrentRow.Cells[3].Value.ToString();
            btn_registrar_visita.Enabled = false;
            btn_cancelar_visita.Enabled = false;
            btn_nuevo_visita.Enabled = true;
            btn_modificar_visita.Text = "Editar";
            btn_modificar_visita.Enabled = true;
            btn_eliminar_visita.Enabled = true;

        }

        private void btn_cancelar_visita_Click(object sender, EventArgs e)
        {
            btn_registrar_visita.Enabled = false;
            btn_cancelar_visita.Enabled = false;
            btn_nuevo_visita.Enabled = true;
            limpiar_cajas_visita();
            inhabilitar_cajas_visita();
            btn_modificar_visita.Text = "Editar";
            btn_eliminar_visita.Enabled = false;
            this.lb_id_visita.Text = "";
            btn_modificar_visita.Enabled = false;
        }

        private void btn_modificar_visita_Click(object sender, EventArgs e)
        {
            btn_eliminar_visita.Enabled = false;
            if (btn_modificar_visita.Text.Equals("Editar"))
            {
                btn_modificar_visita.Text = "Guardar Cambios";
                habilitar_cajas_visita();
                btn_cancelar_visita.Enabled = true;

            }
            else
            {
                Boolean band1 = false;
                String mensaje = "Por Favor Complete los campos obligatorios : \n";
                int Numero_visita = 0;
                String observacion_visita = "";
                DateTime fecha_visi = Convert.ToDateTime(fecha_visita.Text);
                if (!String.IsNullOrEmpty(text_observacion_visita.Text))
                {
                    observacion_visita = text_observacion_visita.Text;
                }
                if (!String.IsNullOrEmpty(text_numero_visita.Text))
                {
                    Numero_visita = Convert.ToInt32(text_numero_visita.Text);
                }
                else
                {
                    mensaje = mensaje + "\n - Casilla de N°Visita";
                    band1 = true;
                }


                if (band1 == true)
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    if (!String.IsNullOrEmpty(this.lb_serie_mascota.Text))
                    {
                        int serie_mascota = int.Parse(lb_serie_mascota.Text);
                        int id_visita = int.Parse(lb_id_visita.Text);
                        int respuesta3 = new NVisita().N_modificar_visita(id_visita, Numero_visita, observacion_visita, fecha_visi);
                        if (respuesta3 == 0)
                        {
                            MessageBox.Show("Error Al Guardar Por favor intente nuevamente");

                        }
                        else
                        {
                            MessageBox.Show("Cambios Guardados Correctamente");
                            limpiar_cajas_visita();
                            lb_id_visita.Text = "";
                            inhabilitar_cajas_visita();
                            btn_registrar_visita.Enabled = false;
                            btn_cancelar_visita.Enabled = false;
                            btn_nuevo_visita.Enabled = true;
                            btn_modificar_visita.Text = "Editar";
                            btn_modificar_visita.Enabled = false;
                            int serie = Convert.ToInt32(this.lb_serie_mascota.Text);
                            listar_visitar_mascota(serie);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio Un Error - Intente Nuevamente");
                    }
                }
            }
        }

        private void btn_eliminar_visita_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que dese Eliminar?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id_visitas = Convert.ToInt32(lb_id_visita.Text);
                int serie = int.Parse(lb_serie_mascota.Text);
                int respuesta2 = new NVisita().N_eliminar_visita(id_visitas);
                if (respuesta2 == 0)
                {
                    MessageBox.Show("Error Al Eliminar Por favor intente nuevamente");
                }
                else
                {
                    MessageBox.Show("Eliminado Correctamente");
                    listar_visitar_mascota(serie);
                    limpiar_cajas_visita();
                    btn_registrar_visita.Enabled = false;
                    btn_cancelar_visita.Enabled = false;
                    btn_nuevo_visita.Enabled = true;
                    inhabilitar_cajas_visita();
                    this.lb_id_visita.Text = "";
                    btn_modificar_visita.Text = "Editar";
                    btn_modificar_visita.Enabled = false;
                    btn_eliminar_visita.Enabled = false;

                }
            }
        }

        private void btn_eliminar_ficha_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que dese Eliminar?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int serie = int.Parse(lb_serie_mascota.Text);
                int respuesta2 = new NMascota().N_eliminar_mascota(serie);
                if (respuesta2 == 0)
                {
                    MessageBox.Show("Error Al Eliminar Por favor intente nuevamente");
                }
                else
                {
                    MessageBox.Show("Eliminado Correctamente");
                    
                    lb_etiqueta_nombre.Visible = false;
                    lb_etiqueta_mascota.Visible = false;
                    lb_etiqueta_mascota.Text = "";
                    lb_id_usuario.Text = "";
                    lb_serie_mascota.Text = "";
                    tab_Historial.Parent = null;
                    tab_vacunas.Parent = null;
                    tab_Visitas.Parent = null;
                    tab_fotos.Parent = null;
                    Ver_serie_mascota();
                    limpiar_cajas();
                    invalidar_todo();
                    btn_registrar_ficha.Enabled = true;
                    btn_cancelar_registro.Enabled = true;
                    btn_eliminar_ficha.Enabled = false;
                    btn_modificar_ficha.Enabled = false;
                    if (radio_negativo.Checked == true)
                    {
                        group_conoce.Enabled = false;
                        radio_conoce_no.Checked = true;
                        fecha_esterilizacion.Enabled = false;
                    }
                    btn_modificar_visita.Text = "Editar";
                    inicio_listar();


                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
