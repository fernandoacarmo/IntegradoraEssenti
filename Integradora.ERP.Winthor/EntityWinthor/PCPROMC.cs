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
    /// Classe referente a tabela PCPromc
    /// </summary>
    [XmlType("PCPROMC")]
    public class PCPromc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BRINDEGRATIS
        /// Comentário: Forma com que o brinde será oferecido
        /// </summary>
        private string brindegratis;
        [XmlElement(ElementName = "BRINDEGRATIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Brindegratis
        {
            get { return  brindegratis; }
            set {  brindegratis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSEVENDA
        /// Comentário: Restringir uma campanha a uma determinada classe de venda
        /// </summary>
        private string classevenda;
        [XmlElement(ElementName = "CLASSEVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Classevenda
        {
            get { return  classevenda; }
            set {  classevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODATIV
        /// Comentário: 
        /// </summary>
        private decimal codativ;
        [XmlElement(ElementName = "CODATIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codativ
        {
            get { return  codativ; }
            set {  codativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Código Auxiliar Embalagem
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPORCA
        /// Comentário: Código do grupo por RCA
        /// </summary>
        private decimal codgruporca;
        [XmlElement(ElementName = "CODGRUPORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codgruporca
        {
            get { return  codgruporca; }
            set {  codgruporca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROPRINC
        /// Comentário: Código da campanha principal. Permite agrupar varias campanhas a uma só.
        /// </summary>
        private decimal codproprinc;
        [XmlElement(ElementName = "CODPROPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codproprinc
        {
            get { return  codproprinc; }
            set {  codproprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: 
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Comentário: Indica o código do supervisor.
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Comentário: 
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINATIVACAO
        /// Comentário: Data de Inativação de registro
        /// </summary>
        private DateTime? dtinativacao;
        [XmlElement(ElementName = "DTINATIVACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinativacao
        {
            get { return  dtinativacao; }
            set {  dtinativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOCAMPANHA
        /// Comentário: 
        /// </summary>
        private decimal grupocampanha;
        [XmlElement(ElementName = "GRUPOCAMPANHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Grupocampanha
        {
            get { return  grupocampanha; }
            set {  grupocampanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MULTIPLO
        /// Comentário: 
        /// </summary>
        private string multiplo;
        [XmlElement(ElementName = "MULTIPLO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Multiplo
        {
            get { return  multiplo; }
            set {  multiplo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: Indica o número da região
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVERBA
        /// Comentário: 
        /// </summary>
        private decimal numverba;
        [XmlElement(ElementName = "NUMVERBA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numverba
        {
            get { return  numverba; }
            set {  numverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBRIGAVENDAMIX
        /// Comentário: Indica se obriga venda de todo o mix em campanha.
        /// </summary>
        private string obrigavendamix;
        [XmlElement(ElementName = "OBRIGAVENDAMIX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Obrigavendamix
        {
            get { return  obrigavendamix; }
            set {  obrigavendamix = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Indica a observação. 
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
        /// Propriedade referente ao campo: OBS1
        /// Comentário: 
        /// </summary>
        private string obs1;
        [XmlElement(ElementName = "OBS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs1
        {
            get { return  obs1; }
            set {  obs1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Comentário: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS3
        /// Comentário: 
        /// </summary>
        private string obs3;
        [XmlElement(ElementName = "OBS3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Obs3
        {
            get { return  obs3; }
            set {  obs3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODUTOPRINC
        /// Comentário: 
        /// </summary>
        private string produtoprinc;
        [XmlElement(ElementName = "PRODUTOPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Produtoprinc
        {
            get { return  produtoprinc; }
            set {  produtoprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBRINDE
        /// Comentário: Indica a quantidade de brinde. 
        /// </summary>
        private decimal qtbrinde;
        [XmlElement(ElementName = "QTBRINDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtbrinde
        {
            get { return  qtbrinde; }
            set {  qtbrinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLIMITEBRINDE
        /// Comentário: Campo para armazenar a quantidade limite para o brinde, com o objetivo de servir como limitador adicional para término de campanhas
        /// </summary>
        private decimal qtlimitebrinde;
        [XmlElement(ElementName = "QTLIMITEBRINDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtlimitebrinde
        {
            get { return  qtlimitebrinde; }
            set {  qtlimitebrinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIN
        /// Comentário: Quantidade mínima.
        /// </summary>
        private decimal qtmin;
        [XmlElement(ElementName = "QTMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmin
        {
            get { return  qtmin; }
            set {  qtmin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTOTVENDA
        /// Comentário: 
        /// </summary>
        private decimal qttotvenda;
        [XmlElement(ElementName = "QTTOTVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qttotvenda
        {
            get { return  qttotvenda; }
            set {  qttotvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRICAOQTMIN
        /// Comentário: Quantidade mínima.
        /// </summary>
        private decimal restricaoqtmin;
        [XmlElement(ElementName = "RESTRICAOQTMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Restricaoqtmin
        {
            get { return  restricaoqtmin; }
            set {  restricaoqtmin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRICAOVALORMIN
        /// Comentário: Restrição valor mínimo.
        /// </summary>
        private decimal restricaovalormin;
        [XmlElement(ElementName = "RESTRICAOVALORMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Restricaovalormin
        {
            get { return  restricaovalormin; }
            set {  restricaovalormin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: Ativo e Inativo
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOAPURACAO
        /// Comentário: 
        /// </summary>
        private string tipoapuracao;
        [XmlElement(ElementName = "TIPOAPURACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoapuracao
        {
            get { return  tipoapuracao; }
            set {  tipoapuracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCAMPANHA
        /// Comentário: 
        /// </summary>
        private string tipocampanha;
        [XmlElement(ElementName = "TIPOCAMPANHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipocampanha
        {
            get { return  tipocampanha; }
            set {  tipocampanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTOTALPRODPRINC
        /// Comentário: 
        /// </summary>
        private string tipototalprodprinc;
        [XmlElement(ElementName = "TIPOTOTALPRODPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipototalprodprinc
        {
            get { return  tipototalprodprinc; }
            set {  tipototalprodprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADEBCREDRCABRIND
        /// Comentário: Movimentar contar corrente do RCA
        /// </summary>
        private string usadebcredrcabrind;
        [XmlElement(ElementName = "USADEBCREDRCABRIND", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadebcredrcabrind
        {
            get { return  usadebcredrcabrind; }
            set {  usadebcredrcabrind = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USURINATIVACAO
        /// Comentário: Usuário responsável pela inativação
        /// </summary>
        private decimal usurinativacao;
        [XmlElement(ElementName = "USURINATIVACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Usurinativacao
        {
            get { return  usurinativacao; }
            set {  usurinativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAAUTOSERVICO
        /// Comentário: Indica se utiliza auto serviço.
        /// </summary>
        private string utilizaautoservico;
        [XmlElement(ElementName = "UTILIZAAUTOSERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaautoservico
        {
            get { return  utilizaautoservico; }
            set {  utilizaautoservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VARIOSBRINDE
        /// Comentário: 
        /// </summary>
        private string variosbrinde;
        [XmlElement(ElementName = "VARIOSBRINDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Variosbrinde
        {
            get { return  variosbrinde; }
            set {  variosbrinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTVENDA
        /// Comentário: 
        /// </summary>
        private decimal vltotvenda;
        [XmlElement(ElementName = "VLTOTVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltotvenda
        {
            get { return  vltotvenda; }
            set {  vltotvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTVENDAMAX
        /// Comentário: Valor máximo de total de venda
        /// </summary>
        private decimal vltotvendamax;
        [XmlElement(ElementName = "VLTOTVENDAMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltotvendamax
        {
            get { return  vltotvendamax; }
            set {  vltotvendamax = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPromc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPROMC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPromc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPromc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPromc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPromc>(where);
        }

        #endregion
    }
}
