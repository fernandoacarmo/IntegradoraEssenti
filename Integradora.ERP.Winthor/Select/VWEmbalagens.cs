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
    /// Classe referente ao select VWEmbalagens
    /// </summary>
    [XmlType("VWEMBALAGENS")]
    public class VWEmbalagens : OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWEmbalagens()
        {
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWEmbalagens> Listar(string where)
        {
            //string filtro = where.ToUpper().Replace("ROWID", "OID");
            Persistencia ba = new Persistencia(VWEmbalagens.GetStringConnection());
            return ba.Listar<VWEmbalagens>(GetSelect(), where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWEmbalagens> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(VWEmbalagens.GetStringConnection());
            return ba.Existe<VWEmbalagens>(where);
        }

        /// <summary>
        /// Retorna o select de obteção dos registros
        /// </summary>
        public static string GetSelect()
        {
            return "SELECT B.* FROM VW_PRODUTOS_ECOMMERCE B WHERE 1=1 ";
//            return @"SELECT B.CODAUXILIAR SKU
//                          , B.CODPROD
//                          , B.CODFILIAL
//                          , B.ROWID OID
//                          , B.DESCRICAOWEB 
//                          , A.DESCRICAO DESCRICAO
//                          ,  (SELECT PCEMBALAGEM.CODAUXILIAR
//                               FROM PCEMBALAGEM
//                              WHERE PCEMBALAGEM.CODFILIAL = B.CODFILIAL
//                                AND PCEMBALAGEM.CODPROD   = B.CODPROD
//                                AND PCEMBALAGEM.QTUNIT IN (SELECT MIN(MENOR.QTUNIT)
//                                                             FROM PCEMBALAGEM MENOR
//                                                            WHERE MENOR.CODFILIAL = B.CODFILIAL
//                                                              AND MENOR.CODPROD = B.CODPROD)
//                                AND ROWNUM = 1) MENORCODAUXILIAR
//                          , NVL((SELECT COUNT(1) FROM PCEMBALAGEM X WHERE X.CODPROD = B.CODPROD),0) QTEMBALAGEM
//                          --, ROUND(DECODE(NVL(B.PVENDAWEB, 0), 0, NVL(B.PVENDA,   0), PVENDAWEB ) + ((DECODE(NVL(B.PVENDAWEB, 0), 0, NVL(B.PVENDA,  0), PVENDAWEB)  * A.PRCACRESCIMO)),2) PVENDA
//                          , ROUND( NVL(B.PVENDA, 0) + (NVL(B.PVENDA,  0)  * A.PRCACRESCIMO),2) PVENDA
//                          , ROUND(CASE WHEN TRUNC(SYSDATE) BETWEEN B.DTOFERTAWEBINI AND B.DTOFERTAWEBFIM
//                                       THEN NVL(B.POFERTAWEB,0)  + (NVL(B.POFERTAWEB,0)  * A.PRCACRESCIMO) 
//                                       ELSE 0
//                                  END,2) POFERTA
//                          , CASE WHEN DECODE(NVL(B.QTUNIT,0), 0, 1, B.QTUNIT) > 1
//                                 THEN ROUND((CASE WHEN TRUNC(SYSDATE) BETWEEN B.DTOFERTAWEBINI AND B.DTOFERTAWEBFIM
//                                                  THEN NVL(B.POFERTAWEB,0)  + (NVL(B.POFERTAWEB,0)  * A.PRCACRESCIMO) 
//                                                  ELSE NVL(B.PVENDA, 0) + (NVL(B.PVENDA,  0)  * A.PRCACRESCIMO)
//--                                                  ELSE DECODE(NVL(B.PVENDAWEB, 0), 0, NVL(B.PVENDA,   0), PVENDAWEB ) +
//--                                                        ((DECODE(NVL(B.PVENDAWEB, 0), 0, NVL(B.PVENDA,  0), PVENDAWEB) * A.PRCACRESCIMO)) 
//                                             END) / DECODE(NVL(B.QTUNIT,0), 0, 1, B.QTUNIT)
//                                             ,2)
//                                ELSE EMBALAGEMMAIOR.VLUNITARIO
//                            END PUNITARIO
//                          , NVL(B.PESOBRUTO, 1) PESO
//                          , NVL(B.ALTURA, 1) ALTURA
//                          , NVL(B.COMPRIMENTO, 1) COMPRIMENTO
//                          , NVL(B.LARGURA, 1) LARGURA
//                          , 0 QTRESERV
//                          , CASE WHEN A.CODEPTO = 16
//                                 THEN 100 --Quantidade será informado direto na plataforma, e-mail do dia 30/12/2015
//                                 ELSE GREATEST(TRUNC(A.QTESTOQUETOTAL / B.QTUNIT),0) 
//                            END QTESTOQUE
//                          , DECODE(NVL(B.QTUNIT,0), 0, 1, B.QTUNIT) QTUNIT
//                          , B.INFOPRODWEB
//                          , CASE WHEN TRUNC(SYSDATE) BETWEEN B.DTOFERTAWEBINI AND B.DTOFERTAWEBFIM
//                                 THEN '18' --Departamento que deve ficar quando estiver em oferta
//                                 ELSE TO_CHAR(NVL(A.CODSUBCATEGORIAWEB, NVL(A.CODCATEGORIAWEB, NVL(A.CODSECAOWEB, A.CODDEPTOWEB)))) 
//                            END CATEGORIZADOR
//                          , A.*
//                       FROM PCEMBALAGEM B
//                          , (SELECT PCEMBALAGEM.CODPROD
//                                  , PCEMBALAGEM.CODAUXILIAR
//                                  , ROUND((CASE WHEN TRUNC(SYSDATE) BETWEEN PCEMBALAGEM.DTOFERTAWEBINI AND PCEMBALAGEM.DTOFERTAWEBFIM
//                                                THEN NVL(PCEMBALAGEM.POFERTAWEB,0)  + (NVL(PCEMBALAGEM.POFERTAWEB,0)  
//                                                   * CASE WHEN NVL(PCPRODUT.ESC_PRCACRESCPRECOWEB, 0) > 0 
//                                                          THEN 1 + (PCPRODUT.ESC_PRCACRESCPRECOWEB / 100) 
//                                                          ELSE 0 
//                                                     END) 
//--                                                ELSE DECODE(NVL(PCEMBALAGEM.PVENDAWEB, 0), 0, NVL(PCEMBALAGEM.PVENDA,   0), PVENDAWEB ) +
//--                                                   ((DECODE(NVL(PCEMBALAGEM.PVENDAWEB, 0), 0, NVL(PCEMBALAGEM.PVENDA,  0), PVENDAWEB) 
//                                                ELSE (NVL(PCEMBALAGEM.PVENDA,   0) + (NVL(PCEMBALAGEM.PVENDA,  0)
//                                                   * CASE WHEN NVL(PCPRODUT.ESC_PRCACRESCPRECOWEB, 0) > 0 
//                                                          THEN 1 + (PCPRODUT.ESC_PRCACRESCPRECOWEB / 100) 
//                                                          ELSE 0 
//                                                     END)) 
//                                             END) / DECODE(NVL(PCEMBALAGEM.QTUNIT,0), 0, 1, PCEMBALAGEM.QTUNIT)
//                                             ,2) VLUNITARIO
//                               FROM PCEMBALAGEM
//                                  , PCPRODUT
//                              WHERE PCEMBALAGEM.CODFILIAL = '" + Biblioteca.Dictionaries.Settings.CodFilialVenda() + "' " +
//                         @"
//                                AND PCEMBALAGEM.DESCRICAOWEB IS NOT NULL
//                                AND NVL(PCEMBALAGEM.EXCLUIDO,'N') = 'N'
//                                AND PCEMBALAGEM.SITUACAOWEB = 'D'
//                                AND PCEMBALAGEM.CODPROD = PCPRODUT.CODPROD
//                                AND PCEMBALAGEM.QTUNIT IN (SELECT MAX(M.QTUNIT)
//                                                             FROM PCEMBALAGEM M
//                                                            WHERE M.CODFILIAL = PCEMBALAGEM.CODFILIAL
//                                                              AND M.CODPROD   = PCEMBALAGEM.CODPROD
//                                                              AND M.DESCRICAOWEB IS NOT NULL
//                                                              AND NVL(M.EXCLUIDO,'N') = 'N'
//                                                              AND M.SITUACAOWEB = 'D')
//                            ) EMBALAGEMMAIOR
//                          , (SELECT PCPRODUT.CODDEPTOWEB
//                                  , (PCPRODUT.CODSECAOWEB        + 1000000) CODSECAOWEB
//                                  , (PCPRODUT.CODCATEGORIAWEB    + 2000000) CODCATEGORIAWEB
//                                  , CASE WHEN PCPRODUT.CODSECAOWEB IS NOT NULL
//                                          AND PCPRODUT.CODCATEGORIAWEB IS NOT NULL
//                                          AND PCPRODUT.CODSUBCATEGORIAWEB IS NOT NULL
//                                          THEN PCPRODUT.CODSECAOWEB || PCPRODUT.CODCATEGORIAWEB || PCPRODUT.CODSUBCATEGORIAWEB
//                                          ELSE NULL
//                                    END CODSUBCATEGORIAWEB
//                                  , PCPRODUT.INFORMACOESTECNICAS 
//                                  , 3 FRETEGRATIS
//                                  , 0 TROCAGRATIS
//                                  , PCPRODUT.CODEPTO
//                                  , 0 PRAZOENTREGA
//                                  , PCFORNEC.CODFORNEC
//                                  , PCFORNEC.FORNECEDOR
//                                  , PCFORNEC.CGC
//                                  , PCFORNEC.ENDER ENDERECO
//                                  , PCFORNEC.BAIRRO
//                                  , PCFORNEC.CIDADE
//                                  , PCFORNEC.ESTADO
//                                  , PCFORNEC.CEP
//                                  , PCFORNEC.NUMEROEND NUMERO
//                                  , PCFORNEC.COMPLEMENTOEND COMPLEMENTO
//                                  , PCPRODUT.DESCRICAO
//                                  , PCPRODUT.APLICACOES
//                                  , NVL(PCPRODUT.ESC_VINCULOWEB,'S') ESC_VINCULOWEB
//                                  , CASE WHEN NVL(PCPRODUT.ESC_PRCACRESCPRECOWEB, 0) > 0 
//                                         THEN 1 + (PCPRODUT.ESC_PRCACRESCPRECOWEB / 100) 
//                                         ELSE 0 
//                                    END PRCACRESCIMO
//                                  , PCPRODUT.DADOSTECNICOS
//                                  , PCEST.CODPROD
//                                  , PCEST.CUSTOFIN CUSTO
//                                  , PCEST.CODFILIAL
//                                  , NVL(PCMARCA.MARCA, 'FABRICANTE Padrao') FABRICANTE
//                                  , TRUNC((NVL(PCEST.QTRESERV, 0) * 0.5)) QTRESERVTOTAL
//                                  --, TRUNC( GREATEST(NVL(PCEST.QTESTGER, 0) - NVL(PCEST.QTRESERV, 0) - NVL(PCEST.QTBLOQUEADA, 0),0) * 0.5) QTESTOQUETOTAL                               
//                                  , CASE WHEN TRUNC( GREATEST(NVL(PCEST.QTESTGER, 0) - NVL(PCEST.QTRESERV, 0) - NVL(PCEST.QTBLOQUEADA, 0),0)) > 10 --Quantidade acima de 10
//                                          AND TRUNC( GREATEST(NVL(PCEST.QTESTGER, 0) - NVL(PCEST.QTRESERV, 0) - NVL(PCEST.QTBLOQUEADA, 0),0)) > (NVL(PCEST.QTGIRODIA,0) * 2) --Maior que o 2x o giro dia
//                                         THEN TRUNC( GREATEST(NVL(PCEST.QTESTGER, 0) - NVL(PCEST.QTRESERV, 0) - NVL(PCEST.QTBLOQUEADA, 0),0) * 0.5) 
//                                         ELSE 0
//                                    END QTESTOQUETOTAL                               
//                                  , NVL((SELECT MAX(PCEMBALAGEM.QTUNIT)
//                                           FROM PCEMBALAGEM
//                                          WHERE PCEMBALAGEM.CODPROD = PCEST.CODPROD
//                                            AND PCEMBALAGEM.CODFILIAL = PCEST.CODFILIAL
//                                            AND NVL(PCEMBALAGEM.EXCLUIDO,'N') = 'N' 
//                                            AND PCEMBALAGEM.SITUACAOWEB = 'D'
//                                            AND PCEMBALAGEM.DESCRICAOWEB IS NOT NULL
//                                        ), 1) QTUNITMAIOR
//
//                               FROM PCEST
//                                  , PCPRODUT
//                                  , PCFORNEC
//                                  , PCMARCA
//                              WHERE PCPRODUT.CODFORNEC = PCFORNEC.CODFORNEC
//                                AND PCPRODUT.CODPROD = PCEST.CODPROD
//                                AND PCPRODUT.DTEXCLUSAO IS NULL
//                                AND PCMARCA.CODMARCA(+) = PCPRODUT.CODMARCA
//                                AND PCEST.CODFILIAL = '" + Biblioteca.Dictionaries.Settings.CodFilialVenda() + "' " +
//                          @") A 
//                      WHERE B.CODFILIAL = A.CODFILIAL
//                        AND B.DESCRICAOWEB IS NOT NULL
//                        AND NVL(B.EXCLUIDO,'N') = 'N'
//                        AND B.SITUACAOWEB = 'D'
//                        AND B.CODPROD = A.CODPROD
//                        AND B.CODPROD = EMBALAGEMMAIOR.CODPROD(+)";
        }
        #endregion

        #region Atributos
        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 6)]
        public decimal Codprod
        {
            get { return codprod; }
            set { codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal sku;
        [XmlElement(ElementName = "SKU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal SKU
        {
            get { return sku; }
            set { sku = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENORCODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal menorcodauxiliar;
        [XmlElement(ElementName = "MENORCODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal MenorCodAuxiliar
        {
            get { return menorcodauxiliar; }
            set { menorcodauxiliar = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: QTEMBALAGEM
        /// Comentário: 
        /// </summary>
        private decimal qtembalagem;
        [XmlElement(ElementName = "QTEMBALAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Qtembalagem
        {
            get { return qtembalagem; }
            set { qtembalagem = value; }
        }

        
        /// <summary>
        /// Propriedade referente ao campo: FABRICANTE
        /// Comentário: 
        /// </summary>
        private string fabricante;
        [XmlElement(ElementName = "FABRICANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_VINCULOWEB
        /// Comentário: 
        /// </summary>
        private string esc_vinculoweb;
        [XmlElement(ElementName = "ESC_VINCULOWEB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Esc_vinculoweb
        {
            get { return esc_vinculoweb; }
            set { esc_vinculoweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string Codfilial
        {
            get { return codfilial; }
            set { codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codfornec
        {
            get { return codfornec; }
            set { codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CATEGORIZADOR
        /// Comentário: Codigo do Departamento na WEB
        /// </summary>
        private string categorizador;
        [XmlElement(ElementName = "CATEGORIZADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Categorizador
        {
            get { return categorizador; }
            set { categorizador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEPTOWEB
        /// Comentário: Codigo do Departamento na WEB
        /// </summary>
        private decimal coddeptoweb;
        [XmlElement(ElementName = "CODDEPTOWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Coddeptoweb
        {
            get { return coddeptoweb; }
            set { coddeptoweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIAWEB
        /// Comentário: Codigo do Categoria na WEB
        /// </summary>
        private decimal codcategoriaweb;
        [XmlElement(ElementName = "CODCATEGORIAWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Codcategoriaweb
        {
            get { return codcategoriaweb; }
            set { codcategoriaweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBCATEGORIAWEB
        /// Comentário: Codigo do Sub-categoria na WEB
        /// </summary>
        private decimal codsubcategoriaweb;
        [XmlElement(ElementName = "CODSUBCATEGORIAWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Codsubcategoriaweb
        {
            get { return codsubcategoriaweb; }
            set { codsubcategoriaweb = value; }
        }

        /// <summary>                       
        /// Propriedade referente ao campo: CODSECAOWEB
        /// Comentário: Codigo da seção na WEB
        /// </summary>
        private decimal codsecaoweb;
        [XmlElement(ElementName = "CODSECAOWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Codsecaoweb
        {
            get { return codsecaoweb; }
            set { codsecaoweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOWEB
        /// Comentário: Descrição do Produto
        /// </summary>
        private string descricaoWEB;
        [XmlElement(ElementName = "DESCRICAOWEB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 200)]
        public string DescricaoWEB
        {
            get { return descricaoWEB; }
            set { descricaoWEB = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INFOPRODWEB
        /// Comentário: Informação do produto na WEB
        /// </summary>
        private string infoprodweb;
        [XmlElement(ElementName = "INFOPRODWEB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Infoprodweb
        {
            get { return infoprodweb; }
            set { infoprodweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICACOES
        /// Comentário: Aplicações
        /// </summary>
        private string aplicacoes;
        [XmlElement(ElementName = "APLICACOES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Aplicacoes
        {
            get { return aplicacoes; }
            set { aplicacoes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INFORMACOESTECNICAS
        /// Comentário: Informação tecnicas
        /// </summary>
        private string informacoestecnicas;
        [XmlElement(ElementName = "INFORMACOESTECNICAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Informacoestecnicas
        {
            get { return informacoestecnicas; }
            set { informacoestecnicas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DADOSTECNICOS
        /// Comentário: Dados tecnicas
        /// </summary>
        private string dadostecnicos;
        [XmlElement(ElementName = "DADOSTECNICOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Dadostecnicos
        {
            get { return dadostecnicos; }
            set { dadostecnicos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição do Produto
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Comentário: 
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 12)]
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
        [DataObjectField(false, false, true, 12)]
        public decimal Poferta
        {
            get { return poferta; }
            set { poferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNITARIO
        /// Comentário: 
        /// </summary>
        private decimal punitario;
        [XmlElement(ElementName = "PUNITARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 12)]
        public decimal Punitario
        {
            get { return punitario; }
            set { punitario = value; }
        }
 
        
        /// <summary>
        /// Propriedade referente ao campo: PESO
        /// Comentário: Indica o Peso da embalagem. 
        /// </summary>
        private decimal peso;
        [XmlElement(ElementName = "PESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURA
        /// Comentário: Altura da embalagem
        /// </summary>
        private decimal altura;
        [XmlElement(ElementName = "ALTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRIMENTO
        /// Comentário: Comprimento da embalagem
        /// </summary>
        private decimal comprimento;
        [XmlElement(ElementName = "COMPRIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Comprimento
        {
            get { return comprimento; }
            set { comprimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURA
        /// Comentário: Largura da embalagem
        /// </summary>
        private decimal largura;
        [XmlElement(ElementName = "LARGURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRETEGRATIS
        /// Comentário: Frete grátis
        /// </summary>
        private decimal fretegratis;
        [XmlElement(ElementName = "FRETEGRATIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public decimal Fretegratis
        {
            get { return fretegratis; }
            set { fretegratis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOENTREGA
        /// Comentário: Frete grátis
        /// </summary>
        private decimal prazoentrega;
        [XmlElement(ElementName = "PRAZOENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public decimal Prazoentrega
        {
            get { return prazoentrega; }
            set { prazoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TROCAGRATIS
        /// Comentário: Troca grátis
        /// </summary>
        private decimal trocagratis;
        [XmlElement(ElementName = "TROCAGRATIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public decimal Trocagratis
        {
            get { return trocagratis; }
            set { trocagratis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTO
        /// Comentário: Valor do custo da embalagem
        /// </summary>
        private decimal custo;
        [XmlElement(ElementName = "CUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 18)]
        public decimal Custo
        {
            get { return custo; }
            set { custo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNIT
        /// Comentário: Quantidade do estoque gerencial
        /// </summary>
        private decimal qtunit;
        [XmlElement(ElementName = "QTUNIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtunit
        {
            get { return qtunit; }
            set { qtunit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTOQUE
        /// Comentário: Quantidade do estoque gerencial
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
        /// Propriedade referente ao campo: NUMERO
        /// Comentário: Indica o numero do endereço.
        /// </summary>
        private string numero;
        [XmlElement(ElementName = "NUMERO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: FORNECEDOR
        /// Comentário: 
        /// </summary>
        private string fornecedor;
        [XmlElement(ElementName = "FORNECEDOR", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 60)]
        public string Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Comentário: Indica o complemento do endereço.
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 80)]
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Comentário: 
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Comentário: 
        /// </summary>
        private string cidade;
        [XmlElement(ElementName = "CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 15)]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Comentário: 
        /// </summary>
        private string estado;
        [XmlElement(ElementName = "ESTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Comentário: 
        /// </summary>
        private string cep;
        [XmlElement(ElementName = "CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 9)]
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Comentário: Endereço do fornecedor
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: CGC
        /// Comentário: 
        /// </summary>
        private string cgc;
        [XmlElement(ElementName = "CGC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 18)]
        public string Cgc
        {
            get { return cgc; }
            set { cgc = value; }
        }
        #endregion
    }
}