namespace App_Ecoanimalia_Piura.Graficos
{
    partial class F_ListarFichasAdopcion
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
            this.grilla_fichaAdopcion = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PERSONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voluntario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI_ADOPTANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adoptante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.text_buscar_fichaAdopcion = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_fichaAdopcion)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_fichaAdopcion
            // 
            this.grilla_fichaAdopcion.AllowUserToAddRows = false;
            this.grilla_fichaAdopcion.AllowUserToDeleteRows = false;
            this.grilla_fichaAdopcion.AllowUserToResizeRows = false;
            this.grilla_fichaAdopcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_fichaAdopcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_PERSONA,
            this.SERIE,
            this.Codigo_usuario,
            this.Voluntario,
            this.DNI_ADOPTANTE,
            this.Adoptante,
            this.Relacion,
            this.Observaciones,
            this.Fecha});
            this.grilla_fichaAdopcion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grilla_fichaAdopcion.Location = new System.Drawing.Point(12, 82);
            this.grilla_fichaAdopcion.Name = "grilla_fichaAdopcion";
            this.grilla_fichaAdopcion.ReadOnly = true;
            this.grilla_fichaAdopcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_fichaAdopcion.Size = new System.Drawing.Size(733, 262);
            this.grilla_fichaAdopcion.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ID_PERSONA
            // 
            this.ID_PERSONA.HeaderText = "ID_PERSONA";
            this.ID_PERSONA.Name = "ID_PERSONA";
            this.ID_PERSONA.ReadOnly = true;
            this.ID_PERSONA.Visible = false;
            // 
            // SERIE
            // 
            this.SERIE.HeaderText = "Serie Voluntario";
            this.SERIE.Name = "SERIE";
            this.SERIE.ReadOnly = true;
            this.SERIE.Visible = false;
            // 
            // Codigo_usuario
            // 
            this.Codigo_usuario.HeaderText = "Codigo Usuario";
            this.Codigo_usuario.Name = "Codigo_usuario";
            this.Codigo_usuario.ReadOnly = true;
            // 
            // Voluntario
            // 
            this.Voluntario.HeaderText = "Nombres Voluntario";
            this.Voluntario.Name = "Voluntario";
            this.Voluntario.ReadOnly = true;
            // 
            // DNI_ADOPTANTE
            // 
            this.DNI_ADOPTANTE.HeaderText = "DNI Adoptante";
            this.DNI_ADOPTANTE.Name = "DNI_ADOPTANTE";
            this.DNI_ADOPTANTE.ReadOnly = true;
            // 
            // Adoptante
            // 
            this.Adoptante.HeaderText = "Adoptante";
            this.Adoptante.Name = "Adoptante";
            this.Adoptante.ReadOnly = true;
            // 
            // Relacion
            // 
            this.Relacion.HeaderText = "Relacion con Responsable";
            this.Relacion.Name = "Relacion";
            this.Relacion.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha Adopcion";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar :";
            // 
            // text_buscar_fichaAdopcion
            // 
            this.text_buscar_fichaAdopcion.Location = new System.Drawing.Point(64, 38);
            this.text_buscar_fichaAdopcion.Name = "text_buscar_fichaAdopcion";
            this.text_buscar_fichaAdopcion.Size = new System.Drawing.Size(238, 20);
            this.text_buscar_fichaAdopcion.TabIndex = 2;
            this.text_buscar_fichaAdopcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_buscar_fichaAdopcion_KeyUp);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(275, 377);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(185, 39);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(670, 36);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(75, 23);
            this.btn_ayuda.TabIndex = 5;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // F_ListarFichasAdopcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 428);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.text_buscar_fichaAdopcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grilla_fichaAdopcion);
            this.Name = "F_ListarFichasAdopcion";
            this.Text = "F_ListarFichasAdopcion";
            this.Load += new System.EventHandler(this.F_ListarFichasAdopcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_fichaAdopcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_fichaAdopcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_buscar_fichaAdopcion;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PERSONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voluntario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI_ADOPTANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adoptante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}