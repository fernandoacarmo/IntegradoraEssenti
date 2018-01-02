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
    /// Classe referente a tabela PCCotacaomoedac
    /// </summary>
    [XmlType("PCCOTACAOMOEDAC")]
    public class PCCotacaomoedac : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAIS
        /// Comentário: Código do Pais
        /// </summary>
        private decimal codpais;
        [XmlElement(ElementName = "CODPAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpais
        {
            get { return  codpais; }
            set {  codpais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSISCOMEX
        /// Comentário: Código SISCOMEX da Moeda.
        /// </summary>
        private decimal codsiscomex;
        [XmlElement(ElementName = "CODSISCOMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codsiscomex
        {
            get { return  codsiscomex; }
            set {  codsiscomex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: Data da Exclusão
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
        /// Propriedade referente ao campo: MOEDA
        /// Comentário: 
        /// </summary>
        private string moeda;
        [XmlElement(ElementName = "MOEDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Moeda
        {
            get { return  moeda; }
            set {  moeda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAIS
        /// Comentário: 
        /// </summary>
        private string pais;
        [XmlElement(ElementName = "PAIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Pais
        {
            get { return  pais; }
            set {  pais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIMBOLO
        /// Comentário:  Símbolo da moeda. Ex.: US$.
        /// </summary>
        private string simbolo;
        [XmlElement(ElementName = "SIMBOLO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Simbolo
        {
            get { return  simbolo; }
            set {  simbolo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONVERSAO
        /// Comentário: Tipo de Conversão
        /// </summary>
        private string tipoconversao;
        [XmlElement(ElementName = "TIPOCONVERSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoconversao
        {
            get { return  tipoconversao; }
            set {  tipoconversao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCotacaomoedac()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOTACAOMOEDAC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCotacaomoedac> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCotacaomoedac>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCotacaomoedac> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCotacaomoedac>(where);
        }

        #endregion
    }
}
