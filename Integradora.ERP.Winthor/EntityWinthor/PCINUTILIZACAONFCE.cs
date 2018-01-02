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
    /// Classe referente a tabela PCInutilizacaonfce
    /// </summary>
    [XmlType("PCINUTILIZACAONFCE")]
    public class PCInutilizacaonfce : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTE
        /// Comentário: Ambiente do envio da inutilização
        /// </summary>
        private string ambiente;
        [XmlElement(ElementName = "AMBIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ambiente
        {
            get { return  ambiente; }
            set {  ambiente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: Ano
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código Filial
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIO
        /// Comentário: Código do usuário
        /// </summary>
        private decimal codusuario;
        [XmlElement(ElementName = "CODUSUARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuario
        {
            get { return  codusuario; }
            set {  codusuario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORAPROCESSAMENTO
        /// Comentário: Data do processamento
        /// </summary>
        private DateTime? dthoraprocessamento;
        [XmlElement(ElementName = "DTHORAPROCESSAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoraprocessamento
        {
            get { return  dthoraprocessamento; }
            set {  dthoraprocessamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: JUSTIFICATIVA
        /// Comentário: Justificativa da inutilização
        /// </summary>
        private string justificativa;
        [XmlElement(ElementName = "JUSTIFICATIVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,256)]
        public string Justificativa
        {
            get { return  justificativa; }
            set {  justificativa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAFINAL
        /// Comentário: Nº da Nota final
        /// </summary>
        private decimal numnotafinal;
        [XmlElement(ElementName = "NUMNOTAFINAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numnotafinal
        {
            get { return  numnotafinal; }
            set {  numnotafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAINICIAL
        /// Comentário: Nº da nota Inicial
        /// </summary>
        private decimal numnotainicial;
        [XmlElement(ElementName = "NUMNOTAINICIAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numnotainicial
        {
            get { return  numnotainicial; }
            set {  numnotainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLOINUTILIZACAO
        /// Comentário: Nº do protocolo da inutiilzação
        /// </summary>
        private string protocoloinutilizacao;
        [XmlElement(ElementName = "PROTOCOLOINUTILIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Protocoloinutilizacao
        {
            get { return  protocoloinutilizacao; }
            set {  protocoloinutilizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: Série vinculada a um caixa
        /// </summary>
        private decimal serie;
        [XmlElement(ElementName = "SERIE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCInutilizacaonfce()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINUTILIZACAONFCE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCInutilizacaonfce> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCInutilizacaonfce>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCInutilizacaonfce> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCInutilizacaonfce>(where);
        }

        #endregion
    }
}
