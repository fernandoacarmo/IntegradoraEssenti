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
    /// Classe referente a tabela PCWmspadraofornec
    /// </summary>
    [XmlType("PCWMSPADRAOFORNEC")]
    public class PCWmspadraofornec : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAOFIMPROD
        /// Comentário: 
        /// </summary>
        private decimal posicaofimprod;
        [XmlElement(ElementName = "POSICAOFIMPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Posicaofimprod
        {
            get { return  posicaofimprod; }
            set {  posicaofimprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAOFIMQT
        /// Comentário: 
        /// </summary>
        private decimal posicaofimqt;
        [XmlElement(ElementName = "POSICAOFIMQT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Posicaofimqt
        {
            get { return  posicaofimqt; }
            set {  posicaofimqt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAOINIPROD
        /// Comentário: 
        /// </summary>
        private decimal posicaoiniprod;
        [XmlElement(ElementName = "POSICAOINIPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Posicaoiniprod
        {
            get { return  posicaoiniprod; }
            set {  posicaoiniprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAOINIQT
        /// Comentário: 
        /// </summary>
        private decimal posicaoiniqt;
        [XmlElement(ElementName = "POSICAOINIQT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Posicaoiniqt
        {
            get { return  posicaoiniqt; }
            set {  posicaoiniqt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCASASDECIMAIS
        /// Comentário: 
        /// </summary>
        private decimal qtcasasdecimais;
        [XmlElement(ElementName = "QTCASASDECIMAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtcasasdecimais
        {
            get { return  qtcasasdecimais; }
            set {  qtcasasdecimais = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWmspadraofornec()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSPADRAOFORNEC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWmspadraofornec> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmspadraofornec.GetStringConnection());
            return ba.Listar<PCWmspadraofornec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWmspadraofornec> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmspadraofornec.GetStringConnection());
            return ba.Existe<PCWmspadraofornec>(where);
        }

        #endregion
    }
}
