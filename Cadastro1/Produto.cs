using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cadastro1
{
    class Produto
    {
        public int cod { get; private set; }
        public string Nome { get; set; }
        public int quant { get; set; }
        public double PrecoUnit { get; set; }
        public Produto(int cod, string Nome, int quant, double PrecoUnit)
        {
            this.Nome = Nome;
            this.cod = cod;
            this.quant = quant;
            this.PrecoUnit = PrecoUnit;
        }
    }
}