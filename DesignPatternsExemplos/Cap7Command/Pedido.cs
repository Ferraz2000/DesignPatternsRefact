using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap7Command
{
    public class Pedido
    {
        public Pedido(string cliente, double valorDoPedido)
        {
            Cliente = cliente;
            ValorDoPedido = valorDoPedido;
            this.Status = Status.Novo;
        }

        public string Cliente { get; private set; }
        public Double ValorDoPedido { get; private set; }
        public DateTime DataDeFinalizacaoDoPedido { get; private set; }
        public Status Status { get; private set; }

        public void Paga()
        {
            Status = Status.Pago;
        }
        public void Finaliza()
        {
            Status = Status.Entregue;
            DataDeFinalizacaoDoPedido = DateTime.Now;
        }
    }
}
