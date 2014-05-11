namespace App_Ecoanimalia_Piura.Graficos
{
    partial class F_ListarVoluntarios
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
            this.grilla_listado = new System.Windows.Forms.DataGridView();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_listado
            // 
            this.grilla_listado.AllowUserToAddRows = false;
            this.grilla_listado.AllowUserToResizeRows = false;
            this.grilla_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_listado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grilla_listado.Location = new System.Drawing.Point(12, 117);
            this.grilla_listado.Name = "grilla_listado";
            this.grilla_listado.ReadOnly = true;
            this.grilla_listado.Size = new System.Drawing.Size(784, 414);
            this.grilla_listado.TabIndex = 0;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(267, 21);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(288, 22);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "RELACION DE VOLUNTARIOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR :";
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(76, 75);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(242, 20);
            this.text_buscar.TabIndex = 3;
            this.text_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_buscar_KeyUp);
            // 
            // F_ListarVoluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 543);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.grilla_listado);
            this.Name = "F_ListarVoluntarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de  Voluntarios";
            this.Load += new System.EventHandler(this.F_ListarVoluntarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_listado;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_buscar;
    }
}