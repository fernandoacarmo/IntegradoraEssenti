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
    /// Classe referente a tabela PCWmsnumserie
    /// </summary>
    [XmlType("PCWMSNUMSERIE")]
    public class PCWmsnumserie : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Indica a filial da ordem de serviço.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Indica o código do produto da ordem de serviço.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: Indica a data do lançamento do registro.
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Comentário: Indica a data da exportação do registro pela rotina 1742.
        /// </summary>
        private DateTime? dtexportacao;
        [XmlElement(ElementName = "DTEXPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacao
        {
            get { return  dtexportacao; }
            set {  dtexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINTEGRACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtintegracao;
        [XmlElement(ElementName = "DTINTEGRACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtintegracao
        {
            get { return  dtintegracao; }
            set {  dtintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROCESSAMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtprocessamento;
        [XmlElement(ElementName = "DTPROCESSAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprocessamento
        {
            get { return  dtprocessamento; }
            set {  dtprocessamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROSERIE
        /// Comentário: Indica o número de série do produto da ordem de serviço.
        /// </summary>
        private string numeroserie;
        [XmlElement(ElementName = "NUMEROSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Numeroserie
        {
            get { return  numeroserie; }
            set {  numeroserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMGER
        /// Comentário: 
        /// </summary>
        private decimal numger;
        [XmlElement(ElementName = "NUMGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numger
        {
            get { return  numger; }
            set {  numger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Comentário: Indica o número da ordem de serviço.
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: Campo referente a quantidade para serie
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEMAFORO
        /// Comentário: Indica o controle de exportação.
        /// </summary>
        private decimal semaforo;
        [XmlElement(ElementName = "SEMAFORO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Semaforo
        {
            get { return  semaforo; }
            set {  semaforo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWmsnumserie()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSNUMSERIE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWmsnumserie> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmsnumserie.GetStringConnection());
            return ba.Listar<PCWmsnumserie>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWmsnumserie> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmsnumserie.GetStringConnection());
            return ba.Existe<PCWmsnumserie>(where);
        }

        #endregion
    }
}
