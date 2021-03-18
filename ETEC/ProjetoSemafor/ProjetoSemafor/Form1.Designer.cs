namespace ProjetoSemafor
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
            this.lblSemaforo = new System.Windows.Forms.Label();
            this.bntInicio = new System.Windows.Forms.Button();
            this.bntFim = new System.Windows.Forms.Button();
            this.tmpTempo = new System.Windows.Forms.Timer(this.components);
            this.lblE = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctCarroAmarelo = new System.Windows.Forms.PictureBox();
            this.pctCarroVerde = new System.Windows.Forms.PictureBox();
            this.pctCarroVermelho = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlVerde = new System.Windows.Forms.Panel();
            this.pnlAmarelo = new System.Windows.Forms.Panel();
            this.pnlVermelho = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarroAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarroVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarroVermelho)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSemaforo
            // 
            this.lblSemaforo.AutoSize = true;
            this.lblSemaforo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemaforo.Location = new System.Drawing.Point(334, 30);
            this.lblSemaforo.Name = "lblSemaforo";
            this.lblSemaforo.Size = new System.Drawing.Size(124, 25);
            this.lblSemaforo.TabIndex = 0;
            this.lblSemaforo.Text = "Semáforo";
            // 
            // bntInicio
            // 
            this.bntInicio.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntInicio.Location = new System.Drawing.Point(561, 38);
            this.bntInicio.Name = "bntInicio";
            this.bntInicio.Size = new System.Drawing.Size(89, 34);
            this.bntInicio.TabIndex = 1;
            this.bntInicio.Text = "Inicio";
            this.bntInicio.UseVisualStyleBackColor = true;
            this.bntInicio.Click += new System.EventHandler(this.bntInicio_Click);
            // 
            // bntFim
            // 
            this.bntFim.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntFim.Location = new System.Drawing.Point(561, 106);
            this.bntFim.Name = "bntFim";
            this.bntFim.Size = new System.Drawing.Size(89, 29);
            this.bntFim.TabIndex = 2;
            this.bntFim.Text = "Fim";
            this.bntFim.UseVisualStyleBackColor = true;
            this.bntFim.Click += new System.EventHandler(this.bntFim_Click);
            // 
            // tmpTempo
            // 
            this.tmpTempo.Tick += new System.EventHandler(this.tmpTempo_Tick);
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(346, 91);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(19, 23);
            this.lblE.TabIndex = 7;
            this.lblE.Text = "-";
            this.lblE.Click += new System.EventHandler(this.lblE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Location = new System.Drawing.Point(90, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 282);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(-2, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 16);
            this.panel2.TabIndex = 17;
            // 
            // pctCarroAmarelo
            // 
            this.pctCarroAmarelo.Image = global::ProjetoSemafor.Properties.Resources.carro;
            this.pctCarroAmarelo.Location = new System.Drawing.Point(359, 335);
            this.pctCarroAmarelo.Name = "pctCarroAmarelo";
            this.pctCarroAmarelo.Size = new System.Drawing.Size(175, 116);
            this.pctCarroAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCarroAmarelo.TabIndex = 16;
            this.pctCarroAmarelo.TabStop = false;
            this.pctCarroAmarelo.Visible = false;
            // 
            // pctCarroVerde
            // 
            this.pctCarroVerde.Image = global::ProjetoSemafor.Properties.Resources.carro;
            this.pctCarroVerde.Location = new System.Drawing.Point(587, 335);
            this.pctCarroVerde.Name = "pctCarroVerde";
            this.pctCarroVerde.Size = new System.Drawing.Size(175, 116);
            this.pctCarroVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCarroVerde.TabIndex = 15;
            this.pctCarroVerde.TabStop = false;
            this.pctCarroVerde.Visible = false;
            // 
            // pctCarroVermelho
            // 
            this.pctCarroVermelho.Image = global::ProjetoSemafor.Properties.Resources.carro;
            this.pctCarroVermelho.Location = new System.Drawing.Point(150, 335);
            this.pctCarroVermelho.Name = "pctCarroVermelho";
            this.pctCarroVermelho.Size = new System.Drawing.Size(175, 116);
            this.pctCarroVermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCarroVermelho.TabIndex = 14;
            this.pctCarroVermelho.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ProjetoSemafor.Properties.Resources.semaforo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.pnlVerde);
            this.panel3.Controls.Add(this.pnlAmarelo);
            this.panel3.Controls.Add(this.pnlVermelho);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 250);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pnlVerde
            // 
            this.pnlVerde.BackColor = System.Drawing.Color.Transparent;
            this.pnlVerde.BackgroundImage = global::ProjetoSemafor.Properties.Resources.verde;
            this.pnlVerde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlVerde.Location = new System.Drawing.Point(78, 182);
            this.pnlVerde.Name = "pnlVerde";
            this.pnlVerde.Size = new System.Drawing.Size(54, 55);
            this.pnlVerde.TabIndex = 2;
            this.pnlVerde.Visible = false;
            // 
            // pnlAmarelo
            // 
            this.pnlAmarelo.BackColor = System.Drawing.Color.Transparent;
            this.pnlAmarelo.BackgroundImage = global::ProjetoSemafor.Properties.Resources.amarelo;
            this.pnlAmarelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAmarelo.Location = new System.Drawing.Point(78, 108);
            this.pnlAmarelo.Name = "pnlAmarelo";
            this.pnlAmarelo.Size = new System.Drawing.Size(54, 55);
            this.pnlAmarelo.TabIndex = 1;
            this.pnlAmarelo.Visible = false;
            // 
            // pnlVermelho
            // 
            this.pnlVermelho.BackColor = System.Drawing.Color.Transparent;
            this.pnlVermelho.BackgroundImage = global::ProjetoSemafor.Properties.Resources.vermelho21;
            this.pnlVermelho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlVermelho.Location = new System.Drawing.Point(75, 26);
            this.pnlVermelho.Name = "pnlVermelho";
            this.pnlVermelho.Size = new System.Drawing.Size(64, 66);
            this.pnlVermelho.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(561, 184);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 42);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 463);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pctCarroAmarelo);
            this.Controls.Add(this.pctCarroVerde);
            this.Controls.Add(this.pctCarroVermelho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.bntFim);
            this.Controls.Add(this.bntInicio);
            this.Controls.Add(this.lblSemaforo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctCarroAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarroVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarroVermelho)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSemaforo;
        private System.Windows.Forms.Button bntInicio;
        private System.Windows.Forms.Button bntFim;
        private System.Windows.Forms.Timer tmpTempo;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlAmarelo;
        private System.Windows.Forms.Panel pnlVermelho;
        private System.Windows.Forms.Panel pnlVerde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctCarroVermelho;
        private System.Windows.Forms.PictureBox pctCarroVerde;
        private System.Windows.Forms.PictureBox pctCarroAmarelo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
    }
}

