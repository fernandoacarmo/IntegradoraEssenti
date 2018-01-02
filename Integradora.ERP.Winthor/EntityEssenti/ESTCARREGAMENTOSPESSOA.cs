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
    /// Classe referente a tabela ESTCarregamentospessoa
    /// </summary>
    [XmlType("ESTCARREGAMENTOSPESSOA")]
    public class ESTCarregamentospessoa : OracleTable
    {
        #region Atributos

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
        /// Propriedade referente ao campo: NUMCARREGAMENTO
        /// Coment�rio: 
        /// </summary>
        private decimal numcarregamento;
        [XmlElement(ElementName = "NUMCARREGAMENTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numcarregamento
        {
            get { return  numcarregamento; }
            set {  numcarregamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCOLABORADOR
        /// Coment�rio: 
        /// </summary>
        private decimal numcolaborador;
        [XmlElement(ElementName = "NUMCOLABORADOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcolaborador
        {
            get { return  numcolaborador; }
            set {  numcolaborador = value; }
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

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public ESTCarregamentospessoa()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTCARREGAMENTOSPESSOA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESTCarregamentospessoa> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTCarregamentospessoa.GetStringConnection());
            return ba.Listar<ESTCarregamentospessoa>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESTCarregamentospessoa> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTCarregamentospessoa.GetStringConnection());
            return ba.Existe<ESTCarregamentospessoa>(where);
        }

        #endregion
    }
}
