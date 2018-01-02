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
    /// Classe referente a tabela PCServicoedifornec
    /// </summary>
    [XmlType("PCSERVICOEDIFORNEC")]
    public class PCServicoedifornec : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�digo do Fornecedor
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSERVICOEDI
        /// Coment�rio: C�digo do Servi�o de EDI
        /// </summary>
        private decimal codservicoedi;
        [XmlElement(ElementName = "CODSERVICOEDI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codservicoedi
        {
            get { return  codservicoedi; }
            set {  codservicoedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CXPOSTALDESTIN
        /// Coment�rio: Caixa Postal do Destinat�rio
        /// </summary>
        private string cxpostaldestin;
        [XmlElement(ElementName = "CXPOSTALDESTIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,35)]
        public string Cxpostaldestin
        {
            get { return  cxpostaldestin; }
            set {  cxpostaldestin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRETORIO
        /// Coment�rio: Diret�rio
        /// </summary>
        private string diretorio;
        [XmlElement(ElementName = "DIRETORIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Diretorio
        {
            get { return  diretorio; }
            set {  diretorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSUBDIRFIL
        /// Coment�rio: Tipo Sub-Diret�rio da Filial
        /// </summary>
        private string tiposubdirfil;
        [XmlElement(ElementName = "TIPOSUBDIRFIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiposubdirfil
        {
            get { return  tiposubdirfil; }
            set {  tiposubdirfil = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCServicoedifornec()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSERVICOEDIFORNEC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCServicoedifornec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCServicoedifornec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCServicoedifornec> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCServicoedifornec>(where);
        }

        #endregion
    }
}
