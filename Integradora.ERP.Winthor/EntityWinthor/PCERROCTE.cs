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
    /// Classe referente a tabela PCErrocte
    /// </summary>
    [XmlType("PCERROCTE")]
    public class PCErrocte : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR1
        /// Comentário: Indica o processo com erro 1.
        /// </summary>
        private decimal codauxiliar1;
        [XmlElement(ElementName = "CODAUXILIAR1", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codauxiliar1
        {
            get { return  codauxiliar1; }
            set {  codauxiliar1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR2
        /// Comentário: Indica o processo com erro 2.
        /// </summary>
        private decimal codauxiliar2;
        [XmlElement(ElementName = "CODAUXILIAR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codauxiliar2
        {
            get { return  codauxiliar2; }
            set {  codauxiliar2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR3
        /// Comentário: Indica o processo com erro 3.
        /// </summary>
        private decimal codauxiliar3;
        [XmlElement(ElementName = "CODAUXILIAR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codauxiliar3
        {
            get { return  codauxiliar3; }
            set {  codauxiliar3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMENSAGEM
        /// Comentário: Código Principal do Erro.
        /// </summary>
        private decimal codmensagem;
        [XmlElement(ElementName = "CODMENSAGEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codmensagem
        {
            get { return  codmensagem; }
            set {  codmensagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Comentário: Número da Transação.
        /// </summary>
        private decimal numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransacao
        {
            get { return  numtransacao; }
            set {  numtransacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCErrocte()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCERROCTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCErrocte> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCErrocte>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCErrocte> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCErrocte>(where);
        }

        #endregion
    }
}
