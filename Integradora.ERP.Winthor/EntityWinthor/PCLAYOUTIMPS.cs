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
    /// Classe referente a tabela PCLayoutimps
    /// </summary>
    [XmlType("PCLAYOUTIMPS")]
    public class PCLayoutimps : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODLAYOUTIMP
        /// Coment�rio: Campo para identificar os layouts.
        /// </summary>
        private decimal codlayoutimp;
        [XmlElement(ElementName = "CODLAYOUTIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codlayoutimp
        {
            get { return  codlayoutimp; }
            set {  codlayoutimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Campo para armazenar a descri��o da se��o criada.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDENTIFICADOR
        /// Coment�rio: Campo para armazenar o valor que identifica a se��o do arquivo a ser importado.
        /// </summary>
        private string identificador;
        [XmlElement(ElementName = "IDENTIFICADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Identificador
        {
            get { return  identificador; }
            set {  identificador = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCLayoutimps()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLAYOUTIMPS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCLayoutimps> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLayoutimps>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCLayoutimps> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLayoutimps>(where);
        }

        #endregion
    }
}
