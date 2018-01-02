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
    /// Classe referente a tabela PCFormulai
    /// </summary>
    [XmlType("PCFORMULAI")]
    public class PCFormulai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTROLE
        /// Comentário: Campo para identificar qual controle, pertencente a rotina, utiliza a fórmula. |Campo do tipo numérico, de tamanho 6, sem casas decimais.
        /// </summary>
        private decimal codcontrole;
        [XmlElement(ElementName = "CODCONTROLE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcontrole
        {
            get { return  codcontrole; }
            set {  codcontrole = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORMULA
        /// Comentário: Campo para identificar a fórmula a ser utilizada. |Campo do tipo numérico, de tamanho 10, sem casas decimais.
        /// </summary>
        private decimal codformula;
        [XmlElement(ElementName = "CODFORMULA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codformula
        {
            get { return  codformula; }
            set {  codformula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Campo para identificar qual rotina utiliza a fórmula. |Campo do tipo numérico, de tamanho 6, sem casas decimais.
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: Indica se o registro está "A - Ativo" ou "I - Inativo".  |Campo do tipo caracter, de tamanho 32.
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFormulai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFORMULAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFormulai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFormulai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFormulai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFormulai>(where);
        }

        #endregion
    }
}
