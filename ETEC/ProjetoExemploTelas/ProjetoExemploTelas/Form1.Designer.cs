namespace ProjetoExemploTelas
{
    partial class Form1
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
            this.rdbTelaPrincipal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdbTelaPrincipal
            // 
            this.rdbTelaPrincipal.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbTelaPrincipal.FlatAppearance.BorderSize = 3;
            this.rdbTelaPrincipal.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdbTelaPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.rdbTelaPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.rdbTelaPrincipal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbTelaPrincipal.Location = new System.Drawing.Point(122, 146);
            this.rdbTelaPrincipal.Name = "rdbTelaPrincipal";
            this.rdbTelaPrincipal.Size = new System.Drawing.Size(122, 84);
            this.rdbTelaPrincipal.TabIndex = 0;
            this.rdbTelaPrincipal.Text = " Tela Principal";
            this.rdbTelaPrincipal.UseVisualStyleBackColor = true;
            this.rdbTelaPrincipal.CheckedChanged += new System.EventHandler(this.rdbTelaPrincipal_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rdbTelaPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTelaPrincipal;
    }
}

