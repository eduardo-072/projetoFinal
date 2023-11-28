Console.WriteLine("-----Bem vindo ao nosso livro de receitas-----");
Console.WriteLine("Selecione a receita de acordo com o número dela");
 
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

double pesoPao, farinha, agua, fermento, sal, leite, ovos, açucar, oleo, margarina;
 
Console.WriteLine("+==============================+");
Console.WriteLine("| LIVRO DE RECEITAS DO PADEIRO |");
Console.WriteLine("+===========RECEITAS===========+");
Console.WriteLine("| 1- Receita de Pão Italiano |");
Console.WriteLine("| 2- Receita de Pão Recheado |");
Console.WriteLine("| 3- Receita de Pão de forma |"); 
Console.WriteLine("| 4- Receita de Pão de queijo |");
Console.WriteLine("| 5- Receita de Baguete |");
Console.WriteLine("+==============================+\n");
Console.WriteLine(" Digite um número da lista ");
 
string opcao = Console.ReadLine().ToUpper();

do
{
    switch (opcao)
    {
        case "1":
        
        Console.WriteLine("Receita de pão italiano");
        Console.WriteLine("Peso desejado de pão italiano (em gramas)...: ");
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

        Console.WriteLine("deseja sair?");
        opcaoDeSair = Console.ReadLine().ToUpper();
        
    break;
    } while (opcaoDeSair == "S");

    Console.WriteLine("VOLTE SEMPRE !!!"); 

    switch (opcao)
    {
            case "2":

            Console.WriteLine("Receita de pão recheado");
            Console.WriteLine("Peso desejado de pão recheado (em gramas)...: ");
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

            Console.WriteLine($"Farinha {farinha:N0} g");
            Console.WriteLine($"leite {leite:N0} g");
            Console.WriteLine($"Sal {sal:N0} g");
            Console.WriteLine($"Ovos {ovos:N0} Qt");
            Console.WriteLine($"Açúcar {açucar:N0} g");
            Console.WriteLine($"Óleo {oleo:N0} g");
            Console.WriteLine($"Fermento {fermento:N0} g");
            Console.WriteLine($"agua {agua:N0} g");
        
        opcaoDeSair = Console.ReadLine().ToUpper();
        break;
    } 

    switch (opcao)
    {
        case "3":

            Console.WriteLine("Receita de pão de forma");
            Console.WriteLine("Peso desejado de pão de forma (em gramas)...: ");
            pesoPaoRecheado = Convert.ToDouble(Console.ReadLine());
        
            farinha = pesoPaoRecheado / percentualPaoRelativoFarinha;
        
            agua = farinha * ReceitaAgua;
            fermento = farinha * ReceitaFermento;
            sal = farinha * ReceitaSal;
            leite = farinha * ReceitaLeite;
            oleo = farinha * ReceitaOleo;
            açucar = farinha * ReceitaAçucar;
            ovos = farinha * ReceitaOvos;
            margarina = farinha * ReceitaMargarina;


            Console.WriteLine("\nIngredientes:");

            Console.WriteLine($"Farinha {farinha:N0} g");
            Console.WriteLine($"leite {leite:N0} g");
            Console.WriteLine($"Margarina {margarina:N0} g");
            Console.WriteLine($"Ovos {ovos:N0} g");
            Console.WriteLine($"Açúcar {açucar:N0} g");
            Console.WriteLine($"Óleo {oleo:N0} g");
        break;
    }

    switch (opcao)
    {
        case "4":

            Console.WriteLine("Receita de pão de queijo");
            Console.WriteLine("Peso desejado de pão de queijo (em gramas)...: ");
            pesoPaoRecheado = Convert.ToDouble(Console.ReadLine());
        
            farinha = pesoPaoRecheado / percentualPaoRelativoFarinha;
        
            agua = farinha * ReceitaAgua;
            fermento = farinha * ReceitaFermento;
            sal = farinha * ReceitaSal;
            leite = farinha * ReceitaLeite;
            oleo = farinha * ReceitaOleo;
            açucar = farinha * ReceitaAçucar;
            ovos = farinha * ReceitaOvos;
            margarina = farinha * ReceitaMargarina;

            Console.WriteLine("\nIngredientes:");

            Console.WriteLine($"Farinha {farinha:N0} g");
            Console.WriteLine($"leite {leite:N0} g");
            Console.WriteLine($"Sal {sal:N0} g");
            Console.WriteLine($"Ovos {ovos:N0} g");
            Console.WriteLine($"Açúcar {açucar:N0} g");
            Console.WriteLine($"Óleo {oleo:N0} g");
            break;
        }

        switch (opcao)
        {
            case "5":

            Console.WriteLine("Receita de baguete");
            Console.WriteLine("Peso desejado de baguete (em gramas)...: ");
            pesoPaoRecheado = Convert.ToDouble(Console.ReadLine());
        
            farinha = pesoPaoRecheado / percentualPaoRelativoFarinha;
        
            agua = farinha * ReceitaAgua;
            fermento = farinha * ReceitaFermento;
            sal = farinha * ReceitaSal;
            leite = farinha * ReceitaLeite;
            oleo = farinha * ReceitaOleo;
            açucar = farinha * ReceitaAçucar;
            ovos = farinha * ReceitaOvos;
            margarina = farinha * ReceitaMargarina;


            Console.WriteLine("\nIngredientes:");

            Console.WriteLine($"Farinha {farinha:N0} g");
            Console.WriteLine($"Água {agua:N0} g");
            Console.WriteLine($"Sal {sal:N0} g");
            Console.WriteLine($"Ovos {ovos:N0} g");
            Console.WriteLine($"Óleo {oleo:N0} g");

        break;
    }
    } while (opcao != "S");
 
    Console.WriteLine("VOLTE SEMPRE !!!");



// int resultado = 0;

// Console.Write("informe um número.....:");
// int numero = int.Parse(Console.ReadLine());

// while (numero != 0)
// {
//     resultado = resultado + numero;

//     Console.WriteLine("Resultado parcial.....:" + resultado);
//     Console.Write(@"
// ");

//     Console.Write("Informe um número.....:");
//     numero = int.Parse(Console.ReadLine());
// }

// Console.WriteLine(" Resultado final.....:" + resultado);
