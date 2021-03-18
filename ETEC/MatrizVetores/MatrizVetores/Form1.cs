using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizVetores
{
    public partial class Form1 : Form
    {
        int j = 0;
        string[] vetNomes = new string[5];

        string[,] matCarros = new string[2,2];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            

            if (j < 5)
            {
                vetNomes[j] = txtNome.Text;
                j++;
                MessageBox.Show("DADOS CARREGADOS!");
            }
            else
            {
                MessageBox.Show("ACABOU ACABOU ACABOU!!!!");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();//limpar
            cmbLista.Items.Clear();

            for (int i = 0;i < j; i++)
            {
                cmbLista.Items.Add(vetNomes[i]);

                lstLista.Items.Add(vetNomes[i]);
            }



            
        }

        private void btnCarregar2_Click(object sender, EventArgs e)
        {
            matCarros[0, 0] = "Fusca";
            matCarros[0, 1] = "Uno";
            matCarros[1, 0] = "Prisma";
            matCarros[1, 1] = "Civic novo";
            MessageBox.Show("CADASTRADO");
        }

        private void btnListar2_Click(object sender, EventArgs e)
        {
            lstMatriz.Items.Clear();
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    lstMatriz.Items.Add(matCarros[i, j]);
                }
            }
        }

        private void txtA00_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] c = new int[3, 3];

            a[0, 0] = int.Parse(txtA00.Text);
            a[0, 1] = int.Parse(txtA01.Text);
            a[0, 2] = int.Parse(txtA02.Text);

            a[1, 0] = int.Parse(txtA10.Text);
            a[1, 1] = int.Parse(txtA11.Text);
            a[1, 2] = int.Parse(txtA12.Text);

            a[2, 0] = int.Parse(txtA20.Text);
            a[2, 1] = int.Parse(txtA21.Text);
            a[2, 2] = int.Parse(txtA22.Text);

            b[0, 0] = int.Parse(txtB00.Text);
            b[0, 1] = int.Parse(txtB01.Text);
            b[0, 2] = int.Parse(txtB02.Text);


            b[1, 0] = int.Parse(txtB10.Text);
            b[1, 1] = int.Parse(txtB11.Text);
            b[1, 2] = int.Parse(txtB12.Text);

            b[2, 0] = int.Parse(txtB20.Text);
            b[2, 1] = int.Parse(txtB21.Text);
            b[2, 2] = int.Parse(txtB22.Text);




            //Calcular

            c[0, 0] = (a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0] + a[0, 2] * b[2, 0]);
            c[0, 1] = (a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1] + a[0, 2] * b[2, 1]);
            c[0, 2] = (a[0, 0] * b[0, 2] + a[0, 1] * b[1, 2] + a[0, 2] * b[2, 2]);

            c[1, 0] = (a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0] + a[1, 2] * b[2, 0]);
            c[1, 1] = (a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1] + a[1, 2] * b[2, 1]);
            c[1, 2] = (a[1, 0] * b[0, 2] + a[1, 1] * b[1, 2] + a[1, 2] * b[2, 2]);

            c[2, 0] = (a[2, 0] * b[0, 0] + a[2, 1] * b[1, 0] + a[2, 2] * b[2, 0]);
            c[2, 1] = (a[2, 0] * b[0, 1] + a[2, 1] * b[1, 1] + a[2, 2] * b[2, 1]);
            c[2, 2] = (a[2, 0] * b[0, 2] + a[2, 1] * b[1, 2] + a[2, 2] * b[2, 2]);

            // Imprimindo
            txtC00.Text = c[0, 0].ToString();
            txtC01.Text = c[0, 1].ToString();
            txtC02.Text = c[0, 2].ToString();

            txtC10.Text = c[1, 0].ToString();
            txtC11.Text = c[1, 1].ToString();
            txtC12.Text = c[1, 2].ToString();

            txtC20.Text = c[2, 0].ToString();
            txtC21.Text = c[2, 1].ToString();
            txtC22.Text = c[2, 2].ToString();



        }
    }
}
