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
    /// Classe referente a tabela PCServicoedifil
    /// </summary>
    [XmlType("PCSERVICOEDIFIL")]
    public class PCServicoedifil : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da Filial
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALVAN
        /// Comentário: Código da Filial na VAN
        /// </summary>
        private string codfilialvan;
        [XmlElement(ElementName = "CODFILIALVAN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codfilialvan
        {
            get { return  codfilialvan; }
            set {  codfilialvan = value; }
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
        /// Propriedade referente ao campo: CXPOSTALREMET
        /// Comentário: Caixa Postal do Remetente
        /// </summary>
        private string cxpostalremet;
        [XmlElement(ElementName = "CXPOSTALREMET", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,35)]
        public string Cxpostalremet
        {
            get { return  cxpostalremet; }
            set {  cxpostalremet = value; }
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

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCServicoedifil()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSERVICOEDIFIL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCServicoedifil> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCServicoedifil>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCServicoedifil> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCServicoedifil>(where);
        }

        #endregion
    }
}
