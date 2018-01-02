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
    /// Classe referente a tabela PCCondvendalinha
    /// </summary>
    [XmlType("PCCONDVENDALINHA")]
    public class PCCondvendalinha : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONDICAOVENDA
        /// Coment�rio: C�digo da condi��o de venda
        /// </summary>
        private decimal codcondicaovenda;
        [XmlElement(ElementName = "CODCONDICAOVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcondicaovenda
        {
            get { return  codcondicaovenda; }
            set {  codcondicaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHAPRAZO
        /// Coment�rio: C�digo da linha de prazo
        /// </summary>
        private decimal codlinhaprazo;
        [XmlElement(ElementName = "CODLINHAPRAZO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codlinhaprazo
        {
            get { return  codlinhaprazo; }
            set {  codlinhaprazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: C�digo do plano de pagamento
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCMAXINDUSTRIA
        /// Coment�rio: Desconto M�ximo da Ind�stria
        /// </summary>
        private decimal descmaxindustria;
        [XmlElement(ElementName = "DESCMAXINDUSTRIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Descmaxindustria
        {
            get { return  descmaxindustria; }
            set {  descmaxindustria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCBOLETO
        /// Coment�rio: Percentual de desconto do Boleto
        /// </summary>
        private decimal percdescboleto;
        [XmlElement(ElementName = "PERCDESCBOLETO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdescboleto
        {
            get { return  percdescboleto; }
            set {  percdescboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCBONIFNOTA
        /// Coment�rio: Percentual de desconto de bonifica��o da NF
        /// </summary>
        private decimal percdescbonifnota;
        [XmlElement(ElementName = "PERCDESCBONIFNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdescbonifnota
        {
            get { return  percdescbonifnota; }
            set {  percdescbonifnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFIN
        /// Coment�rio: Percentual de desconto financeiro por linha de prazo
        /// </summary>
        private decimal percdescfin;
        [XmlElement(ElementName = "PERCDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdescfin
        {
            get { return  percdescfin; }
            set {  percdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCOMNOTA
        /// Coment�rio: Percentual de desconto comercial da NF
        /// </summary>
        private decimal percdescomnota;
        [XmlElement(ElementName = "PERCDESCOMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdescomnota
        {
            get { return  percdescomnota; }
            set {  percdescomnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOINCIDENCIADESCOM
        /// Coment�rio: Tipo de incid�ncia da pol�tica de desconto
        /// </summary>
        private string tipoincidenciadescom;
        [XmlElement(ElementName = "TIPOINCIDENCIADESCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoincidenciadescom
        {
            get { return  tipoincidenciadescom; }
            set {  tipoincidenciadescom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALIDADESCINDUSTRIA
        /// Coment�rio: Tipo de Valida��o do Desconto da Ind�stria
        /// </summary>
        private string tipovalidadescindustria;
        [XmlElement(ElementName = "TIPOVALIDADESCINDUSTRIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalidadescindustria
        {
            get { return  tipovalidadescindustria; }
            set {  tipovalidadescindustria = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCondvendalinha()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONDVENDALINHA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCondvendalinha> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCondvendalinha>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCondvendalinha> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCondvendalinha>(where);
        }

        #endregion
    }
}
