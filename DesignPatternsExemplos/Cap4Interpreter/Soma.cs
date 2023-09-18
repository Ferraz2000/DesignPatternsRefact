using DesignPatterns.Cap5Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap4Interpreter
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }
        public int Avalia()
        {
            int ValorEsquerda = Esquerda.Avalia();
            int ValorDireita = Direita.Avalia();
            return ValorEsquerda + ValorDireita;
        }
        public void Aceita(IVisitor impressora)
        {
            impressora.VisitaSoma(this);
        }
    }
}
