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
    /// Classe referente a tabela PCCidade
    /// </summary>
    [XmlType("PCCIDADE")]
    public class PCCidade : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADE
        /// Comentário: 
        /// </summary>
        private decimal codcidade;
        [XmlElement(ElementName = "CODCIDADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcidade
        {
            get { return  codcidade; }
            set {  codcidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIBGE
        /// Comentário: 
        /// </summary>
        private decimal codibge;
        [XmlElement(ElementName = "CODIBGE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codibge
        {
            get { return  codibge; }
            set {  codibge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMUNESTADUAL
        /// Comentário: Indica o código do município no estado.
        /// </summary>
        private decimal codmunestadual;
        [XmlElement(ElementName = "CODMUNESTADUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmunestadual
        {
            get { return  codmunestadual; }
            set {  codmunestadual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECIDADE
        /// Comentário: 
        /// </summary>
        private string nomecidade;
        [XmlElement(ElementName = "NOMECIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Nomecidade
        {
            get { return  nomecidade; }
            set {  nomecidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POPULACAO
        /// Comentário: Indica o numero de habitantes da cidade.
        /// </summary>
        private decimal populacao;
        [XmlElement(ElementName = "POPULACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Populacao
        {
            get { return  populacao; }
            set {  populacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Comentário: 
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCidade()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCIDADE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCidade> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCidade>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCidade> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCidade>(where);
        }

        #endregion
    }
}
