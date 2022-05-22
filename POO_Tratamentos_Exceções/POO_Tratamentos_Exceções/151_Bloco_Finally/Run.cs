using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tratamentos_Exceções._151_Bloco_Finally
{
    public class Run
    {
        static void Main(string[] args)
        {
            // - É um bloco que contém código a ser executado independentemente de ter ocorrido ou não uma exceção.
            // - Exemplo clássico: fechar um arquivo ou conexão de banco de dados ao final do processamento.
            // Sintaxe:
            // try {
            //  executar
            // }
            // catch (ExceptionType e) {
            //  pegando o erro
            // }
            // finally {
            //  executa idependente de dar erro ou não
            // }

            //    ***     EXEMPLO     ***
            //public class ProcessFile
            //{
            //    public static void Main()
            //    {
            //        FileStream fs = null;
            //        try
            //        {
            //            fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
            //            StreamReader sr = new StreamReader(fs);
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //        catch (FileNotFoundException e)
            //        {
            //            Console.WriteLine(e.Message);
            //        }
            //        finally
            //        {
            //            if (fs != null)
            //            {
            //                fs.Close();
            //            }
            //        }
            //    }
            //}
        }
    }
}
