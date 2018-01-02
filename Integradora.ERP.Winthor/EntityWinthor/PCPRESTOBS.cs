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
    /// Classe referente a tabela PCPrestobs
    /// </summary>
    [XmlType("PCPRESTOBS")]
    public class PCPrestobs : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: Número da transação de venda.
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSACERTO
        /// Comentário:  Observações de acerto.
        /// </summary>
        private string obsacerto;
        [XmlElement(ElementName = "OBSACERTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Obsacerto
        {
            get { return  obsacerto; }
            set {  obsacerto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSGERAIS
        /// Comentário: Observações Cadastradas pelo Usuário.
        /// </summary>
        private string obsgerais;
        [XmlElement(ElementName = "OBSGERAIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Obsgerais
        {
            get { return  obsgerais; }
            set {  obsgerais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PENDENCIA
        /// Comentário: Título tem pendência?
        /// </summary>
        private string pendencia;
        [XmlElement(ElementName = "PENDENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pendencia
        {
            get { return  pendencia; }
            set {  pendencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Comentário: Parcela do título.
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPrestobs()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRESTOBS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPrestobs> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrestobs>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPrestobs> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrestobs>(where);
        }

        #endregion
    }
}
