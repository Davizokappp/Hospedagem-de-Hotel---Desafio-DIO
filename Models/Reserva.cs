using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HOSPEDAGEM_DE_HOTEL.Models
{
    public class Reserva
    {
        int QuantidadeDeHospedes;
        string nome;
        string sobrenome;
        int QuantidadeDeDias;

        List<Pessoa> Hospedes = new List<Pessoa>();
       
        public void CadastrarHospedes()
        {
            Console.WriteLine("Informe o Primeiro Nome do Comprador:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o Sobrenome do Comprador:");
            sobrenome = Console.ReadLine();
            if(nome == "" || sobrenome == "")
            {Console.WriteLine("Não pode ser um Nome ou Sobrenome Vazio");}
            else
            {
                Pessoa P1 = new Pessoa(nome, sobrenome);
                Hospedes.Add(P1);
                Console.WriteLine("Comprador cadastrado com sucesso!");
            }

            Console.WriteLine($"Agora nos informe a quantidade de pessoas descontando o Comprador:");
            QuantidadeDeHospedes = Convert.ToInt32(Console.ReadLine());
            if(QuantidadeDeHospedes <= 0 || QuantidadeDeHospedes >= 10)
            {
                Console.WriteLine("O número de hospedes não pode ser menor que 0 ou maior que 10.");
            }
            else
            {
                Console.WriteLine("Número de Hospedes cadastrados com sucesso.");
            }
            Console.WriteLine("Por fim nos informe a quantidade de dias que pretende reservar a suite:");
            QuantidadeDeDias = Convert.ToInt32(Console.ReadLine());

            if(QuantidadeDeDias <= 0 || QuantidadeDeDias >= 31)
            {
                Console.WriteLine("Não é possível reservar um número menor do que 0 ou maior que o período de 31 dias.");
            }
            else
            {Console.WriteLine("Cadastro feito. Vá para a opção 4, para finalizar o cadastro.");}
        }

        public void MostrarSuite()
        {
        Suite S1 = new Suite("Premium", 10, 350.00M);
        Suite S2 = new Suite("Casual", 5, 200.00M);
        Suite S3 = new Suite("Luxuosa", 5, 500.00M);
        Suite S4 = new Suite("Luxuosa Extra", 10, 1000.00M);
        List<Suite> suites = new List<Suite>();
        suites.Add(S1);
        suites.Add(S2);
        suites.Add(S3);
        suites.Add(S4);

        foreach (Suite suite in suites)
        {
            Console.WriteLine($"Tipo de Suite: {suite.TipoDeSuite}");
          
            Console.WriteLine($"Capacidade máxima de hospedes: {suite.Capacidade}");
         
            Console.WriteLine($"Valor da diária sem desconto: {suite.ValorDaDiaria}");
          
        }
        }

        public void MostrarQuantidadeDeHospedes()
        {
            int QuantidadeDeHospedes2 = QuantidadeDeHospedes + 1;
            Console.WriteLine($"O número total de hospedes é: {QuantidadeDeHospedes2}");
        }

        public void CadastrarSuites()
        {
            if(QuantidadeDeDias == 0)
            {
             throw new ArgumentException("Por favor, primeiro realize o cadastro da opção 1.");
            }
            Console.WriteLine($"Muito bem {nome} {sobrenome}, escolha agora a opção de suite:");
            Console.WriteLine($"1---Suite Casual.");
            Console.WriteLine($"2---Suite Premium.");
            Console.WriteLine($"3---Suite Luxuosa.");
            Console.WriteLine($"4---Suite Luxuosa Extra.");
            int quant = Convert.ToInt32(Console.ReadLine());

            if(quant > 4 || quant < 1)
            {Console.WriteLine("Opção Inválida.");}

            switch(quant)
            {
                case 1:
                if(QuantidadeDeHospedes+1 > 5)
                {Console.WriteLine("O número de Hospedes é maior que a capacidade da suite.");
                Environment.Exit(0);
                }

               decimal ValorS1 = 200.00M * QuantidadeDeDias;
               Console.WriteLine($"O valor total da hospedagem será: {ValorS1:C}");
               Environment.Exit(0);
                break;

                case 2:
                if(QuantidadeDeHospedes+1 > 10)
                {Console.WriteLine("O número de Hospedes é maior que a capacidade da suite.");
                Environment.Exit(0);
                }
                else
                {
                    decimal ValorS2 = 350.00M * QuantidadeDeDias;
                    if(QuantidadeDeDias >= 10)
                    {ValorS2 = 350.00m * QuantidadeDeDias;}
                    decimal ValorS2_ = ValorS2 - ValorS2 * 0.10m;
                    Console.WriteLine($"O valor total da hospedagem será: {ValorS2_:C}");
                    Environment.Exit(0);
                }
                break;

                case 3:
                if(QuantidadeDeHospedes > 5)
                {Console.WriteLine("O número de Hospedes é maior que a capacidade da suite.");
                Environment.Exit(0);
                }
                else
                {
                    decimal ValorS3 = 500.00M * QuantidadeDeDias;
                    if(QuantidadeDeDias >= 10)
                    {ValorS3 = ValorS3 - ValorS3 *0.10m;}
                    Console.WriteLine($"O valor total da hospedagem será: {ValorS3:C}");
                    Environment.Exit(0);
                }
                break;

                case 4:
                if(QuantidadeDeHospedes > 10)
                {Console.WriteLine("O número de Hospedes é maior que a capacidade da suite.");
                Environment.Exit(0);
                }
                else
                {
                    decimal ValorS4 = 1000.00m * QuantidadeDeDias;
                    if(QuantidadeDeDias >= 10)
                    {ValorS4 = ValorS4 - ValorS4 * 0.10m;}
                    Console.WriteLine($"O valor total da hospedagem será: {ValorS4:C}");
                    Environment.Exit(0);
                }
                break;
            }


        }










    }      
} 