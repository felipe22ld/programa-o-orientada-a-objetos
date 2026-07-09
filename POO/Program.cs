using POO.ClassesEOutrosTipos.ClasseSelada;
using POO.ClassesEOutrosTipos.Encapsulamento;
// using POO.ClassesEOutrosTipos.Heranca;

// Produto.PropriedadeSomenteLeitura();
// Produto.Executar();
// Calculos.Executar();
// PessoaFisica.ExemploHeranca01();
// Funcionario.ExemploHeranca02();

var produto = new Produto();
produto.Descricao = "Mouse";
// produto.Preco = -500;
produto.SetPreco(150);
Console.WriteLine(produto.GetPreco());
produto.SetId(10);
Console.WriteLine(produto.Id);

// var configuracao = new Configuracao();
// configuracao.Host = "localhost";

// => object initialize
var configuracao = new Configuracao
{
    Host = "localhost",
};

Console.WriteLine(configuracao.Host);