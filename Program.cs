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

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}, Válido: {metodosPj.validarCnpj(novaPj.cnpj)}
Endereço: {novaPj.endereco.logradouro}, Nº {novaPj.endereco.numero}
complemento: {novaPj.endereco.complemento}
");