using Integradora.ECommerce.DataHub.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{
    public class DefinicoesCliente
    {
        public Int32 unidade { get; set; }
        public Int32 codigoRepresentante { get; set; }
        public string condicaoPagamento { get; set; }
        public Int32 codigoEmpresa { get; set; }
        public Int32 codigoFilial { get; set; }
    }

    public class Cliente
    {
        public Cliente()
        {
            definicoesCliente = new List<DefinicoesCliente>();
        }
        public string nome { get; set; }
        public string idEspecialista { get; set; }
        public string nomeFantasia { get; set; }
        public string tipoCliente { get; set; }
        public string tipoMercado { get; set; }
        public Int32 tipoAcerto { get; set; }
        public string contribuinteICMS { get; set; }
        public string inscEstadual { get; set; }
        public string inscMunicipal { get; set; }
        public string cpfCnpj { get; set; }
        public string beneficioFiscal { get; set; }
        public string inscAliqSuframa { get; set; }
        public string endereco { get; set; }
        public string numeroEndereco { get; set; }
        public string complEndereco { get; set; }
        public string refEndereco { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string codigoPais { get; set; }
        public string ddd1 { get; set; }
        public string ddd2 { get; set; }
        public string ddd3 { get; set; }
        public string ddd4 { get; set; }
        public string ddd5 { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string telefone3 { get; set; }
        public string telefone4 { get; set; }
        public string telefone5 { get; set; }
        public string fax { get; set; }
        public Int32 cxPostal { get; set; }
        public string email { get; set; }
        public string situacao { get; set; }
        public Int32 usuarioAlteracao { get; set; }
        public string emailNFE { get; set; }
        public Int32 idSistemaEspecialista { get; set; }
        public string operacaoRegistro { get; set; }
        public List<DefinicoesCliente> definicoesCliente { get; set; }
    }

    public class CadastroCliente : WebService
    {
        public CadastroCliente()
        {
            lista = new List<Cliente>();
        }

        public List<Cliente> lista { get; set; }

        public override string GetUrl()
        {
            return MontarUrl("Clientes");
        }
    }
}
