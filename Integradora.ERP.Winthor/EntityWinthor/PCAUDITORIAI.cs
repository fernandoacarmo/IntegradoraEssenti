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
    /// Classe referente a tabela PCAuditoriai
    /// </summary>
    [XmlType("PCAUDITORIAI")]
    public class PCAuditoriai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Indica o código do produto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAUDITORIA
        /// Comentário: Indica o número da auditoria por veículo.
        /// </summary>
        private decimal numauditoria;
        [XmlElement(ElementName = "NUMAUDITORIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numauditoria
        {
            get { return  numauditoria; }
            set {  numauditoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCONF
        /// Comentário: Indica a quantidade conferida do produto.
        /// </summary>
        private decimal qtconf;
        [XmlElement(ElementName = "QTCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtconf
        {
            get { return  qtconf; }
            set {  qtconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVEICULO
        /// Comentário: Indica a quantidade do produto no veículo.
        /// </summary>
        private decimal qtveiculo;
        [XmlElement(ElementName = "QTVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtveiculo
        {
            get { return  qtveiculo; }
            set {  qtveiculo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAuditoriai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAUDITORIAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAuditoriai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAuditoriai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAuditoriai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAuditoriai>(where);
        }

        #endregion
    }
}
