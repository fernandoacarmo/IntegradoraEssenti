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
    /// Classe referente a tabela PCPedidologparametros
    /// </summary>
    [XmlType("PCPEDIDOLOGPARAMETROS")]
    public class PCPedidologparametros : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: IDORIGEM
        /// Comentário: Identificador da tabela.
        /// </summary>
        private decimal idorigem;
        [XmlElement(ElementName = "IDORIGEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public decimal Idorigem
        {
            get { return  idorigem; }
            set {  idorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEPARAMETRO
        /// Comentário: Nome do parâmetro.
        /// </summary>
        private string nomeparametro;
        [XmlElement(ElementName = "NOMEPARAMETRO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,200)]
        public string Nomeparametro
        {
            get { return  nomeparametro; }
            set {  nomeparametro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: Valor do parâmetro.
        /// </summary>
        private string valor;
        [XmlElement(ElementName = "VALOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPedidologparametros()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDIDOLOGPARAMETROS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPedidologparametros> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedidologparametros>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPedidologparametros> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPedidologparametros>(where);
        }

        #endregion
    }
}
