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
    /// Classe referente a tabela PCInventrot
    /// </summary>
    [XmlType("PCINVENTROT")]
    public class PCInventrot : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AVARIAATUALIZADA
        /// Comentário: Avarias atualizadas.
        /// </summary>
        private string avariaatualizada;
        [XmlElement(ElementName = "AVARIAATUALIZADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Avariaatualizada
        {
            get { return  avariaatualizada; }
            set {  avariaatualizada = value; }
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
        /// Propriedade referente ao campo: CODFUNCATUALIZACAO
        /// Comentário: Código do funcionario da atualização.
        /// </summary>
        private decimal codfuncatualizacao;
        [XmlElement(ElementName = "CODFUNCATUALIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncatualizacao
        {
            get { return  codfuncatualizacao; }
            set {  codfuncatualizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCANCEL
        /// Comentário: Usuário cancelamento
        /// </summary>
        private decimal codfunccancel;
        [XmlElement(ElementName = "CODFUNCCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccancel
        {
            get { return  codfunccancel; }
            set {  codfunccancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONT1
        /// Comentário: Código do primeiro funcionário da contagem
        /// </summary>
        private decimal codfunccont1;
        [XmlElement(ElementName = "CODFUNCCONT1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccont1
        {
            get { return  codfunccont1; }
            set {  codfunccont1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONT2
        /// Comentário: Código do segundo funcionário da contagem
        /// </summary>
        private decimal codfunccont2;
        [XmlElement(ElementName = "CODFUNCCONT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccont2
        {
            get { return  codfunccont2; }
            set {  codfunccont2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONT3
        /// Comentário: Código do terceiro funcionário da contagem
        /// </summary>
        private decimal codfunccont3;
        [XmlElement(ElementName = "CODFUNCCONT3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccont3
        {
            get { return  codfunccont3; }
            set {  codfunccont3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFEC1
        /// Comentário: Código do funcionário.
        /// </summary>
        private decimal codfuncfec1;
        [XmlElement(ElementName = "CODFUNCFEC1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfec1
        {
            get { return  codfuncfec1; }
            set {  codfuncfec1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFEC2
        /// Comentário: Código do funcionário.
        /// </summary>
        private decimal codfuncfec2;
        [XmlElement(ElementName = "CODFUNCFEC2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfec2
        {
            get { return  codfuncfec2; }
            set {  codfuncfec2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFEC3
        /// Comentário: Código do funcionário.
        /// </summary>
        private decimal codfuncfec3;
        [XmlElement(ElementName = "CODFUNCFEC3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfec3
        {
            get { return  codfuncfec3; }
            set {  codfuncfec3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCMONTAGEM
        /// Comentário: Indica o código do funcionário montador do bônus.
        /// </summary>
        private decimal codfuncmontagem;
        [XmlElement(ElementName = "CODFUNCMONTAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncmontagem
        {
            get { return  codfuncmontagem; }
            set {  codfuncmontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLOCAL
        /// Comentário: Código do local.
        /// </summary>
        private string codlocal;
        [XmlElement(ElementName = "CODLOCAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Codlocal
        {
            get { return  codlocal; }
            set {  codlocal = value; }
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
        /// Propriedade referente ao campo: CUSTO
        /// Comentário: Custo do produto.
        /// </summary>
        private decimal custo;
        [XmlElement(ElementName = "CUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custo
        {
            get { return  custo; }
            set {  custo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACONT1
        /// Comentário: 
        /// </summary>
        private DateTime? datacont1;
        [XmlElement(ElementName = "DATACONT1", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacont1
        {
            get { return  datacont1; }
            set {  datacont1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACONT2
        /// Comentário: 
        /// </summary>
        private DateTime? datacont2;
        [XmlElement(ElementName = "DATACONT2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacont2
        {
            get { return  datacont2; }
            set {  datacont2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACONT3
        /// Comentário: 
        /// </summary>
        private DateTime? datacont3;
        [XmlElement(ElementName = "DATACONT3", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacont3
        {
            get { return  datacont3; }
            set {  datacont3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFECCONT1
        /// Comentário: Data de conferência.
        /// </summary>
        private DateTime? datafeccont1;
        [XmlElement(ElementName = "DATAFECCONT1", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafeccont1
        {
            get { return  datafeccont1; }
            set {  datafeccont1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFECCONT2
        /// Comentário: Data de conferência.
        /// </summary>
        private DateTime? datafeccont2;
        [XmlElement(ElementName = "DATAFECCONT2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafeccont2
        {
            get { return  datafeccont2; }
            set {  datafeccont2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFECCONT3
        /// Comentário: Data de conferência.
        /// </summary>
        private DateTime? datafeccont3;
        [XmlElement(ElementName = "DATAFECCONT3", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafeccont3
        {
            get { return  datafeccont3; }
            set {  datafeccont3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTATUALIZACAO
        /// Comentário: Data da atualização.
        /// </summary>
        private DateTime? dtatualizacao;
        [XmlElement(ElementName = "DTATUALIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtatualizacao
        {
            get { return  dtatualizacao; }
            set {  dtatualizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTATUALIZACAONUMSERIE
        /// Comentário: Data de atualização inventario num. Serie.
        /// </summary>
        private DateTime? dtatualizacaonumserie;
        [XmlElement(ElementName = "DTATUALIZACAONUMSERIE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtatualizacaonumserie
        {
            get { return  dtatualizacaonumserie; }
            set {  dtatualizacaonumserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCALCGIRO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcalcgiro;
        [XmlElement(ElementName = "DTCALCGIRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcalcgiro
        {
            get { return  dtcalcgiro; }
            set {  dtcalcgiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: Data de cancelamento
        /// </summary>
        private DateTime? dtcancel;
        [XmlElement(ElementName = "DTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancel
        {
            get { return  dtcancel; }
            set {  dtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INVENTARIASOMENTEAVARIA
        /// Comentário: Inventaria somente avaria
        /// </summary>
        private string inventariasomenteavaria;
        [XmlElement(ElementName = "INVENTARIASOMENTEAVARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Inventariasomenteavaria
        {
            get { return  inventariasomenteavaria; }
            set {  inventariasomenteavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INVENTAVARIA
        /// Comentário: Inventariar avarias.
        /// </summary>
        private string inventavaria;
        [XmlElement(ElementName = "INVENTAVARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Inventavaria
        {
            get { return  inventavaria; }
            set {  inventavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMINVENT
        /// Comentário: 
        /// </summary>
        private decimal numinvent;
        [XmlElement(ElementName = "NUMINVENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numinvent
        {
            get { return  numinvent; }
            set {  numinvent = value; }
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
        /// Propriedade referente ao campo: QTAVARIA1
        /// Comentário: Quantidade avaria primeira contagem.
        /// </summary>
        private decimal qtavaria1;
        [XmlElement(ElementName = "QTAVARIA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtavaria1
        {
            get { return  qtavaria1; }
            set {  qtavaria1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTAVARIA2
        /// Comentário: Quantidade avaria segunda contagem.
        /// </summary>
        private decimal qtavaria2;
        [XmlElement(ElementName = "QTAVARIA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtavaria2
        {
            get { return  qtavaria2; }
            set {  qtavaria2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTAVARIA3
        /// Comentário: Quantidade avaria terceira contagem.
        /// </summary>
        private decimal qtavaria3;
        [XmlElement(ElementName = "QTAVARIA3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtavaria3
        {
            get { return  qtavaria3; }
            set {  qtavaria3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCONT
        /// Comentário: Estoque Contábil do produto.
        /// </summary>
        private decimal qtcont;
        [XmlElement(ElementName = "QTCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtcont
        {
            get { return  qtcont; }
            set {  qtcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEST
        /// Comentário: Estoque Contábil do produto
        /// </summary>
        private decimal qtest;
        [XmlElement(ElementName = "QTEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtest
        {
            get { return  qtest; }
            set {  qtest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGER
        /// Comentário: 
        /// </summary>
        private decimal qtestger;
        [XmlElement(ElementName = "QTESTGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtestger
        {
            get { return  qtestger; }
            set {  qtestger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTGIROCALC
        /// Comentário: 
        /// </summary>
        private decimal qtgirocalc;
        [XmlElement(ElementName = "QTGIROCALC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtgirocalc
        {
            get { return  qtgirocalc; }
            set {  qtgirocalc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUTILIZAATUALIZACAO
        /// Comentário: Quantidade utilizada na atualização do estoque.
        /// </summary>
        private decimal qtutilizaatualizacao;
        [XmlElement(ElementName = "QTUTILIZAATUALIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtutilizaatualizacao
        {
            get { return  qtutilizaatualizacao; }
            set {  qtutilizaatualizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT1
        /// Comentário: 
        /// </summary>
        private decimal qt1;
        [XmlElement(ElementName = "QT1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qt1
        {
            get { return  qt1; }
            set {  qt1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT1CT
        /// Comentário: 
        /// </summary>
        private decimal qt1ct;
        [XmlElement(ElementName = "QT1CT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt1ct
        {
            get { return  qt1ct; }
            set {  qt1ct = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT1CX
        /// Comentário: 
        /// </summary>
        private decimal qt1cx;
        [XmlElement(ElementName = "QT1CX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt1cx
        {
            get { return  qt1cx; }
            set {  qt1cx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT1LJ
        /// Comentário: 
        /// </summary>
        private decimal qt1lj;
        [XmlElement(ElementName = "QT1LJ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt1lj
        {
            get { return  qt1lj; }
            set {  qt1lj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT1UN
        /// Comentário: 
        /// </summary>
        private decimal qt1un;
        [XmlElement(ElementName = "QT1UN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt1un
        {
            get { return  qt1un; }
            set {  qt1un = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT2
        /// Comentário: 
        /// </summary>
        private decimal qt2;
        [XmlElement(ElementName = "QT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qt2
        {
            get { return  qt2; }
            set {  qt2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT2CT
        /// Comentário: 
        /// </summary>
        private decimal qt2ct;
        [XmlElement(ElementName = "QT2CT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt2ct
        {
            get { return  qt2ct; }
            set {  qt2ct = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT2CX
        /// Comentário: 
        /// </summary>
        private decimal qt2cx;
        [XmlElement(ElementName = "QT2CX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt2cx
        {
            get { return  qt2cx; }
            set {  qt2cx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT2LJ
        /// Comentário: 
        /// </summary>
        private decimal qt2lj;
        [XmlElement(ElementName = "QT2LJ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt2lj
        {
            get { return  qt2lj; }
            set {  qt2lj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT2UN
        /// Comentário: 
        /// </summary>
        private decimal qt2un;
        [XmlElement(ElementName = "QT2UN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt2un
        {
            get { return  qt2un; }
            set {  qt2un = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT3
        /// Comentário: 
        /// </summary>
        private decimal qt3;
        [XmlElement(ElementName = "QT3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qt3
        {
            get { return  qt3; }
            set {  qt3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT3CT
        /// Comentário: 
        /// </summary>
        private decimal qt3ct;
        [XmlElement(ElementName = "QT3CT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt3ct
        {
            get { return  qt3ct; }
            set {  qt3ct = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT3CX
        /// Comentário: 
        /// </summary>
        private decimal qt3cx;
        [XmlElement(ElementName = "QT3CX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt3cx
        {
            get { return  qt3cx; }
            set {  qt3cx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT3LJ
        /// Comentário: 
        /// </summary>
        private decimal qt3lj;
        [XmlElement(ElementName = "QT3LJ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt3lj
        {
            get { return  qt3lj; }
            set {  qt3lj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT3UN
        /// Comentário: 
        /// </summary>
        private decimal qt3un;
        [XmlElement(ElementName = "QT3UN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt3un
        {
            get { return  qt3un; }
            set {  qt3un = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCInventrot()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINVENTROT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCInventrot> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCInventrot>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCInventrot> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCInventrot>(where);
        }

        #endregion
    }
}
