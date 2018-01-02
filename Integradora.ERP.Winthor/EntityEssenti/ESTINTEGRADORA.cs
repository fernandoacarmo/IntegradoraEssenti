using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTMarketplace
    /// </summary>
    [XmlType("ESTINTEGRADORA")]
    public class ESTIntegradora: OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: INTEGRADORA
        /// Comentário: 
        /// </summary>
        private string integradora;
        [XmlElement(ElementName = "INTEGRADORA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,30)]
        public string Integradora
        {
            get { return  integradora; }
            set {  integradora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROCESSAMENTO
        /// Comentário: 
        /// </summary>
        private DateTime dtprocessamento;
        [XmlElement(ElementName = "DTPROCESSAMENTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime Dtprocessamento
        {
            get { return dtprocessamento; }
            set { dtprocessamento = value; }
        }


        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTIntegradora()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTINTEGRADORA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTIntegradora> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTIntegradora.GetStringConnection());
            return ba.Listar<ESTIntegradora>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTIntegradora> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTIntegradora.GetStringConnection());
            return ba.Existe<ESTIntegradora>(where);
        }

        public static void Notificar(string nomeIntegradora)
        {
            try
            {
                string script = string.Format(@"BEGIN
                                                  BEGIN
                                                    INSERT INTO ESTINTEGRADORA (INTEGRADORA, DTPROCESSAMENTO)
                                                          VALUES ('{0}', SYSDATE);
                                                  EXCEPTION
                                                  WHEN DUP_VAL_ON_INDEX THEN
                                                    UPDATE ESTINTEGRADORA
                                                       SET DTPROCESSAMENTO = SYSDATE
                                                     WHERE INTEGRADORA = '{0}';
                                                  END;
                                                END;  ", nomeIntegradora.ToUpper());

                Persistencia ba = new Persistencia(ESTIntegradora.GetStringConnection());
                ba.Executar(script);
            }
            catch (Exception ex)
            {
                Biblioteca.Tools.Logs.GerarLog("Integradora.ERP.Winthor", "Notificar", "Erro ao gravar status da integradora: " + ex.ToString());
            }
        }
        #endregion
    }
}
