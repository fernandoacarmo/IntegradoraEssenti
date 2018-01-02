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
    /// Classe referente a tabela PCDadosgenericos
    /// </summary>
    [XmlType("PCDADOSGENERICOS")]
    public class PCDadosgenericos : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAMPO
        /// Comentário: Nome do campo
        /// </summary>
        private string campo;
        [XmlElement(ElementName = "CAMPO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,30)]
        public string Campo
        {
            get { return  campo; }
            set {  campo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial
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
        /// Propriedade referente ao campo: CODREGISTRO
        /// Comentário: Código do registro
        /// </summary>
        private decimal codregistro;
        [XmlElement(ElementName = "CODREGISTRO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codregistro
        {
            get { return  codregistro; }
            set {  codregistro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREGISTROPAI
        /// Comentário: Código do registro pai
        /// </summary>
        private decimal codregistropai;
        [XmlElement(ElementName = "CODREGISTROPAI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codregistropai
        {
            get { return  codregistropai; }
            set {  codregistropai = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DADOSID
        /// Comentário: Identificador dos dados
        /// </summary>
        private string dadosid;
        [XmlElement(ElementName = "DADOSID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public string Dadosid
        {
            get { return  dadosid; }
            set {  dadosid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: Data do registro (período a qual vai pertencer)
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGISTRO
        /// Comentário: Identificador do registro
        /// </summary>
        private string registro;
        [XmlElement(ElementName = "REGISTRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Registro
        {
            get { return  registro; }
            set {  registro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCAMPO
        /// Comentário: Tipo do campo
        /// </summary>
        private string tipocampo;
        [XmlElement(ElementName = "TIPOCAMPO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocampo
        {
            get { return  tipocampo; }
            set {  tipocampo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR_DATA
        /// Comentário: Valor do campo, se tipo data
        /// </summary>
        private DateTime? valor_data;
        [XmlElement(ElementName = "VALOR_DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Valor_Data
        {
            get { return  valor_data; }
            set {  valor_data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR_NUM
        /// Comentário: Valor do campo, se tipo numerico
        /// </summary>
        private decimal valor_num;
        [XmlElement(ElementName = "VALOR_NUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Valor_Num
        {
            get { return  valor_num; }
            set {  valor_num = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR_TEXTO
        /// Comentário: Valor do campo, se tipo alfanumerico
        /// </summary>
        private string valor_texto;
        [XmlElement(ElementName = "VALOR_TEXTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Valor_Texto
        {
            get { return  valor_texto; }
            set {  valor_texto = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDadosgenericos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDADOSGENERICOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDadosgenericos> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDadosgenericos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDadosgenericos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDadosgenericos>(where);
        }

        #endregion
    }
}
