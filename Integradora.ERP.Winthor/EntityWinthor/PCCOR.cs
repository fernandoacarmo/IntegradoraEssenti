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
    /// Classe referente a tabela PCCor
    /// </summary>
    [XmlType("PCCOR")]
    public class PCCor : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCOR
        /// Comentário: 
        /// </summary>
        private decimal codcor;
        [XmlElement(ElementName = "CODCOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codcor
        {
            get { return  codcor; }
            set {  codcor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCORDELPHI
        /// Comentário: Código da cor (padrão utilizado pelo Delphi)
        /// </summary>
        private decimal codcordelphi;
        [XmlElement(ElementName = "CODCORDELPHI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Codcordelphi
        {
            get { return  codcordelphi; }
            set {  codcordelphi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CORPANTONE
        /// Comentário: Código internacional de cores Pantone
        /// </summary>
        private string corpantone;
        [XmlElement(ElementName = "CORPANTONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Corpantone
        {
            get { return  corpantone; }
            set {  corpantone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,50)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCor()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOR";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCor> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCor>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCor> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCor>(where);
        }

        #endregion
    }
}
