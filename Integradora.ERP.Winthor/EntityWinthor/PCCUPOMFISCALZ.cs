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
    /// Classe referente a tabela PCCupomfiscalz
    /// </summary>
    [XmlType("PCCUPOMFISCALZ")]
    public class PCCupomfiscalz : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ARQUIVONFP
        /// Comentário: Indica o nome do arquivo NFP.
        /// </summary>
        private string arquivonfp;
        [XmlElement(ElementName = "ARQUIVONFP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Arquivonfp
        {
            get { return  arquivonfp; }
            set {  arquivonfp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASSINATURA
        /// Comentário: Código Md-5
        /// </summary>
        private string assinatura;
        [XmlElement(ElementName = "ASSINATURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Assinatura
        {
            get { return  assinatura; }
            set {  assinatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: CONFERIDO
        /// Comentário: Informar se a redução Z foi coferida ou não
        /// </summary>
        private string conferido;
        [XmlElement(ElementName = "CONFERIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conferido
        {
            get { return  conferido; }
            set {  conferido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COORZ
        /// Comentário: NUMERO DE COO DA REDUCAO Z
        /// </summary>
        private decimal coorz;
        [XmlElement(ElementName = "COORZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Coorz
        {
            get { return  coorz; }
            set {  coorz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRETORIOGERACAO
        /// Comentário: Diretório onde foi gerado o Arquivo
        /// </summary>
        private string diretoriogeracao;
        [XmlElement(ElementName = "DIRETORIOGERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Diretoriogeracao
        {
            get { return  diretoriogeracao; }
            set {  diretoriogeracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtexportacao;
        [XmlElement(ElementName = "DTEXPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacao
        {
            get { return  dtexportacao; }
            set {  dtexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAOSERVINT
        /// Comentário: 
        /// </summary>
        private DateTime? dtexportacaoservint;
        [XmlElement(ElementName = "DTEXPORTACAOSERVINT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacaoservint
        {
            get { return  dtexportacaoservint; }
            set {  dtexportacaoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORAEMISSAO
        /// Comentário: Data e hora da emissão.
        /// </summary>
        private DateTime? dthoraemissao;
        [XmlElement(ElementName = "DTHORAEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoraemissao
        {
            get { return  dthoraemissao; }
            set {  dthoraemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORANFP
        /// Comentário: Indica a data e hora recebimento arquivo NFP.
        /// </summary>
        private DateTime? dthoranfp;
        [XmlElement(ElementName = "DTHORANFP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoranfp
        {
            get { return  dthoranfp; }
            set {  dthoranfp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAOSERVPRINC
        /// Comentário: 
        /// </summary>
        private DateTime? dtimportacaoservprinc;
        [XmlElement(ElementName = "DTIMPORTACAOSERVPRINC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacaoservprinc
        {
            get { return  dtimportacaoservprinc; }
            set {  dtimportacaoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Comentário: 
        /// </summary>
        private string exportado;
        [XmlElement(ElementName = "EXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportado
        {
            get { return  exportado; }
            set {  exportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADOSERVINT
        /// Comentário: 
        /// </summary>
        private string exportadoservint;
        [XmlElement(ElementName = "EXPORTADOSERVINT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportadoservint
        {
            get { return  exportadoservint; }
            set {  exportadoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GTFINAL
        /// Comentário: 
        /// </summary>
        private decimal gtfinal;
        [XmlElement(ElementName = "GTFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Gtfinal
        {
            get { return  gtfinal; }
            set {  gtfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GTINICIO
        /// Comentário: 
        /// </summary>
        private decimal gtinicio;
        [XmlElement(ElementName = "GTINICIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Gtinicio
        {
            get { return  gtinicio; }
            set {  gtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADOSERVPRINC
        /// Comentário: 
        /// </summary>
        private string importadoservprinc;
        [XmlElement(ElementName = "IMPORTADOSERVPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importadoservprinc
        {
            get { return  importadoservprinc; }
            set {  importadoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELO
        /// Comentário: 
        /// </summary>
        private string modelo;
        [XmlElement(ElementName = "MODELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Modelo
        {
            get { return  modelo; }
            set {  modelo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODOENVIONFP
        /// Comentário: Indica o modo de envio da redução para o SEFAZ - [P]Produção [V]Validação.
        /// </summary>
        private string modoenvionfp;
        [XmlElement(ElementName = "MODOENVIONFP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Modoenvionfp
        {
            get { return  modoenvionfp; }
            set {  modoenvionfp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEARQUIVO
        /// Comentário: Nome do arquivo gerado
        /// </summary>
        private string nomearquivo;
        [XmlElement(ElementName = "NOMEARQUIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Nomearquivo
        {
            get { return  nomearquivo; }
            set {  nomearquivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXAFISCAL
        /// Comentário: 
        /// </summary>
        private decimal numcaixafiscal;
        [XmlElement(ElementName = "NUMCAIXAFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcaixafiscal
        {
            get { return  numcaixafiscal; }
            set {  numcaixafiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCDC
        /// Comentário: Contador de comprovante de crédito ou débito.
        /// </summary>
        private decimal numcdc;
        [XmlElement(ElementName = "NUMCDC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcdc
        {
            get { return  numcdc; }
            set {  numcdc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCOO
        /// Comentário: Número do COO
        /// </summary>
        private decimal numcoo;
        [XmlElement(ElementName = "NUMCOO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcoo
        {
            get { return  numcoo; }
            set {  numcoo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOMFIM
        /// Comentário: 
        /// </summary>
        private decimal numcupomfim;
        [XmlElement(ElementName = "NUMCUPOMFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numcupomfim
        {
            get { return  numcupomfim; }
            set {  numcupomfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOMINICIO
        /// Comentário: 
        /// </summary>
        private decimal numcupominicio;
        [XmlElement(ElementName = "NUMCUPOMINICIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numcupominicio
        {
            get { return  numcupominicio; }
            set {  numcupominicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMECF
        /// Comentário: 
        /// </summary>
        private decimal numecf;
        [XmlElement(ElementName = "NUMECF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numecf
        {
            get { return  numecf; }
            set {  numecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMGNF
        /// Comentário: Contador geral de operação não fiscal.
        /// </summary>
        private decimal numgnf;
        [XmlElement(ElementName = "NUMGNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numgnf
        {
            get { return  numgnf; }
            set {  numgnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMGRG
        /// Comentário: Contador geral de relatório gerencial.
        /// </summary>
        private decimal numgrg;
        [XmlElement(ElementName = "NUMGRG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numgrg
        {
            get { return  numgrg; }
            set {  numgrg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMAPA
        /// Comentário: 
        /// </summary>
        private decimal nummapa;
        [XmlElement(ElementName = "NUMMAPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Nummapa
        {
            get { return  nummapa; }
            set {  nummapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREDUCAOZ
        /// Comentário: 
        /// </summary>
        private decimal numreducaoz;
        [XmlElement(ElementName = "NUMREDUCAOZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numreducaoz
        {
            get { return  numreducaoz; }
            set {  numreducaoz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREINICIO
        /// Comentário: 
        /// </summary>
        private decimal numreinicio;
        [XmlElement(ElementName = "NUMREINICIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numreinicio
        {
            get { return  numreinicio; }
            set {  numreinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIE
        /// Comentário: 
        /// </summary>
        private string numserie;
        [XmlElement(ElementName = "NUMSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numserie
        {
            get { return  numserie; }
            set {  numserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSNFP
        /// Comentário: OBS NFP.
        /// </summary>
        private string obsnfp;
        [XmlElement(ElementName = "OBSNFP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,800)]
        public string Obsnfp
        {
            get { return  obsnfp; }
            set {  obsnfp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLONFP
        /// Comentário: Indica o numero do protocolo NFP.
        /// </summary>
        private string protocolonfp;
        [XmlElement(ElementName = "PROTOCOLONFP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Protocolonfp
        {
            get { return  protocolonfp; }
            set {  protocolonfp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REENVIARNFP
        /// Comentário: Reenviar NFP.
        /// </summary>
        private string reenviarnfp;
        [XmlElement(ElementName = "REENVIARNFP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reenviarnfp
        {
            get { return  reenviarnfp; }
            set {  reenviarnfp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Comentário: ROTINA QUE GRAVOU A INFORMACAO
        /// </summary>
        private string rotinalanc;
        [XmlElement(ElementName = "ROTINALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,48)]
        public string Rotinalanc
        {
            get { return  rotinalanc; }
            set {  rotinalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAONFP
        /// Comentário: Indica a situação da NFP.
        /// </summary>
        private string situacaonfp;
        [XmlElement(ElementName = "SITUACAONFP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Situacaonfp
        {
            get { return  situacaonfp; }
            set {  situacaonfp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDABRUTA
        /// Comentário: VENDA BRUTA
        /// </summary>
        private decimal vendabruta;
        [XmlElement(ElementName = "VENDABRUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vendabruta
        {
            get { return  vendabruta; }
            set {  vendabruta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCONTABIL
        /// Comentário: 
        /// </summary>
        private decimal vlcontabil;
        [XmlElement(ElementName = "VLCONTABIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcontabil
        {
            get { return  vlcontabil; }
            set {  vlcontabil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLNFP
        /// Comentário: Indica o valor do NFP
        /// </summary>
        private decimal vlnfp;
        [XmlElement(ElementName = "VLNFP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlnfp
        {
            get { return  vlnfp; }
            set {  vlnfp = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCupomfiscalz()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCUPOMFISCALZ";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCupomfiscalz> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCupomfiscalz>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCupomfiscalz> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCupomfiscalz>(where);
        }

        #endregion
    }
}
