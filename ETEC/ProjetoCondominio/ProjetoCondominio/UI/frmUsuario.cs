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
    public partial class frmUsuario : Form
    {
        bool alterar = false;

        BLL.usuarioBLL uBLL = new BLL.usuarioBLL();
        DAL.UsuarioDAL uDAL = new DAL.UsuarioDAL();
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" || txtRG.Text.Trim() == "" || !mskCpf.MaskFull || txtNomeUsu.Text.Trim()=="" || txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;//parando o codigo / não ira executar o que esta abaixo
            }

            uBLL.Nome = txtNome.Text;
            uBLL.Telefone = mskTelefone.Text;
            uBLL.NomeUsuario = txtNomeUsu.Text;
            uBLL.Senha = txtSenha.Text;
            uBLL.Cpf = mskCpf.Text;
            uBLL.Rg = txtRG.Text;

            if (alterar == false)
            {
                //executar método cadastro
                uDAL.Cadastrar(uBLL);
            }
            else
            {
                //execitar método de alteração
                uDAL.Alterar(uBLL);
            }

            btnLimpar.PerformClick();//executa o codigo dentro do botao

            

            MessageBox.Show("DADOS GRAVADOS COM SUCESSO!");
            dgvConsulta.DataSource = uDAL.ConsultarTodos();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = uDAL.ConsultarTodos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            uBLL.Nome = txtFiltro.Text;
            dgvConsulta.DataSource = uDAL.ConsultarPorNome(uBLL);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente excluir este cadastro ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                uBLL.Codusu = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
                uDAL.Excluir(uBLL);

                dgvConsulta.DataSource = uDAL.ConsultarTodos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            alterar = false;

            foreach (Control ctl in tabPage1.Controls)
            {
                if (ctl is TextBox || ctl is MaskedTextBox)
                    ctl.Text = "";
            }
            txtNome.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEdtar_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0) //verifica se tem linhas adicionais
            {
                uBLL.Codusu = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
                uBLL = uDAL.RetornarDados(uBLL); //carregando os dados do cadastro em vBLL
                //carregando as txts
                txtSenha.Text = uBLL.Senha;
                txtRG.Text = uBLL.Rg;
                txtNomeUsu.Text = uBLL.NomeUsuario;
                txtNome.Text = uBLL.Nome;
                mskCpf.Text = uBLL.Cpf;
                mskTelefone.Text = uBLL.Telefone;
                //direcionar para a primeira aba
                tabControl1.SelectedTab = tabPage1;
                alterar = true;
            }
        }
    }
}
