using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.VTex
{
    public class Tips
    {
        public enum StatusPedido
        {
            Aguardando_confirmação_do_Seller,
            Pagamento_Pendente,
            Pagamento_Aprovado,
            Pagamento_Negado,
            Aguardando_decisao_do_Seller,
            Aguardando_autorizaçao_para_despachar_1,
            Aguardando_autorizacao_para_despachar_2,
            Carencia_para_Cancelamento,
            Pronto_para_o_Manuseio,
            Iniciar_Manuseio,
            Preparando_Entrega_1,
            Preparando_Entrega_2,
            Cancelamento_Solicitado,
            Verificando_Envio,
            Faturado_1,
            Faturado_2,
            Cancelar,
            Cancelado
        };

        public enum TipoPagamento
        {
            American_Express = 1,  	//Cartao de Crédito	Cielo  Clear Sale  
            Aura = 7,  	//Cartao de Crédito	Inativo  
            Banricompras = 14,  	//Cartao de Crédito	Inativo  
            Cabal = 33,  	//Cartao de Crédito	Inativo  
            Diners = 3,  	//Cartao de Crédito	Cielo  Clear Sale  
            Discover = 5,  	//Cartao de Crédito	Inativo  
            Elo = 9,  	//Cartao de Crédito	Cielo  Clear Sale  
            Hipercard = 8,  	//Cartao de Crédito	Inativo  
            JCB = 21,  	//Cartao de Crédito	Inativo  
            Mastercard = 4,  	//Cartao de Crédito	Cielo  Clear Sale  
            Naranja = 35,  	//Cartao de Crédito	Inativo  
            Nativa = 34,  	//Cartao de Crédito	Inativo  
            Nevada = 36,  	//Cartao de Crédito	Inativo  
            Shopping = 37,  	//Cartao de Crédito	Inativo  
            Visa = 2,  	//Cartao de Crédito	Cielo  Clear Sale  
            Boleto_Bancário = 6,    //Boleto Bancário	Boleto B B  Sem antifraude 
            Débito_Online = 19,  	//Cartao de Débito	Inativo  
            Maestro = 39,  	//Cartao de Débito	Inativo  
            Visa_Electron = 10,  	//Cartao de Débito	Inativo  
            PayPal = 12,  	//PayPal	Inativo  
            Vale = 16,  	//Vale Presente	Vtex Gift Card System   em antifraude 
            Promissory = 17,  	//Pagamentos Custom	Inativo  
            Mercado_Pago = 18,  	//Mercado Pago	Inativo  
            Alignet = 20,  	//alignet		Inativo  
            Débito_Banco_do_Brasil = 24,	//Débito	Inativo  
            Débito_Banrisul = 25,	//Débito	Inativo  
            Débito_Bradesco = 23,	//Débito	Inativo  
            Débito_Itau = 22,	//Débito	Inativo  
            Hsbc = 27,	//Débito	Inativo  
            PagSeguro = 26,	//PagSeguro	Inativo  
            Peela = 28,	//peela	Inativo  
            Webpay = 30,	//webpay	Inativo  
            PayClub = 32,    //payClub	Inativo  
            Safetypay = 38,	//safetypay	nativo  
            Koin_Pós_Pago = 40,	//boletoKoinPosPao	Inativo  
            Pago_Efectivo = 41,	//PagoEfectivo	Inativo  
            Cartão_BNDES = 201	//Pagamento Customizado       
        }
    }
}
