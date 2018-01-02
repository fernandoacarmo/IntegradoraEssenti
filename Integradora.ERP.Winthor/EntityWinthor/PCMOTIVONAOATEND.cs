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
    /// Classe referente a tabela PCMotivonaoatend
    /// </summary>
    [XmlType("PCMOTIVONAOATEND")]
    public class PCMotivonaoatend : OracleTable
    {
        #region Atributos

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
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o do Motivo de N�o Atendimento
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMotivonaoatend()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOTIVONAOATEND";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMotivonaoatend> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMotivonaoatend>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMotivonaoatend> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMotivonaoatend>(where);
        }

        #endregion
    }
}
