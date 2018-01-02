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
    /// Classe referente a tabela Esvformulas
    /// </summary>
    [XmlType("ESVFORMULAS")]
    public class Esvformulas : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITAFRACAO
        /// Comentário: 
        /// </summary>
        private string aceitafracao;
        [XmlElement(ElementName = "ACEITAFRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitafracao
        {
            get { return  aceitafracao; }
            set {  aceitafracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXAESTOQUE
        /// Comentário: 
        /// </summary>
        private string baixaestoque;
        [XmlElement(ElementName = "BAIXAESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixaestoque
        {
            get { return  baixaestoque; }
            set {  baixaestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODINSUMO
        /// Comentário: 
        /// </summary>
        private decimal codinsumo;
        [XmlElement(ElementName = "CODINSUMO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codinsumo
        {
            get { return  codinsumo; }
            set {  codinsumo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Comentário: 
        /// </summary>
        private decimal codproduto;
        [XmlElement(ElementName = "CODPRODUTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codproduto
        {
            get { return  codproduto; }
            set {  codproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INSUMO
        /// Comentário: 
        /// </summary>
        private string insumo;
        [XmlElement(ElementName = "INSUMO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Insumo
        {
            get { return  insumo; }
            set {  insumo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCONSUMO
        /// Comentário: 
        /// </summary>
        private decimal qtconsumo;
        [XmlElement(ElementName = "QTCONSUMO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Qtconsumo
        {
            get { return  qtconsumo; }
            set {  qtconsumo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Esvformulas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVFORMULAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esvformulas> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvformulas.GetStringConnection());
            return ba.Listar<Esvformulas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esvformulas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvformulas.GetStringConnection());
            return ba.Existe<Esvformulas>(where);
        }

        #endregion
    }
}
