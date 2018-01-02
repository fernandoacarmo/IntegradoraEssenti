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
    /// Classe referente a tabela PCMovendpendvolume
    /// </summary>
    [XmlType("PCMOVENDPENDVOLUME")]
    public class PCMovendpendvolume : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Coment�rio: 
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codendereco
        {
            get { return  codendereco; }
            set {  codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: C�digo conferente
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPER
        /// Coment�rio: 
        /// </summary>
        private string codoper;
        [XmlElement(ElementName = "CODOPER", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Codoper
        {
            get { return  codoper; }
            set {  codoper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONFIRMADO
        /// Coment�rio: 
        /// </summary>
        private string confirmado;
        [XmlElement(ElementName = "CONFIRMADO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Confirmado
        {
            get { return  confirmado; }
            set {  confirmado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data Lan�amento
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
        /// Propriedade referente ao campo: DTVALIDADE
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidade
        {
            get { return  dtvalidade; }
            set {  dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Coment�rio: 
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSWMS
        /// Coment�rio: 
        /// </summary>
        private decimal numtranswms;
        [XmlElement(ElementName = "NUMTRANSWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranswms
        {
            get { return  numtranswms; }
            set {  numtranswms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPECAS
        /// Coment�rio: Quantidade de pe�as
        /// </summary>
        private decimal qtpecas;
        [XmlElement(ElementName = "QTPECAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtpecas
        {
            get { return  qtpecas; }
            set {  qtpecas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQUENCIA
        /// Coment�rio: 
        /// </summary>
        private decimal sequencia;
        [XmlElement(ElementName = "SEQUENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Sequencia
        {
            get { return  sequencia; }
            set {  sequencia = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMovendpendvolume()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVENDPENDVOLUME";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMovendpendvolume> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovendpendvolume>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMovendpendvolume> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovendpendvolume>(where);
        }

        #endregion
    }
}
