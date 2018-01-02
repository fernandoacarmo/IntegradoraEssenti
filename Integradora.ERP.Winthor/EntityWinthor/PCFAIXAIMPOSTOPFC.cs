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
    /// Classe referente a tabela PCFaixaimpostopfc
    /// </summary>
    [XmlType("PCFAIXAIMPOSTOPFC")]
    public class PCFaixaimpostopfc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXCLUSAO
        /// Comentário: Código do funcionário da exclusão
        /// </summary>
        private decimal codfuncexclusao;
        [XmlElement(ElementName = "CODFUNCEXCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncexclusao
        {
            get { return  codfuncexclusao; }
            set {  codfuncexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Código
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFIM
        /// Comentário: Data final da faixa
        /// </summary>
        private DateTime? datafim;
        [XmlElement(ElementName = "DATAFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafim
        {
            get { return  datafim; }
            set {  datafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINICIO
        /// Comentário: Data de inicio da faixa
        /// </summary>
        private DateTime? datainicio;
        [XmlElement(ElementName = "DATAINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datainicio
        {
            get { return  datainicio; }
            set {  datainicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: Data de exclusão
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPOSTO
        /// Comentário: Imposto
        /// </summary>
        private string imposto;
        [XmlElement(ElementName = "IMPOSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Imposto
        {
            get { return  imposto; }
            set {  imposto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: Observação
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASE
        /// Comentário: Percentual base
        /// </summary>
        private decimal percbase;
        [XmlElement(ElementName = "PERCBASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbase
        {
            get { return  percbase; }
            set {  percbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEDUCAODEP
        /// Comentário: Valor de dedução dependente
        /// </summary>
        private decimal vldeducaodep;
        [XmlElement(ElementName = "VLDEDUCAODEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldeducaodep
        {
            get { return  vldeducaodep; }
            set {  vldeducaodep = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFaixaimpostopfc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFAIXAIMPOSTOPFC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFaixaimpostopfc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFaixaimpostopfc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFaixaimpostopfc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFaixaimpostopfc>(where);
        }

        #endregion
    }
}
