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
        /// Comentário: Campo para armazenar o código da administradora de cartão.
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
        /// Comentário: Campo para armazenar o código de autorização da venda TEF.
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
        /// Comentário: Campo para armazenar o código de autorização da venda TEF anterior à conciliação dos títulos.
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
        /// Comentário: Campo para armazenar o código da filial.
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
        /// Comentário: Campo para armazenar o código do funcionário que realizou a conciliação dos títulos.
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
        /// Comentário: Campo para armazenar o código do funcionário que realizou a conciliação de vencimento.
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
        /// Comentário: Campo para armazenar a data e hora de conciliação dos títulos.
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
        /// Comentário: Campo para armazenar a data e hora de conciliação do vencimento.
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
        /// Comentário: Campo para armazenar a data de emissão.
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
        /// Comentário: Campo para armazenar a data de emissão anterior à conciliação dos títulos.
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
        /// Comentário: Campo para armazenar a data de vencimento.
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
        /// Comentário: Campo para armazenar a data de do contas a receber antes de realizar a conciliação.
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
        /// Comentário: Campo para armazenar o número da duplicata.
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
        /// Comentário: Campo para armazenar o NSU do título.
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
        /// Comentário: Campo para armazenar a data de do contas a receber antes de realizar a conciliação.
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
        /// Comentário: Campo para armazenar o número do cartão.
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
        /// Comentário: Campo para armazenar o número do lote gerado para conciliação de cartões.
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
        /// Comentário: Campo para armazenar a prestação da duplicata.
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
        /// Comentário: Campo para identificar o tipo da operação do registro.
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
        /// Comentário: Campo para armazenar o valor do título.
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConciliacartao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConciliacartao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
