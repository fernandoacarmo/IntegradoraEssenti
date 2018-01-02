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
    /// Classe referente a tabela PCClientfv
    /// </summary>
    [XmlType("PCCLIENTFV")]
    public class PCClientfv : OracleTable
    {
        #region Atributos

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
        [XmlElement(ElementName = "CGCENT", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public string Cgcent
        {
            get { return  cgcent; }
            set {  cgcent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTE
        /// Comentário: 
        /// </summary>
        private string cliente;
        [XmlElement(ElementName = "CLIENTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,60)]
        public string Cliente
        {
            get { return  cliente; }
            set {  cliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTPROTESTO
        /// Comentário: cliente protsto
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
        /// Propriedade referente ao campo: CODCIDADEIBGE
        /// Comentário: Codigo cidade ibge
        /// </summary>
        private decimal codcidadeibge;
        [XmlElement(ElementName = "CODCIDADEIBGE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcidadeibge
        {
            get { return  codcidadeibge; }
            set {  codcidadeibge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Codigo do cliente que será usado em conjunto com o campo cnpj para identificar o cliente no caso de ter no cadastro mais de um cliente com mesmo cnpj
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
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
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: CÓdigo de cobranca
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
        /// Propriedade referente ao campo: CODFILIALNF
        /// Comentário: codigo filial NF
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
        /// Propriedade referente ao campo: CODPAIS
        /// Comentário: Código do País
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
        /// Comentário: CÓdigo do plano de pagamento
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
        /// Propriedade referente ao campo: COMPLEMENTOCOB
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: CONSUMIDORFINAL
        /// Comentário: consumidor final
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
        /// Propriedade referente ao campo: CONTRIBUINTE
        /// Comentário: Contribuinte
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
        /// Propriedade referente ao campo: DATACOLETA
        /// Comentário: 
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
        /// Propriedade referente ao campo: DIASEMANA
        /// Comentário: Dia da semana para roteirização
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
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: Data de Alteração no registro
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: Grava Data e Hora da Última Importação.
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
        /// Comentário: Email NFE
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
        /// Propriedade referente ao campo: ENVIONFEMAILCOM
        /// Comentário: envia nf por email
        /// </summary>
        private string envionfemailcom;
        [XmlElement(ElementName = "ENVIONFEMAILCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Envionfemailcom
        {
            get { return  envionfemailcom; }
            set {  envionfemailcom = value; }
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
        /// Propriedade referente ao campo: IEENT
        /// Comentário: 
        /// </summary>
        private string ieent;
        [XmlElement(ElementName = "IEENT", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
        public string Ieent
        {
            get { return  ieent; }
            set {  ieent = value; }
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
        /// Propriedade referente ao campo: IMPORTADO
        /// Comentário: 
        /// </summary>
        private decimal importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LATITUDE
        /// Comentário: 
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
        /// Propriedade referente ao campo: LONGITUDE
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMEROCOB
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMSEMANA
        /// Comentário: Número da semana para roteirização
        /// </summary>
        private decimal numsemana;
        [XmlElement(ElementName = "NUMSEMANA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numsemana
        {
            get { return  numsemana; }
            set {  numsemana = value; }
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: OBSERVACAO_PC
        /// Comentário: 
        /// </summary>
        private string observacao_pc;
        [XmlElement(ElementName = "OBSERVACAO_PC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Observacao_Pc
        {
            get { return  observacao_pc; }
            set {  observacao_pc = value; }
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
        /// Propriedade referente ao campo: PERIODICIDADE
        /// Comentário: Periodicidade para roteirização
        /// </summary>
        private string periodicidade;
        [XmlElement(ElementName = "PERIODICIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Periodicidade
        {
            get { return  periodicidade; }
            set {  periodicidade = value; }
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
        /// Propriedade referente ao campo: SEQUENCIA
        /// Comentário: Sequência para roteirização
        /// </summary>
        private decimal sequencia;
        [XmlElement(ElementName = "SEQUENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Sequencia
        {
            get { return  sequencia; }
            set {  sequencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIMPLESNACIONAL
        /// Comentário: Indica se cliente aderiu ao simples nacional
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
        /// Propriedade referente ao campo: TIPOOPERACAO
        /// Comentário: 
        /// </summary>
        private string tipooperacao;
        [XmlElement(ElementName = "TIPOOPERACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipooperacao
        {
            get { return  tipooperacao; }
            set {  tipooperacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCClientfv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCLIENTFV";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCClientfv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCClientfv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCClientfv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCClientfv>(where);
        }

        #endregion
    }
}
