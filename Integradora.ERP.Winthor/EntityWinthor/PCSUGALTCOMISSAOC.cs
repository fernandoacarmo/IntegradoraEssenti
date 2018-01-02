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
    /// Classe referente a tabela PCSugaltcomissaoc
    /// </summary>
    [XmlType("PCSUGALTCOMISSAOC")]
    public class PCSugaltcomissaoc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODALTERACAO
        /// Coment�rio: Indica o c�digo da altera��o de sugest�o gerada.
        /// </summary>
        private decimal codalteracao;
        [XmlElement(ElementName = "CODALTERACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codalteracao
        {
            get { return  codalteracao; }
            set {  codalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Indica o c�digo da filial para a sugest�o de altera��o para comiss�o.
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
        /// Propriedade referente ao campo: CODFUNCFECHA
        /// Coment�rio: Indica o c�digo do usu�rio respons�vel por realizar o fechamento da sugest�o.
        /// </summary>
        private decimal codfuncfecha;
        [XmlElement(ElementName = "CODFUNCFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfecha
        {
            get { return  codfuncfecha; }
            set {  codfuncfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Coment�rio: Indica o c�digo do motorista do carregamento da nota fiscal da sugest�o de altera��o para comiss�o.
        /// </summary>
        private decimal codmotorista;
        [XmlElement(ElementName = "CODMOTORISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmotorista
        {
            get { return  codmotorista; }
            set {  codmotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: Indica o c�digo do RCA da nota fiscal da sugest�o de altera��o para comiss�o.
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Indica a data de gera��o da sugest�o.
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
        /// Propriedade referente ao campo: DTFECHA
        /// Coment�rio: Indica a data de fechamento da sugest�o.
        /// </summary>
        private DateTime? dtfecha;
        [XmlElement(ElementName = "DTFECHA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfecha
        {
            get { return  dtfecha; }
            set {  dtfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: Indica o n�mero da transa��o de venda da nota fiscal da sugest�o de altera��o para comiss�o.
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCLUCRO
        /// Coment�rio: Indica o percentual de lucro da nota fiscal da sugest�o de altera��o para comiss�o.
        /// </summary>
        private decimal perclucro;
        [XmlElement(ElementName = "PERCLUCRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perclucro
        {
            get { return  perclucro; }
            set {  perclucro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: Indica a situa��o da sugest�o valores poss�veis [P] Pendente, [R] Rejeitada e [A] Aprovada
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDIFMOT
        /// Coment�rio: Indica o valor da diferen�a ap�s a altera��o do percentual de comiss�o do motorista.
        /// </summary>
        private decimal valordifmot;
        [XmlElement(ElementName = "VALORDIFMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valordifmot
        {
            get { return  valordifmot; }
            set {  valordifmot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDIFRCA
        /// Coment�rio: Indica o valor da diferen�a ap�s a altera��o do percentual de comiss�o para RCA.
        /// </summary>
        private decimal valordifrca;
        [XmlElement(ElementName = "VALORDIFRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valordifrca
        {
            get { return  valordifrca; }
            set {  valordifrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALNF
        /// Coment�rio: Indica o valor total da nota fiscal da sugest�o de altera��o para comiss�o.
        /// </summary>
        private decimal vltotalnf;
        [XmlElement(ElementName = "VLTOTALNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltotalnf
        {
            get { return  vltotalnf; }
            set {  vltotalnf = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCSugaltcomissaoc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSUGALTCOMISSAOC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCSugaltcomissaoc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSugaltcomissaoc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCSugaltcomissaoc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSugaltcomissaoc>(where);
        }

        #endregion
    }
}
