using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a tabela Esvcobrancas
    /// </summary>
    [XmlType("ESVCOBRANCAS")]
    public class Esvcobrancas : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BOLETO
        /// Comentário: 
        /// </summary>
        private string boleto;
        [XmlElement(ElementName = "BOLETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Boleto
        {
            get { return  boleto; }
            set {  boleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARTAO
        /// Comentário: 
        /// </summary>
        private string cartao;
        [XmlElement(ElementName = "CARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cartao
        {
            get { return  cartao; }
            set {  cartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COBRANCA
        /// Comentário: 
        /// </summary>
        private string cobranca;
        [XmlElement(ElementName = "COBRANCA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,30)]
        public string Cobranca
        {
            get { return  cobranca; }
            set {  cobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBRANCA
        /// Comentário: 
        /// </summary>
        private string codcobranca;
        [XmlElement(ElementName = "CODCOBRANCA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public string Codcobranca
        {
            get { return  codcobranca; }
            set {  codcobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMPRESA
        /// Comentário: 
        /// </summary>
        private string codempresa;
        [XmlElement(ElementName = "CODEMPRESA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codempresa
        {
            get { return  codempresa; }
            set {  codempresa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOEDA
        /// Comentário: 
        /// </summary>
        private string codmoeda;
        [XmlElement(ElementName = "CODMOEDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codmoeda
        {
            get { return  codmoeda; }
            set {  codmoeda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONVENIO
        /// Comentário: 
        /// </summary>
        private string convenio;
        [XmlElement(ElementName = "CONVENIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Convenio
        {
            get { return  convenio; }
            set {  convenio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,30)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMAXIMOVENDA
        /// Comentário: 
        /// </summary>
        private decimal prazomaximovenda;
        [XmlElement(ElementName = "PRAZOMAXIMOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Prazomaximovenda
        {
            get { return  prazomaximovenda; }
            set {  prazomaximovenda = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Esvcobrancas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVCOBRANCAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esvcobrancas> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvcobrancas.GetStringConnection());
            return ba.Listar<Esvcobrancas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esvcobrancas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvcobrancas.GetStringConnection());
            return ba.Existe<Esvcobrancas>(where);
        }

        #endregion
    }
}
