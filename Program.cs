using System.Diagnostics.CodeAnalysis;

const double ReceitaFarinha = 1;
const double ReceitaAgua = 0.07;
const double ReceitaFermento = 0.4;
const double ReceitaSal = 0.02;
const double ReceitaLeite = 0.01;
const double ReceitaOleo = 0.01;
const double ReceitaAçucar = 0.3;
const double ReceitaOvos = 0.07;
const double ReceitaMargarina = 0.9;
string opcaoDeSair = "";


double percentualPaoRelativoFarinha = ReceitaFarinha + ReceitaAgua + ReceitaFermento + ReceitaSal;
double pesoPaoRecheado = ReceitaFarinha + ReceitaAgua + ReceitaFermento + ReceitaSal;
double pesoPãoForma = ReceitaFarinha + ReceitaAgua + ReceitaOleo + ReceitaOvos + ReceitaMargarina + ReceitaAçucar + ReceitaFermento + ReceitaSal;
double pesoPãoQueijo = ReceitaFarinha + ReceitaAgua + ReceitaOleo + ReceitaOvos + ReceitaMargarina + ReceitaAçucar + ReceitaFermento + ReceitaSal;
double pesoBaguete = ReceitaFarinha + ReceitaAgua + ReceitaOleo + ReceitaOvos + ReceitaMargarina + ReceitaAçucar + ReceitaFermento + ReceitaSal;


double pesoPao, farinha, agua, fermento, sal, leite, ovos, açucar, oleo, margarina;

