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
    /// Classe referente a tabela PCModalidades
    /// </summary>
    [XmlType("PCMODALIDADES")]
    public class PCModalidades : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMODALIDADE
        /// Comentário: Código modalidade.
        /// </summary>
        private decimal codmodalidade;
        [XmlElement(ElementName = "CODMODALIDADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codmodalidade
        {
            get { return  codmodalidade; }
            set {  codmodalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Comentário: Nome.
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Tipo.
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCModalidades()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMODALIDADES";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCModalidades> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCModalidades>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCModalidades> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCModalidades>(where);
        }

        #endregion
    }
}
