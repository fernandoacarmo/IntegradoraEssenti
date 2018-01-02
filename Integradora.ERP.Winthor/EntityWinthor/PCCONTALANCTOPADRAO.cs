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
    /// Classe referente a tabela PCContalanctopadrao
    /// </summary>
    [XmlType("PCCONTALANCTOPADRAO")]
    public class PCContalanctopadrao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODHISTORICO
        /// Comentário: Indica o código do historico.
        /// </summary>
        private decimal codhistorico;
        [XmlElement(ElementName = "CODHISTORICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codhistorico
        {
            get { return  codhistorico; }
            set {  codhistorico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLANCPADRAO
        /// Comentário: Indica o código do lançamento.
        /// </summary>
        private decimal codlancpadrao;
        [XmlElement(ElementName = "CODLANCPADRAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codlancpadrao
        {
            get { return  codlancpadrao; }
            set {  codlancpadrao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDUZIDO_PC
        /// Comentário: Indica o conta contábil.
        /// </summary>
        private string codreduzido_pc;
        [XmlElement(ElementName = "CODREDUZIDO_PC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,12)]
        public string Codreduzido_Pc
        {
            get { return  codreduzido_pc; }
            set {  codreduzido_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HIST_COMPL
        /// Comentário: Indica o historico complementar.
        /// </summary>
        private string hist_compl;
        [XmlElement(ElementName = "HIST_COMPL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Hist_Compl
        {
            get { return  hist_compl; }
            set {  hist_compl = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZA
        /// Comentário: Indica a natureza da conta.
        /// </summary>
        private string natureza;
        [XmlElement(ElementName = "NATUREZA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Natureza
        {
            get { return  natureza; }
            set {  natureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL
        /// Comentário: Indica o percentual do valor.
        /// </summary>
        private decimal percentual;
        [XmlElement(ElementName = "PERCENTUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percentual
        {
            get { return  percentual; }
            set {  percentual = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCContalanctopadrao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTALANCTOPADRAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCContalanctopadrao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContalanctopadrao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCContalanctopadrao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContalanctopadrao>(where);
        }

        #endregion
    }
}
