using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap7Command
{
    public class FinalizaPedido : IComando
    {
        private Pedido pedido;

        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            pedido.Finaliza();
            Console.WriteLine($"Finalizando o pedido do Cliente {pedido.Cliente}");
        }
    }
}
