using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integradora.ERP.Winthor.EntityPedidoDireto
{
    public class Pedido : BaseTabelas
    {
        public Pedido()
        {
            Itens = new List<ItemPedido>();
            Parcelas = new List<ParcelaPedido>();
            Cliente = new Cliente();
       
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        public string Codfilial
        {
            get { return codfilial; }
            set { codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDO
        /// Comentário: 
        /// </summary>
        private Int64 numpedido;
        public Int64 Numpedido
        {
            get { return numpedido; }
            set { numpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA
        /// Comentário: 
        /// </summary>
        private Int64 condvenda;
        public Int64 Condvenda
        {
            get { return condvenda; }
            set { condvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVENDEDOR
        /// Comentário: 
        /// </summary>
        private Int64 codvendedor;
        public Int64 Codvendedor
        {
            get { return codvendedor; }
            set { codvendedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Comentário: 
        /// </summary>
        private Int64 codsupervisor;
        public Int64 Codsupervisor
        {
            get { return codsupervisor; }
            set { codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: cliente
        /// Comentário: 
        /// </summary>
        private Cliente cliente;
        public Cliente Cliente
        {
            get { return cliente;  }
            set { cliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALPESO
        /// Comentário: 
        /// </summary>
        private Decimal totalpeso;
        public Decimal Totalpeso
        {
            get { return totalpeso; }
            set { totalpeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALVOLUME
        /// Comentário: 
        /// </summary>
        private Decimal totalvolume;
        public Decimal Totalvolume
        {
            get { return totalvolume; }
            set { totalvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORTOTAL
        /// Comentário: 
        /// </summary>
        private Decimal valortotal;
        public Decimal Valortotal
        {
            get { return valortotal; }
            set { valortotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORFRETE
        /// Comentário: 
        /// </summary>
        private Decimal valorfrete;
        public Decimal Valorfrete
        {
            get { return valorfrete; }
            set { valorfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDESCONTO
        /// Comentário: 
        /// </summary>
        private Decimal valordesconto;
        public Decimal Valordesconto
        {
            get { return valordesconto; }
            set { valordesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Comentário: 
        /// </summary>
        private DateTime dtemissao;
        public DateTime Dtemissao
        {
            get { return dtemissao; }
            set { dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTREGA
        /// Comentário: 
        /// </summary>
        private DateTime dtentrega;
        public DateTime Dtentrega
        {
            get { return dtentrega; }
            set { dtentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS
        /// Comentário: 
        /// </summary>
        private List<ItemPedido> itens;
        public List<ItemPedido> Itens
        {
            get { return itens; }
            set { itens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARCELAS
        /// Comentário: 
        /// </summary>
        private List<ParcelaPedido> parcelas;
        public List<ParcelaPedido> Parcelas
        {
            get { return parcelas; }
            set { parcelas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: 
        /// </summary>
        private string observacao;
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

    }
}