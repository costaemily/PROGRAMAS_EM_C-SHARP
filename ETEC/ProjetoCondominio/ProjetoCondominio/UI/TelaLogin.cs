using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCondominio.UI
{
    public partial class TelaLogin : Form
    {
        public bool logado { get; set; }
        BLL.usuarioBLL uBLL = new BLL.usuarioBLL();
        DAL.UsuarioDAL uDAL = new DAL.UsuarioDAL();

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void cbMostrarSenha_OnChange(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked == true)
            {

                txtSenha.isPassword = false;

            }
            else
            {
                txtSenha.isPassword = true;
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            uBLL.NomeUsuario = txtUsuario.Text;
            uBLL.Senha = txtSenha.Text;
            uBLL = uDAL.Logar(uBLL);

            if (uBLL.NomeUsuario != null)
            {
                logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos");
            }
        }
    }
}
