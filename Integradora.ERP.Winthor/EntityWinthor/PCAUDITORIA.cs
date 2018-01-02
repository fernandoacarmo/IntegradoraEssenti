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
    /// Classe referente a tabela PCAuditoria
    /// </summary>
    [XmlType("PCAUDITORIA")]
    public class PCAuditoria : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFINALIZADA
        /// Coment�rio: Indica o c�digo usu�rio respons�vel pela finaliza��o.
        /// </summary>
        private decimal codfuncfinalizada;
        [XmlElement(ElementName = "CODFUNCFINALIZADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfinalizada
        {
            get { return  codfuncfinalizada; }
            set {  codfuncfinalizada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO
        /// Coment�rio: Indica o c�digo do ve�culo.
        /// </summary>
        private decimal codveiculo;
        [XmlElement(ElementName = "CODVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codveiculo
        {
            get { return  codveiculo; }
            set {  codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIVERGENCIA
        /// Coment�rio: Indica data de finalizada com diverg�ncia.
        /// </summary>
        private string divergencia;
        [XmlElement(ElementName = "DIVERGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Divergencia
        {
            get { return  divergencia; }
            set {  divergencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Indiaca a data de cadastro.
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINALIZADA
        /// Coment�rio: Indica a data de finaliza��o.
        /// </summary>
        private DateTime? dtfinalizada;
        [XmlElement(ElementName = "DTFINALIZADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinalizada
        {
            get { return  dtfinalizada; }
            set {  dtfinalizada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAUDITORIA
        /// Coment�rio: Indica o n�mero auditoria por ve�culo.
        /// </summary>
        private decimal numauditoria;
        [XmlElement(ElementName = "NUMAUDITORIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numauditoria
        {
            get { return  numauditoria; }
            set {  numauditoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCONF
        /// Coment�rio: Produtos com Divergencia
        /// </summary>
        private decimal qtconf;
        [XmlElement(ElementName = "QTCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtconf
        {
            get { return  qtconf; }
            set {  qtconf = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAuditoria()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAUDITORIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAuditoria> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAuditoria>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAuditoria> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAuditoria>(where);
        }

        #endregion
    }
}
