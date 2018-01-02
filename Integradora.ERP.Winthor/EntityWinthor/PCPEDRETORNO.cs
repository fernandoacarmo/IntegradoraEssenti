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
    /// Classe referente a tabela PCPedretorno
    /// </summary>
    [XmlType("PCPEDRETORNO")]
    public class PCPedretorno : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APONTADORCONDICAO
        /// Comentário: Apontador da Condição de Venda
        /// </summary>
        private string apontadorcondicao;
        [XmlElement(ElementName = "APONTADORCONDICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Apontadorcondicao
        {
            get { return  apontadorcondicao; }
            set {  apontadorcondicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ARQUIVODEV
        /// Comentário: Nome do Arquivo de Devolução
        /// </summary>
        private string arquivodev;
        [XmlElement(ElementName = "ARQUIVODEV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Arquivodev
        {
            get { return  arquivodev; }
            set {  arquivodev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ARQUIVONOT
        /// Comentário: Nome do Arquivo de Espelho da NF
        /// </summary>
        private string arquivonot;
        [XmlElement(ElementName = "ARQUIVONOT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Arquivonot
        {
            get { return  arquivonot; }
            set {  arquivonot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ARQUIVOPED
        /// Comentário: Nome do Arquivo de Pedidos recebido
        /// </summary>
        private string arquivoped;
        [XmlElement(ElementName = "ARQUIVOPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Arquivoped
        {
            get { return  arquivoped; }
            set {  arquivoped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ARQUIVORET
        /// Comentário: Nome do Arquivo de Retorno
        /// </summary>
        private string arquivoret;
        [XmlElement(ElementName = "ARQUIVORET", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Arquivoret
        {
            get { return  arquivoret; }
            set {  arquivoret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCCLI
        /// Comentário: CGC Cliente
        /// </summary>
        private string cgccli;
        [XmlElement(ElementName = "CGCCLI", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,18)]
        public string Cgccli
        {
            get { return  cgccli; }
            set {  cgccli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Código do Cliente
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
        /// Propriedade referente ao campo: CODCONDICAOVENDA
        /// Comentário: Código da Condição de Venda
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
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da Filial de Faturamento
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOPROJETO
        /// Comentário: Código do Projeto OL
        /// </summary>
        private string codigoprojeto;
        [XmlElement(ElementName = "CODIGOPROJETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Codigoprojeto
        {
            get { return  codigoprojeto; }
            set {  codigoprojeto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODINTERNO
        /// Comentário: Código Interno OL
        /// </summary>
        private string codinterno;
        [XmlElement(ElementName = "CODINTERNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codinterno
        {
            get { return  codinterno; }
            set {  codinterno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRAZO
        /// Comentário: Código Prazo
        /// </summary>
        private string codprazo;
        [XmlElement(ElementName = "CODPRAZO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codprazo
        {
            get { return  codprazo; }
            set {  codprazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: Código do Usuário
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTURAPEDPALM
        /// Comentário: Data da Abertura do Pedido do Palm
        /// </summary>
        private DateTime? dtaberturapedpalm;
        [XmlElement(ElementName = "DTABERTURAPEDPALM", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtaberturapedpalm
        {
            get { return  dtaberturapedpalm; }
            set {  dtaberturapedpalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTGERDEV
        /// Comentário: Data de Geração do Arquivo de Devolução
        /// </summary>
        private DateTime? dtgerdev;
        [XmlElement(ElementName = "DTGERDEV", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtgerdev
        {
            get { return  dtgerdev; }
            set {  dtgerdev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTGERNOT
        /// Comentário: Data de geração do Espelho da NF
        /// </summary>
        private DateTime? dtgernot;
        [XmlElement(ElementName = "DTGERNOT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtgernot
        {
            get { return  dtgernot; }
            set {  dtgernot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTGERRET
        /// Comentário: Data de geração do Retorno
        /// </summary>
        private DateTime? dtgerret;
        [XmlElement(ElementName = "DTGERRET", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtgerret
        {
            get { return  dtgerret; }
            set {  dtgerret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAO
        /// Comentário: Data da Importação do Arquivo
        /// </summary>
        private DateTime? dtimportacao;
        [XmlElement(ElementName = "DTIMPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacao
        {
            get { return  dtimportacao; }
            set {  dtimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSAIDA
        /// Comentário: Data Saída da Nota Fiscal
        /// </summary>
        private DateTime? dtsaida;
        [XmlElement(ElementName = "DTSAIDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtsaida
        {
            get { return  dtsaida; }
            set {  dtsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GEROUDEV
        /// Comentário: Gerou Arquivo de Devolução [S-Sim; N-Não]
        /// </summary>
        private string geroudev;
        [XmlElement(ElementName = "GEROUDEV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geroudev
        {
            get { return  geroudev; }
            set {  geroudev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GEROUNOT
        /// Comentário: Identificador de geração do Espelho da NF
        /// </summary>
        private string gerounot;
        [XmlElement(ElementName = "GEROUNOT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerounot
        {
            get { return  gerounot; }
            set {  gerounot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GEROURET
        /// Comentário: Identificador de geração do Retorno
        /// </summary>
        private string gerouret;
        [XmlElement(ElementName = "GEROURET", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerouret
        {
            get { return  gerouret; }
            set {  gerouret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INTEGRADORA
        /// Comentário: Código da Integradora
        /// </summary>
        private decimal integradora;
        [XmlElement(ElementName = "INTEGRADORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Integradora
        {
            get { return  integradora; }
            set {  integradora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: Número da Nota Fiscal
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: Número do Pedido
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDCLI
        /// Comentário: Número do Pedido do Cliente
        /// </summary>
        private string numpedcli;
        [XmlElement(ElementName = "NUMPEDCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Numpedcli
        {
            get { return  numpedcli; }
            set {  numpedcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDRCA
        /// Comentário: Número do Pedido do RCA
        /// </summary>
        private decimal numpedrca;
        [XmlElement(ElementName = "NUMPEDRCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedrca
        {
            get { return  numpedrca; }
            set {  numpedrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDVAN
        /// Comentário: Número do Pedido da VAN
        /// </summary>
        private string numpedvan;
        [XmlElement(ElementName = "NUMPEDVAN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numpedvan
        {
            get { return  numpedvan; }
            set {  numpedvan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMQUEBRA
        /// Comentário: Número da Quebra
        /// </summary>
        private decimal numquebra;
        [XmlElement(ElementName = "NUMQUEBRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numquebra
        {
            get { return  numquebra; }
            set {  numquebra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: Número da Transação de Venda
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMPED
        /// Comentário: Origem do Pedido
        /// </summary>
        private string origemped;
        [XmlElement(ElementName = "ORIGEMPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemped
        {
            get { return  origemped; }
            set {  origemped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO
        /// Comentário: Quantidade de Dias de Prazo
        /// </summary>
        private decimal prazo;
        [XmlElement(ElementName = "PRAZO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Prazo
        {
            get { return  prazo; }
            set {  prazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: Série da Nota Fiscal
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFV
        /// Comentário: Tipo de Força de Vendas (FV - Palm; OL - Operador Logístico; PE - Pedido Eletrônico)
        /// </summary>
        private string tipofv;
        [XmlElement(ElementName = "TIPOFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipofv
        {
            get { return  tipofv; }
            set {  tipofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMSGRET
        /// Comentário: Tipo de Mensagem do Motivo de Não Atendimento no Retorno (Código ou Descrição)
        /// </summary>
        private string tipomsgret;
        [XmlElement(ElementName = "TIPOMSGRET", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipomsgret
        {
            get { return  tipomsgret; }
            set {  tipomsgret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPRAZO
        /// Comentário: Tipo de Prazo do Pedido (V - À Vista; P - A Prazo; D - Prazo Determinado)
        /// </summary>
        private string tipoprazo;
        [XmlElement(ElementName = "TIPOPRAZO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoprazo
        {
            get { return  tipoprazo; }
            set {  tipoprazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALIDADESCEDIMAIOR
        /// Comentário: Tipo de Validação do Desconto EDI a Maior (S - Sem Validação;   C - Conceder Desc. Condição; E - Conceder Desc. EDI; R - Rejeitar Item)
        /// </summary>
        private string tipovalidadescedimaior;
        [XmlElement(ElementName = "TIPOVALIDADESCEDIMAIOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalidadescedimaior
        {
            get { return  tipovalidadescedimaior; }
            set {  tipovalidadescedimaior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALIDADESCEDIMENOR
        /// Comentário: Tipo de Validação do Desconto EDI a Menor (S - Sem Validação;   C - Conceder Desc. Condição; E - Conceder Desc. EDI; R - Rejeitar Item)
        /// </summary>
        private string tipovalidadescedimenor;
        [XmlElement(ElementName = "TIPOVALIDADESCEDIMENOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalidadescedimenor
        {
            get { return  tipovalidadescedimenor; }
            set {  tipovalidadescedimenor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALIDAPRECOEDIMAIOR
        /// Comentário: Tipo de Validação doPreço EDI a Maior (S - Sem Validação;   C - Conceder Desc. Condição; E - Conceder Desc. EDI; R - Rejeitar Item)
        /// </summary>
        private string tipovalidaprecoedimaior;
        [XmlElement(ElementName = "TIPOVALIDAPRECOEDIMAIOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalidaprecoedimaior
        {
            get { return  tipovalidaprecoedimaior; }
            set {  tipovalidaprecoedimaior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALIDAPRECOEDIMENOR
        /// Comentário: Tipo de Validação do Preço EDI a Menor (S - Sem Validação;   C - Conceder Desc. Condição; E - Conceder Desc. EDI; R - Rejeitar Item)
        /// </summary>
        private string tipovalidaprecoedimenor;
        [XmlElement(ElementName = "TIPOVALIDAPRECOEDIMENOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalidaprecoedimenor
        {
            get { return  tipovalidaprecoedimenor; }
            set {  tipovalidaprecoedimenor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TPOPEREDI
        /// Comentário: Tipo Operação EDI
        /// </summary>
        private string tpoperedi;
        [XmlElement(ElementName = "TPOPEREDI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tpoperedi
        {
            get { return  tpoperedi; }
            set {  tpoperedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TPVENEDI
        /// Comentário: Tipo Venda EDI
        /// </summary>
        private string tpvenedi;
        [XmlElement(ElementName = "TPVENEDI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tpvenedi
        {
            get { return  tpvenedi; }
            set {  tpvenedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAO
        /// Comentário: Versão
        /// </summary>
        private string versao;
        [XmlElement(ElementName = "VERSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Versao
        {
            get { return  versao; }
            set {  versao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLLIMITECREDCLI
        /// Comentário: Valor do Limite de Crédito
        /// </summary>
        private decimal vllimitecredcli;
        [XmlElement(ElementName = "VLLIMITECREDCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vllimitecredcli
        {
            get { return  vllimitecredcli; }
            set {  vllimitecredcli = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPedretorno()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDRETORNO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPedretorno> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedretorno>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPedretorno> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPedretorno>(where);
        }

        #endregion
    }
}
