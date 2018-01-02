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
    /// Classe referente a tabela PCProdsimil
    /// </summary>
    [XmlType("PCPRODSIMIL")]
    public class PCProdsimil : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Comentário: 
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
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
        /// Propriedade referente ao campo: CODSIMIL
        /// Comentário: 
        /// </summary>
        private decimal codsimil;
        [XmlElement(ElementName = "CODSIMIL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codsimil
        {
            get { return  codsimil; }
            set {  codsimil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANC
        /// Comentário: 
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Observação no momento de relacionar produto similar.
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRIORIDADE
        /// Comentário: Indica a ordem de prioridade.
        /// </summary>
        private decimal prioridade;
        [XmlElement(ElementName = "PRIORIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prioridade
        {
            get { return  prioridade; }
            set {  prioridade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEGQT
        /// Comentário: 
        /// </summary>
        private decimal segqt;
        [XmlElement(ElementName = "SEGQT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Segqt
        {
            get { return  segqt; }
            set {  segqt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPROD
        /// Comentário: Indica o tipo do produto.
        /// </summary>
        private string tipoprod;
        [XmlElement(ElementName = "TIPOPROD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoprod
        {
            get { return  tipoprod; }
            set {  tipoprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTROCA
        /// Comentário: Indica o tipo de troca na substituição automática.
        /// </summary>
        private string tipotroca;
        [XmlElement(ElementName = "TIPOTROCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipotroca
        {
            get { return  tipotroca; }
            set {  tipotroca = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCProdsimil()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODSIMIL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCProdsimil> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdsimil>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCProdsimil> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdsimil>(where);
        }

        #endregion
    }
}
