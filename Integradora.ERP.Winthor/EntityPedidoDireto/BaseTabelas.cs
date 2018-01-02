using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integradora.ERP.Winthor.EntityPedidoDireto
{
    public class BaseTabelas
    {
        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusao;
        public DateTime? Dtinclusao
        {
            get { return dtinclusao; }
            set { dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtalteracao;
        public DateTime? Dtalteracao
        {
            get { return dtalteracao; }
            set { dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSINTEGRACAO
        /// Comentário: Campo de observação das integração
        /// </summary>
        private string obsintegracao;
        public string Obsintegracao
        {
            get { return obsintegracao; }
            set { obsintegracao = value; }
        }
    }
}