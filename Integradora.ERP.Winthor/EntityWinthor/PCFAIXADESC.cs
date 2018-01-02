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
    /// Classe referente a tabela PCFaixadesc
    /// </summary>
    [XmlType("PCFAIXADESC")]
    public class PCFaixadesc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESC
        /// Comentário: Percentual de acréscimo, por faixa, a ser utilizado na fórmula para cálculo do saldo da conta corrente do RCA. |Campo do tipo numérico, de tamanho 12, com 6 casas decimais.
        /// </summary>
        private decimal percacresc;
        [XmlElement(ElementName = "PERCACRESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percacresc
        {
            get { return  percacresc; }
            set {  percacresc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFIM
        /// Comentário: Percentual final da faixa de desconto comercial informado no pedido de venda, utilizado para identificar qual o percentual de acréscimo será utilizado na fórmula para cálculo do saldo da conta corrente do RCA. |Campo do tipo numérico, de tamanho 12, com 6 casas decimais.
        /// </summary>
        private decimal percfim;
        [XmlElement(ElementName = "PERCFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfim
        {
            get { return  percfim; }
            set {  percfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCINICIO
        /// Comentário: Percentual inicial da faixa de desconto comercial informado no pedido de venda, utilizado para identificar qual o percentual de acréscimo será utilizado na fórmula para cálculo do saldo da conta corrente do RCA. |Campo do tipo numérico, de tamanho 12, com 6 casas decimais.
        /// </summary>
        private decimal percinicio;
        [XmlElement(ElementName = "PERCINICIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percinicio
        {
            get { return  percinicio; }
            set {  percinicio = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFaixadesc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFAIXADESC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFaixadesc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFaixadesc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFaixadesc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFaixadesc>(where);
        }

        #endregion
    }
}
