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
    /// Classe referente a tabela PCBrindeexrestricoes
    /// </summary>
    [XmlType("PCBRINDEEXRESTRICOES")]
    public class PCBrindeexrestricoes : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBREX
        /// Comentário: Código da campanha.
        /// </summary>
        private decimal codbrex;
        [XmlElement(ElementName = "CODBREX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codbrex
        {
            get { return  codbrex; }
            set {  codbrex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Código do objeto a ser validado, quando numérico.
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOA
        /// Comentário: Código do objeto a ser validado, quando Alfanumérico.
        /// </summary>
        private string codigoa;
        [XmlElement(ElementName = "CODIGOA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codigoa
        {
            get { return  codigoa; }
            set {  codigoa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOREGRA
        /// Comentário: Código da regra.
        /// </summary>
        private decimal gruporegra;
        [XmlElement(ElementName = "GRUPOREGRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Gruporegra
        {
            get { return  gruporegra; }
            set {  gruporegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Tipo do objeto a ser validado para a restrição, "R"egião, "P"raça, Redes de Clientes "RC", "C"lientes, Cliente Principal "CP", "CL"asse de Venda dos clientes.
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDACAO
        /// Comentário: Tipo de validação para a restrição, "P"roibido ou "E"xclusivo.
        /// </summary>
        private string validacao;
        [XmlElement(ElementName = "VALIDACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Validacao
        {
            get { return  validacao; }
            set {  validacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCBrindeexrestricoes()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBRINDEEXRESTRICOES";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCBrindeexrestricoes> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBrindeexrestricoes>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCBrindeexrestricoes> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBrindeexrestricoes>(where);
        }

        #endregion
    }
}
