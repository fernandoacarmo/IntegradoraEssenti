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
    /// Classe referente a tabela PCDicionarioitemrotcust
    /// </summary>
    [XmlType("PCDICIONARIOITEMROTCUST")]
    public class PCDicionarioitemrotcust : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AJUDA
        /// Comentário: 
        /// </summary>
        private string ajuda;
        [XmlElement(ElementName = "AJUDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Ajuda
        {
            get { return  ajuda; }
            set {  ajuda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AUTOGERAR
        /// Comentário: 
        /// </summary>
        private string autogerar;
        [XmlElement(ElementName = "AUTOGERAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Autogerar
        {
            get { return  autogerar; }
            set {  autogerar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHARCASE
        /// Comentário: Pesquisa: Código de retorno do resultado da pesquisa
        /// </summary>
        private string charcase;
        [XmlElement(ElementName = "CHARCASE", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Charcase
        {
            get { return  charcase; }
            set {  charcase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTROLE_EDITAVEL
        /// Comentário: 
        /// </summary>
        private decimal codcontrole_editavel;
        [XmlElement(ElementName = "CODCONTROLE_EDITAVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcontrole_Editavel
        {
            get { return  codcontrole_editavel; }
            set {  codcontrole_editavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Nome do campo
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINACAD
        /// Comentário: Se o campo gera ou não log de alteração
        /// </summary>
        private decimal codrotinacad;
        [XmlElement(ElementName = "CODROTINACAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrotinacad
        {
            get { return  codrotinacad; }
            set {  codrotinacad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRIPTOGRAFAR
        /// Comentário: Criptografar informação no banco.
        /// </summary>
        private string criptografar;
        [XmlElement(ElementName = "CRIPTOGRAFAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Criptografar
        {
            get { return  criptografar; }
            set {  criptografar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: Data de Cadastro
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
        /// Propriedade referente ao campo: EDITAVEL
        /// Comentário: Campo obrigatório
        /// </summary>
        private string editavel;
        [XmlElement(ElementName = "EDITAVEL", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Editavel
        {
            get { return  editavel; }
            set {  editavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXECUTAACAO
        /// Comentário: Executação a ação parametrizada para este campo.
        /// </summary>
        private decimal executaacao;
        [XmlElement(ElementName = "EXECUTAACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Executaacao
        {
            get { return  executaacao; }
            set {  executaacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBIRRESPESQ
        /// Comentário: Pesquisa: Campo complementar a pesquisa de registros
        /// </summary>
        private string exibirrespesq;
        [XmlElement(ElementName = "EXIBIRRESPESQ", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibirrespesq
        {
            get { return  exibirrespesq; }
            set {  exibirrespesq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERALOG
        /// Comentário: Formatação do campo: U: Caixa alta, N: Livre, L: Caixa baixa
        /// </summary>
        private string geralog;
        [XmlElement(ElementName = "GERALOG", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geralog
        {
            get { return  geralog; }
            set {  geralog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MASCARA
        /// Comentário: Ordenação no cadastro
        /// </summary>
        private string mascara;
        [XmlElement(ElementName = "MASCARA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Mascara
        {
            get { return  mascara; }
            set {  mascara = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECAMPO
        /// Comentário: Nome da tabela
        /// </summary>
        private string nomecampo;
        [XmlElement(ElementName = "NOMECAMPO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Nomecampo
        {
            get { return  nomecampo; }
            set {  nomecampo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEOBJETO
        /// Comentário: Campo editável
        /// </summary>
        private string nomeobjeto;
        [XmlElement(ElementName = "NOMEOBJETO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Nomeobjeto
        {
            get { return  nomeobjeto; }
            set {  nomeobjeto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBRIGATORIO
        /// Comentário: Máscara do campo
        /// </summary>
        private string obrigatorio;
        [XmlElement(ElementName = "OBRIGATORIO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Obrigatorio
        {
            get { return  obrigatorio; }
            set {  obrigatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEMCAD
        /// Comentário: Ordenação na pesquisa
        /// </summary>
        private decimal ordemcad;
        [XmlElement(ElementName = "ORDEMCAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Ordemcad
        {
            get { return  ordemcad; }
            set {  ordemcad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEMPSQ
        /// Comentário: Visível na pesquisa
        /// </summary>
        private decimal ordempsq;
        [XmlElement(ElementName = "ORDEMPSQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Ordempsq
        {
            get { return  ordempsq; }
            set {  ordempsq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PSQAUXILIAR
        /// Comentário: Pesquisa: Campos que serão exibido no grid da pesquisa
        /// </summary>
        private string psqauxiliar;
        [XmlElement(ElementName = "PSQAUXILIAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Psqauxiliar
        {
            get { return  psqauxiliar; }
            set {  psqauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PSQCAMPO
        /// Comentário: Pesquisa: Filtro fixo da pesquisa
        /// </summary>
        private string psqcampo;
        [XmlElement(ElementName = "PSQCAMPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Psqcampo
        {
            get { return  psqcampo; }
            set {  psqcampo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PSQFILTRO
        /// Comentário: Pesquisa: Descrição de retorno do resultado da pesquisa
        /// </summary>
        private string psqfiltro;
        [XmlElement(ElementName = "PSQFILTRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Psqfiltro
        {
            get { return  psqfiltro; }
            set {  psqfiltro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PSQOBJETO
        /// Comentário: Seção ou agrupador de campos
        /// </summary>
        private string psqobjeto;
        [XmlElement(ElementName = "PSQOBJETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Psqobjeto
        {
            get { return  psqobjeto; }
            set {  psqobjeto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PSQRETIRACARACTERES
        /// Comentário: 
        /// </summary>
        private string psqretiracaracteres;
        [XmlElement(ElementName = "PSQRETIRACARACTERES", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Psqretiracaracteres
        {
            get { return  psqretiracaracteres; }
            set {  psqretiracaracteres = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PSQRETORNOCODIGO
        /// Comentário: Ajuda do campo
        /// </summary>
        private string psqretornocodigo;
        [XmlElement(ElementName = "PSQRETORNOCODIGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Psqretornocodigo
        {
            get { return  psqretornocodigo; }
            set {  psqretornocodigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PSQRETORNODESCRICAO
        /// Comentário: Pesquisa: Tabela base da pesquisa
        /// </summary>
        private string psqretornodescricao;
        [XmlElement(ElementName = "PSQRETORNODESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Psqretornodescricao
        {
            get { return  psqretornodescricao; }
            set {  psqretornodescricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SECAO
        /// Comentário: Valor default do registro
        /// </summary>
        private string secao;
        [XmlElement(ElementName = "SECAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Secao
        {
            get { return  secao; }
            set {  secao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USARNAPESQUISA
        /// Comentário: Visível no resultado da pesquisa
        /// </summary>
        private string usarnapesquisa;
        [XmlElement(ElementName = "USARNAPESQUISA", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usarnapesquisa
        {
            get { return  usarnapesquisa; }
            set {  usarnapesquisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDEFAULT
        /// Comentário: Vísivel no cadastro
        /// </summary>
        private string valordefault;
        [XmlElement(ElementName = "VALORDEFAULT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Valordefault
        {
            get { return  valordefault; }
            set {  valordefault = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VISIVEL
        /// Comentário: Código da rotina que da manutenção no campo
        /// </summary>
        private string visivel;
        [XmlElement(ElementName = "VISIVEL", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Visivel
        {
            get { return  visivel; }
            set {  visivel = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDicionarioitemrotcust()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDICIONARIOITEMROTCUST";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDicionarioitemrotcust> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDicionarioitemrotcust>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDicionarioitemrotcust> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDicionarioitemrotcust>(where);
        }

        #endregion
    }
}
