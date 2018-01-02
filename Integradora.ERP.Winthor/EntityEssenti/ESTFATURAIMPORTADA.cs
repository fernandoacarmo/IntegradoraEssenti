using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTFaturaimportada
    /// </summary>
    [XmlType("ESTFATURAIMPORTADA")]
    public class ESTFaturaimportada : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NR_TITULO
        /// Comentário: 
        /// </summary>
        private decimal nr_titulo;
        [XmlElement(ElementName = "NR_TITULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Nr_Titulo
        {
            get { return  nr_titulo; }
            set {  nr_titulo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTFaturaimportada()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTFATURAIMPORTADA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTFaturaimportada> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTFaturaimportada.GetStringConnection());
            return ba.Listar<ESTFaturaimportada>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTFaturaimportada> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTFaturaimportada.GetStringConnection());
            return ba.Existe<ESTFaturaimportada>(where);
        }

        #endregion
    }
}
