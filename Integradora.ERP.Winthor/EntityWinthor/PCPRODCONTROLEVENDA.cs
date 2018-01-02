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
    /// Classe referente a tabela PCProdcontrolevenda
    /// </summary>
    [XmlType("PCPRODCONTROLEVENDA")]
    public class PCProdcontrolevenda : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do Produto
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOCONTROLEVENDA
        /// Comentário: Código do Tipo de Controle de Venda
        /// </summary>
        private decimal codtipocontrolevenda;
        [XmlElement(ElementName = "CODTIPOCONTROLEVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Codtipocontrolevenda
        {
            get { return  codtipocontrolevenda; }
            set {  codtipocontrolevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLIMISENCAODISTRIBMES
        /// Comentário: Qt. Limite Isenção Distribuidor
        /// </summary>
        private decimal qtlimisencaodistribmes;
        [XmlElement(ElementName = "QTLIMISENCAODISTRIBMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtlimisencaodistribmes
        {
            get { return  qtlimisencaodistribmes; }
            set {  qtlimisencaodistribmes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLIMISENCAOPFMES
        /// Comentário: Qt. Limite Isenção Pessoa Fisica Mês.
        /// </summary>
        private decimal qtlimisencaopfmes;
        [XmlElement(ElementName = "QTLIMISENCAOPFMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtlimisencaopfmes
        {
            get { return  qtlimisencaopfmes; }
            set {  qtlimisencaopfmes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLIMISENCAOPJMES
        /// Comentário: Qt. Limite Isenção Pessoa Juridica Mês.
        /// </summary>
        private decimal qtlimisencaopjmes;
        [XmlElement(ElementName = "QTLIMISENCAOPJMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtlimisencaopjmes
        {
            get { return  qtlimisencaopjmes; }
            set {  qtlimisencaopjmes = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCProdcontrolevenda()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODCONTROLEVENDA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCProdcontrolevenda> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdcontrolevenda>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCProdcontrolevenda> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdcontrolevenda>(where);
        }

        #endregion
    }
}
