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
    /// Classe referente a tabela PCObrigacaofiscal
    /// </summary>
    [XmlType("PCOBRIGACAOFISCAL")]
    public class PCObrigacaofiscal : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADE
        /// Comentário: Cidade da obrigação
        /// </summary>
        private decimal codcidade;
        [XmlElement(ElementName = "CODCIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcidade
        {
            get { return  codcidade; }
            set {  codcidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOBRFISCAL
        /// Comentário: Codigo obrigação fiscal
        /// </summary>
        private decimal codobrfiscal;
        [XmlElement(ElementName = "CODOBRFISCAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codobrfiscal
        {
            get { return  codobrfiscal; }
            set {  codobrfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERADIAUTIL
        /// Comentário: Obrigação em dias uteis
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
        /// Comentário: Considera sabado como dia util
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
        /// Propriedade referente ao campo: DESCOBRFISCAL
        /// Comentário: Descricao da obrigação fiscal
        /// </summary>
        private string descobrfiscal;
        [XmlElement(ElementName = "DESCOBRFISCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descobrfiscal
        {
            get { return  descobrfiscal; }
            set {  descobrfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSOBRFISCAL
        /// Comentário: 
        /// </summary>
        private string obsobrfiscal;
        [XmlElement(ElementName = "OBSOBRFISCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Obsobrfiscal
        {
            get { return  obsobrfiscal; }
            set {  obsobrfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIASAVISO
        /// Comentário: Enviar avisos com o intervalo de quantos dias
        /// </summary>
        private decimal qtdiasaviso;
        [XmlElement(ElementName = "QTDIASAVISO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtdiasaviso
        {
            get { return  qtdiasaviso; }
            set {  qtdiasaviso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIASLEMBRETE
        /// Comentário: Lembrar apartir de quantos dias
        /// </summary>
        private decimal qtdiaslembrete;
        [XmlElement(ElementName = "QTDIASLEMBRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtdiaslembrete
        {
            get { return  qtdiaslembrete; }
            set {  qtdiaslembrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Tipo da obrgiação
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Comentário: UF
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCObrigacaofiscal()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCOBRIGACAOFISCAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCObrigacaofiscal> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCObrigacaofiscal>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCObrigacaofiscal> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCObrigacaofiscal>(where);
        }

        #endregion
    }
}
