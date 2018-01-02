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
    /// Classe referente a tabela PCDiretorio
    /// </summary>
    [XmlType("PCDIRETORIO")]
    public class PCDiretorio : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODDIRETORIO
        /// Comentário: 
        /// </summary>
        private decimal coddiretorio;
        [XmlElement(ElementName = "CODDIRETORIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Coddiretorio
        {
            get { return  coddiretorio; }
            set {  coddiretorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDIRETORIOPAI
        /// Comentário: 
        /// </summary>
        private decimal coddiretoriopai;
        [XmlElement(ElementName = "CODDIRETORIOPAI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddiretoriopai
        {
            get { return  coddiretoriopai; }
            set {  coddiretoriopai = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Comentário: 
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDiretorio()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDIRETORIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDiretorio> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDiretorio>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDiretorio> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDiretorio>(where);
        }

        #endregion
    }
}
