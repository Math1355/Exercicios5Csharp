using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosDoCapitulo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;

            for (int i = 1; i <= 12; i += 1)
            {

                valorInvestido = valorInvestido * 1.01;

            }

            MessageBox.Show("Valor investido agora é: " + valorInvestido);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            double valorInvestido = 1000.0;
            int i = 1;

            while (i <= 12)
            {
                valorInvestido = valorInvestido * 1.01;
                i += 1;
            }

            MessageBox.Show("Valor investido agora é: " + valorInvestido);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            int i = 1;

            do
            {
                valorInvestido = valorInvestido * 1.01;
                i += 1;
            }
            while (i <= 12);

                MessageBox.Show("Valor investido agora é: " + valorInvestido);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Exercicio 1 capitulo 5

            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Exercicio 2 capitulo 5
            int total = 0;
            for (int i = 1; i <= 1000; i++)
            {
                total += i;
            }
            MessageBox.Show("O total e: " + total);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Exercicio 3 capitulo 5
            int multiplos = 0;
            string multiplosDe3 = "";
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    multiplos += 1;
                    multiplosDe3 += i + ",";
                }
            }
            MessageBox.Show("O total de mútiplos por 3 entre 1 e 100 e: " + multiplos);
            MessageBox.Show("O total de mútiplos por 3 entre 1 e 100 e: " + multiplosDe3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Exercicio 4 capitulo 5

            int total = 0;
            string naoMutiplos = "";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    total += i;
                    naoMutiplos += i + ",";
                }
            }

            MessageBox.Show("O total e: " + total);
            MessageBox.Show("O total e: " + naoMutiplos);
        }
    }
}

