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
    /// Classe referente ao select VWPedidoInternit
    /// </summary>
    [XmlType("VWPEDIDOINTERNIT")]
    public class VWPedidoInternit: OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWPedidoInternit()
        {
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWPedidoInternit> Listar(string where)
        {
            Persistencia ba = new Persistencia(VWPedidoInternit.GetStringConnection());
            return ba.Listar<VWPedidoInternit>(GetSelect(), where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWPedidoInternit> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(VWPedidoInternit.GetStringConnection());
            return ba.Existe<VWPedidoInternit>(where);
        }

        public static string GetFiltro()
        {
            string filtro = @" PCPEDC.DTCANCEL IS NULL
                                 AND PCPEDC.POSICAO IN ('L', 'M')
                                 AND PCPEDC.CODCOB IN ('CPGE')
                                 AND PCPEDC.DATA BETWEEN TRUNC(SYSDATE)-100 AND TRUNC(SYSDATE)
                                 AND PCPEDC.ESC_DTENVIOINTERNIT IS NULL";
            return filtro;
        }
        /// <summary>
        /// Retorna o select de obteção dos registros
        /// </summary>
        public static string GetSelect()
        {
            return @"SELECT A.*
                       FROM (SELECT PCPEDC.CODFILIAL
                                  , TO_CHAR(PCPEDC.NUMPED) NUMERO
                                  , TO_CHAR(PCPEDC.DATA, 'yyyy-MM-dd HH24:mm:ss') CRIACAO
                                  , TO_CHAR(PCPEDC.CODCLI) CODIGO
                                  , PCCLIENT.CLIENTE NOME
                                  , PCPEDC.ROWID RID
                                  , PCPRODUT.CODPROD
                                  , PCPRODUT.DESCRICAO
                                  , ROUND(PCPEDI.QT,2) QT
                                  , ROUND(PCPEDI.PVENDA,2) PVENDA
                                  , PCFILIAL.RAZAOSOCIAL FILIAL
                                  , ROUND(nvl(PCPEDC.VLFRETE,0),2) VALORFRETE
                                  , PCPLPAG.DESCRICAO PLANOPAGAMENTO
                                  , PCCOB.COBRANCA
                                  , REGEXP_REPLACE(PCCLIENT.CGCENT, '[^0-9]','')  CPFCNPJ
                                  , NVL(PCCLIENT.EMAIL, PCCLIENT.EMAILNFE) EMAIL
                                  , PCCLIENT.ENDERENT LOGRADOURO
                                  , PCCLIENT.NUMEROENT NUMEROENDERECO
                                  , PCCLIENT.MUNICENT CIDADE
                                  , PCCLIENT.BAIRROENT BAIRRO
                                  , PCCLIENT.COMPLEMENTOENT COMPLEMENTO
                                  , PCCLIENT.ESTENT ESTADO
                                  , REGEXP_REPLACE(PCCLIENT.CEPENT, '[^0-9]','')  CEP
                                  , PCUSUARI.EMAIL EMAILRCA
                                  , PCUSUARI.NOME NOMERCA
                                  , TO_CHAR(PCUSUARI.CODUSUR) CODIGORCA
                                  , GREATEST(GREATEST(NVL(PCPLPAG.NUMPARCELAS, 0)
                                                         , DECODE(PCPLPAG.PRAZO1, NULL, 0, 1)
                                                         + DECODE(PCPLPAG.PRAZO2, NULL, 0, 1)
                                                         + DECODE(PCPLPAG.PRAZO3, NULL, 0, 1)
                                                         + DECODE(PCPLPAG.PRAZO4, NULL, 0, 1)
                                                         + DECODE(PCPLPAG.PRAZO5, NULL, 0, 1)
                                                         + DECODE(PCPLPAG.PRAZO6, NULL, 0, 1)
                                                         + DECODE(PCPLPAG.PRAZO7, NULL, 0, 1)
                                                         + DECODE(PCPLPAG.PRAZO8, NULL, 0, 1)
                                                         + DECODE(PCPLPAG.PRAZO9, NULL, 0, 1)
                                                         + DECODE(PCPLPAG.PRAZO10, NULL, 0, 1)), 1) NUMPARCELAS
                               FROM PCPEDC
                                  , PCCLIENT
                                  , PCPEDI
                                  , PCPRODUT
                                  , PCUSUARI
                                  , PCFILIAL
                                  , PCPLPAG
                                  , PCCOB
                              WHERE PCPEDC.CODCLI = PCCLIENT.CODCLI
                                AND PCPEDC.NUMPED = PCPEDI.NUMPED
                                AND PCPEDC.CODUSUR = PCUSUARI.CODUSUR
                                AND PCPEDC.CODPLPAG = PCPLPAG.CODPLPAG
                                AND PCPEDC.CODCOB = PCCOB.CODCOB(+)
                                AND PCPEDI.CODPROD = PCPRODUT.CODPROD
                                AND NVL(PCPEDC.CODFILIALNF, PCPEDC.CODFILIAL) = PCFILIAL.CODIGO
                                AND " + GetFiltro() +                                          
                                @") A
                          WHERE 1=1";
        }
        #endregion

        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: RID
        /// Comentário: 
        /// </summary>
        private string rid;
        [XmlElement(ElementName = "RID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 40)]
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
        /// Propriedade referente ao campo: NUMERO
        /// Comentário: 
        /// </summary>
        private string numero;
        [XmlElement(ElementName = "NUMERO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 15)]
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRIACAO
        /// Comentário: 
        /// </summary>
        private string criacao;
        [XmlElement(ElementName = "CRIACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, false, 15)]
        public string Criacao
        {
            get { return criacao; }
            set { criacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private string codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, false, 15)]
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Comentário: 
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, false, 15)]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codprod
        {
            get { return codprod; }
            set { codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPARCELAS
        /// Comentário: 
        /// </summary>
        private decimal numparcelas;
        [XmlElement(ElementName = "NUMPARCELAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, false, 6)]
        public decimal Numparcelas
        {
            get { return numparcelas; }
            set { numparcelas = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, false, 60)]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qt
        {
            get { return qt; }
            set { qt = value; }
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
        /// Propriedade referente ao campo: FILIAL
        /// Comentário: 
        /// </summary>
        private string filial;
        [XmlElement(ElementName = "FILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string Filial
        {
            get { return filial; }
            set { filial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORFRETE
        /// Comentário: 
        /// </summary>
        private decimal valorfrete;
        [XmlElement(ElementName = "VALORFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal ValorFrete
        {
            get { return valorfrete; }
            set { valorfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLANOPAGAMENTO
        /// Comentário: 
        /// </summary>
        private string planopagamento;
        [XmlElement(ElementName = "PLANOPAGAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string PlanoPagamento
        {
            get { return planopagamento; }
            set { planopagamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COBRANCA
        /// Comentário: 
        /// </summary>
        private string cobranca;
        [XmlElement(ElementName = "COBRANCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string Cobranca
        {
            get { return cobranca; }
            set { cobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CPFCNPJ
        /// Comentário: 
        /// </summary>
        private string cpfcnpj;
        [XmlElement(ElementName = "CPFCNPJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string CpfCNPJ
        {
            get { return cpfcnpj; }
            set { cpfcnpj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Comentário: 
        /// </summary>
        private string email;
        [XmlElement(ElementName = "EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOGRADOURO
        /// Comentário: 
        /// </summary>
        private string logradouro;
        [XmlElement(ElementName = "LOGRADOURO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Comentário: 
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROENDERECO
        /// Comentário: 
        /// </summary>
        private string numeroendereco;
        [XmlElement(ElementName = "NUMEROENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string NumeroEndereco
        {
            get { return numeroendereco; }
            set { numeroendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Comentário: 
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
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
        [DataObjectField(false, false, true, 22)]
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
        [DataObjectField(false, false, true, 22)]
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
        [DataObjectField(false, false, true, 22)]
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAILRCA
        /// Comentário: 
        /// </summary>
        private string emailrca;
        [XmlElement(ElementName = "EMAILRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string emailRca
        {
            get { return emailrca; }
            set { emailrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGORCA
        /// Comentário: 
        /// </summary>
        private string codigorca;
        [XmlElement(ElementName = "CODIGORCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string codigoRca
        {
            get { return codigorca; }
            set { codigorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMERCA
        /// Comentário: 
        /// </summary>
        private string nomerca;
        [XmlElement(ElementName = "NOMERCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string nomeRca
        {
            get { return nomerca; }
            set { nomerca = value; }
        }

        
        #endregion
    }
}
