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
    /// Classe referente a tabela PCMargem
    /// </summary>
    [XmlType("PCMARGEM")]
    public class PCMargem : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOFIM
        /// Comentário: 
        /// </summary>
        private decimal comissaofim;
        [XmlElement(ElementName = "COMISSAOFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Comissaofim
        {
            get { return  comissaofim; }
            set {  comissaofim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOINI
        /// Comentário: 
        /// </summary>
        private decimal comissaoini;
        [XmlElement(ElementName = "COMISSAOINI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Comissaoini
        {
            get { return  comissaoini; }
            set {  comissaoini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FLEXIVEL
        /// Comentário: 
        /// </summary>
        private decimal flexivel;
        [XmlElement(ElementName = "FLEXIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Flexivel
        {
            get { return  flexivel; }
            set {  flexivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEM
        /// Comentário: 
        /// </summary>
        private decimal margem;
        [XmlElement(ElementName = "MARGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Margem
        {
            get { return  margem; }
            set {  margem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFAIXA
        /// Comentário: 
        /// </summary>
        private decimal numfaixa;
        [XmlElement(ElementName = "NUMFAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numfaixa
        {
            get { return  numfaixa; }
            set {  numfaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCBALCAO
        /// Comentário: 
        /// </summary>
        private decimal perdescbalcao;
        [XmlElement(ElementName = "PERDESCBALCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdescbalcao
        {
            get { return  perdescbalcao; }
            set {  perdescbalcao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMargem()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMARGEM";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMargem> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMargem>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMargem> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMargem>(where);
        }

        #endregion
    }
}
