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
    /// Classe referente a tabela PCParcelasi
    /// </summary>
    [XmlType("PCPARCELASI")]
    public class PCParcelasi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CALCIPIST
        /// Comentário: Calcular Impostos (ST e IPI) na Parcela
        /// </summary>
        private string calcipist;
        [XmlElement(ElementName = "CALCIPIST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcipist
        {
            get { return  calcipist; }
            set {  calcipist = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPARCELA
        /// Comentário: Código de relacionamento com a tabela PCPARCELASC, não é sequencial. 
        /// </summary>
        private decimal codparcela;
        [XmlElement(ElementName = "CODPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codparcela
        {
            get { return  codparcela; }
            set {  codparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPESO
        /// Comentário: Peso da parcela com relação ao valor total
        /// </summary>
        private decimal percpeso;
        [XmlElement(ElementName = "PERCPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Percpeso
        {
            get { return  percpeso; }
            set {  percpeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO
        /// Comentário: Número de dias decorrente a data base informado pela rotina. 
        /// </summary>
        private decimal prazo;
        [XmlElement(ElementName = "PRAZO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Prazo
        {
            get { return  prazo; }
            set {  prazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQPARCELA
        /// Comentário: Sequêncial do parcelamento
        /// </summary>
        private decimal seqparcela;
        [XmlElement(ElementName = "SEQPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Seqparcela
        {
            get { return  seqparcela; }
            set {  seqparcela = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCParcelasi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPARCELASI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCParcelasi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCParcelasi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCParcelasi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCParcelasi>(where);
        }

        #endregion
    }
}
