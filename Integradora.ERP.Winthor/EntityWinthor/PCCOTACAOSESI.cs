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
    /// Classe referente a tabela PCCotacaosesi
    /// </summary>
    [XmlType("PCCOTACAOSESI")]
    public class PCCotacaosesi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOTACAO
        /// Coment�rio: C�digo da cota��o.
        /// </summary>
        private decimal codcotacao;
        [XmlElement(ElementName = "CODCOTACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codcotacao
        {
            get { return  codcotacao; }
            set {  codcotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: A data em que a cota��o foi excluida do winthor.
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMVALIDADE
        /// Coment�rio: Data final de validade.
        /// </summary>
        private DateTime? dtfimvalidade;
        [XmlElement(ElementName = "DTFIMVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimvalidade
        {
            get { return  dtfimvalidade; }
            set {  dtfimvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINIVALIDADE
        /// Coment�rio: Data de inicio da validade.
        /// </summary>
        private DateTime? dtinivalidade;
        [XmlElement(ElementName = "DTINIVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinivalidade
        {
            get { return  dtinivalidade; }
            set {  dtinivalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIMITE
        /// Coment�rio: Indica a data limite da cota��o.
        /// </summary>
        private DateTime? dtlimite;
        [XmlElement(ElementName = "DTLIMITE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlimite
        {
            get { return  dtlimite; }
            set {  dtlimite = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTRESPOSTA
        /// Coment�rio: Data de resposta da cota��o.
        /// </summary>
        private DateTime? dtresposta;
        [XmlElement(ElementName = "DTRESPOSTA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtresposta
        {
            get { return  dtresposta; }
            set {  dtresposta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORALIMITE
        /// Coment�rio: Hora m�xima que o arquivo pode ser exportado.
        /// </summary>
        private decimal horalimite;
        [XmlElement(ElementName = "HORALIMITE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horalimite
        {
            get { return  horalimite; }
            set {  horalimite = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOLIMITE
        /// Coment�rio: Minuto m�ximo que o arquivo pode ser exportado.
        /// </summary>
        private decimal minutolimite;
        [XmlElement(ElementName = "MINUTOLIMITE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutolimite
        {
            get { return  minutolimite; }
            set {  minutolimite = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCotacaosesi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOTACAOSESI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCotacaosesi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCotacaosesi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCotacaosesi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCotacaosesi>(where);
        }

        #endregion
    }
}
