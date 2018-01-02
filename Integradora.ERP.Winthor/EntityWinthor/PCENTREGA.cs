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
    /// Classe referente a tabela PCEntrega
    /// </summary>
    [XmlType("PCENTREGA")]
    public class PCEntrega : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BAIRROENTREGA
        /// Coment�rio: Bairro entrega.
        /// </summary>
        private string bairroentrega;
        [XmlElement(ElementName = "BAIRROENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Bairroentrega
        {
            get { return  bairroentrega; }
            set {  bairroentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEPENTREGA
        /// Coment�rio: CEP do Endere�o de Entrega
        /// </summary>
        private string cepentrega;
        [XmlElement(ElementName = "CEPENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cepentrega
        {
            get { return  cepentrega; }
            set {  cepentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo cliente.
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
        /// Propriedade referente ao campo: CODENDENT
        /// Coment�rio: C�digo Endere�o de Entrega.
        /// </summary>
        private decimal codendent;
        [XmlElement(ElementName = "CODENDENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codendent
        {
            get { return  codendent; }
            set {  codendent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Coment�rio: C�digo pra�a.
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTOENTREGA
        /// Coment�rio: Complemento Entrega
        /// </summary>
        private string complementoentrega;
        [XmlElement(ElementName = "COMPLEMENTOENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Complementoentrega
        {
            get { return  complementoentrega; }
            set {  complementoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDENTREGA
        /// Coment�rio: Endere�o entrega.
        /// </summary>
        private string endentrega;
        [XmlElement(ElementName = "ENDENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Endentrega
        {
            get { return  endentrega; }
            set {  endentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTENTREGA
        /// Coment�rio: Estado entrega.
        /// </summary>
        private string estentrega;
        [XmlElement(ElementName = "ESTENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estentrega
        {
            get { return  estentrega; }
            set {  estentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALENTREGA
        /// Coment�rio: Local entrega.
        /// </summary>
        private string localentrega;
        [XmlElement(ElementName = "LOCALENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Localentrega
        {
            get { return  localentrega; }
            set {  localentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNIENTREGA
        /// Coment�rio: Cidade entrega.
        /// </summary>
        private string munientrega;
        [XmlElement(ElementName = "MUNIENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Munientrega
        {
            get { return  munientrega; }
            set {  munientrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROENTREGA
        /// Coment�rio: N�mero da Entrega
        /// </summary>
        private string numeroentrega;
        [XmlElement(ElementName = "NUMEROENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Numeroentrega
        {
            get { return  numeroentrega; }
            set {  numeroentrega = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEntrega()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCENTREGA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEntrega> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEntrega>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEntrega> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEntrega>(where);
        }

        #endregion
    }
}
