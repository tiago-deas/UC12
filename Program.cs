using cadastro.Classes;

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
novoEndPf.endComercial = true;

novaPF.endereco = novoEndPf;

Console.WriteLine(@$"
Nome: {novaPF.nome}
Maior de Idade: {metodosPf.validarDataNasc(novaPF.dataNasc)}
Enredeço: {novaPF.endereco.logradouro}, {novaPF.endereco.numero}, {novaPF.endereco.complemento}
Endereço comercial: {novaPF.endereco.endComercial}
");


// Console.WriteLine(novaPF.nome);
// Console.WriteLine("nome: " + novaPF.nome);
// Console.WriteLine($"Nome: {novaPF.nome} Nome: {novaPF.nome}");
