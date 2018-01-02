using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.Views
{
    /// <summary>
    /// Classe referente ao select VWFormulacao
    /// </summary>
    [XmlType("VWFORMULACAO")]
    public class VWFormulacao : OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWFormulacao()
        {
 
        }
        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWFormulacao> Listar(string where)
        {
            string filtro = where.ToUpper().Replace("ROWID", "OID");
            Persistencia ba = new Persistencia(VWFormulacao.GetStringConnection());
            return ba.Listar<VWFormulacao>(GetSelect(), filtro);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWFormulacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(VWEmbalagens.GetStringConnection());
            return ba.Existe<VWEmbalagens>(where);
        }

        /// <summary>
        /// Retorna o select de obteção dos registros
        /// </summary>
        public static string GetSelect()
        {
            return @"SELECT A.*
                       FROM (SELECT PCFORMPROD.CODFILIAL
                                  , PCFORMPROD.ROWID OID
                                  , PCFORMPROD.CODPRODACAB
                                  , KIT.CODAUXILIAR CODAUXILIARACAB
                                  , KIT.DESCRICAO DESCRICAOACAB
                                  , KIT.CODFORNEC
                                  , NVL(PCEMBALAGEM.PVENDAWEB, NVL(PCEMBALAGEM.PVENDA, 0)) PVENDA
                                  , NVL(PCEMBALAGEM.POFERTAWEB, NVL(PCEMBALAGEM.POFERTA, 0)) POFERTA
                                  , PCFORMPROD.QTPRODACAB
                                  , PCFORMPROD.CODPRODMP
                                  , NVL(PCFORMPROD.CODAUXILIARMP, MATERIAPRIMA.CODAUXILIAR) CODAUXILIARMP
                                  , MATERIAPRIMA.DESCRICAO DESCRICAOMP
                                  , PCFORMPROD.QTPRODMP
                               FROM PCFORMPROD
                                  , PCPRODUT KIT
                                  , PCPRODUT MATERIAPRIMA
                                  , PCEMBALAGEM
                              WHERE PCFORMPROD.CODPRODACAB = KIT.CODPROD
                                AND PCFORMPROD.CODPRODMP = MATERIAPRIMA.CODPROD
                                AND PCFORMPROD.CODPRODACAB = PCEMBALAGEM.CODPROD
                                AND PCFORMPROD.CODFILIAL   = PCEMBALAGEM.CODFILIAL
                                AND KIT.CODAUXILIAR = PCEMBALAGEM.CODAUXILIAR) A
                        WHERE 1=1 
";
        }
        #endregion

        #region Atributos
        /// <summary>
        /// Propriedade referente ao campo: CODPRODACAB
        /// Comentário: 
        /// </summary>
        private decimal codprodacab;
        [XmlElement(ElementName = "CODPRODACAB", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 6)]
        public decimal Codprodacab
        {
            get { return codprodacab; }
            set { codprodacab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODMP
        /// Comentário: 
        /// </summary>
        private decimal codprodmp;
        [XmlElement(ElementName = "CODPRODMP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 6)]
        public decimal Codprodmp
        {
            get { return codprodmp; }
            set { codprodmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string Codfilial
        {
            get { return codfilial; }
            set { codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIARACAB
        /// Comentário: 
        /// </summary>
        private decimal codauxiliaracab;
        [XmlElement(ElementName = "CODAUXILIARACAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Codauxiliaracab
        {
            get { return codauxiliaracab; }
            set { codauxiliaracab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIARMP
        /// Comentário: 
        /// </summary>
        private decimal codauxiliarmp;
        [XmlElement(ElementName = "CODAUXILIARMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Codauxiliarmp
        {
            get { return codauxiliarmp; }
            set { codauxiliarmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOACAB
        /// Comentário: Descrição do Produto
        /// </summary>
        private string descricaoacab;
        [XmlElement(ElementName = "DESCRICAOACAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Descricaoacab
        {
            get { return descricaoacab; }
            set { descricaoacab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOMP
        /// Comentário: Descrição do Produto
        /// </summary>
        private string descricaomp;
        [XmlElement(ElementName = "DESCRICAOMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Descricaomp
        {
            get { return descricaomp; }
            set { descricaomp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODACAB
        /// Comentário: Quantidade do estoque gerencial
        /// </summary>
        private decimal qtprodacab;
        [XmlElement(ElementName = "QTPRODACAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtprodacab
        {
            get { return qtprodacab; }
            set { qtprodacab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODAMP
        /// Comentário: Quantidade do estoque gerencial
        /// </summary>
        private decimal qtprodamp;
        [XmlElement(ElementName = "QTPRODAMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtprodamp
        {
            get { return qtprodamp; }
            set { qtprodamp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codfornec
        {
            get { return codfornec; }
            set { codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Comentário: 
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 12)]
        public decimal Pvenda
        {
            get { return pvenda; }
            set { pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTA
        /// Comentário: 
        /// </summary>
        private decimal poferta;
        [XmlElement(ElementName = "POFERTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 12)]
        public decimal Poferta
        {
            get { return poferta; }
            set { poferta = value; }
        }

        #endregion
    }
}
