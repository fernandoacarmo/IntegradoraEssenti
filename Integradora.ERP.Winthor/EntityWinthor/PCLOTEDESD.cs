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
    /// Classe referente a tabela PCLotedesd
    /// </summary>
    [XmlType("PCLOTEDESD")]
    public class PCLotedesd : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do Produto
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTEDESTINO
        /// Comentário: 
        /// </summary>
        private string numlotedestino;
        [XmlElement(ElementName = "NUMLOTEDESTINO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlotedestino
        {
            get { return  numlotedestino; }
            set {  numlotedestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTEORIGEM
        /// Comentário: 
        /// </summary>
        private string numloteorigem;
        [XmlElement(ElementName = "NUMLOTEORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numloteorigem
        {
            get { return  numloteorigem; }
            set {  numloteorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDADESTINO
        /// Comentário: 
        /// </summary>
        private decimal numtransvendadestino;
        [XmlElement(ElementName = "NUMTRANSVENDADESTINO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendadestino
        {
            get { return  numtransvendadestino; }
            set {  numtransvendadestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAORIGEM
        /// Comentário: 
        /// </summary>
        private decimal numtransvendaorigem;
        [XmlElement(ElementName = "NUMTRANSVENDAORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendaorigem
        {
            get { return  numtransvendaorigem; }
            set {  numtransvendaorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTAVARIADESTINO
        /// Comentário: 
        /// </summary>
        private decimal qtavariadestino;
        [XmlElement(ElementName = "QTAVARIADESTINO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtavariadestino
        {
            get { return  qtavariadestino; }
            set {  qtavariadestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTAVARIAORIGEM
        /// Comentário: 
        /// </summary>
        private decimal qtavariaorigem;
        [XmlElement(ElementName = "QTAVARIAORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtavariaorigem
        {
            get { return  qtavariaorigem; }
            set {  qtavariaorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQDESTINO
        /// Comentário: 
        /// </summary>
        private decimal qtbloqdestino;
        [XmlElement(ElementName = "QTBLOQDESTINO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtbloqdestino
        {
            get { return  qtbloqdestino; }
            set {  qtbloqdestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQORIGEM
        /// Comentário: 
        /// </summary>
        private decimal qtbloqorigem;
        [XmlElement(ElementName = "QTBLOQORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtbloqorigem
        {
            get { return  qtbloqorigem; }
            set {  qtbloqorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESTINO
        /// Comentário: 
        /// </summary>
        private decimal qtdestino;
        [XmlElement(ElementName = "QTDESTINO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtdestino
        {
            get { return  qtdestino; }
            set {  qtdestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTORIGEM
        /// Comentário: 
        /// </summary>
        private decimal qtorigem;
        [XmlElement(ElementName = "QTORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtorigem
        {
            get { return  qtorigem; }
            set {  qtorigem = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLotedesd()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLOTEDESD";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLotedesd> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLotedesd>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLotedesd> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLotedesd>(where);
        }

        #endregion
    }
}
