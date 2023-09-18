using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap7Command
{
    public class ExemploConsomeCommand
    {
        public void Consome()
        {
            FilaDeTrabalho filaDeTrabalho = new FilaDeTrabalho();

            Pedido pedido1 = new Pedido("Mauricio", 100);
            Pedido pedido2 = new Pedido("Lucas", 300);

            filaDeTrabalho.Adiciona(new PagaPedido(pedido1));
            filaDeTrabalho.Adiciona(new PagaPedido(pedido2));


            filaDeTrabalho.Adiciona(new FinalizaPedido(pedido1));

            filaDeTrabalho.Processa();
            Console.ReadKey();

        }
    }
}
