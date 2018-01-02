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
    /// Classe referente a tabela PCEditaisitens
    /// </summary>
    [XmlType("PCEDITAISITENS")]
    public class PCEditaisitens : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEDITAL
        /// Coment�rio: C�digo edital.
        /// </summary>
        private decimal codedital;
        [XmlElement(ElementName = "CODEDITAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Codedital
        {
            get { return  codedital; }
            set {  codedital = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMARCA
        /// Coment�rio: C�digo Marca.
        /// </summary>
        private decimal codmarca;
        [XmlElement(ElementName = "CODMARCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmarca
        {
            get { return  codmarca; }
            set {  codmarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo produto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUNIDADE
        /// Coment�rio: C�digo unidade.
        /// </summary>
        private string codunidade;
        [XmlElement(ElementName = "CODUNIDADE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codunidade
        {
            get { return  codunidade; }
            set {  codunidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO_AUXILIAR
        /// Coment�rio: Descri��o auxiliar.
        /// </summary>
        private string descricao_auxiliar;
        [XmlElement(ElementName = "DESCRICAO_AUXILIAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Descricao_Auxiliar
        {
            get { return  descricao_auxiliar; }
            set {  descricao_auxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOTE
        /// Coment�rio: Lote.
        /// </summary>
        private string lote;
        [XmlElement(ElementName = "LOTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public string Lote
        {
            get { return  lote; }
            set {  lote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO_ITEM
        /// Coment�rio: Numero do Item.
        /// </summary>
        private decimal numero_item;
        [XmlElement(ElementName = "NUMERO_ITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Numero_Item
        {
            get { return  numero_item; }
            set {  numero_item = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADE
        /// Coment�rio: Quantidade.
        /// </summary>
        private decimal quantidade;
        [XmlElement(ElementName = "QUANTIDADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Quantidade
        {
            get { return  quantidade; }
            set {  quantidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO_DESCRICAO_AUXILIAR
        /// Coment�rio: Tipo da descri��o auxiliar.
        /// </summary>
        private string tipo_descricao_auxiliar;
        [XmlElement(ElementName = "TIPO_DESCRICAO_AUXILIAR", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipo_Descricao_Auxiliar
        {
            get { return  tipo_descricao_auxiliar; }
            set {  tipo_descricao_auxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAR
        /// Coment�rio: Utilizar.
        /// </summary>
        private string utilizar;
        [XmlElement(ElementName = "UTILIZAR", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Utilizar
        {
            get { return  utilizar; }
            set {  utilizar = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEditaisitens()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEDITAISITENS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEditaisitens> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEditaisitens>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEditaisitens> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEditaisitens>(where);
        }

        #endregion
    }
}
