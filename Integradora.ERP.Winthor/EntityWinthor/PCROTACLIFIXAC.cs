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
    /// Classe referente a tabela PCRotaclifixac
    /// </summary>
    [XmlType("PCROTACLIFIXAC")]
    public class PCRotaclifixac : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXCLUSAO
        /// Coment�rio: C�digo do funcion�rio que excluiu a rota
        /// </summary>
        private decimal codfuncexclusao;
        [XmlElement(ElementName = "CODFUNCEXCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncexclusao
        {
            get { return  codfuncexclusao; }
            set {  codfuncexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTAFIXA
        /// Coment�rio: C�digo rota faixa de visitas
        /// </summary>
        private decimal codrotafixa;
        [XmlElement(ElementName = "CODROTAFIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codrotafixa
        {
            get { return  codrotafixa; }
            set {  codrotafixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: RCA da rota faixa
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o da rota faixa de clientes
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: Data exclus�o
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
        /// Propriedade referente ao campo: DTFINAL
        /// Coment�rio: Data final da vig�ncia da rota
        /// </summary>
        private DateTime? dtfinal;
        [XmlElement(ElementName = "DTFINAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtfinal
        {
            get { return  dtfinal; }
            set {  dtfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Coment�rio: Data in�cio da vig�ncia da rota
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRotaclifixac()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCROTACLIFIXAC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRotaclifixac> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRotaclifixac>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRotaclifixac> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRotaclifixac>(where);
        }

        #endregion
    }
}
