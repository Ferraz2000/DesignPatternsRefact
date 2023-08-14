﻿using System;

namespace DesignPatterns.Cap9FacadeSingleton
{
    public class Cobranca
    {
        private Tipo tipo;
        private Fatura fatura;

        public Cobranca(Tipo tipo, Fatura fatura)
        {
            this.tipo = tipo;
            this.fatura = fatura;
        }

        internal void Emite()
        {
            throw new NotImplementedException();
        }
    }
}