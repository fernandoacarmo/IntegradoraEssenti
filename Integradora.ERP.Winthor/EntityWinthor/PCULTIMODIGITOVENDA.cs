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
    /// Classe referente a tabela PCUltimodigitovenda
    /// </summary>
    [XmlType("PCULTIMODIGITOVENDA")]
    public class PCUltimodigitovenda : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DIGITOATUAL
        /// Comentário: Este dígito será substituido pelo dígito novo nos preços das embalagens.
        /// </summary>
        private decimal digitoatual;
        [XmlElement(ElementName = "DIGITOATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Digitoatual
        {
            get { return  digitoatual; }
            set {  digitoatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIGITONOVO
        /// Comentário: Este dígito substituirá o dígito original nos preços das sembalagens.
        /// </summary>
        private decimal digitonovo;
        [XmlElement(ElementName = "DIGITONOVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Digitonovo
        {
            get { return  digitonovo; }
            set {  digitonovo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPROXDIGITO
        /// Comentário: Este parâmetro é utilizado para informar se para chegar no novo dígito será incrementado ou decrementado o valor original, ou seja, o valor será alterado para mais ou para menos.
        /// </summary>
        private string tipoproxdigito;
        [XmlElement(ElementName = "TIPOPROXDIGITO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoproxdigito
        {
            get { return  tipoproxdigito; }
            set {  tipoproxdigito = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCUltimodigitovenda()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCULTIMODIGITOVENDA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCUltimodigitovenda> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCUltimodigitovenda>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCUltimodigitovenda> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCUltimodigitovenda>(where);
        }

        #endregion
    }
}
