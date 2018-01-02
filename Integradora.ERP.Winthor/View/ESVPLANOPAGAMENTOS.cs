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
    /// Classe referente a tabela Esvplanopagamentos
    /// </summary>
    [XmlType("ESVPLANOPAGAMENTOS")]
    public class Esvplanopagamentos : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPAGAMENTO
        /// Comentário: 
        /// </summary>
        private decimal codpagamento;
        [XmlElement(ElementName = "CODPAGAMENTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codpagamento
        {
            get { return  codpagamento; }
            set {  codpagamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMAPARCELAMENTO
        /// Comentário: 
        /// </summary>
        private string formaparcelamento;
        [XmlElement(ElementName = "FORMAPARCELAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Formaparcelamento
        {
            get { return  formaparcelamento; }
            set {  formaparcelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIAS
        /// Comentário: 
        /// </summary>
        private decimal numdias;
        [XmlElement(ElementName = "NUMDIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Numdias
        {
            get { return  numdias; }
            set {  numdias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTABELAPRECO
        /// Comentário: 
        /// </summary>
        private decimal numtabelapreco;
        [XmlElement(ElementName = "NUMTABELAPRECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numtabelapreco
        {
            get { return  numtabelapreco; }
            set {  numtabelapreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLANOPAGAMENTO
        /// Comentário: 
        /// </summary>
        private string planopagamento;
        [XmlElement(ElementName = "PLANOPAGAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Planopagamento
        {
            get { return  planopagamento; }
            set {  planopagamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDABK
        /// Comentário: 
        /// </summary>
        private string vendabk;
        [XmlElement(ElementName = "VENDABK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendabk
        {
            get { return  vendabk; }
            set {  vendabk = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Esvplanopagamentos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVPLANOPAGAMENTOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esvplanopagamentos> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvplanopagamentos.GetStringConnection());
            return ba.Listar<Esvplanopagamentos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esvplanopagamentos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvplanopagamentos.GetStringConnection());
            return ba.Existe<Esvplanopagamentos>(where);
        }

        #endregion
    }
}
