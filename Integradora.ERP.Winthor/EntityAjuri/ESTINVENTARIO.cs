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
    /// Classe referente a tabela ESTInventario
    /// </summary>
    [XmlType("ESTINVENTARIO")]
    public class ESTInventario : BaseAjuri
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 6)]
        public decimal Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Comentário: 
        /// </summary>
        private decimal codproduto;
        [XmlElement(ElementName = "CODPRODUTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 6)]
        public decimal Codproduto
        {
            get { return codproduto; }
            set { codproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCRIADO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcriado;
        [XmlElement(ElementName = "DTCRIADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtcriado
        {
            get { return dtcriado; }
            set { dtcriado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFABRICACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtfabricacao;
        [XmlElement(ElementName = "DTFABRICACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtfabricacao
        {
            get { return dtfabricacao; }
            set { dtfabricacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDINVENTARIOAJURI
        /// Comentário: 
        /// </summary>
        private decimal? idinventarioajuri;
        [XmlElement(ElementName = "IDINVENTARIOAJURI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public decimal? IDinventarioajuri
        {
            get { return idinventarioajuri; }
            set { idinventarioajuri = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public decimal Codendereco
        {
            get { return codendereco; }
            set { codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDINVENTARIOWINTHOR
        /// Comentário: 
        /// </summary>
        private decimal? idinventariowinthor;
        [XmlElement(ElementName = "IDINVENTARIOWINTHOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public decimal? IDinventariowinthor
        {
            get { return idinventariowinthor; }
            set { idinventariowinthor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCIMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtvencimento;
        [XmlElement(ElementName = "DTVENCIMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtvencimento
        {
            get { return dtvencimento; }
            set { dtvencimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALIZACAO
        /// Comentário: 
        /// </summary>
        private string localizacao;
        [XmlElement(ElementName = "LOCALIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELO
        /// Comentário: 
        /// </summary>
        private string modelo;
        [XmlElement(ElementName = "MODELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

      
        /// <summary>
        /// Propriedade referente ao campo: QTPROCESSADA
        /// Comentário: 
        /// </summary>
        private decimal qtprocessada;
        [XmlElement(ElementName = "QTPROCESSADA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Qtprocessada
        {
            get { return qtprocessada; }
            set { qtprocessada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADE
        /// Comentário: 
        /// </summary>
        private decimal quantidade;
        [XmlElement(ElementName = "QUANTIDADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIAL
        /// Comentário: 
        /// </summary>
        private string serial;
        [XmlElement(ElementName = "SERIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLUNITARIO
        /// Comentário: 
        /// </summary>
        private decimal vlunitario;
        [XmlElement(ElementName = "VLUNITARIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Vlunitario
        {
            get { return vlunitario; }
            set { vlunitario = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTInventario()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTINVENTARIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTInventario> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTInventario.GetStringConnection());
            return ba.Listar<ESTInventario>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTInventario> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTInventario.GetStringConnection());
            return ba.Existe<ESTInventario>(where);
        }

        #endregion
    }
}
