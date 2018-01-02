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
    /// Classe referente a tabela PCLimcredcob
    /// </summary>
    [XmlType("PCLIMCREDCOB")]
    public class PCLimcredcob : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: C�digo da cobran�a
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTERACAO
        /// Coment�rio: Data da �ltima altera��o
        /// </summary>
        private DateTime? dtultalteracao;
        [XmlElement(ElementName = "DTULTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalteracao
        {
            get { return  dtultalteracao; }
            set {  dtultalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCLIMCRED
        /// Coment�rio: Data da vencimento limite de cr�dito
        /// </summary>
        private DateTime? dtvenclimcred;
        [XmlElement(ElementName = "DTVENCLIMCRED", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenclimcred
        {
            get { return  dtvenclimcred; }
            set {  dtvenclimcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMCRED
        /// Coment�rio: Limite de cr�dito
        /// </summary>
        private decimal limcred;
        [XmlElement(ElementName = "LIMCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Limcred
        {
            get { return  limcred; }
            set {  limcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMCREDANT
        /// Coment�rio: Este campo grava o limite de cr�dito anterior
        /// </summary>
        private decimal limcredant;
        [XmlElement(ElementName = "LIMCREDANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Limcredant
        {
            get { return  limcredant; }
            set {  limcredant = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCLimcredcob()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLIMCREDCOB";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCLimcredcob> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLimcredcob>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCLimcredcob> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLimcredcob>(where);
        }

        #endregion
    }
}
