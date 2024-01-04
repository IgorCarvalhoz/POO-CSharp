using OrientacaoObjetos.Models;
//Abstração e classes
Pessoa p1 = new Pessoa();
p1.Nome = "Igor";
p1.Idade = 25;
p1.Apresentar();

//Encapsulamento
ContaCorrente c1 = new ContaCorrente(12345, 20000);
c1.Sacar(500);
c1.ExibirSaldo();
c1.Sacar(20000);

//Herança
Aluno a1 = new Aluno();
a1.Nome = "Lucas Hideki";
a1.Idade = 1 ;
a1.Nota = 10;

Professor prof1 = new Professor();
prof1.Nome = "Sthefany Yuri";
prof1.Idade = 24;
prof1.Salario = 20000;

// Polimorfismo
a1.Apresentar();
prof1.Apresentar();