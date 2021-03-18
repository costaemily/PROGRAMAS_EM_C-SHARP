namespace ProjetoCondominio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmGerenciarCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mORADORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vISITANTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistroMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistoVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGerenciarCadastro,
            this.tsmRegistroMorador,
            this.tsmRegistoVisitante,
            this.tsmSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmGerenciarCadastro
            // 
            this.tsmGerenciarCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mORADORToolStripMenuItem,
            this.vISITANTEToolStripMenuItem,
            this.uSUÁRIOToolStripMenuItem});
            this.tsmGerenciarCadastro.Name = "tsmGerenciarCadastro";
            this.tsmGerenciarCadastro.Size = new System.Drawing.Size(145, 20);
            this.tsmGerenciarCadastro.Text = "GERENCIAR CADASTRO";
            this.tsmGerenciarCadastro.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mORADORToolStripMenuItem
            // 
            this.mORADORToolStripMenuItem.Name = "mORADORToolStripMenuItem";
            this.mORADORToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mORADORToolStripMenuItem.Text = "MORADOR";
            this.mORADORToolStripMenuItem.Click += new System.EventHandler(this.mORADORToolStripMenuItem_Click);
            // 
            // vISITANTEToolStripMenuItem
            // 
            this.vISITANTEToolStripMenuItem.Name = "vISITANTEToolStripMenuItem";
            this.vISITANTEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vISITANTEToolStripMenuItem.Text = "VISITANTE";
            this.vISITANTEToolStripMenuItem.Click += new System.EventHandler(this.vISITANTEToolStripMenuItem_Click);
            // 
            // uSUÁRIOToolStripMenuItem
            // 
            this.uSUÁRIOToolStripMenuItem.Name = "uSUÁRIOToolStripMenuItem";
            this.uSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uSUÁRIOToolStripMenuItem.Text = "USUÁRIO";
            this.uSUÁRIOToolStripMenuItem.Click += new System.EventHandler(this.uSUÁRIOToolStripMenuItem_Click);
            // 
            // tsmRegistroMorador
            // 
            this.tsmRegistroMorador.Name = "tsmRegistroMorador";
            this.tsmRegistroMorador.Size = new System.Drawing.Size(151, 20);
            this.tsmRegistroMorador.Text = "REGISTRO DE MORADOR";
            this.tsmRegistroMorador.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmRegistoVisitante
            // 
            this.tsmRegistoVisitante.Name = "tsmRegistoVisitante";
            this.tsmRegistoVisitante.Size = new System.Drawing.Size(148, 20);
            this.tsmRegistoVisitante.Text = "REGISTRO DE VISITANTE";
            this.tsmRegistoVisitante.Click += new System.EventHandler(this.tsmRegistoVisitante_Click);
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(43, 20);
            this.tsmSair.Text = "SAIR";
            this.tsmSair.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 435);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmGerenciarCadastro;
        private System.Windows.Forms.ToolStripMenuItem mORADORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vISITANTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUÁRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistroMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistoVisitante;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
    }
}

