using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTPoliticadesconto
    /// </summary>
    [XmlType("ESTPOLITICADESCONTO")]
    public class ESTPoliticadesconto : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Comentário: 
        /// </summary>
        private decimal codcategoria;
        [XmlElement(ElementName = "CODCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcategoria
        {
            get { return  codcategoria; }
            set {  codcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODDESCONTO
        /// Comentário: 
        /// </summary>
        private decimal coddesconto;
        [XmlElement(ElementName = "CODDESCONTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Coddesconto
        {
            get { return  coddesconto; }
            set {  coddesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Comentário: 
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Comentário: 
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBCATEGORIA
        /// Comentário: 
        /// </summary>
        private decimal codsubcategoria;
        [XmlElement(ElementName = "CODSUBCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsubcategoria
        {
            get { return  codsubcategoria; }
            set {  codsubcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIADOMINGO
        /// Comentário: 
        /// </summary>
        private string diadomingo;
        [XmlElement(ElementName = "DIADOMINGO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diadomingo
        {
            get { return  diadomingo; }
            set {  diadomingo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAQUARTA
        /// Comentário: 
        /// </summary>
        private string diaquarta;
        [XmlElement(ElementName = "DIAQUARTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diaquarta
        {
            get { return  diaquarta; }
            set {  diaquarta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAQUINTA
        /// Comentário: 
        /// </summary>
        private string diaquinta;
        [XmlElement(ElementName = "DIAQUINTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diaquinta
        {
            get { return  diaquinta; }
            set {  diaquinta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASABADO
        /// Comentário: 
        /// </summary>
        private string diasabado;
        [XmlElement(ElementName = "DIASABADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diasabado
        {
            get { return  diasabado; }
            set {  diasabado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEGUNDA
        /// Comentário: 
        /// </summary>
        private string diasegunda;
        [XmlElement(ElementName = "DIASEGUNDA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diasegunda
        {
            get { return  diasegunda; }
            set {  diasegunda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEXTA
        /// Comentário: 
        /// </summary>
        private string diasexta;
        [XmlElement(ElementName = "DIASEXTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diasexta
        {
            get { return  diasexta; }
            set {  diasexta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIATERCA
        /// Comentário: 
        /// </summary>
        private string diaterca;
        [XmlElement(ElementName = "DIATERCA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Diaterca
        {
            get { return  diaterca; }
            set {  diaterca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINAL
        /// Comentário: 
        /// </summary>
        private DateTime? dtfinal;
        [XmlElement(ElementName = "DTFINAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtfinal
        {
            get { return  dtfinal; }
            set {  dtfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRFINAL
        /// Comentário: 
        /// </summary>
        private DateTime? hrfinal;
        [XmlElement(ElementName = "HRFINAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Hrfinal
        {
            get { return  hrfinal; }
            set {  hrfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRINICIO
        /// Comentário: 
        /// </summary>
        private DateTime? hrinicio;
        [XmlElement(ElementName = "HRINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Hrinicio
        {
            get { return  hrinicio; }
            set {  hrinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCONTO
        /// Comentário: 
        /// </summary>
        private decimal percdesconto;
        [XmlElement(ElementName = "PERCDESCONTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Percdesconto
        {
            get { return  percdesconto; }
            set {  percdesconto = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTPoliticadesconto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTPOLITICADESCONTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTPoliticadesconto> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTPoliticadesconto.GetStringConnection());
            return ba.Listar<ESTPoliticadesconto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTPoliticadesconto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTPoliticadesconto.GetStringConnection());
            return ba.Existe<ESTPoliticadesconto>(where);
        }

        #endregion
    }
}
