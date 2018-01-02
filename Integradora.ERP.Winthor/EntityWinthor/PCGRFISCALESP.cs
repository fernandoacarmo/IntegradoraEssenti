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
    /// Classe referente a tabela PCGrfiscalesp
    /// </summary>
    [XmlType("PCGRFISCALESP")]
    public class PCGrfiscalesp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODRELATORIO
        /// Comentário: CÓDIGO DO RELATORIO
        /// </summary>
        private decimal codrelatorio;
        [XmlElement(ElementName = "CODRELATORIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codrelatorio
        {
            get { return  codrelatorio; }
            set {  codrelatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEM
        /// Comentário: ORDENAÇÃO DOS CAMPOS(ORDER BY)
        /// </summary>
        private string ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMOV
        /// Comentário: TIPO DE MOVIMENTAÇÃO(E-ENTRADA, S-SAÍDA)
        /// </summary>
        private string tipomov;
        [XmlElement(ElementName = "TIPOMOV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipomov
        {
            get { return  tipomov; }
            set {  tipomov = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TITULO
        /// Comentário: TITULO DO RELATORIO
        /// </summary>
        private string titulo;
        [XmlElement(ElementName = "TITULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Titulo
        {
            get { return  titulo; }
            set {  titulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VINCULO
        /// Comentário: Vincular entrada a ultima entrada ou metodo PEPS
        /// </summary>
        private string vinculo;
        [XmlElement(ElementName = "VINCULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vinculo
        {
            get { return  vinculo; }
            set {  vinculo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCGrfiscalesp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCGRFISCALESP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCGrfiscalesp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCGrfiscalesp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCGrfiscalesp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCGrfiscalesp>(where);
        }

        #endregion
    }
}
