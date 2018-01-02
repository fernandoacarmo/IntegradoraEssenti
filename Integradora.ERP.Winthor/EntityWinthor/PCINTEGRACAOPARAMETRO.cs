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
    /// Classe referente a tabela PCIntegracaoparametro
    /// </summary>
    [XmlType("PCINTEGRACAOPARAMETRO")]
    public class PCIntegracaoparametro : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRENT
        /// Comentário: Diretório dos arquivo de entreda onde os arquivos serão gerados.
        /// </summary>
        private string dirent;
        [XmlElement(ElementName = "DIRENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Dirent
        {
            get { return  dirent; }
            set {  dirent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRENTBKP
        /// Comentário: Diretório de backup dos arquivo de entreda.
        /// </summary>
        private string direntbkp;
        [XmlElement(ElementName = "DIRENTBKP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Direntbkp
        {
            get { return  direntbkp; }
            set {  direntbkp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRSAI
        /// Comentário: Diretório dos arquivo de saída.
        /// </summary>
        private string dirsai;
        [XmlElement(ElementName = "DIRSAI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Dirsai
        {
            get { return  dirsai; }
            set {  dirsai = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRSAIBKP
        /// Comentário: Diretório de backup dos arquivo de saída.
        /// </summary>
        private string dirsaibkp;
        [XmlElement(ElementName = "DIRSAIBKP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Dirsaibkp
        {
            get { return  dirsaibkp; }
            set {  dirsaibkp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAFIMNFE2562
        /// Comentário: Indica o valor final do squencicial da nota fiscal de entrada a ser exportado.
        /// </summary>
        private decimal faixafimnfe2562;
        [XmlElement(ElementName = "FAIXAFIMNFE2562", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Faixafimnfe2562
        {
            get { return  faixafimnfe2562; }
            set {  faixafimnfe2562 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAFIMPED2562
        /// Comentário: Indica o valor final do squencicial do pedido a ser exportado.
        /// </summary>
        private decimal faixafimped2562;
        [XmlElement(ElementName = "FAIXAFIMPED2562", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Faixafimped2562
        {
            get { return  faixafimped2562; }
            set {  faixafimped2562 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAININFE2562
        /// Comentário: Indica o valor inicial do sequencial da noata fiscal de entrada a ser exportado.
        /// </summary>
        private decimal faixaininfe2562;
        [XmlElement(ElementName = "FAIXAININFE2562", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Faixaininfe2562
        {
            get { return  faixaininfe2562; }
            set {  faixaininfe2562 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAINIPED2562
        /// Comentário: Indica o valor inicial do sequencial do pedido a ser exportado.
        /// </summary>
        private decimal faixainiped2562;
        [XmlElement(ElementName = "FAIXAINIPED2562", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Faixainiped2562
        {
            get { return  faixainiped2562; }
            set {  faixainiped2562 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDTRANSNFE2562
        /// Comentário: Indica o código da transação de estoque para nota fiscal de entrada.
        /// </summary>
        private decimal idtransnfe2562;
        [XmlElement(ElementName = "IDTRANSNFE2562", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Idtransnfe2562
        {
            get { return  idtransnfe2562; }
            set {  idtransnfe2562 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDTRANSPED2562
        /// Comentário: Indica o código da transação de estoque para o pedido de venda.
        /// </summary>
        private decimal idtransped2562;
        [XmlElement(ElementName = "IDTRANSPED2562", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Idtransped2562
        {
            get { return  idtransped2562; }
            set {  idtransped2562 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQNFE2562
        /// Comentário: Indica o número sequencial da nota fisca de entrada a ser exportado.
        /// </summary>
        private decimal seqnfe2562;
        [XmlElement(ElementName = "SEQNFE2562", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Seqnfe2562
        {
            get { return  seqnfe2562; }
            set {  seqnfe2562 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQPED2562
        /// Comentário: Indica o número sequencial do pedido a ser exportado.
        /// </summary>
        private decimal seqped2562;
        [XmlElement(ElementName = "SEQPED2562", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Seqped2562
        {
            get { return  seqped2562; }
            set {  seqped2562 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCIntegracaoparametro()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINTEGRACAOPARAMETRO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCIntegracaoparametro> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCIntegracaoparametro>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCIntegracaoparametro> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCIntegracaoparametro>(where);
        }

        #endregion
    }
}
