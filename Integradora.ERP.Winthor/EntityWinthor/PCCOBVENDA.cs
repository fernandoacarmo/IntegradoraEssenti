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
    /// Classe referente a tabela PCCobvenda
    /// </summary>
    [XmlType("PCCOBVENDA")]
    public class PCCobvenda : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: IDCOB
        /// Comentário: Recebe o identificador da cobrança.
        /// </summary>
        private decimal idcob;
        [XmlElement(ElementName = "IDCOB", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Idcob
        {
            get { return  idcob; }
            set {  idcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDVENDA
        /// Comentário: Recebe o identificador da venda.
        /// </summary>
        private decimal idvenda;
        [XmlElement(ElementName = "IDVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Idvenda
        {
            get { return  idvenda; }
            set {  idvenda = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCobvenda()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOBVENDA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCobvenda> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCobvenda>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCobvenda> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCobvenda>(where);
        }

        #endregion
    }
}
