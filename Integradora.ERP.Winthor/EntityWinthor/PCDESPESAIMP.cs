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
    /// Classe referente a tabela PCDespesaimp
    /// </summary>
    [XmlType("PCDESPESAIMP")]
    public class PCDespesaimp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Coment�rio: C�digo da Conta Gerencial da Despesa de Importa��o.
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESPESA
        /// Coment�rio: C�digo da Despesa de Importa��o.
        /// </summary>
        private decimal coddespesa;
        [XmlElement(ElementName = "CODDESPESA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Coddespesa
        {
            get { return  coddespesa; }
            set {  coddespesa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSISCOMEX
        /// Coment�rio: C�digo SISCOMEX da Despesa de Importa��o.
        /// </summary>
        private decimal codsiscomex;
        [XmlElement(ElementName = "CODSISCOMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codsiscomex
        {
            get { return  codsiscomex; }
            set {  codsiscomex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o da Despesa de Importa��o.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVALOR
        /// Coment�rio: Percentual fixo para definir o valor da despesa
        /// </summary>
        private decimal percvalor;
        [XmlElement(ElementName = "PERCVALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percvalor
        {
            get { return  percvalor; }
            set {  percvalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESPESA
        /// Coment�rio: Tipo da Despesa de Importa��o.
        /// </summary>
        private decimal tipodespesa;
        [XmlElement(ElementName = "TIPODESPESA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Tipodespesa
        {
            get { return  tipodespesa; }
            set {  tipodespesa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORATEIO
        /// Coment�rio: Forma de Proporcionaliza� �o do custo da Despesa de Importa��o
        /// </summary>
        private decimal tiporateio;
        [XmlElement(ElementName = "TIPORATEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Tiporateio
        {
            get { return  tiporateio; }
            set {  tiporateio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Valor fixo da despesa de importa��o.
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDespesaimp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESPESAIMP";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDespesaimp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDespesaimp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDespesaimp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDespesaimp>(where);
        }

        #endregion
    }
}
