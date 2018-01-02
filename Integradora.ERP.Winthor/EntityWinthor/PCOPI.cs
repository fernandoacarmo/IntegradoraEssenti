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
    /// Classe referente a tabela PCOpi
    /// </summary>
    [XmlType("PCOPI")]
    public class PCOpi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITAREQACIMAPREV
        /// Comentário: 
        /// </summary>
        private string aceitareqacimaprev;
        [XmlElement(ElementName = "ACEITAREQACIMAPREV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitareqacimaprev
        {
            get { return  aceitareqacimaprev; }
            set {  aceitareqacimaprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ARQETAPA
        /// Comentário: 
        /// </summary>
        private string arqetapa;
        [XmlElement(ElementName = "ARQETAPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Arqetapa
        {
            get { return  arqetapa; }
            set {  arqetapa = value; }
        }

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
        /// Propriedade referente ao campo: NUMETAPA
        /// Comentário: 
        /// </summary>
        private decimal numetapa;
        [XmlElement(ElementName = "NUMETAPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numetapa
        {
            get { return  numetapa; }
            set {  numetapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOP
        /// Comentário: 
        /// </summary>
        private decimal numop;
        [XmlElement(ElementName = "NUMOP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numop
        {
            get { return  numop; }
            set {  numop = value; }
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
        /// Propriedade referente ao campo: QTPERDA
        /// Comentário: 
        /// </summary>
        private decimal qtperda;
        [XmlElement(ElementName = "QTPERDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtperda
        {
            get { return  qtperda; }
            set {  qtperda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTREQUISITADO
        /// Comentário: 
        /// </summary>
        private decimal qtrequisitado;
        [XmlElement(ElementName = "QTREQUISITADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtrequisitado
        {
            get { return  qtrequisitado; }
            set {  qtrequisitado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESERVALIBERADA
        /// Comentário: 
        /// </summary>
        private string reservaliberada;
        [XmlElement(ElementName = "RESERVALIBERADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reservaliberada
        {
            get { return  reservaliberada; }
            set {  reservaliberada = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCOpi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCOPI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCOpi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOpi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCOpi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOpi>(where);
        }

        #endregion
    }
}
