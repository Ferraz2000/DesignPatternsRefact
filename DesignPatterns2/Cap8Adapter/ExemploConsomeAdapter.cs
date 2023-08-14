using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap8Adapter
{
    public class ExemploConsomeAdapter
    {
        public void Consome()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Lucas";
            cliente.Endereco = "Rua 3";
            cliente.DataDeNascimento = DateTime.Now;

            String xml = new GeradorDeXml().GeraXML(cliente);

            Console.WriteLine(xml);
        }
    }
}
