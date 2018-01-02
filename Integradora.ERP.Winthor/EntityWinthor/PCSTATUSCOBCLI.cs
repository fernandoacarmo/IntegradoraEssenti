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
    /// Classe referente a tabela PCStatuscobcli
    /// </summary>
    [XmlType("PCSTATUSCOBCLI")]
    public class PCStatuscobcli : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODSTATUSCOB
        /// Comentário: 
        /// </summary>
        private decimal codstatuscob;
        [XmlElement(ElementName = "CODSTATUSCOB", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codstatuscob
        {
            get { return  codstatuscob; }
            set {  codstatuscob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASRETORNO
        /// Comentário: Indica o número de dias de retorno da cobrança.
        /// </summary>
        private decimal diasretorno;
        [XmlElement(ElementName = "DIASRETORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Diasretorno
        {
            get { return  diasretorno; }
            set {  diasretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIGEDATA
        /// Comentário: Define se a cobrança exige data de retorno ou não.
        /// </summary>
        private string exigedata;
        [XmlElement(ElementName = "EXIGEDATA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exigedata
        {
            get { return  exigedata; }
            set {  exigedata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRIORIDADE
        /// Comentário: Define a prioridade do status de cobrança.
        /// </summary>
        private decimal prioridade;
        [XmlElement(ElementName = "PRIORIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Prioridade
        {
            get { return  prioridade; }
            set {  prioridade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUSCOB
        /// Comentário: 
        /// </summary>
        private string statuscob;
        [XmlElement(ElementName = "STATUSCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Statuscob
        {
            get { return  statuscob; }
            set {  statuscob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Definir o status da cobrança em produtivo ou improdutivo.
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCStatuscobcli()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSTATUSCOBCLI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCStatuscobcli> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCStatuscobcli>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCStatuscobcli> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCStatuscobcli>(where);
        }

        #endregion
    }
}
