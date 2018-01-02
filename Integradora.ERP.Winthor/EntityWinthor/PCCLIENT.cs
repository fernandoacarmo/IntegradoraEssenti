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
    /// Classe referente a tabela PCClient
    /// </summary>
    [XmlType("PCCLIENT")]
    public class PCClient : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITACHTERCEIROS
        /// Comentário: 
        /// </summary>
        private string aceitachterceiros;
        [XmlElement(ElementName = "ACEITACHTERCEIROS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitachterceiros
        {
            get { return  aceitachterceiros; }
            set {  aceitachterceiros = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: ESC_TIPOCLIENTE
        /// Comentário: Verifica se o cliente e ou não aposentado
        /// </summary>
        private string esc_tipocliente;
        [XmlElement(ElementName = "ESC_TIPOCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Esc_Tipocliente
        {
            get { return esc_tipocliente; }
            set { esc_tipocliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_APOSENTADO
        /// Comentário: Verifica se o cliente e ou não aposentado
        /// </summary>
        private string esc_aposentado;
        [XmlElement(ElementName = "ESC_APOSENTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Esc_Aposentado
        {
            get { return esc_aposentado; }
            set { esc_aposentado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_UC
        /// Comentário: Unidade consumidora utilizado no projeto da UseAll
        /// </summary>
        private string esc_uc;
        [XmlElement(ElementName = "ESC_UC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Esc_UC
        {
            get { return esc_uc; }
            set { esc_uc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_CODASSOCIADO
        /// Comentário: Código do associado no projeto da UseAll
        /// </summary>
        private string esc_codassociado;
        [XmlElement(ElementName = "ESC_CODASSOCIADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Esc_codassociado
        {
            get { return esc_codassociado; }
            set { esc_codassociado = value; }
        }        

        /// <summary>
        /// Propriedade referente ao campo: ESC_DIAVECTO
        /// Comentário: Dia de vencimento da fatura utilizado no projeto da UseAll
        /// </summary>
        private decimal esc_diavecto;
        [XmlElement(ElementName = "ESC_DIAVECTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public decimal Esc_diavecto
        {
            get { return esc_diavecto; }
            set { esc_diavecto = value; }
        }        


        /// <summary>
        /// Propriedade referente ao campo: ACEITASIMILAR
        /// Comentário: Aceita o envio de produtos similares
        /// </summary>
        private string aceitasimilar;
        [XmlElement(ElementName = "ACEITASIMILAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitasimilar
        {
            get { return  aceitasimilar; }
            set {  aceitasimilar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITATROCANEGATIVA
        /// Comentário: Indica se aceita pedido de troca com valor negativo. 
        /// </summary>
        private string aceitatrocanegativa;
        [XmlElement(ElementName = "ACEITATROCANEGATIVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitatrocanegativa
        {
            get { return  aceitatrocanegativa; }
            set {  aceitatrocanegativa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITAVENDAFRACAO
        /// Comentário: 
        /// </summary>
        private string aceitavendafracao;
        [XmlElement(ElementName = "ACEITAVENDAFRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitavendafracao
        {
            get { return  aceitavendafracao; }
            set {  aceitavendafracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AGREGARVALORSTDESCFIN
        /// Comentário: Desconto financeiro sem st
        /// </summary>
        private string agregarvalorstdescfin;
        [XmlElement(ElementName = "AGREGARVALORSTDESCFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agregarvalorstdescfin
        {
            get { return  agregarvalorstdescfin; }
            set {  agregarvalorstdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1
        /// Comentário: 
        /// </summary>
        private decimal aliqicms1;
        [XmlElement(ElementName = "ALIQICMS1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms1
        {
            get { return  aliqicms1; }
            set {  aliqicms1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANALISECRED
        /// Comentário: 
        /// </summary>
        private string analisecred;
        [XmlElement(ElementName = "ANALISECRED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Analisecred
        {
            get { return  analisecred; }
            set {  analisecred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISA
        /// Comentário: Medicamento controlado pela anvisa.
        /// </summary>
        private string anvisa;
        [XmlElement(ElementName = "ANVISA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Anvisa
        {
            get { return  anvisa; }
            set {  anvisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICADESCNF
        /// Comentário: 
        /// </summary>
        private string aplicadescnf;
        [XmlElement(ElementName = "APLICADESCNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicadescnf
        {
            get { return  aplicadescnf; }
            set {  aplicadescnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICREDBASEICMSTRANSP
        /// Comentário: Aplica Redução na Base ICMS de Transporte
        /// </summary>
        private string aplicredbaseicmstransp;
        [XmlElement(ElementName = "APLICREDBASEICMSTRANSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicredbaseicmstransp
        {
            get { return  aplicredbaseicmstransp; }
            set {  aplicredbaseicmstransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AREALOJAM2
        /// Comentário: Indica a area loja M2.
        /// </summary>
        private decimal arealojam2;
        [XmlElement(ElementName = "AREALOJAM2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Arealojam2
        {
            get { return  arealojam2; }
            set {  arealojam2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATENDEDOMINGO
        /// Comentário: Indica se o cliente e atendido no Domingo.
        /// </summary>
        private string atendedomingo;
        [XmlElement(ElementName = "ATENDEDOMINGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atendedomingo
        {
            get { return  atendedomingo; }
            set {  atendedomingo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATENDEQUARTA
        /// Comentário: Indica se o cliente e atendido na Quarta.
        /// </summary>
        private string atendequarta;
        [XmlElement(ElementName = "ATENDEQUARTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atendequarta
        {
            get { return  atendequarta; }
            set {  atendequarta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATENDEQUINTA
        /// Comentário: Indica se o cliente e atendido na Quinta.
        /// </summary>
        private string atendequinta;
        [XmlElement(ElementName = "ATENDEQUINTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atendequinta
        {
            get { return  atendequinta; }
            set {  atendequinta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATENDESABADO
        /// Comentário: Indica se o cliente e atendido no Sábado.
        /// </summary>
        private string atendesabado;
        [XmlElement(ElementName = "ATENDESABADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atendesabado
        {
            get { return  atendesabado; }
            set {  atendesabado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATENDESEGUNDA
        /// Comentário: Indica se o cliente e atendido na Segunda.
        /// </summary>
        private string atendesegunda;
        [XmlElement(ElementName = "ATENDESEGUNDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atendesegunda
        {
            get { return  atendesegunda; }
            set {  atendesegunda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATENDESEXTA
        /// Comentário: Indica se o cliente e atendido na Sexta.
        /// </summary>
        private string atendesexta;
        [XmlElement(ElementName = "ATENDESEXTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atendesexta
        {
            get { return  atendesexta; }
            set {  atendesexta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATENDETERCA
        /// Comentário: Indica se o cliente e atendido na Terça.
        /// </summary>
        private string atendeterca;
        [XmlElement(ElementName = "ATENDETERCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atendeterca
        {
            get { return  atendeterca; }
            set {  atendeterca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZASALDOCCDESCFIN
        /// Comentário: Indicar se o RCA vai receber débito\crédito no desconto financeiro.
        /// </summary>
        private string atualizasaldoccdescfin;
        [XmlElement(ElementName = "ATUALIZASALDOCCDESCFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizasaldoccdescfin
        {
            get { return  atualizasaldoccdescfin; }
            set {  atualizasaldoccdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRROCOB
        /// Comentário: 
        /// </summary>
        private string bairrocob;
        [XmlElement(ElementName = "BAIRROCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Bairrocob
        {
            get { return  bairrocob; }
            set {  bairrocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRROCOM
        /// Comentário: 
        /// </summary>
        private string bairrocom;
        [XmlElement(ElementName = "BAIRROCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Bairrocom
        {
            get { return  bairrocom; }
            set {  bairrocom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRROENT
        /// Comentário: 
        /// </summary>
        private string bairroent;
        [XmlElement(ElementName = "BAIRROENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Bairroent
        {
            get { return  bairroent; }
            set {  bairroent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQREMCOB
        /// Comentário: 
        /// </summary>
        private string bloqremcob;
        [XmlElement(ElementName = "BLOQREMCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqremcob
        {
            get { return  bloqremcob; }
            set {  bloqremcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIO
        /// Comentário: 
        /// </summary>
        private string bloqueio;
        [XmlElement(ElementName = "BLOQUEIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueio
        {
            get { return  bloqueio; }
            set {  bloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIODATACHEQ
        /// Comentário: Indica se o cliete foi bloqueado pleo Datacheq.
        /// </summary>
        private string bloqueiodatacheq;
        [XmlElement(ElementName = "BLOQUEIODATACHEQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueiodatacheq
        {
            get { return  bloqueiodatacheq; }
            set {  bloqueiodatacheq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIODEFINITIVO
        /// Comentário: Indica o bloqueio definitivo do cliente.
        /// </summary>
        private string bloqueiodefinitivo;
        [XmlElement(ElementName = "BLOQUEIODEFINITIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueiodefinitivo
        {
            get { return  bloqueiodefinitivo; }
            set {  bloqueiodefinitivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIOSEFAZ
        /// Comentário: Campo de status de bloqueio na SEFAZ.
        /// </summary>
        private string bloqueiosefaz;
        [XmlElement(ElementName = "BLOQUEIOSEFAZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueiosefaz
        {
            get { return  bloqueiosefaz; }
            set {  bloqueiosefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIOSEFAZPED
        /// Comentário: Campo para Indentificar Clientes com Pedidos Bloqueados.
        /// </summary>
        private string bloqueiosefazped;
        [XmlElement(ElementName = "BLOQUEIOSEFAZPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueiosefazped
        {
            get { return  bloqueiosefazped; }
            set {  bloqueiosefazped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQVENDAPF
        /// Comentário: Indica se as vendas para pessoa física deverão ou não ser permitidas.
        /// </summary>
        private string bloqvendapf;
        [XmlElement(ElementName = "BLOQVENDAPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqvendapf
        {
            get { return  bloqvendapf; }
            set {  bloqvendapf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CACEX
        /// Comentário: 
        /// </summary>
        private string cacex;
        [XmlElement(ElementName = "CACEX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Cacex
        {
            get { return  cacex; }
            set {  cacex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAIXAPOSTAL
        /// Comentário: 
        /// </summary>
        private decimal caixapostal;
        [XmlElement(ElementName = "CAIXAPOSTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Caixapostal
        {
            get { return  caixapostal; }
            set {  caixapostal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULAST
        /// Comentário: 
        /// </summary>
        private string calculast;
        [XmlElement(ElementName = "CALCULAST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calculast
        {
            get { return  calculast; }
            set {  calculast = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAPITALSOCIAL
        /// Comentário: 
        /// </summary>
        private decimal capitalsocial;
        [XmlElement(ElementName = "CAPITALSOCIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Capitalsocial
        {
            get { return  capitalsocial; }
            set {  capitalsocial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARGO
        /// Comentário: 
        /// </summary>
        private string cargo;
        [XmlElement(ElementName = "CARGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cargo
        {
            get { return  cargo; }
            set {  cargo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARGOCONJUGE
        /// Comentário: 
        /// </summary>
        private string cargoconjuge;
        [XmlElement(ElementName = "CARGOCONJUGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cargoconjuge
        {
            get { return  cargoconjuge; }
            set {  cargoconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEPCOB
        /// Comentário: 
        /// </summary>
        private string cepcob;
        [XmlElement(ElementName = "CEPCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cepcob
        {
            get { return  cepcob; }
            set {  cepcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEPCOM
        /// Comentário: 
        /// </summary>
        private string cepcom;
        [XmlElement(ElementName = "CEPCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cepcom
        {
            get { return  cepcom; }
            set {  cepcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEPCXPOSTAL
        /// Comentário: 
        /// </summary>
        private decimal cepcxpostal;
        [XmlElement(ElementName = "CEPCXPOSTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Cepcxpostal
        {
            get { return  cepcxpostal; }
            set {  cepcxpostal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEPENT
        /// Comentário: 
        /// </summary>
        private string cepent;
        [XmlElement(ElementName = "CEPENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cepent
        {
            get { return  cepent; }
            set {  cepent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCENT
        /// Comentário: 
        /// </summary>
        private string cgcent;
        [XmlElement(ElementName = "CGCENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgcent
        {
            get { return  cgcent; }
            set {  cgcent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCENTREGA
        /// Comentário: 
        /// </summary>
        private string cgcentrega;
        [XmlElement(ElementName = "CGCENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgcentrega
        {
            get { return  cgcentrega; }
            set {  cgcentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGEENTAUX
        /// Comentário: 
        /// </summary>
        private string cgeentaux;
        [XmlElement(ElementName = "CGEENTAUX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgeentaux
        {
            get { return  cgeentaux; }
            set {  cgeentaux = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSECOMERCIAL
        /// Comentário: 
        /// </summary>
        private string classecomercial;
        [XmlElement(ElementName = "CLASSECOMERCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classecomercial
        {
            get { return  classecomercial; }
            set {  classecomercial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSEMC
        /// Comentário: 
        /// </summary>
        private string classemc;
        [XmlElement(ElementName = "CLASSEMC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classemc
        {
            get { return  classemc; }
            set {  classemc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSEVENDA
        /// Comentário: 
        /// </summary>
        private string classevenda;
        [XmlElement(ElementName = "CLASSEVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classevenda
        {
            get { return  classevenda; }
            set {  classevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIATACADO
        /// Comentário: 
        /// </summary>
        private string cliatacado;
        [XmlElement(ElementName = "CLIATACADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cliatacado
        {
            get { return  cliatacado; }
            set {  cliatacado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLICRM
        /// Comentário: 
        /// </summary>
        private string clicrm;
        [XmlElement(ElementName = "CLICRM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Clicrm
        {
            get { return  clicrm; }
            set {  clicrm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTE
        /// Comentário: 
        /// </summary>
        private string cliente;
        [XmlElement(ElementName = "CLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Cliente
        {
            get { return  cliente; }
            set {  cliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTEDAN
        /// Comentário: 
        /// </summary>
        private string clientedan;
        [XmlElement(ElementName = "CLIENTEDAN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Clientedan
        {
            get { return  clientedan; }
            set {  clientedan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTEELETRO
        /// Comentário: 
        /// </summary>
        private string clienteeletro;
        [XmlElement(ElementName = "CLIENTEELETRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Clienteeletro
        {
            get { return  clienteeletro; }
            set {  clienteeletro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTEFONTEST
        /// Comentário: 
        /// </summary>
        private string clientefontest;
        [XmlElement(ElementName = "CLIENTEFONTEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Clientefontest
        {
            get { return  clientefontest; }
            set {  clientefontest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTEMONITORADO
        /// Comentário: 
        /// </summary>
        private string clientemonitorado;
        [XmlElement(ElementName = "CLIENTEMONITORADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Clientemonitorado
        {
            get { return  clientemonitorado; }
            set {  clientemonitorado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTE2
        /// Comentário: 
        /// </summary>
        private string cliente2;
        [XmlElement(ElementName = "CLIENTE2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Cliente2
        {
            get { return  cliente2; }
            set {  cliente2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTPROTESTO
        /// Comentário: 
        /// </summary>
        private string clientprotesto;
        [XmlElement(ElementName = "CLIENTPROTESTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Clientprotesto
        {
            get { return  clientprotesto; }
            set {  clientprotesto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJCISP
        /// Comentário: CNPJ para CISP.
        /// </summary>
        private string cnpjcisp;
        [XmlElement(ElementName = "CNPJCISP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Cnpjcisp
        {
            get { return  cnpjcisp; }
            set {  cnpjcisp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODATV1
        /// Comentário: 
        /// </summary>
        private decimal codatv1;
        [XmlElement(ElementName = "CODATV1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codatv1
        {
            get { return  codatv1; }
            set {  codatv1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBAIRROCOB
        /// Comentário: Código de bairro de Cobrança.
        /// </summary>
        private decimal? codbairrocob;
        [XmlElement(ElementName = "CODBAIRROCOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codbairrocob
        {
            get { return  codbairrocob; }
            set {  codbairrocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBAIRROCOM
        /// Comentário: Código de bairro de Entrega.
        /// </summary>
        private decimal? codbairrocom;
        [XmlElement(ElementName = "CODBAIRROCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codbairrocom
        {
            get { return  codbairrocom; }
            set {  codbairrocom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBAIRROENT
        /// Comentário: Código do bairro Comercial.
        /// </summary>
        private decimal? codbairroent;
        [XmlElement(ElementName = "CODBAIRROENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codbairroent
        {
            get { return  codbairroent; }
            set {  codbairroent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA
        /// Comentário: 
        /// </summary>
        private decimal codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBARRACOB
        /// Comentário: 
        /// </summary>
        private decimal codbarracob;
        [XmlElement(ElementName = "CODBARRACOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Codbarracob
        {
            get { return  codbarracob; }
            set {  codbarracob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBARRAENT
        /// Comentário: 
        /// </summary>
        private decimal codbarraent;
        [XmlElement(ElementName = "CODBARRAENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Codbarraent
        {
            get { return  codbarraent; }
            set {  codbarraent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCANAL
        /// Comentário: 
        /// </summary>
        private decimal codcanal;
        [XmlElement(ElementName = "CODCANAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcanal
        {
            get { return  codcanal; }
            set {  codcanal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADE
        /// Comentário: 
        /// </summary>
        private decimal codcidade;
        [XmlElement(ElementName = "CODCIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcidade
        {
            get { return  codcidade; }
            set {  codcidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADECOM
        /// Comentário: Cidade IBGE
        /// </summary>
        private decimal codcidadecom;
        [XmlElement(ElementName = "CODCIDADECOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcidadecom
        {
            get { return  codcidadecom; }
            set {  codcidadecom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIINT
        /// Comentário: Receber identificador do cliente.
        /// </summary>
        private decimal codcliint;
        [XmlElement(ElementName = "CODCLIINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcliint
        {
            get { return  codcliint; }
            set {  codcliint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIPALM
        /// Comentário: 
        /// </summary>
        private decimal codclipalm;
        [XmlElement(ElementName = "CODCLIPALM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codclipalm
        {
            get { return  codclipalm; }
            set {  codclipalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIPRINC
        /// Comentário: 
        /// </summary>
        private decimal codcliprinc;
        [XmlElement(ElementName = "CODCLIPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcliprinc
        {
            get { return  codcliprinc; }
            set {  codcliprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIWEB
        /// Comentário: Indica o código do cliente WEB.
        /// </summary>
        private decimal codcliweb;
        [XmlElement(ElementName = "CODCLIWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcliweb
        {
            get { return  codcliweb; }
            set {  codcliweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCNAE
        /// Comentário: Indica o código nacional de atividade econômica.
        /// </summary>
        private string codcnae;
        [XmlElement(ElementName = "CODCNAE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Codcnae
        {
            get { return  codcnae; }
            set {  codcnae = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBTV1
        /// Comentário: Código de cobrança boleto para venda normal.
        /// </summary>
        private string codcobtv1;
        [XmlElement(ElementName = "CODCOBTV1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobtv1
        {
            get { return  codcobtv1; }
            set {  codcobtv1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBTV3
        /// Comentário: Código de cobrança boleto para venda a faturar.
        /// </summary>
        private string codcobtv3;
        [XmlElement(ElementName = "CODCOBTV3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobtv3
        {
            get { return  codcobtv3; }
            set {  codcobtv3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONDICAOVENDA
        /// Comentário: 
        /// </summary>
        private decimal codcondicaovenda;
        [XmlElement(ElementName = "CODCONDICAOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcondicaovenda
        {
            get { return  codcondicaovenda; }
            set {  codcondicaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAB
        /// Comentário: Indica o código da conta contábil para o cliente.
        /// </summary>
        private string codcontab;
        [XmlElement(ElementName = "CODCONTAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Codcontab
        {
            get { return  codcontab; }
            set {  codcontab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALESTOQUE
        /// Comentário: 
        /// </summary>
        private string codfilialestoque;
        [XmlElement(ElementName = "CODFILIALESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Codfilialestoque
        {
            get { return  codfilialestoque; }
            set {  codfilialestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALNF
        /// Comentário: 
        /// </summary>
        private string codfilialnf;
        [XmlElement(ElementName = "CODFILIALNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialnf
        {
            get { return  codfilialnf; }
            set {  codfilialnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECFRETE
        /// Comentário: Indica o código da transportadora padrão.
        /// </summary>
        private decimal codfornecfrete;
        [XmlElement(ElementName = "CODFORNECFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecfrete
        {
            get { return  codfornecfrete; }
            set {  codfornecfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCAD
        /// Comentário: 
        /// </summary>
        private decimal codfunccad;
        [XmlElement(ElementName = "CODFUNCCAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccad
        {
            get { return  codfunccad; }
            set {  codfunccad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCADASTRO
        /// Comentário: 
        /// </summary>
        private decimal codfunccadastro;
        [XmlElement(ElementName = "CODFUNCCADASTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccadastro
        {
            get { return  codfunccadastro; }
            set {  codfunccadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANCPOTENCIALLIMCRED
        /// Comentário: 
        /// </summary>
        private decimal codfunclancpotenciallimcred;
        [XmlElement(ElementName = "CODFUNCLANCPOTENCIALLIMCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclancpotenciallimcred
        {
            get { return  codfunclancpotenciallimcred; }
            set {  codfunclancpotenciallimcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Comentário: 
        /// </summary>
        private decimal codfuncultalter;
        [XmlElement(ElementName = "CODFUNCULTALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultalter
        {
            get { return  codfuncultalter; }
            set {  codfuncultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTERCLIESP
        /// Comentário: 
        /// </summary>
        private decimal codfuncultaltercliesp;
        [XmlElement(ElementName = "CODFUNCULTALTERCLIESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultaltercliesp
        {
            get { return  codfuncultaltercliesp; }
            set {  codfuncultaltercliesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER1203
        /// Comentário: Código do funcionario que realizou a ultima alteração na 1203
        /// </summary>
        private decimal codfuncultalter1203;
        [XmlElement(ElementName = "CODFUNCULTALTER1203", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultalter1203
        {
            get { return  codfuncultalter1203; }
            set {  codfuncultalter1203 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTCONTATOCOB
        /// Comentário: 
        /// </summary>
        private decimal codfuncultcontatocob;
        [XmlElement(ElementName = "CODFUNCULTCONTATOCOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultcontatocob
        {
            get { return  codfuncultcontatocob; }
            set {  codfuncultcontatocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGLN
        /// Comentário: Código GLN
        /// </summary>
        private decimal? codgln;
        [XmlElement(ElementName = "CODGLN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal? Codgln
        {
            get { return  codgln; }
            set {  codgln = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHIST
        /// Comentário: Código do histórico de bloqueio.
        /// </summary>
        private decimal codhist;
        [XmlElement(ElementName = "CODHIST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codhist
        {
            get { return  codhist; }
            set {  codhist = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMUNICIPIO
        /// Comentário: 
        /// </summary>
        private decimal codmunicipio;
        [XmlElement(ElementName = "CODMUNICIPIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codmunicipio
        {
            get { return  codmunicipio; }
            set {  codmunicipio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNILSEN
        /// Comentário: 
        /// </summary>
        private string codnilsen;
        [XmlElement(ElementName = "CODNILSEN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codnilsen
        {
            get { return  codnilsen; }
            set {  codnilsen = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAIS
        /// Comentário: Código Pais
        /// </summary>
        private decimal codpais;
        [XmlElement(ElementName = "CODPAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpais
        {
            get { return  codpais; }
            set {  codpais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGAGRUPAUTOMATIC
        /// Comentário: Código Plano Pagamento Padrão para Agrupamento Agendado
        /// </summary>
        private decimal codplpagagrupautomatic;
        [XmlElement(ElementName = "CODPLPAGAGRUPAUTOMATIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpagagrupautomatic
        {
            get { return  codplpagagrupautomatic; }
            set {  codplpagagrupautomatic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGETICO
        /// Comentário: Este campo determina o plano de pagamento a ser utilizado para itens tipo medicamentos eticos do pedido
        /// </summary>
        private decimal codplpagetico;
        [XmlElement(ElementName = "CODPLPAGETICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpagetico
        {
            get { return  codplpagetico; }
            set {  codplpagetico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGGENERICO
        /// Comentário: Este campo determina o plano de pagamento a ser utilizado para itens tipo medicamentos genericos do pedido
        /// </summary>
        private decimal codplpaggenerico;
        [XmlElement(ElementName = "CODPLPAGGENERICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpaggenerico
        {
            get { return  codplpaggenerico; }
            set {  codplpaggenerico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGPADRAO
        /// Comentário: 
        /// </summary>
        private decimal codplpagpadrao;
        [XmlElement(ElementName = "CODPLPAGPADRAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpagpadrao
        {
            get { return  codplpagpadrao; }
            set {  codplpagpadrao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG2
        /// Comentário: 
        /// </summary>
        private decimal codplpag2;
        [XmlElement(ElementName = "CODPLPAG2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpag2
        {
            get { return  codplpag2; }
            set {  codplpag2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACACOB
        /// Comentário: Código da praça de cobrança.
        /// </summary>
        private decimal codpracacob;
        [XmlElement(ElementName = "CODPRACACOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpracacob
        {
            get { return  codpracacob; }
            set {  codpracacob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROFISSIONAL
        /// Comentário: Indica o código do profissional.
        /// </summary>
        private decimal codprofissional;
        [XmlElement(ElementName = "CODPROFISSIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprofissional
        {
            get { return  codprofissional; }
            set {  codprofissional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROMOCAOMED
        /// Comentário: Cód. Promoção Med. Padrão
        /// </summary>
        private decimal codpromocaomed;
        [XmlElement(ElementName = "CODPROMOCAOMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Codpromocaomed
        {
            get { return  codpromocaomed; }
            set {  codpromocaomed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDE
        /// Comentário: Indica o código da rede do cliente.
        /// </summary>
        private decimal codrede;
        [XmlElement(ElementName = "CODREDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrede
        {
            get { return  codrede; }
            set {  codrede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSTATUSCOB
        /// Comentário: 
        /// </summary>
        private decimal codstatuscob;
        [XmlElement(ElementName = "CODSTATUSCOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codstatuscob
        {
            get { return  codstatuscob; }
            set {  codstatuscob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUFRAMA
        /// Comentário: 
        /// </summary>
        private string codsuframa;
        [XmlElement(ElementName = "CODSUFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Codsuframa
        {
            get { return  codsuframa; }
            set {  codsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR1
        /// Comentário: 
        /// </summary>
        private decimal codusur1;
        [XmlElement(ElementName = "CODUSUR1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur1
        {
            get { return  codusur1; }
            set {  codusur1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR2
        /// Comentário: 
        /// </summary>
        private decimal codusur2;
        [XmlElement(ElementName = "CODUSUR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur2
        {
            get { return  codusur2; }
            set {  codusur2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR3
        /// Comentário: 
        /// </summary>
        private decimal codusur3;
        [XmlElement(ElementName = "CODUSUR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur3
        {
            get { return  codusur3; }
            set {  codusur3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTOCOB
        /// Comentário: Indica o complemento da cobrança.
        /// </summary>
        private string complementocob;
        [XmlElement(ElementName = "COMPLEMENTOCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Complementocob
        {
            get { return  complementocob; }
            set {  complementocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTOCOM
        /// Comentário: Indica o complemento comercial.
        /// </summary>
        private string complementocom;
        [XmlElement(ElementName = "COMPLEMENTOCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Complementocom
        {
            get { return  complementocom; }
            set {  complementocom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTOENT
        /// Comentário: 
        /// </summary>
        private string complementoent;
        [XmlElement(ElementName = "COMPLEMENTOENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Complementoent
        {
            get { return  complementoent; }
            set {  complementoent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA1
        /// Comentário: 
        /// </summary>
        private string condvenda1;
        [XmlElement(ElementName = "CONDVENDA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda1
        {
            get { return  condvenda1; }
            set {  condvenda1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA10
        /// Comentário: 
        /// </summary>
        private string condvenda10;
        [XmlElement(ElementName = "CONDVENDA10", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda10
        {
            get { return  condvenda10; }
            set {  condvenda10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA11
        /// Comentário: 
        /// </summary>
        private string condvenda11;
        [XmlElement(ElementName = "CONDVENDA11", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda11
        {
            get { return  condvenda11; }
            set {  condvenda11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA12
        /// Comentário: 
        /// </summary>
        private string condvenda12;
        [XmlElement(ElementName = "CONDVENDA12", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda12
        {
            get { return  condvenda12; }
            set {  condvenda12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA13
        /// Comentário: 
        /// </summary>
        private string condvenda13;
        [XmlElement(ElementName = "CONDVENDA13", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda13
        {
            get { return  condvenda13; }
            set {  condvenda13 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA14
        /// Comentário: 
        /// </summary>
        private string condvenda14;
        [XmlElement(ElementName = "CONDVENDA14", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda14
        {
            get { return  condvenda14; }
            set {  condvenda14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA2
        /// Comentário: 
        /// </summary>
        private string condvenda2;
        [XmlElement(ElementName = "CONDVENDA2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda2
        {
            get { return  condvenda2; }
            set {  condvenda2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA20
        /// Comentário: 
        /// </summary>
        private string condvenda20;
        [XmlElement(ElementName = "CONDVENDA20", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda20
        {
            get { return  condvenda20; }
            set {  condvenda20 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA3
        /// Comentário: 
        /// </summary>
        private string condvenda3;
        [XmlElement(ElementName = "CONDVENDA3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda3
        {
            get { return  condvenda3; }
            set {  condvenda3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA4
        /// Comentário: 
        /// </summary>
        private string condvenda4;
        [XmlElement(ElementName = "CONDVENDA4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda4
        {
            get { return  condvenda4; }
            set {  condvenda4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA5
        /// Comentário: 
        /// </summary>
        private string condvenda5;
        [XmlElement(ElementName = "CONDVENDA5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda5
        {
            get { return  condvenda5; }
            set {  condvenda5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA6
        /// Comentário: 
        /// </summary>
        private string condvenda6;
        [XmlElement(ElementName = "CONDVENDA6", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda6
        {
            get { return  condvenda6; }
            set {  condvenda6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA7
        /// Comentário: 
        /// </summary>
        private string condvenda7;
        [XmlElement(ElementName = "CONDVENDA7", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda7
        {
            get { return  condvenda7; }
            set {  condvenda7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA8
        /// Comentário: 
        /// </summary>
        private string condvenda8;
        [XmlElement(ElementName = "CONDVENDA8", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda8
        {
            get { return  condvenda8; }
            set {  condvenda8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA9
        /// Comentário: 
        /// </summary>
        private string condvenda9;
        [XmlElement(ElementName = "CONDVENDA9", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda9
        {
            get { return  condvenda9; }
            set {  condvenda9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA98
        /// Comentário: 
        /// </summary>
        private string condvenda98;
        [XmlElement(ElementName = "CONDVENDA98", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda98
        {
            get { return  condvenda98; }
            set {  condvenda98 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA99
        /// Comentário: 
        /// </summary>
        private string condvenda99;
        [XmlElement(ElementName = "CONDVENDA99", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda99
        {
            get { return  condvenda99; }
            set {  condvenda99 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSUMIDORFINAL
        /// Comentário: 
        /// </summary>
        private string consumidorfinal;
        [XmlElement(ElementName = "CONSUMIDORFINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consumidorfinal
        {
            get { return  consumidorfinal; }
            set {  consumidorfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAGEMESTOQUE
        /// Comentário: Indica se cliente deve ter estoque contado.
        /// </summary>
        private string contagemestoque;
        [XmlElement(ElementName = "CONTAGEMESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Contagemestoque
        {
            get { return  contagemestoque; }
            set {  contagemestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTRIBUINTE
        /// Comentário: 
        /// </summary>
        private string contribuinte;
        [XmlElement(ElementName = "CONTRIBUINTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Contribuinte
        {
            get { return  contribuinte; }
            set {  contribuinte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CPFCONJUGE
        /// Comentário: 
        /// </summary>
        private string cpfconjuge;
        [XmlElement(ElementName = "CPFCONJUGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Cpfconjuge
        {
            get { return  cpfconjuge; }
            set {  cpfconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRF
        /// Comentário: Controle regional de farmacia.
        /// </summary>
        private string crf;
        [XmlElement(ElementName = "CRF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Crf
        {
            get { return  crf; }
            set {  crf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACOLETA
        /// Comentário: Data da última coleta de dados GPS realizada.
        /// </summary>
        private DateTime? datacoleta;
        [XmlElement(ElementName = "DATACOLETA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacoleta
        {
            get { return  datacoleta; }
            set {  datacoleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACONSULTASINTEGRA
        /// Comentário: Indica a data da consulta sintegra.
        /// </summary>
        private DateTime? dataconsultasintegra;
        [XmlElement(ElementName = "DATACONSULTASINTEGRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataconsultasintegra
        {
            get { return  dataconsultasintegra; }
            set {  dataconsultasintegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DDDINTERNACIONAL
        /// Comentário: 
        /// </summary>
        private decimal dddinternacional;
        [XmlElement(ElementName = "DDDINTERNACIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Dddinternacional
        {
            get { return  dddinternacional; }
            set {  dddinternacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCONSVALIDASEFAZ
        /// Comentário: Desconsiderar Validações do cliente junto a sefaz.
        /// </summary>
        private string desconsvalidasefaz;
        [XmlElement(ElementName = "DESCONSVALIDASEFAZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Desconsvalidasefaz
        {
            get { return  desconsvalidasefaz; }
            set {  desconsvalidasefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCPRODUTO
        /// Comentário: 
        /// </summary>
        private string descproduto;
        [XmlElement(ElementName = "DESCPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Descproduto
        {
            get { return  descproduto; }
            set {  descproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTACAFRETE
        /// Comentário: 
        /// </summary>
        private string destacafrete;
        [XmlElement(ElementName = "DESTACAFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Destacafrete
        {
            get { return  destacafrete; }
            set {  destacafrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAFATURAR
        /// Comentário: Dia do mês para iniciar faturamento.
        /// </summary>
        private decimal diafaturar;
        [XmlElement(ElementName = "DIAFATURAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diafaturar
        {
            get { return  diafaturar; }
            set {  diafaturar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAFECHACONVENIO
        /// Comentário: Dia de fechamento do convênio.
        /// </summary>
        private decimal diafechaconvenio;
        [XmlElement(ElementName = "DIAFECHACONVENIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diafechaconvenio
        {
            get { return  diafechaconvenio; }
            set {  diafechaconvenio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEMANA
        /// Comentário: 
        /// </summary>
        private string diasemana;
        [XmlElement(ElementName = "DIASEMANA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Diasemana
        {
            get { return  diasemana; }
            set {  diasemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIGAGENCIA1
        /// Comentário: 
        /// </summary>
        private string digagencia1;
        [XmlElement(ElementName = "DIGAGENCIA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Digagencia1
        {
            get { return  digagencia1; }
            set {  digagencia1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIGAGENCIA2
        /// Comentário: 
        /// </summary>
        private string digagencia2;
        [XmlElement(ElementName = "DIGAGENCIA2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Digagencia2
        {
            get { return  digagencia2; }
            set {  digagencia2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRETORIOCLIENTE
        /// Comentário: 
        /// </summary>
        private string diretoriocliente;
        [XmlElement(ElementName = "DIRETORIOCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Diretoriocliente
        {
            get { return  diretoriocliente; }
            set {  diretoriocliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRETORIOCONTRATO
        /// Comentário: Caminho do diretório do contrato
        /// </summary>
        private string diretoriocontrato;
        [XmlElement(ElementName = "DIRETORIOCONTRATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Diretoriocontrato
        {
            get { return  diretoriocontrato; }
            set {  diretoriocontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTCC1
        /// Comentário: 
        /// </summary>
        private DateTime? dtabertcc1;
        [XmlElement(ElementName = "DTABERTCC1", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtabertcc1
        {
            get { return  dtabertcc1; }
            set {  dtabertcc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTCC2
        /// Comentário: 
        /// </summary>
        private DateTime? dtabertcc2;
        [XmlElement(ElementName = "DTABERTCC2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtabertcc2
        {
            get { return  dtabertcc2; }
            set {  dtabertcc2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTADMISSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtadmissao;
        [XmlElement(ElementName = "DTADMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtadmissao
        {
            get { return  dtadmissao; }
            set {  dtadmissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTADMISSAOCONJUGE
        /// Comentário: 
        /// </summary>
        private DateTime? dtadmissaoconjuge;
        [XmlElement(ElementName = "DTADMISSAOCONJUGE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtadmissaoconjuge
        {
            get { return  dtadmissaoconjuge; }
            set {  dtadmissaoconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBLOQ
        /// Comentário: 
        /// </summary>
        private DateTime? dtbloq;
        [XmlElement(ElementName = "DTBLOQ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbloq
        {
            get { return  dtbloq; }
            set {  dtbloq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCAPITALSOCIAL
        /// Comentário: 
        /// </summary>
        private DateTime? dtcapitalsocial;
        [XmlElement(ElementName = "DTCAPITALSOCIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcapitalsocial
        {
            get { return  dtcapitalsocial; }
            set {  dtcapitalsocial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCLASSIFICAESTRELA
        /// Comentário: 
        /// </summary>
        private DateTime? dtclassificaestrela;
        [XmlElement(ElementName = "DTCLASSIFICAESTRELA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtclassificaestrela
        {
            get { return  dtclassificaestrela; }
            set {  dtclassificaestrela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCLASSIFICAGRUPO
        /// Comentário: 
        /// </summary>
        private DateTime? dtclassificagrupo;
        [XmlElement(ElementName = "DTCLASSIFICAGRUPO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtclassificagrupo
        {
            get { return  dtclassificagrupo; }
            set {  dtclassificagrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDESBLOQUEIO
        /// Comentário: Indica a data em que o cliente foi desbloqueado manualmente, através da rotina 1203 - Extrato do Cliente. 
        /// </summary>
        private DateTime? dtdesbloqueio;
        [XmlElement(ElementName = "DTDESBLOQUEIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdesbloqueio
        {
            get { return  dtdesbloqueio; }
            set {  dtdesbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENQUADRAMENTOMICROEMPRESA
        /// Comentário: 
        /// </summary>
        private DateTime? dtenquadramentomicroempresa;
        [XmlElement(ElementName = "DTENQUADRAMENTOMICROEMPRESA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtenquadramentomicroempresa
        {
            get { return  dtenquadramentomicroempresa; }
            set {  dtenquadramentomicroempresa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTINTEGRACAO
        /// Comentário: Data da última importação do registro na filial de destino da informação.
        /// </summary>
        private DateTime? dtimportintegracao;
        [XmlElement(ElementName = "DTIMPORTINTEGRACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportintegracao
        {
            get { return  dtimportintegracao; }
            set {  dtimportintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINIVISTORIA
        /// Comentário: Data de inicio das vistorias de comodato
        /// </summary>
        private DateTime? dtinivistoria;
        [XmlElement(ElementName = "DTINIVISTORIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinivistoria
        {
            get { return  dtinivistoria; }
            set {  dtinivistoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANCPOTENCIALLIMCRED
        /// Comentário: 
        /// </summary>
        private DateTime? dtlancpotenciallimcred;
        [XmlElement(ElementName = "DTLANCPOTENCIALLIMCRED", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlancpotenciallimcred
        {
            get { return  dtlancpotenciallimcred; }
            set {  dtlancpotenciallimcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNASC
        /// Comentário: 
        /// </summary>
        private DateTime? dtnasc;
        [XmlElement(ElementName = "DTNASC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnasc
        {
            get { return  dtnasc; }
            set {  dtnasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNASCCONJ
        /// Comentário: 
        /// </summary>
        private DateTime? dtnascconj;
        [XmlElement(ElementName = "DTNASCCONJ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnascconj
        {
            get { return  dtnascconj; }
            set {  dtnascconj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPRIMCOMPRA
        /// Comentário: 
        /// </summary>
        private DateTime? dtprimcompra;
        [XmlElement(ElementName = "DTPRIMCOMPRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprimcompra
        {
            get { return  dtprimcompra; }
            set {  dtprimcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXCONTATOCOB
        /// Comentário: 
        /// </summary>
        private DateTime? dtproxcontatocob;
        [XmlElement(ElementName = "DTPROXCONTATOCOB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxcontatocob
        {
            get { return  dtproxcontatocob; }
            set {  dtproxcontatocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXDESDAGENDADO
        /// Comentário: Data do Proximo Desdobramento Agendado.
        /// </summary>
        private DateTime? dtproxdesdagendado;
        [XmlElement(ElementName = "DTPROXDESDAGENDADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxdesdagendado
        {
            get { return  dtproxdesdagendado; }
            set {  dtproxdesdagendado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXVISTORIA
        /// Comentário: Data da próxima vistoria de comodato
        /// </summary>
        private DateTime? dtproxvistoria;
        [XmlElement(ElementName = "DTPROXVISTORIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxvistoria
        {
            get { return  dtproxvistoria; }
            set {  dtproxvistoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREGLIM
        /// Comentário: 
        /// </summary>
        private DateTime? dtreglim;
        [XmlElement(ElementName = "DTREGLIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtreglim
        {
            get { return  dtreglim; }
            set {  dtreglim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSERASAGERENCIE
        /// Comentário: Definir a data de inclusão do cliente no sistema gerencie Serasa.
        /// </summary>
        private DateTime? dtserasagerencie;
        [XmlElement(ElementName = "DTSERASAGERENCIE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtserasagerencie
        {
            get { return  dtserasagerencie; }
            set {  dtserasagerencie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTAGRUPAMENTO
        /// Comentário: Data do Último Agrupamento Agendado
        /// </summary>
        private DateTime? dtultagrupamento;
        [XmlElement(ElementName = "DTULTAGRUPAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultagrupamento
        {
            get { return  dtultagrupamento; }
            set {  dtultagrupamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTER
        /// Comentário: 
        /// </summary>
        private DateTime? dtultalter;
        [XmlElement(ElementName = "DTULTALTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalter
        {
            get { return  dtultalter; }
            set {  dtultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTERCLIESP
        /// Comentário: 
        /// </summary>
        private DateTime? dtultaltercliesp;
        [XmlElement(ElementName = "DTULTALTERCLIESP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltercliesp
        {
            get { return  dtultaltercliesp; }
            set {  dtultaltercliesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTERSRVPRC
        /// Comentário: Indica a data da ultima alteração.
        /// </summary>
        private DateTime? dtultaltersrvprc;
        [XmlElement(ElementName = "DTULTALTERSRVPRC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltersrvprc
        {
            get { return  dtultaltersrvprc; }
            set {  dtultaltersrvprc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTER1203
        /// Comentário: Data da ultima alteração da 1203
        /// </summary>
        private DateTime? dtultalter1203;
        [XmlElement(ElementName = "DTULTALTER1203", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalter1203
        {
            get { return  dtultalter1203; }
            set {  dtultalter1203 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCOMP
        /// Comentário: 
        /// </summary>
        private DateTime? dtultcomp;
        [XmlElement(ElementName = "DTULTCOMP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultcomp
        {
            get { return  dtultcomp; }
            set {  dtultcomp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCOMPNESTLE
        /// Comentário: 
        /// </summary>
        private DateTime? dtultcompnestle;
        [XmlElement(ElementName = "DTULTCOMPNESTLE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultcompnestle
        {
            get { return  dtultcompnestle; }
            set {  dtultcompnestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCONSULTASCI
        /// Comentário: 
        /// </summary>
        private DateTime? dtultconsultasci;
        [XmlElement(ElementName = "DTULTCONSULTASCI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultconsultasci
        {
            get { return  dtultconsultasci; }
            set {  dtultconsultasci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCONSULTASERASA
        /// Comentário: 
        /// </summary>
        private DateTime? dtultconsultaserasa;
        [XmlElement(ElementName = "DTULTCONSULTASERASA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultconsultaserasa
        {
            get { return  dtultconsultaserasa; }
            set {  dtultconsultaserasa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCONSULTASINTEGRA
        /// Comentário: 
        /// </summary>
        private DateTime? dtultconsultasintegra;
        [XmlElement(ElementName = "DTULTCONSULTASINTEGRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultconsultasintegra
        {
            get { return  dtultconsultasintegra; }
            set {  dtultconsultasintegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCONTATOCOB
        /// Comentário: 
        /// </summary>
        private DateTime? dtultcontatocob;
        [XmlElement(ElementName = "DTULTCONTATOCOB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultcontatocob
        {
            get { return  dtultcontatocob; }
            set {  dtultcontatocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTVISITA
        /// Comentário: 
        /// </summary>
        private DateTime? dtultvisita;
        [XmlElement(ElementName = "DTULTVISITA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultvisita
        {
            get { return  dtultvisita; }
            set {  dtultvisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADECONV
        /// Comentário: Indica a data de validade para uso da cobrança CONV nas vendas.
        /// </summary>
        private DateTime? dtvalidadeconv;
        [XmlElement(ElementName = "DTVALIDADECONV", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidadeconv
        {
            get { return  dtvalidadeconv; }
            set {  dtvalidadeconv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADEIBAMA
        /// Comentário: Data validade IBAMA
        /// </summary>
        private DateTime? dtvalidadeibama;
        [XmlElement(ElementName = "DTVALIDADEIBAMA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidadeibama
        {
            get { return  dtvalidadeibama; }
            set {  dtvalidadeibama = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDASEFAZ
        /// Comentário: Campo de informação da data e hora de bloqueio ou desbloqueio na SEFAZ.
        /// </summary>
        private DateTime? dtvalidasefaz;
        [XmlElement(ElementName = "DTVALIDASEFAZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidasefaz
        {
            get { return  dtvalidasefaz; }
            set {  dtvalidasefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCALVARA
        /// Comentário: 
        /// </summary>
        private DateTime? dtvencalvara;
        [XmlElement(ElementName = "DTVENCALVARA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencalvara
        {
            get { return  dtvencalvara; }
            set {  dtvencalvara = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCALVARAANVISA
        /// Comentário: Dt. venc. Alvará anvisa
        /// </summary>
        private DateTime? dtvencalvaraanvisa;
        [XmlElement(ElementName = "DTVENCALVARAANVISA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencalvaraanvisa
        {
            get { return  dtvencalvaraanvisa; }
            set {  dtvencalvaraanvisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCALVARAFUNC
        /// Comentário: 
        /// </summary>
        private DateTime? dtvencalvarafunc;
        [XmlElement(ElementName = "DTVENCALVARAFUNC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencalvarafunc
        {
            get { return  dtvencalvarafunc; }
            set {  dtvencalvarafunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCALVARARETINOICO
        /// Comentário: Alvará Retinóico / Data de Vencimento
        /// </summary>
        private DateTime? dtvencalvararetinoico;
        [XmlElement(ElementName = "DTVENCALVARARETINOICO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencalvararetinoico
        {
            get { return  dtvencalvararetinoico; }
            set {  dtvencalvararetinoico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCALVARASUS
        /// Comentário: Data vencimento alvará sus.
        /// </summary>
        private DateTime? dtvencalvarasus;
        [XmlElement(ElementName = "DTVENCALVARASUS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencalvarasus
        {
            get { return  dtvencalvarasus; }
            set {  dtvencalvarasus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCCRF
        /// Comentário: Dt. Venc CRF
        /// </summary>
        private DateTime? dtvenccrf;
        [XmlElement(ElementName = "DTVENCCRF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenccrf
        {
            get { return  dtvenccrf; }
            set {  dtvenccrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCLIMCRED
        /// Comentário: 
        /// </summary>
        private DateTime? dtvenclimcred;
        [XmlElement(ElementName = "DTVENCLIMCRED", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenclimcred
        {
            get { return  dtvenclimcred; }
            set {  dtvenclimcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCPRAZOADICIONAL
        /// Comentário: 
        /// </summary>
        private DateTime? dtvencprazoadicional;
        [XmlElement(ElementName = "DTVENCPRAZOADICIONAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencprazoadicional
        {
            get { return  dtvencprazoadicional; }
            set {  dtvencprazoadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCSUFRAMA
        /// Comentário: 
        /// </summary>
        private DateTime? dtvencsuframa;
        [XmlElement(ElementName = "DTVENCSUFRAMA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencsuframa
        {
            get { return  dtvencsuframa; }
            set {  dtvencsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANCOBRANCA
        /// Comentário: 
        /// </summary>
        private decimal eancobranca;
        [XmlElement(ElementName = "EANCOBRANCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Eancobranca
        {
            get { return  eancobranca; }
            set {  eancobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANENTREGA
        /// Comentário: 
        /// </summary>
        private decimal eanentrega;
        [XmlElement(ElementName = "EANENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Eanentrega
        {
            get { return  eanentrega; }
            set {  eanentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EDOCOB
        /// Comentário: 
        /// </summary>
        private string edocob;
        [XmlElement(ElementName = "EDOCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Edocob
        {
            get { return  edocob; }
            set {  edocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EDOCOM
        /// Comentário: 
        /// </summary>
        private string edocom;
        [XmlElement(ElementName = "EDOCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Edocom
        {
            get { return  edocom; }
            set {  edocom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EDOENT
        /// Comentário: 
        /// </summary>
        private string edoent;
        [XmlElement(ElementName = "EDOENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Edoent
        {
            get { return  edoent; }
            set {  edoent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Comentário: 
        /// </summary>
        private string email;
        [XmlElement(ElementName = "EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Email
        {
            get { return  email; }
            set {  email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAILNFE
        /// Comentário: E-mail para nota fiscal eletronica.
        /// </summary>
        private string emailnfe;
        [XmlElement(ElementName = "EMAILNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Emailnfe
        {
            get { return  emailnfe; }
            set {  emailnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMITEDAE
        /// Comentário: 
        /// </summary>
        private string emitedae;
        [XmlElement(ElementName = "EMITEDAE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emitedae
        {
            get { return  emitedae; }
            set {  emitedae = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMITEDUP
        /// Comentário: 
        /// </summary>
        private string emitedup;
        [XmlElement(ElementName = "EMITEDUP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emitedup
        {
            get { return  emitedup; }
            set {  emitedup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMITENTECH
        /// Comentário: 
        /// </summary>
        private string emitentech;
        [XmlElement(ElementName = "EMITENTECH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Emitentech
        {
            get { return  emitentech; }
            set {  emitentech = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMITENTECH2
        /// Comentário: 
        /// </summary>
        private string emitentech2;
        [XmlElement(ElementName = "EMITENTECH2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Emitentech2
        {
            get { return  emitentech2; }
            set {  emitentech2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMITEPVENDANFSEMDESC
        /// Comentário: Indica se preço na nota fiscal sem desconto.
        /// </summary>
        private string emitepvendanfsemdesc;
        [XmlElement(ElementName = "EMITEPVENDANFSEMDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emitepvendanfsemdesc
        {
            get { return  emitepvendanfsemdesc; }
            set {  emitepvendanfsemdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMPFIXA
        /// Comentário: 
        /// </summary>
        private string empfixa;
        [XmlElement(ElementName = "EMPFIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Empfixa
        {
            get { return  empfixa; }
            set {  empfixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMPRESA
        /// Comentário: 
        /// </summary>
        private string empresa;
        [XmlElement(ElementName = "EMPRESA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Empresa
        {
            get { return  empresa; }
            set {  empresa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMPRESACONJUGE
        /// Comentário: 
        /// </summary>
        private string empresaconjuge;
        [XmlElement(ElementName = "EMPRESACONJUGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Empresaconjuge
        {
            get { return  empresaconjuge; }
            set {  empresaconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMPRESACONVENIADA
        /// Comentário: Empresa Conveniada.
        /// </summary>
        private string empresaconveniada;
        [XmlElement(ElementName = "EMPRESACONVENIADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Empresaconveniada
        {
            get { return  empresaconveniada; }
            set {  empresaconveniada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERCOB
        /// Comentário: 
        /// </summary>
        private string endercob;
        [XmlElement(ElementName = "ENDERCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Endercob
        {
            get { return  endercob; }
            set {  endercob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERCOM
        /// Comentário: 
        /// </summary>
        private string endercom;
        [XmlElement(ElementName = "ENDERCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Endercom
        {
            get { return  endercom; }
            set {  endercom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERCONJUGE
        /// Comentário: 
        /// </summary>
        private string enderconjuge;
        [XmlElement(ElementName = "ENDERCONJUGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Enderconjuge
        {
            get { return  enderconjuge; }
            set {  enderconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDEREMPR
        /// Comentário: 
        /// </summary>
        private string enderempr;
        [XmlElement(ElementName = "ENDEREMPR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Enderempr
        {
            get { return  enderempr; }
            set {  enderempr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERENT
        /// Comentário: 
        /// </summary>
        private string enderent;
        [XmlElement(ElementName = "ENDERENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Enderent
        {
            get { return  enderent; }
            set {  enderent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIADADOSSERASA
        /// Comentário: Indica se são enviados os dados do cliente para o Serasa, através da rotina 1279 - Geração de Arquivo SERASA.
        /// </summary>
        private string enviadadosserasa;
        [XmlElement(ElementName = "ENVIADADOSSERASA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviadadosserasa
        {
            get { return  enviadadosserasa; }
            set {  enviadadosserasa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIONFEEMAILCOM
        /// Comentário: Envio e-mail comercial
        /// </summary>
        private string envionfeemailcom;
        [XmlElement(ElementName = "ENVIONFEEMAILCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Envionfeemailcom
        {
            get { return  envionfeemailcom; }
            set {  envionfeemailcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIOPDFNFE
        /// Comentário: Não enviar DANFE em PDF .
        /// </summary>
        private string enviopdfnfe;
        [XmlElement(ElementName = "ENVIOPDFNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviopdfnfe
        {
            get { return  enviopdfnfe; }
            set {  enviopdfnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTCOB
        /// Comentário: 
        /// </summary>
        private string estcob;
        [XmlElement(ElementName = "ESTCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estcob
        {
            get { return  estcob; }
            set {  estcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTCOM
        /// Comentário: 
        /// </summary>
        private string estcom;
        [XmlElement(ElementName = "ESTCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estcom
        {
            get { return  estcom; }
            set {  estcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTCONJUGE
        /// Comentário: 
        /// </summary>
        private string estconjuge;
        [XmlElement(ElementName = "ESTCONJUGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estconjuge
        {
            get { return  estconjuge; }
            set {  estconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTEMPR
        /// Comentário: 
        /// </summary>
        private string estempr;
        [XmlElement(ElementName = "ESTEMPR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estempr
        {
            get { return  estempr; }
            set {  estempr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTENT
        /// Comentário: 
        /// </summary>
        private string estent;
        [XmlElement(ElementName = "ESTENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estent
        {
            get { return  estent; }
            set {  estent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTARDADOSIMS
        /// Comentário: 
        /// </summary>
        private string exportardadosims;
        [XmlElement(ElementName = "EXPORTARDADOSIMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportardadosims
        {
            get { return  exportardadosims; }
            set {  exportardadosims = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FANTASIA
        /// Comentário: 
        /// </summary>
        private string fantasia;
        [XmlElement(ElementName = "FANTASIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Fantasia
        {
            get { return  fantasia; }
            set {  fantasia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAXCLI
        /// Comentário: 
        /// </summary>
        private string faxcli;
        [XmlElement(ElementName = "FAXCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Faxcli
        {
            get { return  faxcli; }
            set {  faxcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAXCOM
        /// Comentário: 
        /// </summary>
        private string faxcom;
        [XmlElement(ElementName = "FAXCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Faxcom
        {
            get { return  faxcom; }
            set {  faxcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FILIACAOMAE
        /// Comentário: 
        /// </summary>
        private string filiacaomae;
        [XmlElement(ElementName = "FILIACAOMAE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Filiacaomae
        {
            get { return  filiacaomae; }
            set {  filiacaomae = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FILIACAOMAECONJ
        /// Comentário: 
        /// </summary>
        private string filiacaomaeconj;
        [XmlElement(ElementName = "FILIACAOMAECONJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Filiacaomaeconj
        {
            get { return  filiacaomaeconj; }
            set {  filiacaomaeconj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FILIACAOPAI
        /// Comentário: 
        /// </summary>
        private string filiacaopai;
        [XmlElement(ElementName = "FILIACAOPAI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Filiacaopai
        {
            get { return  filiacaopai; }
            set {  filiacaopai = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FILIACAOPAICONJ
        /// Comentário: 
        /// </summary>
        private string filiacaopaiconj;
        [XmlElement(ElementName = "FILIACAOPAICONJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Filiacaopaiconj
        {
            get { return  filiacaopaiconj; }
            set {  filiacaopaiconj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FOCO
        /// Comentário: Indica se cliente é foco.
        /// </summary>
        private string foco;
        [XmlElement(ElementName = "FOCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Foco
        {
            get { return  foco; }
            set {  foco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FOTOGRAFIASUCESSO
        /// Comentário: Indica se cliente é fotografia de sucesso.
        /// </summary>
        private string fotografiasucesso;
        [XmlElement(ElementName = "FOTOGRAFIASUCESSO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fotografiasucesso
        {
            get { return  fotografiasucesso; }
            set {  fotografiasucesso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FREQDIAVISITA
        /// Comentário: 
        /// </summary>
        private decimal freqdiavisita;
        [XmlElement(ElementName = "FREQDIAVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Freqdiavisita
        {
            get { return  freqdiavisita; }
            set {  freqdiavisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FREQVISITA
        /// Comentário: 
        /// </summary>
        private decimal freqvisita;
        [XmlElement(ElementName = "FREQVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Freqvisita
        {
            get { return  freqvisita; }
            set {  freqvisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRETEDESPACHO
        /// Comentário: Frete do cliente CIF ou FOB.
        /// </summary>
        private string fretedespacho;
        [XmlElement(ElementName = "FRETEDESPACHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fretedespacho
        {
            get { return  fretedespacho; }
            set {  fretedespacho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARCREDITODEVCLI
        /// Comentário: Gerar Credito de Devolução.
        /// </summary>
        private string gerarcreditodevcli;
        [XmlElement(ElementName = "GERARCREDITODEVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarcreditodevcli
        {
            get { return  gerarcreditodevcli; }
            set {  gerarcreditodevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERATITULOST
        /// Comentário: Gerar contas à receber sep. para ST
        /// </summary>
        private string geratitulost;
        [XmlElement(ElementName = "GERATITULOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geratitulost
        {
            get { return  geratitulost; }
            set {  geratitulost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERENCIAMENTO
        /// Comentário: 
        /// </summary>
        private string gerenciamento;
        [XmlElement(ElementName = "GERENCIAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerenciamento
        {
            get { return  gerenciamento; }
            set {  gerenciamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPORAMOATIVI
        /// Comentário: 
        /// </summary>
        private string gruporamoativi;
        [XmlElement(ElementName = "GRUPORAMOATIVI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Gruporamoativi
        {
            get { return  gruporamoativi; }
            set {  gruporamoativi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORACADASTRO
        /// Comentário: Hora do Cadastro.
        /// </summary>
        private DateTime? horacadastro;
        [XmlElement(ElementName = "HORACADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Horacadastro
        {
            get { return  horacadastro; }
            set {  horacadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAPROXCONTATO
        /// Comentário: 
        /// </summary>
        private decimal horaproxcontato;
        [XmlElement(ElementName = "HORAPROXCONTATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horaproxcontato
        {
            get { return  horaproxcontato; }
            set {  horaproxcontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORARIORECEB
        /// Comentário: 
        /// </summary>
        private string horarioreceb;
        [XmlElement(ElementName = "HORARIORECEB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Horarioreceb
        {
            get { return  horarioreceb; }
            set {  horarioreceb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ICMSANTECIP
        /// Comentário: 
        /// </summary>
        private string icmsantecip;
        [XmlElement(ElementName = "ICMSANTECIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Icmsantecip
        {
            get { return  icmsantecip; }
            set {  icmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IEENT
        /// Comentário: 
        /// </summary>
        private string ieent;
        [XmlElement(ElementName = "IEENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ieent
        {
            get { return  ieent; }
            set {  ieent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IEPS
        /// Comentário: 
        /// </summary>
        private decimal ieps;
        [XmlElement(ElementName = "IEPS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Ieps
        {
            get { return  ieps; }
            set {  ieps = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IEST
        /// Comentário: 
        /// </summary>
        private string iest;
        [XmlElement(ElementName = "IEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Iest
        {
            get { return  iest; }
            set {  iest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMENT
        /// Comentário: 
        /// </summary>
        private string iment;
        [XmlElement(ElementName = "IMENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Iment
        {
            get { return  iment; }
            set {  iment = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADOCRM
        /// Comentário: Cliente que foi importado do CRM..
        /// </summary>
        private string importadocrm;
        [XmlElement(ElementName = "IMPORTADOCRM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importadocrm
        {
            get { return  importadocrm; }
            set {  importadocrm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INCLUINOARQSCI
        /// Comentário: 
        /// </summary>
        private string incluinoarqsci;
        [XmlElement(ElementName = "INCLUINOARQSCI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Incluinoarqsci
        {
            get { return  incluinoarqsci; }
            set {  incluinoarqsci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INICIOATIV
        /// Comentário: 
        /// </summary>
        private DateTime? inicioativ;
        [XmlElement(ElementName = "INICIOATIV", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Inicioativ
        {
            get { return  inicioativ; }
            set {  inicioativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INSCESTADUAL
        /// Comentário: Código da Inscrição Estadual. 
        /// </summary>
        private string inscestadual;
        [XmlElement(ElementName = "INSCESTADUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Inscestadual
        {
            get { return  inscestadual; }
            set {  inscestadual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INVESTIMENTO
        /// Comentário: Indica se cliente é de investimento.
        /// </summary>
        private string investimento;
        [XmlElement(ElementName = "INVESTIMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Investimento
        {
            get { return  investimento; }
            set {  investimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENCAOSUFRAMA
        /// Comentário: Isenção Suframa
        /// </summary>
        private string isencaosuframa;
        [XmlElement(ElementName = "ISENCAOSUFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isencaosuframa
        {
            get { return  isencaosuframa; }
            set {  isencaosuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENTAJUROS
        /// Comentário: 
        /// </summary>
        private string isentajuros;
        [XmlElement(ElementName = "ISENTAJUROS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isentajuros
        {
            get { return  isentajuros; }
            set {  isentajuros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENTODIFALIQUOTAS
        /// Comentário: Isento de difereça de alíquotas.
        /// </summary>
        private string isentodifaliquotas;
        [XmlElement(ElementName = "ISENTODIFALIQUOTAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isentodifaliquotas
        {
            get { return  isentodifaliquotas; }
            set {  isentodifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENTOICMS
        /// Comentário: 
        /// </summary>
        private string isentoicms;
        [XmlElement(ElementName = "ISENTOICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isentoicms
        {
            get { return  isentoicms; }
            set {  isentoicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENTOIPI
        /// Comentário: 
        /// </summary>
        private string isentoipi;
        [XmlElement(ElementName = "ISENTOIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isentoipi
        {
            get { return  isentoipi; }
            set {  isentoipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENTOTXBOLETO
        /// Comentário: 
        /// </summary>
        private string isentotxboleto;
        [XmlElement(ElementName = "ISENTOTXBOLETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isentotxboleto
        {
            get { return  isentotxboleto; }
            set {  isentotxboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVA
        /// Comentário: 
        /// </summary>
        private decimal iva;
        [XmlElement(ElementName = "IVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Iva
        {
            get { return  iva; }
            set {  iva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVAFONTE
        /// Comentário: Iva diferenciado para calculo de st fonte.
        /// </summary>
        private decimal ivafonte;
        [XmlElement(ElementName = "IVAFONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Ivafonte
        {
            get { return  ivafonte; }
            set {  ivafonte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LATITUDE
        /// Comentário: Localização geografica.
        /// </summary>
        private string latitude;
        [XmlElement(ElementName = "LATITUDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Latitude
        {
            get { return  latitude; }
            set {  latitude = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMCRED
        /// Comentário: 
        /// </summary>
        private decimal limcred;
        [XmlElement(ElementName = "LIMCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Limcred
        {
            get { return  limcred; }
            set {  limcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMCREDCPF
        /// Comentário: Indica se utiliza limite de crédito por CNPJ/CPF.
        /// </summary>
        private decimal limcredcpf;
        [XmlElement(ElementName = "LIMCREDCPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Limcredcpf
        {
            get { return  limcredcpf; }
            set {  limcredcpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMITEAUTORI
        /// Comentário: 
        /// </summary>
        private string limiteautori;
        [XmlElement(ElementName = "LIMITEAUTORI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Limiteautori
        {
            get { return  limiteautori; }
            set {  limiteautori = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LISTAPLPAG
        /// Comentário: 
        /// </summary>
        private string listaplpag;
        [XmlElement(ElementName = "LISTAPLPAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Listaplpag
        {
            get { return  listaplpag; }
            set {  listaplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LONGITUDE
        /// Comentário: Localização geografica.
        /// </summary>
        private string longitude;
        [XmlElement(ElementName = "LONGITUDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Longitude
        {
            get { return  longitude; }
            set {  longitude = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAGENTO_ENT_ID
        /// Comentário: 
        /// </summary>
        private string magento_ent_id;
        [XmlElement(ElementName = "MAGENTO_ENT_ID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Magento_Ent_Id
        {
            get { return  magento_ent_id; }
            set {  magento_ent_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAGENTO_ID
        /// Comentário: 
        /// </summary>
        private string magento_id;
        [XmlElement(ElementName = "MAGENTO_ID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Magento_Id
        {
            get { return  magento_id; }
            set {  magento_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEDCODFUNCLIBTRIBUT
        /// Comentário: 
        /// </summary>
        private decimal medcodfunclibtribut;
        [XmlElement(ElementName = "MEDCODFUNCLIBTRIBUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Medcodfunclibtribut
        {
            get { return  medcodfunclibtribut; }
            set {  medcodfunclibtribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEDDTLIBTRIBUT
        /// Comentário: 
        /// </summary>
        private DateTime? meddtlibtribut;
        [XmlElement(ElementName = "MEDDTLIBTRIBUT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Meddtlibtribut
        {
            get { return  meddtlibtribut; }
            set {  meddtlibtribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEIOCOMUNICACAO
        /// Comentário: 
        /// </summary>
        private string meiocomunicacao;
        [XmlElement(ElementName = "MEIOCOMUNICACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Meiocomunicacao
        {
            get { return  meiocomunicacao; }
            set {  meiocomunicacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MICROEMPRESA
        /// Comentário: 
        /// </summary>
        private string microempresa;
        [XmlElement(ElementName = "MICROEMPRESA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Microempresa
        {
            get { return  microempresa; }
            set {  microempresa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOPROXCONTATO
        /// Comentário: 
        /// </summary>
        private decimal minutoproxcontato;
        [XmlElement(ElementName = "MINUTOPROXCONTATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutoproxcontato
        {
            get { return  minutoproxcontato; }
            set {  minutoproxcontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOEXCLUSAO
        /// Comentário: 
        /// </summary>
        private string motivoexclusao;
        [XmlElement(ElementName = "MOTIVOEXCLUSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Motivoexclusao
        {
            get { return  motivoexclusao; }
            set {  motivoexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICCOB
        /// Comentário: 
        /// </summary>
        private string municcob;
        [XmlElement(ElementName = "MUNICCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Municcob
        {
            get { return  municcob; }
            set {  municcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICCOB2
        /// Comentário: 
        /// </summary>
        private string municcob2;
        [XmlElement(ElementName = "MUNICCOB2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Municcob2
        {
            get { return  municcob2; }
            set {  municcob2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICCOM
        /// Comentário: 
        /// </summary>
        private string municcom;
        [XmlElement(ElementName = "MUNICCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Municcom
        {
            get { return  municcom; }
            set {  municcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICCOM2
        /// Comentário: 
        /// </summary>
        private string municcom2;
        [XmlElement(ElementName = "MUNICCOM2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Municcom2
        {
            get { return  municcom2; }
            set {  municcom2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICCONJUGE
        /// Comentário: 
        /// </summary>
        private string municconjuge;
        [XmlElement(ElementName = "MUNICCONJUGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Municconjuge
        {
            get { return  municconjuge; }
            set {  municconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICEMPR
        /// Comentário: 
        /// </summary>
        private string municempr;
        [XmlElement(ElementName = "MUNICEMPR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Municempr
        {
            get { return  municempr; }
            set {  municempr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICENT
        /// Comentário: 
        /// </summary>
        private string municent;
        [XmlElement(ElementName = "MUNICENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Municent
        {
            get { return  municent; }
            set {  municent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICENT2
        /// Comentário: 
        /// </summary>
        private string municent2;
        [XmlElement(ElementName = "MUNICENT2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Municent2
        {
            get { return  municent2; }
            set {  municent2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NILPLPAGSOBREPOEPLPAGDISTRIB
        /// Comentário: Plano de pagamento do cliente sobrepõe Plano pagamento da distribuição
        /// </summary>
        private string nilplpagsobrepoeplpagdistrib;
        [XmlElement(ElementName = "NILPLPAGSOBREPOEPLPAGDISTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Nilplpagsobrepoeplpagdistrib
        {
            get { return  nilplpagsobrepoeplpagdistrib; }
            set {  nilplpagsobrepoeplpagdistrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECONJUGE
        /// Comentário: 
        /// </summary>
        private string nomeconjuge;
        [XmlElement(ElementName = "NOMECONJUGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomeconjuge
        {
            get { return  nomeconjuge; }
            set {  nomeconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEFARMACEUTICO
        /// Comentário: Campo que define o nome do farmacêutico
        /// </summary>
        private string nomefarmaceutico;
        [XmlElement(ElementName = "NOMEFARMACEUTICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomefarmaceutico
        {
            get { return  nomefarmaceutico; }
            set {  nomefarmaceutico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGENCIA1
        /// Comentário: 
        /// </summary>
        private decimal numagencia1;
        [XmlElement(ElementName = "NUMAGENCIA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numagencia1
        {
            get { return  numagencia1; }
            set {  numagencia1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGENCIA2
        /// Comentário: 
        /// </summary>
        private decimal numagencia2;
        [XmlElement(ElementName = "NUMAGENCIA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numagencia2
        {
            get { return  numagencia2; }
            set {  numagencia2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMALVARA
        /// Comentário: 
        /// </summary>
        private string numalvara;
        [XmlElement(ElementName = "NUMALVARA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numalvara
        {
            get { return  numalvara; }
            set {  numalvara = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMALVARAANVISA
        /// Comentário: Num. Alvará anvisa
        /// </summary>
        private string numalvaraanvisa;
        [XmlElement(ElementName = "NUMALVARAANVISA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numalvaraanvisa
        {
            get { return  numalvaraanvisa; }
            set {  numalvaraanvisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMALVARAESPEC
        /// Comentário: Campo que define o número do Alvará Especial
        /// </summary>
        private string numalvaraespec;
        [XmlElement(ElementName = "NUMALVARAESPEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numalvaraespec
        {
            get { return  numalvaraespec; }
            set {  numalvaraespec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMALVARAFUNC
        /// Comentário: 
        /// </summary>
        private string numalvarafunc;
        [XmlElement(ElementName = "NUMALVARAFUNC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numalvarafunc
        {
            get { return  numalvarafunc; }
            set {  numalvarafunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMALVARARETINOICO
        /// Comentário: Alvará Retinóico / Numero alvará
        /// </summary>
        private string numalvararetinoico;
        [XmlElement(ElementName = "NUMALVARARETINOICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numalvararetinoico
        {
            get { return  numalvararetinoico; }
            set {  numalvararetinoico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMALVARASUS
        /// Comentário: Número alvará sus.
        /// </summary>
        private string numalvarasus;
        [XmlElement(ElementName = "NUMALVARASUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numalvarasus
        {
            get { return  numalvarasus; }
            set {  numalvarasus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBANCO1
        /// Comentário: 
        /// </summary>
        private decimal numbanco1;
        [XmlElement(ElementName = "NUMBANCO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numbanco1
        {
            get { return  numbanco1; }
            set {  numbanco1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBANCO2
        /// Comentário: 
        /// </summary>
        private decimal numbanco2;
        [XmlElement(ElementName = "NUMBANCO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numbanco2
        {
            get { return  numbanco2; }
            set {  numbanco2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARTAOFIDELIDADE
        /// Comentário: Número cartão fidelidade.
        /// </summary>
        private string numcartaofidelidade;
        [XmlElement(ElementName = "NUMCARTAOFIDELIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numcartaofidelidade
        {
            get { return  numcartaofidelidade; }
            set {  numcartaofidelidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCCORRENTE1
        /// Comentário: 
        /// </summary>
        private string numccorrente1;
        [XmlElement(ElementName = "NUMCCORRENTE1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numccorrente1
        {
            get { return  numccorrente1; }
            set {  numccorrente1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCCORRENTE2
        /// Comentário: 
        /// </summary>
        private string numccorrente2;
        [XmlElement(ElementName = "NUMCCORRENTE2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numccorrente2
        {
            get { return  numccorrente2; }
            set {  numccorrente2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONCESSAO
        /// Comentário: 
        /// </summary>
        private string numconcessao;
        [XmlElement(ElementName = "NUMCONCESSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Numconcessao
        {
            get { return  numconcessao; }
            set {  numconcessao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCRF
        /// Comentário: Num. CRF
        /// </summary>
        private string numcrf;
        [XmlElement(ElementName = "NUMCRF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numcrf
        {
            get { return  numcrf; }
            set {  numcrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCRM
        /// Comentário: Número do Conselho Regional de Medicina
        /// </summary>
        private string numcrm;
        [XmlElement(ElementName = "NUMCRM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Numcrm
        {
            get { return  numcrm; }
            set {  numcrm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROCOB
        /// Comentário: Indica o número do endereço para cobrança.
        /// </summary>
        private string numerocob;
        [XmlElement(ElementName = "NUMEROCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Numerocob
        {
            get { return  numerocob; }
            set {  numerocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROCOM
        /// Comentário: Indica o número do endereço para comercial.
        /// </summary>
        private string numerocom;
        [XmlElement(ElementName = "NUMEROCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Numerocom
        {
            get { return  numerocom; }
            set {  numerocom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROENT
        /// Comentário: Indica o número do endereço para entrega.
        /// </summary>
        private string numeroent;
        [XmlElement(ElementName = "NUMEROENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Numeroent
        {
            get { return  numeroent; }
            set {  numeroent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAOCLI
        /// Comentário: 
        /// </summary>
        private decimal numregiaocli;
        [XmlElement(ElementName = "NUMREGIAOCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiaocli
        {
            get { return  numregiaocli; }
            set {  numregiaocli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGISTROIMUNE
        /// Comentário: Número do registro do cliente.
        /// </summary>
        private string numregistroimune;
        [XmlElement(ElementName = "NUMREGISTROIMUNE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numregistroimune
        {
            get { return  numregistroimune; }
            set {  numregistroimune = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQATU
        /// Comentário: 
        /// </summary>
        private decimal numseqatu;
        [XmlElement(ElementName = "NUMSEQATU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Numseqatu
        {
            get { return  numseqatu; }
            set {  numseqatu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQROTARCA
        /// Comentário: 
        /// </summary>
        private decimal numseqrotarca;
        [XmlElement(ElementName = "NUMSEQROTARCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numseqrotarca
        {
            get { return  numseqrotarca; }
            set {  numseqrotarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTARE
        /// Comentário: 
        /// </summary>
        private string numtare;
        [XmlElement(ElementName = "NUMTARE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numtare
        {
            get { return  numtare; }
            set {  numtare = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDADESC
        /// Comentário: 
        /// </summary>
        private decimal numtransvendadesc;
        [XmlElement(ElementName = "NUMTRANSVENDADESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Numtransvendadesc
        {
            get { return  numtransvendadesc; }
            set {  numtransvendadesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS_ADIC
        /// Comentário: Indica a observação adicional.
        /// </summary>
        private string obs_adic;
        [XmlElement(ElementName = "OBS_ADIC", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Obs_Adic
        {
            get { return  obs_adic; }
            set {  obs_adic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSCALLCENTER
        /// Comentário: 
        /// </summary>
        private string obscallcenter;
        [XmlElement(ElementName = "OBSCALLCENTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Obscallcenter
        {
            get { return  obscallcenter; }
            set {  obscallcenter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSCREDITO
        /// Comentário: 
        /// </summary>
        private string obscredito;
        [XmlElement(ElementName = "OBSCREDITO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Obscredito
        {
            get { return  obscredito; }
            set {  obscredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA1
        /// Comentário: 
        /// </summary>
        private string obsentrega1;
        [XmlElement(ElementName = "OBSENTREGA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsentrega1
        {
            get { return  obsentrega1; }
            set {  obsentrega1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA2
        /// Comentário: 
        /// </summary>
        private string obsentrega2;
        [XmlElement(ElementName = "OBSENTREGA2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsentrega2
        {
            get { return  obsentrega2; }
            set {  obsentrega2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA3
        /// Comentário: 
        /// </summary>
        private string obsentrega3;
        [XmlElement(ElementName = "OBSENTREGA3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsentrega3
        {
            get { return  obsentrega3; }
            set {  obsentrega3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA4
        /// Comentário: Código de bairro de Cobrança.
        /// </summary>
        private string obsentrega4;
        [XmlElement(ElementName = "OBSENTREGA4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsentrega4
        {
            get { return  obsentrega4; }
            set {  obsentrega4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: 
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSGERENCIAL1
        /// Comentário: 
        /// </summary>
        private string obsgerencial1;
        [XmlElement(ElementName = "OBSGERENCIAL1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obsgerencial1
        {
            get { return  obsgerencial1; }
            set {  obsgerencial1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSGERENCIAL2
        /// Comentário: 
        /// </summary>
        private string obsgerencial2;
        [XmlElement(ElementName = "OBSGERENCIAL2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obsgerencial2
        {
            get { return  obsgerencial2; }
            set {  obsgerencial2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSGERENCIAL3
        /// Comentário: 
        /// </summary>
        private string obsgerencial3;
        [XmlElement(ElementName = "OBSGERENCIAL3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obsgerencial3
        {
            get { return  obsgerencial3; }
            set {  obsgerencial3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSRECEPCAO
        /// Comentário: 
        /// </summary>
        private string obsrecepcao;
        [XmlElement(ElementName = "OBSRECEPCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Obsrecepcao
        {
            get { return  obsrecepcao; }
            set {  obsrecepcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSSUFRAMA
        /// Comentário: Observação cliente suframa.
        /// </summary>
        private string obssuframa;
        [XmlElement(ElementName = "OBSSUFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obssuframa
        {
            get { return  obssuframa; }
            set {  obssuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSTESOURARIA
        /// Comentário: 
        /// </summary>
        private string obstesouraria;
        [XmlElement(ElementName = "OBSTESOURARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Obstesouraria
        {
            get { return  obstesouraria; }
            set {  obstesouraria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Comentário: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS3
        /// Comentário: 
        /// </summary>
        private string obs3;
        [XmlElement(ElementName = "OBS3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs3
        {
            get { return  obs3; }
            set {  obs3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS4
        /// Comentário: 
        /// </summary>
        private string obs4;
        [XmlElement(ElementName = "OBS4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs4
        {
            get { return  obs4; }
            set {  obs4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS5
        /// Comentário: 
        /// </summary>
        private string obs5;
        [XmlElement(ElementName = "OBS5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs5
        {
            get { return  obs5; }
            set {  obs5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORGAOPUB
        /// Comentário: 
        /// </summary>
        private string orgaopub;
        [XmlElement(ElementName = "ORGAOPUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Orgaopub
        {
            get { return  orgaopub; }
            set {  orgaopub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORGAOPUBFEDERAL
        /// Comentário: Indica se o cliente é orgão public federal.
        /// </summary>
        private string orgaopubfederal;
        [XmlElement(ElementName = "ORGAOPUBFEDERAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Orgaopubfederal
        {
            get { return  orgaopubfederal; }
            set {  orgaopubfederal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORGAOPUBMUNICIPAL
        /// Comentário: Define se o cliente é orgão público múnicipal em atendimento a  Lei Federal nº 9.718.
        /// </summary>
        private string orgaopubmunicipal;
        [XmlElement(ElementName = "ORGAOPUBMUNICIPAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Orgaopubmunicipal
        {
            get { return  orgaopubmunicipal; }
            set {  orgaopubmunicipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORGAORG
        /// Comentário: 
        /// </summary>
        private string orgaorg;
        [XmlElement(ElementName = "ORGAORG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Orgaorg
        {
            get { return  orgaorg; }
            set {  orgaorg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORGAORGCONJ
        /// Comentário: 
        /// </summary>
        private string orgaorgconj;
        [XmlElement(ElementName = "ORGAORGCONJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Orgaorgconj
        {
            get { return  orgaorgconj; }
            set {  orgaorgconj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMPRECO
        /// Comentário: 
        /// </summary>
        private string origempreco;
        [XmlElement(ElementName = "ORIGEMPRECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origempreco
        {
            get { return  origempreco; }
            set {  origempreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAISENT
        /// Comentário: 
        /// </summary>
        private string paisent;
        [XmlElement(ElementName = "PAISENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Paisent
        {
            get { return  paisent; }
            set {  paisent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARAIBASIM
        /// Comentário: 
        /// </summary>
        private string paraibasim;
        [XmlElement(ElementName = "PARAIBASIM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Paraibasim
        {
            get { return  paraibasim; }
            set {  paraibasim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTICIPAFARMACIAPOPULAR
        /// Comentário: Se o cliente participa da Farmácia Popular.
        /// </summary>
        private string participafarmaciapopular;
        [XmlElement(ElementName = "PARTICIPAFARMACIAPOPULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Participafarmaciapopular
        {
            get { return  participafarmaciapopular; }
            set {  participafarmaciapopular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTICIPAFUNCEP
        /// Comentário: Indica se o cliente participa do FUNCEP.
        /// </summary>
        private string participafuncep;
        [XmlElement(ElementName = "PARTICIPAFUNCEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Participafuncep
        {
            get { return  participafuncep; }
            set {  participafuncep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PDVINVESTIMENTO
        /// Comentário: Indica se cliente tem PDV com investimento.
        /// </summary>
        private string pdvinvestimento;
        [XmlElement(ElementName = "PDVINVESTIMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pdvinvestimento
        {
            get { return  pdvinvestimento; }
            set {  pdvinvestimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERACRESTRANSF
        /// Comentário: 
        /// </summary>
        private decimal peracrestransf;
        [XmlElement(ElementName = "PERACRESTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Peracrestransf
        {
            get { return  peracrestransf; }
            set {  peracrestransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBASEVEND
        /// Comentário: 
        /// </summary>
        private decimal perbasevend;
        [XmlElement(ElementName = "PERBASEVEND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perbasevend
        {
            get { return  perbasevend; }
            set {  perbasevend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEVENDQT
        /// Comentário: 
        /// </summary>
        private decimal percbasevendqt;
        [XmlElement(ElementName = "PERCBASEVENDQT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percbasevendqt
        {
            get { return  percbasevendqt; }
            set {  percbasevendqt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal percbonific;
        [XmlElement(ElementName = "PERCBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percbonific
        {
            get { return  percbonific; }
            set {  percbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMCLI
        /// Comentário: 
        /// </summary>
        private decimal percomcli;
        [XmlElement(ElementName = "PERCOMCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percomcli
        {
            get { return  percomcli; }
            set {  percomcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMFILIALBROKER
        /// Comentário: Indica o percentual de comissão a ser paga pela indústria para uma filial que seja Broker.
        /// </summary>
        private decimal percomfilialbroker;
        [XmlElement(ElementName = "PERCOMFILIALBROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomfilialbroker
        {
            get { return  percomfilialbroker; }
            set {  percomfilialbroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTOLVALIDADEPRODWMS
        /// Comentário: Campo para armazenar percentual de tolerância para validade de produto, os valores possíveis são: de 0% a 100%. Campo utilizado apenas quando a filial utiliza WMS.
        /// </summary>
        private decimal perctolvalidadeprodwms;
        [XmlElement(ElementName = "PERCTOLVALIDADEPRODWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perctolvalidadeprodwms
        {
            get { return  perctolvalidadeprodwms; }
            set {  perctolvalidadeprodwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC
        /// Comentário: 
        /// </summary>
        private decimal perdesc;
        [XmlElement(ElementName = "PERDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdesc
        {
            get { return  perdesc; }
            set {  perdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFIN
        /// Comentário: 
        /// </summary>
        private decimal perdescfin;
        [XmlElement(ElementName = "PERDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perdescfin
        {
            get { return  perdescfin; }
            set {  perdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCISENTOICMS
        /// Comentário: 
        /// </summary>
        private decimal perdescisentoicms;
        [XmlElement(ElementName = "PERDESCISENTOICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perdescisentoicms
        {
            get { return  perdescisentoicms; }
            set {  perdescisentoicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC2
        /// Comentário: 
        /// </summary>
        private decimal perdesc2;
        [XmlElement(ElementName = "PERDESC2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdesc2
        {
            get { return  perdesc2; }
            set {  perdesc2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC3
        /// Comentário: 
        /// </summary>
        private decimal perdesc3;
        [XmlElement(ElementName = "PERDESC3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdesc3
        {
            get { return  perdesc3; }
            set {  perdesc3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC4
        /// Comentário: 
        /// </summary>
        private decimal perdesc4;
        [XmlElement(ElementName = "PERDESC4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdesc4
        {
            get { return  perdesc4; }
            set {  perdesc4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC5
        /// Comentário: 
        /// </summary>
        private decimal perdesc5;
        [XmlElement(ElementName = "PERDESC5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdesc5
        {
            get { return  perdesc5; }
            set {  perdesc5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESMAXPONDERADO
        /// Comentário: Percentual de desconto ponderado do cliente.
        /// </summary>
        private decimal perdesmaxponderado;
        [XmlElement(ElementName = "PERDESMAXPONDERADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdesmaxponderado
        {
            get { return  perdesmaxponderado; }
            set {  perdesmaxponderado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETEBROKER
        /// Comentário: Indica o percentual de frete pago pela indústria para uma filial que seja Broker.
        /// </summary>
        private decimal perfretebroker;
        [XmlElement(ElementName = "PERFRETEBROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perfretebroker
        {
            get { return  perfretebroker; }
            set {  perfretebroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIODICIDADEAGRUP
        /// Comentário: Periodicidade do Agrupamento Agendado
        /// </summary>
        private decimal periodicidadeagrup;
        [XmlElement(ElementName = "PERIODICIDADEAGRUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Periodicidadeagrup
        {
            get { return  periodicidadeagrup; }
            set {  periodicidadeagrup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIODVISTORIA
        /// Comentário: Periodicidade das vistorias de comodato
        /// </summary>
        private decimal? periodvistoria;
        [XmlElement(ElementName = "PERIODVISTORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal? Periodvistoria
        {
            get { return  periodvistoria; }
            set {  periodvistoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMINVALIDADE
        /// Comentário: Percentual mínimo de validade compra.
        /// </summary>
        private decimal perminvalidade;
        [XmlElement(ElementName = "PERMINVALIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Perminvalidade
        {
            get { return  perminvalidade; }
            set {  perminvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEALTERCOBRANCACR
        /// Comentário: Indica se é permitido alterar a cobrança de títulos deste cliente (via rotina 1211).
        /// </summary>
        private string permitealtercobrancacr;
        [XmlElement(ElementName = "PERMITEALTERCOBRANCACR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitealtercobrancacr
        {
            get { return  permitealtercobrancacr; }
            set {  permitealtercobrancacr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PISCOFINSCUMULATIVO
        /// Comentário: PIS/COFINS Cumulativo
        /// </summary>
        private string piscofinscumulativo;
        [XmlElement(ElementName = "PISCOFINSCUMULATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Piscofinscumulativo
        {
            get { return  piscofinscumulativo; }
            set {  piscofinscumulativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLPAGNEG
        /// Comentário: 
        /// </summary>
        private string plpagneg;
        [XmlElement(ElementName = "PLPAGNEG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Plpagneg
        {
            get { return  plpagneg; }
            set {  plpagneg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLPAGNEG2
        /// Comentário: 
        /// </summary>
        private string plpagneg2;
        [XmlElement(ElementName = "PLPAGNEG2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Plpagneg2
        {
            get { return  plpagneg2; }
            set {  plpagneg2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PONTOREFER
        /// Comentário: 
        /// </summary>
        private string pontorefer;
        [XmlElement(ElementName = "PONTOREFER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Pontorefer
        {
            get { return  pontorefer; }
            set {  pontorefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOADICIONAL
        /// Comentário: 
        /// </summary>
        private decimal prazoadicional;
        [XmlElement(ElementName = "PRAZOADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoadicional
        {
            get { return  prazoadicional; }
            set {  prazoadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOADICIONAL2
        /// Comentário: 
        /// </summary>
        private decimal prazoadicional2;
        [XmlElement(ElementName = "PRAZOADICIONAL2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoadicional2
        {
            get { return  prazoadicional2; }
            set {  prazoadicional2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOADICIONAL3
        /// Comentário: 
        /// </summary>
        private decimal prazoadicional3;
        [XmlElement(ElementName = "PRAZOADICIONAL3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoadicional3
        {
            get { return  prazoadicional3; }
            set {  prazoadicional3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOADICIONAL4
        /// Comentário: 
        /// </summary>
        private decimal prazoadicional4;
        [XmlElement(ElementName = "PRAZOADICIONAL4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoadicional4
        {
            get { return  prazoadicional4; }
            set {  prazoadicional4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOADICIONAL5
        /// Comentário: 
        /// </summary>
        private decimal prazoadicional5;
        [XmlElement(ElementName = "PRAZOADICIONAL5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoadicional5
        {
            get { return  prazoadicional5; }
            set {  prazoadicional5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOADICIONAL6
        /// Comentário: 
        /// </summary>
        private decimal prazoadicional6;
        [XmlElement(ElementName = "PRAZOADICIONAL6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoadicional6
        {
            get { return  prazoadicional6; }
            set {  prazoadicional6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOADICIONAL7
        /// Comentário: 
        /// </summary>
        private decimal prazoadicional7;
        [XmlElement(ElementName = "PRAZOADICIONAL7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoadicional7
        {
            get { return  prazoadicional7; }
            set {  prazoadicional7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMAXVALIDADE
        /// Comentário: 
        /// </summary>
        private decimal prazomaxvalidade;
        [XmlElement(ElementName = "PRAZOMAXVALIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Prazomaxvalidade
        {
            get { return  prazomaxvalidade; }
            set {  prazomaxvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIOPLPAG
        /// Comentário: Prazo médio máximo de pagamento.
        /// </summary>
        private decimal prazomedioplpag;
        [XmlElement(ElementName = "PRAZOMEDIOPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazomedioplpag
        {
            get { return  prazomedioplpag; }
            set {  prazomedioplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOSERASAGERENCIE
        /// Comentário: O prazo de monitoramento feito pelo sistema gerencie Serasa.
        /// </summary>
        private decimal prazoserasagerencie;
        [XmlElement(ElementName = "PRAZOSERASAGERENCIE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Prazoserasagerencie
        {
            get { return  prazoserasagerencie; }
            set {  prazoserasagerencie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOVALIDADE
        /// Comentário: 
        /// </summary>
        private decimal prazovalidade;
        [XmlElement(ElementName = "PRAZOVALIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazovalidade
        {
            get { return  prazovalidade; }
            set {  prazovalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOVENCST
        /// Comentário: Prazo venc. de contas à receber de ST
        /// </summary>
        private decimal prazovencst;
        [XmlElement(ElementName = "PRAZOVENCST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Prazovencst
        {
            get { return  prazovencst; }
            set {  prazovencst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOUTILIZADONFE
        /// Comentário: Preço Utilizado na NF-e
        /// </summary>
        private string precoutilizadonfe;
        [XmlElement(ElementName = "PRECOUTILIZADONFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Precoutilizadonfe
        {
            get { return  precoutilizadonfe; }
            set {  precoutilizadonfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREDIOPROPRIO
        /// Comentário: 
        /// </summary>
        private string predioproprio;
        [XmlElement(ElementName = "PREDIOPROPRIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Predioproprio
        {
            get { return  predioproprio; }
            set {  predioproprio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCHECKOUT
        /// Comentário: 
        /// </summary>
        private decimal qtcheckout;
        [XmlElement(ElementName = "QTCHECKOUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtcheckout
        {
            get { return  qtcheckout; }
            set {  qtcheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDDIASAPLICDESCFIN
        /// Comentário: Qtde de dias
        /// </summary>
        private decimal qtddiasaplicdescfin;
        [XmlElement(ElementName = "QTDDIASAPLICDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtddiasaplicdescfin
        {
            get { return  qtddiasaplicdescfin; }
            set {  qtddiasaplicdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIASCARENCIACONV
        /// Comentário: Carência do convênio.
        /// </summary>
        private decimal qtdiascarenciaconv;
        [XmlElement(ElementName = "QTDIASCARENCIACONV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtdiascarenciaconv
        {
            get { return  qtdiascarenciaconv; }
            set {  qtdiascarenciaconv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELA
        /// Comentário: 
        /// </summary>
        private decimal qtestrela;
        [XmlElement(ElementName = "QTESTRELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrela
        {
            get { return  qtestrela; }
            set {  qtestrela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RATINGSCI
        /// Comentário: Indica o rating atual.|Campo do tipo caracter, de tamanho 2. 
        /// </summary>
        private string ratingsci;
        [XmlElement(ElementName = "RATINGSCI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ratingsci
        {
            get { return  ratingsci; }
            set {  ratingsci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RATINGSCI1
        /// Comentário: Indica o rating anterior.|Campo do tipo caracter, de tamanho 2. 
        /// </summary>
        private string ratingsci1;
        [XmlElement(ElementName = "RATINGSCI1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ratingsci1
        {
            get { return  ratingsci1; }
            set {  ratingsci1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RATINGSCI2
        /// Comentário: Indica o rating registro mês anterior.|Campo do tipo caracter, de tamanho 2. 
        /// </summary>
        private string ratingsci2;
        [XmlElement(ElementName = "RATINGSCI2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ratingsci2
        {
            get { return  ratingsci2; }
            set {  ratingsci2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECEBERBOLETOPOREMAIL
        /// Comentário: BOLETO, EMAIL
        /// </summary>
        private string receberboletoporemail;
        [XmlElement(ElementName = "RECEBERBOLETOPOREMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Receberboletoporemail
        {
            get { return  receberboletoporemail; }
            set {  receberboletoporemail = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGISTROIBAMA
        /// Comentário: Nr Registro IBAMA
        /// </summary>
        private string registroibama;
        [XmlElement(ElementName = "REGISTROIBAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Registroibama
        {
            get { return  registroibama; }
            set {  registroibama = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGJUNTACOMERCIAL
        /// Comentário: 
        /// </summary>
        private string regjuntacomercial;
        [XmlElement(ElementName = "REGJUNTACOMERCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Regjuntacomercial
        {
            get { return  regjuntacomercial; }
            set {  regjuntacomercial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RENDAMENSAL
        /// Comentário: 
        /// </summary>
        private decimal rendamensal;
        [XmlElement(ElementName = "RENDAMENSAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Rendamensal
        {
            get { return  rendamensal; }
            set {  rendamensal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RENDAMENSALCONJUGE
        /// Comentário: 
        /// </summary>
        private decimal rendamensalconjuge;
        [XmlElement(ElementName = "RENDAMENSALCONJUGE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Rendamensalconjuge
        {
            get { return  rendamensalconjuge; }
            set {  rendamensalconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESSARCIMENTOST
        /// Comentário: 
        /// </summary>
        private string ressarcimentost;
        [XmlElement(ElementName = "RESSARCIMENTOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ressarcimentost
        {
            get { return  ressarcimentost; }
            set {  ressarcimentost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RETENCAOISS
        /// Comentário: Cliente isento de ISS.
        /// </summary>
        private string retencaoiss;
        [XmlElement(ElementName = "RETENCAOISS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Retencaoiss
        {
            get { return  retencaoiss; }
            set {  retencaoiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RFC
        /// Comentário: 
        /// </summary>
        private string rfc;
        [XmlElement(ElementName = "RFC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Rfc
        {
            get { return  rfc; }
            set {  rfc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RG
        /// Comentário: 
        /// </summary>
        private string rg;
        [XmlElement(ElementName = "RG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Rg
        {
            get { return  rg; }
            set {  rg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RGCONJ
        /// Comentário: 
        /// </summary>
        private string rgconj;
        [XmlElement(ElementName = "RGCONJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Rgconj
        {
            get { return  rgconj; }
            set {  rgconj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTEIROMASTERFOODS
        /// Comentário: 
        /// </summary>
        private string roteiromasterfoods;
        [XmlElement(ElementName = "ROTEIROMASTERFOODS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Roteiromasterfoods
        {
            get { return  roteiromasterfoods; }
            set {  roteiromasterfoods = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SACADOELETRONICO
        /// Comentário: Sacado eletrônico.
        /// </summary>
        private string sacadoeletronico;
        [XmlElement(ElementName = "SACADOELETRONICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sacadoeletronico
        {
            get { return  sacadoeletronico; }
            set {  sacadoeletronico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHACONVECF
        /// Comentário: 
        /// </summary>
        private string senhaconvecf;
        [XmlElement(ElementName = "SENHACONVECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Senhaconvecf
        {
            get { return  senhaconvecf; }
            set {  senhaconvecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHA_WEB
        /// Comentário: 
        /// </summary>
        private string senha_web;
        [XmlElement(ElementName = "SENHA_WEB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Senha_Web
        {
            get { return  senha_web; }
            set {  senha_web = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERASAGERENCIE
        /// Comentário: Definir se o cliente esta incluso no sistema Gerencie SERASA.
        /// </summary>
        private string serasagerencie;
        [XmlElement(ElementName = "SERASAGERENCIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Serasagerencie
        {
            get { return  serasagerencie; }
            set {  serasagerencie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEXO
        /// Comentário: 
        /// </summary>
        private string sexo;
        [XmlElement(ElementName = "SEXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sexo
        {
            get { return  sexo; }
            set {  sexo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIGLADEC
        /// Comentário: 
        /// </summary>
        private string sigladec;
        [XmlElement(ElementName = "SIGLADEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Sigladec
        {
            get { return  sigladec; }
            set {  sigladec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIMPLESNACIONAL
        /// Comentário: Informar se o cliente é optante do simples.
        /// </summary>
        private string simplesnacional;
        [XmlElement(ElementName = "SIMPLESNACIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Simplesnacional
        {
            get { return  simplesnacional; }
            set {  simplesnacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITE
        /// Comentário: 
        /// </summary>
        private string site;
        [XmlElement(ElementName = "SITE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Site
        {
            get { return  site; }
            set {  site = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUSCONSULTASINTEGRA
        /// Comentário: Indica o status da consulta sintegra.
        /// </summary>
        private string statusconsultasintegra;
        [XmlElement(ElementName = "STATUSCONSULTASINTEGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Statusconsultasintegra
        {
            get { return  statusconsultasintegra; }
            set {  statusconsultasintegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SULFRAMA
        /// Comentário: 
        /// </summary>
        private string sulframa;
        [XmlElement(ElementName = "SULFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Sulframa
        {
            get { return  sulframa; }
            set {  sulframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUPRIMIDO
        /// Comentário: 
        /// </summary>
        private string suprimido;
        [XmlElement(ElementName = "SUPRIMIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Suprimido
        {
            get { return  suprimido; }
            set {  suprimido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUS
        /// Comentário: Sistema único de saude.
        /// </summary>
        private string sus;
        [XmlElement(ElementName = "SUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sus
        {
            get { return  sus; }
            set {  sus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXABOLETONF
        /// Comentário: Cobrar taxa de boleto pelo método de agrup.títulos no financ.
        /// </summary>
        private string taxaboletonf;
        [XmlElement(ElementName = "TAXABOLETONF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Taxaboletonf
        {
            get { return  taxaboletonf; }
            set {  taxaboletonf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELCELENT
        /// Comentário: 
        /// </summary>
        private string telcelent;
        [XmlElement(ElementName = "TELCELENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telcelent
        {
            get { return  telcelent; }
            set {  telcelent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELCOB
        /// Comentário: 
        /// </summary>
        private string telcob;
        [XmlElement(ElementName = "TELCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telcob
        {
            get { return  telcob; }
            set {  telcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELCOM
        /// Comentário: 
        /// </summary>
        private string telcom;
        [XmlElement(ElementName = "TELCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telcom
        {
            get { return  telcom; }
            set {  telcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELCOMFACULTATIVO
        /// Comentário: 
        /// </summary>
        private string telcomfacultativo;
        [XmlElement(ElementName = "TELCOMFACULTATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telcomfacultativo
        {
            get { return  telcomfacultativo; }
            set {  telcomfacultativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELCONJUGE
        /// Comentário: 
        /// </summary>
        private string telconjuge;
        [XmlElement(ElementName = "TELCONJUGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telconjuge
        {
            get { return  telconjuge; }
            set {  telconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEMPR
        /// Comentário: 
        /// </summary>
        private string telempr;
        [XmlElement(ElementName = "TELEMPR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telempr
        {
            get { return  telempr; }
            set {  telempr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELENT
        /// Comentário: 
        /// </summary>
        private string telent;
        [XmlElement(ElementName = "TELENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telent
        {
            get { return  telent; }
            set {  telent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELENTFACULTATIVO
        /// Comentário: Sacado eletrônico.|Campo do tipo caracter, de tamanho 1, com valor default 'N'
        /// </summary>
        private string telentfacultativo;
        [XmlElement(ElementName = "TELENTFACULTATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telentfacultativo
        {
            get { return  telentfacultativo; }
            set {  telentfacultativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELENT1
        /// Comentário: 
        /// </summary>
        private string telent1;
        [XmlElement(ElementName = "TELENT1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telent1
        {
            get { return  telent1; }
            set {  telent1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOATIVCLI
        /// Comentário: Este campo é referente ao ramo de atividade do CNAE
        /// </summary>
        private string tipoativcli;
        [XmlElement(ElementName = "TIPOATIVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoativcli
        {
            get { return  tipoativcli; }
            set {  tipoativcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCLIMED
        /// Comentário: Indicar tipo cliente, se é hospital, farmácia, etc.
        /// </summary>
        private string tipoclimed;
        [XmlElement(ElementName = "TIPOCLIMED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoclimed
        {
            get { return  tipoclimed; }
            set {  tipoclimed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONVERSAOTV4
        /// Comentário: 
        /// </summary>
        private string tipoconversaotv4;
        [XmlElement(ElementName = "TIPOCONVERSAOTV4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoconversaotv4
        {
            get { return  tipoconversaotv4; }
            set {  tipoconversaotv4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCUSTOTRANSF
        /// Comentário: 
        /// </summary>
        private string tipocustotransf;
        [XmlElement(ElementName = "TIPOCUSTOTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocustotransf
        {
            get { return  tipocustotransf; }
            set {  tipocustotransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCUSTOTRANSF_FILIAIS
        /// Comentário: Indica o tipo de custo de transferência entre Filias.
        /// </summary>
        private string tipocustotransf_filiais;
        [XmlElement(ElementName = "TIPOCUSTOTRANSF_FILIAIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocustotransf_Filiais
        {
            get { return  tipocustotransf_filiais; }
            set {  tipocustotransf_filiais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCUSTOTRANSF_FILIALVIRTUAL
        /// Comentário: Tipo do custo para transferência filial virtual.
        /// </summary>
        private string tipocustotransf_filialvirtual;
        [XmlElement(ElementName = "TIPOCUSTOTRANSF_FILIALVIRTUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocustotransf_Filialvirtual
        {
            get { return  tipocustotransf_filialvirtual; }
            set {  tipocustotransf_filialvirtual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCISENCAO
        /// Comentário: Indica o tipo de isenção de ICMS, que pode ser: N (Não Usar)  C (Por Cliente) ou T (Por Tributação). |Campo do tipo caracter, de tamanho 1.
        /// </summary>
        private string tipodescisencao;
        [XmlElement(ElementName = "TIPODESCISENCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodescisencao
        {
            get { return  tipodescisencao; }
            set {  tipodescisencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOCUMENTO
        /// Comentário: indica se para o cliente emite Nota fiscal (N), Cupom fiscal (C) ou Ambos (A).
        /// </summary>
        private string tipodocumento;
        [XmlElement(ElementName = "TIPODOCUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodocumento
        {
            get { return  tipodocumento; }
            set {  tipodocumento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMPRESA
        /// Comentário: 
        /// </summary>
        private string tipoempresa;
        [XmlElement(ElementName = "TIPOEMPRESA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Tipoempresa
        {
            get { return  tipoempresa; }
            set {  tipoempresa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFJ
        /// Comentário: 
        /// </summary>
        private string tipofj;
        [XmlElement(ElementName = "TIPOFJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofj
        {
            get { return  tipofj; }
            set {  tipofj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTRATAMENTODESCFIN
        /// Comentário: Tratamento desconto financeiro
        /// </summary>
        private string tipotratamentodescfin;
        [XmlElement(ElementName = "TIPOTRATAMENTODESCFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipotratamentodescfin
        {
            get { return  tipotratamentodescfin; }
            set {  tipotratamentodescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOULTALTER
        /// Comentário: 
        /// </summary>
        private string tipoultalter;
        [XmlElement(ElementName = "TIPOULTALTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoultalter
        {
            get { return  tipoultalter; }
            set {  tipoultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVENDA
        /// Comentário: Define o tipo de venda "Varejo" "Atacado"
        /// </summary>
        private string tipovenda;
        [XmlElement(ElementName = "TIPOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovenda
        {
            get { return  tipovenda; }
            set {  tipovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TPCOMUNICADOSERASA
        /// Comentário: Indicativo do Tipo de Comunicado ao Devedor.
        /// </summary>
        private string tpcomunicadoserasa;
        [XmlElement(ElementName = "TPCOMUNICADOSERASA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tpcomunicadoserasa
        {
            get { return  tpcomunicadoserasa; }
            set {  tpcomunicadoserasa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TURNOENTREGA
        /// Comentário: Define o turno de entrega do pedido do cliente
        /// </summary>
        private string turnoentrega;
        [XmlElement(ElementName = "TURNOENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Turnoentrega
        {
            get { return  turnoentrega; }
            set {  turnoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TV10USACUSTOPRODUTO
        /// Comentário: Utilizar custo p/ TV10 do cadastro do produto
        /// </summary>
        private string tv10usacustoproduto;
        [XmlElement(ElementName = "TV10USACUSTOPRODUTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tv10usacustoproduto
        {
            get { return  tv10usacustoproduto; }
            set {  tv10usacustoproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFRG
        /// Comentário: 
        /// </summary>
        private string ufrg;
        [XmlElement(ElementName = "UFRG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufrg
        {
            get { return  ufrg; }
            set {  ufrg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ULTCODPLPAG
        /// Comentário: 
        /// </summary>
        private decimal ultcodplpag;
        [XmlElement(ElementName = "ULTCODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ultcodplpag
        {
            get { return  ultcodplpag; }
            set {  ultcodplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USABKCNPJCODCLIPRINC
        /// Comentário: Indica se em Boleta Laser (1504) ou Remessas (1501) deverá ser impresso/enviado o CNPJ do cliente principal ou do cliente da venda.
        /// </summary>
        private string usabkcnpjcodcliprinc;
        [XmlElement(ElementName = "USABKCNPJCODCLIPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usabkcnpjcodcliprinc
        {
            get { return  usabkcnpjcodcliprinc; }
            set {  usabkcnpjcodcliprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACRECLIFAT
        /// Comentário: Indica se utiliza o crédito de cliente.
        /// </summary>
        private string usacreclifat;
        [XmlElement(ElementName = "USACRECLIFAT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacreclifat
        {
            get { return  usacreclifat; }
            set {  usacreclifat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACROSS
        /// Comentário: 
        /// </summary>
        private string usacross;
        [XmlElement(ElementName = "USACROSS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacross
        {
            get { return  usacross; }
            set {  usacross = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADEBCREDRCA
        /// Comentário: Usa débito e crédito de RCA no momento da venda.
        /// </summary>
        private string usadebcredrca;
        [XmlElement(ElementName = "USADEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadebcredrca
        {
            get { return  usadebcredrca; }
            set {  usadebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADESCFINSEPARADODESCCOM
        /// Comentário: Usa deconto financeiro separado do desconto comercial
        /// </summary>
        private string usadescfinseparadodesccom;
        [XmlElement(ElementName = "USADESCFINSEPARADODESCCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadescfinseparadodesccom
        {
            get { return  usadescfinseparadodesccom; }
            set {  usadescfinseparadodesccom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADESCONTOICMS
        /// Comentário: Desconto ICMS
        /// </summary>
        private string usadescontoicms;
        [XmlElement(ElementName = "USADESCONTOICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadescontoicms
        {
            get { return  usadescontoicms; }
            set {  usadescontoicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAIVAFONTEDIFERENCIADO
        /// Comentário: Indica se o calculo do st fonte para clientes fonte st sera realizado com IVA diferenciado informado por cliente.
        /// </summary>
        private string usaivafontediferenciado;
        [XmlElement(ElementName = "USAIVAFONTEDIFERENCIADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaivafontediferenciado
        {
            get { return  usaivafontediferenciado; }
            set {  usaivafontediferenciado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAVENDAEXPORTACAO
        /// Comentário: Habilita venda para exportação
        /// </summary>
        private string usavendaexportacao;
        [XmlElement(ElementName = "USAVENDAEXPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usavendaexportacao
        {
            get { return  usavendaexportacao; }
            set {  usavendaexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAVLMINVENDABK
        /// Comentário: 
        /// </summary>
        private string usavlminvendabk;
        [XmlElement(ElementName = "USAVLMINVENDABK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usavlminvendabk
        {
            get { return  usavlminvendabk; }
            set {  usavlminvendabk = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: UTILIZACALCULOSTMT
        /// Comentário: Usa novo cálculo de ST para MT
        /// </summary>
        private string utilizacalculostmt;
        [XmlElement(ElementName = "UTILIZACALCULOSTMT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacalculostmt
        {
            get { return  utilizacalculostmt; }
            set {  utilizacalculostmt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAIESIMPLIFICADA
        /// Comentário: 
        /// </summary>
        private string utilizaiesimplificada;
        [XmlElement(ElementName = "UTILIZAIESIMPLIFICADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaiesimplificada
        {
            get { return  utilizaiesimplificada; }
            set {  utilizaiesimplificada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPEDCLINFE
        /// Comentário: Utiliza Pedido de Cliente NFE
        /// </summary>
        private string utilizapedclinfe;
        [XmlElement(ElementName = "UTILIZAPEDCLINFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizapedclinfe
        {
            get { return  utilizapedclinfe; }
            set {  utilizapedclinfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPLPAGMEDICAMENTO
        /// Comentário: Flag que indica se vai ou não utilizar plano de pagamento para medicamento
        /// </summary>
        private string utilizaplpagmedicamento;
        [XmlElement(ElementName = "UTILIZAPLPAGMEDICAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaplpagmedicamento
        {
            get { return  utilizaplpagmedicamento; }
            set {  utilizaplpagmedicamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPRAZOMEDIOPLPAG
        /// Comentário: Utiliza prazo médio máximo de pagamento.
        /// </summary>
        private string utilizaprazomedioplpag;
        [XmlElement(ElementName = "UTILIZAPRAZOMEDIOPLPAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaprazomedioplpag
        {
            get { return  utilizaprazomedioplpag; }
            set {  utilizaprazomedioplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDAMAXVENDAPF
        /// Comentário: 
        /// </summary>
        private string validamaxvendapf;
        [XmlElement(ElementName = "VALIDAMAXVENDAPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validamaxvendapf
        {
            get { return  validamaxvendapf; }
            set {  validamaxvendapf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARCAMPANHABRINDE
        /// Comentário: 
        /// </summary>
        private string validarcampanhabrinde;
        [XmlElement(ElementName = "VALIDARCAMPANHABRINDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarcampanhabrinde
        {
            get { return  validarcampanhabrinde; }
            set {  validarcampanhabrinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARMULTIPLOVENDA
        /// Comentário: 
        /// </summary>
        private string validarmultiplovenda;
        [XmlElement(ElementName = "VALIDARMULTIPLOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarmultiplovenda
        {
            get { return  validarmultiplovenda; }
            set {  validarmultiplovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORALUGUEL
        /// Comentário: 
        /// </summary>
        private decimal valoraluguel;
        [XmlElement(ElementName = "VALORALUGUEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valoraluguel
        {
            get { return  valoraluguel; }
            set {  valoraluguel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VIP
        /// Comentário: 
        /// </summary>
        private string vip;
        [XmlElement(ElementName = "VIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vip
        {
            get { return  vip; }
            set {  vip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTOQUE
        /// Comentário: 
        /// </summary>
        private decimal vlestoque;
        [XmlElement(ElementName = "VLESTOQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestoque
        {
            get { return  vlestoque; }
            set {  vlestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Comentário: Indica o valor de frete por cliente.
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXCOBFRETE
        /// Comentário: Indica o valor máximo de pedido para cobrança de frete.
        /// </summary>
        private decimal vlmaxcobfrete;
        [XmlElement(ElementName = "VLMAXCOBFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlmaxcobfrete
        {
            get { return  vlmaxcobfrete; }
            set {  vlmaxcobfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMEDIACOMPRAMESFORNEC
        /// Comentário: 
        /// </summary>
        private decimal vlmediacompramesfornec;
        [XmlElement(ElementName = "VLMEDIACOMPRAMESFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmediacompramesfornec
        {
            get { return  vlmediacompramesfornec; }
            set {  vlmediacompramesfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINIMOST
        /// Comentário: Valor Mínimo para gerar contas a receber da ST
        /// </summary>
        private decimal vlminimost;
        [XmlElement(ElementName = "VLMINIMOST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlminimost
        {
            get { return  vlminimost; }
            set {  vlminimost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASRENDAS
        /// Comentário: 
        /// </summary>
        private decimal vloutrasrendas;
        [XmlElement(ElementName = "VLOUTRASRENDAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vloutrasrendas
        {
            get { return  vloutrasrendas; }
            set {  vloutrasrendas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPOTENCIALLIMCRED
        /// Comentário: 
        /// </summary>
        private decimal vlpotenciallimcred;
        [XmlElement(ElementName = "VLPOTENCIALLIMCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlpotenciallimcred
        {
            get { return  vlpotenciallimcred; }
            set {  vlpotenciallimcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ZONA
        /// Comentário: Número da zona de visita do cliente
        /// </summary>
        private decimal zona;
        [XmlElement(ElementName = "ZONA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Zona
        {
            get { return  zona; }
            set {  zona = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCClient()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCLIENT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCClient> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCClient>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCClient> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCClient>(where);
        }

        public PCClient Load(string codigo)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCClient>("ROWID = '" + codigo + "'").Single();
        }

        #endregion
    }
}
