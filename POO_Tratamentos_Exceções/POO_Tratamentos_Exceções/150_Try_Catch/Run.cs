﻿using System;

namespace POO_Tratamentos_Exceções._150_Try_Catch
{
    public class Run
    {
        static void Main(string[] args)
        {
            //            Estrutura try-catch
            // - Bloco try
            // - Contém o código que representa a execução normal do trecho de código que pode acarretar em uma exceção
            //
            // - Bloco catch
            // - Contém o código a ser executado caso uma exceção ocorra
            // - Deve ser especificado o tipo da exceção a ser tratada(upcasting é permitido)

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é permitido divizão por 0");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de entrada de dados, somente numeros por favor");
            }


        }
    }
}
