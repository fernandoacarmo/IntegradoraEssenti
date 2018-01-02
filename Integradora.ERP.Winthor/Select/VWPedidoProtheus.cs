using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.Select
{
    /// <summary>
    /// Classe referente ao select VWPedidoProtheus
    /// </summary>
    [XmlType("VWPEDIDOPROTHEUS")]
    public class VWPedidoProtheus: OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWPedidoProtheus()
        {
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWPedidoProtheus> Listar(string where)
        {
            Persistencia ba = new Persistencia(VWPedidoProtheus.GetStringConnection());
            return ba.Listar<VWPedidoProtheus>(GetSelect(), where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWPedidoProtheus> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(VWPedidoProtheus.GetStringConnection());
            return ba.Existe<VWPedidoProtheus>(where);
        }

        /// <summary>
        /// Retorna o select de obteção dos registros
        /// </summary>
        public static string GetSelect()
        {
            return @"SELECT PCPEDC.ROWID OID
                          , NVL(PCPEDC.CODFILIALNF, PCPEDC.CODFILIAL) CODFILIAL
                          , PCPEDC.NUMPED
                          , PCPEDC.NUMCAR
                          , NVL((SELECT SUM(PCPEDI.QT * (NVL(PCPRODUT.VOLUME,0))) 
                                   FROM PCPEDI
                                      , PCPRODUT
                                  WHERE PCPEDI.NUMPED = PCPEDC.NUMPED
                                    AND PCPEDI.CODPROD = PCPRODUT.CODPROD
                                 ),0) TOTVOLUME
                          , PCPEDC.ESC_BOX                           
                       FROM PCPEDC
                      WHERE PCPEDC.DTCANCEL IS NULL 
                        AND PCPEDC.ESC_DTENVIOPROTHEUS IS NULL 
                        AND PCPEDC.ESC_BOX IS NOT NULL
                        AND PCPEDC.POSICAO = 'M' 
                        AND PCPEDC.NUMCAR IS NOT NULL
                        AND PCPEDC.IMPORTADO = 'S'
                        AND PCPEDC.NUMCAR > 0";
        }
        #endregion

        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public string Codfilial
        {
            get { return codfilial; }
            set { codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_BOX
        /// Comentário: 
        /// </summary>
        private decimal esc_box;
        [XmlElement(ElementName = "ESC_BOX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal Esc_box
        {
            get { return esc_box; }
            set { esc_box = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Comentário: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 8)]
        public decimal Numcar
        {
            get { return numcar; }
            set { numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 10)]
        public decimal Numped
        {
            get { return numped; }
            set { numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVOLUME
        /// Comentário: 
        /// </summary>
        private decimal totvolume;
        [XmlElement(ElementName = "TOTVOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 18)]
        public decimal Totvolume
        {
            get { return totvolume; }
            set { totvolume = value; }
        }

        
        #endregion
    }
}
