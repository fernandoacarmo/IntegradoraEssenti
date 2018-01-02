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
    /// Classe referente a tabela PCDslremvariavelc
    /// </summary>
    [XmlType("PCDSLREMVARIAVELC")]
    public class PCDslremvariavelc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCAMPANHA
        /// Comentário: Código da campanha de remuneração variável.
        /// </summary>
        private decimal codcampanha;
        [XmlElement(ElementName = "CODCAMPANHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcampanha
        {
            get { return  codcampanha; }
            set {  codcampanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFECHA
        /// Comentário: Código do funcionário responsável pelo fechamento.
        /// </summary>
        private decimal codfuncfecha;
        [XmlElement(ElementName = "CODFUNCFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfecha
        {
            get { return  codfuncfecha; }
            set {  codfuncfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHAMENTO
        /// Comentário: Data de fechamento da apuração.
        /// </summary>
        private DateTime? dtfechamento;
        [XmlElement(ElementName = "DTFECHAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechamento
        {
            get { return  dtfechamento; }
            set {  dtfechamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDAPURACAO
        /// Comentário: Identificação apuração remuneração variável.
        /// </summary>
        private decimal idapuracao;
        [XmlElement(ElementName = "IDAPURACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Idapuracao
        {
            get { return  idapuracao; }
            set {  idapuracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MESAPURACAO
        /// Comentário: Mês e Ano de apuração.
        /// </summary>
        private decimal mesapuracao;
        [XmlElement(ElementName = "MESAPURACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Mesapuracao
        {
            get { return  mesapuracao; }
            set {  mesapuracao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDslremvariavelc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDSLREMVARIAVELC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDslremvariavelc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDslremvariavelc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDslremvariavelc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDslremvariavelc>(where);
        }

        #endregion
    }
}
