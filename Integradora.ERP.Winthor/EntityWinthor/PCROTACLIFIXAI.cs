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
    /// Classe referente a tabela PCRotaclifixai
    /// </summary>
    [XmlType("PCROTACLIFIXAI")]
    public class PCRotaclifixai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTAFIXA
        /// Coment�rio: C�digo da rota faixa cliente
        /// </summary>
        private decimal codrotafixa;
        [XmlElement(ElementName = "CODROTAFIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codrotafixa
        {
            get { return  codrotafixa; }
            set {  codrotafixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEMANA
        /// Coment�rio: Dia da semana
        /// </summary>
        private string diasemana;
        [XmlElement(ElementName = "DIASEMANA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diasemana
        {
            get { return  diasemana; }
            set {  diasemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Coment�rio: Hora
        /// </summary>
        private string hora;
        [XmlElement(ElementName = "HORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Coment�rio: M�s do ano
        /// </summary>
        private string mes;
        [XmlElement(ElementName = "MES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: METAVENDA
        /// Coment�rio: Meta de venda
        /// </summary>
        private decimal metavenda;
        [XmlElement(ElementName = "METAVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Metavenda
        {
            get { return  metavenda; }
            set {  metavenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MIN
        /// Coment�rio: Minuto
        /// </summary>
        private string min;
        [XmlElement(ElementName = "MIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Min
        {
            get { return  min; }
            set {  min = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��o do item da rota cadastrada
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEMANA
        /// Coment�rio: Semana do m�s
        /// </summary>
        private string semana;
        [XmlElement(ElementName = "SEMANA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Semana
        {
            get { return  semana; }
            set {  semana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQUENCIA
        /// Coment�rio: Seq��ncia da faixa cadastrada
        /// </summary>
        private decimal sequencia;
        [XmlElement(ElementName = "SEQUENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Sequencia
        {
            get { return  sequencia; }
            set {  sequencia = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRotaclifixai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCROTACLIFIXAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRotaclifixai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRotaclifixai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRotaclifixai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRotaclifixai>(where);
        }

        #endregion
    }
}
