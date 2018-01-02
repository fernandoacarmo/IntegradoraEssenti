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
    /// Classe referente a tabela ESTCarregamentosacerto
    /// </summary>
    [XmlType("ESTCARREGAMENTOSACERTO")]
    public class ESTCarregamentosacerto : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CANHOTOENTREGUE
        /// Comentário: 
        /// </summary>
        private string canhotoentregue;
        [XmlElement(ElementName = "CANHOTOENTREGUE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Canhotoentregue
        {
            get { return  canhotoentregue; }
            set {  canhotoentregue = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOINC
        /// Comentário: 
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
        /// Propriedade referente ao campo: DEVOLVIDO
        /// Comentário: 
        /// </summary>
        private string devolvido;
        [XmlElement(ElementName = "DEVOLVIDO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Devolvido
        {
            get { return  devolvido; }
            set {  devolvido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
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
        /// Propriedade referente ao campo: ENTREGA
        /// Comentário: 
        /// </summary>
        private decimal entrega;
        [XmlElement(ElementName = "ENTREGA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Entrega
        {
            get { return  entrega; }
            set {  entrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARREGAMENTO
        /// Comentário: 
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
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: VLRECEBIDO
        /// Comentário: 
        /// </summary>
        private decimal vlrecebido;
        [XmlElement(ElementName = "VLRECEBIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vlrecebido
        {
            get { return  vlrecebido; }
            set {  vlrecebido = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTCarregamentosacerto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTCARREGAMENTOSACERTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTCarregamentosacerto> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTCarregamentosacerto.GetStringConnection());
            return ba.Listar<ESTCarregamentosacerto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTCarregamentosacerto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTCarregamentosacerto.GetStringConnection());
            return ba.Existe<ESTCarregamentosacerto>(where);
        }

        #endregion
    }
}
