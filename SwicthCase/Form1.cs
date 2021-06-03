using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwicthCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mensagem = "";

            switch (cboSemana.Text)
            {
                case "Domingo":
                    mensagem = "Você escolheu Domingo, que é o 1º dia da semana";
                    break;
                case "Segunda":
                    mensagem = "Você escolheu Segunda, que é o 2º dia da semana";
                    break;
                case "Terça":
                    mensagem = "Você escolheu Terça, que é o 3º dia da semana";
                    break;
                case "Quarta":
                    mensagem = "Você escolheu Quarta, que é o 4º dia da semana";
                    break;
                case "Quinta":
                    mensagem = "Você escolheu Quinta, que é o 5º dia da semana";
                    break;
                case "Sexta":
                    mensagem = "Você escolheu Sexta, que é o 6º dia da semana";
                    break;
                case "Sábado":
                    mensagem = "Você escolheu Sábado, que é o 7º dia da semana";
                    break;
            }
            MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }
    }
}
