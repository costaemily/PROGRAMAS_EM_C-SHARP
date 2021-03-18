namespace ProjetoQuiz
{
    partial class Quiz
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPergunta1 = new System.Windows.Forms.Label();
            this.rdbAlternativa1 = new System.Windows.Forms.RadioButton();
            this.lblTempo = new System.Windows.Forms.Label();
            this.rdbAlternativa2 = new System.Windows.Forms.RadioButton();
            this.rdbAlternativa3 = new System.Windows.Forms.RadioButton();
            this.rdbAlternativa4 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnVerificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblPergunta1
            // 
            this.lblPergunta1.AutoSize = true;
            this.lblPergunta1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta1.ForeColor = System.Drawing.Color.Black;
            this.lblPergunta1.Location = new System.Drawing.Point(160, 48);
            this.lblPergunta1.Name = "lblPergunta1";
            this.lblPergunta1.Size = new System.Drawing.Size(456, 35);
            this.lblPergunta1.TabIndex = 1;
            this.lblPergunta1.Text = "1. Se corta para não faltar?";
            this.lblPergunta1.Click += new System.EventHandler(this.lblPergunta1_Click);
            // 
            // rdbAlternativa1
            // 
            this.rdbAlternativa1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbAlternativa1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.rdbAlternativa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdbAlternativa1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAlternativa1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbAlternativa1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlternativa1.ForeColor = System.Drawing.Color.Black;
            this.rdbAlternativa1.Location = new System.Drawing.Point(154, 172);
            this.rdbAlternativa1.Name = "rdbAlternativa1";
            this.rdbAlternativa1.Size = new System.Drawing.Size(206, 77);
            this.rdbAlternativa1.TabIndex = 2;
            this.rdbAlternativa1.Text = "Despesas";
            this.rdbAlternativa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAlternativa1.UseVisualStyleBackColor = false;
            this.rdbAlternativa1.CheckedChanged += new System.EventHandler(this.rdbAlternativa1_CheckedChanged);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.Black;
            this.lblTempo.Location = new System.Drawing.Point(22, 70);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(27, 25);
            this.lblTempo.TabIndex = 7;
            this.lblTempo.Text = "0";
            this.lblTempo.Click += new System.EventHandler(this.lblTempo_Click);
            // 
            // rdbAlternativa2
            // 
            this.rdbAlternativa2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbAlternativa2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.rdbAlternativa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdbAlternativa2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAlternativa2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbAlternativa2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlternativa2.ForeColor = System.Drawing.Color.Black;
            this.rdbAlternativa2.Location = new System.Drawing.Point(490, 172);
            this.rdbAlternativa2.Name = "rdbAlternativa2";
            this.rdbAlternativa2.Size = new System.Drawing.Size(196, 77);
            this.rdbAlternativa2.TabIndex = 8;
            this.rdbAlternativa2.Text = "Dinheiro";
            this.rdbAlternativa2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAlternativa2.UseVisualStyleBackColor = false;
            // 
            // rdbAlternativa3
            // 
            this.rdbAlternativa3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbAlternativa3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.rdbAlternativa3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdbAlternativa3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAlternativa3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbAlternativa3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlternativa3.ForeColor = System.Drawing.Color.Black;
            this.rdbAlternativa3.Location = new System.Drawing.Point(154, 310);
            this.rdbAlternativa3.Name = "rdbAlternativa3";
            this.rdbAlternativa3.Size = new System.Drawing.Size(206, 77);
            this.rdbAlternativa3.TabIndex = 9;
            this.rdbAlternativa3.Text = "Pão";
            this.rdbAlternativa3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAlternativa3.UseVisualStyleBackColor = false;
            // 
            // rdbAlternativa4
            // 
            this.rdbAlternativa4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbAlternativa4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.rdbAlternativa4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdbAlternativa4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAlternativa4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbAlternativa4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlternativa4.ForeColor = System.Drawing.Color.Black;
            this.rdbAlternativa4.Location = new System.Drawing.Point(490, 309);
            this.rdbAlternativa4.Name = "rdbAlternativa4";
            this.rdbAlternativa4.Size = new System.Drawing.Size(196, 77);
            this.rdbAlternativa4.TabIndex = 10;
            this.rdbAlternativa4.Text = "Amor";
            this.rdbAlternativa4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAlternativa4.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pontos";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.Color.Black;
            this.lblPontos.Location = new System.Drawing.Point(22, 172);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(27, 25);
            this.lblPontos.TabIndex = 12;
            this.lblPontos.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerificar.AutoSize = true;
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.Black;
            this.btnVerificar.Location = new System.Drawing.Point(689, 428);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(121, 52);
            this.btnVerificar.TabIndex = 13;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoQuiz.Properties.Resources.quiz;
            this.pictureBox1.Location = new System.Drawing.Point(677, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.Color.Black;
            this.lblResposta.Location = new System.Drawing.Point(269, 436);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 32);
            this.lblResposta.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tempo";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbAlternativa4);
            this.Controls.Add(this.rdbAlternativa3);
            this.Controls.Add(this.rdbAlternativa2);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.rdbAlternativa1);
            this.Controls.Add(this.lblPergunta1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPergunta1;
        private System.Windows.Forms.RadioButton rdbAlternativa1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.RadioButton rdbAlternativa2;
        private System.Windows.Forms.RadioButton rdbAlternativa3;
        private System.Windows.Forms.RadioButton rdbAlternativa4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

    }
}