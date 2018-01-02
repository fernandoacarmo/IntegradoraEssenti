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
    /// Classe referente a tabela PCDicionarioitem
    /// </summary>
    [XmlType("PCDICIONARIOITEM")]
    public class PCDicionarioitem : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AJUDA
        /// Comentário: Ajuda para o campo, montagem do hint das telas
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
        /// Comentário: S => Campo auto-gerado sempre, N => Campo nao auto-gerado, Tabela.Campo="valor" => Se true, o campo e auto-gerado
        /// </summary>
        private string autogerar;
        [XmlElement(ElementName = "AUTOGERAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Autogerar
        {
            get { return  autogerar; }
            set {  autogerar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHARCASE
        /// Comentário: Formato das letras: U - Caixa alta/ Maiúsculo, N - Livre, L - Caixa baixa / minúsculo
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
        /// Propriedade referente ao campo: CODROTULO
        /// Comentário: Nome do rótulo default, valor padrão para este campo. Campo Default
        /// </summary>
        private string codrotulo;
        [XmlElement(ElementName = "CODROTULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codrotulo
        {
            get { return  codrotulo; }
            set {  codrotulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRIADOPELOCLIENTE
        /// Comentário: Indica se o campo foi criado pelo cliente ou pela PC
        /// </summary>
        private string criadopelocliente;
        [XmlElement(ElementName = "CRIADOPELOCLIENTE", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Criadopelocliente
        {
            get { return  criadopelocliente; }
            set {  criadopelocliente = value; }
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
        /// Comentário: Data de criação do registro
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
        /// Propriedade referente ao campo: FORMULAAUTOGERACAO
        /// Comentário: Indica a formula para auto-gerar o valor deste registro. Usado em conjunto com o campo AutoGerar.
        /// </summary>
        private string formulaautogeracao;
        [XmlElement(ElementName = "FORMULAAUTOGERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Formulaautogeracao
        {
            get { return  formulaautogeracao; }
            set {  formulaautogeracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MASCARA
        /// Comentário: Máscara, utilizado para formatar campos. Campo Default
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
        /// Propriedade referente ao campo: MULTIEDICAO
        /// Comentário: Se o campo aceita ser processado na multi edição, através das teclas F11 e F10 do grid horizontal
        /// </summary>
        private string multiedicao;
        [XmlElement(ElementName = "MULTIEDICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Multiedicao
        {
            get { return  multiedicao; }
            set {  multiedicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECAMPO
        /// Comentário: Nome do campo
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
        /// Comentário: Nome da tabela
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
        /// Propriedade referente ao campo: PSQRETIRACARACTERES
        /// Comentário: Retirar caracteres especiais de campos e filtro durante a pesquisa. Ex.: CGC, CPF, IE
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
        /// Propriedade referente ao campo: TITULO
        /// Comentário: Legenda do campo, curta descrição do mesmo
        /// </summary>
        private string titulo;
        [XmlElement(ElementName = "TITULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Titulo
        {
            get { return  titulo; }
            set {  titulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOCRIADOR
        /// Comentário: Usuário que criou o campo no banco de dados
        /// </summary>
        private string usuariocriador;
        [XmlElement(ElementName = "USUARIOCRIADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Usuariocriador
        {
            get { return  usuariocriador; }
            set {  usuariocriador = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDicionarioitem()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDICIONARIOITEM";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDicionarioitem> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDicionarioitem>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDicionarioitem> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDicionarioitem>(where);
        }

        #endregion
    }
}
