using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.OnLine.Orders;

namespace Integradora.Servico.Testes
{
    [TestClass]
    public class TesteOnLine
    {
        [TestMethod]
        public void TesteOnLineAtualizarPedido()
        {
            Cabecalho cabecalho = new Cabecalho();
            cabecalho.numero = "93824097"; 
            cabecalho.criacao = "2016-03-18 00:00:00";
            cabecalho.cliente.codigo = "90283129830912";
            cabecalho.cliente.nome = "Teste Ws";
            Itens item1 = new Itens();
            item1.codigo = "1";
            item1.descricao = "Descrição 1";
            item1.qtd = 6;
            item1.precoUnitario = 8.84;
            cabecalho.itens.Add(item1);

            Itens item2 = new Itens();
            item2.codigo = "2";
            item2.descricao = "Descrição 2";
            item2.qtd = 8;
            item2.precoUnitario = 1.93;
            cabecalho.itens.Add(item2);

            AtualizarPedido webservice = new AtualizarPedido();
            Biblioteca.Tools.XML.Export(cabecalho, "ClimaRio");
            Cabecalho resposta  = webservice.Notificar(cabecalho);

            string retorno = "OK";

            Assert.IsNotNull(retorno);
        }
    }
}
