using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Trabalhando_Com_Arquivos._196_FileStream_StreamReader
{
    public class Run
    {
        static void Main(string[] args)
        {
            //  FileStream
            // - Disponibiliza uma stream associada a um arquivo, permitindo operações de leitura e escrita.
            // - Suporte a dados binários.
            //  Instanciação:
            // - Vários construtores
            // - File / FileInfo


            //   StreamReader
            // É uma stream capaz de ler caracteres a partir de uma stream binária(ex: FileStream).
            // Suporte a dados no formato de texto.
            // Instanciação:
            // - Vários construtores
            // - File / FileInfo

            string path = @"C:\Users\Wendell\Desktop\Programação\file1.txt.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
