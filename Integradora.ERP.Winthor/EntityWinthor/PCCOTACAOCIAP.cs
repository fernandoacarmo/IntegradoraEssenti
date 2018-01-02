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
    /// Classe referente a tabela PCCotacaociap
    /// </summary>
    [XmlType("PCCOTACAOCIAP")]
    public class PCCotacaociap : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Comentário: Código do usuário de inclusão
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
        /// Propriedade referente ao campo: CODPARCELA
        /// Comentário: Código Parcela geração C.Pagar Previsto
        /// </summary>
        private decimal codparcela;
        [XmlElement(ElementName = "CODPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codparcela
        {
            get { return  codparcela; }
            set {  codparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Código da rotina
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: Data da Cotação
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
        /// Propriedade referente ao campo: DTFIMVIGENCIA
        /// Comentário: Data Fim
        /// </summary>
        private DateTime? dtfimvigencia;
        [XmlElement(ElementName = "DTFIMVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimvigencia
        {
            get { return  dtfimvigencia; }
            set {  dtfimvigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINIVIGENCIA
        /// Comentário: Data Inicio
        /// </summary>
        private DateTime? dtinivigencia;
        [XmlElement(ElementName = "DTINIVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinivigencia
        {
            get { return  dtinivigencia; }
            set {  dtinivigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCOTACAO
        /// Comentário: Número da Cotação
        /// </summary>
        private decimal numcotacao;
        [XmlElement(ElementName = "NUMCOTACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcotacao
        {
            get { return  numcotacao; }
            set {  numcotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: Número do pedido de compra vinculado
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCARGA
        /// Comentário: Tipo descarga geração do pedido
        /// </summary>
        private string tipodescarga;
        [XmlElement(ElementName = "TIPODESCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodescarga
        {
            get { return  tipodescarga; }
            set {  tipodescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTLPRAZOMEDFORNEC
        /// Comentário: Utiliza prazo médio Fornecedor
        /// </summary>
        private string utlprazomedfornec;
        [XmlElement(ElementName = "UTLPRAZOMEDFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utlprazomedfornec
        {
            get { return  utlprazomedfornec; }
            set {  utlprazomedfornec = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCotacaociap()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOTACAOCIAP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCotacaociap> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCotacaociap>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCotacaociap> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCotacaociap>(where);
        }

        #endregion
    }
}
