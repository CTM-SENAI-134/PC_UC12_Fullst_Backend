using plantaoUC9.Classes;
using System;

//variável para armazenar a opção digitada pelo usuário
string? opcao;

do
{
    //limpar o console
    Console.Clear();

    //menu de opções
    Console.WriteLine(@"
         
    1 - Cadastrar PJ      
    2 - Listar PJ                                    
    0 - Sair
    ");

    //variável opção recebe a opção digitada
    opcao = Console.ReadLine();

    //instanciado um objeto para manipular os métodos de pessoa jurídica
    PessoaJuridica metodosPj = new PessoaJuridica();

    //estrutura condicional - switch case - comparação
    //compare a opção
    switch (opcao)
    {
        case "0":
            break;
        //caso a opção for 1
        case "1":

            //instanciado um objeto de pessoa juridica que receberá os valores das propriedades
            PessoaJuridica pj = new PessoaJuridica();

            //entrada do nome    
            Console.WriteLine("Digite o nome da PJ: ");
            pj.Nome = Console.ReadLine();

            //entrada do rendimento
            Console.WriteLine("Informe o rendimento: ");
            pj.Rendimento = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe um Cnpj válido (ex: XX.XXX.XXX/0001-XX): ");
            pj.Cnpj = Console.ReadLine();

            //chamada do método para inserir o objeto
            metodosPj.Inserir(pj);

            Console.WriteLine($"Cadastro realizado com sucesso !");
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            break;

        //caso a opção for 2
        case "2":

            //receba o nome do arquivo que se deseja ler - obs: sem o .txt
            Console.WriteLine($"Digite o nome do arquivo que deseja ler");
            string nomeArquivo = Console.ReadLine()!;

            //ler o arquivo e salvar dentro do objeto pessoaJuridica
            PessoaJuridica pessoaJuridica = metodosPj.Ler(nomeArquivo);

            //mostre no console os dados do objeto
            Console.WriteLine(@$"
                    Nome: {pessoaJuridica.Nome}
                    Rendimento: {pessoaJuridica.Rendimento}
                    Cnpj: {pessoaJuridica.Cnpj}
                    ");
            Console.ReadLine();
            break;

        default:
            Console.WriteLine("Opção inválida, escolha outra opção");
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            break;
    }
} while (opcao != "0");