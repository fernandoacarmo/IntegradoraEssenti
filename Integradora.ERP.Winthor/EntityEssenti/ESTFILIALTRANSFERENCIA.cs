using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTFilialtransferencia
    /// </summary>
    [XmlType("ESTFILIALTRANSFERENCIA")]
    public class ESTFilialtransferencia : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALDESTINO
        /// Comentário: 
        /// </summary>
        private string codfilialdestino;
        [XmlElement(ElementName = "CODFILIALDESTINO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilialdestino
        {
            get { return  codfilialdestino; }
            set {  codfilialdestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALORIGEM
        /// Comentário: 
        /// </summary>
        private string codfilialorigem;
        [XmlElement(ElementName = "CODFILIALORIGEM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilialorigem
        {
            get { return  codfilialorigem; }
            set {  codfilialorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIAS
        /// Comentário: 
        /// </summary>
        private decimal numdias;
        [XmlElement(ElementName = "NUMDIAS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public decimal Numdias
        {
            get { return  numdias; }
            set {  numdias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRCPONTOREPOSICAO
        /// Comentário: 
        /// </summary>
        private decimal prcpontoreposicao;
        [XmlElement(ElementName = "PRCPONTOREPOSICAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Prcpontoreposicao
        {
            get { return  prcpontoreposicao; }
            set {  prcpontoreposicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRCTRANSFENCIA
        /// Comentário: 
        /// </summary>
        private decimal prctransfencia;
        [XmlElement(ElementName = "PRCTRANSFENCIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Prctransfencia
        {
            get { return  prctransfencia; }
            set {  prctransfencia = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTFilialtransferencia()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTFILIALTRANSFERENCIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTFilialtransferencia> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTFilialtransferencia.GetStringConnection());
            return ba.Listar<ESTFilialtransferencia>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTFilialtransferencia> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTFilialtransferencia.GetStringConnection());
            return ba.Existe<ESTFilialtransferencia>(where);
        }

        #endregion
    }
}
