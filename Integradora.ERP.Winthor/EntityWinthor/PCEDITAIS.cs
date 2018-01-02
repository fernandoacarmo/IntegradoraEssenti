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
    /// Classe referente a tabela PCEditais
    /// </summary>
    [XmlType("PCEDITAIS")]
    public class PCEditais : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODATIV
        /// Coment�rio: C�digo atividade.
        /// </summary>
        private decimal codativ;
        [XmlElement(ElementName = "CODATIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codativ
        {
            get { return  codativ; }
            set {  codativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Coment�rio: C�digo banco.
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo cliente.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEDITAL
        /// Coment�rio: C�digo edital.
        /// </summary>
        private decimal codedital;
        [XmlElement(ElementName = "CODEDITAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Codedital
        {
            get { return  codedital; }
            set {  codedital = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo Filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMODALIDADE
        /// Coment�rio: C�digo modalidade.
        /// </summary>
        private decimal codmodalidade;
        [XmlElement(ElementName = "CODMODALIDADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codmodalidade
        {
            get { return  codmodalidade; }
            set {  codmodalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDICOES_PAGAMENTO
        /// Coment�rio: Condi��es do pagamento.
        /// </summary>
        private string condicoes_pagamento;
        [XmlElement(ElementName = "CONDICOES_PAGAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Condicoes_Pagamento
        {
            get { return  condicoes_pagamento; }
            set {  condicoes_pagamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_ABERTURA_LICITACAO
        /// Coment�rio: Data da abertura da licita��o.
        /// </summary>
        private DateTime? data_abertura_licitacao;
        [XmlElement(ElementName = "DATA_ABERTURA_LICITACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data_Abertura_Licitacao
        {
            get { return  data_abertura_licitacao; }
            set {  data_abertura_licitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_ENTREGA_ENVELOPES
        /// Coment�rio: Data da entrega dos envelopes.
        /// </summary>
        private DateTime? data_entrega_envelopes;
        [XmlElement(ElementName = "DATA_ENTREGA_ENVELOPES", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data_Entrega_Envelopes
        {
            get { return  data_entrega_envelopes; }
            set {  data_entrega_envelopes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DECIMAIS
        /// Coment�rio: Decimais.
        /// </summary>
        private decimal decimais;
        [XmlElement(ElementName = "DECIMAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Decimais
        {
            get { return  decimais; }
            set {  decimais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DECLARACAO_CREDENCIAMENTO
        /// Coment�rio: Declara��o do credenciamento.
        /// </summary>
        private string declaracao_credenciamento;
        [XmlElement(ElementName = "DECLARACAO_CREDENCIAMENTO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Declaracao_Credenciamento
        {
            get { return  declaracao_credenciamento; }
            set {  declaracao_credenciamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DECLARACAO_HABILITACAO
        /// Coment�rio: Declara��o da habilita��o.
        /// </summary>
        private string declaracao_habilitacao;
        [XmlElement(ElementName = "DECLARACAO_HABILITACAO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Declaracao_Habilitacao
        {
            get { return  declaracao_habilitacao; }
            set {  declaracao_habilitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DECLARACAO_INEXISTENCIA
        /// Coment�rio: Declara��o da inexistencia.
        /// </summary>
        private string declaracao_inexistencia;
        [XmlElement(ElementName = "DECLARACAO_INEXISTENCIA", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Declaracao_Inexistencia
        {
            get { return  declaracao_inexistencia; }
            set {  declaracao_inexistencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DECLARACAO_MENORES
        /// Coment�rio: Declara��o dos menores.
        /// </summary>
        private string declaracao_menores;
        [XmlElement(ElementName = "DECLARACAO_MENORES", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Declaracao_Menores
        {
            get { return  declaracao_menores; }
            set {  declaracao_menores = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA_ABERTURA_LICITACAO
        /// Coment�rio: Hora da abertura da Licitacao.
        /// </summary>
        private DateTime? hora_abertura_licitacao;
        [XmlElement(ElementName = "HORA_ABERTURA_LICITACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hora_Abertura_Licitacao
        {
            get { return  hora_abertura_licitacao; }
            set {  hora_abertura_licitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA_ENTREGA_ENVELOPES
        /// Coment�rio: Hora da entrega dos envelopes.
        /// </summary>
        private DateTime? hora_entrega_envelopes;
        [XmlElement(ElementName = "HORA_ENTREGA_ENVELOPES", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hora_Entrega_Envelopes
        {
            get { return  hora_entrega_envelopes; }
            set {  hora_entrega_envelopes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Coment�rio: Matricula.
        /// </summary>
        private decimal matricula;
        [XmlElement(ElementName = "MATRICULA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Matricula
        {
            get { return  matricula; }
            set {  matricula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO_CONTA
        /// Coment�rio: Numero da conta.
        /// </summary>
        private string numero_conta;
        [XmlElement(ElementName = "NUMERO_CONTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numero_Conta
        {
            get { return  numero_conta; }
            set {  numero_conta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO_EMPENHO
        /// Coment�rio: Numero do empenho.
        /// </summary>
        private string numero_empenho;
        [XmlElement(ElementName = "NUMERO_EMPENHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numero_Empenho
        {
            get { return  numero_empenho; }
            set {  numero_empenho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO_LICITACAO
        /// Coment�rio: Numero licitacao.
        /// </summary>
        private string numero_licitacao;
        [XmlElement(ElementName = "NUMERO_LICITACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numero_Licitacao
        {
            get { return  numero_licitacao; }
            set {  numero_licitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO_PROCESSO
        /// Coment�rio: Numero processo.
        /// </summary>
        private string numero_processo;
        [XmlElement(ElementName = "NUMERO_PROCESSO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numero_Processo
        {
            get { return  numero_processo; }
            set {  numero_processo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBJETO
        /// Coment�rio: Obejto.
        /// </summary>
        private string objeto;
        [XmlElement(ElementName = "OBJETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Objeto
        {
            get { return  objeto; }
            set {  objeto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Coment�rio: Observa��o.
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO_EMPENHO
        /// Coment�rio: Observa��o do empenho.
        /// </summary>
        private string observacao_empenho;
        [XmlElement(ElementName = "OBSERVACAO_EMPENHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Observacao_Empenho
        {
            get { return  observacao_empenho; }
            set {  observacao_empenho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO_MAPA_PRECOS
        /// Coment�rio: Observa��o mapa dos pre�os.
        /// </summary>
        private string observacao_mapa_precos;
        [XmlElement(ElementName = "OBSERVACAO_MAPA_PRECOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Observacao_Mapa_Precos
        {
            get { return  observacao_mapa_precos; }
            set {  observacao_mapa_precos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO_PROPOSTA
        /// Coment�rio: Observa��o da proposta.
        /// </summary>
        private string observacao_proposta;
        [XmlElement(ElementName = "OBSERVACAO_PROPOSTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Observacao_Proposta
        {
            get { return  observacao_proposta; }
            set {  observacao_proposta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_ACRESCIMO
        /// Coment�rio: Percentual de acrescimo.
        /// </summary>
        private decimal percentual_acrescimo;
        [XmlElement(ElementName = "PERCENTUAL_ACRESCIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percentual_Acrescimo
        {
            get { return  percentual_acrescimo; }
            set {  percentual_acrescimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_DECRESCIMO
        /// Coment�rio: Percentual de decrescimo.
        /// </summary>
        private decimal percentual_decrescimo;
        [XmlElement(ElementName = "PERCENTUAL_DECRESCIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percentual_Decrescimo
        {
            get { return  percentual_decrescimo; }
            set {  percentual_decrescimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO_ENTREGA
        /// Coment�rio: Prazo de entrega.
        /// </summary>
        private string prazo_entrega;
        [XmlElement(ElementName = "PRAZO_ENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Prazo_Entrega
        {
            get { return  prazo_entrega; }
            set {  prazo_entrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROPOSTA_ICMS
        /// Coment�rio: Proposta de ICMS.
        /// </summary>
        private string proposta_icms;
        [XmlElement(ElementName = "PROPOSTA_ICMS", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Proposta_Icms
        {
            get { return  proposta_icms; }
            set {  proposta_icms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: Status.
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS_CLIENTE
        /// Coment�rio: Status do cliente.
        /// </summary>
        private string status_cliente;
        [XmlElement(ElementName = "STATUS_CLIENTE", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status_Cliente
        {
            get { return  status_cliente; }
            set {  status_cliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO_PROPOSTA
        /// Coment�rio: Tipo da proposta.
        /// </summary>
        private string tipo_proposta;
        [XmlElement(ElementName = "TIPO_PROPOSTA", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Tipo_Proposta
        {
            get { return  tipo_proposta; }
            set {  tipo_proposta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDADE_PRODUTOS
        /// Coment�rio: Validade dos produtos.
        /// </summary>
        private string validade_produtos;
        [XmlElement(ElementName = "VALIDADE_PRODUTOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Validade_Produtos
        {
            get { return  validade_produtos; }
            set {  validade_produtos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDADE_PROPOSTA
        /// Coment�rio: Validade da proposta.
        /// </summary>
        private string validade_proposta;
        [XmlElement(ElementName = "VALIDADE_PROPOSTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Validade_Proposta
        {
            get { return  validade_proposta; }
            set {  validade_proposta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR_ICMS
        /// Coment�rio: Valor do ICMS.
        /// </summary>
        private decimal valor_icms;
        [XmlElement(ElementName = "VALOR_ICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valor_Icms
        {
            get { return  valor_icms; }
            set {  valor_icms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICAR_CERTIFICADO
        /// Coment�rio: Verifica certificado.
        /// </summary>
        private string verificar_certificado;
        [XmlElement(ElementName = "VERIFICAR_CERTIFICADO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Verificar_Certificado
        {
            get { return  verificar_certificado; }
            set {  verificar_certificado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICAR_REGISTRO
        /// Coment�rio: Verifica registro.
        /// </summary>
        private string verificar_registro;
        [XmlElement(ElementName = "VERIFICAR_REGISTRO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Verificar_Registro
        {
            get { return  verificar_registro; }
            set {  verificar_registro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VIGENCIA
        /// Coment�rio: Vigencia.
        /// </summary>
        private string vigencia;
        [XmlElement(ElementName = "VIGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Vigencia
        {
            get { return  vigencia; }
            set {  vigencia = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEditais()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEDITAIS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEditais> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEditais>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEditais> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEditais>(where);
        }

        #endregion
    }
}
