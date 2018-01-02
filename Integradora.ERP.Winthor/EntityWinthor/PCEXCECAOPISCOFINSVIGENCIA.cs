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
    /// Classe referente a tabela PCExcecaopiscofinsvigencia
    /// </summary>
    [XmlType("PCEXCECAOPISCOFINSVIGENCIA")]
    public class PCExcecaopiscofinsvigencia : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEXCECAO
        /// Comentário: Código Exceção
        /// </summary>
        private decimal codexcecao;
        [XmlElement(ElementName = "CODEXCECAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codexcecao
        {
            get { return  codexcecao; }
            set {  codexcecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEXCFIGTRIB
        /// Comentário: C?digo da Exceção da Figura Tributária.
        /// </summary>
        private decimal codexcfigtrib;
        [XmlElement(ElementName = "CODEXCFIGTRIB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codexcfigtrib
        {
            get { return  codexcfigtrib; }
            set {  codexcfigtrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBPISCOFINS
        /// Comentário: Código Tribut. PIS/COFINS
        /// </summary>
        private decimal codtribpiscofins;
        [XmlElement(ElementName = "CODTRIBPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codtribpiscofins
        {
            get { return  codtribpiscofins; }
            set {  codtribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINAL
        /// Comentário: Data final de vingência
        /// </summary>
        private DateTime? dtfinal;
        [XmlElement(ElementName = "DTFINAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtfinal
        {
            get { return  dtfinal; }
            set {  dtfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: Data inicial de vingência
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Tipo ST
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO2
        /// Comentário: Segundo Tipo
        /// </summary>
        private string tipo2;
        [XmlElement(ElementName = "TIPO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Tipo2
        {
            get { return  tipo2; }
            set {  tipo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO3
        /// Comentário: Terceiro Tipo
        /// </summary>
        private string tipo3;
        [XmlElement(ElementName = "TIPO3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Tipo3
        {
            get { return  tipo3; }
            set {  tipo3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: Valor Excessão PIS/COFINS
        /// </summary>
        private string valor;
        [XmlElement(ElementName = "VALOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR2
        /// Comentário: Segundo Valor
        /// </summary>
        private string valor2;
        [XmlElement(ElementName = "VALOR2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Valor2
        {
            get { return  valor2; }
            set {  valor2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR3
        /// Comentário: Terceiro Valor
        /// </summary>
        private string valor3;
        [XmlElement(ElementName = "VALOR3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Valor3
        {
            get { return  valor3; }
            set {  valor3 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCExcecaopiscofinsvigencia()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEXCECAOPISCOFINSVIGENCIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCExcecaopiscofinsvigencia> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCExcecaopiscofinsvigencia>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCExcecaopiscofinsvigencia> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCExcecaopiscofinsvigencia>(where);
        }

        #endregion
    }
}
