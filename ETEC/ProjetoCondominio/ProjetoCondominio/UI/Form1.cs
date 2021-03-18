using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCondominio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UI.formRegistro registro = new UI.formRegistro();
            registro.MdiParent = this;
            registro.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmRegistoVisitante_Click(object sender, EventArgs e)
        {
            UI.frmVisita visita = new UI.frmVisita();
            visita.MdiParent = this;
            visita.Show();
        }

        private void mORADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmMorador morador = new UI.frmMorador();
            morador.MdiParent = this;
            morador.Show();
        }

        private void vISITANTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmVisitante visitante = new UI.frmVisitante();
            visitante.MdiParent = this;
            visitante.Show();
        }

        private void uSUÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmUsuario usuario = new UI.frmUsuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UI.TelaLogin login = new UI.TelaLogin();
            login.ShowDialog();

            if (login.logado == false)
            {
                Application.Exit();
            }
        }
    }
}
