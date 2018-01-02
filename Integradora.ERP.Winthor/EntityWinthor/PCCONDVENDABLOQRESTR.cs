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
    /// Classe referente a tabela PCCondvendabloqrestr
    /// </summary>
    [XmlType("PCCONDVENDABLOQRESTR")]
    public class PCCondvendabloqrestr : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONDICAOVENDA
        /// Comentário: Código da condição de venda
        /// </summary>
        private decimal codcondicaovenda;
        [XmlElement(ElementName = "CODCONDICAOVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcondicaovenda
        {
            get { return  codcondicaovenda; }
            set {  codcondicaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUNIVERSO
        /// Comentário: Código do universo
        /// </summary>
        private string coduniverso;
        [XmlElement(ElementName = "CODUNIVERSO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Coduniverso
        {
            get { return  coduniverso; }
            set {  coduniverso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEVENTO
        /// Comentário: Tipo de eveto, bloqueio ou restrição
        /// </summary>
        private string tipoevento;
        [XmlElement(ElementName = "TIPOEVENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Tipoevento
        {
            get { return  tipoevento; }
            set {  tipoevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOUNIVERSO
        /// Comentário: Tipo de universo
        /// </summary>
        private decimal tipouniverso;
        [XmlElement(ElementName = "TIPOUNIVERSO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public decimal Tipouniverso
        {
            get { return  tipouniverso; }
            set {  tipouniverso = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCondvendabloqrestr()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONDVENDABLOQRESTR";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCondvendabloqrestr> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCondvendabloqrestr>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCondvendabloqrestr> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCondvendabloqrestr>(where);
        }

        #endregion
    }
}
