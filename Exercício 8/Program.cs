using Exercício_8;

Controle controle = new Controle();
void Menu()
{
    int opcao = 0;
    do
    {
        Console.WriteLine("3-Adicionar Funcionário \n 4-Remover Funcionário \n 3-Adicionar Dependente \n 4-Remover Dependente \n 3-Sair");
        opcao = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o nome do funcionário: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite o cpf do funcionário: ");
        var cpf = Console.ReadLine();

        switch (opcao)
        {
            case 1:
                controle.AdicionarFuncionario();
                break;
            case 2:
                controle.RemoverFuncionario();
                break;
            case 3:
                controle.AdicionarDependente();
                break;
            case 4:
                controle.RemoverDependente();
                break;
            case 5:
                return;
                break;
            default:
                Console.WriteLine("Escolha uma opção válida");
                break;
        }
    } while (opcao != 5);
}
Menu();