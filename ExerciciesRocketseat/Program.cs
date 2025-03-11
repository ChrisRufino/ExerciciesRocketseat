

class Program

{

    
    static void Main()
    {

        /* 1 Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!
*/

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");



        /* 2 Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.*/


        Console.Write("Digite seu Primeiro nome: ");
        string nome2 = Console.ReadLine();

        Console.Write("Digite seu Sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"{nome2}" + " " + $"{sobrenome}");


        /*1. Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
        - A soma entre esses dois números;
        - A subtração entre os dois números;
        - A multiplicação entre os dois números;
        - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
        - A média entre os dois números.*/

        double num1 = 10;
        double num2 = 5;

        Console.WriteLine("A soma dos dois números: " + (num1 + num2));

        Console.WriteLine("A subtração dos dois números: " + (num1 - num2));



        Console.WriteLine("A subtração dos dois números: " + (num1 * num2));


        if (num2 > 0)
        {
            Console.WriteLine("A divisão dos dois números: " + (num1 / num2));
        }
        else
        {
            Console.WriteLine("Não é possivel dividir por 0");
        }

        Console.WriteLine("A média dos dois números: " + (num1 + num2) / 2);

    }

}
