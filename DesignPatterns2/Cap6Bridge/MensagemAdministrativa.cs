using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap6Bridge
{
    public class MensagemAdministrativa : IMensagem
    {
        private string Nome;
        public IEnviador Enviador { get; set; }
        public MensagemAdministrativa(string nome)
        {
            this.Nome = nome;
        }
        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format($"Enviando a mensagem para o administrador {this.Nome}");
        }
    }
}
