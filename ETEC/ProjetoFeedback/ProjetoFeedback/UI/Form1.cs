using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFeedback
{
    public partial class Form1 : Form
    {
        BLL.AdoreiBLL aBLL = new BLL.AdoreiBLL();
        DAL.AdoreiDAL aDAL = new DAL.AdoreiDAL();
        BLL.GosteiBLL gBLL = new BLL.GosteiBLL();
        DAL.GosteiDAL gDAL = new DAL.GosteiDAL();
        BLL.NaoGosteiBLL nBLL = new BLL.NaoGosteiBLL();
        DAL.NaoGosteiDAL nDAL = new DAL.NaoGosteiDAL();

        int contfeliz = 0, contmedio = 0, conttriste=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAction(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                aBLL.ValorAdorei = contfeliz.ToString();
                contfeliz++;
                lblContAdorei.Text = contfeliz.ToString();
                aDAL.Cadastrar(aBLL);
            }
            else if (e.KeyCode == Keys.O)
            {
                gBLL.ValorGostei = contmedio.ToString();
                contmedio++;
                lblContGostei.Text = contmedio.ToString();
                gDAL.Cadastrar(gBLL);
            }
            else if (e.KeyCode == Keys.OemPeriod)
            {
                nBLL.ValorNaoGostei = conttriste.ToString();
                conttriste++;
                lblContNGostei.Text = conttriste.ToString();
                nDAL.Cadastrar(nBLL);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblContAdorei_Click(object sender, EventArgs e)
        {

        }
    }
}
