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
    /// Classe referente a tabela PCRotaexp
    /// </summary>
    [XmlType("PCROTAEXP")]
    public class PCRotaexp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMSFRETE
        /// Comentário: 
        /// </summary>
        private decimal aliqicmsfrete;
        [XmlElement(ElementName = "ALIQICMSFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicmsfrete
        {
            get { return  aliqicmsfrete; }
            set {  aliqicmsfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODESTEIRA
        /// Comentário: Relação com código tabela pcesteirawms
        /// </summary>
        private decimal codesteira;
        [XmlElement(ElementName = "CODESTEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codesteira
        {
            get { return  codesteira; }
            set {  codesteira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTA
        /// Comentário: 
        /// </summary>
        private decimal codrota;
        [XmlElement(ElementName = "CODROTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codrota
        {
            get { return  codrota; }
            set {  codrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTAPRINCIPAL
        /// Comentário: Indica o código da rotina principal.
        /// </summary>
        private decimal codrotaprincipal;
        [XmlElement(ElementName = "CODROTAPRINCIPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrotaprincipal
        {
            get { return  codrotaprincipal; }
            set {  codrotaprincipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIADOM
        /// Comentário: 
        /// </summary>
        private string diadom;
        [XmlElement(ElementName = "DIADOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diadom
        {
            get { return  diadom; }
            set {  diadom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAQUA
        /// Comentário: 
        /// </summary>
        private string diaqua;
        [XmlElement(ElementName = "DIAQUA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diaqua
        {
            get { return  diaqua; }
            set {  diaqua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAQUI
        /// Comentário: 
        /// </summary>
        private string diaqui;
        [XmlElement(ElementName = "DIAQUI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diaqui
        {
            get { return  diaqui; }
            set {  diaqui = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASAB
        /// Comentário: 
        /// </summary>
        private string diasab;
        [XmlElement(ElementName = "DIASAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diasab
        {
            get { return  diasab; }
            set {  diasab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEG
        /// Comentário: 
        /// </summary>
        private string diaseg;
        [XmlElement(ElementName = "DIASEG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diaseg
        {
            get { return  diaseg; }
            set {  diaseg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASENTREGA
        /// Comentário: Dias de entrega
        /// </summary>
        private decimal diasentrega;
        [XmlElement(ElementName = "DIASENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Diasentrega
        {
            get { return  diasentrega; }
            set {  diasentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEX
        /// Comentário: 
        /// </summary>
        private string diasex;
        [XmlElement(ElementName = "DIASEX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diasex
        {
            get { return  diasex; }
            set {  diasex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIATER
        /// Comentário: 
        /// </summary>
        private string diater;
        [XmlElement(ElementName = "DIATER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diater
        {
            get { return  diater; }
            set {  diater = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSITUACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtsituacao;
        [XmlElement(ElementName = "DTSITUACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtsituacao
        {
            get { return  dtsituacao; }
            set {  dtsituacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: KMEXCLUIDO
        /// Comentário: 
        /// </summary>
        private decimal kmexcluido;
        [XmlElement(ElementName = "KMEXCLUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Kmexcluido
        {
            get { return  kmexcluido; }
            set {  kmexcluido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: KMROTA
        /// Comentário: 
        /// </summary>
        private decimal kmrota;
        [XmlElement(ElementName = "KMROTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Kmrota
        {
            get { return  kmrota; }
            set {  kmrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIARIA
        /// Comentário: 
        /// </summary>
        private decimal numdiaria;
        [XmlElement(ElementName = "NUMDIARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiaria
        {
            get { return  numdiaria; }
            set {  numdiaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAJUDA
        /// Comentário: Percentual de ajuda de custo.
        /// </summary>
        private decimal percajuda;
        [XmlElement(ElementName = "PERCAJUDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percajuda
        {
            get { return  percajuda; }
            set {  percajuda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDIARIA
        /// Comentário: Indica o percentual comissão diária.
        /// </summary>
        private decimal percdiaria;
        [XmlElement(ElementName = "PERCDIARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percdiaria
        {
            get { return  percdiaria; }
            set {  percdiaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMINCARREG
        /// Comentário: Variação do valor minimo de carga
        /// </summary>
        private decimal percmincarreg;
        [XmlElement(ElementName = "PERCMINCARREG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percmincarreg
        {
            get { return  percmincarreg; }
            set {  percmincarreg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMOT
        /// Comentário: 
        /// </summary>
        private decimal percommot;
        [XmlElement(ElementName = "PERCOMMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percommot
        {
            get { return  percommot; }
            set {  percommot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMOT2
        /// Comentário: 
        /// </summary>
        private decimal percommot2;
        [XmlElement(ElementName = "PERCOMMOT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percommot2
        {
            get { return  percommot2; }
            set {  percommot2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMOT3
        /// Comentário: 
        /// </summary>
        private decimal percommot3;
        [XmlElement(ElementName = "PERCOMMOT3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percommot3
        {
            get { return  percommot3; }
            set {  percommot3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETEVALOR
        /// Comentário: 
        /// </summary>
        private decimal perfretevalor;
        [XmlElement(ElementName = "PERFRETEVALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perfretevalor
        {
            get { return  perfretevalor; }
            set {  perfretevalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOPREVENT
        /// Comentário: 
        /// </summary>
        private decimal prazoprevent;
        [XmlElement(ElementName = "PRAZOPREVENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoprevent
        {
            get { return  prazoprevent; }
            set {  prazoprevent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFESCANTV14
        /// Comentário: Próximo número de NF-e
        /// </summary>
        private decimal proxnumnfescantv14;
        [XmlElement(ElementName = "PROXNUMNFESCANTV14", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnfescantv14
        {
            get { return  proxnumnfescantv14; }
            set {  proxnumnfescantv14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFETV14
        /// Comentário: Próximo número de NF-e
        /// </summary>
        private decimal proxnumnfetv14;
        [XmlElement(ElementName = "PROXNUMNFETV14", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnfetv14
        {
            get { return  proxnumnfetv14; }
            set {  proxnumnfetv14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTREGA
        /// Comentário: 
        /// </summary>
        private decimal qtentrega;
        [XmlElement(ElementName = "QTENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtentrega
        {
            get { return  qtentrega; }
            set {  qtentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RASTREADA
        /// Comentário: Indica se a rota possui rastreamento, caso a carga possua pelo menos uma rota rastreada, será exibida mensagem de alerta caso o veículo selecionado não seja rastreado. 
        /// </summary>
        private string rastreada;
        [XmlElement(ElementName = "RASTREADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Rastreada
        {
            get { return  rastreada; }
            set {  rastreada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQENTREGA
        /// Comentário: 
        /// </summary>
        private decimal seqentrega;
        [XmlElement(ElementName = "SEQENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Seqentrega
        {
            get { return  seqentrega; }
            set {  seqentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFESCANTV14
        /// Comentário: Série NFe
        /// </summary>
        private decimal serienfescantv14;
        [XmlElement(ElementName = "SERIENFESCANTV14", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Serienfescantv14
        {
            get { return  serienfescantv14; }
            set {  serienfescantv14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFETV14
        /// Comentário: Série NFe
        /// </summary>
        private decimal serienfetv14;
        [XmlElement(ElementName = "SERIENFETV14", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Serienfetv14
        {
            get { return  serienfetv14; }
            set {  serienfetv14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: 
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCOMISSAO
        /// Comentário: 
        /// </summary>
        private string tipocomissao;
        [XmlElement(ElementName = "TIPOCOMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocomissao
        {
            get { return  tipocomissao; }
            set {  tipocomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODIARIA
        /// Comentário: Indica o tipo de comissão diária (P)percentual (V)valor.
        /// </summary>
        private string tipodiaria;
        [XmlElement(ElementName = "TIPODIARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodiaria
        {
            get { return  tipodiaria; }
            set {  tipodiaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAVLDESCARGAFIXO
        /// Comentário: Define se utiliza valor fixo da descarga.
        /// </summary>
        private string utilizavldescargafixo;
        [XmlElement(ElementName = "UTILIZAVLDESCARGAFIXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizavldescargafixo
        {
            get { return  utilizavldescargafixo; }
            set {  utilizavldescargafixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCOMMOT
        /// Comentário: 
        /// </summary>
        private decimal valorcommot;
        [XmlElement(ElementName = "VALORCOMMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valorcommot
        {
            get { return  valorcommot; }
            set {  valorcommot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLAJUDA
        /// Comentário: Campo referente ao valor de ajuda de custo com motorista.
        /// </summary>
        private decimal vlajuda;
        [XmlElement(ElementName = "VLAJUDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Vlajuda
        {
            get { return  vlajuda; }
            set {  vlajuda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMVEICLEVE
        /// Comentário: 
        /// </summary>
        private decimal vlcomveicleve;
        [XmlElement(ElementName = "VLCOMVEICLEVE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlcomveicleve
        {
            get { return  vlcomveicleve; }
            set {  vlcomveicleve = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMVEICMEDIO
        /// Comentário: 
        /// </summary>
        private decimal vlcomveicmedio;
        [XmlElement(ElementName = "VLCOMVEICMEDIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlcomveicmedio
        {
            get { return  vlcomveicmedio; }
            set {  vlcomveicmedio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMVEICPESADO
        /// Comentário: 
        /// </summary>
        private decimal vlcomveicpesado;
        [XmlElement(ElementName = "VLCOMVEICPESADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlcomveicpesado
        {
            get { return  vlcomveicpesado; }
            set {  vlcomveicpesado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCARGAFIXO
        /// Comentário: Define so valor fixo para descarga.
        /// </summary>
        private decimal vldescargafixo;
        [XmlElement(ElementName = "VLDESCARGAFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescargafixo
        {
            get { return  vldescargafixo; }
            set {  vldescargafixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIARIA
        /// Comentário: 
        /// </summary>
        private decimal vldiaria;
        [XmlElement(ElementName = "VLDIARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vldiaria
        {
            get { return  vldiaria; }
            set {  vldiaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETEENTREGA
        /// Comentário: 
        /// </summary>
        private decimal vlfreteentrega;
        [XmlElement(ElementName = "VLFRETEENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlfreteentrega
        {
            get { return  vlfreteentrega; }
            set {  vlfreteentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETETON
        /// Comentário: 
        /// </summary>
        private decimal vlfreteton;
        [XmlElement(ElementName = "VLFRETETON", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlfreteton
        {
            get { return  vlfreteton; }
            set {  vlfreteton = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKMADICIONAL
        /// Comentário: 
        /// </summary>
        private decimal vlkmadicional;
        [XmlElement(ElementName = "VLKMADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlkmadicional
        {
            get { return  vlkmadicional; }
            set {  vlkmadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINCARREG
        /// Comentário: 
        /// </summary>
        private decimal vlmincarreg;
        [XmlElement(ElementName = "VLMINCARREG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlmincarreg
        {
            get { return  vlmincarreg; }
            set {  vlmincarreg = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRotaexp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCROTAEXP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRotaexp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRotaexp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRotaexp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRotaexp>(where);
        }

        #endregion
    }
}
