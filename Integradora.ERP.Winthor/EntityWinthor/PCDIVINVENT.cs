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
    /// Classe referente a tabela PCDivinvent
    /// </summary>
    [XmlType("PCDIVINVENT")]
    public class PCDivinvent : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,17)]
        public decimal Codendereco
        {
            get { return  codendereco; }
            set {  codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONT
        /// Comentário: 
        /// </summary>
        private decimal custocont;
        [XmlElement(ElementName = "CUSTOCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocont
        {
            get { return  custocont; }
            set {  custocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFIN
        /// Comentário: 
        /// </summary>
        private decimal custofin;
        [XmlElement(ElementName = "CUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofin
        {
            get { return  custofin; }
            set {  custofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREAL
        /// Comentário: 
        /// </summary>
        private decimal custoreal;
        [XmlElement(ElementName = "CUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoreal
        {
            get { return  custoreal; }
            set {  custoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREP
        /// Comentário: 
        /// </summary>
        private decimal custorep;
        [XmlElement(ElementName = "CUSTOREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorep
        {
            get { return  custorep; }
            set {  custorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTATUALIZACAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTPENULTIMOINV
        /// Comentário: 
        /// </summary>
        private DateTime? dtpenultimoinv;
        [XmlElement(ElementName = "DTPENULTIMOINV", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpenultimoinv
        {
            get { return  dtpenultimoinv; }
            set {  dtpenultimoinv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVAL
        /// Comentário: 
        /// </summary>
        private DateTime? dtval;
        [XmlElement(ElementName = "DTVAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtval
        {
            get { return  dtval; }
            set {  dtval = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FILIALGESTAOWMS
        /// Comentário: Filial de Gestão do WMS
        /// </summary>
        private string filialgestaowms;
        [XmlElement(ElementName = "FILIALGESTAOWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Filialgestaowms
        {
            get { return  filialgestaowms; }
            set {  filialgestaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LEGENDA
        /// Comentário: 
        /// </summary>
        private decimal legenda;
        [XmlElement(ElementName = "LEGENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Legenda
        {
            get { return  legenda; }
            set {  legenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMINVENT
        /// Comentário: 
        /// </summary>
        private decimal numinvent;
        [XmlElement(ElementName = "NUMINVENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Numinvent
        {
            get { return  numinvent; }
            set {  numinvent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTAVARIA
        /// Comentário: Quantidade de avaria para cada produto na atualização do inventario.
        /// </summary>
        private decimal qtavaria;
        [XmlElement(ElementName = "QTAVARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtavaria
        {
            get { return  qtavaria; }
            set {  qtavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIV
        /// Comentário: 
        /// </summary>
        private decimal qtdiv;
        [XmlElement(ElementName = "QTDIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtdiv
        {
            get { return  qtdiv; }
            set {  qtdiv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENDAVARIA
        /// Comentário: Quantidade de avaria.
        /// </summary>
        private decimal qtendavaria;
        [XmlElement(ElementName = "QTENDAVARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtendavaria
        {
            get { return  qtendavaria; }
            set {  qtendavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENDCROSS
        /// Comentário: Quantidade de crossdocking.
        /// </summary>
        private decimal qtendcross;
        [XmlElement(ElementName = "QTENDCROSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtendcross
        {
            get { return  qtendcross; }
            set {  qtendcross = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENDEXCESSO
        /// Comentário: Quantidade de excesso.
        /// </summary>
        private decimal qtendexcesso;
        [XmlElement(ElementName = "QTENDEXCESSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtendexcesso
        {
            get { return  qtendexcesso; }
            set {  qtendexcesso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENDFALTA
        /// Comentário: Quantidade de falta.
        /// </summary>
        private decimal qtendfalta;
        [XmlElement(ElementName = "QTENDFALTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtendfalta
        {
            get { return  qtendfalta; }
            set {  qtendfalta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENDSTAGE
        /// Comentário: Quantida do produto que estava em endereço de stage no momento da atualização gerencial.
        /// </summary>
        private decimal qtendstage;
        [XmlElement(ElementName = "QTENDSTAGE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtendstage
        {
            get { return  qtendstage; }
            set {  qtendstage = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTENDERECADA
        /// Comentário: 
        /// </summary>
        private decimal qtestenderecada;
        [XmlElement(ElementName = "QTESTENDERECADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtestenderecada
        {
            get { return  qtestenderecada; }
            set {  qtestenderecada = value; }
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
        /// Propriedade referente ao campo: QTRESERV
        /// Comentário: 
        /// </summary>
        private decimal qtreserv;
        [XmlElement(ElementName = "QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtreserv
        {
            get { return  qtreserv; }
            set {  qtreserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINAATUALIZACAO
        /// Comentário: ROTINA DA ATUALIZAÇÃO
        /// </summary>
        private decimal rotinaatualizacao;
        [XmlElement(ElementName = "ROTINAATUALIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Rotinaatualizacao
        {
            get { return  rotinaatualizacao; }
            set {  rotinaatualizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOATUALIZACAO
        /// Comentário: VERSÃO DA ATUALIZAÇÃO
        /// </summary>
        private string versaoatualizacao;
        [XmlElement(ElementName = "VERSAOATUALIZACAO", DataType = "NVARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,28)]
        public string Versaoatualizacao
        {
            get { return  versaoatualizacao; }
            set {  versaoatualizacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDivinvent()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDIVINVENT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDivinvent> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDivinvent>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDivinvent> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDivinvent>(where);
        }

        #endregion
    }
}
