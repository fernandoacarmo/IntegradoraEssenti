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
    /// Classe referente a tabela PCAgendafornec
    /// </summary>
    [XmlType("PCAGENDAFORNEC")]
    public class PCAgendafornec : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCOMPRADOR
        /// Comentário: 
        /// </summary>
        private decimal codcomprador;
        [XmlElement(ElementName = "CODCOMPRADOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codcomprador
        {
            get { return  codcomprador; }
            set {  codcomprador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Apresenta o código da filial do agendamento
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEMANA
        /// Comentário: 
        /// </summary>
        private decimal diasemana;
        [XmlElement(ElementName = "DIASEMANA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diasemana
        {
            get { return  diasemana; }
            set {  diasemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXIMAVISITA
        /// Comentário: 
        /// </summary>
        private DateTime? dtproximavisita;
        [XmlElement(ElementName = "DTPROXIMAVISITA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtproximavisita
        {
            get { return  dtproximavisita; }
            set {  dtproximavisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAVISITA
        /// Comentário: 
        /// </summary>
        private decimal horavisita;
        [XmlElement(ElementName = "HORAVISITA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Horavisita
        {
            get { return  horavisita; }
            set {  horavisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAVISITAFIM
        /// Comentário: Hora final da visita
        /// </summary>
        private decimal horavisitafim;
        [XmlElement(ElementName = "HORAVISITAFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horavisitafim
        {
            get { return  horavisitafim; }
            set {  horavisitafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOVISITA
        /// Comentário: 
        /// </summary>
        private decimal minutovisita;
        [XmlElement(ElementName = "MINUTOVISITA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Minutovisita
        {
            get { return  minutovisita; }
            set {  minutovisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOVISITAFIM
        /// Comentário: Minuto final da visita
        /// </summary>
        private decimal minutovisitafim;
        [XmlElement(ElementName = "MINUTOVISITAFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutovisitafim
        {
            get { return  minutovisitafim; }
            set {  minutovisitafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIODICIDADE
        /// Comentário: 
        /// </summary>
        private decimal periodicidade;
        [XmlElement(ElementName = "PERIODICIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Periodicidade
        {
            get { return  periodicidade; }
            set {  periodicidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERIODICIDADE
        /// Comentário: Usa agenda por periocidade.
        /// </summary>
        private string usaperiodicidade;
        [XmlElement(ElementName = "USAPERIODICIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaperiodicidade
        {
            get { return  usaperiodicidade; }
            set {  usaperiodicidade = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAgendafornec()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAGENDAFORNEC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAgendafornec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAgendafornec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAgendafornec> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAgendafornec>(where);
        }

        #endregion
    }
}
