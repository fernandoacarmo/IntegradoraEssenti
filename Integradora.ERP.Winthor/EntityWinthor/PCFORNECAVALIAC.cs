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
    /// Classe referente a tabela PCFornecavaliac
    /// </summary>
    [XmlType("PCFORNECAVALIAC")]
    public class PCFornecavaliac : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAVALIACAO
        /// Comentário: Indica o código da avaliação.
        /// </summary>
        private decimal codavaliacao;
        [XmlElement(ElementName = "CODAVALIACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codavaliacao
        {
            get { return  codavaliacao; }
            set {  codavaliacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: Indica o código do fornencedor.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Comentário: Indica o código do avaliador.
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAVALIACAO
        /// Comentário: Indica a data da avaliação.
        /// </summary>
        private DateTime? dtavaliacao;
        [XmlElement(ElementName = "DTAVALIACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtavaliacao
        {
            get { return  dtavaliacao; }
            set {  dtavaliacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCOMPRA
        /// Comentário: Indica a data da compra avaliada.
        /// </summary>
        private DateTime? dtcompra;
        [XmlElement(ElementName = "DTCOMPRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcompra
        {
            get { return  dtcompra; }
            set {  dtcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: Indica a observação da avaliação.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFornecavaliac()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFORNECAVALIAC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFornecavaliac> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFornecavaliac>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFornecavaliac> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFornecavaliac>(where);
        }

        #endregion
    }
}
