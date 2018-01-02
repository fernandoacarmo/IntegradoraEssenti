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
    /// Classe referente a tabela PCWmsprodut
    /// </summary>
    [XmlType("PCWMSPRODUT")]
    public class PCWmsprodut : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALTURAARM
        /// Comentário: 
        /// </summary>
        private decimal alturaarm;
        [XmlElement(ElementName = "ALTURAARM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Alturaarm
        {
            get { return  alturaarm; }
            set {  alturaarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURAM3
        /// Comentário: 
        /// </summary>
        private decimal alturam3;
        [XmlElement(ElementName = "ALTURAM3", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Alturam3
        {
            get { return  alturam3; }
            set {  alturam3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURAPAL
        /// Comentário: 
        /// </summary>
        private decimal alturapal;
        [XmlElement(ElementName = "ALTURAPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Alturapal
        {
            get { return  alturapal; }
            set {  alturapal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZADADOSLOGISTICOS
        /// Comentário: 
        /// </summary>
        private string atualizadadoslogisticos;
        [XmlElement(ElementName = "ATUALIZADADOSLOGISTICOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Atualizadadoslogisticos
        {
            get { return  atualizadadoslogisticos; }
            set {  atualizadadoslogisticos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFAB
        /// Comentário: 
        /// </summary>
        private string codfab;
        [XmlElement(ElementName = "CODFAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Codfab
        {
            get { return codfab; }
            set { codfab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR2
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar2;
        [XmlElement(ElementName = "CODAUXILIAR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Codauxiliar2
        {
            get { return  codauxiliar2; }
            set {  codauxiliar2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Comentário: 
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMARCA
        /// Comentário: 
        /// </summary>
        private decimal codmarca;
        [XmlElement(ElementName = "CODMARCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codmarca
        {
            get { return codmarca; }
            set { codmarca = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: CODPRODPRINC
        /// Comentário: 
        /// </summary>
        private decimal codprodprinc;
        [XmlElement(ElementName = "CODPRODPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodprinc
        {
            get { return  codprodprinc; }
            set {  codprodprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Comentário: 
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRIMENTOARM
        /// Comentário: 
        /// </summary>
        private decimal comprimentoarm;
        [XmlElement(ElementName = "COMPRIMENTOARM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Comprimentoarm
        {
            get { return  comprimentoarm; }
            set {  comprimentoarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRIMENTOM3
        /// Comentário: 
        /// </summary>
        private decimal comprimentom3;
        [XmlElement(ElementName = "COMPRIMENTOM3", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Comprimentom3
        {
            get { return  comprimentom3; }
            set {  comprimentom3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLEDTVALIDADE
        /// Comentário: 
        /// </summary>
        private string controledtvalidade;
        [XmlElement(ElementName = "CONTROLEDTVALIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controledtvalidade
        {
            get { return  controledtvalidade; }
            set {  controledtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,300)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROCESSAMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtprocessamento;
        [XmlElement(ElementName = "DTPROCESSAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprocessamento
        {
            get { return  dtprocessamento; }
            set {  dtprocessamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEM
        /// Comentário: 
        /// </summary>
        private string embalagem;
        [XmlElement(ElementName = "EMBALAGEM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public string Embalagem
        {
            get { return  embalagem; }
            set {  embalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEMMASTER
        /// Comentário: 
        /// </summary>
        private string embalagemmaster;
        [XmlElement(ElementName = "EMBALAGEMMASTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Embalagemmaster
        {
            get { return  embalagemmaster; }
            set {  embalagemmaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURAARM
        /// Comentário: 
        /// </summary>
        private decimal larguraarm;
        [XmlElement(ElementName = "LARGURAARM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Larguraarm
        {
            get { return  larguraarm; }
            set {  larguraarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURAM3
        /// Comentário: 
        /// </summary>
        private decimal larguram3;
        [XmlElement(ElementName = "LARGURAM3", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Larguram3
        {
            get { return  larguram3; }
            set {  larguram3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LASTROPAL
        /// Comentário: 
        /// </summary>
        private decimal lastropal;
        [XmlElement(ElementName = "LASTROPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Lastropal
        {
            get { return  lastropal; }
            set {  lastropal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMGER
        /// Comentário: 
        /// </summary>
        private decimal numger;
        [XmlElement(ElementName = "NUMGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numger
        {
            get { return  numger; }
            set {  numger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Comentário: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERACAO
        /// Comentário: 
        /// </summary>
        private string operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Operacao
        {
            get { return  operacao; }
            set {  operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBRUTO
        /// Comentário: 
        /// </summary>
        private decimal pesobruto;
        [XmlElement(ElementName = "PESOBRUTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Pesobruto
        {
            get { return  pesobruto; }
            set {  pesobruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOLIQ
        /// Comentário: 
        /// </summary>
        private decimal pesoliq;
        [XmlElement(ElementName = "PESOLIQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Pesoliq
        {
            get { return  pesoliq; }
            set {  pesoliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOVAL
        /// Comentário: 
        /// </summary>
        private decimal prazoval;
        [XmlElement(ElementName = "PRAZOVAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoval
        {
            get { return  prazoval; }
            set {  prazoval = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNIT
        /// Comentário: 
        /// </summary>
        private decimal qtunit;
        [XmlElement(ElementName = "QTUNIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtunit
        {
            get { return  qtunit; }
            set {  qtunit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNITCX
        /// Comentário: 
        /// </summary>
        private decimal qtunitcx;
        [XmlElement(ElementName = "QTUNITCX", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Qtunitcx
        {
            get { return  qtunitcx; }
            set {  qtunitcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEMAFORO
        /// Comentário: 
        /// </summary>
        private decimal semaforo;
        [XmlElement(ElementName = "SEMAFORO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Semaforo
        {
            get { return  semaforo; }
            set {  semaforo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE
        /// Comentário: 
        /// </summary>
        private string unidade;
        [XmlElement(ElementName = "UNIDADE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Unidade
        {
            get { return  unidade; }
            set {  unidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADEMASTER
        /// Comentário: 
        /// </summary>
        private string unidademaster;
        [XmlElement(ElementName = "UNIDADEMASTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidademaster
        {
            get { return  unidademaster; }
            set {  unidademaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USANUMEROSERIE
        /// Comentário: 
        /// </summary>
        private string usanumeroserie;
        [XmlElement(ElementName = "USANUMEROSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usanumeroserie
        {
            get { return  usanumeroserie; }
            set {  usanumeroserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUME
        /// Comentário: 
        /// </summary>
        private decimal volume;
        [XmlElement(ElementName = "VOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Volume
        {
            get { return  volume; }
            set {  volume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUMEARM
        /// Comentário: 
        /// </summary>
        private decimal volumearm;
        [XmlElement(ElementName = "VOLUMEARM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public decimal Volumearm
        {
            get { return  volumearm; }
            set {  volumearm = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWmsprodut()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSPRODUT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWmsprodut> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmsprodut.GetStringConnection());
            return ba.Listar<PCWmsprodut>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWmsprodut> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmsprodut.GetStringConnection());
            return ba.Existe<PCWmsprodut>(where);
        }

        #endregion
    }
}
