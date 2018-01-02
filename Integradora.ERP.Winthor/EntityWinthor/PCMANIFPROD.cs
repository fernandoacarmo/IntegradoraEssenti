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
    /// Classe referente a tabela PCManifprod
    /// </summary>
    [XmlType("PCMANIFPROD")]
    public class PCManifprod : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Comentário: Código do Motorista
        /// </summary>
        private decimal codmotorista;
        [XmlElement(ElementName = "CODMOTORISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmotorista
        {
            get { return  codmotorista; }
            set {  codmotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Número de sequencia da Manifestação.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRCA
        /// Comentário: Código do Rca
        /// </summary>
        private decimal codrca;
        [XmlElement(ElementName = "CODRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrca
        {
            get { return  codrca; }
            set {  codrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRANSPORTADOR
        /// Comentário: Código do Transportador
        /// </summary>
        private decimal codtransportador;
        [XmlElement(ElementName = "CODTRANSPORTADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codtransportador
        {
            get { return  codtransportador; }
            set {  codtransportador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMANIF
        /// Comentário: Código de produto incluido em uma Manifestação.
        /// </summary>
        private decimal nummanif;
        [XmlElement(ElementName = "NUMMANIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Nummanif
        {
            get { return  nummanif; }
            set {  nummanif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: Numero da Nota
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: Número da Manifestação à qual a seleção de produtos pertence.
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRECLAMADA
        /// Comentário: Indica a quantidade reclamada/avaria informada pelo cliente.
        /// </summary>
        private decimal qtreclamada;
        [XmlElement(ElementName = "QTRECLAMADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtreclamada
        {
            get { return  qtreclamada; }
            set {  qtreclamada = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCManifprod()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMANIFPROD";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCManifprod> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCManifprod>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCManifprod> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCManifprod>(where);
        }

        #endregion
    }
}
