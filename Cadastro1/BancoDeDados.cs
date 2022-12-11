using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cadastro1
{
    internal class BancoDeDados
    {
        private static MySqlConnection bdConn; //método para fazer a conexão ao banco de dados

        public static void conecta()
        {
            //instancia a classe MySqlConnection passando a string de conexão
            bdConn = new MySqlConnection("server=localhost;database=bdBanco;uid=root;pwd=''; SSL Mode = None");
        try
            {
                bdConn.Open(); // tenta abrir uma conexão com o banco de dados.
            }
        catch
            {
        throw new Exception("Erro de Conexão"); //lança uma exceção  indicando que houve um erro de conexão
            }
        }

        //método para encerrar a conexão com o banco de dados
        public static void desconecta()
        {
            bdConn.Close(); //desconecta a base de dados
        }

        public static void cadastrarProduto(string Nome, int cod, int quant, double PrecoUnit)
        {
            try
            {
                conecta();

                MySqlCommand cmd = new MySqlCommand("Insert into PRODUTO(COD, NOME, ENDERECO) values(@COD, @NOME, @QUANT, @PRECOUNIT)", bdConn);
                

                cmd.Parameters.AddWithValue("@COD", cod);
                cmd.Parameters.AddWithValue("@NOME", Nome);
                cmd.Parameters.AddWithValue("@QUANT", quant);
                cmd.Parameters.AddWithValue("@PRECOUNIT", PrecoUnit);
                cmd.ExecuteNonQuery();

                desconecta();
            }
            catch
            {
                desconecta();

                throw new Exception("Erro ao cadastrar o produto");
            }
        }

        public static Produto consultar_produto_por_cod(string codBuscado)
        {
            Produto? achado = null;
            string? nome;
            int cod, quant;
            double preco;
            string comando = "Select * from PRODUTO where  = @CPF";
            conecta();
            MySqlCommand cmd = new MySqlCommand(comando, bdConn);
            cmd.Parameters.AddWithValue("@COD", codBuscado);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod = Convert.ToInt32(reader["cod"].ToString());
                nome = reader["nome"].ToString();
                quant = Convert.ToInt32(reader["quant"].ToString());
                preco = Convert.ToDouble(reader["preco"].ToString());

                achado = new Produto(cod, nome!, quant, preco);
            }
            reader.Close();
            desconecta();
            return achado!;
        }

        public static List<Produto> consultar_produto_por_nome(string parteNome)
        {
            List<Produto?> produtosAchados = new List<Produto?>();
            string? nome;
            int cod, quant;
            double preco;
            string comando = "Select * from Produto where nome like @nome";
            conecta();
            MySqlCommand cmd = new MySqlCommand(comando, bdConn);
            cmd.Parameters.AddWithValue("@nome", parteNome + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cod = Convert.ToInt32(reader["cod"].ToString());
                nome = reader["nome"].ToString();
                quant = Convert.ToInt32(reader["quant"].ToString());
                preco = Convert.ToDouble(reader["preco"].ToString());
                Produto cl = new Produto(cod, nome!, quant, preco);
                produtosAchados.Add(cl);
            }
            reader.Close();
            desconecta();
            return produtosAchados;
        }
    }
}