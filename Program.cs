Console.WriteLine("-----Bem vindo ao nosso livro de receitas-----");
Console.WriteLine("Selecione a receita de acordo com o número dela");
 
const double ReceitaFarinha = 1;
const double ReceitaAgua = 0.7;
const double ReceitaFermento = 0.4;
const double ReceitaSal = 0.02;
const double ReceitaLeite = 0.06;
const double ReceitaOleo = 0.19;
const double ReceitaAçucar = 0.3;
const double ReceitaOvos = 0.07;

double percentualPaoRelativoFarinha = ReceitaFarinha + ReceitaAgua + ReceitaFermento + ReceitaSal;
double pesoPaoRecheado = ReceitaFarinha + ReceitaAgua + ReceitaFermento + ReceitaSal;


double pesoPao, farinha, agua, fermento, sal, leite, ovos, açucar, oleo;
 
int PãoItaliano = 1;
//int bolo = 2;
//int PãoRecheado = 3;
//int Rocambole = 4;
//string sair;
 
 
Console.WriteLine("+==============================+");
Console.WriteLine("| LIVRO DE RECEITAS DO PADEIRO |");
Console.WriteLine("+===========RECEITAS===========+");
Console.WriteLine("| 1- Receita de Pão Italiano |");
Console.WriteLine("| 2- Receita de Pão Recheado |");
Console.WriteLine("| 3- Receita de bolo |");
Console.WriteLine("| 4- Receita de Rocambole |");
Console.WriteLine("| 5- Fechar o livro |");
Console.WriteLine("+==============================+\n");
Console.WriteLine(" Digite um número da lista ");
 
string opcao = Console.ReadLine().ToUpper();

switch (opcao)
{
    case "1":
    
// Console.ReadLine();
// Console.Clear();

Console.WriteLine("Receita de pão italiano");
Console.WriteLine("Peso desejado de pão italiano (em gramas)...: ");
pesoPao = Convert.ToDouble(Console.ReadLine());
 
farinha = pesoPao / percentualPaoRelativoFarinha;
 
agua = farinha * ReceitaAgua;
fermento = farinha * ReceitaFermento;
sal = farinha * ReceitaSal;
 
Console.WriteLine("\nIngredientes:");
 
Console.WriteLine($"Farinha....: {farinha:N0} g");
Console.WriteLine($"Água.......: {agua:N0} g");
Console.WriteLine($"Fermento...: {fermento:N0} g");
Console.WriteLine($"Sal........: {sal:N0} g");

break;
}

switch (opcao)
{
    case "2":

    Console.WriteLine("Receita de pão recheado");
    Console.WriteLine("Peso desejado de pão recheado (em gramas)...: ");
    pesoPao = Convert.ToDouble(Console.ReadLine());
 
    farinha = pesoPaoRecheado / percentualPaoRelativoFarinha;
 
    agua = farinha * ReceitaAgua;
    fermento = farinha * ReceitaFermento;
    sal = farinha * ReceitaSal;
    leite = farinha * ReceitaLeite;
    oleo = farinha * ReceitaOleo;
    açucar = farinha * ReceitaAçucar;
    ovos = farinha * ReceitaOvos;



Console.WriteLine("\nIngredientes:");

    Console.WriteLine($"Farinha {farinha:N0} g");
    Console.WriteLine($"leite {leite:N0} g");
    Console.WriteLine($"Sal {sal:N0} g");
    Console.WriteLine($"Ovos {ovos:N0} g");
    Console.WriteLine($"Açúcar {açucar:N0} g");
    Console.WriteLine($"Óleo {oleo:N0} g");

    break;
}
