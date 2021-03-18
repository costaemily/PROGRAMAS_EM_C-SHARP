namespace MatrizVetores
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
            this.btnCarregar = new System.Windows.Forms.Button();
            this.cmbLista = new System.Windows.Forms.ComboBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstMatriz = new System.Windows.Forms.ListBox();
            this.btnListar2 = new System.Windows.Forms.Button();
            this.btnCarregar2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtA00 = new System.Windows.Forms.TextBox();
            this.txtA01 = new System.Windows.Forms.TextBox();
            this.txtA02 = new System.Windows.Forms.TextBox();
            this.txtA12 = new System.Windows.Forms.TextBox();
            this.txtA11 = new System.Windows.Forms.TextBox();
            this.txtA10 = new System.Windows.Forms.TextBox();
            this.txtA22 = new System.Windows.Forms.TextBox();
            this.txtA21 = new System.Windows.Forms.TextBox();
            this.txtA20 = new System.Windows.Forms.TextBox();
            this.txtB22 = new System.Windows.Forms.TextBox();
            this.txtB21 = new System.Windows.Forms.TextBox();
            this.txtB20 = new System.Windows.Forms.TextBox();
            this.txtB12 = new System.Windows.Forms.TextBox();
            this.txtB11 = new System.Windows.Forms.TextBox();
            this.txtB10 = new System.Windows.Forms.TextBox();
            this.txtB02 = new System.Windows.Forms.TextBox();
            this.txtB01 = new System.Windows.Forms.TextBox();
            this.txtB00 = new System.Windows.Forms.TextBox();
            this.txtC22 = new System.Windows.Forms.TextBox();
            this.txtC21 = new System.Windows.Forms.TextBox();
            this.txtC20 = new System.Windows.Forms.TextBox();
            this.txtC12 = new System.Windows.Forms.TextBox();
            this.txtC11 = new System.Windows.Forms.TextBox();
            this.txtC10 = new System.Windows.Forms.TextBox();
            this.txtC02 = new System.Windows.Forms.TextBox();
            this.txtC01 = new System.Windows.Forms.TextBox();
            this.txtC00 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(12, 66);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(146, 35);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // cmbLista
            // 
            this.cmbLista.FormattingEnabled = true;
            this.cmbLista.Location = new System.Drawing.Point(25, 160);
            this.cmbLista.Name = "cmbLista";
            this.cmbLista.Size = new System.Drawing.Size(258, 28);
            this.cmbLista.TabIndex = 1;
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 20;
            this.lstLista.Location = new System.Drawing.Point(12, 179);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(328, 104);
            this.lstLista.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(166, 66);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(146, 35);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(300, 26);
            this.txtNome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informe seu nome:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstLista);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.btnCarregar);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 292);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lstMatriz);
            this.panel2.Controls.Add(this.btnListar2);
            this.panel2.Controls.Add(this.btnCarregar2);
            this.panel2.Location = new System.Drawing.Point(374, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 292);
            this.panel2.TabIndex = 7;
            // 
            // lstMatriz
            // 
            this.lstMatriz.FormattingEnabled = true;
            this.lstMatriz.ItemHeight = 20;
            this.lstMatriz.Location = new System.Drawing.Point(3, 85);
            this.lstMatriz.Name = "lstMatriz";
            this.lstMatriz.Size = new System.Drawing.Size(348, 124);
            this.lstMatriz.TabIndex = 2;
            // 
            // btnListar2
            // 
            this.btnListar2.Location = new System.Drawing.Point(181, 23);
            this.btnListar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListar2.Name = "btnListar2";
            this.btnListar2.Size = new System.Drawing.Size(146, 35);
            this.btnListar2.TabIndex = 3;
            this.btnListar2.Text = "Listar";
            this.btnListar2.UseVisualStyleBackColor = true;
            this.btnListar2.Click += new System.EventHandler(this.btnListar2_Click);
            // 
            // btnCarregar2
            // 
            this.btnCarregar2.Location = new System.Drawing.Point(27, 23);
            this.btnCarregar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarregar2.Name = "btnCarregar2";
            this.btnCarregar2.Size = new System.Drawing.Size(146, 35);
            this.btnCarregar2.TabIndex = 0;
            this.btnCarregar2.Text = "Carregar";
            this.btnCarregar2.UseVisualStyleBackColor = true;
            this.btnCarregar2.Click += new System.EventHandler(this.btnCarregar2_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnCalcular);
            this.panel3.Controls.Add(this.txtC22);
            this.panel3.Controls.Add(this.txtC21);
            this.panel3.Controls.Add(this.txtC20);
            this.panel3.Controls.Add(this.txtC12);
            this.panel3.Controls.Add(this.txtC11);
            this.panel3.Controls.Add(this.txtC10);
            this.panel3.Controls.Add(this.txtC02);
            this.panel3.Controls.Add(this.txtC01);
            this.panel3.Controls.Add(this.txtC00);
            this.panel3.Controls.Add(this.txtB22);
            this.panel3.Controls.Add(this.txtB21);
            this.panel3.Controls.Add(this.txtB20);
            this.panel3.Controls.Add(this.txtB12);
            this.panel3.Controls.Add(this.txtB11);
            this.panel3.Controls.Add(this.txtB10);
            this.panel3.Controls.Add(this.txtB02);
            this.panel3.Controls.Add(this.txtB01);
            this.panel3.Controls.Add(this.txtB00);
            this.panel3.Controls.Add(this.txtA22);
            this.panel3.Controls.Add(this.txtA21);
            this.panel3.Controls.Add(this.txtA20);
            this.panel3.Controls.Add(this.txtA12);
            this.panel3.Controls.Add(this.txtA11);
            this.panel3.Controls.Add(this.txtA10);
            this.panel3.Controls.Add(this.txtA02);
            this.panel3.Controls.Add(this.txtA01);
            this.panel3.Controls.Add(this.txtA00);
            this.panel3.Location = new System.Drawing.Point(12, 312);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 200);
            this.panel3.TabIndex = 8;
            // 
            // txtA00
            // 
            this.txtA00.Location = new System.Drawing.Point(12, 29);
            this.txtA00.Name = "txtA00";
            this.txtA00.Size = new System.Drawing.Size(70, 26);
            this.txtA00.TabIndex = 5;
            this.txtA00.TextChanged += new System.EventHandler(this.txtA00_TextChanged);
            // 
            // txtA01
            // 
            this.txtA01.Location = new System.Drawing.Point(88, 29);
            this.txtA01.Name = "txtA01";
            this.txtA01.Size = new System.Drawing.Size(70, 26);
            this.txtA01.TabIndex = 6;
            // 
            // txtA02
            // 
            this.txtA02.Location = new System.Drawing.Point(164, 29);
            this.txtA02.Name = "txtA02";
            this.txtA02.Size = new System.Drawing.Size(70, 26);
            this.txtA02.TabIndex = 7;
            // 
            // txtA12
            // 
            this.txtA12.Location = new System.Drawing.Point(164, 61);
            this.txtA12.Name = "txtA12";
            this.txtA12.Size = new System.Drawing.Size(70, 26);
            this.txtA12.TabIndex = 10;
            // 
            // txtA11
            // 
            this.txtA11.Location = new System.Drawing.Point(88, 61);
            this.txtA11.Name = "txtA11";
            this.txtA11.Size = new System.Drawing.Size(70, 26);
            this.txtA11.TabIndex = 9;
            // 
            // txtA10
            // 
            this.txtA10.Location = new System.Drawing.Point(12, 61);
            this.txtA10.Name = "txtA10";
            this.txtA10.Size = new System.Drawing.Size(70, 26);
            this.txtA10.TabIndex = 8;
            // 
            // txtA22
            // 
            this.txtA22.Location = new System.Drawing.Point(164, 93);
            this.txtA22.Name = "txtA22";
            this.txtA22.Size = new System.Drawing.Size(70, 26);
            this.txtA22.TabIndex = 13;
            // 
            // txtA21
            // 
            this.txtA21.Location = new System.Drawing.Point(88, 93);
            this.txtA21.Name = "txtA21";
            this.txtA21.Size = new System.Drawing.Size(70, 26);
            this.txtA21.TabIndex = 12;
            // 
            // txtA20
            // 
            this.txtA20.Location = new System.Drawing.Point(12, 93);
            this.txtA20.Name = "txtA20";
            this.txtA20.Size = new System.Drawing.Size(70, 26);
            this.txtA20.TabIndex = 11;
            // 
            // txtB22
            // 
            this.txtB22.Location = new System.Drawing.Point(435, 93);
            this.txtB22.Name = "txtB22";
            this.txtB22.Size = new System.Drawing.Size(70, 26);
            this.txtB22.TabIndex = 22;
            // 
            // txtB21
            // 
            this.txtB21.Location = new System.Drawing.Point(359, 93);
            this.txtB21.Name = "txtB21";
            this.txtB21.Size = new System.Drawing.Size(70, 26);
            this.txtB21.TabIndex = 21;
            // 
            // txtB20
            // 
            this.txtB20.Location = new System.Drawing.Point(283, 93);
            this.txtB20.Name = "txtB20";
            this.txtB20.Size = new System.Drawing.Size(70, 26);
            this.txtB20.TabIndex = 20;
            // 
            // txtB12
            // 
            this.txtB12.Location = new System.Drawing.Point(435, 61);
            this.txtB12.Name = "txtB12";
            this.txtB12.Size = new System.Drawing.Size(70, 26);
            this.txtB12.TabIndex = 19;
            // 
            // txtB11
            // 
            this.txtB11.Location = new System.Drawing.Point(359, 61);
            this.txtB11.Name = "txtB11";
            this.txtB11.Size = new System.Drawing.Size(70, 26);
            this.txtB11.TabIndex = 18;
            // 
            // txtB10
            // 
            this.txtB10.Location = new System.Drawing.Point(283, 61);
            this.txtB10.Name = "txtB10";
            this.txtB10.Size = new System.Drawing.Size(70, 26);
            this.txtB10.TabIndex = 17;
            // 
            // txtB02
            // 
            this.txtB02.Location = new System.Drawing.Point(435, 29);
            this.txtB02.Name = "txtB02";
            this.txtB02.Size = new System.Drawing.Size(70, 26);
            this.txtB02.TabIndex = 16;
            // 
            // txtB01
            // 
            this.txtB01.Location = new System.Drawing.Point(359, 29);
            this.txtB01.Name = "txtB01";
            this.txtB01.Size = new System.Drawing.Size(70, 26);
            this.txtB01.TabIndex = 15;
            // 
            // txtB00
            // 
            this.txtB00.Location = new System.Drawing.Point(283, 29);
            this.txtB00.Name = "txtB00";
            this.txtB00.Size = new System.Drawing.Size(70, 26);
            this.txtB00.TabIndex = 14;
            // 
            // txtC22
            // 
            this.txtC22.Location = new System.Drawing.Point(710, 93);
            this.txtC22.Name = "txtC22";
            this.txtC22.ReadOnly = true;
            this.txtC22.Size = new System.Drawing.Size(70, 26);
            this.txtC22.TabIndex = 31;
            // 
            // txtC21
            // 
            this.txtC21.Location = new System.Drawing.Point(634, 93);
            this.txtC21.Name = "txtC21";
            this.txtC21.ReadOnly = true;
            this.txtC21.Size = new System.Drawing.Size(70, 26);
            this.txtC21.TabIndex = 30;
            // 
            // txtC20
            // 
            this.txtC20.Location = new System.Drawing.Point(558, 93);
            this.txtC20.Name = "txtC20";
            this.txtC20.ReadOnly = true;
            this.txtC20.Size = new System.Drawing.Size(70, 26);
            this.txtC20.TabIndex = 29;
            // 
            // txtC12
            // 
            this.txtC12.Location = new System.Drawing.Point(710, 61);
            this.txtC12.Name = "txtC12";
            this.txtC12.ReadOnly = true;
            this.txtC12.Size = new System.Drawing.Size(70, 26);
            this.txtC12.TabIndex = 28;
            // 
            // txtC11
            // 
            this.txtC11.Location = new System.Drawing.Point(634, 61);
            this.txtC11.Name = "txtC11";
            this.txtC11.ReadOnly = true;
            this.txtC11.Size = new System.Drawing.Size(70, 26);
            this.txtC11.TabIndex = 27;
            // 
            // txtC10
            // 
            this.txtC10.Location = new System.Drawing.Point(558, 61);
            this.txtC10.Name = "txtC10";
            this.txtC10.ReadOnly = true;
            this.txtC10.Size = new System.Drawing.Size(70, 26);
            this.txtC10.TabIndex = 26;
            // 
            // txtC02
            // 
            this.txtC02.Location = new System.Drawing.Point(710, 29);
            this.txtC02.Name = "txtC02";
            this.txtC02.ReadOnly = true;
            this.txtC02.Size = new System.Drawing.Size(70, 26);
            this.txtC02.TabIndex = 25;
            // 
            // txtC01
            // 
            this.txtC01.Location = new System.Drawing.Point(634, 29);
            this.txtC01.Name = "txtC01";
            this.txtC01.ReadOnly = true;
            this.txtC01.Size = new System.Drawing.Size(70, 26);
            this.txtC01.TabIndex = 24;
            // 
            // txtC00
            // 
            this.txtC00.Location = new System.Drawing.Point(558, 29);
            this.txtC00.Name = "txtC00";
            this.txtC00.ReadOnly = true;
            this.txtC00.Size = new System.Drawing.Size(70, 26);
            this.txtC00.TabIndex = 23;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(331, 136);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(146, 35);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 37);
            this.label3.TabIndex = 32;
            this.label3.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 552);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbLista);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ComboBox cmbLista;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstMatriz;
        private System.Windows.Forms.Button btnListar2;
        private System.Windows.Forms.Button btnCarregar2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtC22;
        private System.Windows.Forms.TextBox txtC21;
        private System.Windows.Forms.TextBox txtC20;
        private System.Windows.Forms.TextBox txtC12;
        private System.Windows.Forms.TextBox txtC11;
        private System.Windows.Forms.TextBox txtC10;
        private System.Windows.Forms.TextBox txtC02;
        private System.Windows.Forms.TextBox txtC01;
        private System.Windows.Forms.TextBox txtC00;
        private System.Windows.Forms.TextBox txtB22;
        private System.Windows.Forms.TextBox txtB21;
        private System.Windows.Forms.TextBox txtB20;
        private System.Windows.Forms.TextBox txtB12;
        private System.Windows.Forms.TextBox txtB11;
        private System.Windows.Forms.TextBox txtB10;
        private System.Windows.Forms.TextBox txtB02;
        private System.Windows.Forms.TextBox txtB01;
        private System.Windows.Forms.TextBox txtB00;
        private System.Windows.Forms.TextBox txtA22;
        private System.Windows.Forms.TextBox txtA21;
        private System.Windows.Forms.TextBox txtA20;
        private System.Windows.Forms.TextBox txtA12;
        private System.Windows.Forms.TextBox txtA11;
        private System.Windows.Forms.TextBox txtA10;
        private System.Windows.Forms.TextBox txtA02;
        private System.Windows.Forms.TextBox txtA01;
        private System.Windows.Forms.TextBox txtA00;
    }
}

