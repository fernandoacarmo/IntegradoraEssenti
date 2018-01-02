using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Database.Oracle
{
    /// <summary>
    /// Manutenção do banco de dados criandos os campos que faltam
    /// </summary>
    public class Manutencao
    {
        string connection = "";
        public Manutencao(string StringConnection)
        {
            connection = StringConnection; 
        }
        public bool ObjetoExisteNoBancoDados(string tabela, string filtro)
        {
            Persistencia ba = new Persistencia(connection);
            return ba.Contar(tabela, filtro) > 0;
        }
        public bool TabelaExiste(string tabela)
        {
            const string tabelaconsulta = "USER_TABLES";
            return ObjetoExisteNoBancoDados(tabelaconsulta, "TABLE_NAME = '" + tabela + "'");
        }
        public bool CampoExiste(string tabela, string campo)
        {
            const string tabelaconsulta = "USER_TAB_COLUMNS";
            return ObjetoExisteNoBancoDados(tabelaconsulta, "TABLE_NAME = '" + tabela + "' and COLUMN_NAME = '" + campo + "'");
        }
        public bool SequenceExiste(string sequence)
        {
            const string tabelaconsulta = "USER_SEQUENCES";
            return ObjetoExisteNoBancoDados(tabelaconsulta, "SEQUENCE_NAME = '" + sequence + "'");
        }
        public bool ViewExiste(string view)
        {
            const string tabelaconsulta = "USER_VIEWS";
            return ObjetoExisteNoBancoDados(tabelaconsulta, "VIEW_NAME = '" + view + "'");
        }
        public bool TriggerExiste(string trigger)
        {
            const string tabelaconsulta = "USER_TRIGGERS";
            return ObjetoExisteNoBancoDados(tabelaconsulta, "TRIGGER_NAME = '" + trigger + "'");
        }
        public bool ObjetoeExiste(string objeto)
        {
            const string tabelaconsulta = "USER_OBJECTS";
            return ObjetoExisteNoBancoDados(tabelaconsulta, "OBJECT_NAME = '" + objeto + "'");
        }
        public void SequenceCriar(string sequence)
        {
            string comando = "CREATE SEQUENCE " + sequence;
            //TODO: Comando para criar sequence
        }
        public void CampoValidarCriar(string nomeTabela, string nomeCampo, string tipoTamanho, bool Nulo)
        {
            if (!CampoExiste(nomeTabela.ToUpper(), nomeCampo.ToUpper()))
            {
                CampoCriar(nomeTabela.ToUpper(), nomeCampo.ToUpper(), tipoTamanho.ToUpper(), Nulo);
            }
        }

        public void CampoCriar(string nomeTabela, string nomeCampo, string tipoTamanho, bool Nulo)
        { 
            CampoCriar(nomeTabela, nomeCampo, tipoTamanho, "", Nulo);
        }
        public void CampoCriar(string nomeTabela, string nomeCampo, string tipoTamanho, string valordDefault, bool Nulo)
        { 
           string comando = "";
           if (string.IsNullOrEmpty(valordDefault))
           {
               comando = string.Format("ALTER TABLE {0} ADD {1} {2} {3} NULL", nomeTabela, nomeCampo, tipoTamanho, Nulo ? "" : "NOT");
           }
            else
           {
               comando = string.Format("ALTER TABLE {0} ADD {1} {2} DEFAULT {3} {4} NULL", nomeTabela, nomeCampo, tipoTamanho, valordDefault, Nulo ? "" : "NOT");
           }

           Persistencia ba = new Persistencia(connection);
           ba.Executar(comando);
        }

        public void Sequences(List<string> sequences)
        {
            foreach (var item in sequences)
            {
                if (!SequenceExiste(item))
                {
                    SequenceCriar(item);
                }
            }
        }
        public void Campo(string tabela, List<string> campos)
        {

        }
    }
}
