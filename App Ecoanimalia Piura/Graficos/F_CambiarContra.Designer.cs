namespace App_Ecoanimalia_Piura.Graficos
{
    partial class F_CambiarContra
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
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_actual = new System.Windows.Forms.TextBox();
            this.text_nueva = new System.Windows.Forms.TextBox();
            this.text_confirma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.Location = new System.Drawing.Point(129, 183);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(149, 48);
            this.btn_cambiar.TabIndex = 0;
            this.btn_cambiar.Text = "Guardar Cambios";
            this.btn_cambiar.UseVisualStyleBackColor = true;
            this.btn_cambiar.Click += new System.EventHandler(this.btn_cambiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña Actual :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Contraseña :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vuelve a escribir\r\nla contraseña nueva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CONTRASEÑA";
            // 
            // text_actual
            // 
            this.text_actual.Location = new System.Drawing.Point(152, 49);
            this.text_actual.Name = "text_actual";
            this.text_actual.PasswordChar = '*';
            this.text_actual.Size = new System.Drawing.Size(167, 20);
            this.text_actual.TabIndex = 5;
            // 
            // text_nueva
            // 
            this.text_nueva.Location = new System.Drawing.Point(152, 92);
            this.text_nueva.Name = "text_nueva";
            this.text_nueva.PasswordChar = '*';
            this.text_nueva.Size = new System.Drawing.Size(167, 20);
            this.text_nueva.TabIndex = 6;
            // 
            // text_confirma
            // 
            this.text_confirma.Location = new System.Drawing.Point(152, 133);
            this.text_confirma.Name = "text_confirma";
            this.text_confirma.PasswordChar = '*';
            this.text_confirma.Size = new System.Drawing.Size(167, 20);
            this.text_confirma.TabIndex = 7;
            // 
            // F_CambiarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 253);
            this.Controls.Add(this.text_confirma);
            this.Controls.Add(this.text_nueva);
            this.Controls.Add(this.text_actual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cambiar);
            this.Name = "F_CambiarContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cambiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_actual;
        private System.Windows.Forms.TextBox text_nueva;
        private System.Windows.Forms.TextBox text_confirma;
    }
}