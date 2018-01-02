using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor
{
    public class ManutencaoBancoDados
    {
        public ManutencaoBancoDados()
        {
        }

        public void Executar()
        {
            ValidarCampos();
        }

        private void ValidarCampos()
        {
            try
            {
                Manutencao configurador = new Manutencao(PCConsum.GetStringConnection());
                //PCCOB
                configurador.CampoValidarCriar("PCCOB", "CODOUTRO", "VARCHAR2(4)", true);

                //PCPRESTTEMP
                configurador.CampoValidarCriar("PCPRESTTEMP", "ESC_CARTAOCLIENTE", "VARCHAR2(30)", true);
                configurador.CampoValidarCriar("PCPRESTTEMP", "ESC_CARTAONUMERO", "VARCHAR2(30)", true);
                configurador.CampoValidarCriar("PCPRESTTEMP", "ESC_CARTAOVALIDADEANO", "NUMBER(4)", true);
                configurador.CampoValidarCriar("PCPRESTTEMP", "ESC_CARTAOVALIDADEMES", "NUMBER(2)", true);
                configurador.CampoValidarCriar("PCPRESTTEMP", "CODPLPAG", "NUMBER(4)", true);
                configurador.CampoValidarCriar("PCPRESTTEMP", "PRESTTEF", "VARCHAR2(2)", true);
                configurador.CampoValidarCriar("PCPRESTTEMP", "NSUTEF", "varchar2(2)", true);
                configurador.CampoValidarCriar("PCPRESTTEMP", "NUMPEDWEB", "varchar2(10)", true);
                configurador.CampoValidarCriar("PCPRESTTEMP", "ESC_CODAUTORIZACAOTEF", "varchar2(50)", true);
                configurador.CampoValidarCriar("PCPRESTTEMP", "ESC_AJUSTARFINANCEIRO", "varchar2(1)", true);

                //PCPREST
                configurador.CampoValidarCriar("PCPREST", "ESC_DTREFERENCIA", "DATE", true);
                configurador.CampoValidarCriar("PCPREST", "ESC_COBRAJUROS", "VARCHAR2(1)", true);

                //PCCLIENT
                configurador.CampoValidarCriar("PCCLIENT", "ESC_NUMDIASEMBARQUE", "NUMBER(3)", true);
                configurador.CampoValidarCriar("PCCLIENT", "TELENTFACULTATIVO", "VARCHAR2(15)", true);
                configurador.CampoValidarCriar("PCCLIENT", "TELCOMFACULTATIVO", "VARCHAR2(15)", true);
                configurador.CampoValidarCriar("PCCLIENT", "MEIOCOMUNICACAO", "VARCHAR2(1)", true);
                configurador.CampoValidarCriar("PCCLIENT", "ESC_APOSENTADO", "VARCHAR2(1)", true);
                configurador.CampoValidarCriar("PCCLIENT", "ESC_TIPOCLIENTE", "VARCHAR2(1)", true);
                configurador.CampoValidarCriar("PCCLIENT", "ESC_CODASSOCIADO", "VARCHAR2(20)", true);
                configurador.CampoValidarCriar("PCCLIENT", "ESC_UC", "VARCHAR2(20)", true);
                configurador.CampoValidarCriar("PCCLIENT", "MAGENTO_ENT_ID", "VARCHAR2(30)", true);
                configurador.CampoValidarCriar("PCCLIENT", "MAGENTO_ID", "VARCHAR2(30)", true);
                configurador.CampoValidarCriar("PCCLIENT", "DTINCLUSAO", "DATE", true);
                configurador.CampoValidarCriar("PCCLIENT", "ESC_DIAVECTO", "NUMBER(2)", true);

                //PCMOVCR
                configurador.CampoValidarCriar("PCMOVCR", "DTCONTABIL", "DATE", true);

                //PCPRODUT
                configurador.CampoValidarCriar("PCPRODUT", "MAGENTO_ID", "VARCHAR2(30)", true);
                configurador.CampoValidarCriar("PCPRODUT", "ESC_PRCACRESCPRECOWEB", "NUMBER(22,6)", true);

                //PCDEPTO
                configurador.CampoValidarCriar("PCDEPTO", "USANOECOMMERCE", "VARCHAR2(1)", true);
                configurador.CampoValidarCriar("PCDEPTO", "MAGENTO_ID", "VARCHAR2(30)", true);

                //PCUSUARI
                configurador.CampoValidarCriar("PCUSUARI", "MEIOCOMUNICACAO", "VARCHAR2(1)", true);
            
                //PCPEDCTEMP
                configurador.CampoValidarCriar("PCPEDCTEMP", "ESC_AJUSTARFINANCEIRO", "VARCHAR2(1)", true);

                //PCPEDC
                configurador.CampoValidarCriar("PCPEDC", "ESC_DTENVIOINTERNIT", "DATE", true);
                configurador.CampoValidarCriar("PCPEDC", "ESC_DTENVIOPROTHEUS", "DATE", true);

                //PCCRECLI
                configurador.CampoValidarCriar("PCCRECLI", "STATUS", "VARCHAR2(2)", true);
                
                //PCCLIENTENDENT
                configurador.CampoValidarCriar("PCCLIENTENDENT", "DTULTALTER", "DATE", true);
                configurador.CampoValidarCriar("PCCLIENTENDENT", "DTEXCLUSAO", "DATE", true);
                configurador.CampoValidarCriar("PCCLIENTENDENT", "DTCAD", "DATE", true);
                configurador.CampoValidarCriar("PCCLIENTENDENT", "CODFUNCULTALTER", "NUMBER(8)", true);
                configurador.CampoValidarCriar("PCCLIENTENDENT", "CODFUNCCAD", "NUMBER(8)", true);
            }
            catch (Exception ex)
            {
                Integradora.Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor", "Executar", "Erro na criação de campo: " + ex.ToString());
            }
        }
    }
}
