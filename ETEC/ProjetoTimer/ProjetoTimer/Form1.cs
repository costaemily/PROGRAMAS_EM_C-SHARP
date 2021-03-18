using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTimer
{
    public partial class Form1 : Form
    {
        int tmp = 35,cor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            lblMostraTempo.Text = tmp.ToString();
            tmp--;

            if (tmp<0)
            {
                tmrTempo.Stop();
                for (int cont = 1; cont<=100; cont++)
                {
                    lblMostraTempo.Visible = false;
                    lblMostraTempo.Visible = true;
                }

            }
            else if (tmp < 30 && tmp > 20)
            {
                tmrTempo.Interval = 100;
            }
            else if(tmp <10){
                tmrTempo.Interval = 250;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmrTempo.Start();
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            tmrTempo.Stop();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            
        }

        private void tmrCores_Tick(object sender, EventArgs e)
        {
            if (cor % 2 == 0)
            {
                pnlRed.Visible = true;
                pnlYellow.Visible = false;
            }
            else
            {
                pnlRed.Visible = false;
                pnlYellow.Visible = true;
            }
            cor++;
        }
    }
}
