using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.IShopping.Retornos;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using Integradora.ERP.Winthor.View;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Integradora.Norma.Winthor.IShopping
{
    class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.IShopping.Integracao LojaECommerce { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.IShopping.Integracao();
        }

        public void Process(Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            //LojaECommerce.StatusPedidoListar();

            var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadECommerce("1=1 order by dtinclusao");
            foreach (var item in lista)
            {
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        if (Biblioteca.Dictionaries.Settings.Debugando())
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.IShopping", "Process", "Enviar: " + item.Tabela);
                        }

                        string filtro = "rowid = '" + item.Id + "'";

                        //Criando a classe e carregando
                        if (item.Tabela.Substring(0, 2) == "VW")
                            filtro = "rid = '" + item.Id + "'";

                        var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, filtro);

                        //Caso tenha encontrado processa
                        if (integracao != null)
                        {
                            switch (item.Tabela.ToString())
                            {
                                case "VWISHOPPING_PRODUTO":
                                    SendProdutos((Vwishopping_Produto)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCPEDC":
                                    SendPosicaoPedido((PCPedc)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                            }
                        }
                        else
                        {
                            if (Biblioteca.Dictionaries.Settings.Debugando())
                            {
                                Logs.GerarLog("Integradora.Norma.Winthor.IShopping", "Process", string.Format("Nenhum registro encontrado para a tabela: {0} - Filtro: {1}", item.Tabela, filtro));
                            }
                        }

                        Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Processo.Notificar("Integradora.Norma.Winthor.IShopping", "Process", ex);
                    }
                }
            }
        }

        private void SendPosicaoPedido(PCPedc registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            throw new NotImplementedException();
        }

        private void SendProdutos(Vwishopping_Produto registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            Produto dado = new Produto();

            dado.id = Convert.ToInt32(registros.Id);
            dado.allow_buy = registros.Allow_Buy != "D" ? "true" : "false";
            dado.availability = registros.Availability;
            dado.cod_ref = registros.Cod_Ref.ToString();
            dado.description_full = registros.Description_Full;
            dado.description_small = registros.Description_Small;
            dado.dimensions = new Dimensions();
            dado.dimensions.height = Convert.ToInt32(registros.Altura);
            dado.dimensions.length = Convert.ToInt32(registros.Comprimento);
            dado.dimensions.width = Convert.ToInt32(registros.Largura);
            dado.model = registros.Model;
            dado.name = registros.Name;
            dado.price = Convert.ToDouble( registros.Price );
            dado.quantity = Convert.ToInt32(registros.Quantity);
            dado.quantity_critical = Convert.ToInt32(registros.Quantity_Critical);
            dado.quantity_max_buy = Convert.ToInt32(registros.Quantity_Max_Buy);
            dado.quantity_min_buy = Convert.ToInt32(registros.Quantity_Min_Buy);
            dado.weight = Convert.ToDouble(registros.Weight);


            var resultado = LojaECommerce.ProdutoAplicar(dado);
            if (resultado != dado.id)
            {
                PCEmbalagem embalagem = PCEmbalagem.Listar("ROWID = '" + registros.Rid + "'").FirstOrDefault();

                embalagem.Codishopping = resultado;
                embalagem.Gravar();
            }
        }
    }
}
