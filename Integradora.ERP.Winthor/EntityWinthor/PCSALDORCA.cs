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
    /// Classe referente a tabela PCSaldorca
    /// </summary>
    [XmlType("PCSALDORCA")]
    public class PCSaldorca : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: Código do RCA. |Campo do tipo numérico, de tamanho 6, sem casas decimais.
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDORESERVAANT
        /// Comentário: Valor do saldo reserva do RCA anterior
        /// </summary>
        private decimal saldoreservaant;
        [XmlElement(ElementName = "SALDORESERVAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Saldoreservaant
        {
            get { return  saldoreservaant; }
            set {  saldoreservaant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDORESERVAATUAL
        /// Comentário: Valor do saldo reserva do RCA atual
        /// </summary>
        private decimal saldoreservaatual;
        [XmlElement(ElementName = "SALDORESERVAATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Saldoreservaatual
        {
            get { return  saldoreservaatual; }
            set {  saldoreservaatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSALDO
        /// Comentário: Valor do saldo atual do RCA. |Campo do tipo numérico, de tamanho 12, com 6 decimais.
        /// </summary>
        private decimal vlsaldo;
        [XmlElement(ElementName = "VLSALDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlsaldo
        {
            get { return  vlsaldo; }
            set {  vlsaldo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSALDOANT
        /// Comentário: Valor do saldo anterior a última atualização. |Campo do tipo numérico, de tamanho 12, com 6 decimais.
        /// </summary>
        private decimal vlsaldoant;
        [XmlElement(ElementName = "VLSALDOANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlsaldoant
        {
            get { return  vlsaldoant; }
            set {  vlsaldoant = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCSaldorca()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSALDORCA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSaldorca> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSaldorca>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSaldorca> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSaldorca>(where);
        }

        #endregion
    }
}
