using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a tabela Esv_Pedidos_Cesta
    /// </summary>
    [XmlType("ESV_PEDIDOS_CESTA")]
    public class Esv_Pedidos_Cesta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AJUSTARREQUISICAO
        /// Comentário: 
        /// </summary>
        private string ajustarrequisicao;
        [XmlElement(ElementName = "AJUSTARREQUISICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 1)]
        public string Ajustarrequisicao
        {
            get { return ajustarrequisicao; }
            set { ajustarrequisicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BONIFICACAO
        /// Comentário: 
        /// </summary>
        private string bonificacao;
        [XmlElement(ElementName = "BONIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Bonificacao
        {
            get { return bonificacao; }
            set { bonificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTE
        /// Comentário: 
        /// </summary>
        private string cliente;
        [XmlElement(ElementName = "CLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 60)]
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIENTE
        /// Comentário: 
        /// </summary>
        private decimal codcliente;
        [XmlElement(ElementName = "CODCLIENTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codcliente
        {
            get { return codcliente; }
            set { codcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBRANCA
        /// Comentário: 
        /// </summary>
        private string codcobranca;
        [XmlElement(ElementName = "CODCOBRANCA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 4)]
        public string Codcobranca
        {
            get { return codcobranca; }
            set { codcobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMPRESA
        /// Comentário: 
        /// </summary>
        private string codempresa;
        [XmlElement(ElementName = "CODEMPRESA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public string Codempresa
        {
            get { return codempresa; }
            set { codempresa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERACAO
        /// Comentário: 
        /// </summary>
        private decimal codoperacao;
        [XmlElement(ElementName = "CODOPERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 4)]
        public decimal Codoperacao
        {
            get { return codoperacao; }
            set { codoperacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAGAMENTO
        /// Comentário: 
        /// </summary>
        private decimal codpagamento;
        [XmlElement(ElementName = "CODPAGAMENTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codpagamento
        {
            get { return codpagamento; }
            set { codpagamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOALT
        /// Comentário: 
        /// </summary>
        private decimal codusuarioalt;
        [XmlElement(ElementName = "CODUSUARIOALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codusuarioalt
        {
            get { return codusuarioalt; }
            set { codusuarioalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOAPR
        /// Comentário: 
        /// </summary>
        private decimal codusuarioapr;
        [XmlElement(ElementName = "CODUSUARIOAPR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codusuarioapr
        {
            get { return codusuarioapr; }
            set { codusuarioapr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOAPROVACAO
        /// Comentário: 
        /// </summary>
        private decimal codusuarioaprovacao;
        [XmlElement(ElementName = "CODUSUARIOAPROVACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 8)]
        public decimal Codusuarioaprovacao
        {
            get { return codusuarioaprovacao; }
            set { codusuarioaprovacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOEXC
        /// Comentário: 
        /// </summary>
        private decimal codusuarioexc;
        [XmlElement(ElementName = "CODUSUARIOEXC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codusuarioexc
        {
            get { return codusuarioexc; }
            set { codusuarioexc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOINC
        /// Comentário: 
        /// </summary>
        private decimal codusuarioinc;
        [XmlElement(ElementName = "CODUSUARIOINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codusuarioinc
        {
            get { return codusuarioinc; }
            set { codusuarioinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVENDEDOR
        /// Comentário: 
        /// </summary>
        private decimal codvendedor;
        [XmlElement(ElementName = "CODVENDEDOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codvendedor
        {
            get { return codvendedor; }
            set { codvendedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA
        /// Comentário: 
        /// </summary>
        private decimal condvenda;
        [XmlElement(ElementName = "CONDVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public decimal Condvenda
        {
            get { return condvenda; }
            set { condvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAORDEM
        /// Comentário: 
        /// </summary>
        private string contaordem;
        [XmlElement(ElementName = "CONTAORDEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Contaordem
        {
            get { return contaordem; }
            set { contaordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORACAD
        /// Comentário: 
        /// </summary>
        private DateTime? datahoracad;
        [XmlElement(ElementName = "DATAHORACAD", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Datahoracad
        {
            get { return datahoracad; }
            set { datahoracad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtalteracao
        {
            get { return dtalteracao; }
            set { dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAPROVACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtaprovacao;
        [XmlElement(ElementName = "DTAPROVACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtaprovacao
        {
            get { return dtaprovacao; }
            set { dtaprovacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtcadastro
        {
            get { return dtcadastro; }
            set { dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMBARQUE
        /// Comentário: 
        /// </summary>
        private DateTime? dtembarque;
        [XmlElement(ElementName = "DTEMBARQUE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtembarque
        {
            get { return dtembarque; }
            set { dtembarque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtemissao
        {
            get { return dtemissao; }
            set { dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTREGA
        /// Comentário: 
        /// </summary>
        private DateTime? dtentrega;
        [XmlElement(ElementName = "DTENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtentrega
        {
            get { return dtentrega; }
            set { dtentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtexclusao
        {
            get { return dtexclusao; }
            set { dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROGRAMACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtprogramacao;
        [XmlElement(ElementName = "DTPROGRAMACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtprogramacao
        {
            get { return dtprogramacao; }
            set { dtprogramacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECARPORCLIENTEPRINCIPAL
        /// Comentário: 
        /// </summary>
        private string enderecarporclienteprincipal;
        [XmlElement(ElementName = "ENDERECARPORCLIENTEPRINCIPAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Enderecarporclienteprincipal
        {
            get { return enderecarporclienteprincipal; }
            set { enderecarporclienteprincipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENTREGAFUTURA
        /// Comentário: 
        /// </summary>
        private string entregafutura;
        [XmlElement(ElementName = "ENTREGAFUTURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Entregafutura
        {
            get { return entregafutura; }
            set { entregafutura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTOQUE
        /// Comentário: 
        /// </summary>
        private string estoque;
        [XmlElement(ElementName = "ESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FINANCEIRO
        /// Comentário: 
        /// </summary>
        private string financeiro;
        [XmlElement(ElementName = "FINANCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Financeiro
        {
            get { return financeiro; }
            set { financeiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRETE
        /// Comentário: 
        /// </summary>
        private string frete;
        [XmlElement(ElementName = "FRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Frete
        {
            get { return frete; }
            set { frete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Comentário: 
        /// </summary>
        private string importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 1)]
        public string Importado
        {
            get { return importado; }
            set { importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOVIMENTO
        /// Comentário: 
        /// </summary>
        private string movimento;
        [XmlElement(ElementName = "MOVIMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Movimento
        {
            get { return movimento; }
            set { movimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NAOPRODUZIDO
        /// Comentário: 
        /// </summary>
        private string naoproduzido;
        [XmlElement(ElementName = "NAOPRODUZIDO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Naoproduzido
        {
            get { return naoproduzido; }
            set { naoproduzido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMENTREGAFUTURA
        /// Comentário: 
        /// </summary>
        private decimal numentregafutura;
        [XmlElement(ElementName = "NUMENTREGAFUTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Numentregafutura
        {
            get { return numentregafutura; }
            set { numentregafutura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPALETE
        /// Comentário: 
        /// </summary>
        private decimal numpalete;
        [XmlElement(ElementName = "NUMPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Numpalete
        {
            get { return numpalete; }
            set { numpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDO
        /// Comentário: 
        /// </summary>
        private decimal numpedido;
        [XmlElement(ElementName = "NUMPEDIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 10)]
        public decimal Numpedido
        {
            get { return numpedido; }
            set { numpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDOCLI
        /// Comentário: 
        /// </summary>
        private string numpedidocli;
        [XmlElement(ElementName = "NUMPEDIDOCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 15)]
        public string Numpedidocli
        {
            get { return numpedidocli; }
            set { numpedidocli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDODEVOLVIDO
        /// Comentário: 
        /// </summary>
        private decimal numpedidodevolvido;
        [XmlElement(ElementName = "NUMPEDIDODEVOLVIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Numpedidodevolvido
        {
            get { return numpedidodevolvido; }
            set { numpedidodevolvido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDOORIGEM
        /// Comentário: 
        /// </summary>
        private decimal numpedidoorigem;
        [XmlElement(ElementName = "NUMPEDIDOORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Numpedidoorigem
        {
            get { return numpedidoorigem; }
            set { numpedidoorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIAS
        /// Comentário: 
        /// </summary>
        private decimal numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 4)]
        public decimal Numvias
        {
            get { return numvias; }
            set { numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSAPROVACAO
        /// Comentário: 
        /// </summary>
        private string obsaprovacao;
        [XmlElement(ElementName = "OBSAPROVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Obsaprovacao
        {
            get { return obsaprovacao; }
            set { obsaprovacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSARMAZENAGEM
        /// Comentário: 
        /// </summary>
        private string obsarmazenagem;
        [XmlElement(ElementName = "OBSARMAZENAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Obsarmazenagem
        {
            get { return obsarmazenagem; }
            set { obsarmazenagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSCANCELAMENTO
        /// Comentário: 
        /// </summary>
        private string obscancelamento;
        [XmlElement(ElementName = "OBSCANCELAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Obscancelamento
        {
            get { return obscancelamento; }
            set { obscancelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSCLIENTE
        /// Comentário: 
        /// </summary>
        private string obscliente;
        [XmlElement(ElementName = "OBSCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Obscliente
        {
            get { return obscliente; }
            set { obscliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: 
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSPRODUCAO
        /// Comentário: 
        /// </summary>
        private string obsproducao;
        [XmlElement(ElementName = "OBSPRODUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Obsproducao
        {
            get { return obsproducao; }
            set { obsproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERACAO
        /// Comentário: 
        /// </summary>
        private string operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 100)]
        public string Operacao
        {
            get { return operacao; }
            set { operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGAMENTO
        /// Comentário: 
        /// </summary>
        private string pagamento;
        [XmlElement(ElementName = "PAGAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Pagamento
        {
            get { return pagamento; }
            set { pagamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEDIDOCLIENTENOXML
        /// Comentário: 
        /// </summary>
        private string pedidoclientenoxml;
        [XmlElement(ElementName = "PEDIDOCLIENTENOXML", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 1)]
        public string Pedidoclientenoxml
        {
            get { return pedidoclientenoxml; }
            set { pedidoclientenoxml = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEDIDOESTOQUE
        /// Comentário: 
        /// </summary>
        private string pedidoestoque;
        [XmlElement(ElementName = "PEDIDOESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Pedidoestoque
        {
            get { return pedidoestoque; }
            set { pedidoestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Comentário: 
        /// </summary>
        private string posicao;
        [XmlElement(ElementName = "POSICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 1)]
        public string Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREFERENCIAL
        /// Comentário: 
        /// </summary>
        private string preferencial;
        [XmlElement(ElementName = "PREFERENCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Preferencial
        {
            get { return preferencial; }
            set { preferencial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTABERTO
        /// Comentário: 
        /// </summary>
        private decimal qtaberto;
        [XmlElement(ElementName = "QTABERTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtaberto
        {
            get { return qtaberto; }
            set { qtaberto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCESTAS
        /// Comentário: 
        /// </summary>
        private decimal qtcestas;
        [XmlElement(ElementName = "QTCESTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtcestas
        {
            get { return qtcestas; }
            set { qtcestas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCESTASSALDO
        /// Comentário: 
        /// </summary>
        private decimal qtcestassaldo;
        [XmlElement(ElementName = "QTCESTASSALDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtcestassaldo
        {
            get { return qtcestassaldo; }
            set { qtcestassaldo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTITULOSVENCIDOS
        /// Comentário: 
        /// </summary>
        private decimal qttitulosvencidos;
        [XmlElement(ElementName = "QTTITULOSVENCIDOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qttitulosvencidos
        {
            get { return qttitulosvencidos; }
            set { qttitulosvencidos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REQSEMPRODUZIR
        /// Comentário: 
        /// </summary>
        private string reqsemproduzir;
        [XmlElement(ElementName = "REQSEMPRODUZIR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Reqsemproduzir
        {
            get { return reqsemproduzir; }
            set { reqsemproduzir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUA
        /// Comentário: 
        /// </summary>
        private string rua;
        [XmlElement(ElementName = "RUA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARADO
        /// Comentário: 
        /// </summary>
        private string separado;
        [XmlElement(ElementName = "SEPARADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Separado
        {
            get { return separado; }
            set { separado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIMPLESREMESSA
        /// Comentário: 
        /// </summary>
        private string simplesremessa;
        [XmlElement(ElementName = "SIMPLESREMESSA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Simplesremessa
        {
            get { return simplesremessa; }
            set { simplesremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMORDEMPRODUCAO
        /// Comentário: 
        /// </summary>
        private string temordemproducao;
        [XmlElement(ElementName = "TEMORDEMPRODUCAO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Temordemproducao
        {
            get { return temordemproducao; }
            set { temordemproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMORDEMSEPARACAO
        /// Comentário: 
        /// </summary>
        private string temordemseparacao;
        [XmlElement(ElementName = "TEMORDEMSEPARACAO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Temordemseparacao
        {
            get { return temordemseparacao; }
            set { temordemseparacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSFERENCIA
        /// Comentário: 
        /// </summary>
        private string transferencia;
        [XmlElement(ElementName = "TRANSFERENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Transferencia
        {
            get { return transferencia; }
            set { transferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOALTERACAO
        /// Comentário: 
        /// </summary>
        private string usuarioalteracao;
        [XmlElement(ElementName = "USUARIOALTERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Usuarioalteracao
        {
            get { return usuarioalteracao; }
            set { usuarioalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOEXCLUSAO
        /// Comentário: 
        /// </summary>
        private string usuarioexclusao;
        [XmlElement(ElementName = "USUARIOEXCLUSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Usuarioexclusao
        {
            get { return usuarioexclusao; }
            set { usuarioexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOINCLUSAO
        /// Comentário: 
        /// </summary>
        private string usuarioinclusao;
        [XmlElement(ElementName = "USUARIOINCLUSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Usuarioinclusao
        {
            get { return usuarioinclusao; }
            set { usuarioinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDEDOR
        /// Comentário: 
        /// </summary>
        private string vendedor;
        [XmlElement(ElementName = "VENDEDOR", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 40)]
        public string Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Comentário: 
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Vltotal
        {
            get { return vltotal; }
            set { vltotal = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Esv_Pedidos_Cesta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESV_PEDIDOS_CESTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esv_Pedidos_Cesta> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esv_Pedidos_Cesta.GetStringConnection());
            return ba.Listar<Esv_Pedidos_Cesta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esv_Pedidos_Cesta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esv_Pedidos_Cesta.GetStringConnection());
            return ba.Existe<Esv_Pedidos_Cesta>(where);
        }

        #endregion
    }
}
