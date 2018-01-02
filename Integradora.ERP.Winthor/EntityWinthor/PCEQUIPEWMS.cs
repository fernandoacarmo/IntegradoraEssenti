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
    /// Classe referente a tabela PCEquipewms
    /// </summary>
    [XmlType("PCEQUIPEWMS")]
    public class PCEquipewms : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEQUIPE
        /// Coment�rio: 
        /// </summary>
        private decimal codequipe;
        [XmlElement(ElementName = "CODEQUIPE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codequipe
        {
            get { return  codequipe; }
            set {  codequipe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOOPERACAO
        /// Coment�rio: 
        /// </summary>
        private decimal codigooperacao;
        [XmlElement(ElementName = "CODIGOOPERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codigooperacao
        {
            get { return  codigooperacao; }
            set {  codigooperacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAGEM
        /// Coment�rio: 
        /// </summary>
        private decimal contagem;
        [XmlElement(ElementName = "CONTAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Contagem
        {
            get { return  contagem; }
            set {  contagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOPERACAO
        /// Coment�rio: 
        /// </summary>
        private string tipooperacao;
        [XmlElement(ElementName = "TIPOOPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipooperacao
        {
            get { return  tipooperacao; }
            set {  tipooperacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEquipewms()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEQUIPEWMS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEquipewms> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEquipewms>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEquipewms> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEquipewms>(where);
        }

        #endregion
    }
}
