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
    /// Classe referente a tabela PCTransfdepdevol
    /// </summary>
    [XmlType("PCTRANSFDEPDEVOL")]
    public class PCTransfdepdevol : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALDESTINO
        /// Coment�rio: C�digo filial destino.
        /// </summary>
        private string codfilialdestino;
        [XmlElement(ElementName = "CODFILIALDESTINO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialdestino
        {
            get { return  codfilialdestino; }
            set {  codfilialdestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALORIGEM
        /// Coment�rio: Codigo da filial origem.
        /// </summary>
        private string codfilialorigem;
        [XmlElement(ElementName = "CODFILIALORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialorigem
        {
            get { return  codfilialorigem; }
            set {  codfilialorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: Codigo do produto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTTRANSF
        /// Coment�rio: Data de transferencia.
        /// </summary>
        private DateTime? dttransf;
        [XmlElement(ElementName = "DTTRANSF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dttransf
        {
            get { return  dttransf; }
            set {  dttransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: N�mero do lote.
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Coment�rio: Transa��o de entrada.
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
        /// Propriedade referente ao campo: NUMTRANSTRANSFENT
        /// Coment�rio: Numero de transa��o da transferencia entrada.
        /// </summary>
        private decimal numtranstransfent;
        [XmlElement(ElementName = "NUMTRANSTRANSFENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranstransfent
        {
            get { return  numtranstransfent; }
            set {  numtranstransfent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSTRANSFSAIDA
        /// Coment�rio: Numero de transa��o da transferencia saida.
        /// </summary>
        private decimal numtranstransfsaida;
        [XmlElement(ElementName = "NUMTRANSTRANSFSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranstransfsaida
        {
            get { return  numtranstransfsaida; }
            set {  numtranstransfsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: Transa��o de venda.
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
        /// Propriedade referente ao campo: QTTRANSF
        /// Coment�rio: Quantidade de transfer�ncia.
        /// </summary>
        private decimal qttransf;
        [XmlElement(ElementName = "QTTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qttransf
        {
            get { return  qttransf; }
            set {  qttransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSFCONT
        /// Coment�rio: Quantidade de transfer�ncia cont�bil.
        /// </summary>
        private decimal qttransfcont;
        [XmlElement(ElementName = "QTTRANSFCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qttransfcont
        {
            get { return  qttransfcont; }
            set {  qttransfcont = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCTransfdepdevol()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRANSFDEPDEVOL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCTransfdepdevol> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTransfdepdevol>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCTransfdepdevol> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTransfdepdevol>(where);
        }

        #endregion
    }
}
