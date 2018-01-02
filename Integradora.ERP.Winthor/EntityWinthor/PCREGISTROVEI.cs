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
    /// Classe referente a tabela PCRegistrovei
    /// </summary>
    [XmlType("PCREGISTROVEI")]
    public class PCRegistrovei : OracleTable
    {
        #region Atributos

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
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Coment�rio: 
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRANSP
        /// Coment�rio: 
        /// </summary>
        private decimal codtransp;
        [XmlElement(ElementName = "CODTRANSP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codtransp
        {
            get { return  codtransp; }
            set {  codtransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CPF
        /// Coment�rio: 
        /// </summary>
        private string cpf;
        [XmlElement(ElementName = "CPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cpf
        {
            get { return  cpf; }
            set {  cpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAENT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataent;
        [XmlElement(ElementName = "DATAENT", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dataent
        {
            get { return  dataent; }
            set {  dataent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATASAIDA
        /// Coment�rio: 
        /// </summary>
        private DateTime? datasaida;
        [XmlElement(ElementName = "DATASAIDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datasaida
        {
            get { return  datasaida; }
            set {  datasaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAENT
        /// Coment�rio: 
        /// </summary>
        private decimal horaent;
        [XmlElement(ElementName = "HORAENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horaent
        {
            get { return  horaent; }
            set {  horaent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAENTDES
        /// Coment�rio: 
        /// </summary>
        private decimal horaentdes;
        [XmlElement(ElementName = "HORAENTDES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horaentdes
        {
            get { return  horaentdes; }
            set {  horaentdes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFIMDES
        /// Coment�rio: 
        /// </summary>
        private decimal horafimdes;
        [XmlElement(ElementName = "HORAFIMDES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horafimdes
        {
            get { return  horafimdes; }
            set {  horafimdes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINIDES
        /// Coment�rio: 
        /// </summary>
        private decimal horainides;
        [XmlElement(ElementName = "HORAINIDES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horainides
        {
            get { return  horainides; }
            set {  horainides = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORASAIDA
        /// Coment�rio: 
        /// </summary>
        private decimal horasaida;
        [XmlElement(ElementName = "HORASAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horasaida
        {
            get { return  horasaida; }
            set {  horasaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINENT
        /// Coment�rio: 
        /// </summary>
        private decimal minent;
        [XmlElement(ElementName = "MINENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minent
        {
            get { return  minent; }
            set {  minent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINENTDES
        /// Coment�rio: 
        /// </summary>
        private decimal minentdes;
        [XmlElement(ElementName = "MINENTDES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minentdes
        {
            get { return  minentdes; }
            set {  minentdes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINFIMDES
        /// Coment�rio: 
        /// </summary>
        private decimal minfimdes;
        [XmlElement(ElementName = "MINFIMDES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minfimdes
        {
            get { return  minfimdes; }
            set {  minfimdes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MININIDES
        /// Coment�rio: 
        /// </summary>
        private decimal mininides;
        [XmlElement(ElementName = "MININIDES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Mininides
        {
            get { return  mininides; }
            set {  mininides = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINSAIDA
        /// Coment�rio: 
        /// </summary>
        private decimal minsaida;
        [XmlElement(ElementName = "MINSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minsaida
        {
            get { return  minsaida; }
            set {  minsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTORISTA
        /// Coment�rio: 
        /// </summary>
        private string motorista;
        [XmlElement(ElementName = "MOTORISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Motorista
        {
            get { return  motorista; }
            set {  motorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Coment�rio: 
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGISTRO
        /// Coment�rio: 
        /// </summary>
        private decimal numregistro;
        [XmlElement(ElementName = "NUMREGISTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numregistro
        {
            get { return  numregistro; }
            set {  numregistro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLACA
        /// Coment�rio: 
        /// </summary>
        private string placa;
        [XmlElement(ElementName = "PLACA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Placa
        {
            get { return  placa; }
            set {  placa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RG
        /// Coment�rio: 
        /// </summary>
        private string rg;
        [XmlElement(ElementName = "RG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Rg
        {
            get { return  rg; }
            set {  rg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSPORTADORA
        /// Coment�rio: 
        /// </summary>
        private string transportadora;
        [XmlElement(ElementName = "TRANSPORTADORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Transportadora
        {
            get { return  transportadora; }
            set {  transportadora = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRegistrovei()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCREGISTROVEI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRegistrovei> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRegistrovei>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRegistrovei> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRegistrovei>(where);
        }

        #endregion
    }
}
