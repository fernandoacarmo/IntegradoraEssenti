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
        /// Comentário: Código da condição de venda
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
        /// Comentário: Código da linha de prazo
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
        /// Comentário: Código do plano de pagamento
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
        /// Comentário: Desconto Máximo da Indústria
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
        /// Comentário: Percentual de desconto do Boleto
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
        /// Comentário: Percentual de desconto de bonificação da NF
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
        /// Comentário: Percentual de desconto financeiro por linha de prazo
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
        /// Comentário: Percentual de desconto comercial da NF
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
        /// Comentário: Tipo de incidência da política de desconto
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
        /// Comentário: Tipo de Validação do Desconto da Indústria
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCondvendalinha> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCondvendalinha>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
