using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.UseAll.EntityWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Integradora.ECommerce.UseAll
{
    public sealed class Integracao : Integradora.ECommerce.Lojavirtual
    {

        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.UseAll;
        }

        public override void Initialize()
        {
            CriarCreditoParaCliente = false;
        }

        private Api.WS WebService()
        {
            Thread.Sleep(2300);

            Api.WS webservice = new Api.WS();

            webservice.Timeout = 10000; 
            
            return webservice;
        }

        public string PersistirConsumidor(Consumidor consumidor)
        {
            string resultado = "";
            try
            {
                Integradora.ECommerce.UseAll.UseAll useall = new Integradora.ECommerce.UseAll.UseAll();

                if (useall.ClienteExiste(consumidor.anidconsumidor))
                {
                    resultado = AtualizarConsumidor(consumidor);
                }
                else
                {
                    resultado = InserirConsumidor(consumidor);
                }
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.UseAll", "PersistirConsumidor", string.Format("Cliente: {0} - {1}", consumidor.anidconsumidor.ToString(), ex.ToString()));
                resultado = ex.ToString();
            }
            return resultado;
        }

        public string InserirConsumidor(Consumidor consumidor)
        {
            consumidor.Serializer("consumidor_" + consumidor.anidconsumidor.ToString());
            string retorno = "";
            try
            {
                retorno = WebService().Insere_Consumidor_Novo(consumidor.anidconsumidor,
                                                              consumidor.anidassociado,
                                                              consumidor.asnome,
                                                              consumidor.asnomeempresa,
                                                              consumidor.antipoinscricao,
                                                              consumidor.asinscricao,
                                                              consumidor.asinscricaoestadual,
                                                              consumidor.ascep,
                                                              consumidor.ascomplemento,
                                                              consumidor.anidregiao,
                                                              consumidor.asfone1,
                                                              consumidor.asfone2,
                                                              consumidor.asfone_celular,
                                                              consumidor.addata_cadastro,
                                                              consumidor.anidlocalentrega,
                                                              consumidor.asci,
                                                              consumidor.asci_orgao_emissor,
                                                              consumidor.asemail,
                                                              consumidor.asnomepai,
                                                              consumidor.asnomemae,
                                                              consumidor.asprofissao,
                                                              consumidor.asestadocivil,
                                                              consumidor.asnaturalidade,
                                                              consumidor.ancnae,
                                                              consumidor.andiavcto
                                                              );
            }
            catch (Exception erro)
            {
                consumidor.Serializer("consumidor_" + consumidor.anidconsumidor.ToString());
                retorno = "";
                Logs.GerarLog("Integradora.ECommerce.UseAll", "Insere_Consumidor_Novo", erro);
            }
            return retorno;
        }
        public string AtualizarConsumidor(Consumidor consumidor)
        {
            consumidor.Serializer("consumidor_" + consumidor.anidconsumidor.ToString());
            string retorno = "";
            try
            {
                retorno = WebService().Atualiza_Consumidor_Novo(consumidor.anidconsumidor,
                                                                consumidor.asnome,
                                                                consumidor.asnomeempresa,
                                                                consumidor.antipoinscricao,
                                                                consumidor.asinscricao,
                                                                consumidor.asinscricaoestadual,
                                                                consumidor.ascep,
                                                                consumidor.ascomplemento,
                                                                consumidor.anidregiao,
                                                                consumidor.asfone1,
                                                                consumidor.asfone2,
                                                                consumidor.asfone_celular,
                                                                consumidor.addata_cadastro,
                                                                consumidor.anidlocalentrega,
                                                                consumidor.asci,
                                                                consumidor.asci_orgao_emissor,
                                                                consumidor.asemail,
                                                                consumidor.asnomepai,
                                                                consumidor.asnomemae,
                                                                consumidor.asprofissao,
                                                                consumidor.asestadocivil,
                                                                consumidor.asnaturalidade,
                                                                consumidor.ancnae,
                                                                consumidor.andiavcto
                                                                );

            }
            catch (Exception erro)
            {
                consumidor.Serializer("consumidor_" + consumidor.anidconsumidor.ToString());
                retorno = "";
                Logs.GerarLog("Integradora.ECommerce.UseAll", "AtualizarConsumidor", erro);
            }
            return retorno;
        }
        public string EstonarPagamento(Fatura fatura)
        {
            fatura.Serializer("Estornapagamento_" + fatura.annumero_fiscal.ToString());
            string retorno = "";
            try
            {
                retorno = WebService().Estornar_Pagamento_Fatura(fatura.addata_pagto,
                                                                 fatura.anidAgente,
                                                                 fatura.annumero_fiscal,
                                                                 fatura.aniduc,
                                                                 fatura.adanomes,
                                                                 fatura.anvalor_pagto);
            }
            catch (Exception erro)
            {
                fatura.Serializer("Estornapagamento_" + fatura.annumero_fiscal.ToString());
                retorno = "";
                Logs.GerarLog("Integradora.ECommerce.UseAll", "EstonarPagamento", erro);
            }
            return retorno;
        }
        public string InserirCobranca(Cobranca cobranca)
        {
            cobranca.Serializer("cobranca_" + cobranca.anidzona.ToString());
            string retorno = "";
            try
            {
                retorno = WebService().Insere_OutrasCob_UC_Hist(cobranca.anidzona, 
                                                                cobranca.anidconta,
                                                                cobranca.aniditem,
                                                                cobranca.anmesfatura,
                                                                cobranca.ananofatura, 
                                                                cobranca.addatalancto, 
                                                                cobranca.anvalor,
                                                                cobranca.asideverest,
                                                                cobranca.ashistorico);
            }
            catch (Exception erro)
            {
                retorno = "";
                cobranca.Serializer("cobranca_" + cobranca.anidzona.ToString());
                Logs.GerarLog("Integradora.ECommerce.UseAll", "InserirCobranca", erro);
            }
            return retorno;
        }
        public string PagarFatura(Fatura fatura)
        {
            fatura.Serializer("Pagarfatura_" + fatura.annumero_fiscal.ToString());
            string retorno = "";
            try
            {
                retorno = WebService().Pagar_Fatura(fatura.addata_pagto,
                                                    fatura.anidAgente,
                                                    fatura.annumero_fiscal,
                                                    fatura.aniduc,
                                                    fatura.adanomes,
                                                    fatura.anvalor_pagto,
                                                    fatura.ascobrar_multa);

            }
            catch (Exception erro)
            {
                fatura.Serializer("Pagarfatura_" + fatura.annumero_fiscal.ToString());
                retorno = "";
                Logs.GerarLog("Integradora.ECommerce.UseAll", "PagarFAtura", erro);
            }
            return retorno;
        }
    }
}
