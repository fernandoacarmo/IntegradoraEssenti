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
    /// Classe referente a tabela PCSemanasmes
    /// </summary>
    [XmlType("PCSEMANASMES")]
    public class PCSemanasmes : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: Indica o ano.
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAFINAL
        /// Comentário: Indica o dia final da semana.
        /// </summary>
        private decimal diafinal;
        [XmlElement(ElementName = "DIAFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diafinal
        {
            get { return  diafinal; }
            set {  diafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAINICIAL
        /// Comentário: Indica o dia inicial da semana.
        /// </summary>
        private decimal diainicial;
        [XmlElement(ElementName = "DIAINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diainicial
        {
            get { return  diainicial; }
            set {  diainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Comentário: Indica o mês.
        /// </summary>
        private decimal mes;
        [XmlElement(ElementName = "MES", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEMANA
        /// Comentário: Indica o número da semana.
        /// </summary>
        private decimal numsemana;
        [XmlElement(ElementName = "NUMSEMANA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public decimal Numsemana
        {
            get { return  numsemana; }
            set {  numsemana = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCSemanasmes()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSEMANASMES";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSemanasmes> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSemanasmes>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSemanasmes> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSemanasmes>(where);
        }

        #endregion
    }
}
