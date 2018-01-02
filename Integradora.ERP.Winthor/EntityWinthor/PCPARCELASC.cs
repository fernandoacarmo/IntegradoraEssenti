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
    /// Classe referente a tabela PCParcelasc
    /// </summary>
    [XmlType("PCPARCELASC")]
    public class PCParcelasc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALT
        /// Coment�rio: Funcion�rio que alterou o registro. 
        /// </summary>
        private decimal codfuncalt;
        [XmlElement(ElementName = "CODFUNCALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfuncalt
        {
            get { return  codfuncalt; }
            set {  codfuncalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCAD
        /// Coment�rio: Funcion�rio que cadastrou o registro. 
        /// </summary>
        private decimal codfunccad;
        [XmlElement(ElementName = "CODFUNCCAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfunccad
        {
            get { return  codfunccad; }
            set {  codfunccad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPARCELA
        /// Coment�rio: C�digo sequ�ncial. 
        /// </summary>
        private decimal codparcela;
        [XmlElement(ElementName = "CODPARCELA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codparcela
        {
            get { return  codparcela; }
            set {  codparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: Rotina que alterou/criou o registro. 
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o sobre o nome da parcela ou condi��o de pagamento. 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIABASE
        /// Coment�rio: De 1 a 30 dias quando for tipo PF. 
        /// </summary>
        private decimal diabase;
        [XmlElement(ElementName = "DIABASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diabase
        {
            get { return  diabase; }
            set {  diabase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIFPARCELA
        /// Coment�rio: Diferen�a da parcela ser� considera na: P-Primeira parcela ou U-Ultima parcela. 
        /// </summary>
        private string difparcela;
        [XmlElement(ElementName = "DIFPARCELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Difparcela
        {
            get { return  difparcela; }
            set {  difparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Data atual do cadastro do registro. 
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
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: Quando tentar excluir, e j� existir dados, gravar a data de exclus�o para desabilitar esta condi��o. 
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDMAXPARCELA
        /// Coment�rio: N�mero de parcelas que vir� ser defino pelo cadastro da PCConsum, podendo ser apenas menor que est�. 
        /// </summary>
        private decimal qtdmaxparcela;
        [XmlElement(ElementName = "QTDMAXPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtdmaxparcela
        {
            get { return  qtdmaxparcela; }
            set {  qtdmaxparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPARCELA
        /// Coment�rio: Prazo determinado) / AV (A vista) / PF (Prazo Fixo). 
        /// </summary>
        private string tipoparcela;
        [XmlElement(ElementName = "TIPOPARCELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoparcela
        {
            get { return  tipoparcela; }
            set {  tipoparcela = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCParcelasc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPARCELASC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCParcelasc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCParcelasc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCParcelasc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCParcelasc>(where);
        }

        #endregion
    }
}
