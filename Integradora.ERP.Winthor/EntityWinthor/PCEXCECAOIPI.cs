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
    /// Classe referente a tabela PCExcecaoipi
    /// </summary>
    [XmlType("PCEXCECAOIPI")]
    public class PCExcecaoipi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEXCECAO
        /// Coment�rio: Gravar o c�digo da exce��o inclusa
        /// </summary>
        private decimal codexcecao;
        [XmlElement(ElementName = "CODEXCECAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codexcecao
        {
            get { return  codexcecao; }
            set {  codexcecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFIGURAIPI
        /// Coment�rio: C�digo da figura que est� relacionada
        /// </summary>
        private decimal codfiguraipi;
        [XmlElement(ElementName = "CODFIGURAIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiguraipi
        {
            get { return  codfiguraipi; }
            set {  codfiguraipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFIGURAIPIEXCECAO
        /// Coment�rio: C�digo da figura que ser� redirecionado
        /// </summary>
        private decimal codfiguraipiexcecao;
        [XmlElement(ElementName = "CODFIGURAIPIEXCECAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiguraipiexcecao
        {
            get { return  codfiguraipiexcecao; }
            set {  codfiguraipiexcecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO1
        /// Coment�rio: Cliente Suframa: O usu�rio escolher� se o cliente ser� cliente Suframa ou n�o: "Sim" / "N�o"
        /// </summary>
        private string tipo1;
        [XmlElement(ElementName = "TIPO1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipo1
        {
            get { return  tipo1; }
            set {  tipo1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO2
        /// Coment�rio: Cliente Suframa: O usu�rio escolher� se o cliente ser� cliente Suframa ou n�o: "Sim" / "N�o"
        /// </summary>
        private string tipo2;
        [XmlElement(ElementName = "TIPO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipo2
        {
            get { return  tipo2; }
            set {  tipo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR1
        /// Coment�rio: Produto importado: O usu�rio escolher� se o produto tratado na exce��o ser importando ou n�o. Dominio: "Sim" / "N�o"
        /// </summary>
        private string valor1;
        [XmlElement(ElementName = "VALOR1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Valor1
        {
            get { return  valor1; }
            set {  valor1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR2
        /// Coment�rio: Produto importado: O usu�rio escolher� se o produto tratado na exce��o ser importando ou n�o. Dominio: "Sim" / "N�o"
        /// </summary>
        private string valor2;
        [XmlElement(ElementName = "VALOR2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Valor2
        {
            get { return  valor2; }
            set {  valor2 = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCExcecaoipi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEXCECAOIPI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCExcecaoipi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCExcecaoipi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCExcecaoipi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCExcecaoipi>(where);
        }

        #endregion
    }
}
