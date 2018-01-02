using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.Views
{
    /// <summary>
    /// Classe referente ao select VWEmbalagens
    /// </summary>
    [XmlType("VWEMBALAGENS")]
    public class VWEmbalagens : OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWEmbalagens()
        {
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWEmbalagens> Listar(string where)
        {
            string filtro = where.ToUpper().Replace("ROWID", "OID");
            Persistencia ba = new Persistencia(VWEmbalagens.GetStringConnection());
            return ba.Listar<VWEmbalagens>(GetSelect(), filtro);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWEmbalagens> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(VWEmbalagens.GetStringConnection());
            return ba.Existe<VWEmbalagens>(where);
        }

        /// <summary>
        /// Retorna o select de obteção dos registros
        /// </summary>
        public static string GetSelect()
        {
            return @"SELECT A.*
                       FROM (SELECT PCEMBALAGEM.CODAUXILIAR SKU
                                  , PCEMBALAGEM.ROWID OID
                                  , PCEMBALAGEM.CODPROD
                                  , PCEMBALAGEM.CODFILIAL
                                  , PCPRODUT.CODDEPTOWEB
                                  , NVL(PCEMBALAGEM.DESCRICAOWEB, PCPRODUT.DESCRICAO) DESCRICAO
                                  , NVL(PCEMBALAGEM.PVENDAWEB, NVL(PCEMBALAGEM.PVENDA, 0)) PVENDA
                                  , NVL(PCEMBALAGEM.POFERTAWEB, NVL(PCEMBALAGEM.POFERTA, 0)) POFERTA
                                  , NVL(PCEMBALAGEM.PESOBRUTO, 0) PESO
                                  , NVL(PCEMBALAGEM.ALTURA, 0) ALTURA
                                  , NVL(PCEMBALAGEM.COMPRIMENTO, 0) COMPRIMENTO
                                  , NVL(PCEMBALAGEM.LARGURA, 0) LARGURA
                                  , 0 FRETEGRATIS
                                  , 0 TROCAGRATIS
                                  , 0 PRAZOENTREGA
                                  , PCFORNEC.CODFORNEC
                                  , PCFORNEC.FORNECEDOR
                                  , PCFORNEC.CGC
                                  , PCFORNEC.ENDER ENDERECO
                                  , PCFORNEC.BAIRRO
                                  , PCFORNEC.CIDADE
                                  , PCFORNEC.ESTADO
                                  , PCFORNEC.CEP
                                  , PCFORNEC.NUMEROEND NUMERO
                                  , PCFORNEC.COMPLEMENTOEND COMPLEMENTO
                                  , PCEST.CUSTOFIN CUSTO
                                  , TRUNC((NVL(PCEST.QTRESERV, 0) * 0.3) / PCEMBALAGEM.QTUNIT) QTRESERV
                                  , TRUNC((NVL(PCEST.QTESTGER, 0) - NVL(PCEST.QTRESERV, 0) - NVL(PCEST.QTBLOQUEADA, 0) * 0.3) / PCEMBALAGEM.QTUNIT) QTESTOQUE
                               FROM PCEMBALAGEM
                                  , PCEST
                                  , PCPRODUT
                                  , PCFORNEC
                              WHERE PCEMBALAGEM.CODFILIAL = PCEST.CODFILIAL
                                AND PCEMBALAGEM.CODPROD = PCEST.CODPROD
                                AND PCEMBALAGEM.CODPROD = PCPRODUT.CODPROD
                                AND PCPRODUT.CODFORNEC = PCFORNEC.CODFORNEC
                                AND PCPRODUT.DTEXCLUSAO IS NULL
                                AND PCEMBALAGEM.CODFILIAL = '1') A
                    WHERE 1=1 ";
        }
        #endregion

        #region Atributos
        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 6)]
        public decimal Codprod
        {
            get { return codprod; }
            set { codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal sku;
        [XmlElement(ElementName = "SKU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal SKU
        {
            get { return sku; }
            set { sku = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string Codfilial
        {
            get { return codfilial; }
            set { codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codfornec
        {
            get { return codfornec; }
            set { codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEPTOWEB
        /// Comentário: Codigo do Departamento na WEB
        /// </summary>
        private decimal coddeptoweb;
        [XmlElement(ElementName = "CODDEPTOWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Coddeptoweb
        {
            get { return coddeptoweb; }
            set { coddeptoweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição do Produto
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Comentário: 
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 12)]
        public decimal Pvenda
        {
            get { return pvenda; }
            set { pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTA
        /// Comentário: 
        /// </summary>
        private decimal poferta;
        [XmlElement(ElementName = "POFERTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 12)]
        public decimal Poferta
        {
            get { return poferta; }
            set { poferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESO
        /// Comentário: Indica o Peso da embalagem. 
        /// </summary>
        private decimal peso;
        [XmlElement(ElementName = "PESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURA
        /// Comentário: Altura da embalagem
        /// </summary>
        private decimal altura;
        [XmlElement(ElementName = "ALTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRIMENTO
        /// Comentário: Comprimento da embalagem
        /// </summary>
        private decimal comprimento;
        [XmlElement(ElementName = "COMPRIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Comprimento
        {
            get { return comprimento; }
            set { comprimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURA
        /// Comentário: Largura da embalagem
        /// </summary>
        private decimal largura;
        [XmlElement(ElementName = "LARGURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRETEGRATIS
        /// Comentário: Frete grátis
        /// </summary>
        private decimal fretegratis;
        [XmlElement(ElementName = "FRETEGRATIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public decimal Fretegratis
        {
            get { return fretegratis; }
            set { fretegratis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOENTREGA
        /// Comentário: Frete grátis
        /// </summary>
        private decimal prazoentrega;
        [XmlElement(ElementName = "PRAZOENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public decimal Prazoentrega
        {
            get { return prazoentrega; }
            set { prazoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TROCAGRATIS
        /// Comentário: Troca grátis
        /// </summary>
        private decimal trocagratis;
        [XmlElement(ElementName = "TROCAGRATIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public decimal Trocagratis
        {
            get { return trocagratis; }
            set { trocagratis = value; }
        }
        #endregion 

        /// <summary>
        /// Propriedade referente ao campo: CUSTO
        /// Comentário: Valor do custo da embalagem
        /// </summary>
        private decimal custo;
        [XmlElement(ElementName = "CUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 18)]
        public decimal Custo
        {
            get { return custo; }
            set { custo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTOQUE
        /// Comentário: Quantidade do estoque gerencial
        /// </summary>
        private decimal qtestoque;
        [XmlElement(ElementName = "QTESTOQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtestoque
        {
            get { return qtestoque; }
            set { qtestoque = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: QTRESERV
        /// Comentário: 
        /// </summary>
        private decimal qtreserv;
        [XmlElement(ElementName = "QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtreserv
        {
            get { return qtreserv; }
            set { qtreserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO
        /// Comentário: Indica o numero do endereço.
        /// </summary>
        private string numero;
        [XmlElement(ElementName = "NUMERO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: FORNECEDOR
        /// Comentário: 
        /// </summary>
        private string fornecedor;
        [XmlElement(ElementName = "FORNECEDOR", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 60)]
        public string Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Comentário: Indica o complemento do endereço.
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 80)]
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Comentário: 
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Comentário: 
        /// </summary>
        private string cidade;
        [XmlElement(ElementName = "CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 15)]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Comentário: 
        /// </summary>
        private string estado;
        [XmlElement(ElementName = "ESTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Comentário: 
        /// </summary>
        private string cep;
        [XmlElement(ElementName = "CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 9)]
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Comentário: Endereço do fornecedor
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: CGC
        /// Comentário: 
        /// </summary>
        private string cgc;
        [XmlElement(ElementName = "CGC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 18)]
        public string Cgc
        {
            get { return cgc; }
            set { cgc = value; }
        }



    }
}
