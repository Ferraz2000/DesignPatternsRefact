using DesignPatterns.Cap5Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap4Interpreter
{
    public interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }

}
