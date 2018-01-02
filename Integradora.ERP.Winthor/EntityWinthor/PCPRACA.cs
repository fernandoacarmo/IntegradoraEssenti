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
    /// Classe referente a tabela PCPraca
    /// </summary>
    [XmlType("PCPRACA")]
    public class PCPraca : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CEPFINAL
        /// Coment�rio: C�digo do CEP Final da Pra�a.
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
        /// Coment�rio: C�digo do CEP Inicial da Pra�a.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACAORIG
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODPRACAPRINCIPAL
        /// Coment�rio: Indica o c�digo da pra�a principal.
        /// </summary>
        private decimal codpracaprincipal;
        [XmlElement(ElementName = "CODPRACAPRINCIPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codpracaprincipal
        {
            get { return  codpracaprincipal; }
            set {  codpracaprincipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DISTANCIA
        /// Coment�rio: 
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
        /// Coment�rio: Data em que foi efetuado o cadastro da pra�a.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Indica as obseva��es para o cadastro de pra�a.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMINCARREG
        /// Coment�rio: Varia��o do valor minimo de carga
        /// </summary>
        private decimal percmincarreg;
        [XmlElement(ElementName = "PERCMINCARREG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percmincarreg
        {
            get { return  percmincarreg; }
            set {  percmincarreg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETEPROGRESS
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PRIORIDADEENTREGA
        /// Coment�rio: Prioridade de entrega de pedidos na pra�a.
        /// </summary>
        private string prioridadeentrega;
        [XmlElement(ElementName = "PRIORIDADEENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prioridadeentrega
        {
            get { return  prioridadeentrega; }
            set {  prioridadeentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTA
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: TIPOPRACA
        /// Coment�rio: Tipo de Pra�a F ou P - Frete ou Pra�a.
        /// </summary>
        private string tipopraca;
        [XmlElement(ElementName = "TIPOPRACA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipopraca
        {
            get { return  tipopraca; }
            set {  tipopraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINCARREG
        /// Coment�rio: Vl. M�nimo Montagem Carga.
        /// </summary>
        private decimal vlmincarreg;
        [XmlElement(ElementName = "VLMINCARREG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlmincarreg
        {
            get { return  vlmincarreg; }
            set {  vlmincarreg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAFRETE
        /// Coment�rio: 
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

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPraca()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRACA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPraca> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPraca>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPraca> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPraca>(where);
        }

        #endregion
    }
}
