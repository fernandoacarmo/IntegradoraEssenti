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
    /// Classe referente a tabela PCWmsconvocacaoativa
    /// </summary>
    [XmlType("PCWMSCONVOCACAOATIVA")]
    public class PCWmsconvocacaoativa : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo filial
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: C�digo funcion�rio
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVO
        /// Coment�rio: C�digo motivo
        /// </summary>
        private decimal codmotivo;
        [XmlElement(ElementName = "CODMOTIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codmotivo
        {
            get { return  codmotivo; }
            set {  codmotivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTACEITACAO
        /// Coment�rio: Data aceita��o
        /// </summary>
        private DateTime? dtaceitacao;
        [XmlElement(ElementName = "DTACEITACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtaceitacao
        {
            get { return  dtaceitacao; }
            set {  dtaceitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREJEICAO
        /// Coment�rio: Data rejei��o
        /// </summary>
        private DateTime? dtrejeicao;
        [XmlElement(ElementName = "DTREJEICAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtrejeicao
        {
            get { return  dtrejeicao; }
            set {  dtrejeicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Coment�rio: N�mero O.S.
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REJEITADA
        /// Coment�rio: Rejeitada
        /// </summary>
        private string rejeitada;
        [XmlElement(ElementName = "REJEITADA", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Rejeitada
        {
            get { return  rejeitada; }
            set {  rejeitada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOS
        /// Coment�rio: Tipo O.S.
        /// </summary>
        private decimal tipoos;
        [XmlElement(ElementName = "TIPOOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipoos
        {
            get { return  tipoos; }
            set {  tipoos = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCWmsconvocacaoativa()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSCONVOCACAOATIVA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCWmsconvocacaoativa> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmsconvocacaoativa.GetStringConnection());
            return ba.Listar<PCWmsconvocacaoativa>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCWmsconvocacaoativa> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmsconvocacaoativa.GetStringConnection());
            return ba.Existe<PCWmsconvocacaoativa>(where);
        }

        #endregion
    }
}
