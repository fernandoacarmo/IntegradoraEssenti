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
    /// Classe referente a tabela PCComplementoorcai
    /// </summary>
    [XmlType("PCCOMPLEMENTOORCAI")]
    public class PCComplementoorcai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: C�digo Auxiliar
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
        /// Propriedade referente ao campo: CODCOMP
        /// Coment�rio: C�digo do complemento
        /// </summary>
        private decimal codcomp;
        [XmlElement(ElementName = "CODCOMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcomp
        {
            get { return  codcomp; }
            set {  codcomp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRESSORESTAURANTE
        /// Coment�rio: STATUS DE IMPRESSAO
        /// </summary>
        private string impressorestaurante;
        [XmlElement(ElementName = "IMPRESSORESTAURANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Impressorestaurante
        {
            get { return  impressorestaurante; }
            set {  impressorestaurante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRIMERESTAURANTE
        /// Coment�rio: Imprime complemento no restaurante.
        /// </summary>
        private string imprimerestaurante;
        [XmlElement(ElementName = "IMPRIMERESTAURANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Imprimerestaurante
        {
            get { return  imprimerestaurante; }
            set {  imprimerestaurante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Coment�rio: N�mero do Or�amento
        /// </summary>
        private decimal numorca;
        [XmlElement(ElementName = "NUMORCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numorca
        {
            get { return  numorca; }
            set {  numorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: N�mero de sequ�ncia do complemento
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQITEMORCA
        /// Coment�rio: N�mero de sequ�ncia do item
        /// </summary>
        private decimal numseqitemorca;
        [XmlElement(ElementName = "NUMSEQITEMORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numseqitemorca
        {
            get { return  numseqitemorca; }
            set {  numseqitemorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMP
        /// Coment�rio: Quantidade de complementos
        /// </summary>
        private decimal qtcomp;
        [XmlElement(ElementName = "QTCOMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtcomp
        {
            get { return  qtcomp; }
            set {  qtcomp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALACRESCIMO
        /// Coment�rio: Valor total do acr�scimo
        /// </summary>
        private decimal totalacrescimo;
        [XmlElement(ElementName = "TOTALACRESCIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Totalacrescimo
        {
            get { return  totalacrescimo; }
            set {  totalacrescimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLACRESCIMO
        /// Coment�rio: Valor do acr�scimo
        /// </summary>
        private decimal vlacrescimo;
        [XmlElement(ElementName = "VLACRESCIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vlacrescimo
        {
            get { return  vlacrescimo; }
            set {  vlacrescimo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCComplementoorcai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMPLEMENTOORCAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCComplementoorcai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCComplementoorcai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCComplementoorcai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCComplementoorcai>(where);
        }

        #endregion
    }
}
