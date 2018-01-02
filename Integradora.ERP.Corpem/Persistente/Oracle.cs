using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.IO;
using System.Configuration;
//using System.Data.OracleClient;
using Integradora.Biblioteca.Tools;
using Integradora.Biblioteca.Interfaces;
using Oracle.ManagedDataAccess.Client;

namespace Integradora.ERP.Corpem.Persistente
{
    public class Oracle : ISGDB
    {
        string connection = "";
        public Oracle(string StringConnection)
        {
            connection = StringConnection; 
        }
        private OracleConnection GetConnection()
        {
            //String de Conexão
            return new OracleConnection(connection);
        }
        public DataTable ExecutaComando(string comando)
        {
            OracleConnection cn = GetConnection();
            
            OracleCommand dbCommand = cn.CreateCommand();
            DataTable oDt = new DataTable();

            dbCommand.CommandText = comando;
            dbCommand.CommandType = CommandType.Text;

            try
            {
                // Seta a conexão no comando
                dbCommand.Connection = cn;

                // Abre a conexão
                cn.Open();

                //Criar um objeto Oracle Data Adapter
                OracleDataAdapter oDa = new OracleDataAdapter(dbCommand);

                //Preenchendo o DataTable
                oDa.Fill(oDt);

                //Resultado da Função
                return oDt;


            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                dbCommand.Dispose();
                cn.Dispose();
                Logs.GerarLog("Integradora.Database.Oracle", "ExecutaComando", string.Format("Script: {0} - Erro: {1} ", comando, ex.ToString()));
                throw new Exception(string.Format("Script: {0} - Erro: {1} ", comando, ex.ToString()));
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                dbCommand.Dispose();
                cn.Dispose();
            }

        }
        public void ExecuteNonQuery(string comando)
        {
            OracleConnection cn = GetConnection();
            OracleCommand dbCommand = cn.CreateCommand();
            dbCommand.CommandText = comando;
            dbCommand.CommandType = CommandType.Text;

            try
            {
                // Seta a conexão no comando
                dbCommand.Connection = cn;

                // Abre a conexão
                cn.Open();

                dbCommand.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                Logs.GerarLog("Integradora.Database.Oracle", "ExecuteNonQuery", string.Format("Script: {0} - Erro {1} ", comando, ex.ToString()));
                dbCommand.Dispose();
                cn.Dispose();

                System.ArgumentException argEx = new System.ArgumentException("Integradora.Database.Oracle", "ExecuteNonQuery: " + comando, ex);
                throw argEx;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                dbCommand.Dispose();
                cn.Dispose();
            }
        }
        public void ExecutarProcedure(string StoredProcedure, string parametros, string valores)
        {
            using (OracleConnection cn = GetConnection())
            {
                string[] listaParametros = parametros.Split(';');
                string[] listaValores = valores.Split(';');
                int i = 0;

                OracleCommand dbCommand = new OracleCommand(StoredProcedure, cn);
                try
                {
                    dbCommand.CommandType = CommandType.StoredProcedure;

                    foreach (string nomeParametros in listaParametros)
                    {
                        dbCommand.Parameters.Add(nomeParametros, listaValores[i]);
//                        dbCommand.Parameters.AddWithValue(nomeParametros, "number").Value = listaValores[i];
                        i++;
                    }

                    cn.Open();
                    dbCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        cn.Close();
                    }
                    Logs.GerarLog("Integradora.Database.Oracle", "ExecutProcedure", ex);
                    dbCommand.Dispose();
                    cn.Dispose();
                    throw ex;
                }
            }
        }
    }
}