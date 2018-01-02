using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a tabela Esv_Pedidos_Cesta
    /// </summary>
    [XmlType("ESVESTOQUEDISPONIVEL")]
    public class EsvEstoqueDisponivel : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 6)]
        public decimal Codprod
        {
            get { return codprod; }
            set { codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Comentário: 
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 50)]
        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELO
        /// Comentário: 
        /// </summary>
        private string modelo;
        [XmlElement(ElementName = "MODELO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 50)]
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIAL
        /// Comentário: 
        /// </summary>
        private string serial;
        [XmlElement(ElementName = "SERIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 50)]
        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFABRICACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtfabricacao;
        [XmlElement(ElementName = "DTFABRICACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtfabricacao
        {
            get { return dtfabricacao; }
            set { dtfabricacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Comentário: 
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtvalidade
        {
            get { return dtvalidade; }
            set { dtvalidade = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: NUMAJURI
        /// Comentário: 
        /// </summary>
        private string numajuri;
        [XmlElement(ElementName = "NUMAJURI", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 30)]
        public string Numajuri
        {
            get { return numajuri; }
            set { numajuri = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 15)]
        public string Numlote
        {
            get { return numlote; }
            set { numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSALDO
        /// Comentário: 
        /// </summary>
        private decimal qtsaldo;
        [XmlElement(ElementName = "QTSALDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Qtsaldo
        {
            get { return qtsaldo; }
            set { qtsaldo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public EsvEstoqueDisponivel()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVESTOQUEDISPONIVEL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<EsvEstoqueDisponivel> Listar(string where)
        {
            Persistencia ba = new Persistencia(EsvEstoqueDisponivel.GetStringConnection());
            return ba.Listar<EsvEstoqueDisponivel>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<EsvEstoqueDisponivel> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(EsvEstoqueDisponivel.GetStringConnection());
            return ba.Existe<EsvEstoqueDisponivel>(where);
        }

        #endregion
    }

}
