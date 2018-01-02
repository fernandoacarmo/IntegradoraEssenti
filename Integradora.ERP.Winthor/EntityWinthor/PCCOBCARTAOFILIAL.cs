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
    /// Classe referente a tabela PCCobcartaofilial
    /// </summary>
    [XmlType("PCCOBCARTAOFILIAL")]
    public class PCCobcartaofilial : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: C�digo de cobran�a.
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAFIMQTPARCTXADM
        /// Coment�rio: FAIXA FINAL DE PASRCELAS PARA IDENTIFICA��O DA TAXA DE ADMINISTRA��O A SER UTILIZADA, NO FECHAMENTO DO CHECKOUT.
        /// </summary>
        private decimal faixafimqtparctxadm;
        [XmlElement(ElementName = "FAIXAFIMQTPARCTXADM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Faixafimqtparctxadm
        {
            get { return  faixafimqtparctxadm; }
            set {  faixafimqtparctxadm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAINIQTPARCTXADM
        /// Coment�rio: FAIXA INICIAL DE PASRCELAS PARA IDENTIFICA��O DA TAXA DE ADMINISTRA��O A SER UTILIZADA, NO FECHAMENTO DO CHECKOUT.
        /// </summary>
        private decimal faixainiqtparctxadm;
        [XmlElement(ElementName = "FAIXAINIQTPARCTXADM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Faixainiqtparctxadm
        {
            get { return  faixainiqtparctxadm; }
            set {  faixainiqtparctxadm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTXADMINCC
        /// Coment�rio: T�xa de administra��o do cart�o.
        /// </summary>
        private decimal perctxadmincc;
        [XmlElement(ElementName = "PERCTXADMINCC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perctxadmincc
        {
            get { return  perctxadmincc; }
            set {  perctxadmincc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPARCELAS
        /// Coment�rio: Quantidade de parcelas do cart�o de cr�dito.
        /// </summary>
        private decimal qtparcelas;
        [XmlElement(ElementName = "QTPARCELAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtparcelas
        {
            get { return  qtparcelas; }
            set {  qtparcelas = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCobcartaofilial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOBCARTAOFILIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCobcartaofilial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCobcartaofilial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCobcartaofilial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCobcartaofilial>(where);
        }

        #endregion
    }
}
