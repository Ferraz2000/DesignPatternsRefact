using DesignPatterns.Cap5Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap4Interpreter
{
    public class RaizQuadrada : IExpressao
    {
        private IExpressao expressao;

        public RaizQuadrada(IExpressao e)
        {
            this.expressao = e;
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(expressao.Avalia());
        }
        public void Aceita(IVisitor impressora)
        {
            impressora.VisitaRaizQuadrada(this);
        }
    }
}
