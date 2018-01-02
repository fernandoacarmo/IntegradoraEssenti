﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.OnLine
{
    public sealed class Integracao : Integradora.ECommerce.Lojavirtual
    {
        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.OnLineShop;
        }
        public override void Initialize()
        {
            CriarCreditoParaCliente = false;
        }

        public void EnviarPrdouto()
        {
            
        }
    }
}
