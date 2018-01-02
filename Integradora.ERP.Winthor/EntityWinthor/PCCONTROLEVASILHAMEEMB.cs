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
    /// Classe referente a tabela PCControlevasilhameemb
    /// </summary>
    [XmlType("PCCONTROLEVASILHAMEEMB")]
    public class PCControlevasilhameemb : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Codigo da embalagem vinculada
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
        /// Propriedade referente ao campo: CODCONTROLE
        /// Comentário: Código controle vasilhame
        /// </summary>
        private decimal codcontrole;
        [XmlElement(ElementName = "CODCONTROLE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontrole
        {
            get { return  codcontrole; }
            set {  codcontrole = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial
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
        /// Propriedade referente ao campo: CODVASILHAME
        /// Comentário: Código do vasilhame
        /// </summary>
        private decimal codvasilhame;
        [XmlElement(ElementName = "CODVASILHAME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codvasilhame
        {
            get { return  codvasilhame; }
            set {  codvasilhame = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTRADA
        /// Comentário: Data de entrada do vasilhame
        /// </summary>
        private DateTime? dtentrada;
        [XmlElement(ElementName = "DTENTRADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtentrada
        {
            get { return  dtentrada; }
            set {  dtentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Comentário: Matricula do usuario que recebeu
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
        /// Propriedade referente ao campo: QTENTRADA
        /// Comentário: Quantidade recebida de vasilhame
        /// </summary>
        private decimal qtentrada;
        [XmlElement(ElementName = "QTENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtentrada
        {
            get { return  qtentrada; }
            set {  qtentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSAIDA
        /// Comentário: Quantidade saida de vasilhame
        /// </summary>
        private decimal qtsaida;
        [XmlElement(ElementName = "QTSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtsaida
        {
            get { return  qtsaida; }
            set {  qtsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDIDO
        /// Comentário: Vasilhame foi vendido
        /// </summary>
        private string vendido;
        [XmlElement(ElementName = "VENDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendido
        {
            get { return  vendido; }
            set {  vendido = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCControlevasilhameemb()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTROLEVASILHAMEEMB";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCControlevasilhameemb> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCControlevasilhameemb>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCControlevasilhameemb> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCControlevasilhameemb>(where);
        }

        #endregion
    }
}
