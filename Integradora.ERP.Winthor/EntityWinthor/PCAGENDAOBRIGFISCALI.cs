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
    /// Classe referente a tabela PCAgendaobrigfiscali
    /// </summary>
    [XmlType("PCAGENDAOBRIGFISCALI")]
    public class PCAgendaobrigfiscali : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Coment�rio: Ano da obriga��o
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAGENDA
        /// Coment�rio: C�digo da Agenda
        /// </summary>
        private decimal codagenda;
        [XmlElement(ElementName = "CODAGENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codagenda
        {
            get { return  codagenda; }
            set {  codagenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIA
        /// Coment�rio: Dia da obriga��o
        /// </summary>
        private decimal dia;
        [XmlElement(ElementName = "DIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Dia
        {
            get { return  dia; }
            set {  dia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Coment�rio: M�s da obriga��o
        /// </summary>
        private decimal mes;
        [XmlElement(ElementName = "MES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAgendaobrigfiscali()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAGENDAOBRIGFISCALI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAgendaobrigfiscali> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAgendaobrigfiscali>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAgendaobrigfiscali> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAgendaobrigfiscali>(where);
        }

        #endregion
    }
}
