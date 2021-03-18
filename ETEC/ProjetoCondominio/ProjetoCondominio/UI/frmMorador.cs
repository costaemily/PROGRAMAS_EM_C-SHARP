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

    public partial class frmMorador : Form
    {
        bool alterar = false;

                BLL.MoradorBLL mBLL = new BLL.MoradorBLL();
                DAL.MoradorDAL mDAL = new DAL.MoradorDAL();
        public frmMorador()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" || !mskCelular.MaskFull || !mskCpf.MaskFull)
            {
                MessageBox.Show("Preencha os campos obrigatórios","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                return;//parando o codigo / não ira executar o que esta abaixo
            }

            mBLL.Nome = txtNome.Text;
            mBLL.Telefone = mskTelefone.Text;
            mBLL.Celular = mskCelular.Text;
            mBLL.Email = txtEmail.Text;
            mBLL.Cpf = mskCpf.Text;
            mBLL.Rg = txtRG.Text;
            mBLL.Numero = txtNumero.Text;
            mBLL.Rua = txtRua.Text;

            if (alterar == false)
            {
                //executar método cadastro
                mDAL.Cadastrar(mBLL);
            }
            else
            {
                //execitar método de alteração
                mDAL.Alterar(mBLL);
            }

            MessageBox.Show("DADOS GRAVADOS COM SUCESSO!");
            dgvConsulta.DataSource = mDAL.ConsultarTodos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //txtNome.Focus();
            //mskCelular.Clear();
            //txtRG.Clear();
            //txtEmail.Clear();
            //txtNumero.Clear();
            //mskCelular.Clear();
            //mskCpf.Clear();
            //mskTelefone.Clear();
            //txtNome.Clear();

            foreach (Control ctl in tabPage1.Controls)
            {
                if (ctl is TextBox || ctl is MaskedTextBox)
                    ctl.Text = "";
            }
            txtNome.Focus();
        }

        private void frmMorador_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = mDAL.ConsultarTodos();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            mBLL.Nome = txtFiltro.Text;
            dgvConsulta.DataSource = mDAL.ConsultarPorNome(mBLL);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente excluir este cadastro ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mBLL.Codmorador = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
                mDAL.Excluir(mBLL);

                dgvConsulta.DataSource = mDAL.ConsultarTodos();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdtar_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0) //verifica se tem linhas adicionais
            {
                mBLL.Codmorador = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
                mBLL = mDAL.RetornarDados(mBLL); //carregando os dados do cadastro em vBLL
                //carregando as txts
                txtEmail.Text = mBLL.Email;
                txtRG.Text = mBLL.Rg;
                txtRua.Text = mBLL.Rua;
                txtNome.Text = mBLL.Nome;
                mskCpf.Text = mBLL.Cpf;
                mskTelefone.Text = mBLL.Telefone;
                mskCelular.Text = mBLL.Celular;
                txtNumero.Text = mBLL.Numero;
                //direcionar para a primeira aba
                tabControl1.SelectedTab = tabPage1;
                alterar = true;
            }
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
