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
    /// Classe referente a tabela PCSolicitacaomaterial
    /// </summary>
    [XmlType("PCSOLICITACAOMATERIAL")]
    public class PCSolicitacaomaterial : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAPROVAREJEITA
        /// Comentário: Funcionário Aprovação ou Rejeição
        /// </summary>
        private decimal codfuncaprovarejeita;
        [XmlElement(ElementName = "CODFUNCAPROVAREJEITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncaprovarejeita
        {
            get { return  codfuncaprovarejeita; }
            set {  codfuncaprovarejeita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCBENEFICIADO
        /// Comentário: Funcionário Beneficiado
        /// </summary>
        private decimal codfuncbeneficiado;
        [XmlElement(ElementName = "CODFUNCBENEFICIADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncbeneficiado
        {
            get { return  codfuncbeneficiado; }
            set {  codfuncbeneficiado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCSOLICITANTE
        /// Comentário: Funcionário Solicitante
        /// </summary>
        private decimal codfuncsolicitante;
        [XmlElement(ElementName = "CODFUNCSOLICITANTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncsolicitante
        {
            get { return  codfuncsolicitante; }
            set {  codfuncsolicitante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAAPROVACAO
        /// Comentário: Data da Aprovação da Solicitação
        /// </summary>
        private DateTime? dataaprovacao;
        [XmlElement(ElementName = "DATAAPROVACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataaprovacao
        {
            get { return  dataaprovacao; }
            set {  dataaprovacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACRIACAO
        /// Comentário: Data da Criação da Solicitação
        /// </summary>
        private DateTime? datacriacao;
        [XmlElement(ElementName = "DATACRIACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacriacao
        {
            get { return  datacriacao; }
            set {  datacriacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAREJEICAO
        /// Comentário: Data da Rejeição da Solicitação
        /// </summary>
        private DateTime? datarejeicao;
        [XmlElement(ElementName = "DATAREJEICAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datarejeicao
        {
            get { return  datarejeicao; }
            set {  datarejeicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Comentário: Motivo da Solicitação
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Motivo
        {
            get { return  motivo; }
            set {  motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROSOLICITACAO
        /// Comentário: Número da Solicitação
        /// </summary>
        private decimal numerosolicitacao;
        [XmlElement(ElementName = "NUMEROSOLICITACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numerosolicitacao
        {
            get { return  numerosolicitacao; }
            set {  numerosolicitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: Status da Solicitação
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCSolicitacaomaterial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSOLICITACAOMATERIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSolicitacaomaterial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSolicitacaomaterial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSolicitacaomaterial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSolicitacaomaterial>(where);
        }

        #endregion
    }
}
