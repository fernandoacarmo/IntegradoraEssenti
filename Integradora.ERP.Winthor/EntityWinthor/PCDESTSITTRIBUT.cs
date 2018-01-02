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
    /// Classe referente a tabela PCDestsittribut
    /// </summary>
    [XmlType("PCDESTSITTRIBUT")]
    public class PCDestsittribut : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT
        /// Comentário: Campo que especifica a situação tributária. |Campo do tipo caracter, de tamanho 3.
        /// </summary>
        private string sittribut;
        [XmlElement(ElementName = "SITTRIBUT", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public string Sittribut
        {
            get { return  sittribut; }
            set {  sittribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEICMS
        /// Comentário: O valor da base de cálculo do ICMS redizida será destacado na coluna Outras ou Isento do Livro Fiscal
        /// </summary>
        private string vlbaseicms;
        [XmlElement(ElementName = "VLBASEICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vlbaseicms
        {
            get { return  vlbaseicms; }
            set {  vlbaseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISENTAS
        /// Comentário: Quando tiver o valor "S", identifica onde deve ser gerado a diferença de redução de  base de  calculo ou outro valor de situação tributária. |Campo do tipo caracter, de tamanho 1.
        /// </summary>
        private string vlisentas;
        [XmlElement(ElementName = "VLISENTAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vlisentas
        {
            get { return  vlisentas; }
            set {  vlisentas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRAS
        /// Comentário: Quando tiver o valor "S", identifica onde deve ser gerado a diferença de redução de  base de  calculo ou outro valor de situação tributária. |Campo do tipo caracter, de tamanho 1.
        /// </summary>
        private string vloutras;
        [XmlElement(ElementName = "VLOUTRAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vloutras
        {
            get { return  vloutras; }
            set {  vloutras = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDestsittribut()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESTSITTRIBUT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDestsittribut> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDestsittribut>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDestsittribut> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDestsittribut>(where);
        }

        #endregion
    }
}
