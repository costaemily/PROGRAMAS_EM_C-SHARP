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
    public partial class frmVisita : Form
    {
        BLL.VisitaBLL viBLL = new BLL.VisitaBLL();
        DAL.visitaDAL viDAL = new DAL.visitaDAL();

        DAL.MoradorDAL mDAL = new DAL.MoradorDAL();
        DAL.VisitanteDAL vDAL = new DAL.VisitanteDAL();
        public frmVisita()
        {
            InitializeComponent();
        }

        private void frmVisita_Load(object sender, EventArgs e)
        {
            //listando dados na combobox
            cmbMorador.DataSource = mDAL.ConsultarTodos();
            cmbMorador.DisplayMember = "NOME";
            cmbMorador.ValueMember = "CODMORADOR";

            cmbVisitante.DataSource = vDAL.ConsultarTodos();
            cmbVisitante.DisplayMember = "NOME";
            cmbVisitante.ValueMember = "CODVISITANTE";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            viBLL.Data = Convert.ToDateTime(mskData.Text);
            viBLL.Hora = Convert.ToDateTime(mskHora.Text);
            viBLL.Observacao = txtObservacao.Text;
            viBLL.Codmorador = Convert.ToInt16(cmbMorador.SelectedValue);
            viBLL.Codvisitante = Convert.ToInt16(cmbVisitante.SelectedValue);

            viDAL.Cadastrar(viBLL);
            MessageBox.Show("DADOS GRAVADOS COM SUCESSO!");

            dgvConsulta.DataSource = mDAL.ConsultarTodos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
