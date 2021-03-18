namespace ProjetoTimer
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
            this.components = new System.ComponentModel.Container();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblMostraTempo = new System.Windows.Forms.Label();
            this.btnFim = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlBorda = new System.Windows.Forms.Panel();
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.btnPausar = new System.Windows.Forms.Button();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.pnlYellow = new System.Windows.Forms.Panel();
            this.tmrCores = new System.Windows.Forms.Timer(this.components);
            this.pnlBorda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(24, 206);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(90, 32);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblMostraTempo
            // 
            this.lblMostraTempo.AutoSize = true;
            this.lblMostraTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraTempo.Location = new System.Drawing.Point(126, 77);
            this.lblMostraTempo.Name = "lblMostraTempo";
            this.lblMostraTempo.Size = new System.Drawing.Size(19, 25);
            this.lblMostraTempo.TabIndex = 2;
            this.lblMostraTempo.Text = "-";
            // 
            // btnFim
            // 
            this.btnFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFim.Location = new System.Drawing.Point(240, 206);
            this.btnFim.Name = "btnFim";
            this.btnFim.Size = new System.Drawing.Size(87, 32);
            this.btnFim.TabIndex = 3;
            this.btnFim.Text = "Fim";
            this.btnFim.UseVisualStyleBackColor = true;
            this.btnFim.Click += new System.EventHandler(this.btnFim_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(126, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(161, 24);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "TEMPORIZADOR";
            // 
            // pnlBorda
            // 
            this.pnlBorda.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorda.Controls.Add(this.btnPausar);
            this.pnlBorda.Controls.Add(this.btnFim);
            this.pnlBorda.Controls.Add(this.lblMostraTempo);
            this.pnlBorda.Controls.Add(this.btnIniciar);
            this.pnlBorda.Location = new System.Drawing.Point(39, 48);
            this.pnlBorda.Name = "pnlBorda";
            this.pnlBorda.Size = new System.Drawing.Size(348, 261);
            this.pnlBorda.TabIndex = 5;
            // 
            // tmrTempo
            // 
            this.tmrTempo.Interval = 1000;
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
            // 
            // btnPausar
            // 
            this.btnPausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.Location = new System.Drawing.Point(131, 206);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(87, 32);
            this.btnPausar.TabIndex = 4;
            this.btnPausar.Text = "Parar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.Red;
            this.pnlRed.Location = new System.Drawing.Point(404, 69);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(348, 240);
            this.pnlRed.TabIndex = 6;
            this.pnlRed.Visible = false;
            // 
            // pnlYellow
            // 
            this.pnlYellow.BackColor = System.Drawing.Color.Yellow;
            this.pnlYellow.Location = new System.Drawing.Point(404, 69);
            this.pnlYellow.Name = "pnlYellow";
            this.pnlYellow.Size = new System.Drawing.Size(348, 240);
            this.pnlYellow.TabIndex = 7;
            // 
            // tmrCores
            // 
            this.tmrCores.Enabled = true;
            this.tmrCores.Interval = 300;
            this.tmrCores.Tick += new System.EventHandler(this.tmrCores_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 742);
            this.Controls.Add(this.pnlYellow);
            this.Controls.Add(this.pnlRed);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlBorda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlBorda.ResumeLayout(false);
            this.pnlBorda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblMostraTempo;
        private System.Windows.Forms.Button btnFim;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel pnlBorda;
        private System.Windows.Forms.Timer tmrTempo;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Panel pnlYellow;
        private System.Windows.Forms.Timer tmrCores;
    }
}

