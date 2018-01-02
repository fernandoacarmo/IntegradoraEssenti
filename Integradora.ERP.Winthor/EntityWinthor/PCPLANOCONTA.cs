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
    /// Classe referente a tabela PCPlanoconta
    /// </summary>
    [XmlType("PCPLANOCONTA")]
    public class PCPlanoconta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTASINTETICACLIENTE
        /// Comentário: Indica a conta sintética cliente.
        /// </summary>
        private string codcontasinteticacliente;
        [XmlElement(ElementName = "CODCONTASINTETICACLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codcontasinteticacliente
        {
            get { return  codcontasinteticacliente; }
            set {  codcontasinteticacliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTASINTETICAFORNEC
        /// Comentário: Indica grupo de fornecedores no plano de contas do contábil, para fins de integração e utilização da rotina 2124. 
        /// </summary>
        private string codcontasinteticafornec;
        [XmlElement(ElementName = "CODCONTASINTETICAFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codcontasinteticafornec
        {
            get { return  codcontasinteticafornec; }
            set {  codcontasinteticafornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTASINTETICARCA
        /// Comentário: Código da Conta Contábil Sintética do RCA
        /// </summary>
        private string codcontasinteticarca;
        [XmlElement(ElementName = "CODCONTASINTETICARCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codcontasinteticarca
        {
            get { return  codcontasinteticarca; }
            set {  codcontasinteticarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Comentário: 
        /// </summary>
        private decimal codplanoconta;
        [XmlElement(ElementName = "CODPLANOCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public decimal Codplanoconta
        {
            get { return  codplanoconta; }
            set {  codplanoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTALUCRO
        /// Comentário: 
        /// </summary>
        private string contalucro;
        [XmlElement(ElementName = "CONTALUCRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Contalucro
        {
            get { return  contalucro; }
            set {  contalucro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAPREJUIZO
        /// Comentário: 
        /// </summary>
        private string contaprejuizo;
        [XmlElement(ElementName = "CONTAPREJUIZO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Contaprejuizo
        {
            get { return  contaprejuizo; }
            set {  contaprejuizo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTARESULTADO
        /// Comentário: 
        /// </summary>
        private string contaresultado;
        [XmlElement(ElementName = "CONTARESULTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Contaresultado
        {
            get { return  contaresultado; }
            set {  contaresultado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MASCARA
        /// Comentário: 
        /// </summary>
        private string mascara;
        [XmlElement(ElementName = "MASCARA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Mascara
        {
            get { return  mascara; }
            set {  mascara = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVEL_ATIVO
        /// Comentário: 
        /// </summary>
        private string nivel_ativo;
        [XmlElement(ElementName = "NIVEL_ATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Nivel_Ativo
        {
            get { return  nivel_ativo; }
            set {  nivel_ativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVEL_CUSTO
        /// Comentário: 
        /// </summary>
        private string nivel_custo;
        [XmlElement(ElementName = "NIVEL_CUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Nivel_Custo
        {
            get { return  nivel_custo; }
            set {  nivel_custo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVEL_DESPESA
        /// Comentário: 
        /// </summary>
        private string nivel_despesa;
        [XmlElement(ElementName = "NIVEL_DESPESA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Nivel_Despesa
        {
            get { return  nivel_despesa; }
            set {  nivel_despesa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVEL_PASSIVO
        /// Comentário: 
        /// </summary>
        private string nivel_passivo;
        [XmlElement(ElementName = "NIVEL_PASSIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Nivel_Passivo
        {
            get { return  nivel_passivo; }
            set {  nivel_passivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVEL_RECEITA
        /// Comentário: 
        /// </summary>
        private string nivel_receita;
        [XmlElement(ElementName = "NIVEL_RECEITA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Nivel_Receita
        {
            get { return  nivel_receita; }
            set {  nivel_receita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME_PLANOCONTA
        /// Comentário: 
        /// </summary>
        private string nome_planoconta;
        [XmlElement(ElementName = "NOME_PLANOCONTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,50)]
        public string Nome_Planoconta
        {
            get { return  nome_planoconta; }
            set {  nome_planoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TODACONTARECEBELANCTO
        /// Comentário: 
        /// </summary>
        private string todacontarecebelancto;
        [XmlElement(ElementName = "TODACONTARECEBELANCTO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Todacontarecebelancto
        {
            get { return  todacontarecebelancto; }
            set {  todacontarecebelancto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZA_PLANOCONTASPED
        /// Comentário: Indica se utiliza o plano de contas referencial.
        /// </summary>
        private string utiliza_planocontasped;
        [XmlElement(ElementName = "UTILIZA_PLANOCONTASPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utiliza_Planocontasped
        {
            get { return  utiliza_planocontasped; }
            set {  utiliza_planocontasped = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPlanoconta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPLANOCONTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPlanoconta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPlanoconta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPlanoconta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPlanoconta>(where);
        }

        #endregion
    }
}
