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
    /// Classe referente a tabela PCBensresponsavel
    /// </summary>
    [XmlType("PCBENSRESPONSAVEL")]
    public class PCBensresponsavel : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODLOCALIZACAO
        /// Coment�rio: C�digo da localiza��o do bem.
        /// </summary>
        private decimal codlocalizacao;
        [XmlElement(ElementName = "CODLOCALIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codlocalizacao
        {
            get { return  codlocalizacao; }
            set {  codlocalizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRESPONSAVEL
        /// Coment�rio: Indica o c�digo da respons�vel do bem.
        /// </summary>
        private decimal codresponsavel;
        [XmlElement(ElementName = "CODRESPONSAVEL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codresponsavel
        {
            get { return  codresponsavel; }
            set {  codresponsavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRESPONSAVEL
        /// Coment�rio: Indica a descri��o da respons�vel do bem.
        /// </summary>
        private string descresponsavel;
        [XmlElement(ElementName = "DESCRESPONSAVEL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,60)]
        public string Descresponsavel
        {
            get { return  descresponsavel; }
            set {  descresponsavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEALTERALOCAL
        /// Coment�rio: Permite alterar localiza��o do bem no lan�amento.
        /// </summary>
        private string permitealteralocal;
        [XmlElement(ElementName = "PERMITEALTERALOCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitealteralocal
        {
            get { return  permitealteralocal; }
            set {  permitealteralocal = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCBensresponsavel()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBENSRESPONSAVEL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBensresponsavel> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBensresponsavel>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCBensresponsavel> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBensresponsavel>(where);
        }

        #endregion
    }
}
