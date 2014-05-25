namespace App_Ecoanimalia_Piura.Graficos
{
    partial class F_BuscarMascota
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
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grilla_mascota = new System.Windows.Forms.DataGridView();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_RESCATISTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIE_FORMATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_RESCATISTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESCATISTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMPORAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_INGRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAMANO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTERILIZADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_mascota)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(750, 12);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(75, 23);
            this.btn_ayuda.TabIndex = 0;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar :";
            // 
            // grilla_mascota
            // 
            this.grilla_mascota.AllowUserToAddRows = false;
            this.grilla_mascota.AllowUserToDeleteRows = false;
            this.grilla_mascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_mascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SERIE,
            this.ID_RESCATISTA,
            this.SERIE_FORMATO,
            this.COD_RESCATISTA,
            this.RESCATISTA,
            this.TEMPORAL,
            this.FECHA_INGRE,
            this.ID_TIPO,
            this.TIPO,
            this.TAMANO,
            this.ESTADO,
            this.NOMBRE,
            this.RAZA,
            this.SEXO,
            this.COLOR,
            this.EDAD,
            this.ESTERILIZADO});
            this.grilla_mascota.Location = new System.Drawing.Point(12, 67);
            this.grilla_mascota.Name = "grilla_mascota";
            this.grilla_mascota.ReadOnly = true;
            this.grilla_mascota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_mascota.Size = new System.Drawing.Size(813, 340);
            this.grilla_mascota.TabIndex = 2;
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(68, 28);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(179, 20);
            this.text_buscar.TabIndex = 3;
            this.text_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_buscar_KeyUp);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(454, 435);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(103, 42);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(275, 435);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(109, 42);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // SERIE
            // 
            this.SERIE.HeaderText = "SERIE";
            this.SERIE.Name = "SERIE";
            this.SERIE.ReadOnly = true;
            this.SERIE.Visible = false;
            // 
            // ID_RESCATISTA
            // 
            this.ID_RESCATISTA.HeaderText = "ID_RESCATISTA";
            this.ID_RESCATISTA.Name = "ID_RESCATISTA";
            this.ID_RESCATISTA.ReadOnly = true;
            this.ID_RESCATISTA.Visible = false;
            // 
            // SERIE_FORMATO
            // 
            this.SERIE_FORMATO.HeaderText = "SERIE";
            this.SERIE_FORMATO.Name = "SERIE_FORMATO";
            this.SERIE_FORMATO.ReadOnly = true;
            // 
            // COD_RESCATISTA
            // 
            this.COD_RESCATISTA.HeaderText = "CODIGO";
            this.COD_RESCATISTA.Name = "COD_RESCATISTA";
            this.COD_RESCATISTA.ReadOnly = true;
            // 
            // RESCATISTA
            // 
            this.RESCATISTA.HeaderText = "RESCATISTA";
            this.RESCATISTA.Name = "RESCATISTA";
            this.RESCATISTA.ReadOnly = true;
            // 
            // TEMPORAL
            // 
            this.TEMPORAL.HeaderText = "TEMPORAL";
            this.TEMPORAL.Name = "TEMPORAL";
            this.TEMPORAL.ReadOnly = true;
            this.TEMPORAL.Visible = false;
            // 
            // FECHA_INGRE
            // 
            this.FECHA_INGRE.HeaderText = "FECHA";
            this.FECHA_INGRE.Name = "FECHA_INGRE";
            this.FECHA_INGRE.ReadOnly = true;
            // 
            // ID_TIPO
            // 
            this.ID_TIPO.HeaderText = "ID_TIPO";
            this.ID_TIPO.Name = "ID_TIPO";
            this.ID_TIPO.ReadOnly = true;
            this.ID_TIPO.Visible = false;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // TAMANO
            // 
            this.TAMANO.HeaderText = "TAMANO";
            this.TAMANO.Name = "TAMANO";
            this.TAMANO.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // RAZA
            // 
            this.RAZA.HeaderText = "RAZA";
            this.RAZA.Name = "RAZA";
            this.RAZA.ReadOnly = true;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            this.SEXO.ReadOnly = true;
            // 
            // COLOR
            // 
            this.COLOR.HeaderText = "COLOR";
            this.COLOR.Name = "COLOR";
            this.COLOR.ReadOnly = true;
            // 
            // EDAD
            // 
            this.EDAD.HeaderText = "EDAD";
            this.EDAD.Name = "EDAD";
            this.EDAD.ReadOnly = true;
            // 
            // ESTERILIZADO
            // 
            this.ESTERILIZADO.HeaderText = "ESTERILIZADO";
            this.ESTERILIZADO.Name = "ESTERILIZADO";
            this.ESTERILIZADO.ReadOnly = true;
            // 
            // F_BuscarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 489);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.grilla_mascota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ayuda);
            this.Name = "F_BuscarMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_BuscarMascota";
            this.Load += new System.EventHandler(this.F_BuscarMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_mascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grilla_mascota;
        private System.Windows.Forms.TextBox text_buscar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_RESCATISTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIE_FORMATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_RESCATISTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESCATISTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMPORAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INGRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAMANO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTERILIZADO;
    }
}