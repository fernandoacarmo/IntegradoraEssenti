using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using Integradora.ECommerce.VTiger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.VTiger
{
    class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.VTiger.Integracao LojaECommerce { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.VTiger.Integracao();
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadVTiger("");
            foreach (var item in lista)
            {
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        if (Biblioteca.Dictionaries.Settings.Debugando())
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.VTiger", "Process", "Enviar: " + item.Tabela);
                        }

                        string filtro = "rowid = '" + item.Id + "'";

                        //Criando a classe e carregando
                        
                        if (item.Tabela.Substring(0, 2) == "VW")
                        {
                            filtro = "B." + filtro;
                            filtro = filtro.Replace("rowid", "rid");
                        }

                        var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, filtro);

                        //Caso tenha encontrado processa
                        if (integracao != null)
                        {
                            switch (item.Tabela.ToString())
                            {
                                case "VWVTEXPRODUTOS":
                                     SendProduto((VWVtexProdutos)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCCLIENT":
                                     SendCliente((PCClient)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "VWFORMULACAO":
                                     SendKit((VWFormulacao)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                            }
                        }
                        else
                        {
                            if (Biblioteca.Dictionaries.Settings.Debugando())
                            {
                                Logs.GerarLog("Integradora.Norma.Winthor.VTiger", "Process", string.Format("Nenhum registro encontrado para a tabela: {0} - Filtro: {1}", item.Tabela, filtro));
                            }
                        }

                        Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Processo.Notificar("Integradora.Norma.Winthor.VTiger", "Process", ex);
                    }
                }
            }
        }

        private void SendKit(VWFormulacao vWFormulacao, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            throw new NotImplementedException();
        }

        private void SendCliente(PCClient tabela, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            Logs.GerarLog("Integradora.Norma.Winthor.VTiger"
                         , "SendCliente"
                         , string.Format("Enviando cliente: {0} - {1}", tabela.Codcli.ToString(), tabela.Cliente));

            VTigerCustomer registros = new VTigerCustomer();

            registros.siccode = tabela.Cgcent;
            registros.cnpj = tabela.Cgcent;
            registros.rgie = string.IsNullOrEmpty(tabela.Rg) ? tabela.Ieent : tabela.Rg;
            registros.accountname = tabela.Cliente.Replace("&","e");
            registros.email1 = string.IsNullOrEmpty(tabela.Email) ? tabela.Emailnfe : tabela.Email;
            registros.phone = string.IsNullOrEmpty(tabela.Telcelent) ? tabela.Telent : tabela.Telcelent;
            registros.ship_city = string.IsNullOrEmpty(tabela.Municent) ? tabela.Municcob : tabela.Municent;
            registros.ship_country = "Brasil";
            registros.ship_state = string.IsNullOrEmpty(tabela.Estent) ? tabela.Estcob : tabela.Estent;
            registros.ship_street = string.IsNullOrEmpty(tabela.Enderent) ? tabela.Endercob: tabela.Enderent;
            registros.ship_pobox = string.IsNullOrEmpty(tabela.Cepent) ? tabela.Cepcob : tabela.Cepent;
            registros.accounttype = VTigerApi.Accounttype.Customer;
            registros.bill_city = string.IsNullOrEmpty(tabela.Municcob) ? tabela.Municent : tabela.Municcob;
            registros.bill_country = "Brasil";
            registros.bill_state = string.IsNullOrEmpty(tabela.Estcob) ? tabela.Estent : tabela.Estcob;
            registros.bill_street = string.IsNullOrEmpty(tabela.Endercob) ? tabela.Enderent : tabela.Endercob;
            registros.bill_pobox = string.IsNullOrEmpty(tabela.Cepcob) ? tabela.Cepent : tabela.Cepcob;
            registros.fax = string.IsNullOrEmpty(tabela.Faxcli) ? tabela.Faxcom : tabela.Faxcli;


            if (LojaECommerce.exportarCliente(registros))
            {
            }
        }

        private void SendProduto(VWVtexProdutos tabela, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            Logs.GerarLog("Integradora.Norma.Winthor.VTiger"
                         , "SendProduto"
                         , string.Format("Enviando produto: {0} - {1}", tabela.Codprod.ToString(), tabela.Produto));

            VTigerApi.VTigerProduct registros = new VTigerApi.VTigerProduct();

            //---> Estes são gerados automáticos
            //registros.assigned_user_id //Código do usuário conectado
            //registros.id //Código do produto cadastrado dentro do VTiger, gerado automático
            //registros.createdtime; //Data de criação
            //registros.product_no //Gerado automático

            //----> Dados que não estou preenchendo
            //registros.expiry_date 
            //registros.glacct
            //registros.mfr_part_no
            //registros.productsheet
            //registros.qtyindemand
            //registros.reorderlevel
            //registros.sales_start_date
            //registros.sales_end_date
            //registros.serial_no
            //registros.start_date
            //registros.taxclass
            //registros.usageunit
            //registros.vendor_id
            //registros.vendor_part_no
            //registros.website

            //---> Dados que estou enviado
            registros.commissionrate = 0; //Vai informar a comissão?
            registros.discontinued = true; //Não criei nada para desativar produto
            registros.productcode = tabela.Codprod.ToString(); //Código do produto
            registros.productname = tabela.Produto.Replace("&", "e"); ; //Este e o NomeECommerce
            registros.description = tabela.Produto.Replace("&", "e"); ; //Este e o NomeECommerce           
            registros.manufacturer = tabela.Marca; //Registro da tabela ESTMARCAPRODUTO
            registros.productcategory = tabela.Departamento; //Descrição do departamento
            registros.qty_per_unit = Convert.ToDouble( tabela.Qtunit );
            registros.qtyinstock = Convert.ToDouble( tabela.Qtestoque ); //Quantidade do estoque filial 5
            registros.unit_price = Convert.ToDouble(tabela.Pvenda); //Preço de venda da região da filial 13

            if (LojaECommerce.exportarProduto(registros))
            {
                LojaECommerce.exportarPreco(registros);
            }
        }
    }
}
