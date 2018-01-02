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
    /// Classe referente a tabela PCGrupoavaria
    /// </summary>
    [XmlType("PCGRUPOAVARIA")]
    public class PCGrupoavaria : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Cód. Filial
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: Cód. Do fornecedor
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPO
        /// Comentário: Cód. Grupo avaria.
        /// </summary>
        private decimal codgrupo;
        [XmlElement(ElementName = "CODGRUPO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codgrupo
        {
            get { return  codgrupo; }
            set {  codgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVOAVARIA
        /// Comentário: Código de motivo o qual os produtos do grupo estão sendo avariados.
        /// </summary>
        private decimal codmotivoavaria;
        [XmlElement(ElementName = "CODMOTIVOAVARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codmotivoavaria
        {
            get { return  codmotivoavaria; }
            set {  codmotivoavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Cód. Do produto
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODTROCA
        /// Comentário: Produto para troca
        /// </summary>
        private decimal codprodtroca;
        [XmlElement(ElementName = "CODPRODTROCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodtroca
        {
            get { return  codprodtroca; }
            set {  codprodtroca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOAVARIA
        /// Comentário: Cód. Do tipo de avaria.
        /// </summary>
        private decimal codtipoavaria;
        [XmlElement(ElementName = "CODTIPOAVARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Codtipoavaria
        {
            get { return  codtipoavaria; }
            set {  codtipoavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOGER
        /// Comentário: Código do usuario gerador do grupo.
        /// </summary>
        private decimal codusuarioger;
        [XmlElement(ElementName = "CODUSUARIOGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioger
        {
            get { return  codusuarioger; }
            set {  codusuarioger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATABAIXAGRUPO
        /// Comentário: Data de baixa do Grupo
        /// </summary>
        private DateTime? databaixagrupo;
        [XmlElement(ElementName = "DATABAIXAGRUPO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Databaixagrupo
        {
            get { return  databaixagrupo; }
            set {  databaixagrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAGRUPO
        /// Comentário: Data de geração do Grupo
        /// </summary>
        private DateTime? datagrupo;
        [XmlElement(ElementName = "DATAGRUPO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datagrupo
        {
            get { return  datagrupo; }
            set {  datagrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMITENF
        /// Comentário: Valida se o grupo emite ou não nf
        /// </summary>
        private string emitenf;
        [XmlElement(ElementName = "EMITENF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emitenf
        {
            get { return  emitenf; }
            set {  emitenf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: Numero do lote
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: Numero do pedido
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQPED
        /// Comentário: Sequencia do pedido
        /// </summary>
        private decimal numseqped;
        [XmlElement(ElementName = "NUMSEQPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseqped
        {
            get { return  numseqped; }
            set {  numseqped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVERBA
        /// Comentário: Numero da verba
        /// </summary>
        private decimal numverba;
        [XmlElement(ElementName = "NUMVERBA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numverba
        {
            get { return  numverba; }
            set {  numverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: Qt. Avariado
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTORIGINAL
        /// Comentário: Qtde. original do grupo
        /// </summary>
        private decimal qtoriginal;
        [XmlElement(ElementName = "QTORIGINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtoriginal
        {
            get { return  qtoriginal; }
            set {  qtoriginal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: Status do grupo
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOAVARIA
        /// Comentário: Des. Tipo avaria
        /// </summary>
        private string tipoavaria;
        [XmlElement(ElementName = "TIPOAVARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Tipoavaria
        {
            get { return  tipoavaria; }
            set {  tipoavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDOGRUPO
        /// Comentário: Valor do grupo
        /// </summary>
        private decimal valordogrupo;
        [XmlElement(ElementName = "VALORDOGRUPO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Valordogrupo
        {
            get { return  valordogrupo; }
            set {  valordogrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBA
        /// Comentário: Vlr. Verba associada
        /// </summary>
        private decimal vlverba;
        [XmlElement(ElementName = "VLVERBA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlverba
        {
            get { return  vlverba; }
            set {  vlverba = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCGrupoavaria()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCGRUPOAVARIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCGrupoavaria> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCGrupoavaria>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCGrupoavaria> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCGrupoavaria>(where);
        }

        #endregion
    }
}
