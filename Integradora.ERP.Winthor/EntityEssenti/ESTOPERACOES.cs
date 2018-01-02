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
    /// Classe referente a tabela ESTOperacoes
    /// </summary>
    [XmlType("ESTOPERACOES")]
    public class ESTOperacoes : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BONIFICACAO
        /// Coment�rio: 
        /// </summary>
        private string bonificacao;
        [XmlElement(ElementName = "BONIFICACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Bonificacao
        {
            get { return  bonificacao; }
            set {  bonificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBRANCA
        /// Coment�rio: 
        /// </summary>
        private string codcobranca;
        [XmlElement(ElementName = "CODCOBRANCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobranca
        {
            get { return  codcobranca; }
            set {  codcobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERACAO
        /// Coment�rio: 
        /// </summary>
        private decimal codoperacao;
        [XmlElement(ElementName = "CODOPERACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codoperacao
        {
            get { return  codoperacao; }
            set {  codoperacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOUTROERP
        /// Coment�rio: 
        /// </summary>
        private string codoutroerp;
        [XmlElement(ElementName = "CODOUTROERP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codoutroerp
        {
            get { return  codoutroerp; }
            set {  codoutroerp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAGAMENTO
        /// Coment�rio: 
        /// </summary>
        private decimal codpagamento;
        [XmlElement(ElementName = "CODPAGAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpagamento
        {
            get { return  codpagamento; }
            set {  codpagamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOALT
        /// Coment�rio: 
        /// </summary>
        private decimal codusuarioalt;
        [XmlElement(ElementName = "CODUSUARIOALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioalt
        {
            get { return  codusuarioalt; }
            set {  codusuarioalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOEXC
        /// Coment�rio: 
        /// </summary>
        private decimal codusuarioexc;
        [XmlElement(ElementName = "CODUSUARIOEXC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioexc
        {
            get { return  codusuarioexc; }
            set {  codusuarioexc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOINC
        /// Coment�rio: 
        /// </summary>
        private decimal codusuarioinc;
        [XmlElement(ElementName = "CODUSUARIOINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioinc
        {
            get { return  codusuarioinc; }
            set {  codusuarioinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENTREGAFUTURA
        /// Coment�rio: 
        /// </summary>
        private string entregafutura;
        [XmlElement(ElementName = "ENTREGAFUTURA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Entregafutura
        {
            get { return  entregafutura; }
            set {  entregafutura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTOQUE
        /// Coment�rio: 
        /// </summary>
        private string estoque;
        [XmlElement(ElementName = "ESTOQUE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Estoque
        {
            get { return  estoque; }
            set {  estoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FINANCEIRO
        /// Coment�rio: 
        /// </summary>
        private string financeiro;
        [XmlElement(ElementName = "FINANCEIRO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Financeiro
        {
            get { return  financeiro; }
            set {  financeiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOVIMENTO
        /// Coment�rio: 
        /// </summary>
        private string movimento;
        [XmlElement(ElementName = "MOVIMENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Movimento
        {
            get { return  movimento; }
            set {  movimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Coment�rio: 
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIMPLESREMESSA
        /// Coment�rio: 
        /// </summary>
        private string simplesremessa;
        [XmlElement(ElementName = "SIMPLESREMESSA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Simplesremessa
        {
            get { return  simplesremessa; }
            set {  simplesremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSFERENCIA
        /// Coment�rio: 
        /// </summary>
        private string transferencia;
        [XmlElement(ElementName = "TRANSFERENCIA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Transferencia
        {
            get { return  transferencia; }
            set {  transferencia = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public ESTOperacoes()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTOPERACOES";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESTOperacoes> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTOperacoes.GetStringConnection());
            return ba.Listar<ESTOperacoes>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESTOperacoes> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTOperacoes.GetStringConnection());
            return ba.Existe<ESTOperacoes>(where);
        }

        #endregion
    }
}
