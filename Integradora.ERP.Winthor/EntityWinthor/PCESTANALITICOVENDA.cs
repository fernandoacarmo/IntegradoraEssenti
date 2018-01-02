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
    /// Classe referente a tabela PCEstanaliticovenda
    /// </summary>
    [XmlType("PCESTANALITICOVENDA")]
    public class PCEstanaliticovenda : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALESTOQUE
        /// Comentário: O código da filial onde o estoque foi/será reservado.
        /// </summary>
        private string codfilialestoque;
        [XmlElement(ElementName = "CODFILIALESTOQUE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilialestoque
        {
            get { return  codfilialestoque; }
            set {  codfilialestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Quantidade reservada.
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
        /// Propriedade referente ao campo: DATA
        /// Comentário: Código do produto usado na reserva.
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Comentário: O número da Ordem de serviço usada na reserva.
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: O número do pedido usado na reserva.
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: A posição do pedido durante a reserva.
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSAVULSA
        /// Comentário: O número da transação de Ordem de serviço avulsa usada na reserva.
        /// </summary>
        private decimal numtransavulsa;
        [XmlElement(ElementName = "NUMTRANSAVULSA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransavulsa
        {
            get { return  numtransavulsa; }
            set {  numtransavulsa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAOEST
        /// Comentário: Data da reserva.
        /// </summary>
        private string posicaoest;
        [XmlElement(ElementName = "POSICAOEST", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Posicaoest
        {
            get { return  posicaoest; }
            set {  posicaoest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAOPED
        /// Comentário: A posição em que o estoque se encontra. Existe apenas duas posições para o estoque duratne a venda "R - Para reservado" e "P - Para pendente".
        /// </summary>
        private string posicaoped;
        [XmlElement(ElementName = "POSICAOPED", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Posicaoped
        {
            get { return  posicaoped; }
            set {  posicaoped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: Número de sequencia do item no pedido.
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Comentário: Rotina que lançou o resgistro.
        /// </summary>
        private string rotinalanc;
        [XmlElement(ElementName = "ROTINALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Rotinalanc
        {
            get { return  rotinalanc; }
            set {  rotinalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINAULTALT
        /// Comentário: Rotina que fez a ultima alteração do registro.
        /// </summary>
        private string rotinaultalt;
        [XmlElement(ElementName = "ROTINAULTALT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Rotinaultalt
        {
            get { return  rotinaultalt; }
            set {  rotinaultalt = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEstanaliticovenda()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCESTANALITICOVENDA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEstanaliticovenda> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEstanaliticovenda>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEstanaliticovenda> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEstanaliticovenda>(where);
        }

        #endregion
    }
}
