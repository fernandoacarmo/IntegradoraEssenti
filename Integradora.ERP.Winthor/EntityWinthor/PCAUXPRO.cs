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
    /// Classe referente a tabela PCAuxpro
    /// </summary>
    [XmlType("PCAUXPRO")]
    public class PCAuxpro : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: 
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
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
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTMES01
        /// Comentário: 
        /// </summary>
        private decimal custocontmes01;
        [XmlElement(ElementName = "CUSTOCONTMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontmes01
        {
            get { return  custocontmes01; }
            set {  custocontmes01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTMES02
        /// Comentário: 
        /// </summary>
        private decimal custocontmes02;
        [XmlElement(ElementName = "CUSTOCONTMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontmes02
        {
            get { return  custocontmes02; }
            set {  custocontmes02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTMES03
        /// Comentário: 
        /// </summary>
        private decimal custocontmes03;
        [XmlElement(ElementName = "CUSTOCONTMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontmes03
        {
            get { return  custocontmes03; }
            set {  custocontmes03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTMES04
        /// Comentário: 
        /// </summary>
        private decimal custocontmes04;
        [XmlElement(ElementName = "CUSTOCONTMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontmes04
        {
            get { return  custocontmes04; }
            set {  custocontmes04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTMES05
        /// Comentário: 
        /// </summary>
        private decimal custocontmes05;
        [XmlElement(ElementName = "CUSTOCONTMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontmes05
        {
            get { return  custocontmes05; }
            set {  custocontmes05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTMES06
        /// Comentário: 
        /// </summary>
        private decimal custocontmes06;
        [XmlElement(ElementName = "CUSTOCONTMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontmes06
        {
            get { return  custocontmes06; }
            set {  custocontmes06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTMES07
        /// Comentário: 
        /// </summary>
        private decimal custocontmes07;
        [XmlElement(ElementName = "CUSTOCONTMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontmes07
        {
            get { return  custocontmes07; }
            set {  custocontmes07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTMES08
        /// Comentário: 
        /// </summary>
        private decimal custocontmes08;
        [XmlElement(ElementName = "CUSTOCONTMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontmes08
        {
            get { return  custocontmes08; }
            set {  custocontmes08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTMES09
        /// Comentário: 
        /// </summary>
        private decimal custocontmes09;
        [XmlElement(ElementName = "CUSTOCONTMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontmes09
        {
            get { return  custocontmes09; }
            set {  custocontmes09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTMES10
        /// Comentário: 
        /// </summary>
        private decimal custocontmes10;
        [XmlElement(ElementName = "CUSTOCONTMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontmes10
        {
            get { return  custocontmes10; }
            set {  custocontmes10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTMES11
        /// Comentário: 
        /// </summary>
        private decimal custocontmes11;
        [XmlElement(ElementName = "CUSTOCONTMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontmes11
        {
            get { return  custocontmes11; }
            set {  custocontmes11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTMES12
        /// Comentário: 
        /// </summary>
        private decimal custocontmes12;
        [XmlElement(ElementName = "CUSTOCONTMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontmes12
        {
            get { return  custocontmes12; }
            set {  custocontmes12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINMES01
        /// Comentário: 
        /// </summary>
        private decimal custofinmes01;
        [XmlElement(ElementName = "CUSTOFINMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinmes01
        {
            get { return  custofinmes01; }
            set {  custofinmes01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINMES02
        /// Comentário: 
        /// </summary>
        private decimal custofinmes02;
        [XmlElement(ElementName = "CUSTOFINMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinmes02
        {
            get { return  custofinmes02; }
            set {  custofinmes02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINMES03
        /// Comentário: 
        /// </summary>
        private decimal custofinmes03;
        [XmlElement(ElementName = "CUSTOFINMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinmes03
        {
            get { return  custofinmes03; }
            set {  custofinmes03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINMES04
        /// Comentário: 
        /// </summary>
        private decimal custofinmes04;
        [XmlElement(ElementName = "CUSTOFINMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinmes04
        {
            get { return  custofinmes04; }
            set {  custofinmes04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINMES05
        /// Comentário: 
        /// </summary>
        private decimal custofinmes05;
        [XmlElement(ElementName = "CUSTOFINMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinmes05
        {
            get { return  custofinmes05; }
            set {  custofinmes05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINMES06
        /// Comentário: 
        /// </summary>
        private decimal custofinmes06;
        [XmlElement(ElementName = "CUSTOFINMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinmes06
        {
            get { return  custofinmes06; }
            set {  custofinmes06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINMES07
        /// Comentário: 
        /// </summary>
        private decimal custofinmes07;
        [XmlElement(ElementName = "CUSTOFINMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinmes07
        {
            get { return  custofinmes07; }
            set {  custofinmes07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINMES08
        /// Comentário: 
        /// </summary>
        private decimal custofinmes08;
        [XmlElement(ElementName = "CUSTOFINMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinmes08
        {
            get { return  custofinmes08; }
            set {  custofinmes08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINMES09
        /// Comentário: 
        /// </summary>
        private decimal custofinmes09;
        [XmlElement(ElementName = "CUSTOFINMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinmes09
        {
            get { return  custofinmes09; }
            set {  custofinmes09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINMES10
        /// Comentário: 
        /// </summary>
        private decimal custofinmes10;
        [XmlElement(ElementName = "CUSTOFINMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinmes10
        {
            get { return  custofinmes10; }
            set {  custofinmes10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINMES11
        /// Comentário: 
        /// </summary>
        private decimal custofinmes11;
        [XmlElement(ElementName = "CUSTOFINMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinmes11
        {
            get { return  custofinmes11; }
            set {  custofinmes11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINMES12
        /// Comentário: 
        /// </summary>
        private decimal custofinmes12;
        [XmlElement(ElementName = "CUSTOFINMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinmes12
        {
            get { return  custofinmes12; }
            set {  custofinmes12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALMES01
        /// Comentário: 
        /// </summary>
        private decimal custorealmes01;
        [XmlElement(ElementName = "CUSTOREALMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealmes01
        {
            get { return  custorealmes01; }
            set {  custorealmes01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALMES02
        /// Comentário: 
        /// </summary>
        private decimal custorealmes02;
        [XmlElement(ElementName = "CUSTOREALMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealmes02
        {
            get { return  custorealmes02; }
            set {  custorealmes02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALMES03
        /// Comentário: 
        /// </summary>
        private decimal custorealmes03;
        [XmlElement(ElementName = "CUSTOREALMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealmes03
        {
            get { return  custorealmes03; }
            set {  custorealmes03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALMES04
        /// Comentário: 
        /// </summary>
        private decimal custorealmes04;
        [XmlElement(ElementName = "CUSTOREALMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealmes04
        {
            get { return  custorealmes04; }
            set {  custorealmes04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALMES05
        /// Comentário: 
        /// </summary>
        private decimal custorealmes05;
        [XmlElement(ElementName = "CUSTOREALMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealmes05
        {
            get { return  custorealmes05; }
            set {  custorealmes05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALMES06
        /// Comentário: 
        /// </summary>
        private decimal custorealmes06;
        [XmlElement(ElementName = "CUSTOREALMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealmes06
        {
            get { return  custorealmes06; }
            set {  custorealmes06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALMES07
        /// Comentário: 
        /// </summary>
        private decimal custorealmes07;
        [XmlElement(ElementName = "CUSTOREALMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealmes07
        {
            get { return  custorealmes07; }
            set {  custorealmes07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALMES08
        /// Comentário: 
        /// </summary>
        private decimal custorealmes08;
        [XmlElement(ElementName = "CUSTOREALMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealmes08
        {
            get { return  custorealmes08; }
            set {  custorealmes08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALMES09
        /// Comentário: 
        /// </summary>
        private decimal custorealmes09;
        [XmlElement(ElementName = "CUSTOREALMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealmes09
        {
            get { return  custorealmes09; }
            set {  custorealmes09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALMES10
        /// Comentário: 
        /// </summary>
        private decimal custorealmes10;
        [XmlElement(ElementName = "CUSTOREALMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealmes10
        {
            get { return  custorealmes10; }
            set {  custorealmes10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALMES11
        /// Comentário: 
        /// </summary>
        private decimal custorealmes11;
        [XmlElement(ElementName = "CUSTOREALMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealmes11
        {
            get { return  custorealmes11; }
            set {  custorealmes11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALMES12
        /// Comentário: 
        /// </summary>
        private decimal custorealmes12;
        [XmlElement(ElementName = "CUSTOREALMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealmes12
        {
            get { return  custorealmes12; }
            set {  custorealmes12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMES01
        /// Comentário: 
        /// </summary>
        private decimal pvendames01;
        [XmlElement(ElementName = "PVENDAMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pvendames01
        {
            get { return  pvendames01; }
            set {  pvendames01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMES02
        /// Comentário: 
        /// </summary>
        private decimal pvendames02;
        [XmlElement(ElementName = "PVENDAMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pvendames02
        {
            get { return  pvendames02; }
            set {  pvendames02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMES03
        /// Comentário: 
        /// </summary>
        private decimal pvendames03;
        [XmlElement(ElementName = "PVENDAMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pvendames03
        {
            get { return  pvendames03; }
            set {  pvendames03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMES04
        /// Comentário: 
        /// </summary>
        private decimal pvendames04;
        [XmlElement(ElementName = "PVENDAMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pvendames04
        {
            get { return  pvendames04; }
            set {  pvendames04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMES05
        /// Comentário: 
        /// </summary>
        private decimal pvendames05;
        [XmlElement(ElementName = "PVENDAMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pvendames05
        {
            get { return  pvendames05; }
            set {  pvendames05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMES06
        /// Comentário: 
        /// </summary>
        private decimal pvendames06;
        [XmlElement(ElementName = "PVENDAMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pvendames06
        {
            get { return  pvendames06; }
            set {  pvendames06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMES07
        /// Comentário: 
        /// </summary>
        private decimal pvendames07;
        [XmlElement(ElementName = "PVENDAMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pvendames07
        {
            get { return  pvendames07; }
            set {  pvendames07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMES08
        /// Comentário: 
        /// </summary>
        private decimal pvendames08;
        [XmlElement(ElementName = "PVENDAMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pvendames08
        {
            get { return  pvendames08; }
            set {  pvendames08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMES09
        /// Comentário: 
        /// </summary>
        private decimal pvendames09;
        [XmlElement(ElementName = "PVENDAMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pvendames09
        {
            get { return  pvendames09; }
            set {  pvendames09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMES10
        /// Comentário: 
        /// </summary>
        private decimal pvendames10;
        [XmlElement(ElementName = "PVENDAMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pvendames10
        {
            get { return  pvendames10; }
            set {  pvendames10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMES11
        /// Comentário: 
        /// </summary>
        private decimal pvendames11;
        [XmlElement(ElementName = "PVENDAMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pvendames11
        {
            get { return  pvendames11; }
            set {  pvendames11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMES12
        /// Comentário: 
        /// </summary>
        private decimal pvendames12;
        [XmlElement(ElementName = "PVENDAMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pvendames12
        {
            get { return  pvendames12; }
            set {  pvendames12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRAMES01
        /// Comentário: 
        /// </summary>
        private decimal qtcomprames01;
        [XmlElement(ElementName = "QTCOMPRAMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcomprames01
        {
            get { return  qtcomprames01; }
            set {  qtcomprames01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRAMES02
        /// Comentário: 
        /// </summary>
        private decimal qtcomprames02;
        [XmlElement(ElementName = "QTCOMPRAMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcomprames02
        {
            get { return  qtcomprames02; }
            set {  qtcomprames02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRAMES03
        /// Comentário: 
        /// </summary>
        private decimal qtcomprames03;
        [XmlElement(ElementName = "QTCOMPRAMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcomprames03
        {
            get { return  qtcomprames03; }
            set {  qtcomprames03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRAMES04
        /// Comentário: 
        /// </summary>
        private decimal qtcomprames04;
        [XmlElement(ElementName = "QTCOMPRAMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcomprames04
        {
            get { return  qtcomprames04; }
            set {  qtcomprames04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRAMES05
        /// Comentário: 
        /// </summary>
        private decimal qtcomprames05;
        [XmlElement(ElementName = "QTCOMPRAMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcomprames05
        {
            get { return  qtcomprames05; }
            set {  qtcomprames05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRAMES06
        /// Comentário: 
        /// </summary>
        private decimal qtcomprames06;
        [XmlElement(ElementName = "QTCOMPRAMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcomprames06
        {
            get { return  qtcomprames06; }
            set {  qtcomprames06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRAMES07
        /// Comentário: 
        /// </summary>
        private decimal qtcomprames07;
        [XmlElement(ElementName = "QTCOMPRAMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcomprames07
        {
            get { return  qtcomprames07; }
            set {  qtcomprames07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRAMES08
        /// Comentário: 
        /// </summary>
        private decimal qtcomprames08;
        [XmlElement(ElementName = "QTCOMPRAMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcomprames08
        {
            get { return  qtcomprames08; }
            set {  qtcomprames08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRAMES09
        /// Comentário: 
        /// </summary>
        private decimal qtcomprames09;
        [XmlElement(ElementName = "QTCOMPRAMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcomprames09
        {
            get { return  qtcomprames09; }
            set {  qtcomprames09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRAMES10
        /// Comentário: 
        /// </summary>
        private decimal qtcomprames10;
        [XmlElement(ElementName = "QTCOMPRAMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcomprames10
        {
            get { return  qtcomprames10; }
            set {  qtcomprames10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRAMES11
        /// Comentário: 
        /// </summary>
        private decimal qtcomprames11;
        [XmlElement(ElementName = "QTCOMPRAMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcomprames11
        {
            get { return  qtcomprames11; }
            set {  qtcomprames11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRAMES12
        /// Comentário: 
        /// </summary>
        private decimal qtcomprames12;
        [XmlElement(ElementName = "QTCOMPRAMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcomprames12
        {
            get { return  qtcomprames12; }
            set {  qtcomprames12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESDSAIDA01
        /// Comentário: 
        /// </summary>
        private decimal qtdesdsaida01;
        [XmlElement(ElementName = "QTDESDSAIDA01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesdsaida01
        {
            get { return  qtdesdsaida01; }
            set {  qtdesdsaida01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESDSAIDA02
        /// Comentário: 
        /// </summary>
        private decimal qtdesdsaida02;
        [XmlElement(ElementName = "QTDESDSAIDA02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesdsaida02
        {
            get { return  qtdesdsaida02; }
            set {  qtdesdsaida02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESDSAIDA03
        /// Comentário: 
        /// </summary>
        private decimal qtdesdsaida03;
        [XmlElement(ElementName = "QTDESDSAIDA03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesdsaida03
        {
            get { return  qtdesdsaida03; }
            set {  qtdesdsaida03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESDSAIDA04
        /// Comentário: 
        /// </summary>
        private decimal qtdesdsaida04;
        [XmlElement(ElementName = "QTDESDSAIDA04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesdsaida04
        {
            get { return  qtdesdsaida04; }
            set {  qtdesdsaida04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESDSAIDA05
        /// Comentário: 
        /// </summary>
        private decimal qtdesdsaida05;
        [XmlElement(ElementName = "QTDESDSAIDA05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesdsaida05
        {
            get { return  qtdesdsaida05; }
            set {  qtdesdsaida05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESDSAIDA06
        /// Comentário: 
        /// </summary>
        private decimal qtdesdsaida06;
        [XmlElement(ElementName = "QTDESDSAIDA06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesdsaida06
        {
            get { return  qtdesdsaida06; }
            set {  qtdesdsaida06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESDSAIDA07
        /// Comentário: 
        /// </summary>
        private decimal qtdesdsaida07;
        [XmlElement(ElementName = "QTDESDSAIDA07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesdsaida07
        {
            get { return  qtdesdsaida07; }
            set {  qtdesdsaida07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESDSAIDA08
        /// Comentário: 
        /// </summary>
        private decimal qtdesdsaida08;
        [XmlElement(ElementName = "QTDESDSAIDA08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesdsaida08
        {
            get { return  qtdesdsaida08; }
            set {  qtdesdsaida08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESDSAIDA09
        /// Comentário: 
        /// </summary>
        private decimal qtdesdsaida09;
        [XmlElement(ElementName = "QTDESDSAIDA09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesdsaida09
        {
            get { return  qtdesdsaida09; }
            set {  qtdesdsaida09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESDSAIDA10
        /// Comentário: 
        /// </summary>
        private decimal qtdesdsaida10;
        [XmlElement(ElementName = "QTDESDSAIDA10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesdsaida10
        {
            get { return  qtdesdsaida10; }
            set {  qtdesdsaida10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESDSAIDA11
        /// Comentário: 
        /// </summary>
        private decimal qtdesdsaida11;
        [XmlElement(ElementName = "QTDESDSAIDA11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesdsaida11
        {
            get { return  qtdesdsaida11; }
            set {  qtdesdsaida11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESDSAIDA12
        /// Comentário: 
        /// </summary>
        private decimal qtdesdsaida12;
        [XmlElement(ElementName = "QTDESDSAIDA12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesdsaida12
        {
            get { return  qtdesdsaida12; }
            set {  qtdesdsaida12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESD01
        /// Comentário: 
        /// </summary>
        private decimal qtdesd01;
        [XmlElement(ElementName = "QTDESD01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesd01
        {
            get { return  qtdesd01; }
            set {  qtdesd01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESD02
        /// Comentário: 
        /// </summary>
        private decimal qtdesd02;
        [XmlElement(ElementName = "QTDESD02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesd02
        {
            get { return  qtdesd02; }
            set {  qtdesd02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESD03
        /// Comentário: 
        /// </summary>
        private decimal qtdesd03;
        [XmlElement(ElementName = "QTDESD03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesd03
        {
            get { return  qtdesd03; }
            set {  qtdesd03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESD04
        /// Comentário: 
        /// </summary>
        private decimal qtdesd04;
        [XmlElement(ElementName = "QTDESD04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesd04
        {
            get { return  qtdesd04; }
            set {  qtdesd04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESD05
        /// Comentário: 
        /// </summary>
        private decimal qtdesd05;
        [XmlElement(ElementName = "QTDESD05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesd05
        {
            get { return  qtdesd05; }
            set {  qtdesd05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESD06
        /// Comentário: 
        /// </summary>
        private decimal qtdesd06;
        [XmlElement(ElementName = "QTDESD06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesd06
        {
            get { return  qtdesd06; }
            set {  qtdesd06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESD07
        /// Comentário: 
        /// </summary>
        private decimal qtdesd07;
        [XmlElement(ElementName = "QTDESD07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesd07
        {
            get { return  qtdesd07; }
            set {  qtdesd07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESD08
        /// Comentário: 
        /// </summary>
        private decimal qtdesd08;
        [XmlElement(ElementName = "QTDESD08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesd08
        {
            get { return  qtdesd08; }
            set {  qtdesd08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESD09
        /// Comentário: 
        /// </summary>
        private decimal qtdesd09;
        [XmlElement(ElementName = "QTDESD09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesd09
        {
            get { return  qtdesd09; }
            set {  qtdesd09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESD10
        /// Comentário: 
        /// </summary>
        private decimal qtdesd10;
        [XmlElement(ElementName = "QTDESD10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesd10
        {
            get { return  qtdesd10; }
            set {  qtdesd10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESD11
        /// Comentário: 
        /// </summary>
        private decimal qtdesd11;
        [XmlElement(ElementName = "QTDESD11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesd11
        {
            get { return  qtdesd11; }
            set {  qtdesd11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESD12
        /// Comentário: 
        /// </summary>
        private decimal qtdesd12;
        [XmlElement(ElementName = "QTDESD12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdesd12
        {
            get { return  qtdesd12; }
            set {  qtdesd12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLI01
        /// Comentário: Quantidade devolvida pelo cliente no mês 01
        /// </summary>
        private decimal qtdevcli01;
        [XmlElement(ElementName = "QTDEVCLI01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevcli01
        {
            get { return  qtdevcli01; }
            set {  qtdevcli01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLI02
        /// Comentário: Quantidade devolvida pelo cliente no mês 02
        /// </summary>
        private decimal qtdevcli02;
        [XmlElement(ElementName = "QTDEVCLI02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevcli02
        {
            get { return  qtdevcli02; }
            set {  qtdevcli02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLI03
        /// Comentário: Quantidade devolvida pelo cliente no mês 03
        /// </summary>
        private decimal qtdevcli03;
        [XmlElement(ElementName = "QTDEVCLI03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevcli03
        {
            get { return  qtdevcli03; }
            set {  qtdevcli03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLI04
        /// Comentário: Quantidade devolvida pelo cliente no mês 04
        /// </summary>
        private decimal qtdevcli04;
        [XmlElement(ElementName = "QTDEVCLI04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevcli04
        {
            get { return  qtdevcli04; }
            set {  qtdevcli04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLI05
        /// Comentário: Quantidade devolvida pelo cliente no mês 05
        /// </summary>
        private decimal qtdevcli05;
        [XmlElement(ElementName = "QTDEVCLI05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevcli05
        {
            get { return  qtdevcli05; }
            set {  qtdevcli05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLI06
        /// Comentário: Quantidade devolvida pelo cliente no mês 06
        /// </summary>
        private decimal qtdevcli06;
        [XmlElement(ElementName = "QTDEVCLI06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevcli06
        {
            get { return  qtdevcli06; }
            set {  qtdevcli06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLI07
        /// Comentário: Quantidade devolvida pelo cliente no mês 07
        /// </summary>
        private decimal qtdevcli07;
        [XmlElement(ElementName = "QTDEVCLI07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevcli07
        {
            get { return  qtdevcli07; }
            set {  qtdevcli07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLI08
        /// Comentário: Quantidade devolvida pelo cliente no mês 08
        /// </summary>
        private decimal qtdevcli08;
        [XmlElement(ElementName = "QTDEVCLI08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevcli08
        {
            get { return  qtdevcli08; }
            set {  qtdevcli08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLI09
        /// Comentário: Quantidade devolvida pelo cliente no mês 09
        /// </summary>
        private decimal qtdevcli09;
        [XmlElement(ElementName = "QTDEVCLI09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevcli09
        {
            get { return  qtdevcli09; }
            set {  qtdevcli09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLI10
        /// Comentário: Quantidade devolvida pelo cliente no mês 10
        /// </summary>
        private decimal qtdevcli10;
        [XmlElement(ElementName = "QTDEVCLI10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevcli10
        {
            get { return  qtdevcli10; }
            set {  qtdevcli10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLI11
        /// Comentário: Quantidade devolvida pelo cliente no mês 11
        /// </summary>
        private decimal qtdevcli11;
        [XmlElement(ElementName = "QTDEVCLI11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevcli11
        {
            get { return  qtdevcli11; }
            set {  qtdevcli11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLI12
        /// Comentário: Quantidade devolvida pelo cliente no mês 12
        /// </summary>
        private decimal qtdevcli12;
        [XmlElement(ElementName = "QTDEVCLI12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevcli12
        {
            get { return  qtdevcli12; }
            set {  qtdevcli12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFOR01
        /// Comentário: 
        /// </summary>
        private decimal qtdevfor01;
        [XmlElement(ElementName = "QTDEVFOR01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevfor01
        {
            get { return  qtdevfor01; }
            set {  qtdevfor01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFOR02
        /// Comentário: 
        /// </summary>
        private decimal qtdevfor02;
        [XmlElement(ElementName = "QTDEVFOR02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevfor02
        {
            get { return  qtdevfor02; }
            set {  qtdevfor02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFOR03
        /// Comentário: 
        /// </summary>
        private decimal qtdevfor03;
        [XmlElement(ElementName = "QTDEVFOR03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevfor03
        {
            get { return  qtdevfor03; }
            set {  qtdevfor03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFOR04
        /// Comentário: 
        /// </summary>
        private decimal qtdevfor04;
        [XmlElement(ElementName = "QTDEVFOR04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevfor04
        {
            get { return  qtdevfor04; }
            set {  qtdevfor04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFOR05
        /// Comentário: 
        /// </summary>
        private decimal qtdevfor05;
        [XmlElement(ElementName = "QTDEVFOR05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevfor05
        {
            get { return  qtdevfor05; }
            set {  qtdevfor05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFOR06
        /// Comentário: 
        /// </summary>
        private decimal qtdevfor06;
        [XmlElement(ElementName = "QTDEVFOR06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevfor06
        {
            get { return  qtdevfor06; }
            set {  qtdevfor06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFOR07
        /// Comentário: 
        /// </summary>
        private decimal qtdevfor07;
        [XmlElement(ElementName = "QTDEVFOR07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevfor07
        {
            get { return  qtdevfor07; }
            set {  qtdevfor07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFOR08
        /// Comentário: 
        /// </summary>
        private decimal qtdevfor08;
        [XmlElement(ElementName = "QTDEVFOR08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevfor08
        {
            get { return  qtdevfor08; }
            set {  qtdevfor08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFOR09
        /// Comentário: 
        /// </summary>
        private decimal qtdevfor09;
        [XmlElement(ElementName = "QTDEVFOR09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevfor09
        {
            get { return  qtdevfor09; }
            set {  qtdevfor09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFOR10
        /// Comentário: 
        /// </summary>
        private decimal qtdevfor10;
        [XmlElement(ElementName = "QTDEVFOR10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevfor10
        {
            get { return  qtdevfor10; }
            set {  qtdevfor10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFOR11
        /// Comentário: 
        /// </summary>
        private decimal qtdevfor11;
        [XmlElement(ElementName = "QTDEVFOR11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevfor11
        {
            get { return  qtdevfor11; }
            set {  qtdevfor11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFOR12
        /// Comentário: 
        /// </summary>
        private decimal qtdevfor12;
        [XmlElement(ElementName = "QTDEVFOR12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevfor12
        {
            get { return  qtdevfor12; }
            set {  qtdevfor12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVLJCD01
        /// Comentário: 
        /// </summary>
        private decimal qtdevljcd01;
        [XmlElement(ElementName = "QTDEVLJCD01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevljcd01
        {
            get { return  qtdevljcd01; }
            set {  qtdevljcd01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVLJCD02
        /// Comentário: 
        /// </summary>
        private decimal qtdevljcd02;
        [XmlElement(ElementName = "QTDEVLJCD02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevljcd02
        {
            get { return  qtdevljcd02; }
            set {  qtdevljcd02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVLJCD03
        /// Comentário: 
        /// </summary>
        private decimal qtdevljcd03;
        [XmlElement(ElementName = "QTDEVLJCD03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevljcd03
        {
            get { return  qtdevljcd03; }
            set {  qtdevljcd03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVLJCD04
        /// Comentário: 
        /// </summary>
        private decimal qtdevljcd04;
        [XmlElement(ElementName = "QTDEVLJCD04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevljcd04
        {
            get { return  qtdevljcd04; }
            set {  qtdevljcd04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVLJCD05
        /// Comentário: 
        /// </summary>
        private decimal qtdevljcd05;
        [XmlElement(ElementName = "QTDEVLJCD05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevljcd05
        {
            get { return  qtdevljcd05; }
            set {  qtdevljcd05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVLJCD06
        /// Comentário: 
        /// </summary>
        private decimal qtdevljcd06;
        [XmlElement(ElementName = "QTDEVLJCD06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevljcd06
        {
            get { return  qtdevljcd06; }
            set {  qtdevljcd06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVLJCD07
        /// Comentário: 
        /// </summary>
        private decimal qtdevljcd07;
        [XmlElement(ElementName = "QTDEVLJCD07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevljcd07
        {
            get { return  qtdevljcd07; }
            set {  qtdevljcd07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVLJCD08
        /// Comentário: 
        /// </summary>
        private decimal qtdevljcd08;
        [XmlElement(ElementName = "QTDEVLJCD08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevljcd08
        {
            get { return  qtdevljcd08; }
            set {  qtdevljcd08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVLJCD09
        /// Comentário: 
        /// </summary>
        private decimal qtdevljcd09;
        [XmlElement(ElementName = "QTDEVLJCD09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevljcd09
        {
            get { return  qtdevljcd09; }
            set {  qtdevljcd09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVLJCD10
        /// Comentário: 
        /// </summary>
        private decimal qtdevljcd10;
        [XmlElement(ElementName = "QTDEVLJCD10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevljcd10
        {
            get { return  qtdevljcd10; }
            set {  qtdevljcd10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVLJCD11
        /// Comentário: 
        /// </summary>
        private decimal qtdevljcd11;
        [XmlElement(ElementName = "QTDEVLJCD11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevljcd11
        {
            get { return  qtdevljcd11; }
            set {  qtdevljcd11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVLJCD12
        /// Comentário: 
        /// </summary>
        private decimal qtdevljcd12;
        [XmlElement(ElementName = "QTDEVLJCD12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevljcd12
        {
            get { return  qtdevljcd12; }
            set {  qtdevljcd12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTCD01
        /// Comentário: 
        /// </summary>
        private decimal qtentcd01;
        [XmlElement(ElementName = "QTENTCD01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentcd01
        {
            get { return  qtentcd01; }
            set {  qtentcd01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTCD02
        /// Comentário: 
        /// </summary>
        private decimal qtentcd02;
        [XmlElement(ElementName = "QTENTCD02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentcd02
        {
            get { return  qtentcd02; }
            set {  qtentcd02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTCD03
        /// Comentário: 
        /// </summary>
        private decimal qtentcd03;
        [XmlElement(ElementName = "QTENTCD03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentcd03
        {
            get { return  qtentcd03; }
            set {  qtentcd03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTCD04
        /// Comentário: 
        /// </summary>
        private decimal qtentcd04;
        [XmlElement(ElementName = "QTENTCD04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentcd04
        {
            get { return  qtentcd04; }
            set {  qtentcd04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTCD05
        /// Comentário: 
        /// </summary>
        private decimal qtentcd05;
        [XmlElement(ElementName = "QTENTCD05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentcd05
        {
            get { return  qtentcd05; }
            set {  qtentcd05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTCD06
        /// Comentário: 
        /// </summary>
        private decimal qtentcd06;
        [XmlElement(ElementName = "QTENTCD06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentcd06
        {
            get { return  qtentcd06; }
            set {  qtentcd06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTCD07
        /// Comentário: 
        /// </summary>
        private decimal qtentcd07;
        [XmlElement(ElementName = "QTENTCD07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentcd07
        {
            get { return  qtentcd07; }
            set {  qtentcd07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTCD08
        /// Comentário: 
        /// </summary>
        private decimal qtentcd08;
        [XmlElement(ElementName = "QTENTCD08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentcd08
        {
            get { return  qtentcd08; }
            set {  qtentcd08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTCD09
        /// Comentário: 
        /// </summary>
        private decimal qtentcd09;
        [XmlElement(ElementName = "QTENTCD09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentcd09
        {
            get { return  qtentcd09; }
            set {  qtentcd09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTCD10
        /// Comentário: 
        /// </summary>
        private decimal qtentcd10;
        [XmlElement(ElementName = "QTENTCD10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentcd10
        {
            get { return  qtentcd10; }
            set {  qtentcd10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTCD11
        /// Comentário: 
        /// </summary>
        private decimal qtentcd11;
        [XmlElement(ElementName = "QTENTCD11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentcd11
        {
            get { return  qtentcd11; }
            set {  qtentcd11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTCD12
        /// Comentário: 
        /// </summary>
        private decimal qtentcd12;
        [XmlElement(ElementName = "QTENTCD12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentcd12
        {
            get { return  qtentcd12; }
            set {  qtentcd12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTLJ01
        /// Comentário: 
        /// </summary>
        private decimal qtentlj01;
        [XmlElement(ElementName = "QTENTLJ01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentlj01
        {
            get { return  qtentlj01; }
            set {  qtentlj01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTLJ02
        /// Comentário: 
        /// </summary>
        private decimal qtentlj02;
        [XmlElement(ElementName = "QTENTLJ02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentlj02
        {
            get { return  qtentlj02; }
            set {  qtentlj02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTLJ03
        /// Comentário: 
        /// </summary>
        private decimal qtentlj03;
        [XmlElement(ElementName = "QTENTLJ03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentlj03
        {
            get { return  qtentlj03; }
            set {  qtentlj03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTLJ04
        /// Comentário: 
        /// </summary>
        private decimal qtentlj04;
        [XmlElement(ElementName = "QTENTLJ04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentlj04
        {
            get { return  qtentlj04; }
            set {  qtentlj04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTLJ05
        /// Comentário: 
        /// </summary>
        private decimal qtentlj05;
        [XmlElement(ElementName = "QTENTLJ05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentlj05
        {
            get { return  qtentlj05; }
            set {  qtentlj05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTLJ06
        /// Comentário: 
        /// </summary>
        private decimal qtentlj06;
        [XmlElement(ElementName = "QTENTLJ06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentlj06
        {
            get { return  qtentlj06; }
            set {  qtentlj06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTLJ07
        /// Comentário: 
        /// </summary>
        private decimal qtentlj07;
        [XmlElement(ElementName = "QTENTLJ07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentlj07
        {
            get { return  qtentlj07; }
            set {  qtentlj07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTLJ08
        /// Comentário: 
        /// </summary>
        private decimal qtentlj08;
        [XmlElement(ElementName = "QTENTLJ08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentlj08
        {
            get { return  qtentlj08; }
            set {  qtentlj08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTLJ09
        /// Comentário: 
        /// </summary>
        private decimal qtentlj09;
        [XmlElement(ElementName = "QTENTLJ09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentlj09
        {
            get { return  qtentlj09; }
            set {  qtentlj09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTLJ10
        /// Comentário: 
        /// </summary>
        private decimal qtentlj10;
        [XmlElement(ElementName = "QTENTLJ10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentlj10
        {
            get { return  qtentlj10; }
            set {  qtentlj10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTLJ11
        /// Comentário: 
        /// </summary>
        private decimal qtentlj11;
        [XmlElement(ElementName = "QTENTLJ11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentlj11
        {
            get { return  qtentlj11; }
            set {  qtentlj11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTLJ12
        /// Comentário: 
        /// </summary>
        private decimal qtentlj12;
        [XmlElement(ElementName = "QTENTLJ12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentlj12
        {
            get { return  qtentlj12; }
            set {  qtentlj12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERMES01
        /// Comentário: 
        /// </summary>
        private decimal qtestgermes01;
        [XmlElement(ElementName = "QTESTGERMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgermes01
        {
            get { return  qtestgermes01; }
            set {  qtestgermes01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERMES02
        /// Comentário: 
        /// </summary>
        private decimal qtestgermes02;
        [XmlElement(ElementName = "QTESTGERMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgermes02
        {
            get { return  qtestgermes02; }
            set {  qtestgermes02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERMES03
        /// Comentário: 
        /// </summary>
        private decimal qtestgermes03;
        [XmlElement(ElementName = "QTESTGERMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgermes03
        {
            get { return  qtestgermes03; }
            set {  qtestgermes03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERMES04
        /// Comentário: 
        /// </summary>
        private decimal qtestgermes04;
        [XmlElement(ElementName = "QTESTGERMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgermes04
        {
            get { return  qtestgermes04; }
            set {  qtestgermes04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERMES05
        /// Comentário: 
        /// </summary>
        private decimal qtestgermes05;
        [XmlElement(ElementName = "QTESTGERMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgermes05
        {
            get { return  qtestgermes05; }
            set {  qtestgermes05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERMES06
        /// Comentário: 
        /// </summary>
        private decimal qtestgermes06;
        [XmlElement(ElementName = "QTESTGERMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgermes06
        {
            get { return  qtestgermes06; }
            set {  qtestgermes06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERMES07
        /// Comentário: 
        /// </summary>
        private decimal qtestgermes07;
        [XmlElement(ElementName = "QTESTGERMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgermes07
        {
            get { return  qtestgermes07; }
            set {  qtestgermes07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERMES08
        /// Comentário: 
        /// </summary>
        private decimal qtestgermes08;
        [XmlElement(ElementName = "QTESTGERMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgermes08
        {
            get { return  qtestgermes08; }
            set {  qtestgermes08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERMES09
        /// Comentário: 
        /// </summary>
        private decimal qtestgermes09;
        [XmlElement(ElementName = "QTESTGERMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgermes09
        {
            get { return  qtestgermes09; }
            set {  qtestgermes09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERMES10
        /// Comentário: 
        /// </summary>
        private decimal qtestgermes10;
        [XmlElement(ElementName = "QTESTGERMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgermes10
        {
            get { return  qtestgermes10; }
            set {  qtestgermes10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERMES11
        /// Comentário: 
        /// </summary>
        private decimal qtestgermes11;
        [XmlElement(ElementName = "QTESTGERMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgermes11
        {
            get { return  qtestgermes11; }
            set {  qtestgermes11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERMES12
        /// Comentário: 
        /// </summary>
        private decimal qtestgermes12;
        [XmlElement(ElementName = "QTESTGERMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgermes12
        {
            get { return  qtestgermes12; }
            set {  qtestgermes12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES01
        /// Comentário: 
        /// </summary>
        private decimal qtperdames01;
        [XmlElement(ElementName = "QTPERDAMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames01
        {
            get { return  qtperdames01; }
            set {  qtperdames01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES02
        /// Comentário: 
        /// </summary>
        private decimal qtperdames02;
        [XmlElement(ElementName = "QTPERDAMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames02
        {
            get { return  qtperdames02; }
            set {  qtperdames02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES03
        /// Comentário: 
        /// </summary>
        private decimal qtperdames03;
        [XmlElement(ElementName = "QTPERDAMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames03
        {
            get { return  qtperdames03; }
            set {  qtperdames03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES04
        /// Comentário: 
        /// </summary>
        private decimal qtperdames04;
        [XmlElement(ElementName = "QTPERDAMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames04
        {
            get { return  qtperdames04; }
            set {  qtperdames04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES05
        /// Comentário: 
        /// </summary>
        private decimal qtperdames05;
        [XmlElement(ElementName = "QTPERDAMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames05
        {
            get { return  qtperdames05; }
            set {  qtperdames05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES06
        /// Comentário: 
        /// </summary>
        private decimal qtperdames06;
        [XmlElement(ElementName = "QTPERDAMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames06
        {
            get { return  qtperdames06; }
            set {  qtperdames06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES07
        /// Comentário: 
        /// </summary>
        private decimal qtperdames07;
        [XmlElement(ElementName = "QTPERDAMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames07
        {
            get { return  qtperdames07; }
            set {  qtperdames07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES08
        /// Comentário: 
        /// </summary>
        private decimal qtperdames08;
        [XmlElement(ElementName = "QTPERDAMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames08
        {
            get { return  qtperdames08; }
            set {  qtperdames08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES09
        /// Comentário: 
        /// </summary>
        private decimal qtperdames09;
        [XmlElement(ElementName = "QTPERDAMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames09
        {
            get { return  qtperdames09; }
            set {  qtperdames09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES10
        /// Comentário: 
        /// </summary>
        private decimal qtperdames10;
        [XmlElement(ElementName = "QTPERDAMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames10
        {
            get { return  qtperdames10; }
            set {  qtperdames10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES11
        /// Comentário: 
        /// </summary>
        private decimal qtperdames11;
        [XmlElement(ElementName = "QTPERDAMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames11
        {
            get { return  qtperdames11; }
            set {  qtperdames11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES12
        /// Comentário: 
        /// </summary>
        private decimal qtperdames12;
        [XmlElement(ElementName = "QTPERDAMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames12
        {
            get { return  qtperdames12; }
            set {  qtperdames12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRASAIDA01
        /// Comentário: 
        /// </summary>
        private decimal qtquebrasaida01;
        [XmlElement(ElementName = "QTQUEBRASAIDA01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebrasaida01
        {
            get { return  qtquebrasaida01; }
            set {  qtquebrasaida01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRASAIDA02
        /// Comentário: 
        /// </summary>
        private decimal qtquebrasaida02;
        [XmlElement(ElementName = "QTQUEBRASAIDA02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebrasaida02
        {
            get { return  qtquebrasaida02; }
            set {  qtquebrasaida02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRASAIDA03
        /// Comentário: 
        /// </summary>
        private decimal qtquebrasaida03;
        [XmlElement(ElementName = "QTQUEBRASAIDA03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebrasaida03
        {
            get { return  qtquebrasaida03; }
            set {  qtquebrasaida03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRASAIDA04
        /// Comentário: 
        /// </summary>
        private decimal qtquebrasaida04;
        [XmlElement(ElementName = "QTQUEBRASAIDA04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebrasaida04
        {
            get { return  qtquebrasaida04; }
            set {  qtquebrasaida04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRASAIDA05
        /// Comentário: 
        /// </summary>
        private decimal qtquebrasaida05;
        [XmlElement(ElementName = "QTQUEBRASAIDA05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebrasaida05
        {
            get { return  qtquebrasaida05; }
            set {  qtquebrasaida05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRASAIDA06
        /// Comentário: 
        /// </summary>
        private decimal qtquebrasaida06;
        [XmlElement(ElementName = "QTQUEBRASAIDA06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebrasaida06
        {
            get { return  qtquebrasaida06; }
            set {  qtquebrasaida06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRASAIDA07
        /// Comentário: 
        /// </summary>
        private decimal qtquebrasaida07;
        [XmlElement(ElementName = "QTQUEBRASAIDA07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebrasaida07
        {
            get { return  qtquebrasaida07; }
            set {  qtquebrasaida07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRASAIDA08
        /// Comentário: 
        /// </summary>
        private decimal qtquebrasaida08;
        [XmlElement(ElementName = "QTQUEBRASAIDA08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebrasaida08
        {
            get { return  qtquebrasaida08; }
            set {  qtquebrasaida08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRASAIDA09
        /// Comentário: 
        /// </summary>
        private decimal qtquebrasaida09;
        [XmlElement(ElementName = "QTQUEBRASAIDA09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebrasaida09
        {
            get { return  qtquebrasaida09; }
            set {  qtquebrasaida09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRASAIDA10
        /// Comentário: 
        /// </summary>
        private decimal qtquebrasaida10;
        [XmlElement(ElementName = "QTQUEBRASAIDA10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebrasaida10
        {
            get { return  qtquebrasaida10; }
            set {  qtquebrasaida10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRASAIDA11
        /// Comentário: 
        /// </summary>
        private decimal qtquebrasaida11;
        [XmlElement(ElementName = "QTQUEBRASAIDA11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebrasaida11
        {
            get { return  qtquebrasaida11; }
            set {  qtquebrasaida11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRASAIDA12
        /// Comentário: 
        /// </summary>
        private decimal qtquebrasaida12;
        [XmlElement(ElementName = "QTQUEBRASAIDA12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebrasaida12
        {
            get { return  qtquebrasaida12; }
            set {  qtquebrasaida12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRA01
        /// Comentário: 
        /// </summary>
        private decimal qtquebra01;
        [XmlElement(ElementName = "QTQUEBRA01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebra01
        {
            get { return  qtquebra01; }
            set {  qtquebra01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRA02
        /// Comentário: 
        /// </summary>
        private decimal qtquebra02;
        [XmlElement(ElementName = "QTQUEBRA02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebra02
        {
            get { return  qtquebra02; }
            set {  qtquebra02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRA03
        /// Comentário: 
        /// </summary>
        private decimal qtquebra03;
        [XmlElement(ElementName = "QTQUEBRA03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebra03
        {
            get { return  qtquebra03; }
            set {  qtquebra03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRA04
        /// Comentário: 
        /// </summary>
        private decimal qtquebra04;
        [XmlElement(ElementName = "QTQUEBRA04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebra04
        {
            get { return  qtquebra04; }
            set {  qtquebra04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRA05
        /// Comentário: 
        /// </summary>
        private decimal qtquebra05;
        [XmlElement(ElementName = "QTQUEBRA05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebra05
        {
            get { return  qtquebra05; }
            set {  qtquebra05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRA06
        /// Comentário: 
        /// </summary>
        private decimal qtquebra06;
        [XmlElement(ElementName = "QTQUEBRA06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebra06
        {
            get { return  qtquebra06; }
            set {  qtquebra06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRA07
        /// Comentário: 
        /// </summary>
        private decimal qtquebra07;
        [XmlElement(ElementName = "QTQUEBRA07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebra07
        {
            get { return  qtquebra07; }
            set {  qtquebra07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRA08
        /// Comentário: 
        /// </summary>
        private decimal qtquebra08;
        [XmlElement(ElementName = "QTQUEBRA08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebra08
        {
            get { return  qtquebra08; }
            set {  qtquebra08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRA09
        /// Comentário: 
        /// </summary>
        private decimal qtquebra09;
        [XmlElement(ElementName = "QTQUEBRA09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebra09
        {
            get { return  qtquebra09; }
            set {  qtquebra09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRA10
        /// Comentário: 
        /// </summary>
        private decimal qtquebra10;
        [XmlElement(ElementName = "QTQUEBRA10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebra10
        {
            get { return  qtquebra10; }
            set {  qtquebra10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRA11
        /// Comentário: 
        /// </summary>
        private decimal qtquebra11;
        [XmlElement(ElementName = "QTQUEBRA11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebra11
        {
            get { return  qtquebra11; }
            set {  qtquebra11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTQUEBRA12
        /// Comentário: 
        /// </summary>
        private decimal qtquebra12;
        [XmlElement(ElementName = "QTQUEBRA12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtquebra12
        {
            get { return  qtquebra12; }
            set {  qtquebra12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJCD01
        /// Comentário: 
        /// </summary>
        private decimal qttransljcd01;
        [XmlElement(ElementName = "QTTRANSLJCD01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljcd01
        {
            get { return  qttransljcd01; }
            set {  qttransljcd01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJCD02
        /// Comentário: 
        /// </summary>
        private decimal qttransljcd02;
        [XmlElement(ElementName = "QTTRANSLJCD02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljcd02
        {
            get { return  qttransljcd02; }
            set {  qttransljcd02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJCD03
        /// Comentário: 
        /// </summary>
        private decimal qttransljcd03;
        [XmlElement(ElementName = "QTTRANSLJCD03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljcd03
        {
            get { return  qttransljcd03; }
            set {  qttransljcd03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJCD04
        /// Comentário: 
        /// </summary>
        private decimal qttransljcd04;
        [XmlElement(ElementName = "QTTRANSLJCD04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljcd04
        {
            get { return  qttransljcd04; }
            set {  qttransljcd04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJCD05
        /// Comentário: 
        /// </summary>
        private decimal qttransljcd05;
        [XmlElement(ElementName = "QTTRANSLJCD05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljcd05
        {
            get { return  qttransljcd05; }
            set {  qttransljcd05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJCD06
        /// Comentário: 
        /// </summary>
        private decimal qttransljcd06;
        [XmlElement(ElementName = "QTTRANSLJCD06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljcd06
        {
            get { return  qttransljcd06; }
            set {  qttransljcd06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJCD07
        /// Comentário: 
        /// </summary>
        private decimal qttransljcd07;
        [XmlElement(ElementName = "QTTRANSLJCD07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljcd07
        {
            get { return  qttransljcd07; }
            set {  qttransljcd07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJCD08
        /// Comentário: 
        /// </summary>
        private decimal qttransljcd08;
        [XmlElement(ElementName = "QTTRANSLJCD08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljcd08
        {
            get { return  qttransljcd08; }
            set {  qttransljcd08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJCD09
        /// Comentário: 
        /// </summary>
        private decimal qttransljcd09;
        [XmlElement(ElementName = "QTTRANSLJCD09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljcd09
        {
            get { return  qttransljcd09; }
            set {  qttransljcd09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJCD10
        /// Comentário: 
        /// </summary>
        private decimal qttransljcd10;
        [XmlElement(ElementName = "QTTRANSLJCD10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljcd10
        {
            get { return  qttransljcd10; }
            set {  qttransljcd10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJCD11
        /// Comentário: 
        /// </summary>
        private decimal qttransljcd11;
        [XmlElement(ElementName = "QTTRANSLJCD11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljcd11
        {
            get { return  qttransljcd11; }
            set {  qttransljcd11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJCD12
        /// Comentário: 
        /// </summary>
        private decimal qttransljcd12;
        [XmlElement(ElementName = "QTTRANSLJCD12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljcd12
        {
            get { return  qttransljcd12; }
            set {  qttransljcd12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJSAIDA01
        /// Comentário: 
        /// </summary>
        private decimal qttransljsaida01;
        [XmlElement(ElementName = "QTTRANSLJSAIDA01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljsaida01
        {
            get { return  qttransljsaida01; }
            set {  qttransljsaida01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJSAIDA02
        /// Comentário: 
        /// </summary>
        private decimal qttransljsaida02;
        [XmlElement(ElementName = "QTTRANSLJSAIDA02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljsaida02
        {
            get { return  qttransljsaida02; }
            set {  qttransljsaida02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJSAIDA03
        /// Comentário: 
        /// </summary>
        private decimal qttransljsaida03;
        [XmlElement(ElementName = "QTTRANSLJSAIDA03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljsaida03
        {
            get { return  qttransljsaida03; }
            set {  qttransljsaida03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJSAIDA04
        /// Comentário: 
        /// </summary>
        private decimal qttransljsaida04;
        [XmlElement(ElementName = "QTTRANSLJSAIDA04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljsaida04
        {
            get { return  qttransljsaida04; }
            set {  qttransljsaida04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJSAIDA05
        /// Comentário: 
        /// </summary>
        private decimal qttransljsaida05;
        [XmlElement(ElementName = "QTTRANSLJSAIDA05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljsaida05
        {
            get { return  qttransljsaida05; }
            set {  qttransljsaida05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJSAIDA06
        /// Comentário: 
        /// </summary>
        private decimal qttransljsaida06;
        [XmlElement(ElementName = "QTTRANSLJSAIDA06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljsaida06
        {
            get { return  qttransljsaida06; }
            set {  qttransljsaida06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJSAIDA07
        /// Comentário: 
        /// </summary>
        private decimal qttransljsaida07;
        [XmlElement(ElementName = "QTTRANSLJSAIDA07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljsaida07
        {
            get { return  qttransljsaida07; }
            set {  qttransljsaida07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJSAIDA08
        /// Comentário: 
        /// </summary>
        private decimal qttransljsaida08;
        [XmlElement(ElementName = "QTTRANSLJSAIDA08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljsaida08
        {
            get { return  qttransljsaida08; }
            set {  qttransljsaida08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJSAIDA09
        /// Comentário: 
        /// </summary>
        private decimal qttransljsaida09;
        [XmlElement(ElementName = "QTTRANSLJSAIDA09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljsaida09
        {
            get { return  qttransljsaida09; }
            set {  qttransljsaida09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJSAIDA10
        /// Comentário: 
        /// </summary>
        private decimal qttransljsaida10;
        [XmlElement(ElementName = "QTTRANSLJSAIDA10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljsaida10
        {
            get { return  qttransljsaida10; }
            set {  qttransljsaida10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJSAIDA11
        /// Comentário: 
        /// </summary>
        private decimal qttransljsaida11;
        [XmlElement(ElementName = "QTTRANSLJSAIDA11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljsaida11
        {
            get { return  qttransljsaida11; }
            set {  qttransljsaida11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJSAIDA12
        /// Comentário: 
        /// </summary>
        private decimal qttransljsaida12;
        [XmlElement(ElementName = "QTTRANSLJSAIDA12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttransljsaida12
        {
            get { return  qttransljsaida12; }
            set {  qttransljsaida12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJ01
        /// Comentário: 
        /// </summary>
        private decimal qttranslj01;
        [XmlElement(ElementName = "QTTRANSLJ01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttranslj01
        {
            get { return  qttranslj01; }
            set {  qttranslj01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJ02
        /// Comentário: 
        /// </summary>
        private decimal qttranslj02;
        [XmlElement(ElementName = "QTTRANSLJ02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttranslj02
        {
            get { return  qttranslj02; }
            set {  qttranslj02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJ03
        /// Comentário: 
        /// </summary>
        private decimal qttranslj03;
        [XmlElement(ElementName = "QTTRANSLJ03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttranslj03
        {
            get { return  qttranslj03; }
            set {  qttranslj03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJ04
        /// Comentário: 
        /// </summary>
        private decimal qttranslj04;
        [XmlElement(ElementName = "QTTRANSLJ04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttranslj04
        {
            get { return  qttranslj04; }
            set {  qttranslj04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJ05
        /// Comentário: 
        /// </summary>
        private decimal qttranslj05;
        [XmlElement(ElementName = "QTTRANSLJ05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttranslj05
        {
            get { return  qttranslj05; }
            set {  qttranslj05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJ06
        /// Comentário: 
        /// </summary>
        private decimal qttranslj06;
        [XmlElement(ElementName = "QTTRANSLJ06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttranslj06
        {
            get { return  qttranslj06; }
            set {  qttranslj06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJ07
        /// Comentário: 
        /// </summary>
        private decimal qttranslj07;
        [XmlElement(ElementName = "QTTRANSLJ07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttranslj07
        {
            get { return  qttranslj07; }
            set {  qttranslj07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJ08
        /// Comentário: 
        /// </summary>
        private decimal qttranslj08;
        [XmlElement(ElementName = "QTTRANSLJ08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttranslj08
        {
            get { return  qttranslj08; }
            set {  qttranslj08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJ09
        /// Comentário: 
        /// </summary>
        private decimal qttranslj09;
        [XmlElement(ElementName = "QTTRANSLJ09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttranslj09
        {
            get { return  qttranslj09; }
            set {  qttranslj09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJ10
        /// Comentário: 
        /// </summary>
        private decimal qttranslj10;
        [XmlElement(ElementName = "QTTRANSLJ10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttranslj10
        {
            get { return  qttranslj10; }
            set {  qttranslj10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJ11
        /// Comentário: 
        /// </summary>
        private decimal qttranslj11;
        [XmlElement(ElementName = "QTTRANSLJ11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttranslj11
        {
            get { return  qttranslj11; }
            set {  qttranslj11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSLJ12
        /// Comentário: 
        /// </summary>
        private decimal qttranslj12;
        [XmlElement(ElementName = "QTTRANSLJ12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qttranslj12
        {
            get { return  qttranslj12; }
            set {  qttranslj12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES01
        /// Comentário: 
        /// </summary>
        private decimal qtvendames01;
        [XmlElement(ElementName = "QTVENDAMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendames01
        {
            get { return  qtvendames01; }
            set {  qtvendames01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES02
        /// Comentário: 
        /// </summary>
        private decimal qtvendames02;
        [XmlElement(ElementName = "QTVENDAMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendames02
        {
            get { return  qtvendames02; }
            set {  qtvendames02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES03
        /// Comentário: 
        /// </summary>
        private decimal qtvendames03;
        [XmlElement(ElementName = "QTVENDAMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendames03
        {
            get { return  qtvendames03; }
            set {  qtvendames03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES04
        /// Comentário: 
        /// </summary>
        private decimal qtvendames04;
        [XmlElement(ElementName = "QTVENDAMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendames04
        {
            get { return  qtvendames04; }
            set {  qtvendames04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES05
        /// Comentário: 
        /// </summary>
        private decimal qtvendames05;
        [XmlElement(ElementName = "QTVENDAMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendames05
        {
            get { return  qtvendames05; }
            set {  qtvendames05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES06
        /// Comentário: 
        /// </summary>
        private decimal qtvendames06;
        [XmlElement(ElementName = "QTVENDAMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendames06
        {
            get { return  qtvendames06; }
            set {  qtvendames06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES07
        /// Comentário: 
        /// </summary>
        private decimal qtvendames07;
        [XmlElement(ElementName = "QTVENDAMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendames07
        {
            get { return  qtvendames07; }
            set {  qtvendames07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES08
        /// Comentário: 
        /// </summary>
        private decimal qtvendames08;
        [XmlElement(ElementName = "QTVENDAMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendames08
        {
            get { return  qtvendames08; }
            set {  qtvendames08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES09
        /// Comentário: 
        /// </summary>
        private decimal qtvendames09;
        [XmlElement(ElementName = "QTVENDAMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendames09
        {
            get { return  qtvendames09; }
            set {  qtvendames09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES10
        /// Comentário: 
        /// </summary>
        private decimal qtvendames10;
        [XmlElement(ElementName = "QTVENDAMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendames10
        {
            get { return  qtvendames10; }
            set {  qtvendames10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES11
        /// Comentário: 
        /// </summary>
        private decimal qtvendames11;
        [XmlElement(ElementName = "QTVENDAMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendames11
        {
            get { return  qtvendames11; }
            set {  qtvendames11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES12
        /// Comentário: 
        /// </summary>
        private decimal qtvendames12;
        [XmlElement(ElementName = "QTVENDAMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendames12
        {
            get { return  qtvendames12; }
            set {  qtvendames12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRAMES01
        /// Comentário: 
        /// </summary>
        private decimal vlcomprames01;
        [XmlElement(ElementName = "VLCOMPRAMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomprames01
        {
            get { return  vlcomprames01; }
            set {  vlcomprames01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRAMES02
        /// Comentário: 
        /// </summary>
        private decimal vlcomprames02;
        [XmlElement(ElementName = "VLCOMPRAMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomprames02
        {
            get { return  vlcomprames02; }
            set {  vlcomprames02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRAMES03
        /// Comentário: 
        /// </summary>
        private decimal vlcomprames03;
        [XmlElement(ElementName = "VLCOMPRAMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomprames03
        {
            get { return  vlcomprames03; }
            set {  vlcomprames03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRAMES04
        /// Comentário: 
        /// </summary>
        private decimal vlcomprames04;
        [XmlElement(ElementName = "VLCOMPRAMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomprames04
        {
            get { return  vlcomprames04; }
            set {  vlcomprames04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRAMES05
        /// Comentário: 
        /// </summary>
        private decimal vlcomprames05;
        [XmlElement(ElementName = "VLCOMPRAMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomprames05
        {
            get { return  vlcomprames05; }
            set {  vlcomprames05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRAMES06
        /// Comentário: 
        /// </summary>
        private decimal vlcomprames06;
        [XmlElement(ElementName = "VLCOMPRAMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomprames06
        {
            get { return  vlcomprames06; }
            set {  vlcomprames06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRAMES07
        /// Comentário: 
        /// </summary>
        private decimal vlcomprames07;
        [XmlElement(ElementName = "VLCOMPRAMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomprames07
        {
            get { return  vlcomprames07; }
            set {  vlcomprames07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRAMES08
        /// Comentário: 
        /// </summary>
        private decimal vlcomprames08;
        [XmlElement(ElementName = "VLCOMPRAMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomprames08
        {
            get { return  vlcomprames08; }
            set {  vlcomprames08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRAMES09
        /// Comentário: 
        /// </summary>
        private decimal vlcomprames09;
        [XmlElement(ElementName = "VLCOMPRAMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomprames09
        {
            get { return  vlcomprames09; }
            set {  vlcomprames09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRAMES10
        /// Comentário: 
        /// </summary>
        private decimal vlcomprames10;
        [XmlElement(ElementName = "VLCOMPRAMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomprames10
        {
            get { return  vlcomprames10; }
            set {  vlcomprames10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRAMES11
        /// Comentário: 
        /// </summary>
        private decimal vlcomprames11;
        [XmlElement(ElementName = "VLCOMPRAMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomprames11
        {
            get { return  vlcomprames11; }
            set {  vlcomprames11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRAMES12
        /// Comentário: 
        /// </summary>
        private decimal vlcomprames12;
        [XmlElement(ElementName = "VLCOMPRAMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomprames12
        {
            get { return  vlcomprames12; }
            set {  vlcomprames12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINMES01
        /// Comentário: 
        /// </summary>
        private decimal vlcustofinmes01;
        [XmlElement(ElementName = "VLCUSTOFINMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofinmes01
        {
            get { return  vlcustofinmes01; }
            set {  vlcustofinmes01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINMES02
        /// Comentário: 
        /// </summary>
        private decimal vlcustofinmes02;
        [XmlElement(ElementName = "VLCUSTOFINMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofinmes02
        {
            get { return  vlcustofinmes02; }
            set {  vlcustofinmes02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINMES03
        /// Comentário: 
        /// </summary>
        private decimal vlcustofinmes03;
        [XmlElement(ElementName = "VLCUSTOFINMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofinmes03
        {
            get { return  vlcustofinmes03; }
            set {  vlcustofinmes03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINMES04
        /// Comentário: 
        /// </summary>
        private decimal vlcustofinmes04;
        [XmlElement(ElementName = "VLCUSTOFINMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofinmes04
        {
            get { return  vlcustofinmes04; }
            set {  vlcustofinmes04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINMES05
        /// Comentário: 
        /// </summary>
        private decimal vlcustofinmes05;
        [XmlElement(ElementName = "VLCUSTOFINMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofinmes05
        {
            get { return  vlcustofinmes05; }
            set {  vlcustofinmes05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINMES06
        /// Comentário: 
        /// </summary>
        private decimal vlcustofinmes06;
        [XmlElement(ElementName = "VLCUSTOFINMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofinmes06
        {
            get { return  vlcustofinmes06; }
            set {  vlcustofinmes06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINMES07
        /// Comentário: 
        /// </summary>
        private decimal vlcustofinmes07;
        [XmlElement(ElementName = "VLCUSTOFINMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofinmes07
        {
            get { return  vlcustofinmes07; }
            set {  vlcustofinmes07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINMES08
        /// Comentário: 
        /// </summary>
        private decimal vlcustofinmes08;
        [XmlElement(ElementName = "VLCUSTOFINMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofinmes08
        {
            get { return  vlcustofinmes08; }
            set {  vlcustofinmes08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINMES09
        /// Comentário: 
        /// </summary>
        private decimal vlcustofinmes09;
        [XmlElement(ElementName = "VLCUSTOFINMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofinmes09
        {
            get { return  vlcustofinmes09; }
            set {  vlcustofinmes09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINMES10
        /// Comentário: 
        /// </summary>
        private decimal vlcustofinmes10;
        [XmlElement(ElementName = "VLCUSTOFINMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofinmes10
        {
            get { return  vlcustofinmes10; }
            set {  vlcustofinmes10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINMES11
        /// Comentário: 
        /// </summary>
        private decimal vlcustofinmes11;
        [XmlElement(ElementName = "VLCUSTOFINMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofinmes11
        {
            get { return  vlcustofinmes11; }
            set {  vlcustofinmes11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINMES12
        /// Comentário: 
        /// </summary>
        private decimal vlcustofinmes12;
        [XmlElement(ElementName = "VLCUSTOFINMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofinmes12
        {
            get { return  vlcustofinmes12; }
            set {  vlcustofinmes12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALMES01
        /// Comentário: 
        /// </summary>
        private decimal vlcustorealmes01;
        [XmlElement(ElementName = "VLCUSTOREALMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorealmes01
        {
            get { return  vlcustorealmes01; }
            set {  vlcustorealmes01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALMES02
        /// Comentário: 
        /// </summary>
        private decimal vlcustorealmes02;
        [XmlElement(ElementName = "VLCUSTOREALMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorealmes02
        {
            get { return  vlcustorealmes02; }
            set {  vlcustorealmes02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALMES03
        /// Comentário: 
        /// </summary>
        private decimal vlcustorealmes03;
        [XmlElement(ElementName = "VLCUSTOREALMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorealmes03
        {
            get { return  vlcustorealmes03; }
            set {  vlcustorealmes03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALMES04
        /// Comentário: 
        /// </summary>
        private decimal vlcustorealmes04;
        [XmlElement(ElementName = "VLCUSTOREALMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorealmes04
        {
            get { return  vlcustorealmes04; }
            set {  vlcustorealmes04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALMES05
        /// Comentário: 
        /// </summary>
        private decimal vlcustorealmes05;
        [XmlElement(ElementName = "VLCUSTOREALMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorealmes05
        {
            get { return  vlcustorealmes05; }
            set {  vlcustorealmes05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALMES06
        /// Comentário: 
        /// </summary>
        private decimal vlcustorealmes06;
        [XmlElement(ElementName = "VLCUSTOREALMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorealmes06
        {
            get { return  vlcustorealmes06; }
            set {  vlcustorealmes06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALMES07
        /// Comentário: 
        /// </summary>
        private decimal vlcustorealmes07;
        [XmlElement(ElementName = "VLCUSTOREALMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorealmes07
        {
            get { return  vlcustorealmes07; }
            set {  vlcustorealmes07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALMES08
        /// Comentário: 
        /// </summary>
        private decimal vlcustorealmes08;
        [XmlElement(ElementName = "VLCUSTOREALMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorealmes08
        {
            get { return  vlcustorealmes08; }
            set {  vlcustorealmes08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALMES09
        /// Comentário: 
        /// </summary>
        private decimal vlcustorealmes09;
        [XmlElement(ElementName = "VLCUSTOREALMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorealmes09
        {
            get { return  vlcustorealmes09; }
            set {  vlcustorealmes09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALMES10
        /// Comentário: 
        /// </summary>
        private decimal vlcustorealmes10;
        [XmlElement(ElementName = "VLCUSTOREALMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorealmes10
        {
            get { return  vlcustorealmes10; }
            set {  vlcustorealmes10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALMES11
        /// Comentário: 
        /// </summary>
        private decimal vlcustorealmes11;
        [XmlElement(ElementName = "VLCUSTOREALMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorealmes11
        {
            get { return  vlcustorealmes11; }
            set {  vlcustorealmes11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALMES12
        /// Comentário: 
        /// </summary>
        private decimal vlcustorealmes12;
        [XmlElement(ElementName = "VLCUSTOREALMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorealmes12
        {
            get { return  vlcustorealmes12; }
            set {  vlcustorealmes12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVCLI01
        /// Comentário: Valor de Devolução de cliente do mês 01
        /// </summary>
        private decimal vldevcli01;
        [XmlElement(ElementName = "VLDEVCLI01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevcli01
        {
            get { return  vldevcli01; }
            set {  vldevcli01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVCLI02
        /// Comentário: Valor de Devolução de cliente do mês 02
        /// </summary>
        private decimal vldevcli02;
        [XmlElement(ElementName = "VLDEVCLI02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevcli02
        {
            get { return  vldevcli02; }
            set {  vldevcli02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVCLI03
        /// Comentário: Valor de Devolução de cliente do mês 03
        /// </summary>
        private decimal vldevcli03;
        [XmlElement(ElementName = "VLDEVCLI03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevcli03
        {
            get { return  vldevcli03; }
            set {  vldevcli03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVCLI04
        /// Comentário: Valor de Devolução de cliente do mês 04
        /// </summary>
        private decimal vldevcli04;
        [XmlElement(ElementName = "VLDEVCLI04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevcli04
        {
            get { return  vldevcli04; }
            set {  vldevcli04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVCLI05
        /// Comentário: Valor de Devolução de cliente do mês 05
        /// </summary>
        private decimal vldevcli05;
        [XmlElement(ElementName = "VLDEVCLI05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevcli05
        {
            get { return  vldevcli05; }
            set {  vldevcli05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVCLI06
        /// Comentário: Valor de Devolução de cliente do mês 06
        /// </summary>
        private decimal vldevcli06;
        [XmlElement(ElementName = "VLDEVCLI06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevcli06
        {
            get { return  vldevcli06; }
            set {  vldevcli06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVCLI07
        /// Comentário: Valor de Devolução de cliente do mês 07
        /// </summary>
        private decimal vldevcli07;
        [XmlElement(ElementName = "VLDEVCLI07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevcli07
        {
            get { return  vldevcli07; }
            set {  vldevcli07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVCLI08
        /// Comentário: Valor de Devolução de cliente do mês 08
        /// </summary>
        private decimal vldevcli08;
        [XmlElement(ElementName = "VLDEVCLI08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevcli08
        {
            get { return  vldevcli08; }
            set {  vldevcli08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVCLI09
        /// Comentário: Valor de Devolução de cliente do mês 09
        /// </summary>
        private decimal vldevcli09;
        [XmlElement(ElementName = "VLDEVCLI09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevcli09
        {
            get { return  vldevcli09; }
            set {  vldevcli09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVCLI10
        /// Comentário: Valor de Devolução de cliente do mês 10
        /// </summary>
        private decimal vldevcli10;
        [XmlElement(ElementName = "VLDEVCLI10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevcli10
        {
            get { return  vldevcli10; }
            set {  vldevcli10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVCLI11
        /// Comentário: Valor de Devolução de cliente do mês 11
        /// </summary>
        private decimal vldevcli11;
        [XmlElement(ElementName = "VLDEVCLI11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevcli11
        {
            get { return  vldevcli11; }
            set {  vldevcli11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVCLI12
        /// Comentário: Valor de Devolução de cliente do mês 12
        /// </summary>
        private decimal vldevcli12;
        [XmlElement(ElementName = "VLDEVCLI12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevcli12
        {
            get { return  vldevcli12; }
            set {  vldevcli12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT01
        /// Comentário: 
        /// </summary>
        private decimal vlent01;
        [XmlElement(ElementName = "VLENT01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlent01
        {
            get { return  vlent01; }
            set {  vlent01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT02
        /// Comentário: 
        /// </summary>
        private decimal vlent02;
        [XmlElement(ElementName = "VLENT02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlent02
        {
            get { return  vlent02; }
            set {  vlent02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT03
        /// Comentário: 
        /// </summary>
        private decimal vlent03;
        [XmlElement(ElementName = "VLENT03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlent03
        {
            get { return  vlent03; }
            set {  vlent03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT04
        /// Comentário: 
        /// </summary>
        private decimal vlent04;
        [XmlElement(ElementName = "VLENT04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlent04
        {
            get { return  vlent04; }
            set {  vlent04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT05
        /// Comentário: 
        /// </summary>
        private decimal vlent05;
        [XmlElement(ElementName = "VLENT05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlent05
        {
            get { return  vlent05; }
            set {  vlent05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT06
        /// Comentário: 
        /// </summary>
        private decimal vlent06;
        [XmlElement(ElementName = "VLENT06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlent06
        {
            get { return  vlent06; }
            set {  vlent06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT07
        /// Comentário: 
        /// </summary>
        private decimal vlent07;
        [XmlElement(ElementName = "VLENT07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlent07
        {
            get { return  vlent07; }
            set {  vlent07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT08
        /// Comentário: 
        /// </summary>
        private decimal vlent08;
        [XmlElement(ElementName = "VLENT08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlent08
        {
            get { return  vlent08; }
            set {  vlent08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT09
        /// Comentário: 
        /// </summary>
        private decimal vlent09;
        [XmlElement(ElementName = "VLENT09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlent09
        {
            get { return  vlent09; }
            set {  vlent09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT10
        /// Comentário: 
        /// </summary>
        private decimal vlent10;
        [XmlElement(ElementName = "VLENT10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlent10
        {
            get { return  vlent10; }
            set {  vlent10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT11
        /// Comentário: 
        /// </summary>
        private decimal vlent11;
        [XmlElement(ElementName = "VLENT11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlent11
        {
            get { return  vlent11; }
            set {  vlent11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT12
        /// Comentário: 
        /// </summary>
        private decimal vlent12;
        [XmlElement(ElementName = "VLENT12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlent12
        {
            get { return  vlent12; }
            set {  vlent12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUEMES01
        /// Comentário: 
        /// </summary>
        private decimal vlestoquemes01;
        [XmlElement(ElementName = "VLESTOQUEMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoquemes01
        {
            get { return  vlestoquemes01; }
            set {  vlestoquemes01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUEMES02
        /// Comentário: 
        /// </summary>
        private decimal vlestoquemes02;
        [XmlElement(ElementName = "VLESTOQUEMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoquemes02
        {
            get { return  vlestoquemes02; }
            set {  vlestoquemes02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUEMES03
        /// Comentário: 
        /// </summary>
        private decimal vlestoquemes03;
        [XmlElement(ElementName = "VLESTOQUEMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoquemes03
        {
            get { return  vlestoquemes03; }
            set {  vlestoquemes03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUEMES04
        /// Comentário: 
        /// </summary>
        private decimal vlestoquemes04;
        [XmlElement(ElementName = "VLESTOQUEMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoquemes04
        {
            get { return  vlestoquemes04; }
            set {  vlestoquemes04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUEMES05
        /// Comentário: 
        /// </summary>
        private decimal vlestoquemes05;
        [XmlElement(ElementName = "VLESTOQUEMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoquemes05
        {
            get { return  vlestoquemes05; }
            set {  vlestoquemes05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUEMES06
        /// Comentário: 
        /// </summary>
        private decimal vlestoquemes06;
        [XmlElement(ElementName = "VLESTOQUEMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoquemes06
        {
            get { return  vlestoquemes06; }
            set {  vlestoquemes06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUEMES07
        /// Comentário: 
        /// </summary>
        private decimal vlestoquemes07;
        [XmlElement(ElementName = "VLESTOQUEMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoquemes07
        {
            get { return  vlestoquemes07; }
            set {  vlestoquemes07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUEMES08
        /// Comentário: 
        /// </summary>
        private decimal vlestoquemes08;
        [XmlElement(ElementName = "VLESTOQUEMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoquemes08
        {
            get { return  vlestoquemes08; }
            set {  vlestoquemes08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUEMES09
        /// Comentário: 
        /// </summary>
        private decimal vlestoquemes09;
        [XmlElement(ElementName = "VLESTOQUEMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoquemes09
        {
            get { return  vlestoquemes09; }
            set {  vlestoquemes09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUEMES10
        /// Comentário: 
        /// </summary>
        private decimal vlestoquemes10;
        [XmlElement(ElementName = "VLESTOQUEMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoquemes10
        {
            get { return  vlestoquemes10; }
            set {  vlestoquemes10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUEMES11
        /// Comentário: 
        /// </summary>
        private decimal vlestoquemes11;
        [XmlElement(ElementName = "VLESTOQUEMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoquemes11
        {
            get { return  vlestoquemes11; }
            set {  vlestoquemes11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUEMES12
        /// Comentário: 
        /// </summary>
        private decimal vlestoquemes12;
        [XmlElement(ElementName = "VLESTOQUEMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoquemes12
        {
            get { return  vlestoquemes12; }
            set {  vlestoquemes12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMES01
        /// Comentário: 
        /// </summary>
        private decimal vlvendames01;
        [XmlElement(ElementName = "VLVENDAMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendames01
        {
            get { return  vlvendames01; }
            set {  vlvendames01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMES02
        /// Comentário: 
        /// </summary>
        private decimal vlvendames02;
        [XmlElement(ElementName = "VLVENDAMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendames02
        {
            get { return  vlvendames02; }
            set {  vlvendames02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMES03
        /// Comentário: 
        /// </summary>
        private decimal vlvendames03;
        [XmlElement(ElementName = "VLVENDAMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendames03
        {
            get { return  vlvendames03; }
            set {  vlvendames03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMES04
        /// Comentário: 
        /// </summary>
        private decimal vlvendames04;
        [XmlElement(ElementName = "VLVENDAMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendames04
        {
            get { return  vlvendames04; }
            set {  vlvendames04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMES05
        /// Comentário: 
        /// </summary>
        private decimal vlvendames05;
        [XmlElement(ElementName = "VLVENDAMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendames05
        {
            get { return  vlvendames05; }
            set {  vlvendames05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMES06
        /// Comentário: 
        /// </summary>
        private decimal vlvendames06;
        [XmlElement(ElementName = "VLVENDAMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendames06
        {
            get { return  vlvendames06; }
            set {  vlvendames06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMES07
        /// Comentário: 
        /// </summary>
        private decimal vlvendames07;
        [XmlElement(ElementName = "VLVENDAMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendames07
        {
            get { return  vlvendames07; }
            set {  vlvendames07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMES08
        /// Comentário: 
        /// </summary>
        private decimal vlvendames08;
        [XmlElement(ElementName = "VLVENDAMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendames08
        {
            get { return  vlvendames08; }
            set {  vlvendames08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMES09
        /// Comentário: 
        /// </summary>
        private decimal vlvendames09;
        [XmlElement(ElementName = "VLVENDAMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendames09
        {
            get { return  vlvendames09; }
            set {  vlvendames09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMES10
        /// Comentário: 
        /// </summary>
        private decimal vlvendames10;
        [XmlElement(ElementName = "VLVENDAMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendames10
        {
            get { return  vlvendames10; }
            set {  vlvendames10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMES11
        /// Comentário: 
        /// </summary>
        private decimal vlvendames11;
        [XmlElement(ElementName = "VLVENDAMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendames11
        {
            get { return  vlvendames11; }
            set {  vlvendames11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMES12
        /// Comentário: 
        /// </summary>
        private decimal vlvendames12;
        [XmlElement(ElementName = "VLVENDAMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendames12
        {
            get { return  vlvendames12; }
            set {  vlvendames12 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAuxpro()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAUXPRO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAuxpro> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAuxpro>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAuxpro> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAuxpro>(where);
        }

        #endregion
    }
}
