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
    /// <summary>
    /// Classe referente ao select VWVtexProdutos
    /// </summary>
    [XmlType("VWVTEXPRODUTOS")]
    public class VWVtexProdutos : OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWVtexProdutos()
        {
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWVtexProdutos> Listar(string where)
        {
            //string filtro = where.ToUpper().Replace("ROWID", "OID");
            Persistencia ba = new Persistencia(VWVtexProdutos.GetStringConnection());
            return ba.Listar<VWVtexProdutos>(GetSelect(), where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWVtexProdutos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(VWVtexProdutos.GetStringConnection());
            return ba.Existe<VWVtexProdutos>(where);
        }

        /// <summary>
        /// Retorna o select de obteção dos registros
        /// </summary>
        public static string GetSelect()
        {
            string script = "";

            script  = string.Format(
                  @"SELECT B.*
                       FROM (SELECT A.*
                                  , PCDEPTO.DESCRICAO DEPARTAMENTO
                                  , PCDEPTO.MAGENTO_ID AS DEPTO_MAGENTO_ID
                                  , TRUNC(SYSDATE) DATAATUAL
                                  , (CASE
                                       WHEN A.EKIT > 0 THEN
                                         (SELECT SUM(NVL((SELECT PROM_ITEM.PRECOFIXO
                                                            FROM PCPRECOPROM PROM_ITEM
                                                           WHERE PROM_ITEM.CODPROD = TAB_ITEM.CODPROD
                                                             AND PROM_ITEM.NUMREGIAO = TAB_ITEM.NUMREGIAO
                                                             AND PROM_ITEM.CODCLI IS NULL
                                                             AND PROM_ITEM.CODUSUR IS NULL
                                                             AND PROM_ITEM.CODPRACA IS NULL
                                                             AND TRUNC(SYSDATE) BETWEEN PROM_ITEM.DTINICIOVIGENCIA AND PROM_ITEM.DTFIMVIGENCIA), TAB_ITEM.PVENDA1)
                                                     * NVL(F.QTPRODMP, 0))
                                            FROM PCFORMPROD F
                                               , PCTABPR TAB_ITEM
                                           WHERE F.CODPRODACAB = PCTABPR.CODPROD
                                             AND TAB_ITEM.CODPROD = F.CODPRODMP
                                             AND TAB_ITEM.NUMREGIAO = NVL(FILIAL_LOJA.NUMREGIAOPADRAO, PCCONSUM.NUMREGIAOPADRAO))
                                       ELSE
                                         NVL((SELECT MAX(PCPRECOPROM.PRECOFIXO)
                                                FROM PCPRECOPROM
                                               WHERE PCPRECOPROM.CODPROD = PCTABPR.CODPROD
                                                 AND PCPRECOPROM.NUMREGIAO = PCTABPR.NUMREGIAO
                                                 AND PCPRECOPROM.CODCLI IS NULL
                                                 AND PCPRECOPROM.CODUSUR IS NULL
                                                 AND PCPRECOPROM.CODPRACA IS NULL
                                                 AND TRUNC(SYSDATE) BETWEEN PCPRECOPROM.DTINICIOVIGENCIA AND PCPRECOPROM.DTFIMVIGENCIA), PCTABPR.PVENDA1)
                                     END)
                                      PVENDA
                                  ,   NVL(PCEST.QTESTGER, 0)
                                    - NVL(PCEST.QTBLOQUEADA, 0)
                                    - NVL(PCEST.QTRESERV, 0)
                                    - NVL(PCEST.QTPENDENTE, 0)
                                      QTESTOQUE
                                  , PCEST.QTRESERV
                                  , NVL((SELECT MIN((  NVL(ESTOQUE_KIT.QTESTGER, 0)
                                                     - NVL(ESTOQUE_KIT.QTRESERV, 0)
                                                     - NVL(ESTOQUE_KIT.QTBLOQUEADA, 0)
                                                     - NVL(ESTOQUE_KIT.QTPENDENTE, 0)))
                                           FROM PCEST ESTOQUE_KIT
                                              , PCFORMPROD
                                          WHERE PCFORMPROD.CODPRODACAB = A.CODPROD
                                            AND PCFORMPROD.CODPRODMP = ESTOQUE_KIT.CODPROD
                                            AND ESTOQUE_KIT.CODFILIAL = NVL('{1}', '{0}')), 0)
                                      ESTOQUE_DISP_KIT
                               FROM (SELECT PCPRODUT.CODPROD
                                          , NVL(PCPRODUT.NOMEECOMMERCE, PCPRODUT.DESCRICAO) PRODUTO
                                          , PCLINHAPROD.DESCRICAO SKU
                                          , PCPRODUT.MAGENTO_ID
                                          , PCPRODUT.ROWID RID
                                          , PCPRODUT.CODEPTO
                                          , PCPRODUT.CODSEC
                                          , PCPRODUT.CODCATEGORIA
                                          , PCPRODUT.DIRFOTOPROD
                                          , PCPRODUT.CODPRODRELEV
                                          , ESTMARCAPRODUTO.MARCA_ID CODMARCA
                                          , ESTMARCAPRODUTO.DESCRICAO MARCA
                                          , PCPRODUT.NBM
                                          , PCPRODUT.QTUNIT
                                          , PCPRODUT.CODAUXILIAR
                                          , PCPRODUT.CODFAB
                                          , ROUND(NVL(PCPRODUT.PESOLIQ, 0), 4) * 1000 PESOLIQ
                                          , NVL(PCPRODUT.ALTURAM3, 0) * 100 ALTURAM3
                                          , NVL(PCPRODUT.COMPRIMENTOM3, 0) * 100 COMPRIMENTOM3
                                          , NVL(PCPRODUT.LARGURAM3, 0) * 100 LARGURAM3
                                          , NVL(PCPRODUT.OBS, 0) OBS
                                          , NVL(PCPRODUT.OBS2, 0) OBS2
                                          , NVL((SELECT COUNT(1)
                                                   FROM PCFORMPROD
                                                  WHERE PCFORMPROD.CODPRODACAB = PCPRODUT.CODPROD), 0)
                                              EKIT
                                       FROM PCPRODUT
                                          , PCDEPTO
                                          , ESTMARCAPRODUTO
                                          , PCLINHAPROD
                                      WHERE PCPRODUT.DTEXCLUSAO IS NULL
                                        AND PCPRODUT.CODEPTO = PCDEPTO.CODEPTO
                                        AND PCLINHAPROD.DESCRICAO IS NOT NULL
                                        AND PCPRODUT.CODLINHAPROD = PCLINHAPROD.CODLINHA
                                        AND PCDEPTO.USANOECOMMERCE = 'S'
                                        AND PCPRODUT.NOMEECOMMERCE IS NOT NULL
                                        AND ESTMARCAPRODUTO.DESCRICAO = UPPER(TRIM(NVL(PCPRODUT.EMBALAGEM, ' ')))
                                          ) A
                                  , PCDEPTO
                                  , PCTABPR
                                  , PCCONSUM
                                  , PCEST
                                  , PCFILIAL
                                  , PCFILIAL FILIAL_LOJA
                              WHERE A.CODEPTO = PCDEPTO.CODEPTO
                                AND A.CODPROD = PCTABPR.CODPROD
                                AND A.CODPROD = PCEST.CODPROD
                                AND PCEST.CODFILIAL = PCFILIAL.CODIGO
                                AND FILIAL_LOJA.CODIGO = '{0}' --CODFILIALLOJA
                                AND PCEST.CODFILIAL = NVL('{1}', '{2}')
                                AND PCTABPR.NUMREGIAO = NVL(FILIAL_LOJA.NUMREGIAOPADRAO, PCCONSUM.NUMREGIAOPADRAO)) B
                      WHERE NVL(B.PVENDA, 0) > 0
                        AND B.SKU IS NOT NULL  "
               , Biblioteca.Dictionaries.Settings.CodFilialVenda()
               , Biblioteca.Dictionaries.Settings.CodFilialRetira()
               , Biblioteca.Dictionaries.Settings.CodFilialVenda()
               );

            return script;
        }
        #endregion

        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALTURAM3
        /// Comentário: 
        /// </summary>
        private decimal alturam3;
        [XmlElement(ElementName = "ALTURAM3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Alturam3
        {
            get { return alturam3; }
            set { alturam3 = value; }
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
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Comentário: 
        /// </summary>
        private decimal codcategoria;
        [XmlElement(ElementName = "CODCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codcategoria
        {
            get { return codcategoria; }
            set { codcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNIT
        /// Comentário: 
        /// </summary>
        private decimal qtunit;
        [XmlElement(ElementName = "QTUNIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Qtunit
        {
            get { return qtunit; }
            set { qtunit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Comentário: 
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codepto
        {
            get { return codepto; }
            set { codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFAB
        /// Comentário: 
        /// </summary>
        private string codfab;
        [XmlElement(ElementName = "CODFAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Codfab
        {
            get { return codfab; }
            set { codfab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMARCA
        /// Comentário: 
        /// </summary>
        private decimal codmarca;
        [XmlElement(ElementName = "CODMARCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Codmarca
        {
            get { return codmarca; }
            set { codmarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codprod
        {
            get { return codprod; }
            set { codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODRELEV
        /// Comentário: 
        /// </summary>
        private decimal codprodrelev;
        [XmlElement(ElementName = "CODPRODRELEV", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codprodrelev
        {
            get { return codprodrelev; }
            set { codprodrelev = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Comentário: 
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codsec
        {
            get { return codsec; }
            set { codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRIMENTOM3
        /// Comentário: 
        /// </summary>
        private decimal comprimentom3;
        [XmlElement(ElementName = "COMPRIMENTOM3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Comprimentom3
        {
            get { return comprimentom3; }
            set { comprimentom3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAATUAL
        /// Comentário: 
        /// </summary>
        private DateTime? dataatual;
        [XmlElement(ElementName = "DATAATUAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 8)]
        public DateTime? Dataatual
        {
            get { return dataatual; }
            set { dataatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEPARTAMENTO
        /// Comentário: 
        /// </summary>
        private string departamento;
        [XmlElement(ElementName = "DEPARTAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 25)]
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEPTO_MAGENTO_ID
        /// Comentário: 
        /// </summary>
        private string depto_magento_id;
        [XmlElement(ElementName = "DEPTO_MAGENTO_ID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Depto_Magento_Id
        {
            get { return depto_magento_id; }
            set { depto_magento_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRFOTOPROD
        /// Comentário: 
        /// </summary>
        private string dirfotoprod;
        [XmlElement(ElementName = "DIRFOTOPROD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Dirfotoprod
        {
            get { return dirfotoprod; }
            set { dirfotoprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EKIT
        /// Comentário: 
        /// </summary>
        private decimal ekit;
        [XmlElement(ElementName = "EKIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Ekit
        {
            get { return ekit; }
            set { ekit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTOQUE_DISP_KIT
        /// Comentário: 
        /// </summary>
        private decimal estoque_disp_kit;
        [XmlElement(ElementName = "ESTOQUE_DISP_KIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Estoque_Disp_Kit
        {
            get { return estoque_disp_kit; }
            set { estoque_disp_kit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURAM3
        /// Comentário: 
        /// </summary>
        private decimal larguram3;
        [XmlElement(ElementName = "LARGURAM3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Larguram3
        {
            get { return larguram3; }
            set { larguram3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAGENTO_ID
        /// Comentário: 
        /// </summary>
        private string magento_id;
        [XmlElement(ElementName = "MAGENTO_ID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Magento_Id
        {
            get { return magento_id; }
            set { magento_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARCA
        /// Comentário: 
        /// </summary>
        private string marca;
        [XmlElement(ElementName = "MARCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 12)]
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NBM
        /// Comentário: 
        /// </summary>
        private string nbm;
        [XmlElement(ElementName = "NBM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 15)]
        public string Nbm
        {
            get { return nbm; }
            set { nbm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Comentário: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string Obs2
        {
            get { return obs2; }
            set { obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOLIQ
        /// Comentário: 
        /// </summary>
        private decimal pesoliq;
        [XmlElement(ElementName = "PESOLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Pesoliq
        {
            get { return pesoliq; }
            set { pesoliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODUTO
        /// Comentário: 
        /// </summary>
        private string produto;
        [XmlElement(ElementName = "PRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 200)]
        public string Produto
        {
            get { return produto; }
            set { produto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Comentário: 
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Pvenda
        {
            get { return pvenda; }
            set { pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTOQUE
        /// Comentário: 
        /// </summary>
        private decimal qtestoque;
        [XmlElement(ElementName = "QTESTOQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtestoque
        {
            get { return qtestoque; }
            set { qtestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERV
        /// Comentário: 
        /// </summary>
        private decimal qtreserv;
        [XmlElement(ElementName = "QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtreserv
        {
            get { return qtreserv; }
            set { qtreserv = value; }
        }

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
        /// Propriedade referente ao campo: SKU
        /// Comentário: 
        /// </summary>
        private string sku;
        [XmlElement(ElementName = "SKU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Sku
        {
            get { return sku; }
            set { sku = value; }
        }

        #endregion
    }

}

