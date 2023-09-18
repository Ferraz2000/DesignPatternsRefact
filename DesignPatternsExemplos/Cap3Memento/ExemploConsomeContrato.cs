using DesignPatterns.Cap3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap3Memento
{
    public class ExemploConsomeContrato
    {
        public void ConsomeContrato()
        {
            Historico historico = new Historico();
            Contrato c = new Contrato(DateTime.Now, "Lucas", TipoContrato.Novo);

            historico.AdicionaEstadoDoContrato(c.GravaEstado());

            c.Avanca();
            historico.AdicionaEstadoDoContrato(c.GravaEstado());


            c.Avanca();
            historico.AdicionaEstadoDoContrato(c.GravaEstado());

            Console.WriteLine(c.Tipo.ToString());
            Console.WriteLine(historico.PegaEstado(0).Contrato.Tipo);

            Console.ReadKey();
        }
    }
}
