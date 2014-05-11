namespace App_Ecoanimalia_Piura.Graficos
{
    partial class F_Principal
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
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btn_Mascotas = new System.Windows.Forms.Button();
            this.btn_fichaGeneral = new System.Windows.Forms.Button();
            this.btn_perfil = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_fichaTemporal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Location = new System.Drawing.Point(1, 1);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(206, 109);
            this.btn_Usuarios.TabIndex = 0;
            this.btn_Usuarios.Text = "USUARIOS  Y VOLUNTARIOS";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click);
            // 
            // btn_Mascotas
            // 
            this.btn_Mascotas.Location = new System.Drawing.Point(213, 1);
            this.btn_Mascotas.Name = "btn_Mascotas";
            this.btn_Mascotas.Size = new System.Drawing.Size(207, 109);
            this.btn_Mascotas.TabIndex = 1;
            this.btn_Mascotas.Text = "MASCOTAS";
            this.btn_Mascotas.UseVisualStyleBackColor = true;
            // 
            // btn_fichaGeneral
            // 
            this.btn_fichaGeneral.Location = new System.Drawing.Point(427, 1);
            this.btn_fichaGeneral.Name = "btn_fichaGeneral";
            this.btn_fichaGeneral.Size = new System.Drawing.Size(188, 109);
            this.btn_fichaGeneral.TabIndex = 2;
            this.btn_fichaGeneral.Text = "FICHAS GENERALES";
            this.btn_fichaGeneral.UseVisualStyleBackColor = true;
            this.btn_fichaGeneral.Click += new System.EventHandler(this.btn_fichaGeneral_Click);
            // 
            // btn_perfil
            // 
            this.btn_perfil.Location = new System.Drawing.Point(756, 32);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.Size = new System.Drawing.Size(143, 47);
            this.btn_perfil.TabIndex = 3;
            this.btn_perfil.Text = "MI PERFIL";
            this.btn_perfil.UseVisualStyleBackColor = true;
            this.btn_perfil.Click += new System.EventHandler(this.btn_perfil_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(756, 97);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(143, 48);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "CERRAR SESSION";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_fichaTemporal
            // 
            this.btn_fichaTemporal.Location = new System.Drawing.Point(1, 137);
            this.btn_fichaTemporal.Name = "btn_fichaTemporal";
            this.btn_fichaTemporal.Size = new System.Drawing.Size(206, 107);
            this.btn_fichaTemporal.TabIndex = 5;
            this.btn_fichaTemporal.Text = "FICHAS TEMPORALES";
            this.btn_fichaTemporal.UseVisualStyleBackColor = true;
            this.btn_fichaTemporal.Click += new System.EventHandler(this.btn_fichaTemporal_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 692);
            this.Controls.Add(this.btn_fichaTemporal);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_perfil);
            this.Controls.Add(this.btn_fichaGeneral);
            this.Controls.Add(this.btn_Mascotas);
            this.Controls.Add(this.btn_Usuarios);
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Principal";
            this.Load += new System.EventHandler(this.F_Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.Button btn_Mascotas;
        private System.Windows.Forms.Button btn_fichaGeneral;
        private System.Windows.Forms.Button btn_perfil;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_fichaTemporal;
    }
}