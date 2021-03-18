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
    public partial class formRegistro : Form
    {
        BLL.RegistroBLL rBLL = new BLL.RegistroBLL();
        DAL.registroDAL rDAL = new DAL.registroDAL();

        DAL.MoradorDAL mDAL = new DAL.MoradorDAL();

        public formRegistro()
        {
            InitializeComponent();
        }

        private void formRegistro_Load(object sender, EventArgs e)
        {
            //listando dados na combobox
            cmbMorador.DataSource = mDAL.ConsultarTodos();
            cmbMorador.DisplayMember = "NOME";
            cmbMorador.ValueMember = "CODMORADOR";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            rBLL.Data = Convert.ToDateTime(mskData.Text);
            rBLL.Hora = Convert.ToDateTime(mskHora.Text);
            rBLL.Obsrvacao = txtObservacao.Text;
            rBLL.Codmorador = Convert.ToInt16(cmbMorador.SelectedValue);

            rDAL.Cadastrar(rBLL);
            MessageBox.Show("DADOS GRAVADOS COM SUCESSO!");

            dgvConsulta.DataSource = mDAL.ConsultarTodos();
        }

        private void cmbMorador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
