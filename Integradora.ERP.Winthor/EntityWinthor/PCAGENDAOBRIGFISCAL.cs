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
        /// Coment�rio: Codigo da Agenda
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
        /// Coment�rio: Codigo da Obriga��o Fiscal
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
        /// Coment�rio: Considerar somente dias uteis
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
        /// Coment�rio: Considera sabado dia util
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
        /// Coment�rio: Lembrar ap�s o vencimento
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
        /// Coment�rio: Data de lan�amento do registro
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
        /// Coment�rio: Descricao da Agenda
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
        /// Coment�rio: Descartar agenda
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
        /// Coment�rio: Matricula do funcion�rio que lan�ou agenda
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
        /// Coment�rio: Enviar recado de quantos em quantos dias
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
        /// Coment�rio: Enviar recados apartir de que dia
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAgendaobrigfiscal> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAgendaobrigfiscal>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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
