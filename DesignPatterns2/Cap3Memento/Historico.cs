using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap3
{
    public class Historico
    {
        private IList<EstadoDoContrato> estado = new List<EstadoDoContrato>();

        public void AdicionaEstadoDoContrato(EstadoDoContrato estado)
        {
            this.estado.Add(estado);
        }
        public EstadoDoContrato PegaEstado(int indice)
        {
            return estado[indice];
        }
    }
}
