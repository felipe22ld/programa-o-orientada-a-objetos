using POO.ClassesEOutrosTipos.Abstracao;
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
Configuracao.ExemploClasseSelada();

// var animal = new Animal();
var cachorro = new Cachorro();
cachorro.Nome =  "Fred";
cachorro.ImprimirDados();