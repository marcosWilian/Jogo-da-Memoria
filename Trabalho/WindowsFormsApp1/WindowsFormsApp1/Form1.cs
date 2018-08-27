using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int acertos = 0, erros = 0;


        private void button1_Click(object sender, EventArgs e)
        { // GERA OS BOTÕES DINAMICOS
            button1.Enabled = false; // trava o botão de click
            int posiX =1, posiY=1;
            int[] vetor = new int [16];

            VerificadorNumeros.criarVetor(); // Cria um vetor aleatório

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button b = new Button();
                    b.Size = new Size(90, 90);
                    b.Location = new Point(posiX, posiY);
                    b.Text = VerificadorNumeros.getNumero().ToString();
                    this.Controls.Add(b);
                    b.Click += new EventHandler(botaoClick);
                    posiX += 90;
                    b.BackColor = Color.Black;
                }
                posiX = 1;
                posiY += 90;
            }
        }

        //variaveis globais
        int c=0;

        Button botao1, botao2;

        private void botaoClick(object sender, EventArgs e)
        {
            c++;
            if (c % 2 == 1) //SE NUMERO IMPAR 1 BOTÃO CLICADO
                            //SE NUMERO PAR  2 BOTÃO CLICADOS
            {
                botao1 = (Button)sender;
                botao1.BackColor = Color.Yellow;
            }
            else
            {
                botao2 = (Button)sender;
                botao2.BackColor = Color.Yellow;
                comparar();
            }
        }
        
        public void comparar()
        {
            if (botao1.Text == botao2.Text)
            {
                MessageBox.Show("Iguais");
                botao1.BackColor = Color.Green;
                botao2.BackColor = Color.Green;
                acertos++;
                botao1.Enabled = false; // Desativa botão x
                botao2.Enabled = false; // Desativa botão y
            }
            else
            {
                MessageBox.Show("Diferentes");
                botao1.BackColor = Color.Black;
                botao2.BackColor = Color.Black;
                erros++;
            }

            if (acertos == 8)
            {
                MessageBox.Show("Você Ganhou!");
            }
        }

    }
}
