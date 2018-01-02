using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;
using System.Configuration;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Integradora.Database.Oracle
{
    public class Persistencia
    {
        DataTable dt;
        string Connection = "";

        private Manutencao manutencaobancodados;
        public Manutencao ManutencaoBancoDados
        {
            get
            {
                if (manutencaobancodados == null)
                {
                    manutencaobancodados = new Manutencao(Connection);
                }
                return manutencaobancodados;
            }
            set { manutencaobancodados = value; }
        }
        public Persistencia(string connectionString)
        {
            Connection = connectionString;
        }
        private string GeraProximoID(string nomedatabela)
        {
            string comando = "seq_{0}"; ;
            comando = String.Format(comando, nomedatabela);
            decimal retorno = 0;

            retorno = GetProximoID(comando);

            return retorno.ToString();
        }
        public Decimal GetProximoID(string nomesequence)
        {
            string comando = "select {0}.nextval id from dual";
            Oracle bd = new Oracle(Connection);
            DataTable dt = bd.ExecutaComando(String.Format(comando, nomesequence));
            return Convert.ToDecimal(dt.Rows[0]["id"].ToString());
        }
        public Decimal GetProximoID(string nomedatabela, string nomecampo)
        {
            return GetProximoID(nomedatabela, nomecampo, "");
        }
        public Decimal GetProximoID(string nomedatabela, string nomecampo, string filtro)
        {
            Decimal proximocodigo;
            //Obter o próximo código
            string comando = "select {0} id from {1} where {2}";
            Oracle bd = new Oracle(Connection);
            DataTable dt = bd.ExecutaComando(String.Format(comando, nomecampo, nomedatabela, filtro));
            //Próximo código
            proximocodigo = Convert.ToDecimal(dt.Rows[0]["id"].ToString());
            //Atualizar a sequencia no bnaco
            comando = "update {0} set {1} = {2} + 1 where {3}";
            bd.ExecuteNonQuery(String.Format(comando, nomedatabela, nomecampo, proximocodigo.ToString(), filtro));

            return proximocodigo;
        }
        public DateTime GetDataHoraServidor()
        {
            string comando = "select SYSDATE as datahora from dual";
            Oracle bd = new Oracle(Connection);
            DataTable dt = bd.ExecutaComando(comando);
            return Convert.ToDateTime(dt.Rows[0]["datahora"].ToString());
        }

        public decimal GetValorCampoDecimal(string script)
        {
            string comando = script;
            decimal valor = 0;
            Oracle bd = new Oracle(Connection);
            DataTable dt = bd.ExecutaComando(comando);

            if (dt.Rows.Count > 0)
            {
                valor = Convert.ToDecimal(dt.Rows[0]["valor"].ToString());
            }

            return valor;
        }

        public string GetValorCampoString(string script)
        {
            string comando = script;
            string valor = "";
            Oracle bd = new Oracle(Connection);
            DataTable dt = bd.ExecutaComando(comando);

            if (dt.Rows.Count > 0)
            {
                valor = dt.Rows[0]["valor"].ToString();
            }

            return valor;
        }

        public DateTime? GetValorCampoDate(string script)
        {
            string comando = script;
            DateTime? valor = null;
            Oracle bd = new Oracle(Connection);
            DataTable dt = bd.ExecutaComando(comando);

            if (dt.Rows.Count > 0)
            {
                valor = Convert.ToDateTime(dt.Rows[0]["datahora"].ToString());
            }

            return valor;
        }
        public DateTime GetDataServidor()
        {
            string comando = "select TRUNC(SYSDATE) as datahora from dual";
            Oracle bd = new Oracle(Connection);
            DataTable dt = bd.ExecutaComando(comando);
            return Convert.ToDateTime(dt.Rows[0]["datahora"].ToString());
        }

        public bool Inserir(object objeto)
        {
            try
            {
                //insert into nomedatabela (nomedoscampos) values (valores)
                string commandoInsert = "insert into {0} ({1}) values ({2})";
                string campos = "";
                string valores = "";

                //reflexão
                string nomedatabela = objeto.GetType().Name.ToString();

                Type myType = objeto.GetType();
                PropertyInfo[] myPropertyInfo = myType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (var item in myPropertyInfo)
                {
                    if (CamposValido(item.Name))
                    {
                        campos += item.Name.ToString() + " , ";
                    }
                }

                foreach (var item in myPropertyInfo)
                {
                    object[] atributos = item.GetCustomAttributes(typeof(DataObjectFieldAttribute), false);

                    string valorString = "";
                    //seta o valor no objeto
                    if (CamposValido(item.Name))
                    {
                        if (item.GetValue(objeto, null) == null)
                        {

                            if (item.PropertyType.ToString().ToLower().Contains("string"))
                            {
                                valores += @"null  /*" + item.Name.ToString() + "*/ , ";
                            }
                            else
                            {
                                valores += @"null  /*" + item.Name.ToString() + "*/ , ";
                            }

                        }
                        else
                        {

                            if (item.PropertyType.ToString().ToLower().Contains("decimal"))
                            {
                                valorString = item.GetValue(objeto, null).ToString();
                                if ((valorString == "0") && (item.Name.Length > 3) && (item.Name.Substring(0, 2).ToLower() == "cod"))
                                {
                                    valorString = "null";
                                }
                                valores += valorString.ToString().Replace(",", ".") + " /*" + item.Name.ToString() + "*/ , ";
                            }
                            else
                            {
                                if (item.PropertyType.ToString().ToLower().Contains("date"))
                                {
                                    DateTime data = (DateTime)item.GetValue(objeto, null);
                                    //TO_DATE('12/09/2011 14:25:00','DD/MM/YYYY HH24:MI:SS'),
                                    DateTime data1 = new DateTime();
                                    if (data == data1)
                                    {
                                        valores += "null /*" + item.Name.ToString() + "*/ , ";
                                    }
                                    else
                                    {
                                        valores += "TO_DATE('" + String.Format("{0:dd/MM/yyyy HH:mm:ss}", data) + "','DD/MM/YYYY HH24:MI:SS')" + " /*" + item.Name.ToString() + "*/ , ";
                                        //                                    valores += "TO_DATE('" + data.ToShortDateString() + " " + data.ToShortTimeString() + ":00','DD/MM/YYYY HH24:MI:SS')" + " /*" + item.Name.ToString() + "*/ , ";
                                    }
                                }
                                else
                                {
                                    valorString = item.GetValue(objeto, null).ToString();
                                    //Retirando a aspas simples
                                    if (!string.IsNullOrEmpty(valorString))
                                    {
                                        valorString = valorString.Replace("'", "´");
                                    }
                                    int tamanho = (atributos[0] as DataObjectFieldAttribute).Length;
                                    if (tamanho > 0)
                                    {
                                        if (valorString.Length > tamanho)
                                        {
                                            valorString = valorString.Substring(0, tamanho);
                                        }
                                    }

                                    if (valorString == "")
                                    {
                                        valores += "null /*" + item.Name.ToString() + "*/ , ";
                                    }
                                    else
                                    {
                                        valores += "'" + valorString + "'" + " /*" + item.Name.ToString() + "*/ , ";
                                    }
                                }
                            }
                        }
                    }
                }

                campos = campos.Remove(campos.Length - 3, 2);
                valores = valores.Remove(valores.Length - 3, 2);
                string comando = string.Format(commandoInsert, nomedatabela, campos, valores);
                Oracle bd = new Oracle(Connection);
                bd.ExecutaComando(comando);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        public void Alterar(object objeto)
        {

            //update nfe_envio set (campo = valor,campo = valor)
            string commandoUpdate = "update {0} set {1} {2}";
            string campos = "";
            string filtro = "";
            string valorString = "";

            string nomedatabela = objeto.GetType().Name.ToString().ToUpper();

            Type myType = objeto.GetType();
            PropertyInfo[] myPropertyInfo = myType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var item in myPropertyInfo)
            {
                object[] atributos = item.GetCustomAttributes(typeof(DataObjectFieldAttribute), false);

                if (CamposValido(item.Name))
                {
                    if (item.GetValue(objeto, null) == null)
                    {
                        campos += item.Name.ToString() + " = null , ";
                    }
                    else
                    {
                        if (item.PropertyType.ToString().ToLower().Contains("decimal"))
                        {
                            campos += item.Name.ToString() + " = " + item.GetValue(objeto, null).ToString().Replace(",", ".") + " , ";
                        }
                        else if (item.PropertyType.ToString().ToLower().Contains("date"))
                        {
                            DateTime data = (DateTime)item.GetValue(objeto, null);

                            DateTime data1 = new DateTime();
                            if (data == data1)
                            {
                                campos += item.Name.ToString() + " = null, ";
                            }
                            else
                            {
                                campos += item.Name.ToString() + " = TO_DATE('" + String.Format("{0:dd/MM/yyyy HH:mm:ss}", data) + "','DD/MM/YYYY HH24:MI:SS') , ";
                            }

                        }
                        else
                        {
                            if (item.PropertyType.ToString().ToLower().Contains("string"))
                            {
                                try
                                {
                                    valorString = item.GetValue(objeto, null).ToString();
                                    //Retirando a aspas simples
                                    if (!string.IsNullOrEmpty(valorString))
                                    {
                                        valorString = valorString.Replace("'", "´");
                                    }

                                    int tamanho = (atributos[0] as DataObjectFieldAttribute).Length;
                                    if (tamanho > 0)
                                    {
                                        if (valorString.Length > tamanho)
                                        {
                                            valorString = valorString.Substring(0, tamanho);
                                        }
                                    }

                                    if (valorString != "")
                                    { campos += item.Name.ToString() + " = '" + valorString + "' , "; }
                                    else
                                    { campos += item.Name.ToString() + " = null, "; }

                                }
                                catch (Exception)
                                {

                                    campos += item.Name.ToString() + " = null, ";
                                }
                            }
                            else
                            {
                                campos += item.Name.ToString() + " = " + item.GetValue(objeto, null).ToString() + " , ";
                            }
                        }
                    }
                }
                else
                {
                    if (item.Name.ToLower() == "oid")
                    {
                        filtro = " where ROWID = '" + item.GetValue(objeto, null).ToString() + "'";
                    }
                }
            }

            campos = campos.Remove(campos.Length - 3, 2);

            string comando = string.Format(commandoUpdate, nomedatabela, campos, filtro);
            Oracle bd = new Oracle(Connection);
            bd.ExecutaComando(comando);
        }
        public void Excluir(object objeto)
        {
            //reflexão
            string nomedatabela = objeto.GetType().Name.ToString();
            Type myType = objeto.GetType();
            PropertyInfo[] myPropertyInfo = myType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            bool t1 = false;
            foreach (var item in myPropertyInfo)
            {
                if (item.Name.ToLower().ToUpper() == "DTEXCLUSAO")
                {
                    item.SetValue(objeto, DateTime.Now, null);
                    t1 = true;
                }
            }
            if (t1)
            {
                updateBanco(objeto);
            }
            else
            {
                deletarBanco(objeto);
            }
        }
        private void deletarBanco(object objeto)
        {
            string campos = "";

            //reflexão
            string nomedatabela = objeto.GetType().Name.ToString();
            Type myType = objeto.GetType();
            PropertyInfo[] myPropertyInfo = myType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var item in myPropertyInfo)
            {
                if (item.Name.ToLower() == "oid")
                {
                    campos = item.GetValue(objeto, null).ToString();
                }
            }

            string comando = string.Format("delete from {0} where {1} = '{2}'", nomedatabela, "ROWID", campos);

            Oracle bd = new Oracle(Connection);
            bd.ExecutaComando(comando);
        }
        private void updateBanco(object objeto)
        {
            //update nfe_envio set (campo = valor,campo = valor)
            string commandoUpdate = "update {0} set {1} {2}";
            string campos = "";
            string filtro = "";
            string valorString = "";
            //reflexão

            string nomedatabela = objeto.GetType().Name.ToString().ToUpper();

            Type myType = objeto.GetType();
            PropertyInfo[] myPropertyInfo = myType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var item in myPropertyInfo)
            {
                if (CamposValido(item.Name))
                {
                    object[] atributos = item.GetCustomAttributes(typeof(DataObjectFieldAttribute), false);

                    if (!(item.GetValue(objeto, null) == null))
                    {
                        if (item.PropertyType.ToString().ToLower().Contains("date"))
                        {
                            try
                            {
                                //TO_DATE('12/09/2011 14:25:00','DD/MM/YYYY HH24:MI:SS'),

                                DateTime dt = (DateTime)item.GetValue(objeto, null);
                                DateTime data1 = new DateTime();
                                if (dt != data1)
                                {
                                    campos += item.Name.ToString() + " = TO_DATE('" + String.Format("{0:dd/MM/yyyy HH:mm:ss}", dt) + "','DD/MM/YYYY HH24:MI:SS') , ";
                                }
                            }
                            catch (Exception)
                            {
                                campos += item.Name.ToString() + " = null , ";
                            }
                        }
                        else
                        {
                            valorString = item.GetValue(objeto, null).ToString();
                            int tamanho = (atributos[0] as DataObjectFieldAttribute).Length;
                            if (tamanho > 0)
                            {
                                valorString = valorString.Replace("'", "´");
                                if (valorString.Length > tamanho)
                                {
                                    valorString = valorString.Substring(0, tamanho);
                                }
                            }

                            if (valorString == "")
                            {
                                campos += item.Name.ToString() + " = null, ";
                            }
                            {
                                campos += item.Name.ToString() + " = '" + valorString + "', ";
                            }
                        }
                    }
                }
                else
                {
                    if (item.Name.ToLower() == "oid")
                    {
                        filtro = " where ROWID = '" + item.GetValue(objeto, null).ToString() + "'";
                    }

                }
            }

            campos = campos.Remove(campos.Length - 3, 2);

            string comando = string.Format(commandoUpdate, nomedatabela, campos, filtro);
            Oracle bd = new Oracle(Connection);
            bd.ExecutaComando(comando);
        }
        private void MapeamentoObjeto(object objeto)
        {
            string campos = "";
            //reflexão
            string nomedatabela = objeto.GetType().Name.ToString();
            foreach (var item in objeto.GetType().GetProperties())
            {
                //associacoes devem começar com_
                if (CamposValido(item.Name))
                {
                    campos += item.Name.ToString() + ",";

                }
            }
            campos = campos.Remove(campos.Length - 1);
            string select = "select " + campos + " from " + nomedatabela;
            CarregaBanco(select);
        }
        private bool CamposValido(string campo)
        {
            bool resultado;
            resultado = (!campo.StartsWith("_") &&
                        (campo.ToLower() != "oid"));

            return resultado;
        }
        private void MapeamentoObjeto(object objeto, string where)
        {
            string campos = "";
            //reflexão
            string nomedatabela = objeto.GetType().Name.ToString();
            foreach (var item in objeto.GetType().GetProperties())
            {
                //associacoes devem começar com_
                if (CamposValido(item.Name))
                {
                    campos += item.Name.ToString() + ",";

                }
                else
                {
                    if (item.Name.ToLower() == "oid")
                    {
                        campos += "ROWID as " + item.Name.ToString() + ",";
                    }
                }
            }
            campos = campos.Remove(campos.Length - 1);

            if (!where.ToUpper().Contains("WHERE"))
            {
                // trata o order by
                int indice = where.IndexOf("order by");
                if (!(indice == 0 || indice == 1))
                {
                    where = "where " + where + " ";
                }
            }
            else
            {
                if (where != "")
                {
                    where = "where " + where + " ";
                }
            }

            string select = "select " + campos + " from " + nomedatabela + " " + where;
            CarregaBanco(select);
        }
        public List<T> Listar<T>() where T : class, new()
        {
            T obj = new T();
            MapeamentoObjeto(obj);
            List<T> ll = new List<T>();
            DataTable dt = retornaTabela();
            foreach (DataRow dr in dt.Rows)
            {

                EntidadeBuider ent = new EntidadeBuider();
                ll.Add(ent.CriarEntidadeNoDataRow<T>(dr));
            }
            return ll;
        }
        public List<T> Listar<T>(string where) where T : class, new()
        {
            T obj = new T();
            MapeamentoObjeto(obj, where);
            List<T> ll = new List<T>();
            foreach (DataRow dr in retornaTabela().Rows)
            {

                EntidadeBuider ent = new EntidadeBuider();
                ll.Add(ent.CriarEntidadeNoDataRow<T>(dr));
            }
            return ll;

        }
        public List<T> Listar<T>(string script, string where) where T : class, new()
        {
            string select = script;
            if (!string.IsNullOrEmpty(where))
            {
                select += " AND " + where;
            }

            T obj = new T();
            CarregaBanco(select);
            List<T> ll = new List<T>();
            foreach (DataRow dr in retornaTabela().Rows)
            {
                EntidadeBuider ent = new EntidadeBuider();
                ll.Add(ent.CriarEntidadeNoDataRow<T>(dr));
            }
            return ll;

        }
        private DataTable retornaTabela()
        {
            return dt;
        }
        public bool Se_tabela_existe(string tabela)
        {
            bool retorno = false;
            DataTable dtt = new DataTable();
            Oracle bd = new Oracle(Connection);
            dtt = bd.ExecutaComando(String.Format("select table_name from user_tables where table_name = '{0}'", tabela.ToUpper()));
            if (dtt.Rows.Count > 0)
            {
                retorno = true;
            }
            return retorno;
        }
        public bool Existe<T>(string where) where T : class, new()
        {
            T obj = new T();

            //update nfe_envio set (campo = valor,campo = valor)
            string comandoPesquisa = "select count(9) registros from {0} where {1} ";

            string filtro = "1=1";
            bool retorno = false;

            if (!string.IsNullOrEmpty(where))
            {
                filtro = where;
            }
            //reflexão
            string nomedatabela = obj.GetType().Name.ToString();

            DataTable dtt = new DataTable();
            Oracle bd = new Oracle(Connection);
            dtt = bd.ExecutaComando(String.Format(comandoPesquisa, nomedatabela.ToUpper(), filtro));

            if (dtt.Rows.Count > 0)
            {
                comandoPesquisa = dtt.Rows[0]["registros"].ToString();
                return comandoPesquisa != "0";
            }
            return retorno;

        }
        private void CarregaBanco(string select)
        {
            Oracle bd = new Oracle(Connection);
            dt = bd.ExecutaComando(select);
        }
        public bool Executar(string comando)
        {
            bool resultado = false;
            try
            {
                Oracle bd = new Oracle(Connection);
                bd.ExecuteNonQuery(comando);

                resultado = true;
            }
            catch (Exception)
            {
                resultado = false;
            }
            return resultado;
        }
        public bool ExecutarProcedure(string StoredProcedure, string parametros, string valores)
        {
            bool resultado = false;
            try
            {
                Oracle bd = new Oracle(Connection);
                bd.ExecutarProcedure(StoredProcedure, parametros, valores);

                resultado = true;
            }
            catch (Exception)
            {
                resultado = false;
            }
            return resultado;
        }

        public decimal Contar(string nomeTabela, string filtro)
        {
            decimal retorno = 0;
            DataTable dtt = new DataTable();
            Oracle bd = new Oracle(Connection);
            string comando = string.Format("SELECT COUNT(1) AS REGISTROS FROM {0} WHERE {1}", nomeTabela, string.IsNullOrEmpty(filtro) ? "1=1" : filtro);
            dtt = bd.ExecutaComando(comando);
            if (dtt.Rows.Count > 0)
            {
                retorno = Convert.ToDecimal(dtt.Rows[0]["REGISTROS"]);
            }
            return retorno;
        }

        public decimal Maior(string nomeTabela, string nomeCampo, string filtro)
        {
            decimal retorno = 0;
            DataTable dtt = new DataTable();
            Oracle bd = new Oracle(Connection);
            string comando = string.Format("SELECT MAX({0}) AS REGISTROS FROM {1} WHERE {2}", nomeCampo, nomeTabela, string.IsNullOrEmpty(filtro) ? "1=1" : filtro);
            dtt = bd.ExecutaComando(comando);
            if (dtt.Rows.Count > 0)
            {
                retorno = Convert.ToDecimal(dtt.Rows[0]["REGISTROS"]);
            }
            return retorno;
        }
        public void ManutencaoBanco(object objeto)
        {
            //Nome da tabela a ser validada
            string nomedatabela = objeto.GetType().Name.ToString();
            //Obtendo a lista de campos
            Type myType = objeto.GetType();
            PropertyInfo[] myPropertyInfo = myType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            //Percorrendo a lista de campos da classe
            foreach (var item in myPropertyInfo)
            {   //Verificando se o campo existe na tabela
                if (!ManutencaoBancoDados.CampoExiste(nomedatabela, item.Name))
                {   //Obtendo a lista de atributo da propriedade/Campo
                    object[] atributos = item.GetCustomAttributes(typeof(XmlElementAttribute), false);
                    //Obtendo o tipo do campo (formato banco de dados)
                    string tipoTamanho = (atributos[0] as XmlElementAttribute).DataType.ToUpper();
                    //Verificando se o mesmo aceita NULL ou NOT NULL
                    bool Nulo = (atributos[0] as XmlElementAttribute).IsNullable;
                    //Definindo o tamanho dos campos
                    if ((tipoTamanho == "VARCHAR2") || (tipoTamanho == "NUMBER"))
                    {
                        object[] atributos2 = item.GetCustomAttributes(typeof(DataObjectFieldAttribute), false);
                        tipoTamanho = tipoTamanho + "(" + (atributos2[0] as DataObjectFieldAttribute).Length.ToString() + ")";
                    }

                    ManutencaoBancoDados.CampoCriar(nomedatabela.ToUpper(), item.Name.ToUpper(), tipoTamanho, Nulo);
                }
            }
        }
    }
}
