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
    /// Classe referente a tabela PCTipocontrolevenda
    /// </summary>
    [XmlType("PCTIPOCONTROLEVENDA")]
    public class PCTipocontrolevenda : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOCONTROLEVENDA
        /// Comentário: Código
        /// </summary>
        private decimal codtipocontrolevenda;
        [XmlElement(ElementName = "CODTIPOCONTROLEVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Codtipocontrolevenda
        {
            get { return  codtipocontrolevenda; }
            set {  codtipocontrolevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRITICADTVALIDADE
        /// Comentário: Critica a Data de Validade
        /// </summary>
        private string criticadtvalidade;
        [XmlElement(ElementName = "CRITICADTVALIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Criticadtvalidade
        {
            get { return  criticadtvalidade; }
            set {  criticadtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRITICANUMDOC
        /// Comentário: Critica o Número do Documento
        /// </summary>
        private string criticanumdoc;
        [XmlElement(ElementName = "CRITICANUMDOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Criticanumdoc
        {
            get { return  criticanumdoc; }
            set {  criticanumdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALIDACAO
        /// Comentário: Tipo de Validação (1 - Recusar Item; 2 - Gravar Pedido como Bloqueado)
        /// </summary>
        private string tipovalidacao;
        [XmlElement(ElementName = "TIPOVALIDACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalidacao
        {
            get { return  tipovalidacao; }
            set {  tipovalidacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTipocontrolevenda()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTIPOCONTROLEVENDA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTipocontrolevenda> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTipocontrolevenda>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTipocontrolevenda> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTipocontrolevenda>(where);
        }

        #endregion
    }
}
