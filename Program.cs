
Console.WriteLine("-----Bem vindo ao nosso livro de receitas-----");
Console.WriteLine("Selecione a receita de acordo com o número dela");
 
int bolo = 1;
int PãoItaliano = 2;
int PãoRecheado = 3;
int Rocambole = 4;
string sair;

void ExibeMenu()
{
        Console.WriteLine();
        Console.WriteLine("\nObrigado pela prefência!");
    }
{
    Console.WriteLine("+==========================================+");
    Console.WriteLine("| LIVRO DE RECEITAS DO PADEIRO |");
    Console.WriteLine("| RECEITAS |");
    Console.WriteLine("| 1- Receita de bolo");
    Console.WriteLine("| 2- Receita de Pão Recheado |");
    Console.WriteLine("| 3- Receita de Pão Francês |");
    Console.WriteLine("| 4- Rocambole");
    Console.WriteLine("| 5-Fechar o livro|");

    Console.WriteLine("+===========================================+");
}

do
{
    ExibeMenu();
    Console.WriteLine("Deseja ver outra receita? S/N");
    Console.WriteLine();
    sair = Console.ReadLine().ToUpper();
}    
    while (sair != "S" && sair != "SIM");

if (PãoItaliano == 1)
{
    Console.WriteLine("Receita de pão italiano");
    Console.WriteLine(@"
    Farinha = 600
    Água = 380
    Fermento = 10
    Açúcar = 30
    ");
   
    Console.WriteLine(@"
    1- Em uma tigela de uma batedeira — com gancho para pães —, coloque a farinha, o sal e o açúcar
 
    2- Deixe bater por 10 minutos
 
    3- Adicione água aos poucos, sem parar de bater, até a massa formar uma bola
 
    4- Acrescente o fermento e bata novamente até a massa ficar lisa e uniforme
 
    5- Molde a massa no formato de pão, dividindo ela em tamanhos que você deseja
 
    6- Coloque a massa em um recipiente untado com óleo. Cubra a massa com papel filme e deixe na geladeira de 10 a 12 horas
 
    7- Retire da geladeira e faça um corte comprido no pãozinho
 
    8- Asse no forno a 180 graus até ficar dourado
    ");
}
 
 
else
{
    breagtk;
}
 
 
if (PãoRecheado == 2)
{
    Console.WriteLine("Receita de pão recheado");
    Console.WriteLine(@"
    Farinha = 1/2;
    Sal = 15;
    Fermento = 10;
    Margarina = 1;
    Açúcar = 20;
    ");
   
    Console.WriteLine(@"
    1- Dilua o fermento em um copo de água morna com o açúcar
 
    2- Em seguida misture os outros ingredientes
 
    3- Amassa e levante, empurrando a massa para frente, com a palma da mão e dobrando-a sobre si mesma
 
    4- Se for necessário, coloque mais água e mais farinha
 
    5- A massa não deverá grudar nas mãos
 
    6- Deve ficar com aspecto leve e esponjoso
 
    7- Deixe descansar por duas horas
 
    8- A seguir, amasse novamente e prepare o pão, dando-lhe o formato desejado e coloque no tabuleiro untado
 
    9- Se estiver pegajosa, espalhe mais farinha por cima
 
    10- Deixe que ela descanse mais uma hora
 
    11- Aqueça o forno e pincele o pão com água antes de colocá-lo no forno
 
    12- Assar por 40 minutos mais ou menos"
    );
 
}
 
 
else
{
    Console.WriteLine("Digite um número da lista");
}
 
if (bolo == 3)
{
    Console.WriteLine("Receita de bolo de chocolate");
    Console.WriteLine(@"
    Farinha = 2;
    Açúcar = 1/5;
    Fermento = 1;
    Óleo = 1;
    ChocolateEmPó = 2;
    ");
 
    Console.WriteLine(@"
     1- Em um recipiente, misture a farinha de trigo, açúcar, Chocolate em Pó, fermento e o bicarbonato peneirados
 
     2- Junte o óleo, os ovos e a água fervente, misturando bem
 
     3- Despeje a massa em uma forma de aluminio untada com óleo e polvilhada com farinha de trigo, e leve ao forno à 180°C preaquecido, por 40 minutos
    ");
}
else
{
    Console.WriteLine("Digite um número da lista");

}
 
 if (Rocambole == 4)
{
    Console.WriteLine("Receita de rocambole com recheio de chocolate");
    Console.WriteLine(@"
    Ovos = 6;
    ChocolateEmPó = 6;
    Ovos = 6;
    Água = 6;
    Fermento = 6;
    Farinha = 2/5;
    Açucar = 2/5;
    ");
}
else 
{
    Console.WriteLine("Digite um número da lista");

}
do
{
    ExibeMenu();
    Console.WriteLine("Deseja ver outra receita? S/N");
    Console.WriteLine();
}    
    while (sair != "S" && sair != "SIM");

