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
    /// Classe referente a tabela PCWmsauditarcaixa
    /// </summary>
    [XmlType("PCWMSAUDITARCAIXA")]
    public class PCWmsauditarcaixa : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAUDITOR
        /// Coment�rio: C�digo do Funcion�rio auditor
        /// </summary>
        private decimal codfuncauditor;
        [XmlElement(ElementName = "CODFUNCAUDITOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncauditor
        {
            get { return  codfuncauditor; }
            set {  codfuncauditor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data de lan�amento
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
        /// Propriedade referente ao campo: NUMOS
        /// Coment�rio: N�mero da O.S.
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOL
        /// Coment�rio: N�mero do Volume
        /// </summary>
        private decimal numvol;
        [XmlElement(ElementName = "NUMVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numvol
        {
            get { return  numvol; }
            set {  numvol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTOLERANCIA
        /// Coment�rio: Percentual de Toler�ncia
        /// </summary>
        private decimal perctolerancia;
        [XmlElement(ElementName = "PERCTOLERANCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perctolerancia
        {
            get { return  perctolerancia; }
            set {  perctolerancia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBALANCA
        /// Coment�rio: Peso calculado pela balan�a
        /// </summary>
        private decimal pesobalanca;
        [XmlElement(ElementName = "PESOBALANCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pesobalanca
        {
            get { return  pesobalanca; }
            set {  pesobalanca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOESTIMADO
        /// Coment�rio: Peso estimado
        /// </summary>
        private decimal pesoestimado;
        [XmlElement(ElementName = "PESOESTIMADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pesoestimado
        {
            get { return  pesoestimado; }
            set {  pesoestimado = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCWmsauditarcaixa()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSAUDITARCAIXA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCWmsauditarcaixa> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmsauditarcaixa.GetStringConnection());
            return ba.Listar<PCWmsauditarcaixa>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCWmsauditarcaixa> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmsauditarcaixa.GetStringConnection());
            return ba.Existe<PCWmsauditarcaixa>(where);
        }

        #endregion
    }
}
