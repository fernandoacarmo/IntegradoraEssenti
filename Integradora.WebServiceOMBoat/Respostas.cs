using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integradora.WebServiceOMBoat
{
    public struct Respostas
    {
        public bool processado;
        public string mensagem;

        public void Limpar()
        {
            processado = false;
            mensagem = "";
        }
        public void ClaseNaoInformada()
        {
            processado = false;
            mensagem = "Objeto não enviado ou vazio!";
        }

        internal string status()
        {
            return processado ? "SUCCESS" : "ERROR";
        }

        internal string mensagemRespostas()
        {
            if (string.IsNullOrEmpty(mensagem))
            {
                return processado ? "Documento recebido com sucesso" : "Nenhum registro processado";
            }
            else
            {
                return mensagem;
            }
        }
    }
}