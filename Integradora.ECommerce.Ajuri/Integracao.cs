using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.Ajuri.Metodos;
using Integradora.ERP.Winthor.EntityEssenti;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Ajuri
{
    public class Integracao : Integradora.ECommerce.Lojavirtual
    {
        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.Ajuri;
        }

        public override void Initialize()
        {
            CriarCreditoParaCliente = false;
        }

        private Integradora.ECommerce.Ajuri.AjuriTransferencias.WsTransferencias GetWebserviceInventario()
        {
            Integradora.ECommerce.Ajuri.AjuriTransferencias.WsTransferencias webservice = new Integradora.ECommerce.Ajuri.AjuriTransferencias.WsTransferencias();
            webservice.Timeout = 100000;
            webservice.Url = Biblioteca.Dictionaries.Settings.AjuriURL_Transferencia();

            return webservice;
        }

        private string prepararEnvio(object objeto, string nomeArquivo)
        {
            string xml = Integradora.Biblioteca.Tools.XML.XMLtoString(objeto, "vx", nomeArquivo);
            xml = xml.Replace(@"<?xml version=""1.0""?>", "");
            xml = xml.Replace(@"vx=""vx""", @"vx=""http://www.viaexpress.com.br/external/ViaExpress_external_integra.xsd""");
            return xml; 
        }
         
        public bool EnviarEntradas(RetornaIO xml)
        {
            string resposta = "";
            string msg = "";
            bool resultado = false;
            try
            {
                var texto = prepararEnvio(xml, "Entrada" + xml.Conferencias.Conferencia.FirstOrDefault().Cabecalhochave.Numero);

                Integradora.ECommerce.Ajuri.AjuriEntradas.WsEntradas webservice = new Integradora.ECommerce.Ajuri.AjuriEntradas.WsEntradas();
                webservice.Timeout = 100000;
                webservice.Url = Biblioteca.Dictionaries.Settings.AjuriURL_Entradas();

                resposta = webservice.ATUALIZAR_ENTRADA(texto);
                if (resposta.Contains("ERRO"))
                {
                    resultado = resposta.Contains("Entrada ja foi concluida.");
                    msg = string.Format("Retorno do envio da nota de entrada {0}: {1}"
                                                , xml.Conferencias.Conferencia.FirstOrDefault().Cabecalhochave.Numero
                                                , resposta);

                }
                else
                {
                    msg = "Enviado nota com sucesso para Ajuri: " + xml.Conferencias.Conferencia.FirstOrDefault().Cabecalhochave.Numero;
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                msg = string.Format("Erro ao enviar nota de entrada {0}: {1}"
                                   , xml.Conferencias.Conferencia.FirstOrDefault().Cabecalhochave.Numero
                                   , ex);
                resultado = false;
            }

            ESTLogintegracao.GerarLog("Integradora.ECommerce.Ajuri" //classe
                                     , "EnviarEntradas" //metodo
                                     , msg
                                     , "ESTNOTAENTRADA" //tabela
                                     , Convert.ToDecimal(xml.Conferencias.Conferencia.FirstOrDefault().Cabecalhochave.Numero) //codigoEssenti
                                     , xml.Conferencias.Conferencia.FirstOrDefault().Livres.Livre.Where(c => c.Nome == "TRANSACAO_ID_AJURI").FirstOrDefault().Valor
                                     , true //Winthor enviou?
                                     , resultado //sucesso
                                     );
            return resultado;
        }
        public bool EnviarSaidas(RetornaIO xml)
        {
            string resposta = "";
            string msg = "";
            bool resultado = false;
            try
            {
                var texto = prepararEnvio(xml, "Saida" + xml.Conferencias.Conferencia.FirstOrDefault().Cabecalhochave.Numero);

                Integradora.ECommerce.Ajuri.AjuriSaidas.WsPedidos webservice = new Integradora.ECommerce.Ajuri.AjuriSaidas.WsPedidos();
                webservice.Timeout = 100000;
                webservice.Url = Biblioteca.Dictionaries.Settings.AjuriURL_Pedidos();

                resposta = webservice.ATUALIZAR_SAIDA(texto);

                if (resposta.Contains("ERRO"))
                {
                    resultado = resposta.Contains("Pedido ja foi concluido.");
                    msg = string.Format("Retorno do envio do pedido de saída {0}: {1}"
                                       , xml.Conferencias.Conferencia.FirstOrDefault().Cabecalhochave.Numero
                                       , resposta);
                }
                else
                {
                    msg = "Enviado pedido com sucesso para Ajuri: " + xml.Conferencias.Conferencia.FirstOrDefault().Cabecalhochave.Numero;
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                msg = string.Format("Erro ao enviar pedido de saída {0}: {1}"
                                   , xml.Conferencias.Conferencia.FirstOrDefault().Cabecalhochave.Numero
                                   , ex);
                return false;
            }

            ESTLogintegracao.GerarLog("Integradora.ECommerce.Ajuri" //classe
                                     , "EnviarSaidas" //metodo
                                     , msg
                                     , "ESTPEDIDOSAIDA" //tabela
                                     , Convert.ToDecimal(xml.Conferencias.Conferencia.FirstOrDefault().Cabecalhochave.Numero) //codigoEssenti
                                     , xml.Conferencias.Conferencia.FirstOrDefault().Livres.Livre.Where(c => c.Nome == "TRANSACAO_ID_AJURI").FirstOrDefault().Valor
                                     , true //Winthor enviou?
                                     , resultado //sucesso
                                     );

            return resultado;
        }
        public bool EnviarInventario(RetornaInventarioXML xml)
        {
            string resposta = "";
            string msg = "";
            bool resultado = false;
            try
            {
                var texto = prepararEnvio(xml, "Inventario");
                var webservice = GetWebserviceInventario();

                resposta = webservice.INSERIR_LOTES_INVENTARIO(texto);

                if (resposta.Contains("ERRO"))
                {
                    msg = string.Format("Erro ao enviar inventário: {0}", resposta);
                    resultado = false;
                }
                else
                {
                    msg = "Inventário enviado com sucesso: " + resposta;
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                msg = string.Format("Erro ao enviar inventário: {0}", ex.ToString());
                return false;
            }

            ESTLogintegracao.GerarLog("Integradora.ECommerce.Ajuri" //classe
                                     , "EnviarInventario" //metodo
                                     , msg
                                     , "ESTINVENTARIO" //tabela
                                     , -1 //codigoEssenti
                                     , xml.RetornaInventario.Inventario_id//codigoEcommerce
                                     , true //Winthor enviou?
                                     , resultado //sucesso
                                     );

            return resultado;
        }
        public bool EnviarSolicitarAcerto(RetornaInventarioXML xml)
        {
            string resposta = "";
            string msg = "";
            bool resultado = false;
            try
            {
                var texto = prepararEnvio(xml, "Acerto");
                var webservice = GetWebserviceInventario();

                resposta = webservice.SOLICITAR_ACERTO(texto);

                if (resposta.Contains("ERRO"))
                {
                    msg = string.Format("Erro ao enviar solicitar acerto: {0}", resposta);
                    resultado = false;
                }
                else
                {
                    msg = "Acerto de estoque realizado com sucesso! " + resposta;
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                msg = string.Format("Erro ao enviar solicitar acerto: {0}", ex.ToString());
                return false;
            }

            ESTLogintegracao.GerarLog("Integradora.ECommerce.Ajuri" //classe
                                     , "EnviarSolicitarAcerto" //metodo
                                     , msg
                                     , "ESTMOVETOQUE" //tabela
                                     , -1 //codigoEssenti
                                     , xml.RetornaInventario.Inventario_id//codigoEcommerce
                                     , true //Winthor enviou?
                                     , resultado //sucesso
                                     );

            return resultado;
        }
        public bool EnviarSolicitarBloqueio(RetornaInventarioXML xml)
        {
            string resposta = "";
            string msg = "";
            bool resultado = false;
            try
            {
                var texto = prepararEnvio(xml, "Bloqueio");
                var webservice = GetWebserviceInventario();

                resposta = webservice.SOLICITAR_BLOQUEIO(texto);

                if (resposta.Contains("ERRO"))
                {
                    msg = string.Format("Erro ao enviar solicitar bloqueio: {0}", resposta);
                    resultado = false;
                }
                else
                {
                    msg = "Bloqueio realizado com sucesso! " + resposta;
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                msg = string.Format("Erro ao enviar solicitar bloqueio: {0}", ex.ToString());
                return false;
            }

            ESTLogintegracao.GerarLog("Integradora.ECommerce.Ajuri" //classe
                                     , "EnviarSolicitarBloqueio" //metodo
                                     , msg
                                     , "ESTMOVESTOQUE" //tabela
                                     , -1 //codigoEssenti
                                     , xml.RetornaInventario.Inventario_id//codigoEcommerce
                                     , true //Winthor enviou?
                                     , resultado //sucesso
                                     );

            return resultado;
        }
        public bool EnviarSolicitarDesbloqueio(RetornaInventarioXML xml)
        {
            string resposta = "";
            string msg = "";
            bool resultado = false;
            try
            {
                var texto = prepararEnvio(xml, "Desbloqueio");
                var webservice = GetWebserviceInventario();

                resposta = webservice.SOLICITAR_DESBLOQUEIO(texto);

                if (resposta.Contains("ERRO"))
                {
                    msg = string.Format("Erro ao enviar solicitar desbloqueio: {0}", resposta);
                    resultado = false;
                }
                else
                {
                    msg = "Desbloqueio realizado com sucesso! " + resposta;
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                msg = string.Format("Erro ao enviar solicitar desbloqueio: {0}", ex.ToString());
                return false;
            }

            ESTLogintegracao.GerarLog("Integradora.ECommerce.Ajuri" //classe
                                     , "EnviarSolicitarDesbloqueio" //metodo
                                     , msg
                                     , "ESTMOVESTOQUE" //tabela
                                     , -1 //codigoEssenti
                                     , xml.RetornaInventario.Inventario_id//codigoEcommerce
                                     , true //Winthor enviou?
                                     , resultado //sucesso
                                     );

            return resultado;
        }
    }
}
