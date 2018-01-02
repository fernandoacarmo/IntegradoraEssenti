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
    /// Classe referente a tabela PCNfdeclararc
    /// </summary>
    [XmlType("PCNFDECLARARC")]
    public class PCNfdeclararc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: Ano referente a apresentação do danfe.
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVE
        /// Comentário: Chave NF-e.
        /// </summary>
        private string chave;
        [XmlElement(ElementName = "CHAVE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Chave
        {
            get { return  chave; }
            set {  chave = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial.
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
        /// Propriedade referente ao campo: CODREGISTRO
        /// Comentário: Codigo único para cada registro.
        /// </summary>
        private decimal codregistro;
        [XmlElement(ElementName = "CODREGISTRO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codregistro
        {
            get { return  codregistro; }
            set {  codregistro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAIMPORTACAO
        /// Comentário: Data da geração do registro.
        /// </summary>
        private DateTime? dataimportacao;
        [XmlElement(ElementName = "DATAIMPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataimportacao
        {
            get { return  dataimportacao; }
            set {  dataimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAO
        /// Comentário: Data de inclusão do registro.
        /// </summary>
        private DateTime? dtimportacao;
        [XmlElement(ElementName = "DTIMPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacao
        {
            get { return  dtimportacao; }
            set {  dtimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IE
        /// Comentário: Inscrição estadual.
        /// </summary>
        private string ie;
        [XmlElement(ElementName = "IE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Ie
        {
            get { return  ie; }
            set {  ie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Comentário: Mês referente a apresentação do danfe.
        /// </summary>
        private decimal mes;
        [XmlElement(ElementName = "MES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORDEM
        /// Comentário: Ordem da nota na lista.
        /// </summary>
        private decimal numordem;
        [XmlElement(ElementName = "NUMORDEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numordem
        {
            get { return  numordem; }
            set {  numordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEM
        /// Comentário: Origem do registro, se veio do XML ou se foi incluído pelo usuário.
        /// </summary>
        private string origem;
        [XmlElement(ElementName = "ORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origem
        {
            get { return  origem; }
            set {  origem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECONHECENF
        /// Comentário: Reconhecimento da Nfe importada.
        /// </summary>
        private string reconhecenf;
        [XmlElement(ElementName = "RECONHECENF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reconhecenf
        {
            get { return  reconhecenf; }
            set {  reconhecenf = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCNfdeclararc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNFDECLARARC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCNfdeclararc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNfdeclararc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCNfdeclararc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNfdeclararc>(where);
        }

        #endregion
    }
}
