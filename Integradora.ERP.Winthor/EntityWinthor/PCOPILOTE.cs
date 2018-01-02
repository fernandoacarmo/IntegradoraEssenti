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
    /// Classe referente a tabela PCOpilote
    /// </summary>
    [XmlType("PCOPILOTE")]
    public class PCOpilote : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTBAIXA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtbaixa;
        [XmlElement(ElementName = "DTBAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbaixa
        {
            get { return  dtbaixa; }
            set {  dtbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRACAOUMIDA
        /// Coment�rio: 
        /// </summary>
        private string fracaoumida;
        [XmlElement(ElementName = "FRACAOUMIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Fracaoumida
        {
            get { return  fracaoumida; }
            set {  fracaoumida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTEORI
        /// Coment�rio: Indica o lote de origem. 
        /// </summary>
        private string numloteori;
        [XmlElement(ElementName = "NUMLOTEORI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numloteori
        {
            get { return  numloteori; }
            set {  numloteori = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOP
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: Indica sequencial das MPS. 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: QTREQUISITADO
        /// Coment�rio: 
        /// </summary>
        private decimal qtrequisitado;
        [XmlElement(ElementName = "QTREQUISITADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtrequisitado
        {
            get { return  qtrequisitado; }
            set {  qtrequisitado = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCOpilote()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCOPILOTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOpilote> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOpilote>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCOpilote> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOpilote>(where);
        }

        #endregion
    }
}
