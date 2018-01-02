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
    /// Classe referente a tabela PCModelocc
    /// </summary>
    [XmlType("PCMODELOCC")]
    public class PCModelocc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCENTROCUSTO
        /// Comentário: 
        /// </summary>
        private decimal codcentrocusto;
        [XmlElement(ElementName = "CODCENTROCUSTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public decimal Codcentrocusto
        {
            get { return  codcentrocusto; }
            set {  codcentrocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA_CC
        /// Comentário: 
        /// </summary>
        private string codconta_cc;
        [XmlElement(ElementName = "CODCONTA_CC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public string Codconta_Cc
        {
            get { return  codconta_cc; }
            set {  codconta_cc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDUZIDO_CC
        /// Comentário: 
        /// </summary>
        private string codreduzido_cc;
        [XmlElement(ElementName = "CODREDUZIDO_CC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public string Codreduzido_Cc
        {
            get { return  codreduzido_cc; }
            set {  codreduzido_cc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME_CONTA
        /// Comentário: 
        /// </summary>
        private string nome_conta;
        [XmlElement(ElementName = "NOME_CONTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,50)]
        public string Nome_Conta
        {
            get { return  nome_conta; }
            set {  nome_conta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECEBE_LANCTO
        /// Comentário: 
        /// </summary>
        private string recebe_lancto;
        [XmlElement(ElementName = "RECEBE_LANCTO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Recebe_Lancto
        {
            get { return  recebe_lancto; }
            set {  recebe_lancto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ULT_CODREDUZIDO
        /// Comentário: 
        /// </summary>
        private decimal ult_codreduzido;
        [XmlElement(ElementName = "ULT_CODREDUZIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Ult_Codreduzido
        {
            get { return  ult_codreduzido; }
            set {  ult_codreduzido = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCModelocc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMODELOCC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCModelocc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCModelocc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCModelocc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCModelocc>(where);
        }

        #endregion
    }
}
