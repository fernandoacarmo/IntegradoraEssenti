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
    /// Classe referente a tabela PCPrevprodi
    /// </summary>
    [XmlType("PCPREVPRODI")]
    public class PCPrevprodi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMSIMULACAO
        /// Comentário: 
        /// </summary>
        private decimal numsimulacao;
        [XmlElement(ElementName = "NUMSIMULACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numsimulacao
        {
            get { return  numsimulacao; }
            set {  numsimulacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTDISP
        /// Comentário: 
        /// </summary>
        private decimal qtestdisp;
        [XmlElement(ElementName = "QTESTDISP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtestdisp
        {
            get { return  qtestdisp; }
            set {  qtestdisp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTNECESSIDADE
        /// Comentário: 
        /// </summary>
        private decimal qtnecessidade;
        [XmlElement(ElementName = "QTNECESSIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtnecessidade
        {
            get { return  qtnecessidade; }
            set {  qtnecessidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDIDA
        /// Comentário: 
        /// </summary>
        private decimal qtpedida;
        [XmlElement(ElementName = "QTPEDIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtpedida
        {
            get { return  qtpedida; }
            set {  qtpedida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSUGCOMPRA
        /// Comentário: 
        /// </summary>
        private decimal qtsugcompra;
        [XmlElement(ElementName = "QTSUGCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtsugcompra
        {
            get { return  qtsugcompra; }
            set {  qtsugcompra = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPrevprodi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPREVPRODI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPrevprodi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrevprodi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPrevprodi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrevprodi>(where);
        }

        #endregion
    }
}
