using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integradora.ERP.Winthor.Login
{
    public class LojasWinThorIni
    {
        public string Nome { get; set; }

        private List<string> fEmpresas;

        public List<string> Empresas { get { return fEmpresas; } set { } }

        public LojasWinThorIni(string nomeLoja)
        {
            this.Nome = nomeLoja;
            fEmpresas = new List<string>();
        }
    }

    public class ListaLojasDTO : List<LojasWinThorIni>
    {
        public ListaLojasDTO()
        {
        }

        public LojasWinThorIni ObterLoja(string nome)
        {
            return Find(filtro => filtro.Nome == nome);
        }

        public void Ordenar()
        {
            this.Sort(delegate(LojasWinThorIni obj1, LojasWinThorIni obj2) { return string.Compare(obj1.Nome, obj2.Nome); });
        }
    }

}
