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
    /// Classe referente a tabela PCSugaltcomissaoi
    /// </summary>
    [XmlType("PCSUGALTCOMISSAOI")]
    public class PCSugaltcomissaoi : OracleTable
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
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: Indica o c�digo do produto para a sugest�o de altera��o para comiss�o.
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
        /// Propriedade referente ao campo: PERCLUCRO
        /// Coment�rio: Indica o percentual de lucro por produto da nota fiscal da sugest�o de altera��o para comiss�o.
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
        /// Propriedade referente ao campo: PERCOMMOT
        /// Coment�rio: Indica o percentual de comiss�o do motorista do item da nota fiscal da sugest�o de altera��o para comiss�o.
        /// </summary>
        private decimal percommot;
        [XmlElement(ElementName = "PERCOMMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percommot
        {
            get { return  percommot; }
            set {  percommot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMOTNOVO
        /// Coment�rio: Indica o novo percentual de comiss�o do Motorista da nota fiscal da sugest�o de altera��o para comiss�o.
        /// </summary>
        private decimal percommotnovo;
        [XmlElement(ElementName = "PERCOMMOTNOVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percommotnovo
        {
            get { return  percommotnovo; }
            set {  percommotnovo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMRCA
        /// Coment�rio: Indica o percentual de comiss�o por produto do RCA da nota fiscal da sugest�o de altera��o para comiss�o.
        /// </summary>
        private decimal percomrca;
        [XmlElement(ElementName = "PERCOMRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomrca
        {
            get { return  percomrca; }
            set {  percomrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMRCANOVO
        /// Coment�rio: Indica o novo percentual de comiss�o por produto do RCA da nota fiscal da sugest�o de altera��o para comiss�o.
        /// </summary>
        private decimal percomrcanovo;
        [XmlElement(ElementName = "PERCOMRCANOVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomrcanovo
        {
            get { return  percomrcanovo; }
            set {  percomrcanovo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNIT
        /// Coment�rio: Indica o valor unit�rio do produto na nota fiscal da sugest�o de altera��o para comiss�o.
        /// </summary>
        private decimal punit;
        [XmlElement(ElementName = "PUNIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Punit
        {
            get { return  punit; }
            set {  punit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: Indica a quantidade do produto na nota fiscal da sugest�o de altera��o para comiss�o.
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDIFMOT
        /// Coment�rio: Indica o valor da diferen�a por produto referente � sugest�o de altera��o na comiss�o do motorista.
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
        /// Coment�rio: Indica o valor da diferen�a por produto referente � sugest�o de altera��o na comiss�o do RCA.
        /// </summary>
        private decimal valordifrca;
        [XmlElement(ElementName = "VALORDIFRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valordifrca
        {
            get { return  valordifrca; }
            set {  valordifrca = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCSugaltcomissaoi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSUGALTCOMISSAOI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCSugaltcomissaoi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSugaltcomissaoi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCSugaltcomissaoi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSugaltcomissaoi>(where);
        }

        #endregion
    }
}
