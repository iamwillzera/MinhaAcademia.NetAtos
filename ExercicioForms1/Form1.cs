using System.Security.Cryptography.X509Certificates;

namespace ExercicioForms1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Pessoa> listaNomes = new List<Pessoa>();
        public void adicionarNome()
        {
            Pessoa pessoa = new Pessoa(textBox_nomeCompleto.Text);
            string[] tamanho = textBox_nomeCompleto.Text.Split(' ');

            if (textBox_nomeCompleto.Text.Length == 0)
            {
                MessageBox.Show("Favor informar um nome para adicionar.", "ATENÇÃO!");
            }
            else if (tamanho.Length < 2)
            {
                MessageBox.Show("Favor informar o nome completo.", "ATENÇÃO!");
            }
            else
            {
                listaNomes.Add(pessoa);
                textBox_nomeCompleto.Clear();
            }
        }

        public void listarNome()
        {
            textBox_listaNomes.Text = String.Empty;
            foreach (var item in listaNomes)
            {
                textBox_listaNomes.Text += item.Nome + Environment.NewLine;
            }

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            textBox_listaNomes.CharacterCasing = CharacterCasing.Upper;
            adicionarNome();
            listaNomes = listaNomes.OrderBy(n => n.Nome).ToList();
            listarNome();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            textBox_listaNomes.Clear();
        }
    }
}