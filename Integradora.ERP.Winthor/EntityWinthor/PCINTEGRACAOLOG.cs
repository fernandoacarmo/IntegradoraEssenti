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
    /// Classe referente a tabela PCIntegracaolog
    /// </summary>
    [XmlType("PCINTEGRACAOLOG")]
    public class PCIntegracaolog : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLOG
        /// Comentário: Funcionário logado na rotina.
        /// </summary>
        private decimal codfunclog;
        [XmlElement(ElementName = "CODFUNCLOG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codfunclog
        {
            get { return  codfunclog; }
            set {  codfunclog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATALOG
        /// Comentário: Data e hora da tentativa de importação.
        /// </summary>
        private DateTime? datalog;
        [XmlElement(ElementName = "DATALOG", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Datalog
        {
            get { return  datalog; }
            set {  datalog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDENTIFICACAO
        /// Comentário: Texto com dados que identifiquem o registro que não foi importado (notadamente, a chave primária, se houver).
        /// </summary>
        private string identificacao;
        [XmlElement(ElementName = "IDENTIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Identificacao
        {
            get { return  identificacao; }
            set {  identificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Motivo da rejeição.
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
        /// Propriedade referente ao campo: TABELA
        /// Comentário: Tabela a qual pertence o registro rejeitado.
        /// </summary>
        private string tabela;
        [XmlElement(ElementName = "TABELA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Tabela
        {
            get { return  tabela; }
            set {  tabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Tipo de log (E-Erro, A-Aviso).
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCIntegracaolog()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINTEGRACAOLOG";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCIntegracaolog> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCIntegracaolog>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCIntegracaolog> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCIntegracaolog>(where);
        }

        #endregion
    }
}
