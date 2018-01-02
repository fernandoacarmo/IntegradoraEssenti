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
    /// Classe referente a tabela PCFatogerador
    /// </summary>
    [XmlType("PCFATOGERADOR")]
    public class PCFatogerador : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFATOGERADOR
        /// Comentário: Indica o código do fato gerador
        /// </summary>
        private decimal codfatogerador;
        [XmlElement(ElementName = "CODFATOGERADOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfatogerador
        {
            get { return  codfatogerador; }
            set {  codfatogerador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Indica o descrição do fato gerador
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
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Indica a observação do fato gerador.
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SQLFATOGERADOR
        /// Comentário: Indica o SQL do fato gerador responsável pela regra contábil
        /// </summary>
        private string sqlfatogerador;
        [XmlElement(ElementName = "SQLFATOGERADOR", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Sqlfatogerador
        {
            get { return  sqlfatogerador; }
            set {  sqlfatogerador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOLANCAMENTO
        /// Comentário: Indica o tipo do fato gerador da movimentação
        /// </summary>
        private string tipolancamento;
        [XmlElement(ElementName = "TIPOLANCAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipolancamento
        {
            get { return  tipolancamento; }
            set {  tipolancamento = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFatogerador()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFATOGERADOR";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFatogerador> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFatogerador>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFatogerador> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFatogerador>(where);
        }

        #endregion
    }
}
