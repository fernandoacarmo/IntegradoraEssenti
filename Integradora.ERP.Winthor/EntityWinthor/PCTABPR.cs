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
    /// Classe referente a tabela PCTabpr
    /// </summary>
    [XmlType("PCTABPR")]
    public class PCTabpr : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAR
        /// Comentário: Na rotina 201, indicará se o preço da região será atualizado pela tecla F11, ou não. 
        /// </summary>
        private string atualizar;
        [XmlElement(ElementName = "ATUALIZAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizar
        {
            get { return  atualizar; }
            set {  atualizar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODST
        /// Comentário: 
        /// </summary>
        private decimal codst;
        [XmlElement(ElementName = "CODST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codst
        {
            get { return  codst; }
            set {  codst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBPISCOFINS
        /// Comentário: Código tributação PIS/COFINS
        /// </summary>
        private decimal codtribpiscofins;
        [XmlElement(ElementName = "CODTRIBPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codtribpiscofins
        {
            get { return  codtribpiscofins; }
            set {  codtribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COTAITEM
        /// Comentário: 
        /// </summary>
        private decimal cotaitem;
        [XmlElement(ElementName = "COTAITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Cotaitem
        {
            get { return  cotaitem; }
            set {  cotaitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COTAITEMTAB
        /// Comentário: 
        /// </summary>
        private decimal cotaitemtab;
        [XmlElement(ElementName = "COTAITEMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Cotaitemtab
        {
            get { return  cotaitemtab; }
            set {  cotaitemtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPRECIFIC
        /// Comentário: Custo utilizado na precificação.
        /// </summary>
        private decimal custoprecific;
        [XmlElement(ElementName = "CUSTOPRECIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoprecific
        {
            get { return  custoprecific; }
            set {  custoprecific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPRECIFICTAB
        /// Comentário: Custo utilizado na precificação tab.
        /// </summary>
        private decimal custoprecifictab;
        [XmlElement(ElementName = "CUSTOPRECIFICTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoprecifictab
        {
            get { return  custoprecifictab; }
            set {  custoprecifictab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCONTAFRETE
        /// Comentário: 
        /// </summary>
        private string descontafrete;
        [XmlElement(ElementName = "DESCONTAFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Descontafrete
        {
            get { return  descontafrete; }
            set {  descontafrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOETIQ
        /// Comentário: 
        /// </summary>
        private DateTime? dtemissaoetiq;
        [XmlElement(ElementName = "DTEMISSAOETIQ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaoetiq
        {
            get { return  dtemissaoetiq; }
            set {  dtemissaoetiq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMVALIDADE
        /// Comentário: 
        /// </summary>
        private DateTime? dtfimvalidade;
        [XmlElement(ElementName = "DTFIMVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimvalidade
        {
            get { return  dtfimvalidade; }
            set {  dtfimvalidade = value; }
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
        /// Propriedade referente ao campo: DTINICIOPTABELA
        /// Comentário: 
        /// </summary>
        private DateTime? dtinicioptabela;
        [XmlElement(ElementName = "DTINICIOPTABELA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicioptabela
        {
            get { return  dtinicioptabela; }
            set {  dtinicioptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOVALIDADE
        /// Comentário: 
        /// </summary>
        private DateTime? dtiniciovalidade;
        [XmlElement(ElementName = "DTINICIOVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciovalidade
        {
            get { return  dtiniciovalidade; }
            set {  dtiniciovalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTERSRVPRC
        /// Comentário: Indica a data da ultima alteração nesta tabela.
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
        /// Propriedade referente ao campo: DTULTALTPTABELA
        /// Comentário: 
        /// </summary>
        private DateTime? dtultaltptabela;
        [XmlElement(ElementName = "DTULTALTPTABELA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltptabela
        {
            get { return  dtultaltptabela; }
            set {  dtultaltptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTPTABELAFUTURO
        /// Comentário: 
        /// </summary>
        private DateTime? dtultaltptabelafuturo;
        [XmlElement(ElementName = "DTULTALTPTABELAFUTURO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltptabelafuturo
        {
            get { return  dtultaltptabelafuturo; }
            set {  dtultaltptabelafuturo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTPVENDA
        /// Comentário: 
        /// </summary>
        private DateTime? dtultaltpvenda;
        [XmlElement(ElementName = "DTULTALTPVENDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltpvenda
        {
            get { return  dtultaltpvenda; }
            set {  dtultaltpvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTATUPVENDA
        /// Comentário: Data da última atualização do preço de venda.
        /// </summary>
        private DateTime? dtultatupvenda;
        [XmlElement(ElementName = "DTULTATUPVENDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultatupvenda
        {
            get { return  dtultatupvenda; }
            set {  dtultatupvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALPREVISTA
        /// Comentário: DATA DE VALIDADE DO PREÇO DE REVISTA
        /// </summary>
        private DateTime? dtvalprevista;
        [XmlElement(ElementName = "DTVALPREVISTA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalprevista
        {
            get { return  dtvalprevista; }
            set {  dtvalprevista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXCLUIDO
        /// Comentário: 
        /// </summary>
        private string excluido;
        [XmlElement(ElementName = "EXCLUIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Excluido
        {
            get { return  excluido; }
            set {  excluido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICEPRECO
        /// Comentário: Índice que será multiplicado ao preço de venda para que seja calculado o preço de Atacado ou de Varejo. 
        /// </summary>
        private decimal indicepreco;
        [XmlElement(ElementName = "INDICEPRECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Indicepreco
        {
            get { return  indicepreco; }
            set {  indicepreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEM
        /// Comentário: 
        /// </summary>
        private decimal margem;
        [XmlElement(ElementName = "MARGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Margem
        {
            get { return  margem; }
            set {  margem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEM_ESP
        /// Comentário: 
        /// </summary>
        private decimal margem_esp;
        [XmlElement(ElementName = "MARGEM_ESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Margem_Esp
        {
            get { return  margem_esp; }
            set {  margem_esp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Comentário: Usuario que fez a alteração
        /// </summary>
        private decimal matricula;
        [XmlElement(ElementName = "MATRICULA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matricula
        {
            get { return  matricula; }
            set {  matricula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: 
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
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
        /// Propriedade referente ao campo: OBS
        /// Comentário: Observação do motivo da precificação abaixo do mínimo
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMREP1
        /// Comentário: 
        /// </summary>
        private decimal pcomrep1;
        [XmlElement(ElementName = "PCOMREP1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcomrep1
        {
            get { return  pcomrep1; }
            set {  pcomrep1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMREP2
        /// Comentário: 
        /// </summary>
        private decimal pcomrep2;
        [XmlElement(ElementName = "PCOMREP2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcomrep2
        {
            get { return  pcomrep2; }
            set {  pcomrep2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMREP3
        /// Comentário: 
        /// </summary>
        private decimal pcomrep3;
        [XmlElement(ElementName = "PCOMREP3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcomrep3
        {
            get { return  pcomrep3; }
            set {  pcomrep3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESCIMOFRETE
        /// Comentário: 
        /// </summary>
        private decimal percacrescimofrete;
        [XmlElement(ElementName = "PERCACRESCIMOFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percacrescimofrete
        {
            get { return  percacrescimofrete; }
            set {  percacrescimofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOM
        /// Comentário: % COMISSAO.
        /// </summary>
        private decimal perccom;
        [XmlElement(ElementName = "PERCCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perccom
        {
            get { return  perccom; }
            set {  perccom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOMGARANTIDA
        /// Comentário: % COMISSAO GARANTIDA
        /// </summary>
        private decimal perccomgarantida;
        [XmlElement(ElementName = "PERCCOMGARANTIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perccomgarantida
        {
            get { return  perccomgarantida; }
            set {  perccomgarantida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOMGARANTIDATAB
        /// Comentário: % COMISSÃO GARANTIDA FUTURA
        /// </summary>
        private decimal perccomgarantidatab;
        [XmlElement(ElementName = "PERCCOMGARANTIDATAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perccomgarantidatab
        {
            get { return  perccomgarantidatab; }
            set {  perccomgarantidatab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCSIMPLESNAC
        /// Comentário: Percentual Desc. Simples Nacional.
        /// </summary>
        private decimal percdescsimplesnac;
        [XmlElement(ElementName = "PERCDESCSIMPLESNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percdescsimplesnac
        {
            get { return  percdescsimplesnac; }
            set {  percdescsimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPIVENDATAB
        /// Comentário: Indica o percentural do IPI venda futuro.
        /// </summary>
        private decimal percipivendatab;
        [XmlElement(ElementName = "PERCIPIVENDATAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percipivendatab
        {
            get { return  percipivendatab; }
            set {  percipivendatab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCAUTOR
        /// Comentário: 
        /// </summary>
        private decimal perdescautor;
        [XmlElement(ElementName = "PERDESCAUTOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdescautor
        {
            get { return  perdescautor; }
            set {  perdescautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCAUTORTAB
        /// Comentário: 
        /// </summary>
        private decimal perdescautortab;
        [XmlElement(ElementName = "PERDESCAUTORTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdescautortab
        {
            get { return  perdescautortab; }
            set {  perdescautortab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFOB
        /// Comentário: 
        /// </summary>
        private decimal perdescfob;
        [XmlElement(ElementName = "PERDESCFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perdescfob
        {
            get { return  perdescfob; }
            set {  perdescfob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAX
        /// Comentário: 
        /// </summary>
        private decimal perdescmax;
        [XmlElement(ElementName = "PERDESCMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmax
        {
            get { return  perdescmax; }
            set {  perdescmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXAVISTA
        /// Comentário: % DESCONTO MÁXIMO VENDA AVISTA
        /// </summary>
        private decimal perdescmaxavista;
        [XmlElement(ElementName = "PERDESCMAXAVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxavista
        {
            get { return  perdescmaxavista; }
            set {  perdescmaxavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXAVISTATAB
        /// Comentário: % DESCONTO MAXIMO À VISTA FUTURO
        /// </summary>
        private decimal perdescmaxavistatab;
        [XmlElement(ElementName = "PERDESCMAXAVISTATAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxavistatab
        {
            get { return  perdescmaxavistatab; }
            set {  perdescmaxavistatab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXBALCAO
        /// Comentário: 
        /// </summary>
        private decimal perdescmaxbalcao;
        [XmlElement(ElementName = "PERDESCMAXBALCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxbalcao
        {
            get { return  perdescmaxbalcao; }
            set {  perdescmaxbalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXESP
        /// Comentário: 
        /// </summary>
        private decimal perdescmaxesp;
        [XmlElement(ElementName = "PERDESCMAXESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdescmaxesp
        {
            get { return  perdescmaxesp; }
            set {  perdescmaxesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXIDEAL
        /// Comentário: % DESCONTO MAXIMO IDEAL VENDA
        /// </summary>
        private decimal perdescmaxideal;
        [XmlElement(ElementName = "PERDESCMAXIDEAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxideal
        {
            get { return  perdescmaxideal; }
            set {  perdescmaxideal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXIDEALTAB
        /// Comentário: % DESCONTO MAXIMO IDEAL FUTURO
        /// </summary>
        private decimal perdescmaxidealtab;
        [XmlElement(ElementName = "PERDESCMAXIDEALTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxidealtab
        {
            get { return  perdescmaxidealtab; }
            set {  perdescmaxidealtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXPOSSIVEL
        /// Comentário: % DESCONTO MÁXIMO POSSÍVEL
        /// </summary>
        private decimal perdescmaxpossivel;
        [XmlElement(ElementName = "PERDESCMAXPOSSIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxpossivel
        {
            get { return  perdescmaxpossivel; }
            set {  perdescmaxpossivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXPOSSIVELTAB
        /// Comentário: % DESCONTO MAXIMO POSSIVEL FUTURO
        /// </summary>
        private decimal perdescmaxpossiveltab;
        [XmlElement(ElementName = "PERDESCMAXPOSSIVELTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxpossiveltab
        {
            get { return  perdescmaxpossiveltab; }
            set {  perdescmaxpossiveltab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXTAB
        /// Comentário: 
        /// </summary>
        private decimal perdescmaxtab;
        [XmlElement(ElementName = "PERDESCMAXTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxtab
        {
            get { return  perdescmaxtab; }
            set {  perdescmaxtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXTABBALCAO
        /// Comentário: 
        /// </summary>
        private decimal perdescmaxtabbalcao;
        [XmlElement(ElementName = "PERDESCMAXTABBALCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxtabbalcao
        {
            get { return  perdescmaxtabbalcao; }
            set {  perdescmaxtabbalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PFRETE
        /// Comentário: 
        /// </summary>
        private decimal pfrete;
        [XmlElement(ElementName = "PFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pfrete
        {
            get { return  pfrete; }
            set {  pfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTA
        /// Comentário: 
        /// </summary>
        private decimal poferta;
        [XmlElement(ElementName = "POFERTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Poferta
        {
            get { return  poferta; }
            set {  poferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTAAUX
        /// Comentário: 
        /// </summary>
        private decimal pofertaaux;
        [XmlElement(ElementName = "POFERTAAUX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pofertaaux
        {
            get { return  pofertaaux; }
            set {  pofertaaux = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTATAB
        /// Comentário: 
        /// </summary>
        private decimal pofertatab;
        [XmlElement(ElementName = "POFERTATAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pofertatab
        {
            get { return  pofertatab; }
            set {  pofertatab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOANTERIORATAC
        /// Comentário: 
        /// </summary>
        private decimal precoanterioratac;
        [XmlElement(ElementName = "PRECOANTERIORATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precoanterioratac
        {
            get { return  precoanterioratac; }
            set {  precoanterioratac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOFAB
        /// Comentário: 
        /// </summary>
        private decimal precofab;
        [XmlElement(ElementName = "PRECOFAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precofab
        {
            get { return  precofab; }
            set {  precofab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMAXCONSUM
        /// Comentário: Indica o preço máximo ao consumidor. 
        /// </summary>
        private decimal precomaxconsum;
        [XmlElement(ElementName = "PRECOMAXCONSUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precomaxconsum
        {
            get { return  precomaxconsum; }
            set {  precomaxconsum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMAXCONSUMTAB
        /// Comentário: Preço máximo consumidor futuro.
        /// </summary>
        private decimal precomaxconsumtab;
        [XmlElement(ElementName = "PRECOMAXCONSUMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precomaxconsumtab
        {
            get { return  precomaxconsumtab; }
            set {  precomaxconsumtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMINIMOTABELA
        /// Comentário: 
        /// </summary>
        private decimal precominimotabela;
        [XmlElement(ElementName = "PRECOMINIMOTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Precominimotabela
        {
            get { return  precominimotabela; }
            set {  precominimotabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMINIMOVENDA
        /// Comentário: 
        /// </summary>
        private decimal precominimovenda;
        [XmlElement(ElementName = "PRECOMINIMOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Precominimovenda
        {
            get { return  precominimovenda; }
            set {  precominimovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOREVISTA
        /// Comentário: PREÇO DE REVISTA DO PRODUTO
        /// </summary>
        private decimal precorevista;
        [XmlElement(ElementName = "PRECOREVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precorevista
        {
            get { return  precorevista; }
            set {  precorevista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Comentário: 
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATAC
        /// Comentário: 
        /// </summary>
        private decimal ptabelaatac;
        [XmlElement(ElementName = "PTABELAATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatac
        {
            get { return  ptabelaatac; }
            set {  ptabelaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATACSEMIMPOSTO1
        /// Comentário: Preço de Tabela atacado 1 sem imposto
        /// </summary>
        private decimal ptabelaatacsemimposto1;
        [XmlElement(ElementName = "PTABELAATACSEMIMPOSTO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatacsemimposto1
        {
            get { return  ptabelaatacsemimposto1; }
            set {  ptabelaatacsemimposto1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATACSEMIMPOSTO2
        /// Comentário: Preço de Tabela atacado 2 sem imposto
        /// </summary>
        private decimal ptabelaatacsemimposto2;
        [XmlElement(ElementName = "PTABELAATACSEMIMPOSTO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatacsemimposto2
        {
            get { return  ptabelaatacsemimposto2; }
            set {  ptabelaatacsemimposto2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATACSEMIMPOSTO3
        /// Comentário: Preço de Tabela atacado 3 sem imposto
        /// </summary>
        private decimal ptabelaatacsemimposto3;
        [XmlElement(ElementName = "PTABELAATACSEMIMPOSTO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatacsemimposto3
        {
            get { return  ptabelaatacsemimposto3; }
            set {  ptabelaatacsemimposto3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATACSEMIMPOSTO4
        /// Comentário: Preço de Tabela atacado 4 sem imposto
        /// </summary>
        private decimal ptabelaatacsemimposto4;
        [XmlElement(ElementName = "PTABELAATACSEMIMPOSTO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatacsemimposto4
        {
            get { return  ptabelaatacsemimposto4; }
            set {  ptabelaatacsemimposto4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATACSEMIMPOSTO5
        /// Comentário: Preço de Tabela atacado 5 sem imposto
        /// </summary>
        private decimal ptabelaatacsemimposto5;
        [XmlElement(ElementName = "PTABELAATACSEMIMPOSTO5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatacsemimposto5
        {
            get { return  ptabelaatacsemimposto5; }
            set {  ptabelaatacsemimposto5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATACSEMIMPOSTO6
        /// Comentário: Preço de Tabela atacado 6 sem imposto
        /// </summary>
        private decimal ptabelaatacsemimposto6;
        [XmlElement(ElementName = "PTABELAATACSEMIMPOSTO6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatacsemimposto6
        {
            get { return  ptabelaatacsemimposto6; }
            set {  ptabelaatacsemimposto6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATACSEMIMPOSTO7
        /// Comentário: Preço de Tabela atacado 7 sem imposto
        /// </summary>
        private decimal ptabelaatacsemimposto7;
        [XmlElement(ElementName = "PTABELAATACSEMIMPOSTO7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatacsemimposto7
        {
            get { return  ptabelaatacsemimposto7; }
            set {  ptabelaatacsemimposto7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATAC1
        /// Comentário: 
        /// </summary>
        private decimal ptabelaatac1;
        [XmlElement(ElementName = "PTABELAATAC1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatac1
        {
            get { return  ptabelaatac1; }
            set {  ptabelaatac1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATAC2
        /// Comentário: 
        /// </summary>
        private decimal ptabelaatac2;
        [XmlElement(ElementName = "PTABELAATAC2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatac2
        {
            get { return  ptabelaatac2; }
            set {  ptabelaatac2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATAC3
        /// Comentário: 
        /// </summary>
        private decimal ptabelaatac3;
        [XmlElement(ElementName = "PTABELAATAC3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatac3
        {
            get { return  ptabelaatac3; }
            set {  ptabelaatac3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATAC4
        /// Comentário: 
        /// </summary>
        private decimal ptabelaatac4;
        [XmlElement(ElementName = "PTABELAATAC4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatac4
        {
            get { return  ptabelaatac4; }
            set {  ptabelaatac4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATAC5
        /// Comentário: 
        /// </summary>
        private decimal ptabelaatac5;
        [XmlElement(ElementName = "PTABELAATAC5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatac5
        {
            get { return  ptabelaatac5; }
            set {  ptabelaatac5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATAC6
        /// Comentário: 
        /// </summary>
        private decimal ptabelaatac6;
        [XmlElement(ElementName = "PTABELAATAC6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatac6
        {
            get { return  ptabelaatac6; }
            set {  ptabelaatac6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATAC7
        /// Comentário: 
        /// </summary>
        private decimal ptabelaatac7;
        [XmlElement(ElementName = "PTABELAATAC7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatac7
        {
            get { return  ptabelaatac7; }
            set {  ptabelaatac7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAFUTURO
        /// Comentário: 
        /// </summary>
        private decimal ptabelafuturo;
        [XmlElement(ElementName = "PTABELAFUTURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabelafuturo
        {
            get { return  ptabelafuturo; }
            set {  ptabelafuturo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAMED
        /// Comentário: 
        /// </summary>
        private decimal ptabelamed;
        [XmlElement(ElementName = "PTABELAMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabelamed
        {
            get { return  ptabelamed; }
            set {  ptabelamed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAMED1
        /// Comentário: 
        /// </summary>
        private decimal ptabelamed1;
        [XmlElement(ElementName = "PTABELAMED1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabelamed1
        {
            get { return  ptabelamed1; }
            set {  ptabelamed1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAMED2
        /// Comentário: 
        /// </summary>
        private decimal ptabelamed2;
        [XmlElement(ElementName = "PTABELAMED2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabelamed2
        {
            get { return  ptabelamed2; }
            set {  ptabelamed2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAMED3
        /// Comentário: 
        /// </summary>
        private decimal ptabelamed3;
        [XmlElement(ElementName = "PTABELAMED3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabelamed3
        {
            get { return  ptabelamed3; }
            set {  ptabelamed3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAMED4
        /// Comentário: 
        /// </summary>
        private decimal ptabelamed4;
        [XmlElement(ElementName = "PTABELAMED4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabelamed4
        {
            get { return  ptabelamed4; }
            set {  ptabelamed4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAMED5
        /// Comentário: 
        /// </summary>
        private decimal ptabelamed5;
        [XmlElement(ElementName = "PTABELAMED5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabelamed5
        {
            get { return  ptabelamed5; }
            set {  ptabelamed5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAMED6
        /// Comentário: 
        /// </summary>
        private decimal ptabelamed6;
        [XmlElement(ElementName = "PTABELAMED6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabelamed6
        {
            get { return  ptabelamed6; }
            set {  ptabelamed6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAMED7
        /// Comentário: 
        /// </summary>
        private decimal ptabelamed7;
        [XmlElement(ElementName = "PTABELAMED7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabelamed7
        {
            get { return  ptabelamed7; }
            set {  ptabelamed7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELASEMIMPOSTO1
        /// Comentário: Preço de Tabela 1 sem imposto
        /// </summary>
        private decimal ptabelasemimposto1;
        [XmlElement(ElementName = "PTABELASEMIMPOSTO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelasemimposto1
        {
            get { return  ptabelasemimposto1; }
            set {  ptabelasemimposto1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELASEMIMPOSTO2
        /// Comentário: Preço de Tabela 2 sem imposto
        /// </summary>
        private decimal ptabelasemimposto2;
        [XmlElement(ElementName = "PTABELASEMIMPOSTO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelasemimposto2
        {
            get { return  ptabelasemimposto2; }
            set {  ptabelasemimposto2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELASEMIMPOSTO3
        /// Comentário: Preço de Tabela 3 sem imposto
        /// </summary>
        private decimal ptabelasemimposto3;
        [XmlElement(ElementName = "PTABELASEMIMPOSTO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelasemimposto3
        {
            get { return  ptabelasemimposto3; }
            set {  ptabelasemimposto3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELASEMIMPOSTO4
        /// Comentário: Preço de Tabela 4 sem imposto
        /// </summary>
        private decimal ptabelasemimposto4;
        [XmlElement(ElementName = "PTABELASEMIMPOSTO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelasemimposto4
        {
            get { return  ptabelasemimposto4; }
            set {  ptabelasemimposto4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELASEMIMPOSTO5
        /// Comentário: Preço de Tabela 5 sem imposto
        /// </summary>
        private decimal ptabelasemimposto5;
        [XmlElement(ElementName = "PTABELASEMIMPOSTO5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelasemimposto5
        {
            get { return  ptabelasemimposto5; }
            set {  ptabelasemimposto5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELASEMIMPOSTO6
        /// Comentário: Preço de Tabela 6 sem imposto
        /// </summary>
        private decimal ptabelasemimposto6;
        [XmlElement(ElementName = "PTABELASEMIMPOSTO6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelasemimposto6
        {
            get { return  ptabelasemimposto6; }
            set {  ptabelasemimposto6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELASEMIMPOSTO7
        /// Comentário: Preço de Tabela 7 sem imposto
        /// </summary>
        private decimal ptabelasemimposto7;
        [XmlElement(ElementName = "PTABELASEMIMPOSTO7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelasemimposto7
        {
            get { return  ptabelasemimposto7; }
            set {  ptabelasemimposto7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA1
        /// Comentário: 
        /// </summary>
        private decimal ptabela1;
        [XmlElement(ElementName = "PTABELA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela1
        {
            get { return  ptabela1; }
            set {  ptabela1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA2
        /// Comentário: 
        /// </summary>
        private decimal ptabela2;
        [XmlElement(ElementName = "PTABELA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela2
        {
            get { return  ptabela2; }
            set {  ptabela2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA3
        /// Comentário: 
        /// </summary>
        private decimal ptabela3;
        [XmlElement(ElementName = "PTABELA3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela3
        {
            get { return  ptabela3; }
            set {  ptabela3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA4
        /// Comentário: 
        /// </summary>
        private decimal ptabela4;
        [XmlElement(ElementName = "PTABELA4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela4
        {
            get { return  ptabela4; }
            set {  ptabela4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA5
        /// Comentário: 
        /// </summary>
        private decimal ptabela5;
        [XmlElement(ElementName = "PTABELA5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela5
        {
            get { return  ptabela5; }
            set {  ptabela5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA6
        /// Comentário: 
        /// </summary>
        private decimal ptabela6;
        [XmlElement(ElementName = "PTABELA6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela6
        {
            get { return  ptabela6; }
            set {  ptabela6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA7
        /// Comentário: 
        /// </summary>
        private decimal ptabela7;
        [XmlElement(ElementName = "PTABELA7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela7
        {
            get { return  ptabela7; }
            set {  ptabela7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Comentário: 
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda
        {
            get { return  pvenda; }
            set {  pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATAC
        /// Comentário: 
        /// </summary>
        private decimal pvendaatac;
        [XmlElement(ElementName = "PVENDAATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatac
        {
            get { return  pvendaatac; }
            set {  pvendaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATACSEMIMPOSTO1
        /// Comentário: Preço de Venda atacado 1 sem imposto
        /// </summary>
        private decimal pvendaatacsemimposto1;
        [XmlElement(ElementName = "PVENDAATACSEMIMPOSTO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatacsemimposto1
        {
            get { return  pvendaatacsemimposto1; }
            set {  pvendaatacsemimposto1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATACSEMIMPOSTO2
        /// Comentário: Preço de Venda atacado 2 sem imposto
        /// </summary>
        private decimal pvendaatacsemimposto2;
        [XmlElement(ElementName = "PVENDAATACSEMIMPOSTO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatacsemimposto2
        {
            get { return  pvendaatacsemimposto2; }
            set {  pvendaatacsemimposto2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATACSEMIMPOSTO3
        /// Comentário: Preço de Venda atacado 3 sem imposto
        /// </summary>
        private decimal pvendaatacsemimposto3;
        [XmlElement(ElementName = "PVENDAATACSEMIMPOSTO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatacsemimposto3
        {
            get { return  pvendaatacsemimposto3; }
            set {  pvendaatacsemimposto3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATACSEMIMPOSTO4
        /// Comentário: Preço de Venda atacado 4 sem imposto
        /// </summary>
        private decimal pvendaatacsemimposto4;
        [XmlElement(ElementName = "PVENDAATACSEMIMPOSTO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatacsemimposto4
        {
            get { return  pvendaatacsemimposto4; }
            set {  pvendaatacsemimposto4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATACSEMIMPOSTO5
        /// Comentário: Preço de Venda atacado 5 sem imposto
        /// </summary>
        private decimal pvendaatacsemimposto5;
        [XmlElement(ElementName = "PVENDAATACSEMIMPOSTO5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatacsemimposto5
        {
            get { return  pvendaatacsemimposto5; }
            set {  pvendaatacsemimposto5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATACSEMIMPOSTO6
        /// Comentário: Preço de Venda atacado 6 sem imposto
        /// </summary>
        private decimal pvendaatacsemimposto6;
        [XmlElement(ElementName = "PVENDAATACSEMIMPOSTO6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatacsemimposto6
        {
            get { return  pvendaatacsemimposto6; }
            set {  pvendaatacsemimposto6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATACSEMIMPOSTO7
        /// Comentário: Preço de Venda atacado 7 sem imposto
        /// </summary>
        private decimal pvendaatacsemimposto7;
        [XmlElement(ElementName = "PVENDAATACSEMIMPOSTO7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatacsemimposto7
        {
            get { return  pvendaatacsemimposto7; }
            set {  pvendaatacsemimposto7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATAC1
        /// Comentário: 
        /// </summary>
        private decimal pvendaatac1;
        [XmlElement(ElementName = "PVENDAATAC1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatac1
        {
            get { return  pvendaatac1; }
            set {  pvendaatac1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATAC2
        /// Comentário: 
        /// </summary>
        private decimal pvendaatac2;
        [XmlElement(ElementName = "PVENDAATAC2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatac2
        {
            get { return  pvendaatac2; }
            set {  pvendaatac2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATAC3
        /// Comentário: 
        /// </summary>
        private decimal pvendaatac3;
        [XmlElement(ElementName = "PVENDAATAC3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatac3
        {
            get { return  pvendaatac3; }
            set {  pvendaatac3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATAC4
        /// Comentário: 
        /// </summary>
        private decimal pvendaatac4;
        [XmlElement(ElementName = "PVENDAATAC4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatac4
        {
            get { return  pvendaatac4; }
            set {  pvendaatac4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATAC5
        /// Comentário: 
        /// </summary>
        private decimal pvendaatac5;
        [XmlElement(ElementName = "PVENDAATAC5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatac5
        {
            get { return  pvendaatac5; }
            set {  pvendaatac5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATAC6
        /// Comentário: 
        /// </summary>
        private decimal pvendaatac6;
        [XmlElement(ElementName = "PVENDAATAC6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatac6
        {
            get { return  pvendaatac6; }
            set {  pvendaatac6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATAC7
        /// Comentário: 
        /// </summary>
        private decimal pvendaatac7;
        [XmlElement(ElementName = "PVENDAATAC7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaatac7
        {
            get { return  pvendaatac7; }
            set {  pvendaatac7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMED
        /// Comentário: 
        /// </summary>
        private decimal pvendamed;
        [XmlElement(ElementName = "PVENDAMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendamed
        {
            get { return  pvendamed; }
            set {  pvendamed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMED1
        /// Comentário: 
        /// </summary>
        private decimal pvendamed1;
        [XmlElement(ElementName = "PVENDAMED1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendamed1
        {
            get { return  pvendamed1; }
            set {  pvendamed1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMED2
        /// Comentário: 
        /// </summary>
        private decimal pvendamed2;
        [XmlElement(ElementName = "PVENDAMED2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendamed2
        {
            get { return  pvendamed2; }
            set {  pvendamed2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMED3
        /// Comentário: 
        /// </summary>
        private decimal pvendamed3;
        [XmlElement(ElementName = "PVENDAMED3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendamed3
        {
            get { return  pvendamed3; }
            set {  pvendamed3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMED4
        /// Comentário: 
        /// </summary>
        private decimal pvendamed4;
        [XmlElement(ElementName = "PVENDAMED4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendamed4
        {
            get { return  pvendamed4; }
            set {  pvendamed4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMED5
        /// Comentário: 
        /// </summary>
        private decimal pvendamed5;
        [XmlElement(ElementName = "PVENDAMED5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendamed5
        {
            get { return  pvendamed5; }
            set {  pvendamed5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMED6
        /// Comentário: 
        /// </summary>
        private decimal pvendamed6;
        [XmlElement(ElementName = "PVENDAMED6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendamed6
        {
            get { return  pvendamed6; }
            set {  pvendamed6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAMED7
        /// Comentário: 
        /// </summary>
        private decimal pvendamed7;
        [XmlElement(ElementName = "PVENDAMED7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendamed7
        {
            get { return  pvendamed7; }
            set {  pvendamed7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDASEMIMPOSTO1
        /// Comentário: Preço de Venda 1 sem imposto
        /// </summary>
        private decimal pvendasemimposto1;
        [XmlElement(ElementName = "PVENDASEMIMPOSTO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendasemimposto1
        {
            get { return  pvendasemimposto1; }
            set {  pvendasemimposto1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDASEMIMPOSTO2
        /// Comentário: Preço de Venda 2 sem imposto
        /// </summary>
        private decimal pvendasemimposto2;
        [XmlElement(ElementName = "PVENDASEMIMPOSTO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendasemimposto2
        {
            get { return  pvendasemimposto2; }
            set {  pvendasemimposto2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDASEMIMPOSTO3
        /// Comentário: Preço de Venda 3 sem imposto
        /// </summary>
        private decimal pvendasemimposto3;
        [XmlElement(ElementName = "PVENDASEMIMPOSTO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendasemimposto3
        {
            get { return  pvendasemimposto3; }
            set {  pvendasemimposto3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDASEMIMPOSTO4
        /// Comentário: Preço de Venda 4 sem imposto
        /// </summary>
        private decimal pvendasemimposto4;
        [XmlElement(ElementName = "PVENDASEMIMPOSTO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendasemimposto4
        {
            get { return  pvendasemimposto4; }
            set {  pvendasemimposto4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDASEMIMPOSTO5
        /// Comentário: Preço de Venda 5 sem imposto
        /// </summary>
        private decimal pvendasemimposto5;
        [XmlElement(ElementName = "PVENDASEMIMPOSTO5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendasemimposto5
        {
            get { return  pvendasemimposto5; }
            set {  pvendasemimposto5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDASEMIMPOSTO6
        /// Comentário: Preço de Venda 6 sem imposto
        /// </summary>
        private decimal pvendasemimposto6;
        [XmlElement(ElementName = "PVENDASEMIMPOSTO6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendasemimposto6
        {
            get { return  pvendasemimposto6; }
            set {  pvendasemimposto6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDASEMIMPOSTO7
        /// Comentário: Preço de Venda 7 sem imposto
        /// </summary>
        private decimal pvendasemimposto7;
        [XmlElement(ElementName = "PVENDASEMIMPOSTO7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendasemimposto7
        {
            get { return  pvendasemimposto7; }
            set {  pvendasemimposto7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA1
        /// Comentário: 
        /// </summary>
        private decimal pvenda1;
        [XmlElement(ElementName = "PVENDA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda1
        {
            get { return  pvenda1; }
            set {  pvenda1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA2
        /// Comentário: 
        /// </summary>
        private decimal pvenda2;
        [XmlElement(ElementName = "PVENDA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda2
        {
            get { return  pvenda2; }
            set {  pvenda2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA3
        /// Comentário: 
        /// </summary>
        private decimal pvenda3;
        [XmlElement(ElementName = "PVENDA3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda3
        {
            get { return  pvenda3; }
            set {  pvenda3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA4
        /// Comentário: 
        /// </summary>
        private decimal pvenda4;
        [XmlElement(ElementName = "PVENDA4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda4
        {
            get { return  pvenda4; }
            set {  pvenda4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA5
        /// Comentário: 
        /// </summary>
        private decimal pvenda5;
        [XmlElement(ElementName = "PVENDA5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda5
        {
            get { return  pvenda5; }
            set {  pvenda5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA6
        /// Comentário: 
        /// </summary>
        private decimal pvenda6;
        [XmlElement(ElementName = "PVENDA6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda6
        {
            get { return  pvenda6; }
            set {  pvenda6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA7
        /// Comentário: 
        /// </summary>
        private decimal pvenda7;
        [XmlElement(ElementName = "PVENDA7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda7
        {
            get { return  pvenda7; }
            set {  pvenda7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESCAUTOR
        /// Comentário: 
        /// </summary>
        private decimal qtdescautor;
        [XmlElement(ElementName = "QTDESCAUTOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtdescautor
        {
            get { return  qtdescautor; }
            set {  qtdescautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESCAUTORTAB
        /// Comentário: 
        /// </summary>
        private decimal qtdescautortab;
        [XmlElement(ElementName = "QTDESCAUTORTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtdescautortab
        {
            get { return  qtdescautortab; }
            set {  qtdescautortab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINA
        /// Comentário: Rotina que fez a alteração
        /// </summary>
        private string rotina;
        [XmlElement(ElementName = "ROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Rotina
        {
            get { return  rotina; }
            set {  rotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TABELAEMITIDA
        /// Comentário: 
        /// </summary>
        private string tabelaemitida;
        [XmlElement(ElementName = "TABELAEMITIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tabelaemitida
        {
            get { return  tabelaemitida; }
            set {  tabelaemitida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZARIOLOG
        /// Comentário: Define de foi utilizado o metodo rio log para calculo do ST
        /// </summary>
        private string utilizariolog;
        [XmlElement(ElementName = "UTILIZARIOLOG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizariolog
        {
            get { return  utilizariolog; }
            set {  utilizariolog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLACRESFRETEKG
        /// Comentário: Contém o valor do frete por kilo. 
        /// </summary>
        private decimal vlacresfretekg;
        [XmlElement(ElementName = "VLACRESFRETEKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlacresfretekg
        {
            get { return  vlacresfretekg; }
            set {  vlacresfretekg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Comentário: Valor de IPI atual.
        /// </summary>
        private decimal vlipi;
        [XmlElement(ElementName = "VLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipi
        {
            get { return  vlipi; }
            set {  vlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIPORKGVENDATAB
        /// Comentário: Indica o valor do IPI/KG venda futuro.
        /// </summary>
        private decimal vlipiporkgvendatab;
        [XmlElement(ElementName = "VLIPIPORKGVENDATAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipiporkgvendatab
        {
            get { return  vlipiporkgvendatab; }
            set {  vlipiporkgvendatab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPITAB
        /// Comentário: Valor de IPI futuro.
        /// </summary>
        private decimal vlipitab;
        [XmlElement(ElementName = "VLIPITAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipitab
        {
            get { return  vlipitab; }
            set {  vlipitab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAIPIVENDATAB
        /// Comentário: Indica o valor do IPI venda futuro
        /// </summary>
        private decimal vlpautaipivendatab;
        [XmlElement(ElementName = "VLPAUTAIPIVENDATAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautaipivendatab
        {
            get { return  vlpautaipivendatab; }
            set {  vlpautaipivendatab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLST
        /// Comentário: Valor da Situação Tributária Atual.
        /// </summary>
        private decimal vlst;
        [XmlElement(ElementName = "VLST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlst
        {
            get { return  vlst; }
            set {  vlst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTTAB
        /// Comentário: Valor da Situação Tributária Futuro.
        /// </summary>
        private decimal vlsttab;
        [XmlElement(ElementName = "VLSTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlsttab
        {
            get { return  vlsttab; }
            set {  vlsttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLULTENTMES
        /// Comentário: Média do valor da última entrada
        /// </summary>
        private decimal vlultentmes;
        [XmlElement(ElementName = "VLULTENTMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlultentmes
        {
            get { return  vlultentmes; }
            set {  vlultentmes = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTabpr()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTABPR";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTabpr> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTabpr>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTabpr> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTabpr>(where);
        }

        #endregion
    }
}
