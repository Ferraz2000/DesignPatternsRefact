using DesignPatterns.Cap2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap2Flyweight
{
    public class ExemploConsomeNotasMusicais
    {
        public void Consome()
        {
            NotasMusicais notasMusicais = new NotasMusicais();
            IList<INota> musica = new List<INota>()
           {
              notasMusicais.Pega("do"),
              notasMusicais.Pega("re"),
              notasMusicais.Pega("mi"),
              notasMusicais.Pega("fa"),
              notasMusicais.Pega("fa"),
              notasMusicais.Pega("fa")
           };
            Piano piano = new Piano();
            piano.Toca(musica);
        }
    }
}
