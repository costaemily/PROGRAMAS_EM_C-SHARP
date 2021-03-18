using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoExemploTelas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbTelaPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            telaprincipal tela = new telaprincipal();

            tela.Show();
        }
    }
}
