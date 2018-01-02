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
    /// Classe referente a tabela PCInutilizarcte
    /// </summary>
    [XmlType("PCINUTILIZARCTE")]
    public class PCInutilizarcte : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CHAVECTE
        /// Coment�rio: Chave de acesso do CTE
        /// </summary>
        private string chavecte;
        [XmlElement(ElementName = "CHAVECTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Chavecte
        {
            get { return  chavecte; }
            set {  chavecte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINUTILIZACAO
        /// Coment�rio: Data de inutiliza��o na SEFAZ
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
        /// Coment�rio: Data de lan�amento
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
        /// Propriedade referente ao campo: NUMCTE
        /// Coment�rio: N�mero do CTE sem retorno SEFAZ.
        /// </summary>
        private decimal numcte;
        [XmlElement(ElementName = "NUMCTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Numcte
        {
            get { return  numcte; }
            set {  numcte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTECTE
        /// Coment�rio: N�mero do lote
        /// </summary>
        private string numlotecte;
        [XmlElement(ElementName = "NUMLOTECTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlotecte
        {
            get { return  numlotecte; }
            set {  numlotecte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Coment�rio: N�mero da transa��o
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
        /// Propriedade referente ao campo: RECIBOCTE
        /// Coment�rio: N�mero do recibo SEFAZ
        /// </summary>
        private string recibocte;
        [XmlElement(ElementName = "RECIBOCTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Recibocte
        {
            get { return  recibocte; }
            set {  recibocte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Coment�rio: S�rio do CTE sem retorno SEFAZ.
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
        /// Coment�rio: Tipo da movimenta��o
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

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCInutilizarcte()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINUTILIZARCTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCInutilizarcte> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCInutilizarcte>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCInutilizarcte> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCInutilizarcte>(where);
        }

        #endregion
    }
}
