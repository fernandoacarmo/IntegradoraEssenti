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
    /// Classe referente a tabela PCPromi
    /// </summary>
    [XmlType("PCPROMI")]
    public class PCPromi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Código Auxiliar Embalagem
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
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
        /// Propriedade referente ao campo: CODPROPRINC
        /// Comentário: Código da campanha principal. Permite agrupar varias campanhas a uma só.
        /// </summary>
        private decimal codproprinc;
        [XmlElement(ElementName = "CODPROPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codproprinc
        {
            get { return  codproprinc; }
            set {  codproprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODOBRIG
        /// Comentário: Produto Obrigatório.
        /// </summary>
        private string prodobrig;
        [XmlElement(ElementName = "PRODOBRIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prodobrig
        {
            get { return  prodobrig; }
            set {  prodobrig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLIMITEBRINDE
        /// Comentário: Campo para armazenar a quantidade limite para o brinde, com o objetivo de servir como limitador adicional para término de campanhas
        /// </summary>
        private decimal qtlimitebrinde;
        [XmlElement(ElementName = "QTLIMITEBRINDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtlimitebrinde
        {
            get { return  qtlimitebrinde; }
            set {  qtlimitebrinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXDIA
        /// Comentário: 
        /// </summary>
        private decimal qtmaxdia;
        [XmlElement(ElementName = "QTMAXDIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtmaxdia
        {
            get { return  qtmaxdia; }
            set {  qtmaxdia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXVENDA
        /// Comentário: 
        /// </summary>
        private decimal qtmaxvenda;
        [XmlElement(ElementName = "QTMAXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtmaxvenda
        {
            get { return  qtmaxvenda; }
            set {  qtmaxvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIN
        /// Comentário: Quantidade mínima.
        /// </summary>
        private decimal qtmin;
        [XmlElement(ElementName = "QTMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmin
        {
            get { return  qtmin; }
            set {  qtmin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRICAOGRUPO
        /// Comentário: Restrição ao grupo.
        /// </summary>
        private string restricaogrupo;
        [XmlElement(ElementName = "RESTRICAOGRUPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Restricaogrupo
        {
            get { return  restricaogrupo; }
            set {  restricaogrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRICAOQTMIN
        /// Comentário: Quantidade mínima.
        /// </summary>
        private decimal restricaoqtmin;
        [XmlElement(ElementName = "RESTRICAOQTMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Restricaoqtmin
        {
            get { return  restricaoqtmin; }
            set {  restricaoqtmin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRICAOVALORMIN
        /// Comentário: Restrição valor mínimo
        /// </summary>
        private decimal restricaovalormin;
        [XmlElement(ElementName = "RESTRICAOVALORMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Restricaovalormin
        {
            get { return  restricaovalormin; }
            set {  restricaovalormin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMAX
        /// Comentário: 
        /// </summary>
        private decimal vlvendamax;
        [XmlElement(ElementName = "VLVENDAMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvendamax
        {
            get { return  vlvendamax; }
            set {  vlvendamax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMIN
        /// Comentário: 
        /// </summary>
        private decimal vlvendamin;
        [XmlElement(ElementName = "VLVENDAMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvendamin
        {
            get { return  vlvendamin; }
            set {  vlvendamin = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPromi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPROMI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPromi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPromi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPromi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPromi>(where);
        }

        #endregion
    }
}
