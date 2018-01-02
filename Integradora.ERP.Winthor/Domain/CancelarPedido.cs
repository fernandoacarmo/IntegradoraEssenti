using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ERP.Winthor.Domain
{
    public class CancelarPedido
    {
        public static string Cancelar( decimal numeroPedido
                                     , string motivo
              //                      , int codigoFuncionario
              //                      , int? codigoMotivo
                              )
        {
            string resultado = "";
            int codigoFuncionario = Biblioteca.Dictionaries.Settings.Matricula();

            if (numeroPedido == 0)
            {
                return "Informe o número do pedido de venda!";
            }
            if (string.IsNullOrEmpty(motivo))
            {
                return "Informe o motivo do cancelamento";
            }
//            if (codigoFuncionario == 0)
//            {
//                codigoFuncionario = Biblioteca.Dictionaries.Settings.Matricula();
//            }

            Oracle oracle = new Oracle( PCPedc.GetStringConnection() );

            OracleConnection objConn = oracle.GetConnection();
            OracleCommand objCmd = objConn.CreateCommand();

            objCmd.CommandText = FuncoesBanco.cancelarpedidovenda();
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("p_numped", OracleType.Double).Value = numeroPedido;
            objCmd.Parameters.Add("p_codfunc", OracleType.Double).Value = codigoFuncionario;
            objCmd.Parameters.Add("p_motivo", OracleType.VarChar, 100).Value = motivo;
            objCmd.Parameters.Add("p_codmotivo", OracleType.Double).Value = -1;

            objCmd.Parameters.Add("p_mensagem", OracleType.VarChar, 500).Direction = ParameterDirection.Output;
            objCmd.Parameters.Add("p_cancelado", OracleType.VarChar, 1).Direction = ParameterDirection.Output;
            try
            {
                objConn.Open();
                objCmd.ExecuteNonQuery();

                resultado = objCmd.Parameters["p_mensagem"].Value.ToString();
                string sucesso = objCmd.Parameters["p_cancelado"].Value.ToString();

                if (sucesso == "S")
                    resultado = "OK";
            }
            catch (Exception ex)
            {
                resultado = "Erro: " + ex.ToString();
            }
            objConn.Close();
            return resultado;
        }
    }
}
