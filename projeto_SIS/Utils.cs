using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_SIS
{
    class Utils
    {

        public static void escreverParaFicheiro(string RespostaOuPedido, string url, string metodo, IList<Parameter> parametros) {
            using (StreamWriter writeText = new StreamWriter("log.txt", true)) {
                DateTime agora = DateTime.Now;
                writeText.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------");
                writeText.WriteLine(" ");
                writeText.WriteLine(agora.ToShortDateString() + " " + agora.ToLongTimeString() + "\t \t ------" + RespostaOuPedido + "------");
                writeText.WriteLine(" URL ->" + url + " | Metodo: " + metodo + "\n");
                string campos = null;
                if (parametros != null) {
                    foreach (Parameter item in parametros)
                    {
                        if (item.Name != "application/json")
                            writeText.WriteLine(campos = "\t\t\t" + item.Name + ": " + item.Value);

                        if (item.Name == "application/json")
                            writeText.WriteLine(campos = "\t\t\t Body: " + item.Value);
                    }
                }

            }
        }

        public static void escreverParaFicheiro2(string RespostaOuPedido, string url, string metodo, string body)
        {
            using (StreamWriter writeText = new StreamWriter("log.txt", true))
            {
                DateTime agora = DateTime.Now;
                writeText.WriteLine(" ");
                writeText.WriteLine(agora.ToShortDateString() + " " + agora.ToLongTimeString() + "\t \t ------" + RespostaOuPedido + "------");
                writeText.WriteLine(" URL ->" + url + " | Metodo: " + metodo + "\n");
                writeText.WriteLine("\t \t Body: " + body);
                writeText.WriteLine("");
               
            }
        }
    }
}
