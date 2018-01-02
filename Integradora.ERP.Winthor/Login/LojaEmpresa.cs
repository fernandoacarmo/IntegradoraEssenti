using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integradora.ERP.Winthor.Login
{
    public class LojaEmpresa
    {
        List<string> _empresas;
        public string Loja { get; set; }
        public List<string> Empresas
        {
            get
            {
                if (this._empresas == null)
                {
                    this._empresas = new List<string>();
                }
                return this._empresas;
            }
            set
            {
                if (this._empresas != value)
                {
                    this._empresas = value;
                }
            }
        }
    }
}