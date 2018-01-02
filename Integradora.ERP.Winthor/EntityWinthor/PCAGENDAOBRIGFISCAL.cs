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
    /// Classe referente a tabela PCAgendaobrigfiscal
    /// </summary>
    [XmlType("PCAGENDAOBRIGFISCAL")]
    public class PCAgendaobrigfiscal : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAGENDA
        /// Comentário: Codigo da Agenda
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
        /// Propriedade referente ao campo: CODOBRFISCAL
        /// Comentário: Codigo da Obrigação Fiscal
        /// </summary>
        private decimal codobrfiscal;
        [XmlElement(ElementName = "CODOBRFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codobrfiscal
        {
            get { return  codobrfiscal; }
            set {  codobrfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERADIAUTIL
        /// Comentário: Considerar somente dias uteis
        /// </summary>
        private string consideradiautil;
        [XmlElement(ElementName = "CONSIDERADIAUTIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideradiautil
        {
            get { return  consideradiautil; }
            set {  consideradiautil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERASABADOUTIL
        /// Comentário: Considera sabado dia util
        /// </summary>
        private string considerasabadoutil;
        [XmlElement(ElementName = "CONSIDERASABADOUTIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerasabadoutil
        {
            get { return  considerasabadoutil; }
            set {  considerasabadoutil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTINUALEMBRETEAPOSVENC
        /// Comentário: Lembrar após o vencimento
        /// </summary>
        private string continualembreteaposvenc;
        [XmlElement(ElementName = "CONTINUALEMBRETEAPOSVENC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Continualembreteaposvenc
        {
            get { return  continualembreteaposvenc; }
            set {  continualembreteaposvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATALANC
        /// Comentário: Data de lançamento do registro
        /// </summary>
        private DateTime? datalanc;
        [XmlElement(ElementName = "DATALANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datalanc
        {
            get { return  datalanc; }
            set {  datalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCAGENDA
        /// Comentário: Descricao da Agenda
        /// </summary>
        private string descagenda;
        [XmlElement(ElementName = "DESCAGENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descagenda
        {
            get { return  descagenda; }
            set {  descagenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCARTARAGENDA
        /// Comentário: Descartar agenda
        /// </summary>
        private string descartaragenda;
        [XmlElement(ElementName = "DESCARTARAGENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Descartaragenda
        {
            get { return  descartaragenda; }
            set {  descartaragenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULALANC
        /// Comentário: Matricula do funcionário que lançou agenda
        /// </summary>
        private decimal matriculalanc;
        [XmlElement(ElementName = "MATRICULALANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matriculalanc
        {
            get { return  matriculalanc; }
            set {  matriculalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIASAVISO
        /// Comentário: Enviar recado de quantos em quantos dias
        /// </summary>
        private decimal qtdiasaviso;
        [XmlElement(ElementName = "QTDIASAVISO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtdiasaviso
        {
            get { return  qtdiasaviso; }
            set {  qtdiasaviso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIASLEMBRETE
        /// Comentário: Enviar recados apartir de que dia
        /// </summary>
        private decimal qtdiaslembrete;
        [XmlElement(ElementName = "QTDIASLEMBRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtdiaslembrete
        {
            get { return  qtdiaslembrete; }
            set {  qtdiaslembrete = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAgendaobrigfiscal()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAGENDAOBRIGFISCAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAgendaobrigfiscal> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAgendaobrigfiscal>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAgendaobrigfiscal> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAgendaobrigfiscal>(where);
        }

        #endregion
    }
}
