using cadastro.Classes;

Console.Clear();
Console.WriteLine(@$"
*****************************************
*  Bem Vindo ao sistema de cadastro de  *
*      pessoas físicas e jurídicas      *
*****************************************

       █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
       █░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█
       █░░║║║╠─║─║─║║║║║╠─░░█
       █░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█
       █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█
");

LoadingBar("Iniciando ", 500, 20);

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
*****************************************
*     Escolha uma das opções abaixo:    *
*           1 - Pessoa Física           *
*           2 - Pessoa Jurídica         *
*                                       *
*           0 - Sair                    *
*****************************************
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPF = new PessoaFisica();
            PessoaFisica metodosPf = new PessoaFisica();
            Endereco novoEndPf = new Endereco();

            novaPF.nome = "Tiago de Almeida";
            novaPF.dataNasc = new DateTime(2000, 01, 01);
            novaPF.cpf = "1234567890";
            novaPF.rendimento = 3500.5f;

            novoEndPf.logradouro = "Avenida Rio Branco";
            novoEndPf.numero = 31;
            novoEndPf.complemento = "Senai";
            novoEndPf.endComercial = false;

            novaPF.endereco = novoEndPf;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPF.nome}
Maior de Idade: {metodosPf.validarDataNasc(novaPF.dataNasc)}
Enredeço: {novaPF.endereco.logradouro}, {novaPF.endereco.numero}, {novaPF.endereco.complemento}
Endereço comercial: {novaPF.endereco.endComercial}
");

            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.Write("Aperte ENTER para continuar");
            Console.ReadLine();

            break;            

        case "2":
            PessoaJuridica novaPj = new PessoaJuridica();
            PessoaJuridica metodosPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "SENAI Informática";
            novaPj.razaoSocial = "Instituição de Educação";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.rendimento = 10000.5f;

            novoEndPj.logradouro = "Avenida das Américas";
            novoEndPj.numero = 101;
            novoEndPj.complemento = "SENAI Rio de Janeiro";
            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}, Válido: {metodosPj.validarCnpj(novaPj.cnpj)}
Endereço: {novaPj.endereco.logradouro}, Nº {novaPj.endereco.numero}
complemento: {novaPj.endereco.complemento}
");

            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.Write("Aperte ENTER para continuar");
            Console.ReadLine();

            break;

        case "0":
            Console.Clear();
            Console.WriteLine(@$"
 Obrigado por utilizar nosso sistema!

        ░░░░░░░▄█▄▄▄█▄ ░░░░░░
        ▄▀░░░░▄▌─▄─▄─▐▄░░░░▀▄
        █▄▄█░░▀▌─▀─▀─▐▀░░█▄▄█
        ░▐▌░░░░▀▀███▀▀░░░░▐▌
        ████░▄█████████▄░████
            
                 ");
            Thread.Sleep(1500);
            LoadingBar("Finalizando ", 500, 20);           

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção Incorreta!");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }
    Console.ResetColor();
} while (opcao != "0");




static void LoadingBar(string texto, int tempo, int quantidade)
{
    // Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Green;

    System.Console.Write(texto);

    for (var i = 0; i < quantidade; i++)
    {
        Console.Write("▓");
        Thread.Sleep(tempo);
    }

    Console.ResetColor();
}





// PessoaFisica novaPF = new PessoaFisica();
// PessoaFisica metodosPf = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPF.nome = "Tiago de Almeida";
// novaPF.dataNasc = new DateTime(2000, 01, 01);
// novaPF.cpf = "1234567890";
// novaPF.rendimento = 3500.5f;

// novoEndPf.logradouro = "Avenida Rio Branco";
// novoEndPf.numero = 31;
// novoEndPf.complemento = "Senai";
// novoEndPf.endComercial = true;

// novaPF.endereco = novoEndPf;

// Console.WriteLine(@$"
// Nome: {novaPF.nome}
// Maior de Idade: {metodosPf.validarDataNasc(novaPF.dataNasc)}
// Enredeço: {novaPF.endereco.logradouro}, {novaPF.endereco.numero}, {novaPF.endereco.complemento}
// Endereço comercial: {novaPF.endereco.endComercial}
// ");


// Console.WriteLine(novaPF.nome);
// Console.WriteLine("nome: " + novaPF.nome);
// Console.WriteLine($"Nome: {novaPF.nome} Nome: {novaPF.nome}");

// PessoaJuridica novaPj = new PessoaJuridica();
// PessoaJuridica metodosPj = new PessoaJuridica();
// Endereco novoEndPj = new Endereco();

// novaPj.nome = "SENAI Informática";
// novaPj.razaoSocial = "Instituição de Educação";
// novaPj.cnpj = "00.000.000/0001-00";
// novaPj.rendimento = 10000.5f;

// novoEndPj.logradouro = "Avenida das Américas";
// novoEndPj.numero = 101;
// novoEndPj.complemento = "SENAI Rio de Janeiro";
// novoEndPj.endComercial = true;

// novaPj.endereco = novoEndPj;

// Console.WriteLine(@$"
// Nome: {novaPj.nome}
// Razão Social: {novaPj.razaoSocial}
// CNPJ: {novaPj.cnpj}, Válido: {metodosPj.validarCnpj(novaPj.cnpj)}
// Endereço: {novaPj.endereco.logradouro}, Nº {novaPj.endereco.numero}
// complemento: {novaPj.endereco.complemento}
// ");