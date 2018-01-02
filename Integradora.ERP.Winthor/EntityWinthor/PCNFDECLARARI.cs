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
    /// Classe referente a tabela PCNfdeclarari
    /// </summary>
    [XmlType("PCNFDECLARARI")]
    public class PCNfdeclarari : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do produto no Winthor.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODNF
        /// Comentário: Código do produto.
        /// </summary>
        private string codprodnf;
        [XmlElement(ElementName = "CODPRODNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Codprodnf
        {
            get { return  codprodnf; }
            set {  codprodnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREGISTRO
        /// Comentário: Código de registro da NF.
        /// </summary>
        private decimal codregistro;
        [XmlElement(ElementName = "CODREGISTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codregistro
        {
            get { return  codregistro; }
            set {  codregistro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBSEFAZ
        /// Comentário: Código do tipo de tributação por filial.
        /// </summary>
        private string codtribsefaz;
        [XmlElement(ElementName = "CODTRIBSEFAZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Codtribsefaz
        {
            get { return  codtribsefaz; }
            set {  codtribsefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Decrição do produto.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,120)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EAN
        /// Comentário: Código EAN.
        /// </summary>
        private string ean;
        [XmlElement(ElementName = "EAN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Ean
        {
            get { return  ean; }
            set {  ean = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NCM
        /// Comentário: Código NCM.
        /// </summary>
        private string ncm;
        [XmlElement(ElementName = "NCM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Ncm
        {
            get { return  ncm; }
            set {  ncm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMITEMNF
        /// Comentário: Número da ordem do produto.
        /// </summary>
        private decimal numitemnf;
        [XmlElement(ElementName = "NUMITEMNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numitemnf
        {
            get { return  numitemnf; }
            set {  numitemnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGMERCTRIB
        /// Comentário: Informação da PCPRODFILIAL.ORIGMERCTRIB.
        /// </summary>
        private string origmerctrib;
        [XmlElement(ElementName = "ORIGMERCTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origmerctrib
        {
            get { return  origmerctrib; }
            set {  origmerctrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: Valor do produto.
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORIMPOSTODECLARADO
        /// Comentário: Valor do item da nota * valor multiplicador.
        /// </summary>
        private decimal valorimpostodeclarado;
        [XmlElement(ElementName = "VALORIMPOSTODECLARADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Valorimpostodeclarado
        {
            get { return  valorimpostodeclarado; }
            set {  valorimpostodeclarado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORMULTIPLICADOR
        /// Comentário: Recebe o número da nota gerada na devolução.
        /// </summary>
        private decimal valormultiplicador;
        [XmlElement(ElementName = "VALORMULTIPLICADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Valormultiplicador
        {
            get { return  valormultiplicador; }
            set {  valormultiplicador = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCNfdeclarari()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNFDECLARARI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCNfdeclarari> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNfdeclarari>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCNfdeclarari> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNfdeclarari>(where);
        }

        #endregion
    }
}
