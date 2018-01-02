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
    /// Classe referente a tabela PCUsuariolicenca
    /// </summary>
    [XmlType("PCUSUARIOLICENCA")]
    public class PCUsuariolicenca : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPERFIL
        /// Comentário: Código do Perfil
        /// </summary>
        private decimal codperfil;
        [XmlElement(ElementName = "CODPERFIL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codperfil
        {
            get { return  codperfil; }
            set {  codperfil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDENTIFICADOR
        /// Comentário: Identificador do device autorizado
        /// </summary>
        private string identificador;
        [XmlElement(ElementName = "IDENTIFICADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Identificador
        {
            get { return  identificador; }
            set {  identificador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAQUINA
        /// Comentário: Dóminio e máquina do usuário
        /// </summary>
        private string maquina;
        [XmlElement(ElementName = "MAQUINA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,60)]
        public string Maquina
        {
            get { return  maquina; }
            set {  maquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOID
        /// Comentário: Identificador do usuário
        /// </summary>
        private string usuarioid;
        [XmlElement(ElementName = "USUARIOID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,32)]
        public string Usuarioid
        {
            get { return  usuarioid; }
            set {  usuarioid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOOS
        /// Comentário: Usuário logado no windows
        /// </summary>
        private string usuarioos;
        [XmlElement(ElementName = "USUARIOOS", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,60)]
        public string Usuarioos
        {
            get { return  usuarioos; }
            set {  usuarioos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOWINTHOR
        /// Comentário: Código do usuário no WinThor
        /// </summary>
        private decimal usuariowinthor;
        [XmlElement(ElementName = "USUARIOWINTHOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Usuariowinthor
        {
            get { return  usuariowinthor; }
            set {  usuariowinthor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCUsuariolicenca()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCUSUARIOLICENCA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCUsuariolicenca> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCUsuariolicenca>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCUsuariolicenca> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCUsuariolicenca>(where);
        }

        #endregion
    }
}
