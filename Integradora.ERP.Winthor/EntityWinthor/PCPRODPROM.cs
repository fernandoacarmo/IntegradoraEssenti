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
    /// Classe referente a tabela PCProdprom
    /// </summary>
    [XmlType("PCPRODPROM")]
    public class PCProdprom : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFUNCLANCPROM
        /// Comentário: 
        /// </summary>
        private decimal codfunclancprom;
        [XmlElement(ElementName = "CODFUNCLANCPROM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclancprom
        {
            get { return  codfunclancprom; }
            set {  codfunclancprom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFIN
        /// Comentário: 
        /// </summary>
        private decimal custofin;
        [XmlElement(ElementName = "CUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofin
        {
            get { return  custofin; }
            set {  custofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPROM
        /// Comentário: 
        /// </summary>
        private decimal custoprom;
        [XmlElement(ElementName = "CUSTOPROM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoprom
        {
            get { return  custoprom; }
            set {  custoprom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREAL
        /// Comentário: 
        /// </summary>
        private decimal custoreal;
        [XmlElement(ElementName = "CUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoreal
        {
            get { return  custoreal; }
            set {  custoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMPROM
        /// Comentário: 
        /// </summary>
        private DateTime? dtfimprom;
        [XmlElement(ElementName = "DTFIMPROM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimprom
        {
            get { return  dtfimprom; }
            set {  dtfimprom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOPROM
        /// Comentário: 
        /// </summary>
        private DateTime? dtinicioprom;
        [XmlElement(ElementName = "DTINICIOPROM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicioprom
        {
            get { return  dtinicioprom; }
            set {  dtinicioprom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANCPROM
        /// Comentário: 
        /// </summary>
        private DateTime? dtlancprom;
        [XmlElement(ElementName = "DTLANCPROM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlancprom
        {
            get { return  dtlancprom; }
            set {  dtlancprom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADEPROD
        /// Comentário: 
        /// </summary>
        private DateTime? dtvalidadeprod;
        [XmlElement(ElementName = "DTVALIDADEPROD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidadeprod
        {
            get { return  dtvalidadeprod; }
            set {  dtvalidadeprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: 
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQPROM
        /// Comentário: 
        /// </summary>
        private decimal numseqprom;
        [XmlElement(ElementName = "NUMSEQPROM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numseqprom
        {
            get { return  numseqprom; }
            set {  numseqprom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPROMOCAO
        /// Comentário: 
        /// </summary>
        private decimal ppromocao;
        [XmlElement(ElementName = "PPROMOCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ppromocao
        {
            get { return  ppromocao; }
            set {  ppromocao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPROMOCAO1
        /// Comentário: 
        /// </summary>
        private decimal ppromocao1;
        [XmlElement(ElementName = "PPROMOCAO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ppromocao1
        {
            get { return  ppromocao1; }
            set {  ppromocao1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPROMOCAO2
        /// Comentário: 
        /// </summary>
        private decimal ppromocao2;
        [XmlElement(ElementName = "PPROMOCAO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ppromocao2
        {
            get { return  ppromocao2; }
            set {  ppromocao2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPROMOCAO3
        /// Comentário: 
        /// </summary>
        private decimal ppromocao3;
        [XmlElement(ElementName = "PPROMOCAO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ppromocao3
        {
            get { return  ppromocao3; }
            set {  ppromocao3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPROMOCAO4
        /// Comentário: 
        /// </summary>
        private decimal ppromocao4;
        [XmlElement(ElementName = "PPROMOCAO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ppromocao4
        {
            get { return  ppromocao4; }
            set {  ppromocao4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPROMOCAO5
        /// Comentário: 
        /// </summary>
        private decimal ppromocao5;
        [XmlElement(ElementName = "PPROMOCAO5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ppromocao5
        {
            get { return  ppromocao5; }
            set {  ppromocao5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPROMOCAO6
        /// Comentário: 
        /// </summary>
        private decimal ppromocao6;
        [XmlElement(ElementName = "PPROMOCAO6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ppromocao6
        {
            get { return  ppromocao6; }
            set {  ppromocao6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPROMOCAO7
        /// Comentário: 
        /// </summary>
        private decimal ppromocao7;
        [XmlElement(ElementName = "PPROMOCAO7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ppromocao7
        {
            get { return  ppromocao7; }
            set {  ppromocao7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMAXIMO
        /// Comentário: 
        /// </summary>
        private decimal prazomaximo;
        [XmlElement(ElementName = "PRAZOMAXIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazomaximo
        {
            get { return  prazomaximo; }
            set {  prazomaximo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Comentário: 
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA1
        /// Comentário: 
        /// </summary>
        private decimal ptabela1;
        [XmlElement(ElementName = "PTABELA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabela1
        {
            get { return  ptabela1; }
            set {  ptabela1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA2
        /// Comentário: 
        /// </summary>
        private decimal ptabela2;
        [XmlElement(ElementName = "PTABELA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabela2
        {
            get { return  ptabela2; }
            set {  ptabela2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA3
        /// Comentário: 
        /// </summary>
        private decimal ptabela3;
        [XmlElement(ElementName = "PTABELA3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabela3
        {
            get { return  ptabela3; }
            set {  ptabela3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA4
        /// Comentário: 
        /// </summary>
        private decimal ptabela4;
        [XmlElement(ElementName = "PTABELA4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabela4
        {
            get { return  ptabela4; }
            set {  ptabela4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA5
        /// Comentário: 
        /// </summary>
        private decimal ptabela5;
        [XmlElement(ElementName = "PTABELA5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabela5
        {
            get { return  ptabela5; }
            set {  ptabela5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA6
        /// Comentário: 
        /// </summary>
        private decimal ptabela6;
        [XmlElement(ElementName = "PTABELA6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabela6
        {
            get { return  ptabela6; }
            set {  ptabela6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA7
        /// Comentário: 
        /// </summary>
        private decimal ptabela7;
        [XmlElement(ElementName = "PTABELA7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabela7
        {
            get { return  ptabela7; }
            set {  ptabela7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTDISP
        /// Comentário: 
        /// </summary>
        private decimal qtestdisp;
        [XmlElement(ElementName = "QTESTDISP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestdisp
        {
            get { return  qtestdisp; }
            set {  qtestdisp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTDISPPROM
        /// Comentário: 
        /// </summary>
        private decimal qtestdispprom;
        [XmlElement(ElementName = "QTESTDISPPROM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestdispprom
        {
            get { return  qtestdispprom; }
            set {  qtestdispprom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAPROM
        /// Comentário: 
        /// </summary>
        private decimal qtvendaprom;
        [XmlElement(ElementName = "QTVENDAPROM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendaprom
        {
            get { return  qtvendaprom; }
            set {  qtvendaprom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: 
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALVERBA
        /// Comentário: 
        /// </summary>
        private decimal vltotalverba;
        [XmlElement(ElementName = "VLTOTALVERBA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalverba
        {
            get { return  vltotalverba; }
            set {  vltotalverba = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCProdprom()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODPROM";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCProdprom> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdprom>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCProdprom> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdprom>(where);
        }

        #endregion
    }
}
