using POO.ClassesEOutrosTipos.Abstracao;
using POO.ClassesEOutrosTipos.ClasseSelada;
using POO.ClassesEOutrosTipos.Construtores;
using POO.ClassesEOutrosTipos.Encapsulamento;
using POO.ClassesEOutrosTipos.Heranca;
using POO.ClassesEOutrosTipos.Record;
using POO.ClassesEOutrosTipos.SobrecargaMetodo;

// Produto.PropriedadeSomenteLeitura();
// Produto.Executar();
// Calculos.Executar();
// PessoaFisica.ExemploHeranca01();
// Funcionario.ExemploHeranca02();

// Produto.ExemploEncapsulamento();

// var configuracao = new Configuracao();
// configuracao.Host = "localhost";
// Configuracao.ExemploClasseSelada();
// Cachorro.ExemploAbstracao();

// Produto03.ExemplosConstrutores();

// Calculos02.ExemploSobrecarga();

// var curso1 = new Curso()
// {
//     Id = 1,
//     Descricao = "Curso",
// };
// var curso2 = new Curso()
// {
//     Id = 1,
//     Descricao = "Curso",
// };
// Console.WriteLine(curso1 == curso2);
// Console.WriteLine(curso1.Equals(curso2));
var curso1 = new Curso(1,"Curso");
 
// var curso2= new Curso(1,"Curso");
var curso2 = curso1 with
{
Descricao = "Curso Banco de Dados"
};
Console.WriteLine(curso1 == curso2);