using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityAjuri
{ 
    /// <summary>
    /// Classe referente a tabela ESTEstoquemotivo
    /// </summary>
    [XmlType("ESTESTOQUEMOTIVO")]
    public class ESTEstoquemotivo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 6)]
        public decimal Codprod
        {
            get { return codprod; }
            set { codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtalteracao
        {
            get { return dtalteracao; }
            set { dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Comentário: 
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 50)]
        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELO
        /// Comentário: 
        /// </summary>
        private string modelo;
        [XmlElement(ElementName = "MODELO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 50)]
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIAL
        /// Comentário: 
        /// </summary>
        private string serial;
        [XmlElement(ElementName = "SERIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 50)]
        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFABRICACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtfabricacao;
        [XmlElement(ElementName = "DTFABRICACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtfabricacao
        {
            get { return dtfabricacao; }
            set { dtfabricacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Comentário: 
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtvalidade
        {
            get { return dtvalidade; }
            set { dtvalidade = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: NUMAJURI
        /// Comentário: 
        /// </summary>
        private string numajuri;
        [XmlElement(ElementName = "NUMAJURI", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 30)]
        public string Numajuri
        {
            get { return numajuri; }
            set { numajuri = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 15)]
        public string Numlote
        {
            get { return numlote; }
            set { numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTRADA
        /// Comentário: 
        /// </summary>
        private decimal qtentrada;
        [XmlElement(ElementName = "QTENTRADA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Qtentrada
        {
            get { return qtentrada; }
            set { qtentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSAIDA
        /// Comentário: 
        /// </summary>
        private decimal qtsaida;
        [XmlElement(ElementName = "QTSAIDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Qtsaida
        {
            get { return qtsaida; }
            set { qtsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSALDO
        /// Comentário: 
        /// </summary>
        private decimal qtsaldo;
        [XmlElement(ElementName = "QTSALDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Qtsaldo
        {
            get { return qtsaldo; }
            set { qtsaldo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTEstoquemotivo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTESTOQUEMOTIVO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTEstoquemotivo> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTEstoquemotivo.GetStringConnection());
            return ba.Listar<ESTEstoquemotivo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTEstoquemotivo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTEstoquemotivo.GetStringConnection());
            return ba.Existe<ESTEstoquemotivo>(where);
        }

        #endregion
    }
}
