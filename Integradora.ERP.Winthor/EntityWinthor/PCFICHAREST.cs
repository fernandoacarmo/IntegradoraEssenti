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
    /// Classe referente a tabela PCFicharest
    /// </summary>
    [XmlType("PCFICHAREST")]
    public class PCFicharest : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo Filial
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
        /// Propriedade referente ao campo: CODFUNCINATIV
        /// Coment�rio: C�digo do funcion�rio que desativou a ficha
        /// </summary>
        private decimal codfuncinativ;
        [XmlElement(ElementName = "CODFUNCINATIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncinativ
        {
            get { return  codfuncinativ; }
            set {  codfuncinativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINC
        /// Coment�rio: C�digo do funcion�rio que incluiu a ficha
        /// </summary>
        private decimal codfuncinc;
        [XmlElement(ElementName = "CODFUNCINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncinc
        {
            get { return  codfuncinc; }
            set {  codfuncinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTVENDA
        /// Coment�rio: C�digo do funcion�rio que realizou a �ltima venda com a ficha
        /// </summary>
        private decimal codfuncultvenda;
        [XmlElement(ElementName = "CODFUNCULTVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultvenda
        {
            get { return  codfuncultvenda; }
            set {  codfuncultvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINATIV
        /// Coment�rio: Data da inativa��o
        /// </summary>
        private DateTime? dtinativ;
        [XmlElement(ElementName = "DTINATIV", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinativ
        {
            get { return  dtinativ; }
            set {  dtinativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Coment�rio: Data inclus�o
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTVENDA
        /// Coment�rio: Data da �ltima venda com a ficha
        /// </summary>
        private DateTime? dtultvenda;
        [XmlElement(ElementName = "DTULTVENDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultvenda
        {
            get { return  dtultvenda; }
            set {  dtultvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFICHA
        /// Coment�rio: N�mero da ficha
        /// </summary>
        private decimal numficha;
        [XmlElement(ElementName = "NUMFICHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numficha
        {
            get { return  numficha; }
            set {  numficha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��o
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFicharest()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFICHAREST";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFicharest> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFicharest>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFicharest> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFicharest>(where);
        }

        #endregion
    }
}
