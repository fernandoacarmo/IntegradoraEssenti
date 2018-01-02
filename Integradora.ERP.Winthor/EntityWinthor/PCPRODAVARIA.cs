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
    /// Classe referente a tabela PCProdavaria
    /// </summary>
    [XmlType("PCPRODAVARIA")]
    public class PCProdavaria : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�d. da filial
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�d. Fornecedor
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Coment�rio: C�d. Funcinario
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPO
        /// Coment�rio: C�d. Grupo de avaria
        /// </summary>
        private decimal codgrupo;
        [XmlElement(ElementName = "CODGRUPO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codgrupo
        {
            get { return  codgrupo; }
            set {  codgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVOAVARIA
        /// Coment�rio: C�d. Motivo avaria
        /// </summary>
        private decimal codmotivoavaria;
        [XmlElement(ElementName = "CODMOTIVOAVARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codmotivoavaria
        {
            get { return  codmotivoavaria; }
            set {  codmotivoavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�d. Prod
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data da avaria
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
        /// Propriedade referente ao campo: ESTACAO
        /// Coment�rio: Esta��o que efetivou a avaria
        /// </summary>
        private string estacao;
        [XmlElement(ElementName = "ESTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Estacao
        {
            get { return  estacao; }
            set {  estacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: Numero de lote
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: Transa��o de sa�da
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVERBA
        /// Coment�rio: N�mero da verba
        /// </summary>
        private decimal numverba;
        [XmlElement(ElementName = "NUMVERBA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numverba
        {
            get { return  numverba; }
            set {  numverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��o
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: Qt. Avariada
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTORIGINAL
        /// Coment�rio: Quantidade original de entrada.
        /// </summary>
        private decimal qtoriginal;
        [XmlElement(ElementName = "QTORIGINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtoriginal
        {
            get { return  qtoriginal; }
            set {  qtoriginal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Coment�rio: Rotina de lan�amento
        /// </summary>
        private string rotinalanc;
        [XmlElement(ElementName = "ROTINALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Rotinalanc
        {
            get { return  rotinalanc; }
            set {  rotinalanc = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCProdavaria()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODAVARIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCProdavaria> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdavaria>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCProdavaria> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdavaria>(where);
        }

        #endregion
    }
}
