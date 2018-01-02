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
    /// Classe referente a tabela PCControlecx
    /// </summary>
    [XmlType("PCCONTROLECX")]
    public class PCControlecx : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: Campo para armazenar o número do caixa.
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCAIXA
        /// Comentário: Campo para armazenar o código do funcionário responsável pelo caixa.
        /// </summary>
        private decimal codfunccaixa;
        [XmlElement(ElementName = "CODFUNCCAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfunccaixa
        {
            get { return  codfunccaixa; }
            set {  codfunccaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTURA
        /// Comentário: Campo para armazenar a data e hora de abertura do caixa.
        /// </summary>
        private DateTime? dtabertura;
        [XmlElement(ElementName = "DTABERTURA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtabertura
        {
            get { return  dtabertura; }
            set {  dtabertura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHAMENTO
        /// Comentário: Campo para armazenar a data e hora de fechamento do caixa.
        /// </summary>
        private DateTime? dtfechamento;
        [XmlElement(ElementName = "DTFECHAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechamento
        {
            get { return  dtfechamento; }
            set {  dtfechamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIMITEFECHAMENTO
        /// Comentário: Campo para armazenar a data e hora limite para fechamento do caixa.
        /// </summary>
        private DateTime? dtlimitefechamento;
        [XmlElement(ElementName = "DTLIMITEFECHAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlimitefechamento
        {
            get { return  dtlimitefechamento; }
            set {  dtlimitefechamento = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCControlecx()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTROLECX";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCControlecx> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCControlecx>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCControlecx> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCControlecx>(where);
        }

        #endregion
    }
}
