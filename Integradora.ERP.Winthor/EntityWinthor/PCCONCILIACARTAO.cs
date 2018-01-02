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
    /// Classe referente a tabela PCConciliacartao
    /// </summary>
    [XmlType("PCCONCILIACARTAO")]
    public class PCConciliacartao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODADMCARTAO
        /// Coment�rio: Campo para armazenar o c�digo da administradora de cart�o.
        /// </summary>
        private string codadmcartao;
        [XmlElement(ElementName = "CODADMCARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Codadmcartao
        {
            get { return  codadmcartao; }
            set {  codadmcartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUTORIZTEF
        /// Coment�rio: Campo para armazenar o c�digo de autoriza��o da venda TEF.
        /// </summary>
        private decimal codautoriztef;
        [XmlElement(ElementName = "CODAUTORIZTEF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codautoriztef
        {
            get { return  codautoriztef; }
            set {  codautoriztef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUTORIZTEFANT
        /// Coment�rio: Campo para armazenar o c�digo de autoriza��o da venda TEF anterior � concilia��o dos t�tulos.
        /// </summary>
        private decimal codautoriztefant;
        [XmlElement(ElementName = "CODAUTORIZTEFANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codautoriztefant
        {
            get { return  codautoriztefant; }
            set {  codautoriztefant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Campo para armazenar o c�digo da filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONCIL
        /// Coment�rio: Campo para armazenar o c�digo do funcion�rio que realizou a concilia��o dos t�tulos.
        /// </summary>
        private decimal codfuncconcil;
        [XmlElement(ElementName = "CODFUNCCONCIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncconcil
        {
            get { return  codfuncconcil; }
            set {  codfuncconcil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONCILVENC
        /// Coment�rio: Campo para armazenar o c�digo do funcion�rio que realizou a concilia��o de vencimento.
        /// </summary>
        private decimal codfuncconcilvenc;
        [XmlElement(ElementName = "CODFUNCCONCILVENC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncconcilvenc
        {
            get { return  codfuncconcilvenc; }
            set {  codfuncconcilvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONCIL
        /// Coment�rio: Campo para armazenar a data e hora de concilia��o dos t�tulos.
        /// </summary>
        private DateTime? dtconcil;
        [XmlElement(ElementName = "DTCONCIL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtconcil
        {
            get { return  dtconcil; }
            set {  dtconcil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONCILVENC
        /// Coment�rio: Campo para armazenar a data e hora de concilia��o do vencimento.
        /// </summary>
        private DateTime? dtconcilvenc;
        [XmlElement(ElementName = "DTCONCILVENC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtconcilvenc
        {
            get { return  dtconcilvenc; }
            set {  dtconcilvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Coment�rio: Campo para armazenar a data de emiss�o.
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
        /// Propriedade referente ao campo: DTEMISSAOANT
        /// Coment�rio: Campo para armazenar a data de emiss�o anterior � concilia��o dos t�tulos.
        /// </summary>
        private DateTime? dtemissaoant;
        [XmlElement(ElementName = "DTEMISSAOANT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaoant
        {
            get { return  dtemissaoant; }
            set {  dtemissaoant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Coment�rio: Campo para armazenar a data de vencimento.
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCANT
        /// Coment�rio: Campo para armazenar a data de do contas a receber antes de realizar a concilia��o.
        /// </summary>
        private DateTime? dtvencant;
        [XmlElement(ElementName = "DTVENCANT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencant
        {
            get { return  dtvencant; }
            set {  dtvencant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DUPLIC
        /// Coment�rio: Campo para armazenar o n�mero da duplicata.
        /// </summary>
        private decimal duplic;
        [XmlElement(ElementName = "DUPLIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Duplic
        {
            get { return  duplic; }
            set {  duplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSU
        /// Coment�rio: Campo para armazenar o NSU do t�tulo.
        /// </summary>
        private string nsu;
        [XmlElement(ElementName = "NSU", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Nsu
        {
            get { return  nsu; }
            set {  nsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUANT
        /// Coment�rio: Campo para armazenar a data de do contas a receber antes de realizar a concilia��o.
        /// </summary>
        private string nsuant;
        [XmlElement(ElementName = "NSUANT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nsuant
        {
            get { return  nsuant; }
            set {  nsuant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARTAO
        /// Coment�rio: Campo para armazenar o n�mero do cart�o.
        /// </summary>
        private string numcartao;
        [XmlElement(ElementName = "NUMCARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numcartao
        {
            get { return  numcartao; }
            set {  numcartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTECARTAOTEF
        /// Coment�rio: Campo para armazenar o n�mero do lote gerado para concilia��o de cart�es.
        /// </summary>
        private string numlotecartaotef;
        [XmlElement(ElementName = "NUMLOTECARTAOTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Numlotecartaotef
        {
            get { return  numlotecartaotef; }
            set {  numlotecartaotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Coment�rio: Campo para armazenar a presta��o da duplicata.
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOREGISTRO
        /// Coment�rio: Campo para identificar o tipo da opera��o do registro.
        /// </summary>
        private string tiporegistro;
        [XmlElement(ElementName = "TIPOREGISTRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Tiporegistro
        {
            get { return  tiporegistro; }
            set {  tiporegistro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Campo para armazenar o valor do t�tulo.
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCConciliacartao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONCILIACARTAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCConciliacartao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConciliacartao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCConciliacartao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConciliacartao>(where);
        }

        #endregion
    }
}
