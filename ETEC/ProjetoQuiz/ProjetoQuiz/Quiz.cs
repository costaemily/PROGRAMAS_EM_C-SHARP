using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoQuiz.Properties;
using System.Media;

namespace ProjetoQuiz
{
    public partial class Quiz : Form
    {
        SoundPlayer audio = new SoundPlayer(Application.StartupPath + "//audio.wav");

        String[] quiz = new String[5];
        int pontos = 0, tmp = 0, controle = 0;
        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            timer1.Start();
            audio.Play();
            
        }
        public void preencher3()
        {
            quiz[0] = lblPergunta1.Text = "3. Quanto mais se perde\n mais se tem?";
            quiz[1] = rdbAlternativa1.Text = "Paixão";
            quiz[2] = rdbAlternativa2.Text = "Amizade";
            quiz[3] = rdbAlternativa3.Text = "Tristeza";
            quiz[4] = rdbAlternativa4.Text = "Sono";
        }
        public void preencher2()
        {
            quiz[0] = lblPergunta1.Text = "2. Enche uma casa,\n mas não enche uma mão?";
            quiz[1] = rdbAlternativa1.Text = "Anel";
            quiz[2] = rdbAlternativa2.Text = "Botão";
            quiz[3] = rdbAlternativa3.Text = "Pulseira";
            quiz[4] = rdbAlternativa4.Text = "Cordão";
        }
        public void preencher4()
        {
            quiz[0] = lblPergunta1.Text = "4. Se quebra quando se come?";
            quiz[1] = rdbAlternativa1.Text = "Jejum";
            quiz[2] = rdbAlternativa2.Text = "Dente";
            quiz[3] = rdbAlternativa3.Text = "Pipoca";
            quiz[4] = rdbAlternativa4.Text = "Quebra-queixo";
        }
        public void preencher5()
        {
            quiz[0] = lblPergunta1.Text = "5. Quando se perde\n nunca mais se encontra?";
            quiz[1] = rdbAlternativa1.Text = "Amor";
            quiz[2] = rdbAlternativa2.Text = "Felicidade";
            quiz[3] = rdbAlternativa3.Text = "Tempo";
            quiz[4] = rdbAlternativa4.Text = "As chaves";
        }
        public void preencher6()
        {
            quiz[0] = lblPergunta1.Text = "6. Os livros têm,\n as árvores também?";
            quiz[1] = rdbAlternativa1.Text = "Folhas";
            quiz[2] = rdbAlternativa2.Text = "Informação";
            quiz[3] = rdbAlternativa3.Text = "Beleza";
            quiz[4] = rdbAlternativa4.Text = "Oxigênio";
        }
        public void preencher7()
        {
            quiz[0] = lblPergunta1.Text = "7. Se para, não fica em pé?";
            quiz[1] = rdbAlternativa1.Text = "Pessoa\nAlcolizada";
            quiz[2] = rdbAlternativa2.Text = "Motocicleta";
            quiz[3] = rdbAlternativa3.Text = "Avó";
            quiz[4] = rdbAlternativa4.Text = "Pião";
        }
        public void preencher8()
        {
            quiz[0] = lblPergunta1.Text = "8. Cai de muito alto\n e não se quebra?";
            quiz[1] = rdbAlternativa1.Text = "Bola";
            quiz[2] = rdbAlternativa2.Text = "Chuva";
            quiz[3] = rdbAlternativa3.Text = "Folha";
            quiz[4] = rdbAlternativa4.Text = "Manteiga";
        }
        public void preencher9()
        {
            quiz[0] = lblPergunta1.Text = "9. Está sempre\n na nossa frente?";
            quiz[1] = rdbAlternativa1.Text = "Futuro";
            quiz[2] = rdbAlternativa2.Text = "Passado";
            quiz[3] = rdbAlternativa3.Text = "Presente";
            quiz[4] = rdbAlternativa4.Text = "Pretérito";
        }
        public void preencher10()
        {
            quiz[0] = lblPergunta1.Text = "10. É bonita e não tem cor,\n é gostosa e não tem sabor?";
            quiz[1] = rdbAlternativa1.Text = "Luar";
            quiz[2] = rdbAlternativa2.Text = "Luz Solar";
            quiz[3] = rdbAlternativa3.Text = "Água";
            quiz[4] = rdbAlternativa4.Text = "Oxigênio";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = tmp.ToString();
            tmp++;
        }

