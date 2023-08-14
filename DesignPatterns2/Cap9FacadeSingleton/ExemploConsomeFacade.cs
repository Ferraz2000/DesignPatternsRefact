using DesignPatterns.Cap8Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap9FacadeSingleton
{
    public class ExemploConsomeFacade
    {
        public void Consome()
        {
            string cpf = "1234";
            EmpresaFacade empresaFacade = new EmpresaFacadeSingleton().Instancia;
            Cliente cliente = empresaFacade.BuscaCliente(cpf);
            Fatura fatura = empresaFacade.CriaFatura(cliente, 5000);
            Cobranca cobranca = empresaFacade.GeraCobranca(Tipo.Boleto, fatura);
        }
    }
}
