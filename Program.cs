using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double altura;
            double peso;
            double IMC;
            
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu Peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            IMC = peso / (altura * altura);

            Console.Clear();

            Console.WriteLine("\t <---Dados Pessoais--->");
            Console.WriteLine($"nome:  {nome}");
            Console.WriteLine($"idade: {idade} anos");
            Console.WriteLine($"Altura:  {altura}m");
            Console.WriteLine($"peso: {Math.Round(peso, 1)}kg");
            Console.Write("\n");

            Console.WriteLine("seu resultado de IMC é = {0}", Math.Round(IMC, 1));




            







        }
    }
}
