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
    /// Classe referente a tabela PCSuperv
    /// </summary>
    [XmlType("PCSUPERV")]
    public class PCSuperv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: COD_CADRCA
        /// Comentário: 
        /// </summary>
        private decimal cod_cadrca;
        [XmlElement(ElementName = "COD_CADRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Cod_Cadrca
        {
            get { return  cod_cadrca; }
            set {  cod_cadrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOORDENADOR
        /// Comentário: Indica o Coordenador de venda.
        /// </summary>
        private decimal codcoordenador;
        [XmlElement(ElementName = "CODCOORDENADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcoordenador
        {
            get { return  codcoordenador; }
            set {  codcoordenador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGERENTE
        /// Comentário: 
        /// </summary>
        private decimal codgerente;
        [XmlElement(ElementName = "CODGERENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codgerente
        {
            get { return  codgerente; }
            set {  codgerente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Comentário: 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CPF
        /// Comentário: Indica o numero do CPF.
        /// </summary>
        private string cpf;
        [XmlElement(ElementName = "CPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Cpf
        {
            get { return  cpf; }
            set {  cpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTADMISSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtadmissao;
        [XmlElement(ElementName = "DTADMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtadmissao
        {
            get { return  dtadmissao; }
            set {  dtadmissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDEMISSAO
        /// Comentário: Indica a data de emissão.
        /// </summary>
        private DateTime? dtdemissao;
        [XmlElement(ElementName = "DTDEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdemissao
        {
            get { return  dtdemissao; }
            set {  dtdemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Comentário: 
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMARGEMPREV
        /// Comentário: 
        /// </summary>
        private decimal percmargemprev;
        [XmlElement(ElementName = "PERCMARGEMPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percmargemprev
        {
            get { return  percmargemprev; }
            set {  percmargemprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMISSAO
        /// Comentário: 
        /// </summary>
        private decimal percomissao;
        [XmlElement(ElementName = "PERCOMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percomissao
        {
            get { return  percomissao; }
            set {  percomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPARTVENDAPREV
        /// Comentário: 
        /// </summary>
        private decimal percpartvendaprev;
        [XmlElement(ElementName = "PERCPARTVENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percpartvendaprev
        {
            get { return  percpartvendaprev; }
            set {  percpartvendaprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Comentário: 
        /// </summary>
        private string posicao;
        [XmlElement(ElementName = "POSICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Posicao
        {
            get { return  posicao; }
            set {  posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGIONAL
        /// Comentário: 
        /// </summary>
        private decimal regional;
        [XmlElement(ElementName = "REGIONAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Regional
        {
            get { return  regional; }
            set {  regional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSUPERVISOR
        /// Comentário: 
        /// </summary>
        private string tiposupervisor;
        [XmlElement(ElementName = "TIPOSUPERVISOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiposupervisor
        {
            get { return  tiposupervisor; }
            set {  tiposupervisor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCSuperv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSUPERV";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSuperv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSuperv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSuperv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSuperv>(where);
        }

        #endregion
    }
}
