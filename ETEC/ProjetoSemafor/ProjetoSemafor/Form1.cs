using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoSemafor.Properties;
using System.Media;

namespace ProjetoSemafor

  
{
    public partial class Form1 : Form

    {
        SoundPlayer audio1 = new SoundPlayer(Application.StartupPath+"//audio1.wav");

        SoundPlayer audio2 = new SoundPlayer(Application.StartupPath + "//audio2.wav");

        SoundPlayer audio3 = new SoundPlayer(Application.StartupPath + "//audio3.wav");

        int tmp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void bntInicio_Click(object sender, EventArgs e)
        {
            tmpTempo.Start();
        }

        private void bntFim_Click(object sender, EventArgs e)
        {
            tmpTempo.Stop();
            tmp = 0;
        }

        private void pnpAmarelo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmpTempo_Tick(object sender, EventArgs e)
        {
            if(tmp == 0)
            {
                pnlVerde.Visible = false;
                pnlVermelho.Visible = false;
                pnlAmarelo.Visible = false;
                audio1.Play();
                pctCarroVerde.Visible = false;
                pctCarroVermelho.Visible = true;
                pctCarroAmarelo.Visible = false;
            }
            else if(tmp == 30)
            {
                pnlVerde.Visible = false;
                pnlVermelho.Visible = true;
                pnlAmarelo.Visible = true;
                audio2.Play();
                pctCarroVerde.Visible = false;
                pctCarroVermelho.Visible = false;
                pctCarroAmarelo.Visible = true;
            }
            else if(tmp == 60)
            {
                pnlVerde.Visible = true;
                pnlVermelho.Visible = true;
                pnlAmarelo.Visible = false;
                audio3.Play();
                pctCarroVerde.Visible = true;
                pctCarroVermelho.Visible = false;
                pctCarroAmarelo.Visible = false;
            }
            else if (tmp == 90)
            {
                tmp = 0;
                pnlVerde.Visible = false;
                pnlVermelho.Visible = false;
                pnlAmarelo.Visible = false;
                audio1.Play();
                pctCarroVerde.Visible = false;
                pctCarroVermelho.Visible = true;
                pctCarroAmarelo.Visible = false;
            }
            lblE.Text = tmp.ToString();
            tmp++;
        }

        private void timerVerde_Tick(object sender, EventArgs e)
        {

        }

        private void timerAmarelo_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
        }

        private void btnReproduzir_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblE_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