        private void rdbAlternativa1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (lblPergunta1.Text == "1. Se corta para não faltar?")
            {
                if (rdbAlternativa1.Checked == true)
                {
                    MessageBox.Show("Resposta Correta!");
                    pontos = pontos + 10;
                    lblPontos.Text = pontos.ToString();
                    preencher2();
          
                }
                else
                {
                    pontos = pontos - 10;
                    lblPontos.Text = pontos.ToString();
                    MessageBox.Show("Resposta Errada!");
                    preencher2();
                }
            }
            if (controle == 1)
            {
                if (lblPergunta1.Text == "2. Enche uma casa,\n mas não enche uma mão?")
                {
                    if (rdbAlternativa2.Checked == true)
                    {
                        MessageBox.Show("Resposta Correta!");
                        pontos = pontos + 10;
                        lblPontos.Text = pontos.ToString();
                        preencher3();
                    }
                    else
                    {
                        pontos = pontos - 10;
                        lblPontos.Text = pontos.ToString();
                        MessageBox.Show("Resposta Errada!");
                        preencher3();
                    }
                }
            }
            if (controle == 2)
            {

                if (lblPergunta1.Text == "3. Quanto mais se perde\n mais se tem?")
                {
                    if (rdbAlternativa4.Checked == true)
                    {
                        MessageBox.Show("Resposta Correta!");
                        pontos = pontos + 10;
                        lblPontos.Text = pontos.ToString();
                        preencher4();
                    }
                    else
                    {
                        pontos = pontos - 10;
                        lblPontos.Text = pontos.ToString();
                        MessageBox.Show("Resposta Errada!");
                        preencher4();
                    }
                }
            }
            if (controle == 3)
            {

                if (lblPergunta1.Text == "4. Se quebra quando se come?")
                {
                    if (rdbAlternativa1.Checked == true)
                    {
                        MessageBox.Show("Resposta Correta!");
                        pontos = pontos + 10;
                        lblPontos.Text = pontos.ToString();
                        preencher5();
                    }
                    else
                    {
                        pontos = pontos - 10;
                        lblPontos.Text = pontos.ToString();
                        MessageBox.Show("Resposta Errada!");
                        preencher5();
                    }
                }
            }
            if (controle == 4)
            {

                if (lblPergunta1.Text == "5. Quando se perde\n nunca mais se encontra?")
                {
                    if (rdbAlternativa3.Checked == true)
                    {
                        MessageBox.Show("Resposta Correta!");
                        pontos = pontos + 10;
                        lblPontos.Text = pontos.ToString();
                        preencher6();
                    }
                    else
                    {
                        pontos = pontos - 10;
                        lblPontos.Text = pontos.ToString();
                        MessageBox.Show("Resposta Errada!");
                        preencher6();
                    }
                }
            }
            if (controle == 5)
            {

                if (lblPergunta1.Text == "6. Os livros têm,\n as árvores também?")
                {
                    if (rdbAlternativa1.Checked == true)
                    {
                        MessageBox.Show("Resposta Correta!");
                        pontos = pontos + 10;
                        lblPontos.Text = pontos.ToString();
                        preencher7();
                    }
                    else
                    {
                        pontos = pontos - 10;
                        lblPontos.Text = pontos.ToString();
                        MessageBox.Show("Resposta Errada!");
                        preencher7();
                    }
                }
            }
            if (controle == 6)
            {

                if (lblPergunta1.Text == "7. Se para, não fica em pé?")
                {
                    if (rdbAlternativa4.Checked == true)
                    {
                        MessageBox.Show("Resposta Correta!");
                        pontos = pontos + 10;
                        lblPontos.Text = pontos.ToString();
                        preencher8();
                    }
                    else
                    {
                        pontos = pontos - 10;
                        lblPontos.Text = pontos.ToString();
                        MessageBox.Show("Resposta Errada!");
                        preencher8();
                    }
                }
            }
            if (controle == 7)
            {

                if (lblPergunta1.Text == "8. Cai de muito alto\n e não se quebra?")
                {
                    if (rdbAlternativa2.Checked == true)
                    {
                        MessageBox.Show("Resposta Correta!");
                        pontos = pontos + 10;
                        lblPontos.Text = pontos.ToString();
                        preencher9();
                    }
                    else
                    {
                        pontos = pontos - 10;
                        lblPontos.Text = pontos.ToString();
                        MessageBox.Show("Resposta Errada!");
                        preencher9();
                    }
                }
            }
            if (controle == 8)
            {

                if (lblPergunta1.Text == "9. Está sempre\n na nossa frente?")
                {
                    if (rdbAlternativa1.Checked == true)
                    {
                        MessageBox.Show("Resposta Correta!");
                        pontos = pontos + 10;
                        lblPontos.Text = pontos.ToString();
                        preencher10();
                    }
                    else
                    {
                        pontos = pontos - 10;
                        lblPontos.Text = pontos.ToString();
                        MessageBox.Show("Resposta Errada!");
                        preencher10();
                    }
                }
            } if (controle == 9)
            {

                if (lblPergunta1.Text == "10. É bonita e não tem cor,\n é gostosa e não tem sabor?")
                {
                    if (rdbAlternativa3.Checked == true)
                    {
                        MessageBox.Show("Resposta Correta!");
                        pontos = pontos + 10;
                        lblPontos.Text = pontos.ToString();
                        MessageBox.Show("Pontos: " + pontos);

                        this.Hide();

                        Form1 f1 = new Form1();
                        f1.ShowDialog();
                    }
                    else
                    {
                        pontos = pontos - 10;
                        lblPontos.Text = pontos.ToString();
                        MessageBox.Show("Resposta Errada!");
                        MessageBox.Show("Pontos: " + pontos);

                        this.Hide(); 

                        Form1 f1 = new Form1();
                        f1.ShowDialog();
                    }
                }
            }

                controle++;
        

        }

        private void lblTempo_Click(object sender, EventArgs e)
        {
            lblTempo.Text = tmp.ToString();
            tmp++;
        }

        private void lblPergunta1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
