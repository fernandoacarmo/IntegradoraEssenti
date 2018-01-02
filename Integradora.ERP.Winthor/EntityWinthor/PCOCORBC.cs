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
    /// Classe referente a tabela PCOcorbc
    /// </summary>
    [XmlType("PCOCORBC")]
    public class PCOcorbc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BAIXA
        /// Coment�rio: 
        /// </summary>
        private string baixa;
        [XmlElement(ElementName = "BAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixa
        {
            get { return  baixa; }
            set {  baixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHDESCONTADO
        /// Coment�rio: Indica a ocorr�ncia para cheque descontado.
        /// </summary>
        private string chdescontado;
        [XmlElement(ElementName = "CHDESCONTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Chdescontado
        {
            get { return  chdescontado; }
            set {  chdescontado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHDEVOLVIDO
        /// Coment�rio: Indica a ocorr�ncia para cheque devolvido.
        /// </summary>
        private string chdevolvido;
        [XmlElement(ElementName = "CHDEVOLVIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Chdevolvido
        {
            get { return  chdevolvido; }
            set {  chdevolvido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Coment�rio: C�digo do Banco da Ocorr�ncia
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOCORRENCIA
        /// Coment�rio: 
        /// </summary>
        private string codocorrencia;
        [XmlElement(ElementName = "CODOCORRENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codocorrencia
        {
            get { return  codocorrencia; }
            set {  codocorrencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARTARIFA
        /// Coment�rio: Gerar valores de tarifa?
        /// </summary>
        private string gerartarifa;
        [XmlElement(ElementName = "GERARTARIFA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerartarifa
        {
            get { return  gerartarifa; }
            set {  gerartarifa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBANCO
        /// Coment�rio: 
        /// </summary>
        private decimal numbanco;
        [XmlElement(ElementName = "NUMBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numbanco
        {
            get { return  numbanco; }
            set {  numbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OCORCARTORIO
        /// Coment�rio: 
        /// </summary>
        private string ocorcartorio;
        [XmlElement(ElementName = "OCORCARTORIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ocorcartorio
        {
            get { return  ocorcartorio; }
            set {  ocorcartorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OCORRENCIA
        /// Coment�rio: 
        /// </summary>
        private string ocorrencia;
        [XmlElement(ElementName = "OCORRENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Ocorrencia
        {
            get { return  ocorrencia; }
            set {  ocorrencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTESTO
        /// Coment�rio: Indica a ocorr�ncia de protesto.
        /// </summary>
        private string protesto;
        [XmlElement(ElementName = "PROTESTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Protesto
        {
            get { return  protesto; }
            set {  protesto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TARIFA
        /// Coment�rio: 
        /// </summary>
        private decimal tarifa;
        [XmlElement(ElementName = "TARIFA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Tarifa
        {
            get { return  tarifa; }
            set {  tarifa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOCORR
        /// Coment�rio: Indica o tipo da ocorr�ncia magn�tica.
        /// </summary>
        private decimal tipoocorr;
        [XmlElement(ElementName = "TIPOOCORR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Tipoocorr
        {
            get { return  tipoocorr; }
            set {  tipoocorr = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCOcorbc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCOCORBC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOcorbc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOcorbc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCOcorbc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOcorbc>(where);
        }

        #endregion
    }
}
