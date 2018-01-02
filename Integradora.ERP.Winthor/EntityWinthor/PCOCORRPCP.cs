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
    /// Classe referente a tabela PCOcorrpcp
    /// </summary>
    [XmlType("PCOCORRPCP")]
    public class PCOcorrpcp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Comentário: 
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAOCORR
        /// Comentário: 
        /// </summary>
        private DateTime? dataocorr;
        [XmlElement(ElementName = "DATAOCORR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataocorr
        {
            get { return  dataocorr; }
            set {  dataocorr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAOCORR
        /// Comentário: 
        /// </summary>
        private decimal horaocorr;
        [XmlElement(ElementName = "HORAOCORR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horaocorr
        {
            get { return  horaocorr; }
            set {  horaocorr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOOCORR
        /// Comentário: 
        /// </summary>
        private decimal minutoocorr;
        [XmlElement(ElementName = "MINUTOOCORR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutoocorr
        {
            get { return  minutoocorr; }
            set {  minutoocorr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Comentário: 
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Motivo
        {
            get { return  motivo; }
            set {  motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOP
        /// Comentário: 
        /// </summary>
        private decimal numop;
        [XmlElement(ElementName = "NUMOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numop
        {
            get { return  numop; }
            set {  numop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPCP
        /// Comentário: 
        /// </summary>
        private decimal numpcp;
        [XmlElement(ElementName = "NUMPCP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpcp
        {
            get { return  numpcp; }
            set {  numpcp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSUBOP
        /// Comentário: 
        /// </summary>
        private decimal numsubop;
        [XmlElement(ElementName = "NUMSUBOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numsubop
        {
            get { return  numsubop; }
            set {  numsubop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: 
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TABELA
        /// Comentário: 
        /// </summary>
        private string tabela;
        [XmlElement(ElementName = "TABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tabela
        {
            get { return  tabela; }
            set {  tabela = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCOcorrpcp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCOCORRPCP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCOcorrpcp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOcorrpcp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCOcorrpcp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOcorrpcp>(where);
        }

        #endregion
    }
}
