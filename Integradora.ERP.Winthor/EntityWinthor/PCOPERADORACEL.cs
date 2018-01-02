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
    /// Classe referente a tabela PCOperadoracel
    /// </summary>
    [XmlType("PCOPERADORACEL")]
    public class PCOperadoracel : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Coment�rio: Codigo da Conta gerencial da PCCONTA.
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: Codigo do Fornecedor a ser lan�ado na PCLANC.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHIST
        /// Coment�rio: Codigo do Historico da PCHIST.
        /// </summary>
        private decimal codhist;
        [XmlElement(ElementName = "CODHIST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codhist
        {
            get { return  codhist; }
            set {  codhist = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERRECARGACEL
        /// Coment�rio: C�d de retorno da operadora de celular.
        /// </summary>
        private decimal codoperrecargacel;
        [XmlElement(ElementName = "CODOPERRECARGACEL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public decimal Codoperrecargacel
        {
            get { return  codoperrecargacel; }
            set {  codoperrecargacel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAMESRECARGA
        /// Coment�rio: Dia do m�s para recarga g�s
        /// </summary>
        private decimal diamesrecarga;
        [XmlElement(ElementName = "DIAMESRECARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diamesrecarga
        {
            get { return  diamesrecarga; }
            set {  diamesrecarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEMANARECARGA
        /// Coment�rio: Dia da semana recarga g�s
        /// </summary>
        private string diasemanarecarga;
        [XmlElement(ElementName = "DIASEMANARECARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Diasemanarecarga
        {
            get { return  diasemanarecarga; }
            set {  diasemanarecarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTCOMPL
        /// Coment�rio: Complemento do historico a ser lan�ado na PCLANC.
        /// </summary>
        private string histcompl;
        [XmlElement(ElementName = "HISTCOMPL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Histcompl
        {
            get { return  histcompl; }
            set {  histcompl = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERADORA
        /// Coment�rio: Nome da Operadora de Celular(vivo, tim, etc...).
        /// </summary>
        private string operadora;
        [XmlElement(ElementName = "OPERADORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Operadora
        {
            get { return  operadora; }
            set {  operadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Coment�rio: Percentual do valor da recarga a ser repassado para o fornecedor do servi�o.
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO
        /// Coment�rio: Prazo de vencimento a ser informado na PCLANC.
        /// </summary>
        private decimal prazo;
        [XmlElement(ElementName = "PRAZO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo
        {
            get { return  prazo; }
            set {  prazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOPERADORA
        /// Coment�rio: Tipo de Operadora de recargar 
        /// </summary>
        private string tipooperadora;
        [XmlElement(ElementName = "TIPOOPERADORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Tipooperadora
        {
            get { return  tipooperadora; }
            set {  tipooperadora = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCOperadoracel()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCOPERADORACEL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOperadoracel> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOperadoracel>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCOperadoracel> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOperadoracel>(where);
        }

        #endregion
    }
}
