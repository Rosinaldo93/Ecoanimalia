namespace App_Ecoanimalia_Piura.Graficos
{
    partial class F_BuscarAdoptante
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
            this.grilla_adoptantes = new System.Windows.Forms.DataGridView();
            this.ID_Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facebook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rpm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movistar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Claro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nextel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario_disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_adoptantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar :";
            // 
            // grilla_adoptantes
            // 
            this.grilla_adoptantes.AllowUserToAddRows = false;
            this.grilla_adoptantes.AllowUserToDeleteRows = false;
            this.grilla_adoptantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_adoptantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Persona,
            this.Nombre,
            this.Apellidos,
            this.Dni,
            this.Direccion,
            this.Sexo,
            this.Edad,
            this.Email,
            this.Facebook,
            this.Rpm,
            this.Movistar,
            this.Claro,
            this.Nextel,
            this.Telefono,
            this.Horario_disponible});
            this.grilla_adoptantes.Location = new System.Drawing.Point(12, 86);
            this.grilla_adoptantes.Name = "grilla_adoptantes";
            this.grilla_adoptantes.ReadOnly = true;
            this.grilla_adoptantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_adoptantes.Size = new System.Drawing.Size(805, 288);
            this.grilla_adoptantes.TabIndex = 1;
            // 
            // ID_Persona
            // 
            this.ID_Persona.HeaderText = "ID";
            this.ID_Persona.Name = "ID_Persona";
            this.ID_Persona.ReadOnly = true;
            this.ID_Persona.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Facebook
            // 
            this.Facebook.HeaderText = "Facebook";
            this.Facebook.Name = "Facebook";
            this.Facebook.ReadOnly = true;
            // 
            // Rpm
            // 
            this.Rpm.HeaderText = "Rpm";
            this.Rpm.Name = "Rpm";
            this.Rpm.ReadOnly = true;
            // 
            // Movistar
            // 
            this.Movistar.HeaderText = "Movistar";
            this.Movistar.Name = "Movistar";
            this.Movistar.ReadOnly = true;
            // 
            // Claro
            // 
            this.Claro.HeaderText = "Claro";
            this.Claro.Name = "Claro";
            this.Claro.ReadOnly = true;
            // 
            // Nextel
            // 
            this.Nextel.HeaderText = "Nextel";
            this.Nextel.Name = "Nextel";
            this.Nextel.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Horario_disponible
            // 
            this.Horario_disponible.HeaderText = "Horario disponible";
            this.Horario_disponible.Name = "Horario_disponible";
            this.Horario_disponible.ReadOnly = true;
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(64, 35);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(187, 20);
            this.text_buscar.TabIndex = 2;
            this.text_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_buscar_KeyUp);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(280, 392);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(109, 42);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(742, 12);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(75, 23);
            this.btn_ayuda.TabIndex = 4;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(459, 392);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(103, 42);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // F_BuscarAdoptante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 462);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.grilla_adoptantes);
            this.Controls.Add(this.label1);
            this.Name = "F_BuscarAdoptante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_BuscarAdoptante";
            this.Load += new System.EventHandler(this.F_BuscarAdoptante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_adoptantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grilla_adoptantes;
        private System.Windows.Forms.TextBox text_buscar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rpm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movistar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Claro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nextel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario_disponible;
        private System.Windows.Forms.Button btn_cancelar;
    }
}