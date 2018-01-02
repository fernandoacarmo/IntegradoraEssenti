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
    /// Classe referente a tabela PCMetaoscomod
    /// </summary>
    [XmlType("PCMETAOSCOMOD")]
    public class PCMetaoscomod : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLIENT
        /// Comentário: Código cliente	Campo para armazenar o código do cliente
        /// </summary>
        private decimal codclient;
        [XmlElement(ElementName = "CODCLIENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codclient
        {
            get { return  codclient; }
            set {  codclient = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUT
        /// Comentário: Código do produto	Campo para armazenar o código do produto
        /// </summary>
        private decimal codprodut;
        [XmlElement(ElementName = "CODPRODUT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codprodut
        {
            get { return  codprodut; }
            set {  codprodut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSERVICO
        /// Comentário: Código do serviço	Campo para armazenar o código do serviço
        /// </summary>
        private decimal codservico;
        [XmlElement(ElementName = "CODSERVICO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codservico
        {
            get { return  codservico; }
            set {  codservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMETA
        /// Comentário: Campo para armazenar o código da meta
        /// </summary>
        private decimal nummeta;
        [XmlElement(ElementName = "NUMMETA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Nummeta
        {
            get { return  nummeta; }
            set {  nummeta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORQTDCLIENTVISITADOS
        /// Comentário: Apurar meta por quantidade de clientes visitados	Campo para armazenar se a meta será apurada por quantidade de clientes visitados (indicador utilizado apenas para a meta por ranking).
        /// </summary>
        private string porqtdclientvisitados;
        [XmlElement(ElementName = "PORQTDCLIENTVISITADOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Porqtdclientvisitados
        {
            get { return  porqtdclientvisitados; }
            set {  porqtdclientvisitados = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDCLIENT
        /// Comentário: Quantidade cliente	Campo para armazenar a quantidade de cliente
        /// </summary>
        private decimal qtdclient;
        [XmlElement(ElementName = "QTDCLIENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Qtdclient
        {
            get { return  qtdclient; }
            set {  qtdclient = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDPRODUT
        /// Comentário: Quantidade produto	Campo para armazenar a quantidade produto
        /// </summary>
        private decimal qtdprodut;
        [XmlElement(ElementName = "QTDPRODUT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Qtdprodut
        {
            get { return  qtdprodut; }
            set {  qtdprodut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDSERVICO
        /// Comentário: Quantidade serviço	Campo para armazenar a quantidade serviço
        /// </summary>
        private decimal qtdservico;
        [XmlElement(ElementName = "QTDSERVICO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Qtdservico
        {
            get { return  qtdservico; }
            set {  qtdservico = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMetaoscomod()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMETAOSCOMOD";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMetaoscomod> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMetaoscomod>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMetaoscomod> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMetaoscomod>(where);
        }

        #endregion
    }
}
