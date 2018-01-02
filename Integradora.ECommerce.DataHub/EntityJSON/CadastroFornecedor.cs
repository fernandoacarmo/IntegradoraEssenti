using Integradora.ECommerce.DataHub.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{

    public class DefinicoesFornecedor
    {
        public Int32 unidade { get; set; }
        public string condicaoPagamento { get; set; }
        public string operacaoRegistro { get; set; }
        public Int32 codigoEmpresa { get; set; }
        public Int32 codigoFilial { get; set; }
    }

    public class Fornecedor
    {
        public Fornecedor()
        {
            definicoesFornecedor = new List<DefinicoesFornecedor>();
        }

        public Int32 fornecedorIu { get; set; }
        public string nome { get; set; }
        public string idEspecialista { get; set; }
        public string razaoSocial { get; set; }
        public string tipoPessoa { get; set; }
        public string estrangeiro { get; set; }
        public string inscEstadual { get; set; }
        public string inscMunicipal { get; set; }
        public string cpfCnpj { get; set; }
        public string codigoSuframa { get; set; }
        public string endereco { get; set; }
        public string numeroEndereco { get; set; }
        public string complEndereco { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string dddFone1 { get; set; }
        public string telefone1 { get; set; }
        public string dddFone2 { get; set; }
        public string telefone2 { get; set; }
        public string dddFone3 { get; set; }
        public string telefone3 { get; set; }
        public string fax { get; set; }
        public Int32 cxPostal { get; set; }
        public string email { get; set; }
        public string situacao { get; set; }
        public Int32 codigoPais { get; set; }
        public string tipoFornecedor { get; set; }
        public string usuarioAlteracao { get; set; }
        public string operacaoRegistro { get; set; }
        public List<DefinicoesFornecedor> definicoesFornecedor { get; set; }
    }

    public class CadastroFornecedor : WebService
    {
        public CadastroFornecedor()
        {
            lista = new List<Fornecedor>();
        }

        public List<Fornecedor> lista { get; set; }

        public override string GetUrl()
        {
            return MontarUrl("Fornecedor");
        }
    }
}
