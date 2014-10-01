namespace App_Ecoanimalia_Piura.Graficos
{
    partial class F_FichaAdopcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_persona = new System.Windows.Forms.ComboBox();
            this.btn_nueva_persona = new System.Windows.Forms.Button();
            this.btn_buscar_persona = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_voluntarios = new System.Windows.Forms.ComboBox();
            this.btn_buscar_voluntario = new System.Windows.Forms.Button();
            this.lb_id_ficha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fech_adopcion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_observacion_ficha = new System.Windows.Forms.TextBox();
            this.combo_mascota = new System.Windows.Forms.ComboBox();
            this.btn_buscar_mascota = new System.Windows.Forms.Button();
            this.text_nombre_adoptarse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grupo_estado = new System.Windows.Forms.GroupBox();
            this.radio_inactivo = new System.Windows.Forms.RadioButton();
            this.radio_activo = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.text_observacion_mascota = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_agregar_mascota = new System.Windows.Forms.Button();
            this.grilla_detalle = new System.Windows.Forms.DataGridView();
            this.btn_modificar_mascota = new System.Windows.Forms.Button();
            this.btn_eliminar_mascota = new System.Windows.Forms.Button();
            this.btn_cancelar_mascota = new System.Windows.Forms.Button();
            this.btn_registrar_ficha = new System.Windows.Forms.Button();
            this.btn_editar_ficha = new System.Windows.Forms.Button();
            this.btn_nueva_ficha = new System.Windows.Forms.Button();
            this.btn_nuevo_mascota = new System.Windows.Forms.Button();
            this.btn_cancelar_ficha = new System.Windows.Forms.Button();
            this.btn_eliminar_ficha = new System.Windows.Forms.Button();
            this.text_relacion = new System.Windows.Forms.TextBox();
            this.btn_listar_ficha = new System.Windows.Forms.Button();
            this.btn_terminar_ficha = new System.Windows.Forms.Button();
            this.grupo_estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Fichas de Adopcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADOPTANTE :";
            // 
            // combo_persona
            // 
            this.combo_persona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_persona.Enabled = false;
            this.combo_persona.FormattingEnabled = true;
            this.combo_persona.Location = new System.Drawing.Point(168, 87);
            this.combo_persona.Name = "combo_persona";
            this.combo_persona.Size = new System.Drawing.Size(230, 21);
            this.combo_persona.TabIndex = 2;
            // 
            // btn_nueva_persona
            // 
            this.btn_nueva_persona.Enabled = false;
            this.btn_nueva_persona.Location = new System.Drawing.Point(404, 78);
            this.btn_nueva_persona.Name = "btn_nueva_persona";
            this.btn_nueva_persona.Size = new System.Drawing.Size(112, 36);
            this.btn_nueva_persona.TabIndex = 3;
            this.btn_nueva_persona.Text = "Registrar Nueva Adoptante";
            this.btn_nueva_persona.UseVisualStyleBackColor = true;
            this.btn_nueva_persona.Click += new System.EventHandler(this.btn_nueva_persona_Click);
            // 
            // btn_buscar_persona
            // 
            this.btn_buscar_persona.Enabled = false;
            this.btn_buscar_persona.Location = new System.Drawing.Point(531, 78);
            this.btn_buscar_persona.Name = "btn_buscar_persona";
            this.btn_buscar_persona.Size = new System.Drawing.Size(89, 36);
            this.btn_buscar_persona.TabIndex = 4;
            this.btn_buscar_persona.Text = "Buscar Adoptante";
            this.btn_buscar_persona.UseVisualStyleBackColor = true;
            this.btn_buscar_persona.Click += new System.EventHandler(this.btn_buscar_persona_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "VOLUNTARIO :";
            // 
            // combo_voluntarios
            // 
            this.combo_voluntarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_voluntarios.Enabled = false;
            this.combo_voluntarios.FormattingEnabled = true;
            this.combo_voluntarios.Location = new System.Drawing.Point(168, 167);
            this.combo_voluntarios.Name = "combo_voluntarios";
            this.combo_voluntarios.Size = new System.Drawing.Size(281, 21);
            this.combo_voluntarios.TabIndex = 6;
            // 
            // btn_buscar_voluntario
            // 
            this.btn_buscar_voluntario.Enabled = false;
            this.btn_buscar_voluntario.Location = new System.Drawing.Point(465, 153);
            this.btn_buscar_voluntario.Name = "btn_buscar_voluntario";
            this.btn_buscar_voluntario.Size = new System.Drawing.Size(112, 46);
            this.btn_buscar_voluntario.TabIndex = 7;
            this.btn_buscar_voluntario.Text = "Buscar Voluntario";
            this.btn_buscar_voluntario.UseVisualStyleBackColor = true;
            this.btn_buscar_voluntario.Click += new System.EventHandler(this.btn_buscar_voluntario_Click);
            // 
            // lb_id_ficha
            // 
            this.lb_id_ficha.AutoSize = true;
            this.lb_id_ficha.Location = new System.Drawing.Point(65, 22);
            this.lb_id_ficha.Name = "lb_id_ficha";
            this.lb_id_ficha.Size = new System.Drawing.Size(58, 13);
            this.lb_id_ficha.TabIndex = 8;
            this.lb_id_ficha.Text = "lb_id_ficha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(751, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "RELACION CON \r\nEL VOLUNTARIO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "OBSERVACIONES :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(754, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "FECHA DE ADOPCION :";
            // 
            // fech_adopcion
            // 
            this.fech_adopcion.Enabled = false;
            this.fech_adopcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fech_adopcion.Location = new System.Drawing.Point(885, 217);
            this.fech_adopcion.Name = "fech_adopcion";
            this.fech_adopcion.Size = new System.Drawing.Size(200, 20);
            this.fech_adopcion.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "DETALLE DE ADOPCION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "MASCOTA :";
            // 
            // text_observacion_ficha
            // 
            this.text_observacion_ficha.Enabled = false;
            this.text_observacion_ficha.Location = new System.Drawing.Point(883, 120);
            this.text_observacion_ficha.Multiline = true;
            this.text_observacion_ficha.Name = "text_observacion_ficha";
            this.text_observacion_ficha.Size = new System.Drawing.Size(230, 68);
            this.text_observacion_ficha.TabIndex = 12;
            // 
            // combo_mascota
            // 
            this.combo_mascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_mascota.Enabled = false;
            this.combo_mascota.FormattingEnabled = true;
            this.combo_mascota.Location = new System.Drawing.Point(168, 300);
            this.combo_mascota.Name = "combo_mascota";
            this.combo_mascota.Size = new System.Drawing.Size(230, 21);
            this.combo_mascota.TabIndex = 18;
            // 
            // btn_buscar_mascota
            // 
            this.btn_buscar_mascota.Enabled = false;
            this.btn_buscar_mascota.Location = new System.Drawing.Point(404, 292);
            this.btn_buscar_mascota.Name = "btn_buscar_mascota";
            this.btn_buscar_mascota.Size = new System.Drawing.Size(104, 35);
            this.btn_buscar_mascota.TabIndex = 19;
            this.btn_buscar_mascota.Text = "Buscar Mascota";
            this.btn_buscar_mascota.UseVisualStyleBackColor = true;
            this.btn_buscar_mascota.Click += new System.EventHandler(this.btn_buscar_mascota_Click);
            // 
            // text_nombre_adoptarse
            // 
            this.text_nombre_adoptarse.Enabled = false;
            this.text_nombre_adoptarse.Location = new System.Drawing.Point(168, 351);
            this.text_nombre_adoptarse.Name = "text_nombre_adoptarse";
            this.text_nombre_adoptarse.Size = new System.Drawing.Size(230, 20);
            this.text_nombre_adoptarse.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "NOMBRE AL\r\nADOPTARSE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(520, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "ESTADO :";
            // 
            // grupo_estado
            // 
            this.grupo_estado.Controls.Add(this.radio_inactivo);
            this.grupo_estado.Controls.Add(this.radio_activo);
            this.grupo_estado.Enabled = false;
            this.grupo_estado.Location = new System.Drawing.Point(640, 285);
            this.grupo_estado.Name = "grupo_estado";
            this.grupo_estado.Size = new System.Drawing.Size(166, 39);
            this.grupo_estado.TabIndex = 23;
            this.grupo_estado.TabStop = false;
            // 
            // radio_inactivo
            // 
            this.radio_inactivo.AutoSize = true;
            this.radio_inactivo.Checked = true;
            this.radio_inactivo.Location = new System.Drawing.Point(83, 15);
            this.radio_inactivo.Name = "radio_inactivo";
            this.radio_inactivo.Size = new System.Drawing.Size(63, 17);
            this.radio_inactivo.TabIndex = 1;
            this.radio_inactivo.TabStop = true;
            this.radio_inactivo.Text = "Inactivo";
            this.radio_inactivo.UseVisualStyleBackColor = true;
            // 
            // radio_activo
            // 
            this.radio_activo.AutoSize = true;
            this.radio_activo.Location = new System.Drawing.Point(7, 15);
            this.radio_activo.Name = "radio_activo";
            this.radio_activo.Size = new System.Drawing.Size(55, 17);
            this.radio_activo.TabIndex = 0;
            this.radio_activo.Text = "Activo";
            this.radio_activo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(520, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "OBSERVACION :";
            // 
            // text_observacion_mascota
            // 
            this.text_observacion_mascota.Enabled = false;
            this.text_observacion_mascota.Location = new System.Drawing.Point(640, 343);
            this.text_observacion_mascota.Multiline = true;
            this.text_observacion_mascota.Name = "text_observacion_mascota";
            this.text_observacion_mascota.Size = new System.Drawing.Size(202, 55);
            this.text_observacion_mascota.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "LISTADO DE MASCOTAS ADOPTADAS EN LA FICHA";
            // 
            // btn_agregar_mascota
            // 
            this.btn_agregar_mascota.Location = new System.Drawing.Point(151, 412);
            this.btn_agregar_mascota.Name = "btn_agregar_mascota";
            this.btn_agregar_mascota.Size = new System.Drawing.Size(107, 37);
            this.btn_agregar_mascota.TabIndex = 27;
            this.btn_agregar_mascota.Text = "Agregar Mascota";
            this.btn_agregar_mascota.UseVisualStyleBackColor = true;
            this.btn_agregar_mascota.Click += new System.EventHandler(this.btn_agregar_mascota_Click);
            // 
            // grilla_detalle
            // 
            this.grilla_detalle.AllowUserToAddRows = false;
            this.grilla_detalle.AllowUserToDeleteRows = false;
            this.grilla_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_detalle.Location = new System.Drawing.Point(65, 518);
            this.grilla_detalle.Name = "grilla_detalle";
            this.grilla_detalle.ReadOnly = true;
            this.grilla_detalle.Size = new System.Drawing.Size(523, 150);
            this.grilla_detalle.TabIndex = 28;
            // 
            // btn_modificar_mascota
            // 
            this.btn_modificar_mascota.Location = new System.Drawing.Point(276, 412);
            this.btn_modificar_mascota.Name = "btn_modificar_mascota";
            this.btn_modificar_mascota.Size = new System.Drawing.Size(94, 37);
            this.btn_modificar_mascota.TabIndex = 30;
            this.btn_modificar_mascota.Text = "Editar Mascota";
            this.btn_modificar_mascota.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_mascota
            // 
            this.btn_eliminar_mascota.Location = new System.Drawing.Point(392, 412);
            this.btn_eliminar_mascota.Name = "btn_eliminar_mascota";
            this.btn_eliminar_mascota.Size = new System.Drawing.Size(95, 37);
            this.btn_eliminar_mascota.TabIndex = 31;
            this.btn_eliminar_mascota.Text = "Eliminar Mascota";
            this.btn_eliminar_mascota.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar_mascota
            // 
            this.btn_cancelar_mascota.Location = new System.Drawing.Point(510, 412);
            this.btn_cancelar_mascota.Name = "btn_cancelar_mascota";
            this.btn_cancelar_mascota.Size = new System.Drawing.Size(100, 37);
            this.btn_cancelar_mascota.TabIndex = 32;
            this.btn_cancelar_mascota.Text = "Cancelar";
            this.btn_cancelar_mascota.UseVisualStyleBackColor = true;
            // 
            // btn_registrar_ficha
            // 
            this.btn_registrar_ficha.Location = new System.Drawing.Point(861, 460);
            this.btn_registrar_ficha.Name = "btn_registrar_ficha";
            this.btn_registrar_ficha.Size = new System.Drawing.Size(110, 42);
            this.btn_registrar_ficha.TabIndex = 33;
            this.btn_registrar_ficha.Text = "Registrar Ficha Adopcion";
            this.btn_registrar_ficha.UseVisualStyleBackColor = true;
            this.btn_registrar_ficha.Click += new System.EventHandler(this.btn_registrar_ficha_Click);
            // 
            // btn_editar_ficha
            // 
            this.btn_editar_ficha.Location = new System.Drawing.Point(861, 544);
            this.btn_editar_ficha.Name = "btn_editar_ficha";
            this.btn_editar_ficha.Size = new System.Drawing.Size(110, 45);
            this.btn_editar_ficha.TabIndex = 34;
            this.btn_editar_ficha.Text = "Editar Ficha Adopcion";
            this.btn_editar_ficha.UseVisualStyleBackColor = true;
            this.btn_editar_ficha.Click += new System.EventHandler(this.btn_editar_ficha_Click);
            // 
            // btn_nueva_ficha
            // 
            this.btn_nueva_ficha.Location = new System.Drawing.Point(688, 544);
            this.btn_nueva_ficha.Name = "btn_nueva_ficha";
            this.btn_nueva_ficha.Size = new System.Drawing.Size(110, 45);
            this.btn_nueva_ficha.TabIndex = 35;
            this.btn_nueva_ficha.Text = "Nueva Ficha Adopcion";
            this.btn_nueva_ficha.UseVisualStyleBackColor = true;
            this.btn_nueva_ficha.Click += new System.EventHandler(this.btn_nueva_ficha_Click);
            // 
            // btn_nuevo_mascota
            // 
            this.btn_nuevo_mascota.Location = new System.Drawing.Point(23, 412);
            this.btn_nuevo_mascota.Name = "btn_nuevo_mascota";
            this.btn_nuevo_mascota.Size = new System.Drawing.Size(107, 37);
            this.btn_nuevo_mascota.TabIndex = 36;
            this.btn_nuevo_mascota.Text = "Nuevo";
            this.btn_nuevo_mascota.UseVisualStyleBackColor = true;
            this.btn_nuevo_mascota.Click += new System.EventHandler(this.btn_nuevo_mascota_Click);
            // 
            // btn_cancelar_ficha
            // 
            this.btn_cancelar_ficha.Location = new System.Drawing.Point(688, 614);
            this.btn_cancelar_ficha.Name = "btn_cancelar_ficha";
            this.btn_cancelar_ficha.Size = new System.Drawing.Size(110, 46);
            this.btn_cancelar_ficha.TabIndex = 37;
            this.btn_cancelar_ficha.Text = "Cancelar";
            this.btn_cancelar_ficha.UseVisualStyleBackColor = true;
            this.btn_cancelar_ficha.Click += new System.EventHandler(this.btn_cancelar_ficha_Click);
            // 
            // btn_eliminar_ficha
            // 
            this.btn_eliminar_ficha.Location = new System.Drawing.Point(861, 614);
            this.btn_eliminar_ficha.Name = "btn_eliminar_ficha";
            this.btn_eliminar_ficha.Size = new System.Drawing.Size(110, 46);
            this.btn_eliminar_ficha.TabIndex = 38;
            this.btn_eliminar_ficha.Text = "Eliminar Ficha Adopcion";
            this.btn_eliminar_ficha.UseVisualStyleBackColor = true;
            // 
            // text_relacion
            // 
            this.text_relacion.Enabled = false;
            this.text_relacion.Location = new System.Drawing.Point(883, 84);
            this.text_relacion.Name = "text_relacion";
            this.text_relacion.Size = new System.Drawing.Size(202, 20);
            this.text_relacion.TabIndex = 39;
            // 
            // btn_listar_ficha
            // 
            this.btn_listar_ficha.Location = new System.Drawing.Point(688, 457);
            this.btn_listar_ficha.Name = "btn_listar_ficha";
            this.btn_listar_ficha.Size = new System.Drawing.Size(110, 45);
            this.btn_listar_ficha.TabIndex = 40;
            this.btn_listar_ficha.Text = "Lista de Fichas";
            this.btn_listar_ficha.UseVisualStyleBackColor = true;
            this.btn_listar_ficha.Click += new System.EventHandler(this.btn_listar_ficha_Click);
            // 
            // btn_terminar_ficha
            // 
            this.btn_terminar_ficha.Location = new System.Drawing.Point(1003, 566);
            this.btn_terminar_ficha.Name = "btn_terminar_ficha";
            this.btn_terminar_ficha.Size = new System.Drawing.Size(100, 42);
            this.btn_terminar_ficha.TabIndex = 41;
            this.btn_terminar_ficha.Text = "Terminar Ficha";
            this.btn_terminar_ficha.UseVisualStyleBackColor = true;
            // 
            // F_FichaAdopcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 698);
            this.Controls.Add(this.btn_terminar_ficha);
            this.Controls.Add(this.btn_listar_ficha);
            this.Controls.Add(this.text_relacion);
            this.Controls.Add(this.btn_eliminar_ficha);
            this.Controls.Add(this.btn_cancelar_ficha);
            this.Controls.Add(this.btn_nuevo_mascota);
            this.Controls.Add(this.btn_nueva_ficha);
            this.Controls.Add(this.btn_editar_ficha);
            this.Controls.Add(this.btn_registrar_ficha);
            this.Controls.Add(this.btn_cancelar_mascota);
            this.Controls.Add(this.btn_eliminar_mascota);
            this.Controls.Add(this.btn_modificar_mascota);
            this.Controls.Add(this.grilla_detalle);
            this.Controls.Add(this.btn_agregar_mascota);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.text_observacion_mascota);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grupo_estado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text_nombre_adoptarse);
            this.Controls.Add(this.btn_buscar_mascota);
            this.Controls.Add(this.combo_mascota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fech_adopcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_observacion_ficha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_id_ficha);
            this.Controls.Add(this.btn_buscar_voluntario);
            this.Controls.Add(this.combo_voluntarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_buscar_persona);
            this.Controls.Add(this.btn_nueva_persona);
            this.Controls.Add(this.combo_persona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_FichaAdopcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "l";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_FichaAdopcion_Load);
            this.grupo_estado.ResumeLayout(false);
            this.grupo_estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_persona;
        private System.Windows.Forms.Button btn_nueva_persona;
        private System.Windows.Forms.Button btn_buscar_persona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_voluntarios;
        private System.Windows.Forms.Button btn_buscar_voluntario;
        private System.Windows.Forms.Label lb_id_ficha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fech_adopcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_observacion_ficha;
        private System.Windows.Forms.ComboBox combo_mascota;
        private System.Windows.Forms.Button btn_buscar_mascota;
        private System.Windows.Forms.TextBox text_nombre_adoptarse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grupo_estado;
        private System.Windows.Forms.RadioButton radio_activo;
        private System.Windows.Forms.RadioButton radio_inactivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_observacion_mascota;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_agregar_mascota;
        private System.Windows.Forms.DataGridView grilla_detalle;
        private System.Windows.Forms.Button btn_modificar_mascota;
        private System.Windows.Forms.Button btn_eliminar_mascota;
        private System.Windows.Forms.Button btn_cancelar_mascota;
        private System.Windows.Forms.Button btn_registrar_ficha;
        private System.Windows.Forms.Button btn_editar_ficha;
        private System.Windows.Forms.Button btn_nueva_ficha;
        private System.Windows.Forms.Button btn_nuevo_mascota;
        private System.Windows.Forms.Button btn_cancelar_ficha;
        private System.Windows.Forms.Button btn_eliminar_ficha;
        private System.Windows.Forms.TextBox text_relacion;
        private System.Windows.Forms.Button btn_listar_ficha;
        private System.Windows.Forms.Button btn_terminar_ficha;
    }
}