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
    /// Classe referente a tabela PCMovloja
    /// </summary>
    [XmlType("PCMOVLOJA")]
    public class PCMovloja : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial
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
        /// Propriedade referente ao campo: CODFUNBAIXA
        /// Comentário: Código do funcionário da baixa
        /// </summary>
        private decimal codfunbaixa;
        [XmlElement(ElementName = "CODFUNBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunbaixa
        {
            get { return  codfunbaixa; }
            set {  codfunbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAD
        /// Comentário: Código do funcionário do cadastro
        /// </summary>
        private decimal codfuncad;
        [XmlElement(ElementName = "CODFUNCAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncad
        {
            get { return  codfuncad; }
            set {  codfuncad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNEXPEDICAO
        /// Comentário: Código do funcionário de reposição da mercadoria
        /// </summary>
        private decimal codfunexpedicao;
        [XmlElement(ElementName = "CODFUNEXPEDICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunexpedicao
        {
            get { return  codfunexpedicao; }
            set {  codfunexpedicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOVLOJA
        /// Comentário: Código sequencial
        /// </summary>
        private decimal codmovloja;
        [XmlElement(ElementName = "CODMOVLOJA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codmovloja
        {
            get { return  codmovloja; }
            set {  codmovloja = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOVLOJAORIG
        /// Comentário: Código da movimentação da loja
        /// </summary>
        private decimal codmovlojaorig;
        [XmlElement(ElementName = "CODMOVLOJAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmovlojaorig
        {
            get { return  codmovlojaorig; }
            set {  codmovlojaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Código da rotina de cadastro
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBAIXA
        /// Comentário: Data de baixa da movimentação
        /// </summary>
        private DateTime? dtbaixa;
        [XmlElement(ElementName = "DTBAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbaixa
        {
            get { return  dtbaixa; }
            set {  dtbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: Data de cadastro
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Tipo do movimento: Requisição ou Inventário
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCANCEL
        /// Comentário: Tipo de cancelamento
        /// </summary>
        private string tipocancel;
        [XmlElement(ElementName = "TIPOCANCEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocancel
        {
            get { return  tipocancel; }
            set {  tipocancel = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMovloja()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVLOJA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMovloja> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovloja>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMovloja> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovloja>(where);
        }

        #endregion
    }
}
