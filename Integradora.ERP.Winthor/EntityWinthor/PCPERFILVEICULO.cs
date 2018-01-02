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
    /// Classe referente a tabela PCPerfilveiculo
    /// </summary>
    [XmlType("PCPERFILVEICULO")]
    public class PCPerfilveiculo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPERFILVEICULO
        /// Coment�rio: C�digo do perfil do ve�culo
        /// </summary>
        private decimal codperfilveiculo;
        [XmlElement(ElementName = "CODPERFILVEICULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Codperfilveiculo
        {
            get { return  codperfilveiculo; }
            set {  codperfilveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DSCPERFILVEICULO
        /// Coment�rio: Descri��o do perfil do ve�culo
        /// </summary>
        private string dscperfilveiculo;
        [XmlElement(ElementName = "DSCPERFILVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Dscperfilveiculo
        {
            get { return  dscperfilveiculo; }
            set {  dscperfilveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDMAXIMA
        /// Coment�rio: Quantidade M�xima
        /// </summary>
        private decimal qtdmaxima;
        [XmlElement(ElementName = "QTDMAXIMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtdmaxima
        {
            get { return  qtdmaxima; }
            set {  qtdmaxima = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDMINIMA
        /// Coment�rio: Quantidade Min�ma
        /// </summary>
        private decimal qtdminima;
        [XmlElement(ElementName = "QTDMINIMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtdminima
        {
            get { return  qtdminima; }
            set {  qtdminima = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPerfilveiculo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPERFILVEICULO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPerfilveiculo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPerfilveiculo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPerfilveiculo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPerfilveiculo>(where);
        }

        #endregion
    }
}
