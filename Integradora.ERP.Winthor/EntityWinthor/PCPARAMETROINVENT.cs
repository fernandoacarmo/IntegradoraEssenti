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
    /// Classe referente a tabela PCParametroinvent
    /// </summary>
    [XmlType("PCPARAMETROINVENT")]
    public class PCParametroinvent : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINCLUSAO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncinclusao;
        [XmlElement(ElementName = "CODFUNCINCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncinclusao
        {
            get { return  codfuncinclusao; }
            set {  codfuncinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncultalter;
        [XmlElement(ElementName = "CODFUNCULTALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultalter
        {
            get { return  codfuncultalter; }
            set {  codfuncultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPARAM
        /// Coment�rio: 
        /// </summary>
        private decimal codparam;
        [XmlElement(ElementName = "CODPARAM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codparam
        {
            get { return  codparam; }
            set {  codparam = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONFERENCIACEGAQTDE
        /// Coment�rio: 
        /// </summary>
        private string conferenciacegaqtde;
        [XmlElement(ElementName = "CONFERENCIACEGAQTDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conferenciacegaqtde
        {
            get { return  conferenciacegaqtde; }
            set {  conferenciacegaqtde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONFERENCIACEGAVALIDADE
        /// Coment�rio: 
        /// </summary>
        private string conferenciacegavalidade;
        [XmlElement(ElementName = "CONFERENCIACEGAVALIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conferenciacegavalidade
        {
            get { return  conferenciacegavalidade; }
            set {  conferenciacegavalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAULTALTER
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataultalter;
        [XmlElement(ElementName = "DATAULTALTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataultalter
        {
            get { return  dataultalter; }
            set {  dataultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,50)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTOQUECONTABIL
        /// Coment�rio: Par�metro para Atualizar/Movimentar Estoque Cont�bil
        /// </summary>
        private string estoquecontabil;
        [XmlElement(ElementName = "ESTOQUECONTABIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estoquecontabil
        {
            get { return  estoquecontabil; }
            set {  estoquecontabil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INFORMALOTE
        /// Coment�rio: Informa se o n�mero de lote ser� validado.
        /// </summary>
        private string informalote;
        [XmlElement(ElementName = "INFORMALOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Informalote
        {
            get { return  informalote; }
            set {  informalote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INICIARFINALIZAROS
        /// Coment�rio: Informa se o usu�rio ir� obrigatoriamente iniciar e finalizar contagem de OS.
        /// </summary>
        private string iniciarfinalizaros;
        [XmlElement(ElementName = "INICIARFINALIZAROS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Iniciarfinalizaros
        {
            get { return  iniciarfinalizaros; }
            set {  iniciarfinalizaros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INPUTINVENTARIO
        /// Coment�rio: 
        /// </summary>
        private string inputinventario;
        [XmlElement(ElementName = "INPUTINVENTARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Inputinventario
        {
            get { return  inputinventario; }
            set {  inputinventario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INPUTPRIMEIRACONTAGEM
        /// Coment�rio: 
        /// </summary>
        private string inputprimeiracontagem;
        [XmlElement(ElementName = "INPUTPRIMEIRACONTAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Inputprimeiracontagem
        {
            get { return  inputprimeiracontagem; }
            set {  inputprimeiracontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADEESTOQUE
        /// Coment�rio: 
        /// </summary>
        private string quantidadeestoque;
        [XmlElement(ElementName = "QUANTIDADEESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Quantidadeestoque
        {
            get { return  quantidadeestoque; }
            set {  quantidadeestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADEESTOQUEFINAL
        /// Coment�rio: 
        /// </summary>
        private decimal quantidadeestoquefinal;
        [XmlElement(ElementName = "QUANTIDADEESTOQUEFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Quantidadeestoquefinal
        {
            get { return  quantidadeestoquefinal; }
            set {  quantidadeestoquefinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADEESTOQUEINICIAL
        /// Coment�rio: 
        /// </summary>
        private decimal quantidadeestoqueinicial;
        [XmlElement(ElementName = "QUANTIDADEESTOQUEINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Quantidadeestoqueinicial
        {
            get { return  quantidadeestoqueinicial; }
            set {  quantidadeestoqueinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCHECAGEMQTDE
        /// Coment�rio: 
        /// </summary>
        private string tipochecagemqtde;
        [XmlElement(ElementName = "TIPOCHECAGEMQTDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipochecagemqtde
        {
            get { return  tipochecagemqtde; }
            set {  tipochecagemqtde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCHECAGEMVALIDADE
        /// Coment�rio: 
        /// </summary>
        private string tipochecagemvalidade;
        [XmlElement(ElementName = "TIPOCHECAGEMVALIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipochecagemvalidade
        {
            get { return  tipochecagemvalidade; }
            set {  tipochecagemvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOINVENTARIO
        /// Coment�rio: 
        /// </summary>
        private string tipoinventario;
        [XmlElement(ElementName = "TIPOINVENTARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoinventario
        {
            get { return  tipoinventario; }
            set {  tipoinventario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADEMEDIDAPICKING
        /// Coment�rio: 
        /// </summary>
        private string unidademedidapicking;
        [XmlElement(ElementName = "UNIDADEMEDIDAPICKING", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Unidademedidapicking
        {
            get { return  unidademedidapicking; }
            set {  unidademedidapicking = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADEMEDIDAPULMAO
        /// Coment�rio: 
        /// </summary>
        private string unidademedidapulmao;
        [XmlElement(ElementName = "UNIDADEMEDIDAPULMAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Unidademedidapulmao
        {
            get { return  unidademedidapulmao; }
            set {  unidademedidapulmao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZACONTROLEEQUIPE
        /// Coment�rio: 
        /// </summary>
        private string utilizacontroleequipe;
        [XmlElement(ElementName = "UTILIZACONTROLEEQUIPE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacontroleequipe
        {
            get { return  utilizacontroleequipe; }
            set {  utilizacontroleequipe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VISUALIZADADOSPRODLISTA
        /// Coment�rio: Visualiza��o dos dados do produto na listagem de contagem
        /// </summary>
        private string visualizadadosprodlista;
        [XmlElement(ElementName = "VISUALIZADADOSPRODLISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Visualizadadosprodlista
        {
            get { return  visualizadadosprodlista; }
            set {  visualizadadosprodlista = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCParametroinvent()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPARAMETROINVENT";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCParametroinvent> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCParametroinvent>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCParametroinvent> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCParametroinvent>(where);
        }

        #endregion
    }
}
