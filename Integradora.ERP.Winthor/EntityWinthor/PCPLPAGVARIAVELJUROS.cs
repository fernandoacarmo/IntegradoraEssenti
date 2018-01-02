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
    /// Classe referente a tabela PCPlpagvariaveljuros
    /// </summary>
    [XmlType("PCPLPAGVARIAVELJUROS")]
    public class PCPlpagvariaveljuros : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: Código do plano de pagamento
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Comentário: Percentual de desconto/acréscimo referente ao prazo médio
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIOFINAL
        /// Comentário: Prazo Médio Final
        /// </summary>
        private decimal prazomediofinal;
        [XmlElement(ElementName = "PRAZOMEDIOFINAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Prazomediofinal
        {
            get { return  prazomediofinal; }
            set {  prazomediofinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIOINICIAL
        /// Comentário: Prazo Médio Inicial
        /// </summary>
        private decimal prazomedioinicial;
        [XmlElement(ElementName = "PRAZOMEDIOINICIAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Prazomedioinicial
        {
            get { return  prazomedioinicial; }
            set {  prazomedioinicial = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPlpagvariaveljuros()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPLPAGVARIAVELJUROS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPlpagvariaveljuros> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPlpagvariaveljuros>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPlpagvariaveljuros> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPlpagvariaveljuros>(where);
        }

        #endregion
    }
}
