﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cap9FacadeSingleton
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();
        public EmpresaFacade Instancia
        {
            get
            {
                return facade;
            }
        }
    }
}
