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
    /// Classe referente a tabela PCRendimentos
    /// </summary>
    [XmlType("PCRENDIMENTOS")]
    public class PCRendimentos : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Coment�rio: C�digo do Funcion�rio.
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
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto.
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
        /// Propriedade referente ao campo: DTLANC
        /// Coment�rio: Data de Lan�amento.
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOP
        /// Coment�rio: N�mero da OP.
        /// </summary>
        private decimal numop;
        [XmlElement(ElementName = "NUMOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numop
        {
            get { return  numop; }
            set {  numop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENT
        /// Coment�rio: Quantidade da entrada na OP.
        /// </summary>
        private decimal qtent;
        [XmlElement(ElementName = "QTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtent
        {
            get { return  qtent; }
            set {  qtent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSAID
        /// Coment�rio: Quantidade de sa�da na OP.
        /// </summary>
        private decimal qtsaid;
        [XmlElement(ElementName = "QTSAID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtsaid
        {
            get { return  qtsaid; }
            set {  qtsaid = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRendimentos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRENDIMENTOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRendimentos> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRendimentos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRendimentos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRendimentos>(where);
        }

        #endregion
    }
}
