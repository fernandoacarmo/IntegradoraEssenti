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
    /// Classe referente a tabela PCRegistrocirurgia
    /// </summary>
    [XmlType("PCREGISTROCIRURGIA")]
    public class PCRegistrocirurgia : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMEDICOCIRURGIA
        /// Comentário: Cód. Médico
        /// </summary>
        private decimal codmedicocirurgia;
        [XmlElement(ElementName = "CODMEDICOCIRURGIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmedicocirurgia
        {
            get { return  codmedicocirurgia; }
            set {  codmedicocirurgia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPACIENTECIRURGIA
        /// Comentário: Cód. Paciente
        /// </summary>
        private decimal codpacientecirurgia;
        [XmlElement(ElementName = "CODPACIENTECIRURGIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Codpacientecirurgia
        {
            get { return  codpacientecirurgia; }
            set {  codpacientecirurgia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCIRURGIA
        /// Comentário: Data da Cirurgia
        /// </summary>
        private DateTime? dtcirurgia;
        [XmlElement(ElementName = "DTCIRURGIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcirurgia
        {
            get { return  dtcirurgia; }
            set {  dtcirurgia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCIRURGIA
        /// Comentário: Num. Cirurgia
        /// </summary>
        private decimal numcirurgia;
        [XmlElement(ElementName = "NUMCIRURGIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numcirurgia
        {
            get { return  numcirurgia; }
            set {  numcirurgia = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRegistrocirurgia()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCREGISTROCIRURGIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRegistrocirurgia> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRegistrocirurgia>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRegistrocirurgia> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRegistrocirurgia>(where);
        }

        #endregion
    }
}
