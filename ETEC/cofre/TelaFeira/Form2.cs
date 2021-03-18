using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TelaFeira.Properties;

namespace TelaFeira
{
    public partial class fmrJanela : Form
    {
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(String command, StringBuilder buffer, Int32 bufferSize, IntPtr hwndCallback);
        int senha = 0;
        public fmrJanela()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNum.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNum.Clear();//apagar textbox
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtNum.Text += "0";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNum.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNum.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNum.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNum.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNum.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNum.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtNum.Text += "2";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            txtNum.Text += "3";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "123456")
            {
                txtNum.Text = "ABERTO";
                mciSendString("set CDAudio door open", null, 127, IntPtr.Zero);
            }
            else
            {
                txtNum.Text = "INVÁLIDO";
            }
            //fechar = mciSendString("set CDAudio door closed", null, 127, IntPtr.Zero);
        }
    
    
    }
}
