using System;
using System.IO;

namespace POO_Trabalhando_Com_Arquivos._195_File_FileInfo_IOException
{
    public class Run
    {
        static void Main(string[] args)
        {
            //       **** File, FileInfo ****
            //• Namespace System.IO
            //• Realiza operações com arquivos(create, copy, delete, move, open, etc.) e ajuda na criação de objetos FileStream.
            //• File
            // - static members (simples, mas realiza verificação de segurança para cada operação)
            // - https://msdn.microsoft.com/en-us/library/system.io.file(v=vs.110).aspx
            //• FileInfo
            // - instance members
            // - https://msdn.microsoft.com/en-us/library/system.io.fileinfo(v=vs.110).aspx

            //       **** IOException ****
            // Namespace System.IO
            //* IOException
            // - DirectoryNotFoundException = diretorio não existe
            // - DriveNotFoundException 
            // - EndOfStreamException
            // - FileLoadException
            // - FileNotFoundException
            // - PathTooLongException
            // - PipeException

            string sourcePath = @"C:\Users\Wendell\Desktop\Programação\file1.txt.txt";
            string targetPath = @"C:\Users\Wendell\Desktop\Programação\file2.txt.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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
