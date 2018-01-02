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
    /// Classe referente a tabela PCClireffv
    /// </summary>
    [XmlType("PCCLIREFFV")]
    public class PCClireffv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CGCCLI
        /// Comentário: cgc/Cpf do cliente
        /// </summary>
        private string cgccli;
        [XmlElement(ElementName = "CGCCLI", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,18)]
        public string Cgccli
        {
            get { return  cgccli; }
            set {  cgccli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Codigo do cliente
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBREFER
        /// Comentário: Codigo de cobrança
        /// </summary>
        private string codcobrefer;
        [XmlElement(ElementName = "CODCOBREFER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobrefer
        {
            get { return  codcobrefer; }
            set {  codcobrefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREF
        /// Comentário: sequencial para referencia por cliente
        /// </summary>
        private decimal codref;
        [XmlElement(ElementName = "CODREF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Codref
        {
            get { return  codref; }
            set {  codref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATOREFER
        /// Comentário: Contato da referencia
        /// </summary>
        private string contatorefer;
        [XmlElement(ElementName = "CONTATOREFER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Contatorefer
        {
            get { return  contatorefer; }
            set {  contatorefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTROREFER
        /// Comentário: Data de cadastro da referencia
        /// </summary>
        private DateTime? dtcadastrorefer;
        [XmlElement(ElementName = "DTCADASTROREFER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastrorefer
        {
            get { return  dtcadastrorefer; }
            set {  dtcadastrorefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: Data de inclusão do registro na tabela
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTMAIORCOMPREFER
        /// Comentário: Data da maior compra
        /// </summary>
        private DateTime? dtmaiorcomprefer;
        [XmlElement(ElementName = "DTMAIORCOMPREFER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtmaiorcomprefer
        {
            get { return  dtmaiorcomprefer; }
            set {  dtmaiorcomprefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCOMPREFER
        /// Comentário: Data da ultima compra
        /// </summary>
        private DateTime? dtultcomprefer;
        [XmlElement(ElementName = "DTULTCOMPREFER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultcomprefer
        {
            get { return  dtultcomprefer; }
            set {  dtultcomprefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMPREFER
        /// Comentário: nome da referencia
        /// </summary>
        private string emprefer;
        [XmlElement(ElementName = "EMPREFER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Emprefer
        {
            get { return  emprefer; }
            set {  emprefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Comentário: Flag de importação do pedido
        /// </summary>
        private decimal importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMCREDREFER
        /// Comentário: Limite de credito
        /// </summary>
        private decimal limcredrefer;
        [XmlElement(ElementName = "LIMCREDREFER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Limcredrefer
        {
            get { return  limcredrefer; }
            set {  limcredrefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: Observação
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO_PC
        /// Comentário: Mensagem de retorno da package
        /// </summary>
        private string observacao_pc;
        [XmlElement(ElementName = "OBSERVACAO_PC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Observacao_Pc
        {
            get { return  observacao_pc; }
            set {  observacao_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELREFER
        /// Comentário: Telefone da referencia
        /// </summary>
        private string telrefer;
        [XmlElement(ElementName = "TELREFER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Telrefer
        {
            get { return  telrefer; }
            set {  telrefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAIORCOMPREFER
        /// Comentário: Valor da maior compra
        /// </summary>
        private decimal vlmaiorcomprefer;
        [XmlElement(ElementName = "VLMAIORCOMPREFER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmaiorcomprefer
        {
            get { return  vlmaiorcomprefer; }
            set {  vlmaiorcomprefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLULTCOMPREFER
        /// Comentário: Valor da ultima compra
        /// </summary>
        private decimal vlultcomprefer;
        [XmlElement(ElementName = "VLULTCOMPREFER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlultcomprefer
        {
            get { return  vlultcomprefer; }
            set {  vlultcomprefer = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCClireffv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCLIREFFV";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCClireffv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCClireffv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCClireffv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCClireffv>(where);
        }

        #endregion
    }
}
