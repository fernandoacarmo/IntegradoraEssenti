using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integradora.ERP.Winthor.EntityPedidoDireto
{
    public class Cliente : BaseTabelas
    {
        public Cliente()
        {
            Inscricaoestadual = "ISENTO";
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIENTE
        /// Comentário: 
        /// </summary>
        private Int64 codcliente;
        public Int64 Codcliente
        {
            get { return codcliente; }
            set { codcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJCPF
        /// Comentário: 
        /// </summary>
        private String cnpjcpf;
        public String CNPJCPF
        {
            get { return cnpjcpf; }
            set { cnpjcpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INSCRICAOESTADUAL
        /// Comentário: 
        /// </summary>
        private String inscricaoestadual;
        public String Inscricaoestadual
        {
            get { return inscricaoestadual; }
            set { inscricaoestadual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAZAOSOCIAL
        /// Comentário: 
        /// </summary>
        private String razaosocial;
        public String Razaosocial
        {
            get { return razaosocial; }
            set { razaosocial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEFANTASIA
        /// Comentário: 
        /// </summary>
        private String nomefantasia;
        public String Nomefantasia
        {
            get { return nomefantasia; }
            set { nomefantasia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Comentário: 
        /// </summary>
        private String endereco;
        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO
        /// Comentário: 
        /// </summary>
        private String numero;
        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Comentário: 
        /// </summary>
        private String bairro;
        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Comentário: 
        /// </summary>
        private String cidade;
        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Comentário: 
        /// </summary>
        private String estado;
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Comentário: 
        /// </summary>
        private String cep;
        public String CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Comentário: 
        /// </summary>
        private String complemento;
        public String Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Comentário: 
        /// </summary>
        private String telefone;
        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAX
        /// Comentário: 
        /// </summary>
        private String fax;
        public String FAX
        {
            get { return fax; }
            set { fax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CELULAR
        /// Comentário: 
        /// </summary>
        private String celular;
        public String Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Comentário: 
        /// </summary>
        private String email;
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: 
        /// </summary>
        private Int64 codpraca;
        public Int64 Codpraca
        {
            get { return codpraca; }
            set { codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIBGE
        /// Comentário: 
        /// </summary>
        private Int64 codIBGE;
        public Int64 CodIBGE
        {
            get { return codIBGE; }
            set { codIBGE = value; }
        }


    }
}