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
    /// Classe referente a tabela PCIntegrafrete
    /// </summary>
    [XmlType("PCINTEGRAFRETE")]
    public class PCIntegrafrete : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AD_VLEM
        /// Comentário: VALOR ADICIONAL.
        /// </summary>
        private decimal ad_vlem;
        [XmlElement(ElementName = "AD_VLEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ad_Vlem
        {
            get { return  ad_vlem; }
            set {  ad_vlem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: CÓDIGO CLIENTE.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: CÓDIGO FILIAL.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRANSP
        /// Comentário: CÓDIGO TRANSPORTADORA.
        /// </summary>
        private decimal codtransp;
        [XmlElement(ElementName = "CODTRANSP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codtransp
        {
            get { return  codtransp; }
            set {  codtransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISAO
        /// Comentário: DATA DE EMISSÃO.
        /// </summary>
        private DateTime? dtemisao;
        [XmlElement(ElementName = "DTEMISAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemisao
        {
            get { return  dtemisao; }
            set {  dtemisao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISAOMAN
        /// Comentário: DATA DE EMISSÃO DO MANIFESTO.
        /// </summary>
        private DateTime? dtemisaoman;
        [XmlElement(ElementName = "DTEMISAOMAN", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemisaoman
        {
            get { return  dtemisaoman; }
            set {  dtemisaoman = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMI_BAIRRO
        /// Comentário: BAIRRO DO EMISSOR.
        /// </summary>
        private string emi_bairro;
        [XmlElement(ElementName = "EMI_BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Emi_Bairro
        {
            get { return  emi_bairro; }
            set {  emi_bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMI_CEP
        /// Comentário: CEP DO EMISSOR.
        /// </summary>
        private string emi_cep;
        [XmlElement(ElementName = "EMI_CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,11)]
        public string Emi_Cep
        {
            get { return  emi_cep; }
            set {  emi_cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMI_CGC
        /// Comentário: CGC DO EMISSOR.
        /// </summary>
        private string emi_cgc;
        [XmlElement(ElementName = "EMI_CGC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Emi_Cgc
        {
            get { return  emi_cgc; }
            set {  emi_cgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMI_CIDADE
        /// Comentário: CIDADE DO EMISSOR.
        /// </summary>
        private string emi_cidade;
        [XmlElement(ElementName = "EMI_CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Emi_Cidade
        {
            get { return  emi_cidade; }
            set {  emi_cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMI_ENDERECO
        /// Comentário: ENDEREÇO DO EMISSOR.
        /// </summary>
        private string emi_endereco;
        [XmlElement(ElementName = "EMI_ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Emi_Endereco
        {
            get { return  emi_endereco; }
            set {  emi_endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMI_IE
        /// Comentário: INSCRIÇÃO ESTADUAL DO EMISSOR.
        /// </summary>
        private string emi_ie;
        [XmlElement(ElementName = "EMI_IE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Emi_Ie
        {
            get { return  emi_ie; }
            set {  emi_ie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMI_NOMEFILIAL
        /// Comentário: NOME DO EMISSOR.
        /// </summary>
        private string emi_nomefilial;
        [XmlElement(ElementName = "EMI_NOMEFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Emi_Nomefilial
        {
            get { return  emi_nomefilial; }
            set {  emi_nomefilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMI_UF
        /// Comentário: UF DO EMISSOR.
        /// </summary>
        private string emi_uf;
        [XmlElement(ElementName = "EMI_UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Emi_Uf
        {
            get { return  emi_uf; }
            set {  emi_uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENT_BAIRRO
        /// Comentário: BAIRRO DA ENTREGA.
        /// </summary>
        private string ent_bairro;
        [XmlElement(ElementName = "ENT_BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Ent_Bairro
        {
            get { return  ent_bairro; }
            set {  ent_bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENT_CEP
        /// Comentário: CEP DA ENTREGA.
        /// </summary>
        private string ent_cep;
        [XmlElement(ElementName = "ENT_CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,11)]
        public string Ent_Cep
        {
            get { return  ent_cep; }
            set {  ent_cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENT_CGC
        /// Comentário: CGC DA ENTREGA.
        /// </summary>
        private string ent_cgc;
        [XmlElement(ElementName = "ENT_CGC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Ent_Cgc
        {
            get { return  ent_cgc; }
            set {  ent_cgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENT_CIDADE
        /// Comentário: CIDADE DA ENTREGA.
        /// </summary>
        private string ent_cidade;
        [XmlElement(ElementName = "ENT_CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Ent_Cidade
        {
            get { return  ent_cidade; }
            set {  ent_cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENT_ENDERECO
        /// Comentário: ENDEREÇO DA ENTREGA.
        /// </summary>
        private string ent_endereco;
        [XmlElement(ElementName = "ENT_ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Ent_Endereco
        {
            get { return  ent_endereco; }
            set {  ent_endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENT_IE
        /// Comentário: INSCRIÇÃO ESTADUAL DA ENTREGA.
        /// </summary>
        private string ent_ie;
        [XmlElement(ElementName = "ENT_IE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ent_Ie
        {
            get { return  ent_ie; }
            set {  ent_ie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENT_NOMEFILIAL
        /// Comentário: NOME DA ENTREGA.
        /// </summary>
        private string ent_nomefilial;
        [XmlElement(ElementName = "ENT_NOMEFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Ent_Nomefilial
        {
            get { return  ent_nomefilial; }
            set {  ent_nomefilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENT_UF
        /// Comentário: UF DA ENTREGA.
        /// </summary>
        private string ent_uf;
        [XmlElement(ElementName = "ENT_UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ent_Uf
        {
            get { return  ent_uf; }
            set {  ent_uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERADO
        /// Comentário: CONHECIMENTO GERADO.
        /// </summary>
        private string gerado;
        [XmlElement(ElementName = "GERADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Gerado
        {
            get { return  gerado; }
            set {  gerado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MANIFESTO
        /// Comentário: CÓDIGO DO MANIFESTO.
        /// </summary>
        private decimal manifesto;
        [XmlElement(ElementName = "MANIFESTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public decimal Manifesto
        {
            get { return  manifesto; }
            set {  manifesto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMETRANSP
        /// Comentário: NOME TRANSPORTADORA.
        /// </summary>
        private string nometransp;
        [XmlElement(ElementName = "NOMETRANSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Nometransp
        {
            get { return  nometransp; }
            set {  nometransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: NUMERO DE NOTA FISCAL.
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICM
        /// Comentário: PERCENTUAL ICMS.
        /// </summary>
        private decimal percicm;
        [XmlElement(ElementName = "PERCICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percicm
        {
            get { return  percicm; }
            set {  percicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOTOTAL
        /// Comentário: PESO TOTAL.
        /// </summary>
        private decimal pesototal;
        [XmlElement(ElementName = "PESOTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pesototal
        {
            get { return  pesototal; }
            set {  pesototal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT_VOLUME
        /// Comentário: QUANTIDADE DE VOLUME.
        /// </summary>
        private decimal qt_volume;
        [XmlElement(ElementName = "QT_VOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qt_Volume
        {
            get { return  qt_volume; }
            set {  qt_volume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REM_BAIRRO
        /// Comentário: BAIRRO DA REMETENTE.
        /// </summary>
        private string rem_bairro;
        [XmlElement(ElementName = "REM_BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Rem_Bairro
        {
            get { return  rem_bairro; }
            set {  rem_bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REM_CEP
        /// Comentário: CEP DA REMETENTE.
        /// </summary>
        private string rem_cep;
        [XmlElement(ElementName = "REM_CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,11)]
        public string Rem_Cep
        {
            get { return  rem_cep; }
            set {  rem_cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REM_CGC
        /// Comentário: CGC DA REMETENTE.
        /// </summary>
        private string rem_cgc;
        [XmlElement(ElementName = "REM_CGC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Rem_Cgc
        {
            get { return  rem_cgc; }
            set {  rem_cgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REM_CIDADE
        /// Comentário: CIDADE DA REMETENTE.
        /// </summary>
        private string rem_cidade;
        [XmlElement(ElementName = "REM_CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Rem_Cidade
        {
            get { return  rem_cidade; }
            set {  rem_cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REM_ENDERECO
        /// Comentário: ENDEREÇO DA REMETENTE.
        /// </summary>
        private string rem_endereco;
        [XmlElement(ElementName = "REM_ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Rem_Endereco
        {
            get { return  rem_endereco; }
            set {  rem_endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REM_IE
        /// Comentário: INSCRIÇÃO ESTADUAL DO REMETENTE.
        /// </summary>
        private string rem_ie;
        [XmlElement(ElementName = "REM_IE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Rem_Ie
        {
            get { return  rem_ie; }
            set {  rem_ie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REM_NOMEFILIAL
        /// Comentário: NOME DA REMETENTE.
        /// </summary>
        private string rem_nomefilial;
        [XmlElement(ElementName = "REM_NOMEFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Rem_Nomefilial
        {
            get { return  rem_nomefilial; }
            set {  rem_nomefilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REM_UF
        /// Comentário: UF DA REMETENTE.
        /// </summary>
        private string rem_uf;
        [XmlElement(ElementName = "REM_UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Rem_Uf
        {
            get { return  rem_uf; }
            set {  rem_uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQCONHECNOTA
        /// Comentário: SEQÜÊNCIA DO CONHECIMENTO DE NOTA .
        /// </summary>
        private decimal seqconhecnota;
        [XmlElement(ElementName = "SEQCONHECNOTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Seqconhecnota
        {
            get { return  seqconhecnota; }
            set {  seqconhecnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCARGA
        /// Comentário: VALOR DA DESCARGA.
        /// </summary>
        private decimal vldescarga;
        [XmlElement(ElementName = "VLDESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescarga
        {
            get { return  vldescarga; }
            set {  vldescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Comentário: VALOR DO FRETE.
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIMPOSTOS
        /// Comentário: VALOR DOS IMPOSTOS.
        /// </summary>
        private decimal vlimpostos;
        [XmlElement(ElementName = "VLIMPOSTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlimpostos
        {
            get { return  vlimpostos; }
            set {  vlimpostos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPEDAGIO
        /// Comentário: VALOR DO PEDAGIO.
        /// </summary>
        private decimal vlpedagio;
        [XmlElement(ElementName = "VLPEDAGIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpedagio
        {
            get { return  vlpedagio; }
            set {  vlpedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRNOTA
        /// Comentário: VALOR DA NOTA.
        /// </summary>
        private decimal vlrnota;
        [XmlElement(ElementName = "VLRNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrnota
        {
            get { return  vlrnota; }
            set {  vlrnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUMETOTAL
        /// Comentário: VOLUME TOTAL.
        /// </summary>
        private decimal volumetotal;
        [XmlElement(ElementName = "VOLUMETOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Volumetotal
        {
            get { return  volumetotal; }
            set {  volumetotal = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCIntegrafrete()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINTEGRAFRETE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCIntegrafrete> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCIntegrafrete>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCIntegrafrete> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCIntegrafrete>(where);
        }

        #endregion
    }
}
