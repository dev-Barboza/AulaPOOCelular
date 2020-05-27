using System;
using AulaPOOcelular;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            celular Iphone = new celular();
            Iphone.cor = "red";
            Iphone.modelo = "Iphone 8";
            Iphone.tamanho = 4;
            Iphone.ligado = true;
            Iphone.memoria = "5GB";
            
            Console.WriteLine();
            Console.WriteLine (Iphone.modelo + " " + Iphone.cor + Iphone.memoria );
            Console.WriteLine();
            Console.WriteLine (Iphone.Ligar());
            Console.WriteLine();  
            
            Console.WriteLine();
            Console.WriteLine (Iphone.FazerLigacao());
            Console.WriteLine();
            Console.WriteLine (Iphone.EnviarMensagem());
        }
    }
}