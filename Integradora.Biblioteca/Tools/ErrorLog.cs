using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Tools
{
    class ErrorLog
    {
        const long maxFileSize = 2097152;
        const string fileName = "Integradora_servico.log";

        private static void ClearLog()
        {
            if (!System.IO.File.Exists(fileName))
                System.IO.File.CreateText(fileName);
            else
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(fileName);
                while (fileInfo.Length > maxFileSize)
                {
                    // leitura do arquivo
                    List<string> logFile = new List<string>();
                    logFile.AddRange(System.IO.File.ReadAllLines(fileName));

                    // removendo uma linha para redução do arquivo
                    logFile.RemoveRange(0, 1);
                    System.IO.File.WriteAllLines(fileName, logFile);

                    // atualiza as informações do arquivo
                    fileInfo.Refresh();
                }
            }
        }

        public static void WriteLog(string className, string methodName, string errorMessage)
        {
            string log = string.Format("{0} \t {1} \t {2} \t {3}", DateTime.Now.ToString("G"), className, methodName, errorMessage);
            System.IO.File.AppendAllText(fileName, log);
            ClearLog();
        }
    }
}
