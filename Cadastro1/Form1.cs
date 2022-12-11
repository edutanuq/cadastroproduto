namespace Cadastro1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //1o Passo: guardar em variáveis os valores digitados na tela para nome, cod e quant.
            string Nome = txtbNome.Text;
            int cod = Convert.ToInt32(txtbCod.Text);
            int quant = Convert.ToInt32(txtbQuant.Text);
            double PrecoUnit = Convert.ToDouble(txtbQuant.Text);
            try
            {
                BancoDeDados.cadastrarProduto(Nome, cod, quant, PrecoUnit);
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }