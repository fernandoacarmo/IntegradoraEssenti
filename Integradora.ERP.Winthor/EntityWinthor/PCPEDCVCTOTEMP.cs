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
    /// Classe referente a tabela PCPedcvctotemp
    /// </summary>
    [XmlType("PCPEDCVCTOTEMP")]
    public class PCPedcvctotemp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Coment�rio: Data de vencimento
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
        /// Propriedade referente ao campo: INTEGRADORA
        /// Coment�rio: 
        /// </summary>
        private decimal integradora;
        [XmlElement(ElementName = "INTEGRADORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Integradora
        {
            get { return  integradora; }
            set {  integradora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPARCELA
        /// Coment�rio: N�mero da parcela
        /// </summary>
        private decimal numparcela;
        [XmlElement(ElementName = "NUMPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numparcela
        {
            get { return  numparcela; }
            set {  numparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDCLI
        /// Coment�rio: 
        /// </summary>
        private decimal numpedcli;
        [XmlElement(ElementName = "NUMPEDCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true, 50)]
        public decimal Numpedcli
        {
            get { return  numpedcli; }
            set {  numpedcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDRCA
        /// Coment�rio: 
        /// </summary>
        private decimal numpedrca;
        [XmlElement(ElementName = "NUMPEDRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedrca
        {
            get { return  numpedrca; }
            set {  numpedrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDWEB
        /// Coment�rio: 
        /// </summary>
        private decimal numpedweb;
        [XmlElement(ElementName = "NUMPEDWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedweb
        {
            get { return  numpedweb; }
            set {  numpedweb = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPedcvctotemp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDCVCTOTEMP";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPedcvctotemp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedcvctotemp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPedcvctotemp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPedcvctotemp>(where);
        }

        #endregion
    }
}
