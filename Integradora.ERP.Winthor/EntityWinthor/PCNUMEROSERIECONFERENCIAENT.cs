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
    /// Classe referente a tabela PCNumeroserieconferenciaent
    /// </summary>
    [XmlType("PCNUMEROSERIECONFERENCIAENT")]
    public class PCNumeroserieconferenciaent : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AVARIADO
        /// Coment�rio: Informa se o n�mero de s�rie esta avariado
        /// </summary>
        private string avariado;
        [XmlElement(ElementName = "AVARIADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Avariado
        {
            get { return  avariado; }
            set {  avariado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDLINHAPCMOV
        /// Coment�rio: ROWID da PCMOV
        /// </summary>
        private string idlinhapcmov;
        [XmlElement(ElementName = "IDLINHAPCMOV", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,50)]
        public string Idlinhapcmov
        {
            get { return  idlinhapcmov; }
            set {  idlinhapcmov = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIE
        /// Coment�rio: N�mero de s�rie
        /// </summary>
        private string numserie;
        [XmlElement(ElementName = "NUMSERIE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,60)]
        public string Numserie
        {
            get { return  numserie; }
            set {  numserie = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCNumeroserieconferenciaent()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNUMEROSERIECONFERENCIAENT";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCNumeroserieconferenciaent> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNumeroserieconferenciaent>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCNumeroserieconferenciaent> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNumeroserieconferenciaent>(where);
        }

        #endregion
    }
}
