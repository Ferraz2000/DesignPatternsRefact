using DesignPatterns.Cap4Interpreter;
using System;


namespace DesignPatterns.Cap5Visitor
{
    public class ExemploConsomeCalculadoraComImpressora
    {
        public void Consome()
        {
            //( ( 1 + 100 ) + 10 ) + ( 20 - 10 )
            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());

            ImpressoraVisitor impressora = new ImpressoraVisitor();
            soma.Aceita(impressora);
            Console.ReadKey();
        }
    }
}
