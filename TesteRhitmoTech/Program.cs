using System;

/*
    TO-DO

 - [100%] Criar um menu para o usuário escolher oque deseja fazer (Inserir ou retirar um veículo)
 - [100%] Criar sub-menu chamado após o primeiro menu, para escolher o tipo do veículo (moto, carro ou van)
 - [100%] De acordo com as escolhas nos menu's, retornar os status do estacionamento (os métodos)
 - [100%] Criar opção que aparecerá após os status, para ir ao menu novamente ou sair da aplicação.
 - [100%] Criação opções no menu para verificar os status das vagas
 - [100%] Lógica para salvar veículos em vagas diferentes
*/

/*
 - vaga para moto -> 1 espaço
 - vaga para carro -> 2 espaços
 - vaga para van -> 6 espaços
*/

// Link do repositório no GitHub: https://github.com/CaboFernando/TesteRhitmoTech

class Solution
{
    static void Main(string[] args)
    {
        Estacionamento estacionamento = new Estacionamento();

        estacionamento.ActionMenu();
    }
}

class Estacionamento
{
    int qtdMotos = 0;
    int qtdCarros = 0;
    int qtdVans = 0;
    int vagasMotos = 0;
    int vagasCarros = 0;
    int vagasVans = 0;

    public void ActionMenu()
    {
        string choice;
        do
        {
            Console.WriteLine("Escolha oque você deseja fazer:\n");
            Console.WriteLine("1 - Inserir um veículo");
            Console.WriteLine("2 - Retirar um veículo");
            Console.WriteLine("3 - Status do estacionamento");
            Console.WriteLine("4 - Sair da aplicação\n");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    InsertRemoveMenu(true);
                    break;
                case "2":
                    InsertRemoveMenu(false);
                    break;
                case "3":
                    CheckStatus();
                    break;
                case "4":
                    Console.WriteLine("\nTchau Tchau!\n");
                    break;
                default:
                    Console.WriteLine("\n{0} Não é um opção!\n", choice);
                    break;
            }

        } while (choice != "4");
    }

    public void InsertRemoveMenu(bool insert)
    {
        string choice;
        string action = insert ? "INSERIR" : "REMOVER";
        do
        {
            Console.WriteLine($"\nOque você deseja {action} no estacionamento:\n");
            Console.WriteLine($"1 - {action} uma moto");
            Console.WriteLine($"2 - {action} um carro");
            Console.WriteLine($"3 - {action} uma van");
            Console.WriteLine("4 - Retornar ao menu anterior\n");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddRemoveVeiculo(insert, int.Parse(choice));
                    break;
                case "2":
                    AddRemoveVeiculo(insert, int.Parse(choice));
                    break;
                case "3":
                    AddRemoveVeiculo(insert, int.Parse(choice));
                    break;
                case "4":
                    Console.WriteLine("\nVoltando...\n");
                    break;
                default:
                    Console.WriteLine("\n{0} Não é um opção!\n", choice);
                    break;
            }

        } while (choice != "4");
    }

    public void AddRemoveVeiculo(bool incert, int typeVehicle)
    {
        switch (typeVehicle)
        {
            case 1:
                if (incert)
                {
                    if(vagasMotos < 4)
                    {
                        Console.WriteLine($"\nVocê INSERIU uma moto na vaga para motos\n");
                        qtdMotos++;
                        vagasMotos++;
                        break;
                    }
                    if(vagasMotos == 4 && vagasCarros < 4)
                    {
                        Console.WriteLine($"\nAs vagas para motos estão cheias!\n");
                        Console.WriteLine($"\nVocê INSERIU uma moto na vaga para carros\n");
                        qtdMotos++;
                        vagasCarros++;
                        break;
                    }
                    if (vagasMotos == 4 && vagasCarros == 4 && vagasVans < 4)
                    {
                        Console.WriteLine($"\nAs vagas para carros estão cheias!\n");
                        Console.WriteLine($"\nVocê INSERIU uma moto na vaga para vans\n");
                        qtdMotos++;
                        vagasVans++;
                        break;
                    }                    
                    Console.WriteLine($"\nTodas vagas para motos do estacionamento estão cheias!\n");
                    break;
                }
                else
                {
                    if (qtdMotos > 8 && vagasMotos == 4 && vagasCarros == 4 && vagasVans == 4)
                    {
                        Console.WriteLine($"\nVocê REMOVEU uma moto da vaga para vans\n");
                        qtdMotos--;
                        vagasVans--;
                        break;
                    }
                    if (qtdMotos > 4 && vagasMotos == 4 && vagasCarros > 0)
                    {
                        Console.WriteLine($"\nVocê REMOVEU uma moto da vaga para carros\n");
                        qtdMotos--;
                        vagasCarros--;
                        break;
                    }
                    if (qtdMotos > 0 && vagasMotos > 0)
                    {
                        Console.WriteLine($"\nVocê REMOVEU uma moto da vaga para vans\n");
                        qtdMotos--;
                        vagasMotos--;
                        break;
                    }
                    Console.WriteLine($"\nTodas vagas para motos do estacionamento estão vazias!\n");
                    break;
                }
            case 2:
                if (incert)
                {
                    if (vagasCarros < 4)
                    {
                        Console.WriteLine($"\nVocê INSERIU um carro na vaga para carros\n");
                        qtdCarros++;
                        vagasCarros++;
                        break;
                    }
                    if (vagasCarros == 4 && vagasVans < 4)
                    {
                        Console.WriteLine($"\nAs vagas para carros estão cheias!\n");
                        Console.WriteLine($"\nVocê INSERIU um carro na vaga para vans\n");
                        qtdCarros++;
                        vagasVans++;
                        break;
                    }
                    Console.WriteLine($"\nTodas vagas para carros do estacionamento estão cheias!\n");
                    break;
                }
                else
                {
                    if (qtdCarros > 4 && vagasCarros == 4 && vagasVans > 0)
                    {
                        Console.WriteLine($"\nVocê REMOVEU um carro da vaga para vans\n");
                        qtdCarros--;
                        vagasVans--;
                        break;
                    }
                    if (qtdCarros > 0 && vagasCarros > 0)
                    {
                        Console.WriteLine($"\nVocê REMOVEU um carro da vaga para carros\n");
                        qtdCarros--;
                        vagasCarros--;
                        break;
                    }
                    Console.WriteLine($"\nTodas vagas para carros do estacionamento estão vazias!\n");
                    break;
                }
            case 3:
                if (incert)
                {
                    if (vagasVans < 4)
                    {
                        Console.WriteLine($"\nVocê INSERIU uma van na vaga para vans\n");
                        qtdVans++;
                        vagasVans++;
                        break;
                    }
                    if (vagasVans == 4 && vagasCarros <= 1)
                    {
                        Console.WriteLine($"\nAs vagas para vans estão cheias!\n");
                        Console.WriteLine($"\nVocê INSERIU uma van na vaga para 3 carros\n");
                        qtdVans++;
                        vagasCarros += 3;
                        break;
                    }
                    Console.WriteLine($"\nTodas vagas para vans do estacionamento estão cheias!\n");
                    break;
                }
                else
                {
                    if (qtdVans > 4 && vagasVans == 4 && vagasCarros > 2)
                    {
                        Console.WriteLine($"\nVocê REMOVEU uma van da vaga para 3 carros\n");
                        qtdVans--;
                        vagasCarros -= 3;
                        break;
                    }
                    if (qtdVans > 0 && vagasVans > 0)
                    {
                        Console.WriteLine($"\nVocê REMOVEU uma van da vaga para vans\n");
                        qtdVans--;
                        vagasVans--;
                        break;
                    }
                    Console.WriteLine($"\nTodas vagas para vans do estacionamento estão vazias!\n");
                    break;
                }
            default:
                break;
        }
    }

    public void CheckStatus()
    {
        int total = 12;


        Console.WriteLine("\nStatus do estacionamento:\n");
        Console.WriteLine($"- Quantidade de vagas totais: {total}");
        Console.WriteLine($"- Quantidade de motos: {qtdMotos}");
        Console.WriteLine($"- Quantidade de carros: {qtdCarros}");
        Console.WriteLine($"- Quantidade de vans: {qtdVans}");
        Console.WriteLine($"- Quantidade de vagas restantes: \n\tMotos --> 4/{vagasMotos} \n\tCarros -> 4/{vagasCarros} \n\tVans ---> 4/{vagasVans}\n");        
    }

}