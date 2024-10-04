using HOSPEDAGEM_DE_HOTEL.Models;
Reserva reserva = new Reserva();
bool Encerrar = true;
int OpcoesTerminal;

 //FIZ DO ZERO, APENAS COM O QUE APRENDI NA DIO ATÉ AGORA!      

while(Encerrar)
{
Console.WriteLine("BEM VINDO AO HOTEL ESTRELA, ESCOLHA SUA OPÇÃO:");
Console.WriteLine($"1---Cadastrar Hospedes.");
Console.WriteLine($"2---Mostrar Suites.");
Console.WriteLine($"3---Obter Quantidade de Hospedes.");
Console.WriteLine($"4---Cadastrar suite.");
Console.WriteLine($"5---Encerrar Programa.");

OpcoesTerminal = Convert.ToInt32(Console.ReadLine());
if(OpcoesTerminal <= 0 || OpcoesTerminal > 5)
{Console.WriteLine("Opção Inválida.");}

switch(OpcoesTerminal)
{
    case 1: reserva.CadastrarHospedes();
    break;

    case 2: reserva.MostrarSuite();
    break;

    case 3: reserva.MostrarQuantidadeDeHospedes();
    break;

    case 4: reserva.CadastrarSuites();
    break;

    case 5: Encerrar = false;
    Console.WriteLine("Programa encerrado/ dados apagados.");
    break;
}


}