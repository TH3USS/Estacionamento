using EstacionamentoSystem.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n\n" +
                  "Digite o preço inicial:");

precoInicial = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento e = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("=====================\n" + 
                        "Digite a sua opção:\n" + 
                        "=====================");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar\n" + 
                        "=====================");

    switch(Console.ReadLine()){
        case "1":
        e.Adicionar();
        break;

        case "2":
        e.Remover();
        break;

        case "3":
        e.MostrarLista();
        break;

        case "4":
        exibirMenu = false;
        break;

        default:
        Console.WriteLine("Opção inválida");
        break;
    }
    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadLine();

}
Console.WriteLine("O programa se encerrou");