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
    /// Classe referente a tabela PCBrindeexvalidacoes
    /// </summary>
    [XmlType("PCBRINDEEXVALIDACOES")]
    public class PCBrindeexvalidacoes : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BASECALCULO
        /// Coment�rio: Base de c�lculo, "PS" Pre�o sem imposto e "PC" Pre�o com Imposto.
        /// </summary>
        private string basecalculo;
        [XmlElement(ElementName = "BASECALCULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Basecalculo
        {
            get { return  basecalculo; }
            set {  basecalculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBREX
        /// Coment�rio: C�digo da campanha.
        /// </summary>
        private decimal codbrex;
        [XmlElement(ElementName = "CODBREX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codbrex
        {
            get { return  codbrex; }
            set {  codbrex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: C�digo do objeto a ser validado.
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRPREGRACAMP
        /// Coment�rio: Grupo de regra da campanha.
        /// </summary>
        private string grpregracamp;
        [XmlElement(ElementName = "GRPREGRACAMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Grpregracamp
        {
            get { return  grpregracamp; }
            set {  grpregracamp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOREGRA
        /// Coment�rio: C�digo do grupo da regra.
        /// </summary>
        private decimal gruporegra;
        [XmlElement(ElementName = "GRUPOREGRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Gruporegra
        {
            get { return  gruporegra; }
            set {  gruporegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINREGRASATENDER
        /// Coment�rio: Qtde minima de de regras que a valida��o deve atender.
        /// </summary>
        private decimal qtminregrasatender;
        [XmlElement(ElementName = "QTMINREGRASATENDER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtminregrasatender
        {
            get { return  qtminregrasatender; }
            set {  qtminregrasatender = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: Tipo do objeto a ser validado, "P"roduto, "D"epartamento, "S"e��o, Grupos de Produtos "GP", "F"ornecedor, Produto Principal "PP", "VL" Valor Total, "QT" Qtde Total e "PE" Peso Total.
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALOR
        /// Coment�rio: Tipo do valor a ser comparado, "VL" valor, "QT" quantidade e "PE" peso.
        /// </summary>
        private string tipovalor;
        [XmlElement(ElementName = "TIPOVALOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipovalor
        {
            get { return  tipovalor; }
            set {  tipovalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAX
        /// Coment�rio: Valor m�ximo.
        /// </summary>
        private decimal vlmax;
        [XmlElement(ElementName = "VLMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlmax
        {
            get { return  vlmax; }
            set {  vlmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMIN
        /// Coment�rio: Valor min�mo.
        /// </summary>
        private decimal vlmin;
        [XmlElement(ElementName = "VLMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlmin
        {
            get { return  vlmin; }
            set {  vlmin = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCBrindeexvalidacoes()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBRINDEEXVALIDACOES";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBrindeexvalidacoes> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBrindeexvalidacoes>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCBrindeexvalidacoes> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBrindeexvalidacoes>(where);
        }

        #endregion
    }
}
