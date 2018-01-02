using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integradora.ERP.Winthor.EntityPedidoDireto
{
    public class ItemPedido : BaseTabelas
    {
        public ItemPedido()
        {
            Quantidade = 0;
            Precotabela = 0;
            Precovenda = 0;
            Percentualdesconto = 0;
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMITEM
        /// Comentário: 
        /// </summary>
        private Int32 numitem;
        public Int32 Numitem
        {
            get { return numitem; }
            set { numitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Comentário: 
        /// </summary>
        private decimal codproduto;
        public decimal Codproduto
        {
            get { return codproduto; }
            set { codproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADE
        /// Comentário: 
        /// </summary>
        private decimal quantidade;
        public decimal Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOVENDA
        /// Comentário: 
        /// </summary>
        private decimal precovenda;
        public decimal Precovenda
        {
            get { return precovenda; }
            set { precovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOTABELA
        /// Comentário: 
        /// </summary>
        private decimal precotabela;
        public decimal Precotabela
        {
            get { return precotabela; }
            set { precotabela = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: PERCENTUALDESCONTO
        /// Comentário: 
        /// </summary>
        private decimal percentualdesconto;
        public decimal Percentualdesconto
        {
            get { return percentualdesconto; }
            set { percentualdesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDECAIXA
        /// Comentário: 
        /// </summary>
        private decimal qtdecaixa;
        public decimal Qtdecaixa
        {
            get { return qtdecaixa; }
            set { qtdecaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBRUTO
        /// Comentário: 
        /// </summary>
        private decimal pesobruto;
        public decimal Pesobruto
        {
            get { return pesobruto; }
            set { pesobruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOLIQUIDO
        /// Comentário: 
        /// </summary>
        private decimal pesoliquido;
        public decimal Pesoliquido
        {
            get { return pesoliquido; }
            set { pesoliquido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEUNITARIA
        /// Comentário: 
        /// </summary>
        private decimal qtdeunitaria;
        public decimal Qtdeunitaria
        {
            get { return qtdeunitaria; }
            set { qtdeunitaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal? codauxiliar;
        public decimal? Codauxiliar
        {
            get { return codauxiliar; }
            set { codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEM
        /// Comentário: 
        /// </summary>
        private string embalagem;
        public string Embalagem
        {
            get { return embalagem; }
            set { embalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE
        /// Comentário: 
        /// </summary>
        private string unidade;
        public string Unidade
        {
            get { return unidade; }
            set { unidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADEMASTER
        /// Comentário: 
        /// </summary>
        private string unidademaster;
        public string Unidademaster
        {
            get { return unidademaster; }
            set { unidademaster = value; }
        }

    }
}