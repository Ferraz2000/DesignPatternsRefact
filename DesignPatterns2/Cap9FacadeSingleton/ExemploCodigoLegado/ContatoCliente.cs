using DesignPatterns.Cap8Adapter;
using System;

namespace DesignPatterns.Cap9FacadeSingleton
{
    public class ContatoCliente
    {
        private Cliente cliente;
        private Cobranca cobranca;

        public ContatoCliente(Cliente cliente, Cobranca cobranca)
        {
            this.cliente = cliente;
            this.cobranca = cobranca;
        }

        internal void Dispara()
        {
            throw new NotImplementedException();
        }
    }
}