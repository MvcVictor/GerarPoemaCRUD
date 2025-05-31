using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorPoemaWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lê os valores da tela (textboxes e combobox)
            string nome = textBoxNome.Text.Trim();
            string lugar = textBoxLugar.Text.Trim();
            string sentimento = textBoxSentimento.Text.Trim();
            string qualidade = textBoxQualidade.Text.Trim();
            string escolha = comboBoxPoema.SelectedItem?.ToString();

            // Validação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(lugar) ||
                string.IsNullOrWhiteSpace(sentimento) ||
                string.IsNullOrWhiteSpace(qualidade))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (string.IsNullOrEmpty(escolha))
            {
                MessageBox.Show("Por favor, escolha um tipo de poema.");
                return;
            }

            // Cria o poema com base na escolha
            string poema = GerarPoema(nome, lugar, sentimento, qualidade, escolha);

            // Mostra o poema na caixa de texto final
            textBoxResultado.Text = poema;

            // Limpa os campos
            textBoxNome.Clear();
            textBoxLugar.Clear();
            textBoxSentimento.Clear();
            textBoxQualidade.Clear();
            comboBoxPoema.SelectedIndex = -1;
        }

        private string GerarPoema(string nome, string lugar, string sentimento, string qualidade, string escolha)
        {
            if (escolha.Contains("1"))
            {
                return $@"
Em {lugar}, pensei em você, {nome},
Com um sentimento tão forte: {sentimento}.
Tua alma é tão {qualidade},
Que me faz sorrir com sinceridade.

Quando o vento sopra, eu lembro de nós,
Em cada detalhe, em cada voz.
{nome}, você é meu verso favorito,
Meu sonho mais bonito.";
            }
            else if (escolha.Contains("2"))
            {
                return $@"
{nome} anda por meus pensamentos,
como brisa leve de {lugar} ao entardecer.

É um {sentimento} que não sei explicar,
Mas que me aquece.

Tão {qualidade}, tão única.

Você é um instante eterno.";
            }
            else if (escolha.Contains("3"))
            {
                return $@"
{nome}, flor do meu jardim,
Te encontrei ali no fim.

Em {lugar}, meu coração sorriu,
O {sentimento} em mim surgiu.

Com teu jeito tão {qualidade},
Viraste minha realidade.";
            }
            else if (escolha.Contains("4"))
            {
                return $@"
{nome}, safada, o dog te ama,
Te pego e dale, sem drama.

Pode ser em {lugar}, ou qualquer outro canto,
O {sentimento} em mim, cresce tanto.

Com teu jeito tão {qualidade},
Você é minha metade, de verdade.";
            }
            else
            {
                return "Escolha inválida.";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPoema.Items.Clear();
            comboBoxPoema.Items.Add("1 - poema clássico fofinho");
            comboBoxPoema.Items.Add("2 - poema Moderno");
            comboBoxPoema.Items.Add("3 - poema Rimado");
            comboBoxPoema.Items.Add("4 - poema versão Cria");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSentimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLugar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
