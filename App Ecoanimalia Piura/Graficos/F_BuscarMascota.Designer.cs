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
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(454, 435);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(103, 42);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(275, 435);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(109, 42);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
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
    }
}