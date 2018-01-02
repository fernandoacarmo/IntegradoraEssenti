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
    /// Classe referente a tabela PCBairrodeliv
    /// </summary>
    [XmlType("PCBAIRRODELIV")]
    public class PCBairrodeliv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Coment�rio: Nome do bairro de entrega
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Bairro
        {
            get { return  bairro; }
            set {  bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADE
        /// Coment�rio: C�digo da Cidade
        /// </summary>
        private decimal codcidade;
        [XmlElement(ElementName = "CODCIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcidade
        {
            get { return  codcidade; }
            set {  codcidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da Filial
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
        /// Propriedade referente ao campo: CODFUNCINATIVO
        /// Coment�rio: C�digo do Funcion�rio que inativou o cadastro
        /// </summary>
        private decimal codfuncinativo;
        [XmlElement(ElementName = "CODFUNCINATIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncinativo
        {
            get { return  codfuncinativo; }
            set {  codfuncinativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: Codigo sequencial do bairro
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINATIVO
        /// Coment�rio: Data que o cadastro foi inativado
        /// </summary>
        private DateTime? dtinativo;
        [XmlElement(ElementName = "DTINATIVO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinativo
        {
            get { return  dtinativo; }
            set {  dtinativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOINATIVO
        /// Coment�rio: Motivo da inativa��o
        /// </summary>
        private string motivoinativo;
        [XmlElement(ElementName = "MOTIVOINATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Motivoinativo
        {
            get { return  motivoinativo; }
            set {  motivoinativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Coment�rio: 
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: A - Ativo; I - Inativo
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Coment�rio: UF
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTXENTREGA
        /// Coment�rio: Valor da Taxa de Entrega
        /// </summary>
        private decimal vltxentrega;
        [XmlElement(ElementName = "VLTXENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Vltxentrega
        {
            get { return  vltxentrega; }
            set {  vltxentrega = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCBairrodeliv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBAIRRODELIV";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBairrodeliv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBairrodeliv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCBairrodeliv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBairrodeliv>(where);
        }

        #endregion
    }
}
