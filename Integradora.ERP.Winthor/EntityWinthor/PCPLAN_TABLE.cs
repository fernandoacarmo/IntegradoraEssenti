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
    /// Classe referente a tabela PCPlan_table
    /// </summary>
    [XmlType("PCPLAN_TABLE")]
    public class PCPlan_table : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BYTES
        /// Comentário: 
        /// </summary>
        private decimal bytes;
        [XmlElement(ElementName = "BYTES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Bytes
        {
            get { return  bytes; }
            set {  bytes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARDINALITY
        /// Comentário: 
        /// </summary>
        private decimal cardinality;
        [XmlElement(ElementName = "CARDINALITY", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Cardinality
        {
            get { return  cardinality; }
            set {  cardinality = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COST
        /// Comentário: 
        /// </summary>
        private decimal cost;
        [XmlElement(ElementName = "COST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Cost
        {
            get { return  cost; }
            set {  cost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DISTRIBUTION
        /// Comentário: 
        /// </summary>
        private string distribution;
        [XmlElement(ElementName = "DISTRIBUTION", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Distribution
        {
            get { return  distribution; }
            set {  distribution = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Comentário: 
        /// </summary>
        private decimal id;
        [XmlElement(ElementName = "ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Id
        {
            get { return  id; }
            set {  id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBJECT_INSTANCE
        /// Comentário: 
        /// </summary>
        private decimal object_instance;
        [XmlElement(ElementName = "OBJECT_INSTANCE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Object_Instance
        {
            get { return  object_instance; }
            set {  object_instance = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBJECT_NAME
        /// Comentário: 
        /// </summary>
        private string object_name;
        [XmlElement(ElementName = "OBJECT_NAME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Object_Name
        {
            get { return  object_name; }
            set {  object_name = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBJECT_NODE
        /// Comentário: 
        /// </summary>
        private string object_node;
        [XmlElement(ElementName = "OBJECT_NODE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,128)]
        public string Object_Node
        {
            get { return  object_node; }
            set {  object_node = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBJECT_OWNER
        /// Comentário: 
        /// </summary>
        private string object_owner;
        [XmlElement(ElementName = "OBJECT_OWNER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Object_Owner
        {
            get { return  object_owner; }
            set {  object_owner = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBJECT_TYPE
        /// Comentário: 
        /// </summary>
        private string object_type;
        [XmlElement(ElementName = "OBJECT_TYPE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Object_Type
        {
            get { return  object_type; }
            set {  object_type = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERATION
        /// Comentário: 
        /// </summary>
        private string operation;
        [XmlElement(ElementName = "OPERATION", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Operation
        {
            get { return  operation; }
            set {  operation = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPTIMIZER
        /// Comentário: 
        /// </summary>
        private string optimizer;
        [XmlElement(ElementName = "OPTIMIZER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Optimizer
        {
            get { return  optimizer; }
            set {  optimizer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPTIONS
        /// Comentário: 
        /// </summary>
        private string options;
        [XmlElement(ElementName = "OPTIONS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Options
        {
            get { return  options; }
            set {  options = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OTHER
        /// Comentário: 
        /// </summary>
        private string other;
        [XmlElement(ElementName = "OTHER", DataType = "LONG", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Other
        {
            get { return  other; }
            set {  other = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OTHER_TAG
        /// Comentário: 
        /// </summary>
        private string other_tag;
        [XmlElement(ElementName = "OTHER_TAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Other_Tag
        {
            get { return  other_tag; }
            set {  other_tag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARENT_ID
        /// Comentário: 
        /// </summary>
        private decimal parent_id;
        [XmlElement(ElementName = "PARENT_ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Parent_Id
        {
            get { return  parent_id; }
            set {  parent_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTITION_ID
        /// Comentário: 
        /// </summary>
        private decimal partition_id;
        [XmlElement(ElementName = "PARTITION_ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Partition_Id
        {
            get { return  partition_id; }
            set {  partition_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTITION_START
        /// Comentário: 
        /// </summary>
        private string partition_start;
        [XmlElement(ElementName = "PARTITION_START", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Partition_Start
        {
            get { return  partition_start; }
            set {  partition_start = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTITION_STOP
        /// Comentário: 
        /// </summary>
        private string partition_stop;
        [XmlElement(ElementName = "PARTITION_STOP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Partition_Stop
        {
            get { return  partition_stop; }
            set {  partition_stop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSITION
        /// Comentário: 
        /// </summary>
        private decimal position;
        [XmlElement(ElementName = "POSITION", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Position
        {
            get { return  position; }
            set {  position = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REMARKS
        /// Comentário: 
        /// </summary>
        private string remarks;
        [XmlElement(ElementName = "REMARKS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Remarks
        {
            get { return  remarks; }
            set {  remarks = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEARCH_COLUMNS
        /// Comentário: 
        /// </summary>
        private decimal search_columns;
        [XmlElement(ElementName = "SEARCH_COLUMNS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Search_Columns
        {
            get { return  search_columns; }
            set {  search_columns = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATEMENT_ID
        /// Comentário: 
        /// </summary>
        private string statement_id;
        [XmlElement(ElementName = "STATEMENT_ID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Statement_Id
        {
            get { return  statement_id; }
            set {  statement_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIMESTAMP
        /// Comentário: 
        /// </summary>
        private DateTime? timestamp;
        [XmlElement(ElementName = "TIMESTAMP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Timestamp
        {
            get { return  timestamp; }
            set {  timestamp = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPlan_table()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPLAN_TABLE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPlan_table> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPlan_table>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPlan_table> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPlan_table>(where);
        }

        #endregion
    }
}
