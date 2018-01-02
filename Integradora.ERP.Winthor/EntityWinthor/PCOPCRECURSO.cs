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
    /// Classe referente a tabela PCOpcrecurso
    /// </summary>
    [XmlType("PCOPCRECURSO")]
    public class PCOpcrecurso : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODETAPA
        /// Coment�rio: C�digo da etapa utilizada na produ��o.
        /// </summary>
        private decimal codetapa;
        [XmlElement(ElementName = "CODETAPA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codetapa
        {
            get { return  codetapa; }
            set {  codetapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial da produ��o.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPREVISTO
        /// Coment�rio: Custo dos recursos Previstos.
        /// </summary>
        private decimal custoprevisto;
        [XmlElement(ElementName = "CUSTOPREVISTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoprevisto
        {
            get { return  custoprevisto; }
            set {  custoprevisto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALIZADO
        /// Coment�rio: Custo dos recursos Realizados.
        /// </summary>
        private decimal custorealizado;
        [XmlElement(ElementName = "CUSTOREALIZADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealizado
        {
            get { return  custorealizado; }
            set {  custorealizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDRECURSO
        /// Coment�rio: C�digo do Recurso utilizado na etapa.
        /// </summary>
        private decimal idrecurso;
        [XmlElement(ElementName = "IDRECURSO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Idrecurso
        {
            get { return  idrecurso; }
            set {  idrecurso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOP
        /// Coment�rio: N�mero da Ordem de Produ��o.
        /// </summary>
        private decimal numop;
        [XmlElement(ElementName = "NUMOP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numop
        {
            get { return  numop; }
            set {  numop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPREVISTA
        /// Coment�rio: Quantidade de Recursos Prevista.
        /// </summary>
        private decimal qtprevista;
        [XmlElement(ElementName = "QTPREVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtprevista
        {
            get { return  qtprevista; }
            set {  qtprevista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTREALIZADA
        /// Coment�rio: Quantidade de Recursos Realizados.
        /// </summary>
        private decimal qtrealizada;
        [XmlElement(ElementName = "QTREALIZADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtrealizada
        {
            get { return  qtrealizada; }
            set {  qtrealizada = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCOpcrecurso()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCOPCRECURSO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOpcrecurso> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOpcrecurso>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCOpcrecurso> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOpcrecurso>(where);
        }

        #endregion
    }
}
