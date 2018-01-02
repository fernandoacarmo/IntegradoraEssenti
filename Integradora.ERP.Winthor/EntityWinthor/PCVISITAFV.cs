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
    /// Classe referente a tabela PCVisitafv
    /// </summary>
    [XmlType("PCVISITAFV")]
    public class PCVisitafv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ASSUNTO
        /// Coment�rio: 
        /// </summary>
        private string assunto;
        [XmlElement(ElementName = "ASSUNTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,4000)]
        public string Assunto
        {
            get { return  assunto; }
            set {  assunto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCCLI
        /// Coment�rio: 
        /// </summary>
        private string cgccli;
        [XmlElement(ElementName = "CGCCLI", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public string Cgccli
        {
            get { return  cgccli; }
            set {  cgccli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: Codigo do cliente que ser� usado em conjunto com o campo cnpj para identificar o cliente no caso de ter no cadastro mais de um cliente com mesmo cnpj
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVO
        /// Coment�rio: 
        /// </summary>
        private decimal codmotivo;
        [XmlElement(ElementName = "CODMOTIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmotivo
        {
            get { return  codmotivo; }
            set {  codmotivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTA
        /// Coment�rio: Codigo da Rota
        /// </summary>
        private decimal codrota;
        [XmlElement(ElementName = "CODROTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codrota
        {
            get { return  codrota; }
            set {  codrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Coment�rio: Data de Altera��o no registro
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Coment�rio: Grava Data e Hora da �ltima Importa��o.
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFINAL
        /// Coment�rio: 
        /// </summary>
        private decimal horafinal;
        [XmlElement(ElementName = "HORAFINAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Horafinal
        {
            get { return  horafinal; }
            set {  horafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINICIAL
        /// Coment�rio: 
        /// </summary>
        private decimal horainicial;
        [XmlElement(ElementName = "HORAINICIAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Horainicial
        {
            get { return  horainicial; }
            set {  horainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Coment�rio: 
        /// </summary>
        private decimal importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOFINAL
        /// Coment�rio: 
        /// </summary>
        private decimal minutofinal;
        [XmlElement(ElementName = "MINUTOFINAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Minutofinal
        {
            get { return  minutofinal; }
            set {  minutofinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOINICIAL
        /// Coment�rio: 
        /// </summary>
        private decimal minutoinicial;
        [XmlElement(ElementName = "MINUTOINICIAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Minutoinicial
        {
            get { return  minutoinicial; }
            set {  minutoinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO_PC
        /// Coment�rio: 
        /// </summary>
        private string observacao_pc;
        [XmlElement(ElementName = "OBSERVACAO_PC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Observacao_Pc
        {
            get { return  observacao_pc; }
            set {  observacao_pc = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCVisitafv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVISITAFV";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCVisitafv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCVisitafv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCVisitafv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCVisitafv>(where);
        }

        #endregion
    }
}
