using System;

/*
    TO-DO

 - Criar um menu para o usuário escolher oque deseja fazer (Inserir ou retirar um veículo)
 - Criar sub-menu chamado após o primeiro menu, para escolher o tipo do veículo (moto, carro ou van)
 - De acordo com as escolhas nos menu's, retornar os status do estacionamento (os métodos)
 - Criar opção que aparecerá após os status, para ir ao menu novamente ou sair da aplicação.
*/

class Solution
{
    static void Main(string[] args)
    {
        Menu.ActionMenu();
    }
}

class Menu
{
    public static void ActionMenu()
    {
        string choice;
        do
        {
            Console.WriteLine("Escolha oque você deseja fazer:\n");
            Console.WriteLine("1 - Inserir um veículo");
            Console.WriteLine("2 - Retirar um veículo");
            Console.WriteLine("3 - Sair da aplicação\n");

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
                    Console.WriteLine("Tchau Tchau!\n");
                    break;
                default:
                    Console.WriteLine("{0} Não é um opção!", choice);
                    break;
            }

        } while (choice != "3");
    }

    public static void InsertRemoveMenu(Boolean insert)
    {
        string choice;
        string action = insert ? "INSERIR" : "REMOVER";
        string switchAction = insert ? "INSERIU" : "REMOVEU";
        do
        {
            Console.WriteLine($"Oque você deseja {action} no estacionamento:\n");
            Console.WriteLine($"1 - {action} uma moto");
            Console.WriteLine($"2 - {action} um carro");
            Console.WriteLine($"3 - {action} uma van");
            Console.WriteLine("4 - Retornar ao menu anterior\n");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Você {switchAction} uma moto");
                    break;
                case "2":
                    Console.WriteLine($"Você {switchAction} um carro");
                    break;
                case "3":
                    Console.WriteLine($"Você {switchAction} uma van");
                    break;
                case "4":
                    Console.WriteLine("Voltando...\n");
                    break;
                default:
                    Console.WriteLine("{0} Não é um opção!", choice);
                    break;
            }

        } while (choice != "4");
    }
}


