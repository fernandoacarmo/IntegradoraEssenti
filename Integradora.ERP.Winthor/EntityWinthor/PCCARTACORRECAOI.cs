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
    /// Classe referente a tabela PCCartacorrecaoi
    /// </summary>
    [XmlType("PCCARTACORRECAOI")]
    public class PCCartacorrecaoi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAMPOALTERADO
        /// Comentário: Nome do campo modificado.
        /// </summary>
        private string campoalterado;
        [XmlElement(ElementName = "CAMPOALTERADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Campoalterado
        {
            get { return  campoalterado; }
            set {  campoalterado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOCORRECAO
        /// Comentário: 
        /// </summary>
        private string descricaocorrecao;
        [XmlElement(ElementName = "DESCRICAOCORRECAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1000)]
        public string Descricaocorrecao
        {
            get { return  descricaocorrecao; }
            set {  descricaocorrecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOITEMCORRECAO
        /// Comentário: 
        /// </summary>
        private string descricaoitemcorrecao;
        [XmlElement(ElementName = "DESCRICAOITEMCORRECAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,100)]
        public string Descricaoitemcorrecao
        {
            get { return  descricaoitemcorrecao; }
            set {  descricaoitemcorrecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOALTERADO
        /// Comentário: Grupo de informações alteradas
        /// </summary>
        private string grupoalterado;
        [XmlElement(ElementName = "GRUPOALTERADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Grupoalterado
        {
            get { return  grupoalterado; }
            set {  grupoalterado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDITEMCORRECAO
        /// Comentário: 
        /// </summary>
        private decimal iditemcorrecao;
        [XmlElement(ElementName = "IDITEMCORRECAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public decimal Iditemcorrecao
        {
            get { return  iditemcorrecao; }
            set {  iditemcorrecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARTACORRECAO
        /// Comentário: 
        /// </summary>
        private decimal numcartacorrecao;
        [XmlElement(ElementName = "NUMCARTACORRECAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numcartacorrecao
        {
            get { return  numcartacorrecao; }
            set {  numcartacorrecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMITEMALTERADO
        /// Comentário: Indice do item alterado.
        /// </summary>
        private string numitemalterado;
        [XmlElement(ElementName = "NUMITEMALTERADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Numitemalterado
        {
            get { return  numitemalterado; }
            set {  numitemalterado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORALTERADO
        /// Comentário: Valor da alteração
        /// </summary>
        private string valoralterado;
        [XmlElement(ElementName = "VALORALTERADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1500)]
        public string Valoralterado
        {
            get { return  valoralterado; }
            set {  valoralterado = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCartacorrecaoi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCARTACORRECAOI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCartacorrecaoi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCartacorrecaoi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCartacorrecaoi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCartacorrecaoi>(where);
        }

        #endregion
    }
}
