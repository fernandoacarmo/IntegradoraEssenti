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
    /// Classe referente a tabela PCLoteend
    /// </summary>
    [XmlType("PCLOTEEND")]
    public class PCLoteend : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APTO
        /// Coment�rio: Apartamento
        /// </summary>
        private decimal apto;
        [XmlElement(ElementName = "APTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Apto
        {
            get { return  apto; }
            set {  apto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da Filial
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
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo de Produto
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
        /// Propriedade referente ao campo: MODULO
        /// Coment�rio: M�dulo
        /// </summary>
        private decimal modulo;
        [XmlElement(ElementName = "MODULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Modulo
        {
            get { return  modulo; }
            set {  modulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO
        /// Coment�rio: N�mero
        /// </summary>
        private decimal numero;
        [XmlElement(ElementName = "NUMERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numero
        {
            get { return  numero; }
            set {  numero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: N�mero do Lote
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUA
        /// Coment�rio: Rua
        /// </summary>
        private decimal rua;
        [XmlElement(ElementName = "RUA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Rua
        {
            get { return  rua; }
            set {  rua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOENDER
        /// Coment�rio: Tipo do endere�o
        /// </summary>
        private string tipoender;
        [XmlElement(ElementName = "TIPOENDER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoender
        {
            get { return  tipoender; }
            set {  tipoender = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCLoteend()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLOTEEND";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCLoteend> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLoteend>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCLoteend> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLoteend>(where);
        }

        #endregion
    }
}
