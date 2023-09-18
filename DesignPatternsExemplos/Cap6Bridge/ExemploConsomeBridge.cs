using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap6Bridge
{
    public class ExemploConsomeBridge
    {
        public void Consome()
        {
            IEnviador enviadorPorEmail = new EnviaPorEmail();
            IEnviador enviadorPorSms = new EnviaPorSMS();

            IMensagem mensagemAdministrativa = new MensagemAdministrativa("Lucas");
            mensagemAdministrativa.Enviador = enviadorPorEmail;
            mensagemAdministrativa.Envia();

            mensagemAdministrativa.Enviador = enviadorPorSms;
            mensagemAdministrativa.Envia();

            IMensagem mensagemCliente = new MensagemCliente("Lucas");
            mensagemCliente.Enviador = enviadorPorEmail;
            mensagemCliente.Envia();

            mensagemCliente.Enviador = enviadorPorSms;
            mensagemCliente.Envia();

            Console.ReadKey();
        }
    }
}
