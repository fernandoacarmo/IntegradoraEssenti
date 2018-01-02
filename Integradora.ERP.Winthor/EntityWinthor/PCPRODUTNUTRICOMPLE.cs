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
    /// Classe referente a tabela PCProdutnutricomple
    /// </summary>
    [XmlType("PCPRODUTNUTRICOMPLE")]
    public class PCProdutnutricomple : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Código auxiliar
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,16)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEINFNUTRI
        /// Comentário: Nome da informação nutricional
        /// </summary>
        private string nomeinfnutri;
        [XmlElement(ElementName = "NOMEINFNUTRI", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,60)]
        public string Nomeinfnutri
        {
            get { return  nomeinfnutri; }
            set {  nomeinfnutri = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORCAO
        /// Comentário: Porção da embalagem
        /// </summary>
        private string porcao;
        [XmlElement(ElementName = "PORCAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,35)]
        public string Porcao
        {
            get { return  porcao; }
            set {  porcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPORCAO
        /// Comentário: Quantidade da porção
        /// </summary>
        private decimal qtporcao;
        [XmlElement(ElementName = "QTPORCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtporcao
        {
            get { return  qtporcao; }
            set {  qtporcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNMEDIDA
        /// Comentário: Unidade de medida do componente nutricional
        /// </summary>
        private string unmedida;
        [XmlElement(ElementName = "UNMEDIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Unmedida
        {
            get { return  unmedida; }
            set {  unmedida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDIARIO
        /// Comentário: Valor diário recomendado
        /// </summary>
        private decimal valordiario;
        [XmlElement(ElementName = "VALORDIARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Valordiario
        {
            get { return  valordiario; }
            set {  valordiario = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCProdutnutricomple()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODUTNUTRICOMPLE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCProdutnutricomple> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdutnutricomple>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCProdutnutricomple> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdutnutricomple>(where);
        }

        #endregion
    }
}
