namespace TelaFeira
{
    partial class TelaLogin
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCmpUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.textCmpSenha = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(181, 134);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(88, 23);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCmpUsuario
            // 
            this.txtCmpUsuario.Location = new System.Drawing.Point(279, 125);
            this.txtCmpUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtCmpUsuario.Name = "txtCmpUsuario";
            this.txtCmpUsuario.Size = new System.Drawing.Size(307, 32);
            this.txtCmpUsuario.TabIndex = 1;
            this.txtCmpUsuario.TextChanged += new System.EventHandler(this.txtCmpUsuario_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(197, 177);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(72, 23);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textCmpSenha
            // 
            this.textCmpSenha.Location = new System.Drawing.Point(279, 168);
            this.textCmpSenha.Margin = new System.Windows.Forms.Padding(5);
            this.textCmpSenha.Name = "textCmpSenha";
            this.textCmpSenha.Size = new System.Drawing.Size(307, 32);
            this.textCmpSenha.TabIndex = 3;
//            this.textCmpSenha.TextChanged += new System.EventHandler(this.textCmpSenha_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(379, 249);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(202, 35);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Entrar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.entrar);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 365);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.textCmpSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtCmpUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login de Acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCmpUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox textCmpSenha;
        private System.Windows.Forms.Button btnEnviar;
    }
}

