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
    /// Classe referente a tabela PCParamsaldo
    /// </summary>
    [XmlType("PCPARAMSALDO")]
    public class PCParamsaldo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DESCMAX
        /// Coment�rio: Percentual do desconto m�ximo permitido, por�m este campo somente � utilizado na f�rmula de c�lculo do saldo da conta corrente do RCA.
        /// </summary>
        private decimal descmax;
        [XmlElement(ElementName = "DESCMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Descmax
        {
            get { return  descmax; }
            set {  descmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIXO
        /// Coment�rio: Valor fixo utilizado na f�rmula de c�lculo do saldo da conta corrente do RCA.
        /// </summary>
        private decimal fixo;
        [XmlElement(ElementName = "FIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Fixo
        {
            get { return  fixo; }
            set {  fixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMAXDESCFIN
        /// Coment�rio: Percentual m�ximo de desconto financeiro que poder� ser informado no pedido de venda.
        /// </summary>
        private decimal percmaxdescfin;
        [XmlElement(ElementName = "PERCMAXDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percmaxdescfin
        {
            get { return  percmaxdescfin; }
            set {  percmaxdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINITENS
        /// Coment�rio: Quantidade m�nima de itens que um pedido dever� ter, para que seja permitido informar desconto financeiro.
        /// </summary>
        private decimal qtminitens;
        [XmlElement(ElementName = "QTMINITENS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtminitens
        {
            get { return  qtminitens; }
            set {  qtminitens = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCParamsaldo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPARAMSALDO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCParamsaldo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCParamsaldo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCParamsaldo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCParamsaldo>(where);
        }

        #endregion
    }
}
