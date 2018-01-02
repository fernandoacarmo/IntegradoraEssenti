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
    /// Classe referente a tabela PCComplementoemb
    /// </summary>
    [XmlType("PCCOMPLEMENTOEMB")]
    public class PCComplementoemb : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACRESCIMO
        /// Comentário: Acréscimo  inserido por complemento
        /// </summary>
        private decimal acrescimo;
        [XmlElement(ElementName = "ACRESCIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Acrescimo
        {
            get { return  acrescimo; }
            set {  acrescimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Código da embalagem
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Comentário: Código da categoria
        /// </summary>
        private decimal codcategoria;
        [XmlElement(ElementName = "CODCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcategoria
        {
            get { return  codcategoria; }
            set {  codcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOMP
        /// Comentário: Código do complemento
        /// </summary>
        private decimal codcomp;
        [XmlElement(ElementName = "CODCOMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcomp
        {
            get { return  codcomp; }
            set {  codcomp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Comentário: Código do departamento
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do produto
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Comentário: Código da seção
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBCATEGORIA
        /// Comentário: Código da subcategoria
        /// </summary>
        private decimal codsubcategoria;
        [XmlElement(ElementName = "CODSUBCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codsubcategoria
        {
            get { return  codsubcategoria; }
            set {  codsubcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Comentário: Complemento a ser inserido
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Complemento
        {
            get { return  complemento; }
            set {  complemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUSCOMP
        /// Comentário: Status do complemento
        /// </summary>
        private string statuscomp;
        [XmlElement(ElementName = "STATUSCOMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Statuscomp
        {
            get { return  statuscomp; }
            set {  statuscomp = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCComplementoemb()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMPLEMENTOEMB";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCComplementoemb> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCComplementoemb>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCComplementoemb> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCComplementoemb>(where);
        }

        #endregion
    }
}
