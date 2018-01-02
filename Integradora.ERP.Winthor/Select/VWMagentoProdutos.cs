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
    /// Classe referente ao select VWMagentoProdutos
    /// </summary>
    [XmlType("VWMAGENTOPRODUTOS")]
    public class VWMagentoProdutos : OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWMagentoProdutos()
        {
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWMagentoProdutos> Listar(string where)
        {
            //string filtro = where.ToUpper().Replace("ROWID", "OID");
            Persistencia ba = new Persistencia(VWMagentoProdutos.GetStringConnection());
            return ba.Listar<VWMagentoProdutos>(GetSelect(), where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWMagentoProdutos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(VWMagentoProdutos.GetStringConnection());
            return ba.Existe<VWMagentoProdutos>(where);
        }

        /// <summary>
        /// Retorna o select de obteção dos registros
        /// </summary>
        public static string GetSelect()
        {
            string script = string.Format(
                  @"SELECT B.*
                       FROM (SELECT PCPRODUT.CODPROD
                                  , TO_CHAR(PCPRODUT.CODPROD) SKU 
                                  , PCPRODUT.ROWID RID
                                  , PCPRODUT.DESCRICAO
                                  , NVL(PCPRODUT.ENVIAECOMMERCE,'N') ENVIAECOMMERCE
                                  , PCPRODUT.NOMEECOMMERCE
                                  , PCPRODUT.NBM
                                  , PCPRODUT.CODFAB
                                  , PCPRODUT.CODMARCA
                                  , PCMARCA.MARCA
                                  , PCPRODUT.CODEPTO
                                  , PCDEPTO.DESCRICAO DEPARTAMENTO
                                  , PCPRODUT.CODSEC
                                  , PCSECAO.DESCRICAO SECAO
                                  , PCPRODUT.CODCATEGORIA
                                  , PCCATEGORIA.CATEGORIA
                                  , PCPRODUT.CODSUBCATEGORIA
                                  , PCSUBCATEGORIA.SUBCATEGORIA
                                  , PCPRODUT.DTEXCLUSAO
                                  , PCPRODUT.CODAUXILIAR 
                                  , PCPRODUT.DIRFOTOPROD    
                                  , PCPRODUT.QTUNIT
                                  , NVL(PCPRODUT.OBS,'X') OBS
                                  , PCPRODUT.OBS2
                                  , ROUND(NVL(PCPRODUT.PESOLIQ, 0), 4) * 1000 PESOLIQ
                                  , NVL(PCPRODUT.ALTURAM3, 0) * 100 ALTURAM3
                                  , NVL(PCPRODUT.COMPRIMENTOM3, 0) * 100 COMPRIMENTOM3
                                  , NVL(PCPRODUT.LARGURAM3, 0) * 100 LARGURAM3
                                  --Especificos para o cliente Ingá
                                  , PCPRODUT.ESC_VINICOLA 
                                  , PCPRODUT.ESC_DETALHESVINICOLA 
                                  , PCPRODUT.ESC_PAIS 
                                  , PCPRODUT.ESC_PAIS PAIS
                                  , PCPRODUT.ESC_REGIAO
                                  , PCPRODUT.ESC_TIPO
                                  , PCPRODUT.ESC_COLORACAO
                                  , PCPRODUT.ESC_CAPACIDADE
                                  , NVL(PCPRODUT.ESC_UVAS , '0') ESC_UVAS 
                                  , NVL(PCPRODUT.ESC_UVAS1, '0') ESC_UVAS1
                                  , NVL(PCPRODUT.ESC_UVAS2, '0') ESC_UVAS2
                                  , NVL(PCPRODUT.ESC_UVAS3, '0') ESC_UVAS3
                                  , NVL(PCPRODUT.ESC_UVAS4, '0') ESC_UVAS4
                                  , NVL(PCPRODUT.ESC_UVAS5, '0') ESC_UVAS5
                                  , NVL(PCPRODUT.ESC_UVAS6, '0') ESC_UVAS6
                                  , NVL(PCPRODUT.ESC_UVAS7, '0') ESC_UVAS7
                                  , NVL(PCPRODUT.ESC_UVAS8, '0') ESC_UVAS8
                                  , NVL(PCPRODUT.ESC_UVAS9, '0') ESC_UVAS9
                                  , PCPRODUT.ESC_SAFRA
                                  , PCPRODUT.ESC_CLASSIFICACAO
                                  , PCPRODUT.ESC_TEORALCOOLICO
                                  , PCPRODUT.ESC_VISUAL
                                  , PCPRODUT.ESC_OLFATO
                                  , PCPRODUT.ESC_GUSTATIVO
                                  , PCPRODUT.ESC_AMADURECIMENTO
                                  , PCPRODUT.ESC_POTENCIALDEGUARDA
                                  , PCPRODUT.ESC_TEMPERATURADESERVICO
                                  , PCPRODUT.ESC_TIPODEROLHA
                                  , PCPRODUT.ESC_VARIETALASSEMBLAGEM
                                  , PCPRODUT.ESC_PREMIACOES
                                  , NVL(PCPRODUT.ESC_HARMONIZACAO , '0') ESC_HARMONIZACAO 
                                  , NVL(PCPRODUT.ESC_HARMONIZACAO1, '0') ESC_HARMONIZACAO1
                                  , NVL(PCPRODUT.ESC_HARMONIZACAO2, '0') ESC_HARMONIZACAO2
                                  , NVL(PCPRODUT.ESC_HARMONIZACAO3, '0') ESC_HARMONIZACAO3
                                  --Campos especiais
                                  
                                  --Data e hora atual
                                  , TRUNC(SYSDATE) DATAATUAL
                                  --Descrição do departamento
                                  , CASE WHEN PCPRODUT.CODSUBCATEGORIA IS NOT NULL 
                                         THEN PCSUBCATEGORIA.SUBCATEGORIA
                                         WHEN PCPRODUT.CODCATEGORIA IS NOT NULL 
                                         THEN PCCATEGORIA.CATEGORIA            
                                         WHEN PCPRODUT.CODSEC IS NOT NULL 
                                         THEN PCSECAO.DESCRICAO            
                                         ELSE PCDEPTO.DESCRICAO            
                                    END DEPARTAMENTOECOMMERCE
                                  --Estoque atual
                                  , GREATEST((NVL(PCEST.QTESTGER, 0)
                                            - NVL(PCEST.QTBLOQUEADA, 0)
                                            - NVL(PCEST.QTRESERV, 0)
                                         --   - NVL(PCEST.QTPENDENTE, 0) Cliente não quer utilizar
                                            ),0) QTESTOQUE  
                                  --Preço de venda (olhando se tem promoção ativa
                                  , NVL((SELECT MAX(PCPRECOPROM.PRECOFIXO)
                                           FROM PCPRECOPROM
                                          WHERE PCPRECOPROM.CODPROD = PCTABPR.CODPROD
                                            AND PCPRECOPROM.NUMREGIAO = PCTABPR.NUMREGIAO
                                            AND PCPRECOPROM.CODCLI IS NULL
                                            AND PCPRECOPROM.CODUSUR IS NULL
                                            AND PCPRECOPROM.CODPRACA IS NULL
                                            AND TRUNC(SYSDATE) BETWEEN PCPRECOPROM.DTINICIOVIGENCIA AND PCPRECOPROM.DTFIMVIGENCIA), PCTABPR.PVENDA1) PVENDA
                                  --Preço de venda (olhando se tem promoção ativa
                                  , OFERTA.PVENDA1 POFERTA
                               FROM PCPRODUT
                                  , PCDEPTO
                                  , PCSECAO
                                  , PCCATEGORIA
                                  , PCSUBCATEGORIA
                                  , PCMARCA
                                  , PCEST
                                  , PCTABPR
                                  , PCTABPR OFERTA
                                  , PCFILIAL
                                  , PCCONSUM
                              WHERE PCPRODUT.CODEPTO         = PCDEPTO.CODEPTO
                                AND PCPRODUT.CODEPTO         = PCSECAO.CODEPTO
                                AND PCPRODUT.CODSEC          = PCSECAO.CODSEC
                                AND PCPRODUT.CODSEC          = PCCATEGORIA.CODSEC(+)
                                AND PCPRODUT.CODCATEGORIA    = PCCATEGORIA.CODCATEGORIA(+)
                                AND PCPRODUT.CODCATEGORIA    = PCSUBCATEGORIA.CODCATEGORIA(+)
                                AND PCPRODUT.CODSEC          = PCSUBCATEGORIA.CODSEC(+)
                                AND PCPRODUT.CODSUBCATEGORIA = PCSUBCATEGORIA.CODSUBCATEGORIA(+)
                                AND PCPRODUT.CODMARCA        = PCMARCA.CODMARCA(+)
                                AND PCEST.CODPROD            = PCPRODUT.CODPROD      
                                AND PCFILIAL.CODIGO          = NVL('{0}','{1}') 
                                AND PCEST.CODFILIAL          = PCFILIAL.CODIGO
                                AND PCTABPR.CODPROD          = PCPRODUT.CODPROD
                                AND PCTABPR.NUMREGIAO        = NVL(PCFILIAL.NUMREGIAOPADRAO, PCCONSUM.NUMREGIAOPADRAO)
                                AND OFERTA.CODPROD           = PCPRODUT.CODPROD
                                AND OFERTA.NUMREGIAO         = {2}
                                AND PCPRODUT.NOMEECOMMERCE IS NOT NULL
                                --AND PCPRODUT.ENVIAECOMMERCE  = 'S'
                             ) B
                       WHERE 1 = 1"
               , Biblioteca.Dictionaries.Settings.CodFilialRetira()
               , Biblioteca.Dictionaries.Settings.CodFilialVenda()
               , Biblioteca.Dictionaries.Settings.NumRegiaoOferta()
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
        /// Propriedade referente ao campo: NOMEECOMMERCE
        /// Comentário: 
        /// </summary>
        private string nomeecommerce;
        [XmlElement(ElementName = "NOMEECOMMERCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Nomeecommerce
        {
            get { return nomeecommerce; }
            set { nomeecommerce = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: NOMEECOMMERCE
        /// Comentário: 
        /// </summary>
        private string enviaecommerce;
        [XmlElement(ElementName = "ENVIAECOMMERCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Enviaecommerce
        {
            get { return enviaecommerce; }
            set { enviaecommerce = value; }
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
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
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
        /// Propriedade referente ao campo: POFERTA
        /// Comentário: 
        /// </summary>
        private decimal poferta;
        [XmlElement(ElementName = "POFERTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Poferta
        {
            get { return poferta; }
            set { poferta = value; }
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

        /// <summary>
        /// Propriedade referente ao campo: ESC_VINICOLA
        /// Comentário: 
        /// </summary>
        private string esc_vinicola;
        [XmlElement(ElementName = "ESC_VINICOLA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_vinicola
        {
            get { return esc_vinicola; }
            set { esc_vinicola = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_SAFRA
        /// Comentário: 
        /// </summary>
        private string esc_safra;
        [XmlElement(ElementName = "ESC_SAFRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_safra
        {
            get { return esc_safra; }
            set { esc_safra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_CLASSIFICACAO
        /// Comentário: 
        /// </summary>
        private string esc_classificacao;
        [XmlElement(ElementName = "ESC_CLASSIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_classificacao
        {
            get { return esc_classificacao; }
            set { esc_classificacao = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: ESC_DETALHESVINICOLA
        /// Comentário: 
        /// </summary>
        private string esc_detalhesvinicola;
        [XmlElement(ElementName = "ESC_DETALHESVINICOLA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_detalhesvinicola
        {
            get { return esc_detalhesvinicola; }
            set { esc_detalhesvinicola = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_PAIS
        /// Comentário: 
        /// </summary>
        private string esc_pais;
        [XmlElement(ElementName = "ESC_PAIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_pais
        {
            get { return esc_pais; }
            set { esc_pais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAIS
        /// Comentário: 
        /// </summary>
        private string pais;
        [XmlElement(ElementName = "PAIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_REGIAO
        /// Comentário: 
        /// </summary>
        private string esc_regiao;
        [XmlElement(ElementName = "ESC_REGIAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_regiao
        {
            get { return esc_regiao; }
            set { esc_regiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_TIPO
        /// Comentário: 
        /// </summary>
        private string esc_tipo;
        [XmlElement(ElementName = "ESC_TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_tipo
        {
            get { return esc_tipo; }
            set { esc_tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_COLORACAO
        /// Comentário: 
        /// </summary>
        private string esc_coloracao;
        [XmlElement(ElementName = "ESC_COLORACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_coloracao
        {
            get { return esc_coloracao; }
            set { esc_coloracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_CAPACIDADE
        /// Comentário: 
        /// </summary>
        private string esc_capacidade;
        [XmlElement(ElementName = "ESC_CAPACIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_capacidade
        {
            get { return esc_capacidade; }
            set { esc_capacidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_UVAS
        /// Comentário: 
        /// </summary>
        private string esc_uvas;
        [XmlElement(ElementName = "ESC_UVAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_uvas
        {
            get { return esc_uvas; }
            set { esc_uvas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_UVAS
        /// Comentário: 
        /// </summary>
        private string esc_uvas1;
        [XmlElement(ElementName = "ESC_UVAS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_uvas1
        {
            get { return esc_uvas1; }
            set { esc_uvas1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_UVAS2
        /// Comentário: 
        /// </summary>
        private string esc_uvas2;
        [XmlElement(ElementName = "ESC_UVAS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_uvas2
        {
            get { return esc_uvas2; }
            set { esc_uvas2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_UVAS3
        /// Comentário: 
        /// </summary>
        private string esc_uvas3;
        [XmlElement(ElementName = "ESC_UVAS3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_uvas3
        {
            get { return esc_uvas3; }
            set { esc_uvas3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_UVAS4
        /// Comentário: 
        /// </summary>
        private string esc_uvas4;
        [XmlElement(ElementName = "ESC_UVAS4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_uvas4
        {
            get { return esc_uvas4; }
            set { esc_uvas4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_UVAS5
        /// Comentário: 
        /// </summary>
        private string esc_uvas5;
        [XmlElement(ElementName = "ESC_UVAS5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_uvas5
        {
            get { return esc_uvas5; }
            set { esc_uvas5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_UVAS6
        /// Comentário: 
        /// </summary>
        private string esc_uvas6;
        [XmlElement(ElementName = "ESC_UVAS6", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_uvas6
        {
            get { return esc_uvas6; }
            set { esc_uvas6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_UVAS
        /// Comentário: 
        /// </summary>
        private string esc_uvas7;
        [XmlElement(ElementName = "ESC_UVAS7", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_uvas7
        {
            get { return esc_uvas7; }
            set { esc_uvas7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_UVAS8
        /// Comentário: 
        /// </summary>
        private string esc_uvas8;
        [XmlElement(ElementName = "ESC_UVAS8", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_uvas8
        {
            get { return esc_uvas8; }
            set { esc_uvas8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_UVAS
        /// Comentário: 
        /// </summary>
        private string esc_uvas9;
        [XmlElement(ElementName = "ESC_UVAS9", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_uvas9
        {
            get { return esc_uvas9; }
            set { esc_uvas9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_TEORALCOOLICO
        /// Comentário: 
        /// </summary>
        private string esc_teoralcoolico;
        [XmlElement(ElementName = "ESC_TEORALCOOLICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_teoralcoolico
        {
            get { return esc_teoralcoolico; }
            set { esc_teoralcoolico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_VISUAL
        /// Comentário: 
        /// </summary>
        private string esc_visual;
        [XmlElement(ElementName = "ESC_VISUAL", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_visual
        {
            get { return esc_visual; }
            set { esc_visual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_HARMONIZACAO
        /// Comentário: 
        /// </summary>
        private string esc_harmonizacao;
        [XmlElement(ElementName = "ESC_HARMONIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Esc_harmonizacao
        {
            get { return esc_harmonizacao; }
            set { esc_harmonizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_HARMONIZACAO1
        /// Comentário: 
        /// </summary>
        private string esc_harmonizacao1;
        [XmlElement(ElementName = "ESC_HARMONIZACAO1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Esc_harmonizacao1
        {
            get { return esc_harmonizacao1; }
            set { esc_harmonizacao1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_HARMONIZACAO2
        /// Comentário: 
        /// </summary>
        private string esc_harmonizacao2;
        [XmlElement(ElementName = "ESC_HARMONIZACAO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Esc_harmonizacao2
        {
            get { return esc_harmonizacao2; }
            set { esc_harmonizacao2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_HARMONIZACAO3
        /// Comentário: 
        /// </summary>
        private string esc_harmonizacao3;
        [XmlElement(ElementName = "ESC_HARMONIZACAO3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Esc_harmonizacao3
        {
            get { return esc_harmonizacao3; }
            set { esc_harmonizacao3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_OLFATO
        /// Comentário: 
        /// </summary>
        private string esc_olfato;
        [XmlElement(ElementName = "ESC_OLFATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_olfato
        {
            get { return esc_olfato; }
            set { esc_olfato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_GUSTATIVO
        /// Comentário: 
        /// </summary>
        private string esc_gustativo;
        [XmlElement(ElementName = "ESC_GUSTATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_gustativo
        {
            get { return esc_gustativo; }
            set { esc_gustativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_AMADURECIMENTO
        /// Comentário: 
        /// </summary>
        private string esc_amadurecimento;
        [XmlElement(ElementName = "ESC_AMADURECIMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_amadurecimento
        {
            get { return esc_amadurecimento; }
            set { esc_amadurecimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_POTENCIALDEGUARDA
        /// Comentário: 
        /// </summary>
        private string esc_potencialdeguarda;
        [XmlElement(ElementName = "ESC_POTENCIALDEGUARDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_potencialdeguarda
        {
            get { return esc_potencialdeguarda; }
            set { esc_potencialdeguarda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_TEMPERATURADESERVICO
        /// Comentário: 
        /// </summary>
        private string esc_temperaturadeservico;
        [XmlElement(ElementName = "ESC_TEMPERATURADESERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_temperaturadeservico
        {
            get { return esc_temperaturadeservico; }
            set { esc_temperaturadeservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_TIPODEROLHA
        /// Comentário: 
        /// </summary>
        private string esc_tipoderolha;
        [XmlElement(ElementName = "ESC_TIPODEROLHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_tipoderolha
        {
            get { return esc_tipoderolha; }
            set { esc_tipoderolha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_VARIETALASSEMBLAGEM
        /// Comentário: 
        /// </summary>
        private string esc_varietalassemblagem;
        [XmlElement(ElementName = "ESC_VARIETALASSEMBLAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_varietalassemblagem
        {
            get { return esc_varietalassemblagem; }
            set { esc_varietalassemblagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_PREMIACOES
        /// Comentário: 
        /// </summary>
        private string esc_premiacoes;
        [XmlElement(ElementName = "ESC_PREMIACOES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Esc_premiacoes
        {
            get { return esc_premiacoes; }
            set { esc_premiacoes = value; }
        }

        #endregion
    }

}

