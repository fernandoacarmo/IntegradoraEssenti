using Canducci.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.CEP
{
    public class Consultar
    {
        public static ZipCodeInfo ObterEndereco(string CEP)
        {
            try
            {
                ZipCodeInfo zipCodeInfo = ZipCodeLoad.Find(CEP);

                if (zipCodeInfo.Erro == false)
                {

                    //Zip Find
                    return zipCodeInfo;
                }
                else
                {
                    return ObterEndereco2(CEP);
                }
            }
            catch //(ZipCodeException ex)
            {
                return ObterEndereco2(CEP);
//                throw ex;
            }
        }


        public static ZipCodeInfo ObterEndereco2(string CEP)
        {
            try
            {

                CEPToolsweb.ServicoSoapClient webservice = new CEPToolsweb.ServicoSoapClient();
                webservice.Open();
                CEPToolsweb.CepVO resultado = webservice.ObterCep(CEP);

                ZipCodeInfo zipCodeInfo = new ZipCodeInfo();

                zipCodeInfo.Address = resultado.Logradouro;
                zipCodeInfo.City = resultado.Cidade;
                zipCodeInfo.Uf = resultado.Estado;
                zipCodeInfo.Ibge = Convert.ToInt32(resultado.Codigo);
                zipCodeInfo.District = resultado.Bairro;
                zipCodeInfo.Complement = resultado.Mensagem;
                zipCodeInfo.Zip = CEP;

                return zipCodeInfo;
            }
            catch
            {
                return null;
            }

        }

        public static string ObterEtiqueta(string cnpj)
        {            
            string resultado = "";
            try
            {
               
                BasicHttpsBinding binding = new BasicHttpsBinding();
                binding.Name = "AtendeClienteServiceSoapBinding1";
                binding.MaxReceivedMessageSize = 2147483647;
                binding.MaxBufferSize = 2147483647;
               
                //Endereço do webservice
                EndpointAddress remoteAddress = new EndpointAddress(Biblioteca.Dictionaries.Settings.Sigep_UrlProducao());
                
                //Carregando o webservice

                Sigep.AtendeClienteClient ws = new Sigep.AtendeClienteClient(binding, remoteAddress);
                ws.Open();

                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                var usuario = Biblioteca.Dictionaries.Settings.Sigep_Usuario();
                var senha = Biblioteca.Dictionaries.Settings.Sigep_Senha();

                Int32 CodigoServico =  Biblioteca.Dictionaries.Settings.Sigep_CodigoServico();
                if (CodigoServico <= 0)
                {
                    var contrato = Biblioteca.Dictionaries.Settings.Sigep_Contrato();
                    var cartao   = Biblioteca.Dictionaries.Settings.Sigep_Cartao();

                    var dadosCliente = ws.buscaCliente( contrato
                                                      , cartao
                                                      , usuario
                                                      , senha
                                                      );
                    if (dadosCliente != null)
                    {
                        CodigoServico = Convert.ToInt32(dadosCliente.id);
                    }
                }

                resultado = ws.solicitaEtiquetas("C"
                                                , cnpj
                                                , CodigoServico
                                                , 1
                                                , usuario
                                                , senha
                                                );
                //ws.solicitaEtiquetas(cor)
                if (!string.IsNullOrEmpty(resultado))
                {
                    string[] parametro = { resultado };
                    int[] digito = ws.geraDigitoVerificadorEtiquetas(parametro
                                                                    , usuario
                                                                    , senha
                                                                    );
                    if (digito != null)
                    {
                        resultado += digito[0].ToString();
                    }
                }
                ws.Close();
                Biblioteca.Tools.Logs.GerarLog("Integradora.CEP", "ObterEtiqueta", "Etiqueta do correio gerada com sucesso: " + resultado);
            }
            catch (Exception ex)
            {
                resultado = "";
                Biblioteca.Tools.Logs.GerarLog("Integradora.CEP", "ObterEtiqueta", "Erro ao gerar etiqueta do correio: " + ex.ToString());
            }

            return resultado;
        }
    }
}
