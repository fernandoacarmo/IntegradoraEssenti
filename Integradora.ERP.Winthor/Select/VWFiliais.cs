using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.Select
{
    /// <summary>
    /// Classe referente ao select VWFiliais
    /// </summary>
    [XmlType("VWFILIAIS")]
    public class VWFiliais: OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWFiliais()
        {
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWFiliais> Listar(string where)
        {
            //string filtro = where.ToUpper().Replace("ROWID", "OID");
            Persistencia ba = new Persistencia(VWFiliais.GetStringConnection());
            return ba.Listar<VWFiliais>(GetSelect(), where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWFiliais> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(VWFiliais.GetStringConnection());
            return ba.Existe<VWFiliais>(where);
        }

        /// <summary>
        /// Retorna o select de obteção dos registros
        /// </summary>
        public static string GetSelect()
        {
//            return @"SELECT B.*
//                       FROM (SELECT B.CODIGO
//                                  , B.ROWID OID
//                                  , B.RAZAOSOCIAL
//                                  , 'http://192.168.55.8/Essenti/ServiceTrafego.svc' URLWMSCORPEM
//                                  , 'S' USAWMSCORPEM
//                               FROM PCFILIAL B
//                              WHERE B.CODIGO in ('5','13') AND B.DTEXCLUSAO IS NULL) B
//                      WHERE 1 = 1 ";

            return @"SELECT B.CODIGO
                          , B.ROWID OID
                          , B.RAZAOSOCIAL
                          , B.URLWMSCORPEM
                          , NVL(B.USAWMSCORPEM,'N') USAWMSCORPEM
                          , B.VTEXCODFILIAL
                          , B.VTEXWAREHOUSE
                       FROM PCFILIAL B
                      WHERE B.CODIGO <> '99'
                        AND B.DTEXCLUSAO IS NULL";
        }
        #endregion

        #region Atributos
        /// <summary>
        /// Propriedade referente ao campo: VTEXWAREHOUSE
        /// Comentário: 
        /// </summary>
        private string vtexwarehouse;
        [XmlElement(ElementName = "VTEXWAREHOUSE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 20)]
        public string Vtexwarehouse
        {
            get { return vtexwarehouse; }
            set { vtexwarehouse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VTEXCODFILIAL
        /// Comentário: 
        /// </summary>
        private string vtexcodfilial;
        [XmlElement(ElementName = "VTEXCODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 2)]
        public string Vtexcodfilial
        {
            get { return vtexcodfilial; }
            set { vtexcodfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private string codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 2)]
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAWMSCORPEM
        /// Comentário: 
        /// </summary>
        private string usawmscorpem;
        [XmlElement(ElementName = "USAWMSCORPEM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 1)]
        public string Usawmscorpem
        {
            get { return usawmscorpem; }
            set { usawmscorpem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: URLWMSCORPEM
        /// Comentário: 
        /// </summary>
        private string urlwmscorpem;
        [XmlElement(ElementName = "URLWMSCORPEM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 1)]
        public string Urlwmscorpem
        {
            get { return urlwmscorpem; }
            set { urlwmscorpem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAZAOSOCIAL
        /// Comentário: 
        /// </summary>
        private string razaosocial;
        [XmlElement(ElementName = "RAZAOSOCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 60)]
        public string Razaosocial
        {
            get { return razaosocial; }
            set { razaosocial = value; }
        }
        #endregion
    }
}
