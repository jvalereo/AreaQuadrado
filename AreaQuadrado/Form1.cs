using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace AreaQuadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            //Treinamento , Calculdo da area do quadrado , tipo double
            //Jonas valereo - Técnico em Informática

            //Declarando as variaveis, tipo double

            double lado1, lado2, area;

            //Declarando a entrada de dados no textbox

            lado1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            lado2 = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);

            //Declarando a variavel area


            area = lado1 * lado2;


            //Imprimir saida de dados no MessagemBox, concatenação


           MessageBox.Show("O Valor da Area = " + area.ToString("F1", 
               CultureInfo.InvariantCulture), "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
           MessageBox.Show("Teste de Novo!!!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            //Declarando codigo limpa textbox

            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Declarano do codigo sair do programa

            Close();
        }

        //Fim do programa

    }
}
