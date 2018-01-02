using Integradora.Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce
{
    public abstract class Lojavirtual : IECommerce
    {
        public abstract Biblioteca.Dictionaries.Tips.ECommerce ECommerce();
        public abstract void Initialize();

        /// <summary>
        /// Propriedade referente ao campo: CODCD
        /// Comentário: Filial de Origem (CD)
        /// </summary>
        private bool criarcreditoparacliente;
        public bool CriarCreditoParaCliente
        {
            get { return criarcreditoparacliente; }
            set { criarcreditoparacliente = value; }
        }
    }
}
