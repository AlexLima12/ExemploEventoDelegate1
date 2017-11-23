using System;

namespace ExemploEvento1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(10, "011 654513245");
            carro.TanqueVazio += new Carro.EventoCarro(taque_vazio);
            carro.TanqueVazio += new Carro.EventoCarro(ligar_uber);
            carro.Ligacao += new Carro.Chamar(ligar_casa);
            carro.Ligar();
        }
        static void taque_vazio()
        {
            System.Console.WriteLine("Tanque vazio");

        }

        static void ligar_uber(){
            System.Console.WriteLine("Chamar o Uber...");
        }

        static void ligar_casa(string telefone){
            System.Console.WriteLine("Ligando: " + telefone);
        }
    }
}
