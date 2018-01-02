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
    /// Classe referente a tabela PCPromoi
    /// </summary>
    [XmlType("PCPROMOI")]
    public class PCPromoi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODPROMOCAO
        /// Coment�rio: 
        /// </summary>
        private decimal codpromocao;
        [XmlElement(ElementName = "CODPROMOCAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codpromocao
        {
            get { return  codpromocao; }
            set {  codpromocao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXPONTO
        /// Coment�rio: Quantidade m�xima de pontos neste produto/prod principal.
        /// </summary>
        private decimal qtmaxponto;
        [XmlElement(ElementName = "QTMAXPONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtmaxponto
        {
            get { return  qtmaxponto; }
            set {  qtmaxponto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMETA
        /// Coment�rio: 
        /// </summary>
        private decimal qtmeta;
        [XmlElement(ElementName = "QTMETA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtmeta
        {
            get { return  qtmeta; }
            set {  qtmeta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINITEM
        /// Coment�rio: Quantidade minima por produto.
        /// </summary>
        private decimal qtminitem;
        [XmlElement(ElementName = "QTMINITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtminitem
        {
            get { return  qtminitem; }
            set {  qtminitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPESOMINIMOPONTUACAO
        /// Coment�rio: Qtd. Peso m�nimo para pontua��o da campanha.
        /// </summary>
        private decimal qtpesominimopontuacao;
        [XmlElement(ElementName = "QTPESOMINIMOPONTUACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtpesominimopontuacao
        {
            get { return  qtpesominimopontuacao; }
            set {  qtpesominimopontuacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPONTOS
        /// Coment�rio: 
        /// </summary>
        private decimal qtpontos;
        [XmlElement(ElementName = "QTPONTOS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Qtpontos
        {
            get { return  qtpontos; }
            set {  qtpontos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPONTOSCLIENTE
        /// Coment�rio: 
        /// </summary>
        private decimal qtpontoscliente;
        [XmlElement(ElementName = "QTPONTOSCLIENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtpontoscliente
        {
            get { return  qtpontoscliente; }
            set {  qtpontoscliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPONTOSMETA
        /// Coment�rio: 
        /// </summary>
        private decimal qtpontosmeta;
        [XmlElement(ElementName = "QTPONTOSMETA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtpontosmeta
        {
            get { return  qtpontosmeta; }
            set {  qtpontosmeta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPONTOSPESO
        /// Coment�rio: Quantidade de pontos por peso(KG) vendido.
        /// </summary>
        private decimal qtpontospeso;
        [XmlElement(ElementName = "QTPONTOSPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtpontospeso
        {
            get { return  qtpontospeso; }
            set {  qtpontospeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPONTOSVALOR
        /// Coment�rio: 
        /// </summary>
        private decimal qtpontosvalor;
        [XmlElement(ElementName = "QTPONTOSVALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtpontosvalor
        {
            get { return  qtpontosvalor; }
            set {  qtpontosvalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCADAPONTO
        /// Coment�rio: 
        /// </summary>
        private decimal vlcadaponto;
        [XmlElement(ElementName = "VLCADAPONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcadaponto
        {
            get { return  vlcadaponto; }
            set {  vlcadaponto = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPromoi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPROMOI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPromoi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPromoi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPromoi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPromoi>(where);
        }

        #endregion
    }
}
