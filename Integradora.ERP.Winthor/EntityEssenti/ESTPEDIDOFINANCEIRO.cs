using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTPedidofinanceiro
    /// </summary>
    [XmlType("ESTPEDIDOFINANCEIRO")]
    public class ESTPedidofinanceiro : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BOLETOQUITADO
        /// Comentário: 
        /// </summary>
        private string boletoquitado;
        [XmlElement(ElementName = "BOLETOQUITADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 1)]
        public string Boletoquitado
        {
            get { return boletoquitado; }
            set { boletoquitado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOINC
        /// Comentário: 
        /// </summary>
        private decimal codusuarioinc;
        [XmlElement(ElementName = "CODUSUARIOINC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 8)]
        public decimal Codusuarioinc
        {
            get { return codusuarioinc; }
            set { codusuarioinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtinclusao
        {
            get { return dtinclusao; }
            set { dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMAPAGTO
        /// Comentário: 
        /// </summary>
        private string formapagto;
        [XmlElement(ElementName = "FORMAPAGTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 1)]
        public string Formapagto
        {
            get { return formapagto; }
            set { formapagto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 10)]
        public decimal Numped
        {
            get { return numped; }
            set { numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Comentário: 
        /// </summary>
        private decimal? numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 10)]
        public decimal? Numtransacao
        {
            get { return numtransacao; }
            set { numtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Comentário: 
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string Prest
        {
            get { return prest; }
            set { prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUMRECEITA
        /// Comentário: 
        /// </summary>
        private decimal? recnumreceita;
        [XmlElement(ElementName = "RECNUMRECEITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal? Recnumreceita
        {
            get { return recnumreceita; }
            set { recnumreceita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLUTILIZADO
        /// Comentário: 
        /// </summary>
        private decimal vlutilizado;
        [XmlElement(ElementName = "VLUTILIZADO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Vlutilizado
        {
            get { return vlutilizado; }
            set { vlutilizado = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTPedidofinanceiro()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTPEDIDOFINANCEIRO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTPedidofinanceiro> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTPedidofinanceiro.GetStringConnection());
            return ba.Listar<ESTPedidofinanceiro>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTPedidofinanceiro> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTPedidofinanceiro.GetStringConnection());
            return ba.Existe<ESTPedidofinanceiro>(where);
        }

        #endregion
    }
}
