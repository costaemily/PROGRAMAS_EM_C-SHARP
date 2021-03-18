namespace ProjetoFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPergunta = new System.Windows.Forms.Label();
            this.lblContAdorei = new System.Windows.Forms.Label();
            this.lblContGostei = new System.Windows.Forms.Label();
            this.lblContNGostei = new System.Windows.Forms.Label();
            this.lblAdorei = new System.Windows.Forms.Label();
            this.lblGostei = new System.Windows.Forms.Label();
            this.lblNGostei = new System.Windows.Forms.Label();
            this.btnAdorei = new System.Windows.Forms.Button();
            this.btnGostei = new System.Windows.Forms.Button();
            this.btnTriste = new System.Windows.Forms.Button();
            this.ptbTriste = new System.Windows.Forms.PictureBox();
            this.ptbMedio = new System.Windows.Forms.PictureBox();
            this.ptbFeliz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTriste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFeliz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPergunta.Font = new System.Drawing.Font("Minion Pro", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(419, 9);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(860, 130);
            this.lblPergunta.TabIndex = 0;
            this.lblPergunta.Text = "O que achou da sala?";
            // 
            // lblContAdorei
            // 
            this.lblContAdorei.AutoSize = true;
            this.lblContAdorei.BackColor = System.Drawing.Color.Transparent;
            this.lblContAdorei.Font = new System.Drawing.Font("Minion Pro", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContAdorei.Location = new System.Drawing.Point(321, 177);
            this.lblContAdorei.Name = "lblContAdorei";
            this.lblContAdorei.Size = new System.Drawing.Size(101, 130);
            this.lblContAdorei.TabIndex = 1;
            this.lblContAdorei.Text = "0";
            this.lblContAdorei.Click += new System.EventHandler(this.lblContAdorei_Click);
            // 
            // lblContGostei
            // 
            this.lblContGostei.AutoSize = true;
            this.lblContGostei.BackColor = System.Drawing.Color.Transparent;
            this.lblContGostei.Font = new System.Drawing.Font("Minion Pro", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContGostei.Location = new System.Drawing.Point(763, 177);
            this.lblContGostei.Name = "lblContGostei";
            this.lblContGostei.Size = new System.Drawing.Size(101, 130);
            this.lblContGostei.TabIndex = 2;
            this.lblContGostei.Text = "0";
            // 
            // lblContNGostei
            // 
            this.lblContNGostei.AutoSize = true;
            this.lblContNGostei.BackColor = System.Drawing.Color.Transparent;
            this.lblContNGostei.Font = new System.Drawing.Font("Minion Pro", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContNGostei.Location = new System.Drawing.Point(1178, 177);
            this.lblContNGostei.Name = "lblContNGostei";
            this.lblContNGostei.Size = new System.Drawing.Size(101, 130);
            this.lblContNGostei.TabIndex = 3;
            this.lblContNGostei.Text = "0";
            // 
            // lblAdorei
            // 
            this.lblAdorei.AutoSize = true;
            this.lblAdorei.BackColor = System.Drawing.Color.Transparent;
            this.lblAdorei.Font = new System.Drawing.Font("Minion Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdorei.Location = new System.Drawing.Point(278, 570);
            this.lblAdorei.Name = "lblAdorei";
            this.lblAdorei.Size = new System.Drawing.Size(212, 86);
            this.lblAdorei.TabIndex = 4;
            this.lblAdorei.Text = "Adorei";
            // 
            // lblGostei
            // 
            this.lblGostei.AutoSize = true;
            this.lblGostei.BackColor = System.Drawing.Color.Transparent;
            this.lblGostei.Font = new System.Drawing.Font("Minion Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGostei.Location = new System.Drawing.Point(707, 570);
            this.lblGostei.Name = "lblGostei";
            this.lblGostei.Size = new System.Drawing.Size(204, 86);
            this.lblGostei.TabIndex = 5;
            this.lblGostei.Text = "Gostei";
            // 
            // lblNGostei
            // 
            this.lblNGostei.AutoSize = true;
            this.lblNGostei.BackColor = System.Drawing.Color.Transparent;
            this.lblNGostei.Font = new System.Drawing.Font("Minion Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNGostei.Location = new System.Drawing.Point(1108, 570);
            this.lblNGostei.Name = "lblNGostei";
            this.lblNGostei.Size = new System.Drawing.Size(308, 86);
            this.lblNGostei.TabIndex = 6;
            this.lblNGostei.Text = "Não gostei";
            // 
            // btnAdorei
            // 
            this.btnAdorei.Location = new System.Drawing.Point(435, 400);
            this.btnAdorei.Name = "btnAdorei";
            this.btnAdorei.Size = new System.Drawing.Size(75, 23);
            this.btnAdorei.TabIndex = 7;
            this.btnAdorei.UseVisualStyleBackColor = true;
            this.btnAdorei.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonAction);
            // 
            // btnGostei
            // 
            this.btnGostei.Location = new System.Drawing.Point(860, 400);
            this.btnGostei.Name = "btnGostei";
            this.btnGostei.Size = new System.Drawing.Size(75, 23);
            this.btnGostei.TabIndex = 8;
            this.btnGostei.UseVisualStyleBackColor = true;
            // 
            // btnTriste
            // 
            this.btnTriste.Location = new System.Drawing.Point(1268, 414);
            this.btnTriste.Name = "btnTriste";
            this.btnTriste.Size = new System.Drawing.Size(75, 23);
            this.btnTriste.TabIndex = 9;
            this.btnTriste.UseVisualStyleBackColor = true;
            // 
            // ptbTriste
            // 
            this.ptbTriste.BackColor = System.Drawing.Color.Transparent;
            this.ptbTriste.Image = ((System.Drawing.Image)(resources.GetObject("ptbTriste.Image")));
            this.ptbTriste.Location = new System.Drawing.Point(262, 288);
            this.ptbTriste.Name = "ptbTriste";
            this.ptbTriste.Size = new System.Drawing.Size(248, 251);
            this.ptbTriste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTriste.TabIndex = 10;
            this.ptbTriste.TabStop = false;
            // 
            // ptbMedio
            // 
            this.ptbMedio.BackColor = System.Drawing.Color.Transparent;
            this.ptbMedio.Image = ((System.Drawing.Image)(resources.GetObject("ptbMedio.Image")));
            this.ptbMedio.Location = new System.Drawing.Point(696, 288);
            this.ptbMedio.Name = "ptbMedio";
            this.ptbMedio.Size = new System.Drawing.Size(253, 251);
            this.ptbMedio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMedio.TabIndex = 11;
            this.ptbMedio.TabStop = false;
            // 
            // ptbFeliz
            // 
            this.ptbFeliz.BackColor = System.Drawing.Color.Transparent;
            this.ptbFeliz.Image = ((System.Drawing.Image)(resources.GetObject("ptbFeliz.Image")));
            this.ptbFeliz.Location = new System.Drawing.Point(1111, 288);
            this.ptbFeliz.Name = "ptbFeliz";
            this.ptbFeliz.Size = new System.Drawing.Size(253, 251);
            this.ptbFeliz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFeliz.TabIndex = 12;
            this.ptbFeliz.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1588, 740);
            this.ControlBox = false;
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.ptbTriste);
            this.Controls.Add(this.ptbFeliz);
            this.Controls.Add(this.ptbMedio);
            this.Controls.Add(this.btnTriste);
            this.Controls.Add(this.btnGostei);
            this.Controls.Add(this.btnAdorei);
            this.Controls.Add(this.lblNGostei);
            this.Controls.Add(this.lblGostei);
            this.Controls.Add(this.lblAdorei);
            this.Controls.Add(this.lblContNGostei);
            this.Controls.Add(this.lblContGostei);
            this.Controls.Add(this.lblContAdorei);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTriste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFeliz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Label lblContAdorei;
        private System.Windows.Forms.Label lblContGostei;
        private System.Windows.Forms.Label lblContNGostei;
        private System.Windows.Forms.Label lblAdorei;
        private System.Windows.Forms.Label lblGostei;
        private System.Windows.Forms.Label lblNGostei;
        private System.Windows.Forms.Button btnAdorei;
        private System.Windows.Forms.Button btnGostei;
        private System.Windows.Forms.Button btnTriste;
        private System.Windows.Forms.PictureBox ptbTriste;
        private System.Windows.Forms.PictureBox ptbMedio;
        private System.Windows.Forms.PictureBox ptbFeliz;
    }
}

