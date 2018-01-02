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
    /// Classe referente a tabela PCDocemitidosecf
    /// </summary>
    [XmlType("PCDOCEMITIDOSECF")]
    public class PCDocemitidosecf : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ASSINATURA
        /// Coment�rio: C�digo MD-5.
        /// </summary>
        private string assinatura;
        [XmlElement(ElementName = "ASSINATURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Assinatura
        {
            get { return  assinatura; }
            set {  assinatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CDC
        /// Coment�rio: Comprovante de d�bito e cr�dito
        /// </summary>
        private decimal cdc;
        [XmlElement(ElementName = "CDC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Cdc
        {
            get { return  cdc; }
            set {  cdc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da Filial
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COO
        /// Coment�rio: Contador de ordem
        /// </summary>
        private decimal coo;
        [XmlElement(ElementName = "COO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Coo
        {
            get { return  coo; }
            set {  coo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data do comprovante
        /// </summary>
        private string data;
        [XmlElement(ElementName = "DATA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DENOMINICAO
        /// Coment�rio: Tipo do Comprovante
        /// </summary>
        private string denominicao;
        [XmlElement(ElementName = "DENOMINICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Denominicao
        {
            get { return  denominicao; }
            set {  denominicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Coment�rio: Data de Exporta��o para o Servidor
        /// </summary>
        private DateTime? dtexportacao;
        [XmlElement(ElementName = "DTEXPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacao
        {
            get { return  dtexportacao; }
            set {  dtexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Coment�rio: Exporta��o para Servidor
        /// </summary>
        private string exportado;
        [XmlElement(ElementName = "EXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportado
        {
            get { return  exportado; }
            set {  exportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GNF
        /// Coment�rio: Geral de opera��o n�o fiscal
        /// </summary>
        private decimal gnf;
        [XmlElement(ElementName = "GNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Gnf
        {
            get { return  gnf; }
            set {  gnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRG
        /// Coment�rio: Geral de relat�rio gerencial
        /// </summary>
        private decimal grg;
        [XmlElement(ElementName = "GRG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Grg
        {
            get { return  grg; }
            set {  grg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Coment�rio: Hora do Comprovante
        /// </summary>
        private string hora;
        [XmlElement(ElementName = "HORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Coment�rio: N�mero do Caixa
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEECF
        /// Coment�rio: N�mero de S�rie do ECF
        /// </summary>
        private string numserieecf;
        [XmlElement(ElementName = "NUMSERIEECF", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Numserieecf
        {
            get { return  numserieecf; }
            set {  numserieecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Valor do comprovante
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
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
        public PCDocemitidosecf()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDOCEMITIDOSECF";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDocemitidosecf> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDocemitidosecf>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDocemitidosecf> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDocemitidosecf>(where);
        }

        #endregion
    }
}
