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
        /// Comentário: Código do Fornecedor
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
        /// Comentário: Código do Serviço de EDI
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
        /// Comentário: Caixa Postal do Destinatário
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
        /// Comentário: Diretório
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
        /// Comentário: Tipo Sub-Diretório da Filial
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCServicoedifornec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCServicoedifornec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
