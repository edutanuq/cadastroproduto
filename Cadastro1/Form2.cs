using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro1
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        List<Produto> produtosAchados;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //
            //Passo1: Guardar em uma variável o CPF digitado
            //string codBuscado = txtbProcCod.Text;
            //Passo2: chamar um método de consulta de cliente por CPF, que recebe o CPF como parâmetro e retorna um cliente
            //try
            {
                //Produto cl = BancoDeDados.consultar_produto_por_cod(codBuscado);
                //Passo3: Preencher o CPF, nome e endereço na tela com os dados do cliente encontrado
                //if (cl == null)
                //MessageBox.Show("Cliente não encontrado");
                //else
                {
                    //txtCod.Text = Convert.ToString(cl.cod);
                    //txtNome.Text = Convert.ToString(cl.Nome);
                    //txtQuant.Text = Convert.ToString(cl.quant);
                    //txtPreco.Text = Convert.ToString(cl.PrecoUnit);

                }
            }
            //catch
            {
                //BancoDeDados.desconecta();
                //MessageBox.Show("Erro de Consulta");
            }

            {
                //Passo1: Guardar em uma variável a parte do nome digitada
                string parteNome = cbProcNome.Text;
                //Passo2: chamar um método da classe BancoDeDados.cs de consulta de cliente por nome, que recebe a parte do nome digitada como parâmetro e retorna uma lista de todos os clientes cujo nome começa com aquela parte de nome.
                try
                {
                    produtosAchados = BancoDeDados.consultar_produto_por_nome(parteNome);
                    //Passo3: Preencher o cbBuscaNome com os nomes dos clientes da lista retornada.
                    cbProcNome.Items.Clear();
                    if (produtosAchados.Count == 0)

                        MessageBox.Show("Produto não encontrado");
                    else
                    {
                        for (int i = 0; i < produtosAchados.Count; i++)
                            cbProcNome.Items.Add(produtosAchados[i].Nome);

                    }
                }
                catch (Exception ex)
                {
                    BancoDeDados.desconecta();
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void cbProcNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posicao = cbProcNome.SelectedIndex;
            txtCod.Text = Convert.ToString(produtosAchados[posicao].cod);
            txtNome.Text = produtosAchados[posicao].Nome;
            txtQuant.Text = Convert.ToString(produtosAchados[posicao].quant);
            txtPreco.Text = Convert.ToString(produtosAchados[posicao].PrecoUnit);

        }
    }
    }

