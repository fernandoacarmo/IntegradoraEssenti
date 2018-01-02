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
    /// Classe referente a tabela PCLancprev
    /// </summary>
    [XmlType("PCLANCPREV")]
    public class PCLancprev : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Comentário: 
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPARCEIRO
        /// Comentário: Código do parceiro do lançamento.
        /// </summary>
        private decimal codparceiro;
        [XmlElement(ElementName = "CODPARCEIRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codparceiro
        {
            get { return  codparceiro; }
            set {  codparceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIA
        /// Comentário: 
        /// </summary>
        private decimal dia;
        [XmlElement(ElementName = "DIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Dia
        {
            get { return  dia; }
            set {  dia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Comentário: 
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO2
        /// Comentário: 
        /// </summary>
        private string historico2;
        [XmlElement(ElementName = "HISTORICO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Historico2
        {
            get { return  historico2; }
            set {  historico2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLANCPREV
        /// Comentário: 
        /// </summary>
        private decimal numlancprev;
        [XmlElement(ElementName = "NUMLANCPREV", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numlancprev
        {
            get { return  numlancprev; }
            set {  numlancprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPARCEIRO
        /// Comentário: Tipo do parceiro do lançamento.
        /// </summary>
        private string tipoparceiro;
        [XmlElement(ElementName = "TIPOPARCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoparceiro
        {
            get { return  tipoparceiro; }
            set {  tipoparceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPREV
        /// Comentário: 
        /// </summary>
        private decimal vlprev;
        [XmlElement(ElementName = "VLPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlprev
        {
            get { return  vlprev; }
            set {  vlprev = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLancprev()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLANCPREV";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLancprev> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLancprev>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLancprev> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLancprev>(where);
        }

        #endregion
    }
}
