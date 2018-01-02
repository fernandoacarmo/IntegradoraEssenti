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
    /// Classe referente a tabela PCAuxlan
    /// </summary>
    [XmlType("PCAUXLAN")]
    public class PCAuxlan : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODCONTA
        /// Coment�rio: 
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: TIPOREGIME
        /// Coment�rio: Define se o registro se refere ao regime de caixa ou de compet�ncia.
        /// </summary>
        private string tiporegime;
        [XmlElement(ElementName = "TIPOREGIME", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public string Tiporegime
        {
            get { return  tiporegime; }
            set {  tiporegime = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMES1
        /// Coment�rio: 
        /// </summary>
        private decimal vlmes1;
        [XmlElement(ElementName = "VLMES1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmes1
        {
            get { return  vlmes1; }
            set {  vlmes1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMES10
        /// Coment�rio: 
        /// </summary>
        private decimal vlmes10;
        [XmlElement(ElementName = "VLMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmes10
        {
            get { return  vlmes10; }
            set {  vlmes10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMES11
        /// Coment�rio: 
        /// </summary>
        private decimal vlmes11;
        [XmlElement(ElementName = "VLMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmes11
        {
            get { return  vlmes11; }
            set {  vlmes11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMES12
        /// Coment�rio: 
        /// </summary>
        private decimal vlmes12;
        [XmlElement(ElementName = "VLMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmes12
        {
            get { return  vlmes12; }
            set {  vlmes12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMES2
        /// Coment�rio: 
        /// </summary>
        private decimal vlmes2;
        [XmlElement(ElementName = "VLMES2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmes2
        {
            get { return  vlmes2; }
            set {  vlmes2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMES3
        /// Coment�rio: 
        /// </summary>
        private decimal vlmes3;
        [XmlElement(ElementName = "VLMES3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmes3
        {
            get { return  vlmes3; }
            set {  vlmes3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMES4
        /// Coment�rio: 
        /// </summary>
        private decimal vlmes4;
        [XmlElement(ElementName = "VLMES4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmes4
        {
            get { return  vlmes4; }
            set {  vlmes4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMES5
        /// Coment�rio: 
        /// </summary>
        private decimal vlmes5;
        [XmlElement(ElementName = "VLMES5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmes5
        {
            get { return  vlmes5; }
            set {  vlmes5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMES6
        /// Coment�rio: 
        /// </summary>
        private decimal vlmes6;
        [XmlElement(ElementName = "VLMES6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmes6
        {
            get { return  vlmes6; }
            set {  vlmes6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMES7
        /// Coment�rio: 
        /// </summary>
        private decimal vlmes7;
        [XmlElement(ElementName = "VLMES7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmes7
        {
            get { return  vlmes7; }
            set {  vlmes7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMES8
        /// Coment�rio: 
        /// </summary>
        private decimal vlmes8;
        [XmlElement(ElementName = "VLMES8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmes8
        {
            get { return  vlmes8; }
            set {  vlmes8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMES9
        /// Coment�rio: 
        /// </summary>
        private decimal vlmes9;
        [XmlElement(ElementName = "VLMES9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmes9
        {
            get { return  vlmes9; }
            set {  vlmes9 = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAuxlan()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAUXLAN";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAuxlan> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAuxlan>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAuxlan> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAuxlan>(where);
        }

        #endregion
    }
}
