using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integradora.ERP.Winthor.EntityPedidoDireto
{
    public class ParcelaPedido : BaseTabelas
    {
        public ParcelaPedido()
        {
            Valor = 0;
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPARCELA
        /// Comentário: 
        /// </summary>
        private Int32 numparcela;
        public Int32 Numparcela
        {
            get { return numparcela; }
            set { numparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private Decimal valor;
        public Decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCIMENTO
        /// Comentário: 
        /// </summary>
        private DateTime dtvencimento;
        public DateTime Dtvencimento
        {
            get { return dtvencimento; }
            set { dtvencimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSU
        /// Comentário: 
        /// </summary>
        private string nsu;
        public string NSU
        {
            get { return nsu; }
            set { nsu = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: NSU
        /// Comentário: 
        /// </summary>
        private Decimal? codautorizacao;
        public Decimal? CodAutorizacao
        {
            get { return codautorizacao; }
            set { codautorizacao = value; }
        }
    }
}