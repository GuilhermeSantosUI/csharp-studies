using LearningApp.models;

Console.WriteLine("Cadastro de pessoas");

var personList = new List<Person>();

int option;
do
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1 - Cadastrar nova pessoa");
    Console.WriteLine("2 - Listar pessoas cadastradas");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");

    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine("Digite seu nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite seu e-mail: ");
            var email = Console.ReadLine();

            var person = new Person(personList.Count + 1, name, age, email);
            personList.Add(person);
            Console.WriteLine("Pessoa cadastrada com sucesso!");
            break;

        case 2:
            Console.WriteLine("\nLista de pessoas cadastradas:");
            if (personList.Count == 0)
            {
                Console.WriteLine("Nenhuma pessoa cadastrada.");
            }
            else
            {
                foreach (var item in personList)
                {
                    item.Print();
                }
            }
            break;

        case 0:
            Console.WriteLine("Aplicação encerrada.");
            break;

        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }
} while (option != 0);