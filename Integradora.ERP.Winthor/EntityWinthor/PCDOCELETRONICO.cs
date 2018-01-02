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
    /// Classe referente a tabela PCDoceletronico
    /// </summary>
    [XmlType("PCDOCELETRONICO")]
    public class PCDoceletronico : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: MOVIMENTO
        /// Coment�rio: Tipo de NF(S - Sa�da,E - Entrada).
        /// </summary>
        private string movimento;
        [XmlElement(ElementName = "MOVIMENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Movimento
        {
            get { return  movimento; }
            set {  movimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Coment�rio: N�mero Transa��o.
        /// </summary>
        private decimal numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransacao
        {
            get { return  numtransacao; }
            set {  numtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: XMLCCE
        /// Coment�rio: Arquivo XML do Cce.
        /// </summary>
        private string xmlcce;
        [XmlElement(ElementName = "XMLCCE", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Xmlcce
        {
            get { return  xmlcce; }
            set {  xmlcce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: XMLCTE
        /// Coment�rio: Arquivo XML da CTe.
        /// </summary>
        private string xmlcte;
        [XmlElement(ElementName = "XMLCTE", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Xmlcte
        {
            get { return  xmlcte; }
            set {  xmlcte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: XMLCTECANC
        /// Coment�rio: XML DE CANCELAMENTO DOS CTEs
        /// </summary>
        private string xmlctecanc;
        [XmlElement(ElementName = "XMLCTECANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Xmlctecanc
        {
            get { return  xmlctecanc; }
            set {  xmlctecanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: XMLMDFE
        /// Coment�rio: Arquivo XML do MDFe.
        /// </summary>
        private string xmlmdfe;
        [XmlElement(ElementName = "XMLMDFE", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Xmlmdfe
        {
            get { return  xmlmdfe; }
            set {  xmlmdfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: XMLNFE
        /// Coment�rio: Arquivo XML da NFe.
        /// </summary>
        private string xmlnfe;
        [XmlElement(ElementName = "XMLNFE", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Xmlnfe
        {
            get { return  xmlnfe; }
            set {  xmlnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: XMLNFECANC
        /// Coment�rio: NC	XML DE CANCELAMENTO.
        /// </summary>
        private string xmlnfecanc;
        [XmlElement(ElementName = "XMLNFECANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Xmlnfecanc
        {
            get { return  xmlnfecanc; }
            set {  xmlnfecanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: XMLNFEINUT
        /// Coment�rio: INC	XML DE INUTILIZACAO.
        /// </summary>
        private string xmlnfeinut;
        [XmlElement(ElementName = "XMLNFEINUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Xmlnfeinut
        {
            get { return  xmlnfeinut; }
            set {  xmlnfeinut = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDoceletronico()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDOCELETRONICO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDoceletronico> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDoceletronico>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDoceletronico> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDoceletronico>(where);
        }

        #endregion
    }
}
