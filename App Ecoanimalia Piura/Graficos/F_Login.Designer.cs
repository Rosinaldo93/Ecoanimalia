namespace App_Ecoanimalia_Piura.Graficos
{
    partial class F_Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.Text_Usuario = new System.Windows.Forms.TextBox();
            this.Text_Contra = new System.Windows.Forms.TextBox();
            this.Btn_Sesion = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA :";
            // 
            // Text_Usuario
            // 
            this.Text_Usuario.Location = new System.Drawing.Point(220, 123);
            this.Text_Usuario.Name = "Text_Usuario";
            this.Text_Usuario.Size = new System.Drawing.Size(223, 20);
            this.Text_Usuario.TabIndex = 3;
            // 
            // Text_Contra
            // 
            this.Text_Contra.Location = new System.Drawing.Point(220, 185);
            this.Text_Contra.Name = "Text_Contra";
            this.Text_Contra.PasswordChar = '*';
            this.Text_Contra.Size = new System.Drawing.Size(223, 20);
            this.Text_Contra.TabIndex = 4;
            this.Text_Contra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Contra_KeyPress);
            // 
            // Btn_Sesion
            // 
            this.Btn_Sesion.Location = new System.Drawing.Point(235, 251);
            this.Btn_Sesion.Name = "Btn_Sesion";
            this.Btn_Sesion.Size = new System.Drawing.Size(156, 61);
            this.Btn_Sesion.TabIndex = 5;
            this.Btn_Sesion.Text = "Iniciar Sesion";
            this.Btn_Sesion.UseVisualStyleBackColor = true;
            this.Btn_Sesion.Click += new System.EventHandler(this.Btn_Sesion_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(67, 375);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(509, 32);
            this.progressBar1.TabIndex = 6;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 466);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Btn_Sesion);
            this.Controls.Add(this.Text_Contra);
            this.Controls.Add(this.Text_Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Econimalia Piura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_Usuario;
        private System.Windows.Forms.TextBox Text_Contra;
        private System.Windows.Forms.Button Btn_Sesion;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}