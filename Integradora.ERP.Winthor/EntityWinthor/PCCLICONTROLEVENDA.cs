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
    /// Classe referente a tabela PCClicontrolevenda
    /// </summary>
    [XmlType("PCCLICONTROLEVENDA")]
    public class PCClicontrolevenda : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Cód. Cliente
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOCONTROLEVENDA
        /// Comentário: Cód. Tipo Controle Venda
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
        /// Propriedade referente ao campo: DTVALIDADE
        /// Comentário: Dt. Validade
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidade
        {
            get { return  dtvalidade; }
            set {  dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDOC
        /// Comentário: Número Documento
        /// </summary>
        private string numdoc;
        [XmlElement(ElementName = "NUMDOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numdoc
        {
            get { return  numdoc; }
            set {  numdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Observações
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCClicontrolevenda()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCLICONTROLEVENDA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCClicontrolevenda> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCClicontrolevenda>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCClicontrolevenda> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCClicontrolevenda>(where);
        }

        #endregion
    }
}
