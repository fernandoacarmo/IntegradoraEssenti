using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
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
    /// Classe referente a tabela Esvconcluidowms
    /// </summary>
    [XmlType("ESVSTATUSDOCUMENTO_SAIDA")]
    public class ESVStatusDocumento_Saida : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: NUMAJURI
        /// Comentário: 
        /// </summary>
        private string numajuri;
        [XmlElement(ElementName = "NUMAJURI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Numajuri
        {
            get { return numajuri; }
            set { numajuri = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDOCUMENTO
        /// Comentário: 
        /// </summary>
        private string numdocumento;
        [XmlElement(ElementName = "NUMDOCUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public string Numdocumento
        {
            get { return numdocumento; }
            set { numdocumento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESVStatusDocumento_Saida()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVSTATUSDOCUMENTO_SAIDA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESVStatusDocumento_Saida> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESVStatusDocumento_Saida.GetStringConnection());
            return ba.Listar<ESVStatusDocumento_Saida>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESVStatusDocumento_Saida> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESVStatusDocumento_Saida.GetStringConnection());
            return ba.Existe<ESVStatusDocumento_Saida>(where);
        }

        #endregion
    }
}

