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
    /// Classe referente a tabela PCEquifax
    /// </summary>
    [XmlType("PCEQUIFAX")]
    public class PCEquifax : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CNPJ
        /// Comentário: CPF/CNPJ do cliente
        /// </summary>
        private string cnpj;
        [XmlElement(ElementName = "CNPJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Cnpj
        {
            get { return  cnpj; }
            set {  cnpj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Código do Cliente Utilizado na Consulta
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Comentário: Funcionário que executou a pesquisa
        /// </summary>
        private string codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORA
        /// Comentário: Data/Hora Execução da Consulta
        /// </summary>
        private DateTime? datahora;
        [XmlElement(ElementName = "DATAHORA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datahora
        {
            get { return  datahora; }
            set {  datahora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Comentário: Identificador do Registro
        /// </summary>
        private decimal id;
        [XmlElement(ElementName = "ID", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public decimal Id
        {
            get { return  id; }
            set {  id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDTIPOPRODUTO
        /// Comentário: Código do produto da Equifax
        /// </summary>
        private decimal idtipoproduto;
        [XmlElement(ElementName = "IDTIPOPRODUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Idtipoproduto
        {
            get { return  idtipoproduto; }
            set {  idtipoproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMETIPOPRODUTO
        /// Comentário: Descrição do Produto da Equifax
        /// </summary>
        private string nometipoproduto;
        [XmlElement(ElementName = "NOMETIPOPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nometipoproduto
        {
            get { return  nometipoproduto; }
            set {  nometipoproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: XML
        /// Comentário: XML de retorno da consulta
        /// </summary>
        private string xml;
        [XmlElement(ElementName = "XML", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Xml
        {
            get { return  xml; }
            set {  xml = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEquifax()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEQUIFAX";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEquifax> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEquifax>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEquifax> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEquifax>(where);
        }

        #endregion
    }
}
