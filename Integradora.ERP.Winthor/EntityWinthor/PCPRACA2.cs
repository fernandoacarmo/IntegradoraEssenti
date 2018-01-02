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
    /// Classe referente a tabela PCPraca2
    /// </summary>
    [XmlType("PCPRACA2")]
    public class PCPraca2 : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CEPFINAL
        /// Comentário: 
        /// </summary>
        private string cepfinal;
        [XmlElement(ElementName = "CEPFINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cepfinal
        {
            get { return  cepfinal; }
            set {  cepfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEPINICIAL
        /// Comentário: 
        /// </summary>
        private string cepinicial;
        [XmlElement(ElementName = "CEPINICIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cepinicial
        {
            get { return  cepinicial; }
            set {  cepinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMUNIC
        /// Comentário: 
        /// </summary>
        private decimal codmunic;
        [XmlElement(ElementName = "CODMUNIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmunic
        {
            get { return  codmunic; }
            set {  codmunic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACAORIG
        /// Comentário: 
        /// </summary>
        private decimal codpracaorig;
        [XmlElement(ElementName = "CODPRACAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpracaorig
        {
            get { return  codpracaorig; }
            set {  codpracaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACAORIG2
        /// Comentário: 
        /// </summary>
        private decimal codpracaorig2;
        [XmlElement(ElementName = "CODPRACAORIG2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpracaorig2
        {
            get { return  codpracaorig2; }
            set {  codpracaorig2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACAORIG3
        /// Comentário: 
        /// </summary>
        private decimal codpracaorig3;
        [XmlElement(ElementName = "CODPRACAORIG3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpracaorig3
        {
            get { return  codpracaorig3; }
            set {  codpracaorig3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACAORIG4
        /// Comentário: 
        /// </summary>
        private decimal codpracaorig4;
        [XmlElement(ElementName = "CODPRACAORIG4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpracaorig4
        {
            get { return  codpracaorig4; }
            set {  codpracaorig4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DISTANCIA
        /// Comentário: 
        /// </summary>
        private decimal distancia;
        [XmlElement(ElementName = "DISTANCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Distancia
        {
            get { return  distancia; }
            set {  distancia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: 
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO2
        /// Comentário: 
        /// </summary>
        private decimal numregiao2;
        [XmlElement(ElementName = "NUMREGIAO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiao2
        {
            get { return  numregiao2; }
            set {  numregiao2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETEPROGRESS
        /// Comentário: 
        /// </summary>
        private decimal perfreteprogress;
        [XmlElement(ElementName = "PERFRETEPROGRESS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perfreteprogress
        {
            get { return  perfreteprogress; }
            set {  perfreteprogress = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POPULACAO
        /// Comentário: 
        /// </summary>
        private decimal populacao;
        [XmlElement(ElementName = "POPULACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Populacao
        {
            get { return  populacao; }
            set {  populacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRACA
        /// Comentário: 
        /// </summary>
        private string praca;
        [XmlElement(ElementName = "PRACA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,25)]
        public string Praca
        {
            get { return  praca; }
            set {  praca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTA
        /// Comentário: 
        /// </summary>
        private decimal rota;
        [XmlElement(ElementName = "ROTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Rota
        {
            get { return  rota; }
            set {  rota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQROTA
        /// Comentário: 
        /// </summary>
        private decimal seqrota;
        [XmlElement(ElementName = "SEQROTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Seqrota
        {
            get { return  seqrota; }
            set {  seqrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: 
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAFRETE
        /// Comentário: 
        /// </summary>
        private decimal vlpautafrete;
        [XmlElement(ElementName = "VLPAUTAFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlpautafrete
        {
            get { return  vlpautafrete; }
            set {  vlpautafrete = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPraca2()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRACA2";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPraca2> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPraca2>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPraca2> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPraca2>(where);
        }

        #endregion
    }
}
