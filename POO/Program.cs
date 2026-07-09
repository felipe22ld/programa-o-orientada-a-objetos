using POO.ClassesEOutrosTipos.ClasseSelada;
using POO.ClassesEOutrosTipos.Encapsulamento;
// using POO.ClassesEOutrosTipos.Heranca;

// Produto.PropriedadeSomenteLeitura();
// Produto.Executar();
// Calculos.Executar();
// PessoaFisica.ExemploHeranca01();
// Funcionario.ExemploHeranca02();

Produto.ExemploEncapsulamento();

// var configuracao = new Configuracao();
// configuracao.Host = "localhost";

// => object initialize
var configuracao = new Configuracao
{
    Host = "localhost",
};

Console.WriteLine(configuracao.Host);