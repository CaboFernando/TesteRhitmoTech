using System;

/*
    TO-DO

 - [100%] Criar um menu para o usuário escolher oque deseja fazer (Inserir ou retirar um veículo)
 - [100%] Criar sub-menu chamado após o primeiro menu, para escolher o tipo do veículo (moto, carro ou van)
 - [100%] De acordo com as escolhas nos menu's, retornar os status do estacionamento (os métodos)
 - [100%] Criar opção que aparecerá após os status, para ir ao menu novamente ou sair da aplicação.
 - [100%] Criação opções no menu para verificar os status das vagas
 - [0%] Lógica para salvar veículos em vagas diferentes
*/

/*
 - vaga para moto -> 1 espaço
 - vaga para carro -> 2 espaços
 - vaga para van -> 6 espaços
*/

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
    string[] motos = new string[4];
    string[] carros = new string[4];
    string[] vans = new string[4];

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
                    if (HasVacancies(motos))
                    {
                        AddVehicle(typeVehicle);
                        Console.WriteLine($"\nVocê INSERIU uma moto\n");
                        break;
                    }
                    Console.WriteLine($"\nNão tem mais vagas para motos\n");
                    break;
                }
                else
                {
                    if (HasNoVacancies(motos))
                    {
                        RemoveVehicle(typeVehicle);
                        Console.WriteLine($"\nVocê REMOVEU uma moto\n");
                        break;
                    }
                    Console.WriteLine($"\nNão tem mais motos para se retirar\n");
                    break;
                }
            case 2:
                if (incert)
                {
                    if (HasVacancies(carros))
                    {
                        AddVehicle(typeVehicle);
                        Console.WriteLine($"\nVocê INSERIU um carro\n");
                        break;
                    }
                    Console.WriteLine($"\nNão tem mais vagas para carros\n");
                    break;
                }
                else
                {
                    if (HasNoVacancies(carros))
                    {
                        RemoveVehicle(typeVehicle);
                        Console.WriteLine($"\nVocê REMOVEU um carro\n");
                        break;
                    }
                    Console.WriteLine($"\nNão tem mais carros para se retirar\n");
                    break;
                }
            case 3:
                if (incert)
                {
                    if (HasVacancies(vans))
                    {
                        AddVehicle(typeVehicle);
                        Console.WriteLine($"\nVocê INSERIU uma van\n");
                        break;
                    }
                    Console.WriteLine($"\nNão tem mais vagas para vans\n");
                    break;
                }
                else
                {
                    if (HasNoVacancies(vans))
                    {
                        RemoveVehicle(typeVehicle);
                        Console.WriteLine($"\nVocê REMOVEU uma van\n");
                        break;
                    }
                    Console.WriteLine($"\nNão tem mais vans para se retirar\n");
                    break;
                }
            default:
                break;
        }
    }

    public bool HasVacancies(string[] vehicles)
    {
        for (int i = 0; i < vehicles.Length; i++)
        {
            if (vehicles[i] == null) return true;
        }

        return false;
    }

    public bool HasNoVacancies(string[] vehicles)
    {
        for (int i = 0; i < vehicles.Length; i++)
        {
            if (vehicles[i] != null) return true;
        }

        return false;
    }

    public void AddVehicle(int typeVehicle)
    {
        switch (typeVehicle)
        {
            case 1:
                for (int i = 0; i < motos.Length; i++)
                {
                    if (motos[i] == null)
                    {
                        motos[i] = "1";
                        break;
                    }

                }
                break;
            case 2:
                for (int i = 0; i < carros.Length; i++)
                {
                    if (carros[i] == null)
                    {
                        carros[i] = "1";
                        break;
                    }

                }
                break;
            case 3:
                for (int i = 0; i < vans.Length; i++)
                {
                    if (vans[i] == null)
                    {
                        vans[i] = "1";
                        break;
                    }
                }
                break;

            default:
                break;
        }
    }

    public void RemoveVehicle(int typeVehicle)
    {
        switch (typeVehicle)
        {
            case 1:
                for (int i = 0; i < motos.Length; i++)
                {
                    if (motos[i] != null)
                    {
                        motos[i] = null;
                        break;
                    }
                }
                break;
            case 2:
                for (int i = 0; i < carros.Length; i++)
                {
                    if (carros[i] != null)
                    {
                        carros[i] = null;
                        break;
                    }
                }
                break;
            case 3:
                for (int i = 0; i < vans.Length; i++)
                {
                    if (vans[i] != null)
                    {
                        vans[i] = null;
                        break;
                    }
                }
                break;

            default:
                break;
        }
    }

    public void CheckStatus()
    {
        int qtdMoto = motos.Where(x => x == null).Count();
        int qtdCar = carros.Where(x => x == null).Count();
        int qtdVan = vans.Where(x => x == null).Count();

        Console.WriteLine("\nStatus do estacionamento:\n");
        Console.WriteLine("- Quantidade de vagas totais: 12");
        Console.WriteLine($"- Quantidade de vagas restantes: \n\tMotos --> {qtdMoto} \n\tCarros -> {qtdCar} \n\tVans ---> {qtdVan}\n");        
    }

}