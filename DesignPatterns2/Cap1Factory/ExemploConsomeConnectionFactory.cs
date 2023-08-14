using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap1
{
    public class ExemploConsomeConnectionFactory
    {
        public void Consome()
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "Select * from tabela";
        }
    }
}