do
{

    ExibeMenu();
    double opcao = Convert.ToDouble(Console.ReadLine());
    {
    switch (opcao)
        {
        case 1:
        
            Console.WriteLine("Receita de pão italiano");
            Console.Write("Peso desejado de pão italiano (em gramas)...: ");
            pesoPao = Convert.ToDouble(Console.ReadLine());
            
            farinha = pesoPao / percentualPaoRelativoFarinha;

            agua = farinha * ReceitaAgua;
            fermento = farinha * ReceitaFermento;
            sal = farinha * ReceitaSal;
            farinha = farinha * ReceitaFarinha;
            
            Console.WriteLine("\nIngredientes:");
            
            Console.WriteLine($"Farinha....: {farinha:N0} g");
            Console.WriteLine($"Água.......: {agua:N0} g");
            Console.WriteLine($"Fermento...: {fermento:N0} g");
            Console.WriteLine($"Sal........: {sal:N0} g");
            break;
        }

        switch (opcao)
        {
        case 2:

            Console.WriteLine("Receita de pão recheado");
            Console.Write("Peso desejado de pão recheado (em gramas)...: ");
            pesoPaoRecheado = Convert.ToDouble(Console.ReadLine());
        
            farinha = pesoPaoRecheado / percentualPaoRelativoFarinha;
        
            agua = farinha * ReceitaAgua;
            fermento = farinha * ReceitaFermento;
            sal = farinha * ReceitaSal;
            leite = farinha * ReceitaLeite;
            oleo = farinha * ReceitaOleo;
            açucar = farinha * ReceitaAçucar;
            ovos = farinha * ReceitaOvos;


            Console.WriteLine("\nIngredientes:");

            Console.WriteLine($"Farinha.....: {farinha:N0} g");
            Console.WriteLine($"Leite.......: {leite:N0} g");
            Console.WriteLine($"Sal.........: {sal:N0} g");
            Console.WriteLine($"Ovos........: {ovos:N0} Qt");
            Console.WriteLine($"Açúcar......: {açucar:N0} g");
            Console.WriteLine($"Óleo........: {oleo:N0} g");
            Console.WriteLine($"Fermento....: {fermento:N0} g");
            Console.WriteLine($"Água........: {agua:N0} g");
            break;
        }

        switch (opcao)
        {
        case 3:

            Console.WriteLine("Receita de pão de forma");
            Console.Write("Peso desejado de pão de forma (em gramas)...: ");
            pesoPãoForma = Convert.ToDouble(Console.ReadLine());
        
            farinha = pesoPãoForma / percentualPaoRelativoFarinha;
        
            agua = farinha * ReceitaAgua;
            fermento = farinha * ReceitaFermento;
            sal = farinha * ReceitaSal;
            leite = farinha * ReceitaLeite;
            oleo = farinha * ReceitaOleo;
            açucar = farinha * ReceitaAçucar;
            ovos = farinha * ReceitaOvos;
            margarina = farinha * ReceitaMargarina;


            Console.WriteLine("\nIngredientes:");

            Console.WriteLine($"Farinha......: {farinha:N0} g");
            Console.WriteLine($"Leite........: {leite:N0} g");
            Console.WriteLine($"Margarina....: {margarina:N0} g");
            Console.WriteLine($"Ovos.........: {ovos:N0} g");
            Console.WriteLine($"Açúcar.......: {açucar:N0} g");
            Console.WriteLine($"Óleo.........: {oleo:N0} g");
            Console.WriteLine($"Fermento.....: {fermento:N0} g"); 
            Console.WriteLine($"Água.........: {agua:N0} g");  
            Console.WriteLine($"Sal..........: {sal:N0} g");

            break;
        }

        switch (opcao)
        {
        case 4:

            Console.WriteLine("Receita de pão de queijo");
            Console.Write("Peso desejado de pão de queijo (em gramas)...: ");
            pesoPãoQueijo = Convert.ToDouble(Console.ReadLine());
        
            farinha = pesoPãoQueijo / percentualPaoRelativoFarinha;
        
            agua = farinha * ReceitaAgua;
            fermento = farinha * ReceitaFermento;
            sal = farinha * ReceitaSal;
            leite = farinha * ReceitaLeite;
            oleo = farinha * ReceitaOleo;
            açucar = farinha * ReceitaAçucar;
            ovos = farinha * ReceitaOvos;
            margarina = farinha * ReceitaMargarina;

            Console.WriteLine("\nIngredientes:");

            Console.WriteLine($"Farinha.....: {farinha:N0} g");
            Console.WriteLine($"leite.......: {leite:N0} g");
            Console.WriteLine($"Sal.........: {sal:N0} g");
            Console.WriteLine($"Ovos........: {ovos:N0} g");
            Console.WriteLine($"Açúcar......: {açucar:N0} g");
            Console.WriteLine($"Óleo........: {oleo:N0} g");
            Console.WriteLine($"Água........: {agua:N0} g");  
            Console.WriteLine($"Fermento....: {fermento:N0} g"); 
            Console.WriteLine($"Margarina...: {margarina:N0} g");        


            break;
        }

        switch (opcao)
        {
        case 5:

            Console.WriteLine("Receita de baguete");
            Console.Write("Peso desejado de baguete (em gramas)...: ");
            pesoBaguete = Convert.ToDouble(Console.ReadLine());
        
            farinha = pesoBaguete / percentualPaoRelativoFarinha;
        
            agua = farinha * ReceitaAgua;
            fermento = farinha * ReceitaFermento;
            sal = farinha * ReceitaSal;
            leite = farinha * ReceitaLeite;
            oleo = farinha * ReceitaOleo;
            açucar = farinha * ReceitaAçucar;
            ovos = farinha * ReceitaOvos;
            margarina = farinha * ReceitaMargarina;


            Console.WriteLine("\nIngredientes:");

            Console.WriteLine($"Farinha.....: {farinha:N0} g");
            Console.WriteLine($"Água........: {agua:N0} g");
            Console.WriteLine($"Sal.........: {sal:N0} g");
            Console.WriteLine($"Ovos........: {ovos:N0} g");
            Console.WriteLine($"Óleo........: {oleo:N0} g");
            Console.WriteLine($"Açucar......: {açucar:N0} g");     
            Console.WriteLine($"Margarina...: {margarina:N0} g");        
            Console.WriteLine($"leite.......: {leite:N0} g");
            Console.WriteLine($"Fermento....: {fermento:N0} g"); 
            

            break;
        }
        
    }   

    void ExibeMenu()
    { 
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("--------Bem vindo ao nosso livro de receitas--------");
    Console.WriteLine("Selecione a receita de acordo com os números na tela");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("          +==============================+         ");
    Console.WriteLine("          | LIVRO DE RECEITAS DO PADEIRO |         ");
    Console.WriteLine("          +===========RECEITAS===========+         ");
    Console.WriteLine("          | 1- Receita de Pão Italiano   |         ");
    Console.WriteLine("          | 2- Receita de Pão Recheado   |         ");
    Console.WriteLine("          | 3- Receita de Pão de forma   |         "); 
    Console.WriteLine("          | 4- Receita de Pão de queijo  |         ");
    Console.WriteLine("          | 5- Receita de Baguete        |         ");
    Console.WriteLine("          +==============================+      \n");  
    Console.ResetColor();
    Console.Write("Digite um número da lista: ");
    }

    Console.WriteLine();
    while (opcaoDeSair == "S");
    Console.Write("Deseja sair? S/N: ");
    opcaoDeSair = Console.ReadLine()!.ToUpper();
  
}    
while (opcaoDeSair != "S" && opcaoDeSair != "SIM");
    Console.WriteLine("VOLTE SEMPRE !!!");