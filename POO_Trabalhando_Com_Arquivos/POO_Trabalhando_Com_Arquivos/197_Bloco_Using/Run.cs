using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Trabalhando_Com_Arquivos._197_Bloco_Using
{
    class Run
    {
        static void Main(string[] args)
        {
            // Sintaxe simplificada que garante que os objetos IDisposable serão fechados.
            // Objetos IDisposable NÃO são gerenciados pelo CLR.Eles precisam ser manualmente fechados.
            //Exemplos: Font, FileStream, StreamReader, StreamWriter

            string path = @"C:\Users\Wendell\Desktop\Programação\file1.txt.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
