using System;

namespace DiamanteLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma letra para criar o diamante de letras: ");

            string letra = Console.ReadLine();
            
            //pegar tanto variaveis minusculas e transformar todas em maiusculas

            letra = letra.ToUpper();

            //alfabeto
            string alfabeto = " ABCDEFGHIJKLMNORSTUVWXYZ";

            //transfomar cada letra em um char
            char[] alfabetoChars = alfabeto.ToCharArray();

            int letraDiamante = Convert.ToChar(letra);// converter para usar no for.

            letraDiamante = letraDiamante - 64; // Transformando o valor da Letra para um numero 1,2,3


            #region Parte cima 
            for(int i = 0; i < letraDiamante; i++)
            {
                //printar A
                if(i == 0)
                {
                    for (int j = 0; j < letraDiamante - i; j++)
                    {
                        //pular espaços
                        Console.Write(" ");
                    }
                    Console.Write(alfabetoChars[i + 1]);
                    Console.WriteLine();
                    Console.WriteLine();
                } 
                else {
                    for (int j = 0; j < letraDiamante - i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(alfabetoChars[i + 1]);
                    

                    //contador de letras
                    int cont = (2 * i) + 1;

                    //espaços e mais a letra seguinte
                    for (int k = 0; k < cont - 2; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(alfabetoChars[i + 1]);

                    Console.WriteLine();

                    Console.WriteLine();

                }

            }
#endregion
            #region Parte baixo
            //decrementar a letra e abrir espaços
            for (int i = letraDiamante - 2; i >= 0 ; i--)
            {

                if (i == 0)
                {
                    for (int j = 0; j < letraDiamante - i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(alfabetoChars[i + 1]);
                    Console.WriteLine();
                    
                }
                else
                {
                    
                    for (int j = 0; j < letraDiamante - i; j++)
                    {
                        Console.Write(" ");

                    }
                    
                    Console.Write(alfabetoChars[i + 1]);

                    


                    //contador de espaços e letras
                    int cont = (2 * i) + 1;


                    for (int k = 0; k < cont - 2; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(alfabetoChars[i + 1]);

                    Console.WriteLine();

                    Console.WriteLine();
                }
                
            }
            Console.ReadLine();
            #endregion

        }
    }
}
