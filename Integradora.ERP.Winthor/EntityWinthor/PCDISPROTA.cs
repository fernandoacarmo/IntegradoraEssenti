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
    /// Classe referente a tabela PCDisprota
    /// </summary>
    [XmlType("PCDISPROTA")]
    public class PCDisprota : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAPACIDADE
        /// Coment�rio: Capacidade da rota.
        /// </summary>
        private decimal capacidade;
        [XmlElement(ElementName = "CAPACIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Capacidade
        {
            get { return  capacidade; }
            set {  capacidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDISP
        /// Coment�rio: C�digo de disponibilidade de rota.
        /// </summary>
        private decimal coddisp;
        [XmlElement(ElementName = "CODDISP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Coddisp
        {
            get { return  coddisp; }
            set {  coddisp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial.
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
        /// Propriedade referente ao campo: CODROTA
        /// Coment�rio: C�digo da rota.
        /// </summary>
        private decimal codrota;
        [XmlElement(ElementName = "CODROTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrota
        {
            get { return  codrota; }
            set {  codrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data de entrega.
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
        /// Propriedade referente ao campo: DIASROTADISP
        /// Coment�rio: DIAS ROTA DISP
        /// </summary>
        private decimal diasrotadisp;
        [XmlElement(ElementName = "DIASROTADISP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Diasrotadisp
        {
            get { return  diasrotadisp; }
            set {  diasrotadisp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TURNOENTREGA
        /// Coment�rio: Turno para entrega.
        /// </summary>
        private string turnoentrega;
        [XmlElement(ElementName = "TURNOENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Turnoentrega
        {
            get { return  turnoentrega; }
            set {  turnoentrega = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDisprota()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDISPROTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDisprota> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDisprota>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDisprota> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDisprota>(where);
        }

        #endregion
    }
}
