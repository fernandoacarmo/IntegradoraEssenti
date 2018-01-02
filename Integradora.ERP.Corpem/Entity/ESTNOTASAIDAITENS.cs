using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.ERP.Corpem.Inherited;
using Integradora.ERP.Corpem.Persistente;

namespace Integradora.ERP.Corpem.Entity
{
    /// <summary>
    /// Classe referente a tabela ESTNotasaidaitens
    /// </summary>
    [XmlType("ESTNOTASAIDAITENS")]
    public class ESTNotasaidaitens : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Comentário: 
        /// </summary>
        private Int32 codproduto;
        [XmlElement(ElementName = "CODPRODUTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public Int32 Codproduto
        {
            get { return  codproduto; }
            set {  codproduto = value; }
        }

  
       
        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private Int32 numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public Int32 Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Comentário: 
        /// </summary>
        private Int64 numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public Int64 Numtransacao
        {
            get { return  numtransacao; }
            set {  numtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTATENDIDO
        /// Comentário: 
        /// </summary>
        private decimal qtatendido;
        [XmlElement(ElementName = "QTATENDIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Qtatendido
        {
            get { return  qtatendido; }
            set {  qtatendido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCORTE
        /// Comentário: 
        /// </summary>
        private decimal qtcorte;
        [XmlElement(ElementName = "QTCORTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Qtcorte
        {
            get { return  qtcorte; }
            set {  qtcorte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADE
        /// Comentário: 
        /// </summary>
        private decimal quantidade;
        [XmlElement(ElementName = "QUANTIDADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Quantidade
        {
            get { return  quantidade; }
            set {  quantidade = value; }
        }

       
        /// <summary>
        /// Propriedade referente ao campo: VLUNITARIO
        /// Comentário: 
        /// </summary>
        private decimal vlunitario;
        [XmlElement(ElementName = "VLUNITARIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vlunitario
        {
            get { return  vlunitario; }
            set {  vlunitario = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Comentário: 
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Vltotal
        {
            get { return vltotal; }
            set { vltotal = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTNotasaidaitens()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTNOTASAIDAITENS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTNotasaidaitens> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTNotasaidaitens.GetStringConnection());
            return ba.Listar<ESTNotasaidaitens>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTNotasaidaitens> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTNotasaidaitens.GetStringConnection());
            return ba.Existe<ESTNotasaidaitens>(where);
        }

        #endregion
    }
}
