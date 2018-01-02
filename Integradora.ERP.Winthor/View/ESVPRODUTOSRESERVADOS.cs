using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a tabela Esvprodutosreservados
    /// </summary>
    [XmlType("ESVPRODUTOSRESERVADOS")]
    public class Esvprodutosreservados : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA
        /// Comentário: 
        /// </summary>
        private decimal codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMPRESA
        /// Comentário: 
        /// </summary>
        private string codempresa;
        [XmlElement(ElementName = "CODEMPRESA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codempresa
        {
            get { return  codempresa; }
            set {  codempresa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Comentário: 
        /// </summary>
        private decimal codproduto;
        [XmlElement(ElementName = "CODPRODUTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codproduto
        {
            get { return  codproduto; }
            set {  codproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEM
        /// Comentário: 
        /// </summary>
        private string embalagem;
        [XmlElement(ElementName = "EMBALAGEM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public string Embalagem
        {
            get { return  embalagem; }
            set {  embalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQUEADA
        /// Comentário: 
        /// </summary>
        private decimal qtbloqueada;
        [XmlElement(ElementName = "QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtbloqueada
        {
            get { return  qtbloqueada; }
            set {  qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIFERENCA
        /// Comentário: 
        /// </summary>
        private decimal qtdiferenca;
        [XmlElement(ElementName = "QTDIFERENCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtdiferenca
        {
            get { return  qtdiferenca; }
            set {  qtdiferenca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEMBALAGEM
        /// Comentário: 
        /// </summary>
        private decimal qtembalagem;
        [XmlElement(ElementName = "QTEMBALAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtembalagem
        {
            get { return  qtembalagem; }
            set {  qtembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTOQUE
        /// Comentário: 
        /// </summary>
        private decimal qtestoque;
        [XmlElement(ElementName = "QTESTOQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtestoque
        {
            get { return  qtestoque; }
            set {  qtestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDIDOCOMPRA
        /// Comentário: 
        /// </summary>
        private decimal qtpedidocompra;
        [XmlElement(ElementName = "QTPEDIDOCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtpedidocompra
        {
            get { return  qtpedidocompra; }
            set {  qtpedidocompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERVADA
        /// Comentário: 
        /// </summary>
        private decimal qtreservada;
        [XmlElement(ElementName = "QTRESERVADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtreservada
        {
            get { return  qtreservada; }
            set {  qtreservada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERV_ESSENTI
        /// Comentário: 
        /// </summary>
        private decimal qtreserv_essenti;
        [XmlElement(ElementName = "QTRESERV_ESSENTI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtreserv_Essenti
        {
            get { return  qtreserv_essenti; }
            set {  qtreserv_essenti = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERV_PC
        /// Comentário: 
        /// </summary>
        private decimal qtreserv_pc;
        [XmlElement(ElementName = "QTRESERV_PC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtreserv_Pc
        {
            get { return  qtreserv_pc; }
            set {  qtreserv_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSALDOATUAL
        /// Comentário: 
        /// </summary>
        private decimal qtsaldoatual;
        [XmlElement(ElementName = "QTSALDOATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtsaldoatual
        {
            get { return  qtsaldoatual; }
            set {  qtsaldoatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSOMARESERVA
        /// Comentário: 
        /// </summary>
        private decimal qtsomareserva;
        [XmlElement(ElementName = "QTSOMARESERVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtsomareserva
        {
            get { return  qtsomareserva; }
            set {  qtsomareserva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE
        /// Comentário: 
        /// </summary>
        private string unidade;
        [XmlElement(ElementName = "UNIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidade
        {
            get { return  unidade; }
            set {  unidade = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Esvprodutosreservados()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVPRODUTOSRESERVADOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esvprodutosreservados> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvprodutosreservados.GetStringConnection());
            return ba.Listar<Esvprodutosreservados>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esvprodutosreservados> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvprodutosreservados.GetStringConnection());
            return ba.Existe<Esvprodutosreservados>(where);
        }

        #endregion
    }
}
