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
    /// Classe referente a tabela PCMotivonaoatendlayout
    /// </summary>
    [XmlType("PCMOTIVONAOATENDLAYOUT")]
    public class PCMotivonaoatendlayout : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVOLAYOUT
        /// Coment�rio: C�digo do Motivo no Layout correspondente
        /// </summary>
        private string codmotivolayout;
        [XmlElement(ElementName = "CODMOTIVOLAYOUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codmotivolayout
        {
            get { return  codmotivolayout; }
            set {  codmotivolayout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVONAOATEND
        /// Coment�rio: C�digo do Motivo de N�o Atendimento
        /// </summary>
        private decimal codmotivonaoatend;
        [XmlElement(ElementName = "CODMOTIVONAOATEND", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Codmotivonaoatend
        {
            get { return  codmotivonaoatend; }
            set {  codmotivonaoatend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCMOTIVOLAYOUT
        /// Coment�rio: Descri��o do Motivo no Layout correspondente
        /// </summary>
        private string descmotivolayout;
        [XmlElement(ElementName = "DESCMOTIVOLAYOUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descmotivolayout
        {
            get { return  descmotivolayout; }
            set {  descmotivolayout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LAYOUT
        /// Coment�rio: C�digo do Layout
        /// </summary>
        private decimal layout;
        [XmlElement(ElementName = "LAYOUT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Layout
        {
            get { return  layout; }
            set {  layout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOREG
        /// Coment�rio: Tipo de Registro (C - Cabe�alho; I - Itens; A - Ambos)
        /// </summary>
        private string tiporeg;
        [XmlElement(ElementName = "TIPOREG", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Tiporeg
        {
            get { return  tiporeg; }
            set {  tiporeg = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMotivonaoatendlayout()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOTIVONAOATENDLAYOUT";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMotivonaoatendlayout> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMotivonaoatendlayout>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMotivonaoatendlayout> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMotivonaoatendlayout>(where);
        }

        #endregion
    }
}
