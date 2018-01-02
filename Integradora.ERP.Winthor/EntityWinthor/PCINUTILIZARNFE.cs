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
    /// Classe referente a tabela PCInutilizarnfe
    /// </summary>
    [XmlType("PCINUTILIZARNFE")]
    public class PCInutilizarnfe : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CHAVENFE
        /// Comentário: Chave de acesso da Nfe
        /// </summary>
        private string chavenfe;
        [XmlElement(ElementName = "CHAVENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Chavenfe
        {
            get { return  chavenfe; }
            set {  chavenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINUTILIZACAO
        /// Comentário: Data da inutilização efetiva.
        /// </summary>
        private DateTime? dtinutilizacao;
        [XmlElement(ElementName = "DTINUTILIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinutilizacao
        {
            get { return  dtinutilizacao; }
            set {  dtinutilizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANC
        /// Comentário: Data de lançamento para inutilização.
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTENFE
        /// Comentário: Número do Lote
        /// </summary>
        private string numlotenfe;
        [XmlElement(ElementName = "NUMLOTENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlotenfe
        {
            get { return  numlotenfe; }
            set {  numlotenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: Número da nota fiscal eletrônica inutilizada.
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Comentário: Número da transação.
        /// </summary>
        private decimal numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransacao
        {
            get { return  numtransacao; }
            set {  numtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECIBONFE
        /// Comentário: Número do Recibo do Sefaz
        /// </summary>
        private string recibonfe;
        [XmlElement(ElementName = "RECIBONFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Recibonfe
        {
            get { return  recibonfe; }
            set {  recibonfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: Série da NF-e inutilizada.
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMOV
        /// Comentário: Tipo da movimentação.
        /// </summary>
        private string tipomov;
        [XmlElement(ElementName = "TIPOMOV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomov
        {
            get { return  tipomov; }
            set {  tipomov = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCInutilizarnfe()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINUTILIZARNFE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCInutilizarnfe> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCInutilizarnfe>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCInutilizarnfe> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCInutilizarnfe>(where);
        }

        #endregion
    }
}
