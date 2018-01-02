using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTCombo
    /// </summary>
    [XmlType("ESTCOMBO")]
    public class ESTCombo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOMBO
        /// Comentário: 
        /// </summary>
        private decimal codcombo;
        [XmlElement(ElementName = "CODCOMBO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcombo
        {
            get { return  codcombo; }
            set {  codcombo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIADOMINGO
        /// Comentário: 
        /// </summary>
        private string diadomingo;
        [XmlElement(ElementName = "DIADOMINGO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diadomingo
        {
            get { return  diadomingo; }
            set {  diadomingo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAQUARTA
        /// Comentário: 
        /// </summary>
        private string diaquarta;
        [XmlElement(ElementName = "DIAQUARTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diaquarta
        {
            get { return  diaquarta; }
            set {  diaquarta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAQUINTA
        /// Comentário: 
        /// </summary>
        private string diaquinta;
        [XmlElement(ElementName = "DIAQUINTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diaquinta
        {
            get { return  diaquinta; }
            set {  diaquinta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASABADO
        /// Comentário: 
        /// </summary>
        private string diasabado;
        [XmlElement(ElementName = "DIASABADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diasabado
        {
            get { return  diasabado; }
            set {  diasabado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEGUNDA
        /// Comentário: 
        /// </summary>
        private string diasegunda;
        [XmlElement(ElementName = "DIASEGUNDA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diasegunda
        {
            get { return  diasegunda; }
            set {  diasegunda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEXTA
        /// Comentário: 
        /// </summary>
        private string diasexta;
        [XmlElement(ElementName = "DIASEXTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diasexta
        {
            get { return  diasexta; }
            set {  diasexta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIATERCA
        /// Comentário: 
        /// </summary>
        private string diaterca;
        [XmlElement(ElementName = "DIATERCA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diaterca
        {
            get { return  diaterca; }
            set {  diaterca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINAL
        /// Comentário: 
        /// </summary>
        private DateTime? dtfinal;
        [XmlElement(ElementName = "DTFINAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtfinal
        {
            get { return  dtfinal; }
            set {  dtfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRFINAL
        /// Comentário: 
        /// </summary>
        private DateTime? hrfinal;
        [XmlElement(ElementName = "HRFINAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Hrfinal
        {
            get { return  hrfinal; }
            set {  hrfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRINICIO
        /// Comentário: 
        /// </summary>
        private DateTime? hrinicio;
        [XmlElement(ElementName = "HRINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Hrinicio
        {
            get { return  hrinicio; }
            set {  hrinicio = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTCombo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTCOMBO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTCombo> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTCombo.GetStringConnection());
            return ba.Listar<ESTCombo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTCombo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTCombo.GetStringConnection());
            return ba.Existe<ESTCombo>(where);
        }

        #endregion
    }
}
