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
    public partial class frmVisitante : Form
    {
        bool alterar = false;

        //refencia ds classes (instâncias)
        BLL.VisitanteBLL vBLL = new BLL.VisitanteBLL();
        DAL.VisitanteDAL vDAL = new DAL.VisitanteDAL();

        public frmVisitante()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" || txtRG.Text.Trim() == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;//parando o codigo / não ira executar o que esta abaixo
            }

            //passar valores para variáveis
            vBLL.Nome = txtNome.Text;
            vBLL.Celular = mskCelular.Text;
            vBLL.Observacao = txtObservacao.Text;
            vBLL.Rg = txtRG.Text;
            //executar método de cadastro
            if (alterar == false)
            {
                //executar método cadastro
                vDAL.Cadastrar(vBLL);
            }
            else
            {
                //execitar método de alteração
                vDAL.Alterar(vBLL);
            }
            //mensagem de confirmacao
            MessageBox.Show("DADOS GRAVADOS COM SUCESSO!");
            //atualizando a consulta
            dgvConsulta.DataSource = vDAL.ConsultarTodos();

            btnLimpar.PerformClick();//executa o codigo dentro do botao



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //txtNome.Clear();
            //mskCelular.Clear();
            //txtRG.Clear();
            //txtObservacao.Clear();

            alterar = false;

            foreach (Control ctl in tabPage1.Controls)
            {
                if (ctl is TextBox || ctl is MaskedTextBox)
                    ctl.Text = "";
            }
            txtNome.Focus();
        }

        private void frmVisitante_Load(object sender, EventArgs e)
        {
            //para chegar aqui clique duas vezes na barra do form
            dgvConsulta.DataSource = vDAL.ConsultarTodos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            vBLL.Nome = txtFiltro.Text;
            dgvConsulta.DataSource = vDAL.ConsultarPorNome(vBLL);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente excluir este cadastro ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vBLL.Codvisitante = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
                vDAL.Excluir(vBLL);

                dgvConsulta.DataSource = vDAL.ConsultarTodos();
            }
        }

        private void btnEdtar_Click(object sender, EventArgs e)
        {

            if (dgvConsulta.RowCount > 0) //verifica se tem linhas adicionais
            {
                vBLL.Codvisitante = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
                vBLL = vDAL.RetornarDados(vBLL); //carregando os dados do cadastro em vBLL
                //carregando as txts
                mskCelular.Text = vBLL.Celular;
                txtNome.Text = vBLL.Nome;
                txtObservacao.Text = vBLL.Observacao;
                txtRG.Text = vBLL.Rg;
                //direcionar para a primeira aba
                tabControl1.SelectedTab = tabPage1;
                alterar = true;
            }
        }
    }
}
