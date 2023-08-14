using DesignPatterns.Cap4Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap5Visitor
{
    public interface IVisitor
    {
        void VisitaSoma(Soma soma);
        void VisitaSubtracao(Subtracao subtracao);
        void VisitaNumero(Numero numero);
        void VisitaDivisao(Divisao numero);
        void VisitaMultiplicacao(Multiplicacao multiplicacao);
        void VisitaRaizQuadrada(RaizQuadrada raizQuadrada);
    }
}
