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
    /// Classe referente a tabela PCAuxcli
    /// </summary>
    [XmlType("PCAUXCLI")]
    public class PCAuxcli : OracleTable
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
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAMES01
        /// Comentário: 
        /// </summary>
        private decimal qtestrelames01;
        [XmlElement(ElementName = "QTESTRELAMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelames01
        {
            get { return  qtestrelames01; }
            set {  qtestrelames01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAMES02
        /// Comentário: 
        /// </summary>
        private decimal qtestrelames02;
        [XmlElement(ElementName = "QTESTRELAMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelames02
        {
            get { return  qtestrelames02; }
            set {  qtestrelames02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAMES03
        /// Comentário: 
        /// </summary>
        private decimal qtestrelames03;
        [XmlElement(ElementName = "QTESTRELAMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelames03
        {
            get { return  qtestrelames03; }
            set {  qtestrelames03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAMES04
        /// Comentário: 
        /// </summary>
        private decimal qtestrelames04;
        [XmlElement(ElementName = "QTESTRELAMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelames04
        {
            get { return  qtestrelames04; }
            set {  qtestrelames04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAMES05
        /// Comentário: 
        /// </summary>
        private decimal qtestrelames05;
        [XmlElement(ElementName = "QTESTRELAMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelames05
        {
            get { return  qtestrelames05; }
            set {  qtestrelames05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAMES06
        /// Comentário: 
        /// </summary>
        private decimal qtestrelames06;
        [XmlElement(ElementName = "QTESTRELAMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelames06
        {
            get { return  qtestrelames06; }
            set {  qtestrelames06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAMES07
        /// Comentário: 
        /// </summary>
        private decimal qtestrelames07;
        [XmlElement(ElementName = "QTESTRELAMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelames07
        {
            get { return  qtestrelames07; }
            set {  qtestrelames07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAMES08
        /// Comentário: 
        /// </summary>
        private decimal qtestrelames08;
        [XmlElement(ElementName = "QTESTRELAMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelames08
        {
            get { return  qtestrelames08; }
            set {  qtestrelames08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAMES09
        /// Comentário: 
        /// </summary>
        private decimal qtestrelames09;
        [XmlElement(ElementName = "QTESTRELAMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelames09
        {
            get { return  qtestrelames09; }
            set {  qtestrelames09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAMES10
        /// Comentário: 
        /// </summary>
        private decimal qtestrelames10;
        [XmlElement(ElementName = "QTESTRELAMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelames10
        {
            get { return  qtestrelames10; }
            set {  qtestrelames10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAMES11
        /// Comentário: 
        /// </summary>
        private decimal qtestrelames11;
        [XmlElement(ElementName = "QTESTRELAMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelames11
        {
            get { return  qtestrelames11; }
            set {  qtestrelames11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAMES12
        /// Comentário: 
        /// </summary>
        private decimal qtestrelames12;
        [XmlElement(ElementName = "QTESTRELAMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelames12
        {
            get { return  qtestrelames12; }
            set {  qtestrelames12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMES01
        /// Comentário: Indica a quantidade MIX de produtos Janeiro.
        /// </summary>
        private decimal qtmixmes01;
        [XmlElement(ElementName = "QTMIXMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixmes01
        {
            get { return  qtmixmes01; }
            set {  qtmixmes01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMES02
        /// Comentário: Indica a quantidade MIX de produtos Fevereiro.
        /// </summary>
        private decimal qtmixmes02;
        [XmlElement(ElementName = "QTMIXMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixmes02
        {
            get { return  qtmixmes02; }
            set {  qtmixmes02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMES03
        /// Comentário: Indica a quantidade MIX de produtos Março.
        /// </summary>
        private decimal qtmixmes03;
        [XmlElement(ElementName = "QTMIXMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixmes03
        {
            get { return  qtmixmes03; }
            set {  qtmixmes03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMES04
        /// Comentário: Indica a quantidade MIX de produtos Abril.
        /// </summary>
        private decimal qtmixmes04;
        [XmlElement(ElementName = "QTMIXMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixmes04
        {
            get { return  qtmixmes04; }
            set {  qtmixmes04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMES05
        /// Comentário: Indica a quantidade MIX de produtos Maio.
        /// </summary>
        private decimal qtmixmes05;
        [XmlElement(ElementName = "QTMIXMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixmes05
        {
            get { return  qtmixmes05; }
            set {  qtmixmes05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMES06
        /// Comentário: Indica a quantidade MIX de produtos Junho.
        /// </summary>
        private decimal qtmixmes06;
        [XmlElement(ElementName = "QTMIXMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixmes06
        {
            get { return  qtmixmes06; }
            set {  qtmixmes06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMES07
        /// Comentário: Indica a quantidade MIX de produtos Julho.
        /// </summary>
        private decimal qtmixmes07;
        [XmlElement(ElementName = "QTMIXMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixmes07
        {
            get { return  qtmixmes07; }
            set {  qtmixmes07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMES08
        /// Comentário: Indica a quantidade MIX de produtos Agosto.
        /// </summary>
        private decimal qtmixmes08;
        [XmlElement(ElementName = "QTMIXMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixmes08
        {
            get { return  qtmixmes08; }
            set {  qtmixmes08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMES09
        /// Comentário: Indica a quantidade MIX de produtos Setembro.
        /// </summary>
        private decimal qtmixmes09;
        [XmlElement(ElementName = "QTMIXMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixmes09
        {
            get { return  qtmixmes09; }
            set {  qtmixmes09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMES10
        /// Comentário: Indica a quantidade MIX de produtos Outubro.
        /// </summary>
        private decimal qtmixmes10;
        [XmlElement(ElementName = "QTMIXMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixmes10
        {
            get { return  qtmixmes10; }
            set {  qtmixmes10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMES11
        /// Comentário: Indica a quantidade MIX de produtos Novembro.
        /// </summary>
        private decimal qtmixmes11;
        [XmlElement(ElementName = "QTMIXMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixmes11
        {
            get { return  qtmixmes11; }
            set {  qtmixmes11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMES12
        /// Comentário: Indica a quantidade MIX de produtos Dezembro.
        /// </summary>
        private decimal qtmixmes12;
        [XmlElement(ElementName = "QTMIXMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmixmes12
        {
            get { return  qtmixmes12; }
            set {  qtmixmes12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAMES01
        /// Comentário: 
        /// </summary>
        private decimal qtvendames01;
        [XmlElement(ElementName = "QTVENDAMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
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
        [DataObjectField(false,false,true,14)]
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
        [DataObjectField(false,false,true,14)]
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
        [DataObjectField(false,false,true,14)]
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
        [DataObjectField(false,false,true,14)]
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
        [DataObjectField(false,false,true,14)]
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
        [DataObjectField(false,false,true,14)]
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
        [DataObjectField(false,false,true,14)]
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
        [DataObjectField(false,false,true,14)]
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
        [DataObjectField(false,false,true,14)]
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
        [DataObjectField(false,false,true,14)]
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
        [DataObjectField(false,false,true,14)]
        public decimal Qtvendames12
        {
            get { return  qtvendames12; }
            set {  qtvendames12 = value; }
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
        /// Propriedade referente ao campo: VLMETAMES01
        /// Comentário: 
        /// </summary>
        private decimal vlmetames01;
        [XmlElement(ElementName = "VLMETAMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames01
        {
            get { return  vlmetames01; }
            set {  vlmetames01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES02
        /// Comentário: 
        /// </summary>
        private decimal vlmetames02;
        [XmlElement(ElementName = "VLMETAMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames02
        {
            get { return  vlmetames02; }
            set {  vlmetames02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES03
        /// Comentário: 
        /// </summary>
        private decimal vlmetames03;
        [XmlElement(ElementName = "VLMETAMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames03
        {
            get { return  vlmetames03; }
            set {  vlmetames03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES04
        /// Comentário: 
        /// </summary>
        private decimal vlmetames04;
        [XmlElement(ElementName = "VLMETAMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames04
        {
            get { return  vlmetames04; }
            set {  vlmetames04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES05
        /// Comentário: 
        /// </summary>
        private decimal vlmetames05;
        [XmlElement(ElementName = "VLMETAMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames05
        {
            get { return  vlmetames05; }
            set {  vlmetames05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES06
        /// Comentário: 
        /// </summary>
        private decimal vlmetames06;
        [XmlElement(ElementName = "VLMETAMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames06
        {
            get { return  vlmetames06; }
            set {  vlmetames06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES07
        /// Comentário: 
        /// </summary>
        private decimal vlmetames07;
        [XmlElement(ElementName = "VLMETAMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames07
        {
            get { return  vlmetames07; }
            set {  vlmetames07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES08
        /// Comentário: 
        /// </summary>
        private decimal vlmetames08;
        [XmlElement(ElementName = "VLMETAMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames08
        {
            get { return  vlmetames08; }
            set {  vlmetames08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES09
        /// Comentário: 
        /// </summary>
        private decimal vlmetames09;
        [XmlElement(ElementName = "VLMETAMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames09
        {
            get { return  vlmetames09; }
            set {  vlmetames09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES10
        /// Comentário: 
        /// </summary>
        private decimal vlmetames10;
        [XmlElement(ElementName = "VLMETAMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames10
        {
            get { return  vlmetames10; }
            set {  vlmetames10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES11
        /// Comentário: 
        /// </summary>
        private decimal vlmetames11;
        [XmlElement(ElementName = "VLMETAMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames11
        {
            get { return  vlmetames11; }
            set {  vlmetames11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES12
        /// Comentário: 
        /// </summary>
        private decimal vlmetames12;
        [XmlElement(ElementName = "VLMETAMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames12
        {
            get { return  vlmetames12; }
            set {  vlmetames12 = value; }
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
        public PCAuxcli()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAUXCLI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAuxcli> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAuxcli>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAuxcli> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAuxcli>(where);
        }

        #endregion
    }
}
