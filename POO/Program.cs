using POO.ClassesEOutrosTipos.Cadastro;
using POO.ClassesEOutrosTipos.Heranca;

// Produto.PropriedadeSomenteLeitura();
// Produto.Executar();
// Calculos.Executar();

var pessoaFisica = new PessoaFisica();
pessoaFisica.Id = 1;
pessoaFisica.Endereco = "Rua do Brasil, n 10";
pessoaFisica.Cidade = "Rio de Janeiro";
pessoaFisica.Cep = "010101010";
pessoaFisica.CPF = "01234567890";

pessoaFisica.ImprimirDados();
pessoaFisica.ImprimirCpf();

var funcionario = new Funcionario();
funcionario.Endereco = "Rua do Brasil, n 13";
funcionario.Cidade = "SP";
funcionario.Cep = "02342424";
funcionario.CPF = "00000000000";
funcionario.Matricula = "111111111";

funcionario.ImprimirDados();
funcionario.ImprimirCpf();
funcionario.ImprimirMatricula();