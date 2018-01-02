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
    /// Classe referente a tabela PCHistcob
    /// </summary>
    [XmlType("PCHISTCOB")]
    public class PCHistcob : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGENDARNOVOCONTATO
        /// Coment�rio: 
        /// </summary>
        private string agendarnovocontato;
        [XmlElement(ElementName = "AGENDARNOVOCONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agendarnovocontato
        {
            get { return  agendarnovocontato; }
            set {  agendarnovocontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: 
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSTATUSCOB
        /// Coment�rio: Indica a situa��o da cobran�a.
        /// </summary>
        private decimal codstatuscob;
        [XmlElement(ElementName = "CODSTATUSCOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codstatuscob
        {
            get { return  codstatuscob; }
            set {  codstatuscob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATO
        /// Coment�rio: 
        /// </summary>
        private string contato;
        [XmlElement(ElementName = "CONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Contato
        {
            get { return  contato; }
            set {  contato = value; }
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
        /// Propriedade referente ao campo: DTPROXCONTATO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtproxcontato;
        [XmlElement(ElementName = "DTPROXCONTATO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxcontato
        {
            get { return  dtproxcontato; }
            set {  dtproxcontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAPROXCONTATO
        /// Coment�rio: 
        /// </summary>
        private decimal horaproxcontato;
        [XmlElement(ElementName = "HORAPROXCONTATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horaproxcontato
        {
            get { return  horaproxcontato; }
            set {  horaproxcontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOPROXCONTATO
        /// Coment�rio: 
        /// </summary>
        private decimal minutoproxcontato;
        [XmlElement(ElementName = "MINUTOPROXCONTATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutoproxcontato
        {
            get { return  minutoproxcontato; }
            set {  minutoproxcontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGCOB
        /// Coment�rio: N�mero do registro de cobran�a.
        /// </summary>
        private decimal numregcob;
        [XmlElement(ElementName = "NUMREGCOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numregcob
        {
            get { return  numregcob; }
            set {  numregcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVERBA
        /// Coment�rio: Indica o n�mero da verba.
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
        /// Propriedade referente ao campo: OBS1
        /// Coment�rio: 
        /// </summary>
        private string obs1;
        [XmlElement(ElementName = "OBS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs1
        {
            get { return  obs1; }
            set {  obs1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Coment�rio: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS3
        /// Coment�rio: 
        /// </summary>
        private string obs3;
        [XmlElement(ElementName = "OBS3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs3
        {
            get { return  obs3; }
            set {  obs3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS4
        /// Coment�rio: 
        /// </summary>
        private string obs4;
        [XmlElement(ElementName = "OBS4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs4
        {
            get { return  obs4; }
            set {  obs4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS5
        /// Coment�rio: 
        /// </summary>
        private string obs5;
        [XmlElement(ElementName = "OBS5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Obs5
        {
            get { return  obs5; }
            set {  obs5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESULTADOCOB
        /// Coment�rio: 
        /// </summary>
        private string resultadocob;
        [XmlElement(ElementName = "RESULTADOCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Resultadocob
        {
            get { return  resultadocob; }
            set {  resultadocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELCOB
        /// Coment�rio: 
        /// </summary>
        private string telcob;
        [XmlElement(ElementName = "TELCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Telcob
        {
            get { return  telcob; }
            set {  telcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOACOMPANHAMENTO
        /// Coment�rio: Indica o tipo de acompanhamento.
        /// </summary>
        private string tipoacompanhamento;
        [XmlElement(ElementName = "TIPOACOMPANHAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoacompanhamento
        {
            get { return  tipoacompanhamento; }
            set {  tipoacompanhamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONTATO
        /// Coment�rio: 
        /// </summary>
        private string tipocontato;
        [XmlElement(ElementName = "TIPOCONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocontato
        {
            get { return  tipocontato; }
            set {  tipocontato = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCHistcob()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCHISTCOB";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCHistcob> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCHistcob>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCHistcob> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCHistcob>(where);
        }

        #endregion
    }
}
