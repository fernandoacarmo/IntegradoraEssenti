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
    /// Classe referente a tabela PCRecomposicaoestoque
    /// </summary>
    [XmlType("PCRECOMPOSICAOESTOQUE")]
    public class PCRecomposicaoestoque : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEVENTO
        /// Coment�rio: C�digo referente ao tipo de evento
        /// </summary>
        private string codevento;
        [XmlElement(ElementName = "CODEVENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public string Codevento
        {
            get { return  codevento; }
            set {  codevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da Filial
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
        /// Propriedade referente ao campo: DIASESTOQUEMAX
        /// Coment�rio: Dias para calcular o estoque m�ximo que a empresa dever� manter do produto
        /// </summary>
        private decimal diasestoquemax;
        [XmlElement(ElementName = "DIASESTOQUEMAX", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public decimal Diasestoquemax
        {
            get { return  diasestoquemax; }
            set {  diasestoquemax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASESTOQUEMIN
        /// Coment�rio: Dias para calcular o estoque m�nimo que a empresa dever� manter do produto
        /// </summary>
        private decimal diasestoquemin;
        [XmlElement(ElementName = "DIASESTOQUEMIN", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public decimal Diasestoquemin
        {
            get { return  diasestoquemin; }
            set {  diasestoquemin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEVENTO
        /// Coment�rio: Tipo de Evento que definir� os dias que ser�o utilizados para calcular o estoque m�nimo ou m�ximo de um produto. (SB)Sub-Categoria, (CA)Categoria, (SE)Se��o, (DE)Departamento, (SC)Sub-Classe ou (C)Classe.
        /// </summary>
        private string tipoevento;
        [XmlElement(ElementName = "TIPOEVENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Tipoevento
        {
            get { return  tipoevento; }
            set {  tipoevento = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRecomposicaoestoque()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRECOMPOSICAOESTOQUE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRecomposicaoestoque> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRecomposicaoestoque>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRecomposicaoestoque> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRecomposicaoestoque>(where);
        }

        #endregion
    }
}
