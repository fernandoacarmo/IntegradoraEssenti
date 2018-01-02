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
    /// Classe referente a tabela PCErrocce
    /// </summary>
    [XmlType("PCERROCCE")]
    public class PCErrocce : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMENSAGEM
        /// Comentário: NUMERO DA MENSAGEM
        /// </summary>
        private decimal codmensagem;
        [XmlElement(ElementName = "CODMENSAGEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Codmensagem
        {
            get { return  codmensagem; }
            set {  codmensagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARTACORRECAO
        /// Comentário: NUMERO SEQUENCIAL CARTA CORRECAO
        /// </summary>
        private decimal numcartacorrecao;
        [XmlElement(ElementName = "NUMCARTACORRECAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numcartacorrecao
        {
            get { return  numcartacorrecao; }
            set {  numcartacorrecao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCErrocce()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCERROCCE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCErrocce> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCErrocce>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCErrocce> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCErrocce>(where);
        }

        #endregion
    }
}
