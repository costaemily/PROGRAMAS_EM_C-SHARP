namespace Tabuada
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
            this.lsbExibir = new System.Windows.Forms.ListBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbExibir
            // 
            this.lsbExibir.FormattingEnabled = true;
            this.lsbExibir.Location = new System.Drawing.Point(56, 41);
            this.lsbExibir.Name = "lsbExibir";
            this.lsbExibir.Size = new System.Drawing.Size(296, 264);
            this.lsbExibir.TabIndex = 0;
            this.lsbExibir.SelectedIndexChanged += new System.EventHandler(this.lsbExibir_SelectedIndexChanged);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(56, 325);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 1;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 369);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lsbExibir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbExibir;
        private System.Windows.Forms.Button btnExibir;
    }
}

