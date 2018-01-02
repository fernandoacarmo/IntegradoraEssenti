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
    /// Classe referente a tabela PCValorfreteporfaixakm
    /// </summary>
    [XmlType("PCVALORFRETEPORFAIXAKM")]
    public class PCValorfreteporfaixakm : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALNF
        /// Coment�rio: Filial
        /// </summary>
        private string codfilialnf;
        [XmlElement(ElementName = "CODFILIALNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialnf
        {
            get { return  codfilialnf; }
            set {  codfilialnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAFINAL
        /// Coment�rio: Faixa Final
        /// </summary>
        private decimal faixafinal;
        [XmlElement(ElementName = "FAIXAFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Faixafinal
        {
            get { return  faixafinal; }
            set {  faixafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAINICIAL
        /// Coment�rio: Faixa Inicial
        /// </summary>
        private decimal faixainicial;
        [XmlElement(ElementName = "FAIXAINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Faixainicial
        {
            get { return  faixainicial; }
            set {  faixainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFDESTINO
        /// Coment�rio: UF Destino
        /// </summary>
        private string ufdestino;
        [XmlElement(ElementName = "UFDESTINO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufdestino
        {
            get { return  ufdestino; }
            set {  ufdestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORREFERENCIA
        /// Coment�rio: Valor Refer�ncia
        /// </summary>
        private decimal valorreferencia;
        [XmlElement(ElementName = "VALORREFERENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Valorreferencia
        {
            get { return  valorreferencia; }
            set {  valorreferencia = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCValorfreteporfaixakm()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVALORFRETEPORFAIXAKM";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCValorfreteporfaixakm> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCValorfreteporfaixakm>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCValorfreteporfaixakm> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCValorfreteporfaixakm>(where);
        }

        #endregion
    }
}
