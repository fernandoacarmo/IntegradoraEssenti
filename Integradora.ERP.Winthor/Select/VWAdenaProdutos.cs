using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.Select
{
   // class VWAdenaProdutos
  //  {
  //  }
        /// <summary>
    /// Classe referente ao select VWAdenaProdutos
    /// </summary>
    [XmlType("VWADENAPRODUTOS")]
    public class VWAdenaProdutos : OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWAdenaProdutos()
        {

        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWAdenaProdutos> Listar(string where)
        {
            //string filtro = where.ToUpper().Replace("ROWID", "OID");
            Persistencia ba = new Persistencia(VWAdenaProdutos.GetStringConnection());
            Biblioteca.Tools.Logs.GerarLog(string.Format("SELECT: {0}, filtro: {1}", GetSelect(), where));
            return ba.Listar<VWAdenaProdutos>(GetSelect(), where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWAdenaProdutos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(VWAdenaProdutos.GetStringConnection());
            return ba.Existe<VWAdenaProdutos>(where);
        }

        /// <summary>
        /// Retorna o select de obteção dos registros
        /// </summary>
        public static string GetSelect()
        {
            string script = "";

            script = string.Format(@"SELECT B.*
                                      FROM ( SELECT   PCPRODUT.ROWID RID
                                            , PCEST.CODFILIAL
                                            , PCPRODUT.CODPROD
                                            , PCPRODUT.NOMEECOMMERCE AS NOME
                                            , 1 ID_CATEGORIA
                                            , '' CATEGORIA
                                            , PCPRODUT.CODPROD AS SKU
                                            , GREATEST(( NVL(PCEST.QTESTGER,0) - NVL(PCEST.QTRESERV,0) - NVL(PCEST.QTBLOQUEADA, 0)), 0 ) QTESTOQUE
                                            , PCEST.CUSTOFIN CUSTO
                                            , PCTABPR.PVENDA1 PRECO
                                            , PCPRODUT.PESOBRUTO PESO
                                            , PCPRODUT.ALTURAM3 ALTURA 
                                            , PCPRODUT.LARGURAM3 LARGURA
                                            , 0 PROFUNDIDADE
                                            , DECODE(NVL(PCEST.ESTMIN,0), 0, 1, PCEST.ESTMIN) ESTOQUEMINIMO
                                            , PCPRODUT.CODAUXILIAR
                                            , PCPRODUT.CODAUXILIAR2
                                       FROM PCPRODUT, PCEST, PCTABPR, PCPARAMFILIAL
                                      WHERE PCPRODUT.CODPROD  = PCEST.CODPROD
                                        AND PCPRODUT.CODPROD  = PCTABPR.CODPROD
                                        AND PCTABPR.NUMREGIAO = PCPARAMFILIAL.VALOR
                                        AND PCEST.CODFILIAL   = PCPARAMFILIAL.CODFILIAL
                                        AND PCPARAMFILIAL.NOME = 'FIL_NUMREGIAOPADRAO'
                                        AND PCEST.CODFILIAL = {0} ) B
                                   WHERE B.SKU > 0
                                     AND B.NOME IS NOT NULL "
                                , Biblioteca.Dictionaries.Settings.CodFilialVenda()
                                );

            return script;
        }
        #endregion

        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: RID
        /// Comentário: 
        /// </summary>
        private string rid;
        [XmlElement(ElementName = "RID", DataType = "ROWID", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public string Rid
        {
            get { return rid; }
            set { rid = value; }
        }
        
        
        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public string Codfilial
        {
            get { return codfilial; }
            set { codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal CodProd
        {
            get { return codprod; }
            set { codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Comentário: 
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 200)]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID_CATEGORIA
        /// Comentário: 
        /// </summary>
        private decimal idcategoria;
        [XmlElement(ElementName = "ID_CATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal IdCategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CATEGORIA
        /// Comentário: 
        /// </summary>
        private string categoria;
        [XmlElement(ElementName = "CATEGORIA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 200)]
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SKU
        /// Comentário: 
        /// </summary>
        private decimal sku;
        [XmlElement(ElementName = "SKU", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, true, 6)]
        public decimal Sku
        {
            get { return sku; }
            set { sku = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTOQUE
        /// Comentário: 
        /// </summary>
        private decimal qtestoque;
        [XmlElement(ElementName = "QTESTOQUE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal QtEstoque
        {
            get { return qtestoque; }
            set { qtestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTO
        /// Comentário: 
        /// </summary>
        private decimal custo;
        [XmlElement(ElementName = "CUSTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Custo
        {
            get { return custo; }
            set { custo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECO
        /// Comentário: 
        /// </summary>
        private decimal preco;
        [XmlElement(ElementName = "PRECO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESO
        /// Comentário: 
        /// </summary>
        private decimal peso;
        [XmlElement(ElementName = "PESO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURA
        /// Comentário: 
        /// </summary>
        private decimal altura;
        [XmlElement(ElementName = "ALTURA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURA
        /// Comentário: 
        /// </summary>
        private decimal largura;
        [XmlElement(ElementName = "LARGURA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROFUNDIDADE
        /// Comentário: 
        /// </summary>
        private decimal profundidade;
        [XmlElement(ElementName = "PROFUNDIDADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Profundidade
        {
            get { return profundidade; }
            set { profundidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTOQUEMINIMO
        /// Comentário: 
        /// </summary>
        private decimal estoqueminimo;
        [XmlElement(ElementName = "ESTOQUEMINIMO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal EstoqueMinimo
        {
            get { return estoqueminimo; }
            set { estoqueminimo = value; }
        }      

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Codauxiliar
        {
            get { return codauxiliar; }
            set { codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar2;
        [XmlElement(ElementName = "CODAUXILIAR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Codauxiliar2
        {
            get { return codauxiliar2; }
            set { codauxiliar2 = value; }
        }

        #endregion
    }
}
