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
    /// Classe referente a tabela PCConexos
    /// </summary>
    [XmlType("PCCONEXOS")]
    public class PCConexos : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPEDIDO
        /// Comentário: Indica o código do pedido.
        /// </summary>
        private decimal codpedido;
        [XmlElement(ElementName = "CODPEDIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Codpedido
        {
            get { return  codpedido; }
            set {  codpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROCESSO
        /// Comentário: Indica o código do processo.
        /// </summary>
        private decimal codprocesso;
        [XmlElement(ElementName = "CODPROCESSO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Codprocesso
        {
            get { return  codprocesso; }
            set {  codprocesso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Indica o código do produto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: Indica a data do registro/processamento.
        /// </summary>
        private string data;
        [XmlElement(ElementName = "DATA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public string Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Comentário: Indica a hora do registro/processamento.
        /// </summary>
        private string hora;
        [XmlElement(ElementName = "HORA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public string Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: Indica a quantidade.
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFEXTPROCESSO
        /// Comentário: Indica o referencia externa processo.
        /// </summary>
        private string refextprocesso;
        [XmlElement(ElementName = "REFEXTPROCESSO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Refextprocesso
        {
            get { return  refextprocesso; }
            set {  refextprocesso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Indica o tipo do registro.
        /// </summary>
        private decimal tipo;
        [XmlElement(ElementName = "TIPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VUNIT
        /// Comentário: Indica o valor unitário.
        /// </summary>
        private decimal vunit;
        [XmlElement(ElementName = "VUNIT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public decimal Vunit
        {
            get { return  vunit; }
            set {  vunit = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCConexos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONEXOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConexos> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConexos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCConexos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConexos>(where);
        }

        #endregion
    }
}
