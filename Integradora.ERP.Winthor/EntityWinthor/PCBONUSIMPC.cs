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
    /// Classe referente a tabela PCBonusimpc
    /// </summary>
    [XmlType("PCBONUSIMPC")]
    public class PCBonusimpc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Filial
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
        /// Propriedade referente ao campo: CODFUNCBONUS
        /// Comentário: Funcionario que Fez o Bonus
        /// </summary>
        private decimal codfuncbonus;
        [XmlElement(ElementName = "CODFUNCBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncbonus
        {
            get { return  codfuncbonus; }
            set {  codfuncbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: Data do Cancelamento do Bonus
        /// </summary>
        private DateTime? dtcancel;
        [XmlElement(ElementName = "DTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancel
        {
            get { return  dtcancel; }
            set {  dtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHA
        /// Comentário: Data do Fechamento do Bonus
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
        /// Propriedade referente ao campo: DTMONTAGEM
        /// Comentário: Data da Montagem
        /// </summary>
        private DateTime? dtmontagem;
        [XmlElement(ElementName = "DTMONTAGEM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtmontagem
        {
            get { return  dtmontagem; }
            set {  dtmontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMITIDO
        /// Comentário: Se foi emitido ou não
        /// </summary>
        private string emitido;
        [XmlElement(ElementName = "EMITIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emitido
        {
            get { return  emitido; }
            set {  emitido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Comentário: Numero do Bonus
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Observação do bonus
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOTOTAL
        /// Comentário: Peso Total do Bonus
        /// </summary>
        private decimal pesototal;
        [XmlElement(ElementName = "PESOTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pesototal
        {
            get { return  pesototal; }
            set {  pesototal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDIDO
        /// Comentário: Quantidade do pedido
        /// </summary>
        private decimal qtpedido;
        [XmlElement(ElementName = "QTPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtpedido
        {
            get { return  qtpedido; }
            set {  qtpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORTOTAL
        /// Comentário: Valor Total do Bonus
        /// </summary>
        private decimal valortotal;
        [XmlElement(ElementName = "VALORTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valortotal
        {
            get { return  valortotal; }
            set {  valortotal = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCBonusimpc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBONUSIMPC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCBonusimpc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBonusimpc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCBonusimpc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBonusimpc>(where);
        }

        #endregion
    }
}
