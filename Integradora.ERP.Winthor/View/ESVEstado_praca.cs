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
    /// Classe referente ao select ESVEstado_praca
    /// </summary>
    [XmlType("ESVESTADO_PRACA")]
    class ESVEstado_praca : OracleView
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESVEstado_praca()
        {
        }

        /// <summary>
        /// Obter nome da view
        /// </summary>
        public override string GetViewName()
        {
            return "ESVESTADO_PRACA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESVEstado_praca> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<ESVEstado_praca>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESVEstado_praca> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESVEstado_praca.GetStringConnection());
            return ba.Existe<ESVEstado_praca>(where);
        }
        #endregion

        #region Atributos
        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Comentário: 
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 2)]
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 4)]
        public decimal Codpraca
        {
            get { return codpraca; }
            set { codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: 
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 4)]
        public decimal Numregiao
        {
            get { return numregiao; }
            set { numregiao = value; }
        }


        #endregion
    }
}
