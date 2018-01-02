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
    /// Classe referente a tabela PCFaixasatraso
    /// </summary>
    [XmlType("PCFAIXASATRASO")]
    public class PCFaixasatraso : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAMINHORELATORIO
        /// Comentário: Caminho do arquivo de relatório
        /// </summary>
        private string caminhorelatorio;
        [XmlElement(ElementName = "CAMINHORELATORIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Caminhorelatorio
        {
            get { return  caminhorelatorio; }
            set {  caminhorelatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Código da faixa de atraso
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELORELATORIO
        /// Comentário: Modelo do relatório utilizado
        /// </summary>
        private decimal modelorelatorio;
        [XmlElement(ElementName = "MODELORELATORIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Modelorelatorio
        {
            get { return  modelorelatorio; }
            set {  modelorelatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDMAXIMADIAS
        /// Comentário: Quantidade máxima
        /// </summary>
        private decimal qtdmaximadias;
        [XmlElement(ElementName = "QTDMAXIMADIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtdmaximadias
        {
            get { return  qtdmaximadias; }
            set {  qtdmaximadias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDMINIMADIAS
        /// Comentário: Quantidade mínima
        /// </summary>
        private decimal qtdminimadias;
        [XmlElement(ElementName = "QTDMINIMADIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtdminimadias
        {
            get { return  qtdminimadias; }
            set {  qtdminimadias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOGERACAO
        /// Comentário: Tipo de geração do arquivo
        /// </summary>
        private string tipogeracao;
        [XmlElement(ElementName = "TIPOGERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipogeracao
        {
            get { return  tipogeracao; }
            set {  tipogeracao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFaixasatraso()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFAIXASATRASO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFaixasatraso> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFaixasatraso>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFaixasatraso> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFaixasatraso>(where);
        }

        #endregion
    }
}
