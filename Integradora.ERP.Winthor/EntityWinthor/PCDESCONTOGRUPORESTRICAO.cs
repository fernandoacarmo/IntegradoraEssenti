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
    /// Classe referente a tabela PCDescontogruporestricao
    /// </summary>
    [XmlType("PCDESCONTOGRUPORESTRICAO")]
    public class PCDescontogruporestricao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODDESCONTO
        /// Comentário: Código da política de desconto
        /// </summary>
        private decimal coddesconto;
        [XmlElement(ElementName = "CODDESCONTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Coddesconto
        {
            get { return  coddesconto; }
            set {  coddesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOA
        /// Comentário: Indica o código alfanumerico da restrição.
        /// </summary>
        private string codigoa;
        [XmlElement(ElementName = "CODIGOA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,24)]
        public string Codigoa
        {
            get { return  codigoa; }
            set {  codigoa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGON
        /// Comentário: Indica o código numérico da restrição.
        /// </summary>
        private decimal codigon;
        [XmlElement(ElementName = "CODIGON", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codigon
        {
            get { return  codigon; }
            set {  codigon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Tipo  da restrição
        /// </summary>
        private decimal tipo;
        [XmlElement(ElementName = "TIPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDescontogruporestricao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESCONTOGRUPORESTRICAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDescontogruporestricao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDescontogruporestricao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDescontogruporestricao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDescontogruporestricao>(where);
        }

        #endregion
    }
}
