Console.WriteLine("-----Bem vindo ao nosso livro de receitas-----");
Console.WriteLine("Selecione a receita deacordo com o número dela");

int bolo = 1;
int PãoItaliano = 2;
int PãoRecheado = 3;
string sair;

do 
{
    ExibeMenu();
    Console.WriteLine("Deseja ver outra receita? S/N");
    Console.Write();
    sair = Console.ReadLine().ToUpper();
}    
    while (sair != "S" && sair != "SIM");
    {
        Console.WriteLine();
        Console.WriteLine("\nObrigado pela prefência!");
    }
void ExibeOpções();
{
    Console.WriteLine("+==========================================+");
    Console.WriteLine("| LIVRO DE RECEITAS DO PADEIRO |");
    Console.WriteLine("| RECEITAS |");
    Console.WriteLine("| 1- Receita de bolo");
    Console.WriteLine("| 2- Receita de Pão Recheado |");
    Console.WriteLine("| 3- Receita de Pão Francês |");
    Console.WriteLine("| 4- Rocambole");
    Console.WriteLine("+===========================================+");
}
double SoliciteUmNumero(string OrdemNumero)
{
    double numero = 0;
    Console.Write("Digite o ");
    Console.Write(OrdemNumero);

    Console.WriteLine(" número");
    numero = Convert.ToDouble(Console.ReadLine());

    return numero;
}

if (PãoItaliano == 1)
{
    Console.WriteLine("Se o valor digitado for 1");
    const double Farinha = 1;
    const double Água = 0.7;
    const double Fermento = 0.4;
    const double Sal = 0.02;
    
    double percentualPaoRelativoFarinha = Farinha + Água + Fermento + Sal;
    double pesoPao, farinha, agua, fermento, sal;   

}

else 
{
    Console.WriteLine("Digite um número da lista");
}

if (PãoRecheado == 2)
{
    const double Farinha = 1/2;
    const double Sal = 15;
    const double Fermento = 10;
    const double Margarina = 1;
    const double açucar = 20;
    
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
    return;
}

if (bolo == 3)
{
    const double Farinha = 2;
    const double açucar = 1/5;
    const double Fermento = 1;
    const double Oleo = 1;


}

