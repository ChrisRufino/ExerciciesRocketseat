

using System.Globalization;
using System.Security.Cryptography;

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


        /*3. Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
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


        /*4. Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.*/

        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        bool temEspaco = palavra.Contains(" ");

        string palavraSemEspaco = palavra.Replace(" ", "");

        Console.WriteLine($"A palavra {palavraSemEspaco} tem {palavraSemEspaco.Length} caracteres");


        /*5. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
        - A placa deve ter 7 caracteres alfanuméricos;
        - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
        - Os quatro últimos caracteres são números;
    
        Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.*/

        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();



        if(placa.Length == 7)
        {
            string letras = placa.Substring(0, 3); // contar os 3 primeiros caracter
            string numeros = placa.Substring(3, 4); // contar os 4 ultimos caracter

            bool saoLetras = letras.All(char.IsLetter); // Verificar se um caractere é uma letra (tanto maiúscula quanto minúscula).
            bool saoNumeros = numeros.All(char.IsDigit);// Verificar se um caractere é um dígito numérico (0 a 9).

            if (saoLetras && saoNumeros)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }

        else
        {
            Console.WriteLine("Falso");
        }


        /* 6. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
            - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
            - Apenas a data no formato "01/03/2024".
            - Apenas a hora no formato de 24 horas.
            - A data com o mês por extenso.*/


        Console.Write("Digite a data atual em diversos formatos: ");
        string inputDate = Console.ReadLine();

        // Tenta converter a string para um DateTime
        DateTime date;
        bool isValidDate = DateTime.TryParse(inputDate, out date);

        if (isValidDate)
        {
            // Formatar a hora no formato de 24 horas
            string horaEmTexto = date.ToString("HH:mm");

            // Formatar a data com o mês por extenso
            string diaEmTexto = date.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));

            //Formatar a data no formato completo
            string dataCompleta = date.ToString("dddd, dd/MMMM/yyyy HH:mm:ss");

            //Apenas a data no formato "01/03/2024".
            string mesPorExtenso = date.ToString("dd/MM/yyyy");



            Console.WriteLine($"Data completa: {dataCompleta}");
            Console.WriteLine($"Hora: {horaEmTexto}");
            Console.WriteLine($"Data: {diaEmTexto}");
            Console.WriteLine($"Data: {mesPorExtenso}");

        }

        else
        {
            Console.WriteLine("Data inválida!");
        }


        // CONFESSO QUE TIVE AJUDA EXTERNA PARA REALIZAR ALGUNS EXERCICIOS, VALEU. POREM ENTENDI O CONCEITO DE CADA UM DELES..


    }

}
