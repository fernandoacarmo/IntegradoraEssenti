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
    /// Classe referente a tabela PCRotinaversao
    /// </summary>
    [XmlType("PCROTINAVERSAO")]
    public class PCRotinaversao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: Apresenta codigo da rotina
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINALANC
        /// Coment�rio: Apresenta o codigo da rotina da ultima atualiza��o
        /// </summary>
        private decimal codrotinalanc;
        [XmlElement(ElementName = "CODROTINALANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrotinalanc
        {
            get { return  codrotinalanc; }
            set {  codrotinalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Apresnta a data de lancamento
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENORVERSAO
        /// Coment�rio: Apresenta a menor versao que deve ser executada
        /// </summary>
        private decimal menorversao;
        [XmlElement(ElementName = "MENORVERSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Menorversao
        {
            get { return  menorversao; }
            set {  menorversao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITECONTINUAR
        /// Coment�rio: Apresenta se e permitido continuar mesmo estando desatualizada
        /// </summary>
        private string permitecontinuar;
        [XmlElement(ElementName = "PERMITECONTINUAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitecontinuar
        {
            get { return  permitecontinuar; }
            set {  permitecontinuar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOCLIENTE
        /// Coment�rio: Apresenta a vers�o da rotina do cliente
        /// </summary>
        private decimal versaocliente;
        [XmlElement(ElementName = "VERSAOCLIENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Versaocliente
        {
            get { return  versaocliente; }
            set {  versaocliente = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRotinaversao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCROTINAVERSAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRotinaversao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRotinaversao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRotinaversao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRotinaversao>(where);
        }

        #endregion
    }
}
