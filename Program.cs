using OrientacaoObjetos.Models;
using POOCSharp.Models;

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

// Classe abstrata
Poupanca Cpoup1 = new Poupanca();
Cpoup1.Creditar(7000);
Cpoup1.ExibirSaldo();
Cpoup1.Remover(200);
Cpoup1.ExibirSaldo();


//Treinando Relational pattern usando switchm
void comparar(int valor){
    if (valor >10){
        Console.WriteLine(1);
    }
    if (valor < 10){
       Console.WriteLine(-1);
    }
    else{
       Console.WriteLine(0);
    }
}
comparar(3);

void comparar2(int valor){
    Console.WriteLine(valor switch{
        <10 => -1,
        >10 =>1,
        _ => 0
    });
}
comparar2(15);