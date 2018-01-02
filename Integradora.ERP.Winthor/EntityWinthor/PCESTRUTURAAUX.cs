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
    /// Classe referente a tabela PCEstruturaaux
    /// </summary>
    [XmlType("PCESTRUTURAAUX")]
    public class PCEstruturaaux : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA
        /// Coment�rio: 
        /// </summary>
        private decimal codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public decimal Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODESTRUTURAAUX
        /// Coment�rio: 
        /// </summary>
        private decimal codestruturaaux;
        [XmlElement(ElementName = "CODESTRUTURAAUX", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codestruturaaux
        {
            get { return  codestruturaaux; }
            set {  codestruturaaux = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Coment�rio: N�mero da O.S.
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: Indica o n�mero do pedido da OS do carrinho.
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESO
        /// Coment�rio: Peso suportado pela estrutura.
        /// </summary>
        private decimal peso;
        [XmlElement(ElementName = "PESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Peso
        {
            get { return  peso; }
            set {  peso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: Situa��o da estrutura
        /// </summary>
        private decimal situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUME
        /// Coment�rio: 
        /// </summary>
        private decimal volume;
        [XmlElement(ElementName = "VOLUME", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public decimal Volume
        {
            get { return  volume; }
            set {  volume = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEstruturaaux()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCESTRUTURAAUX";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEstruturaaux> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEstruturaaux>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEstruturaaux> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEstruturaaux>(where);
        }

        #endregion
    }
}
