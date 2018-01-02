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
    /// Classe referente a tabela PCCertific
    /// </summary>
    [XmlType("PCCERTIFIC")]
    public class PCCertific : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CLASSE
        /// Comentário: 
        /// </summary>
        private string classe;
        [XmlElement(ElementName = "CLASSE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Classe
        {
            get { return  classe; }
            set {  classe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCERTIFIC
        /// Comentário: 
        /// </summary>
        private decimal codcertific;
        [XmlElement(ElementName = "CODCERTIFIC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codcertific
        {
            get { return  codcertific; }
            set {  codcertific = value; }
        }

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
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Comentário: 
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Comentário: 
        /// </summary>
        private string estado;
        [XmlElement(ElementName = "ESTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estado
        {
            get { return  estado; }
            set {  estado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTEMITCLASSIFIC
        /// Comentário: 
        /// </summary>
        private string estemitclassific;
        [XmlElement(ElementName = "ESTEMITCLASSIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Estemitclassific
        {
            get { return  estemitclassific; }
            set {  estemitclassific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTEMITSELO
        /// Comentário: 
        /// </summary>
        private string estemitselo;
        [XmlElement(ElementName = "ESTEMITSELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Estemitselo
        {
            get { return  estemitselo; }
            set {  estemitselo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPO
        /// Comentário: 
        /// </summary>
        private string grupo;
        [XmlElement(ElementName = "GRUPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Grupo
        {
            get { return  grupo; }
            set {  grupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARCA
        /// Comentário: 
        /// </summary>
        private string marca;
        [XmlElement(ElementName = "MARCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Marca
        {
            get { return  marca; }
            set {  marca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEMNF
        /// Comentário: 
        /// </summary>
        private string mensagemnf;
        [XmlElement(ElementName = "MENSAGEMNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Mensagemnf
        {
            get { return  mensagemnf; }
            set {  mensagemnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCERTIFICADO
        /// Comentário: 
        /// </summary>
        private string numcertificado;
        [XmlElement(ElementName = "NUMCERTIFICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numcertificado
        {
            get { return  numcertificado; }
            set {  numcertificado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: Indica o número do lote do certificado.
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMATEST
        /// Comentário: 
        /// </summary>
        private decimal percmatest;
        [XmlElement(ElementName = "PERCMATEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percmatest
        {
            get { return  percmatest; }
            set {  percmatest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCQUEBRADO
        /// Comentário: 
        /// </summary>
        private decimal percquebrado;
        [XmlElement(ElementName = "PERCQUEBRADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percquebrado
        {
            get { return  percquebrado; }
            set {  percquebrado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCUMIDADE
        /// Comentário: 
        /// </summary>
        private decimal percumidade;
        [XmlElement(ElementName = "PERCUMIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percumidade
        {
            get { return  percumidade; }
            set {  percumidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOLIQ
        /// Comentário: 
        /// </summary>
        private decimal pesoliq;
        [XmlElement(ElementName = "PESOLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Pesoliq
        {
            get { return  pesoliq; }
            set {  pesoliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOUTILIZADO
        /// Comentário: 
        /// </summary>
        private decimal pesoutilizado;
        [XmlElement(ElementName = "PESOUTILIZADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Pesoutilizado
        {
            get { return  pesoutilizado; }
            set {  pesoutilizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODUTO
        /// Comentário: 
        /// </summary>
        private string produto;
        [XmlElement(ElementName = "PRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Produto
        {
            get { return  produto; }
            set {  produto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: 
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBGRUPO
        /// Comentário: 
        /// </summary>
        private string subgrupo;
        [XmlElement(ElementName = "SUBGRUPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Subgrupo
        {
            get { return  subgrupo; }
            set {  subgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
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
        /// Propriedade referente ao campo: TIPODOC
        /// Comentário: 
        /// </summary>
        private string tipodoc;
        [XmlElement(ElementName = "TIPODOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodoc
        {
            get { return  tipodoc; }
            set {  tipodoc = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCertific()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCERTIFIC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCertific> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCertific>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCertific> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCertific>(where);
        }

        #endregion
    }
}
