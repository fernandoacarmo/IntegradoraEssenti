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
    /// Classe referente a tabela PCIntegrarpedidos
    /// </summary>
    [XmlType("PCINTEGRARPEDIDOS")]
    public class PCIntegrarpedidos : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODREFERENCIA
        /// Comentário: O código da referência.
        /// </summary>
        private string codreferencia;
        [XmlElement(ElementName = "CODREFERENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codreferencia
        {
            get { return  codreferencia; }
            set {  codreferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INTEGRADORA
        /// Comentário: O código da integração.
        /// </summary>
        private decimal integradora;
        [XmlElement(ElementName = "INTEGRADORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Integradora
        {
            get { return  integradora; }
            set {  integradora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: Número do Pedido
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUSINTEGRACAO
        /// Comentário: O status do pedido
        /// </summary>
        private string statusintegracao;
        [XmlElement(ElementName = "STATUSINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Statusintegracao
        {
            get { return  statusintegracao; }
            set {  statusintegracao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCIntegrarpedidos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINTEGRARPEDIDOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCIntegrarpedidos> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCIntegrarpedidos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCIntegrarpedidos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCIntegrarpedidos>(where);
        }

        #endregion
    }
}
