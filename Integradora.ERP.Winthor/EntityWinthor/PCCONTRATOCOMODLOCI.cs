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
    /// Classe referente a tabela PCContratocomodloci
    /// </summary>
    [XmlType("PCCONTRATOCOMODLOCI")]
    public class PCContratocomodloci : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEQUIPAMENTO
        /// Coment�rio: C�digo do equipamento comodatado.
        /// </summary>
        private decimal codequipamento;
        [XmlElement(ElementName = "CODEQUIPAMENTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codequipamento
        {
            get { return  codequipamento; }
            set {  codequipamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: Indica o c�digo do produto.
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
        /// Propriedade referente ao campo: DTDEVOLUCAO
        /// Coment�rio: Data de devolu��o do item.
        /// </summary>
        private DateTime? dtdevolucao;
        [XmlElement(ElementName = "DTDEVOLUCAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdevolucao
        {
            get { return  dtdevolucao; }
            set {  dtdevolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTRATO
        /// Coment�rio: Indica o n�mero do contrato.
        /// </summary>
        private decimal numcontrato;
        [XmlElement(ElementName = "NUMCONTRATO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcontrato
        {
            get { return  numcontrato; }
            set {  numcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Coment�rio: Indica a transa��o de entrada.
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: Indica a transa��o de venda.
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLLOCACAO
        /// Coment�rio: Indica o valor de loca��o do produto.
        /// </summary>
        private decimal vllocacao;
        [XmlElement(ElementName = "VLLOCACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vllocacao
        {
            get { return  vllocacao; }
            set {  vllocacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCContratocomodloci()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTRATOCOMODLOCI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCContratocomodloci> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContratocomodloci>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCContratocomodloci> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContratocomodloci>(where);
        }

        #endregion
    }
}
