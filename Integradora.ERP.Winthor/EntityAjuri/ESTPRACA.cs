using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityAjuri
{
    /// <summary>
    /// Classe referente a tabela ESTPraca
    /// </summary>
    [XmlType("ESTPRACA")]
    public class ESTPraca : BaseAjuri
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODROTA
        /// Comentário: 
        /// </summary>
        private decimal codrota;
        [XmlElement(ElementName = "CODROTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codrota
        {
            get { return  codrota; }
            set {  codrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOENTREGA
        /// Comentário: 
        /// </summary>
        private decimal prazoentrega;
        [XmlElement(ElementName = "PRAZOENTREGA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public decimal Prazoentrega
        {
            get { return  prazoentrega; }
            set {  prazoentrega = value; }
        }


        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTPraca()
        {
            Inicializar();
            Prazoentrega = 3;
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTPRACA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTPraca> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTPraca.GetStringConnection());
            return ba.Listar<ESTPraca>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTPraca> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTPraca.GetStringConnection());
            return ba.Existe<ESTPraca>(where);
        }

        #endregion
    }
}
