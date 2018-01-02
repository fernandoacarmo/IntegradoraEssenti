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
    /// Classe referente a tabela PCDesdrecebimentofv
    /// </summary>
    [XmlType("PCDESDRECEBIMENTOFV")]
    public class PCDesdrecebimentofv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DESDOBRAMENTOEFETUADO
        /// Coment�rio: INDICA SE O DESDOBRAMENTO FOI APLICADO NA PCPREST (S = SIM, N=NAO)
        /// </summary>
        private string desdobramentoefetuado;
        [XmlElement(ElementName = "DESDOBRAMENTOEFETUADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Desdobramentoefetuado
        {
            get { return  desdobramentoefetuado; }
            set {  desdobramentoefetuado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA_PCPREST
        /// Coment�rio: N�mero transa��o de venda do t�tulo no contas a receber
        /// </summary>
        private decimal numtransvenda_pcprest;
        [XmlElement(ElementName = "NUMTRANSVENDA_PCPREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda_Pcprest
        {
            get { return  numtransvenda_pcprest; }
            set {  numtransvenda_pcprest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA_PCRECEBIMENTOFV
        /// Coment�rio: N�mero transa��o de venda no recebimento do for�a de vendas
        /// </summary>
        private decimal numtransvenda_pcrecebimentofv;
        [XmlElement(ElementName = "NUMTRANSVENDA_PCRECEBIMENTOFV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda_Pcrecebimentofv
        {
            get { return  numtransvenda_pcrecebimentofv; }
            set {  numtransvenda_pcrecebimentofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST_PCPREST
        /// Coment�rio: Presta��o do t�tulo no contas a receber
        /// </summary>
        private string prest_pcprest;
        [XmlElement(ElementName = "PREST_PCPREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Prest_Pcprest
        {
            get { return  prest_pcprest; }
            set {  prest_pcprest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST_PCRECEBIMENTOFV
        /// Coment�rio: Presta��o do t�tulo no recebimento do for�a de vendas
        /// </summary>
        private string prest_pcrecebimentofv;
        [XmlElement(ElementName = "PREST_PCRECEBIMENTOFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Prest_Pcrecebimentofv
        {
            get { return  prest_pcrecebimentofv; }
            set {  prest_pcrecebimentofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQUENCIAL_DESDOBRAMENTO
        /// Coment�rio: CODIGO DE IDENTICA��O (SEQUENCIAL) DA OPERA��O, SE FOI ENVOLVIDO VARIOS TITULOS, TODOS ELES DEVEM TER O MESMO IDENTIFICADOR.
        /// </summary>
        private decimal sequencial_desdobramento;
        [XmlElement(ElementName = "SEQUENCIAL_DESDOBRAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Sequencial_Desdobramento
        {
            get { return  sequencial_desdobramento; }
            set {  sequencial_desdobramento = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDesdrecebimentofv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESDRECEBIMENTOFV";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDesdrecebimentofv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDesdrecebimentofv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDesdrecebimentofv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDesdrecebimentofv>(where);
        }

        #endregion
    }
}
