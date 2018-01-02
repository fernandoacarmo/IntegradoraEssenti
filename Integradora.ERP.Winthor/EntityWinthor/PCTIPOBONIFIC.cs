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
    /// Classe referente a tabela PCTipobonific
    /// </summary>
    [XmlType("PCTIPOBONIFIC")]
    public class PCTipobonific : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BONIFPADRAO
        /// Comentário: VERIFICA SE A BONIFICAÇÃO CORRENTE É A PADRÃO DENTRE AS DEMAIS.
        /// </summary>
        private string bonifpadrao;
        [XmlElement(ElementName = "BONIFPADRAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bonifpadrao
        {
            get { return  bonifpadrao; }
            set {  bonifpadrao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBNF
        /// Comentário: Código do tipo de bonificação.
        /// </summary>
        private decimal codbnf;
        [XmlElement(ElementName = "CODBNF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codbnf
        {
            get { return  codbnf; }
            set {  codbnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição do tipo de bonificação.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOVIMENTACCRCA
        /// Comentário: MOVIMENTA CONTA CORRENTE DO RCA
        /// </summary>
        private string movimentaccrca;
        [XmlElement(ElementName = "MOVIMENTACCRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Movimentaccrca
        {
            get { return  movimentaccrca; }
            set {  movimentaccrca = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTipobonific()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTIPOBONIFIC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTipobonific> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTipobonific>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTipobonific> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTipobonific>(where);
        }

        #endregion
    }
}
