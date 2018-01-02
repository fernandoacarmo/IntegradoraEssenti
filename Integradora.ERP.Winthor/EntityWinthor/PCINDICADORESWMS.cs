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
    /// Classe referente a tabela PCIndicadoreswms
    /// </summary>
    [XmlType("PCINDICADORESWMS")]
    public class PCIndicadoreswms : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BOM
        /// Coment�rio: Qtde. bom
        /// </summary>
        private decimal bom;
        [XmlElement(ElementName = "BOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public decimal Bom
        {
            get { return  bom; }
            set {  bom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: C�digo do funcion�rio
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o do indicador
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FILIAL
        /// Coment�rio: Filial do Indicador
        /// </summary>
        private string filial;
        [XmlElement(ElementName = "FILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Filial
        {
            get { return  filial; }
            set {  filial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORNECEDOR
        /// Coment�rio: Fornecedor
        /// </summary>
        private string fornecedor;
        [XmlElement(ElementName = "FORNECEDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Fornecedor
        {
            get { return  fornecedor; }
            set {  fornecedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HABILITACOCKPIT
        /// Coment�rio: Habilita cockpit
        /// </summary>
        private string habilitacockpit;
        [XmlElement(ElementName = "HABILITACOCKPIT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Habilitacockpit
        {
            get { return  habilitacockpit; }
            set {  habilitacockpit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: META
        /// Coment�rio: Meta
        /// </summary>
        private decimal meta;
        [XmlElement(ElementName = "META", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public decimal Meta
        {
            get { return  meta; }
            set {  meta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECOMPONENTE
        /// Coment�rio: Nome do componente
        /// </summary>
        private string nomecomponente;
        [XmlElement(ElementName = "NOMECOMPONENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomecomponente
        {
            get { return  nomecomponente; }
            set {  nomecomponente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMINVENT
        /// Coment�rio: N�mero do invent�rio
        /// </summary>
        private string numinvent;
        [XmlElement(ElementName = "NUMINVENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Numinvent
        {
            get { return  numinvent; }
            set {  numinvent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDENACAO
        /// Coment�rio: Orderna��o
        /// </summary>
        private string ordenacao;
        [XmlElement(ElementName = "ORDENACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ordenacao
        {
            get { return  ordenacao; }
            set {  ordenacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OTIMO
        /// Coment�rio: Qtde. otimo
        /// </summary>
        private decimal otimo;
        [XmlElement(ElementName = "OTIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public decimal Otimo
        {
            get { return  otimo; }
            set {  otimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIODO
        /// Coment�rio: Per�odo
        /// </summary>
        private string periodo;
        [XmlElement(ElementName = "PERIODO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Periodo
        {
            get { return  periodo; }
            set {  periodo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAZOAVEL
        /// Coment�rio: Qtde. razoavel
        /// </summary>
        private decimal razoavel;
        [XmlElement(ElementName = "RAZOAVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public decimal Razoavel
        {
            get { return  razoavel; }
            set {  razoavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUIM
        /// Coment�rio: Qtde. ruim
        /// </summary>
        private decimal ruim;
        [XmlElement(ElementName = "RUIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public decimal Ruim
        {
            get { return  ruim; }
            set {  ruim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODADOS
        /// Coment�rio: Tipo dados
        /// </summary>
        private string tipodados;
        [XmlElement(ElementName = "TIPODADOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Tipodados
        {
            get { return  tipodados; }
            set {  tipodados = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOINVENT
        /// Coment�rio: Tipo do Invent�rio
        /// </summary>
        private string tipoinvent;
        [XmlElement(ElementName = "TIPOINVENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoinvent
        {
            get { return  tipoinvent; }
            set {  tipoinvent = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCIndicadoreswms()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINDICADORESWMS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCIndicadoreswms> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCIndicadoreswms>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCIndicadoreswms> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCIndicadoreswms>(where);
        }

        #endregion
    }
}
