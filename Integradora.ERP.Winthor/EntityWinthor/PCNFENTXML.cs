using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityWinthor
{
    /// <summary>
    /// Classe referente a tabela PCNfentxml
    /// </summary>
    [XmlType("PCNFENTXML")]
    public class PCNfentxml : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CHAVENFE
        /// Coment�rio: Chave NFe
        /// </summary>
        private string chavenfe;
        [XmlElement(ElementName = "CHAVENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Chavenfe
        {
            get { return  chavenfe; }
            set {  chavenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ
        /// Coment�rio: Gravar o CNPJ do Fornecedor	Gravar o CNPJ do Fornecedor
        /// </summary>
        private string cnpj;
        [XmlElement(ElementName = "CNPJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cnpj
        {
            get { return  cnpj; }
            set {  cnpj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: Gravar o C�d. Func que fez a opera��o	Gravar o C�d. Func que fez a opera��o
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DADOSXML
        /// Coment�rio: Gravar os dados do XML	Gravar os dados do XML
        /// </summary>
        private string dadosxml;
        [XmlElement(ElementName = "DADOSXML", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Dadosxml
        {
            get { return  dadosxml; }
            set {  dadosxml = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Gravar a Data de entrada do XML	Gravar a Data de entrada do XML
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Coment�rio: Gravar a data de emiss�o da nota de entrada	Gravar a data de emiss�o da nota de entrada
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Coment�rio: Gravar o n�mero da nota que est� dando entrada	Gravar o n�mero da nota que est� dando entrada
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Coment�rio: Gravar o NUMTRANSENT	Gravar o NUMTRANSENT
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Coment�rio: Gravar a s�rie da nota de entrada	Gravar a s�rie da nota de entrada
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCNfentxml()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNFENTXML";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCNfentxml> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNfentxml>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCNfentxml> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNfentxml>(where);
        }

        #endregion
    }
}
