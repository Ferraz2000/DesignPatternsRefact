using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap4Interpreter
{
    public class ExemploConsomeCalculadora
    {
        public void Consome()
        {
            //( ( 1 + 100 ) + 10 ) + ( 20 - 10 )
            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());

            Expression somaExpression = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            Func<int> funcao = Expression.Lambda<Func<int>>(somaExpression).Compile();
            Console.WriteLine(funcao());

            Console.ReadKey();
        }
    }
}
