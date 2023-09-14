
Main();
void Main()
{
    // Dado1();
    // Dado2();
    // Dado3();
    // Dado4();
    // Dado5();
    // Dado6();
    battle(PcBet(), 150);


}


void start()
{
    System.Console.WriteLine("");
}




int PcBet()
{
    Random rnd = new Random();
    int bet = rnd.Next(1, 5);

    int[] avaliableBets = { 50, 100, 150, 200, 250 };

    int pcbet = avaliableBets[bet];
    return pcbet;

}


void battle(int pcbet, int userBet)
{

    int[] randomNumbersPc = Randoms();
    int[] randomNumbersUser = Randoms();


    pcbet = PcBet();
    System.Console.WriteLine("aposta pc " + pcbet);


    int userScore = 0;
    int pcScore = 0;

    Console.WriteLine("numeros dos dados do pc");
    foreach (int number in randomNumbersPc)
    {
        Console.WriteLine(number);
        switch (number)
        {
            case 1:
                Dado1();
                pcScore++;
                break;
            case 2:
                Dado2();
                pcScore += 2;
                break;
            case 3:
                Dado3();
                pcScore += 3;
                break;
            case 4:
                Dado4();
                pcScore += 4;
                break;
            case 5:
                Dado5();
                pcScore += 5;
                break;
            case 6:
                Dado6();
                pcScore += 6;
                break;
            default:
                System.Console.WriteLine("bug");
                break;
        }

    }
    Console.WriteLine("numeros dos dados do usuário");
    foreach (int number in randomNumbersUser)
    {
        Console.WriteLine(number);
        switch (number)
        {
            case 1:
                Dado1();
                userScore++;
                break;
            case 2:
                Dado2();
                userScore += 2;
                break;
            case 3:
                Dado3();
                userScore += 3;
                break;
            case 4:
                Dado4();
                userScore += 4;
                break;
            case 5:
                Dado5();
                userScore += 5;
                break;
            case 6:
                Dado6();
                userScore += 6;
                break;
            default:
                System.Console.WriteLine("bug");
                break;
        }

    }
    System.Console.WriteLine(userScore);
    System.Console.WriteLine(pcScore);

    if (userScore > pcScore) System.Console.WriteLine("vc venceu corno manco");



    else if (userScore < pcScore) System.Console.WriteLine("vc perdeu, cabaço");






    else System.Console.WriteLine("bug fodase");


    // int[] randomNumbersUser = pcRandoms();

    // Console.WriteLine("numeros dos dados do usuário");
    // foreach (int numberUser in randomNumbersUser)
    // {
    //     Console.WriteLine(numberUser);
    // }
}





int[] Randoms()
{
    Random rnd = new Random();
    int[] rand = new int[3];

    for (int i = 0; i < 3; i++)
    {
        rand[i] = rnd.Next(1, 6);

    }

    return rand;
}



void regras()
{
    Console.WriteLine("O jogo começa no turno 0. O turno 0 é usado para começar as apostas.");
    Console.WriteLine("Você começa com 1000 (mil) moedas.");
    Console.WriteLine("A cada turno você tem que apostar pelo menos 50 moedas.");
    Console.WriteLine("Você joga 3 dados por vez.");
    Console.WriteLine("Se a combinação for: 1-2-3 {AZAR}, você paga o dobro.");
    Console.WriteLine("As trincas: 1-1-1, 2-2-2, etc, dobram o valor atual das suas moedas.");
    Console.WriteLine("Se a combinação for: 4-5-6 {SORTE}, você ganha o dobro.");
    Console.WriteLine("O jogo não tem limite de turno, ou seja, começa no turno 0 e só termina quando alguém perder.");
    Console.WriteLine("Você perde quando fica sem dinheiro para apostar.");
    Console.WriteLine("Se der empate, o dinheiro apostado volta.");
    Console.WriteLine("Depois que as apostas são feitas, você pode jogar o dado. Se quiser refazer as apostas, digite 2");
}


//muda a cor do console   
void changeConsoleColor(string cor)
{
    ConsoleColor corEnum = GetConsoleColorFromName(cor);

    if (corEnum != ConsoleColor.Black)
    {
        Console.ForegroundColor = corEnum;
    }
    else
    {
        Console.WriteLine("Essa cor não existe.");
    }
}

void resetConsoleColor()
{
    Console.ResetColor();
}

ConsoleColor GetConsoleColorFromName(string cor)
{
    Dictionary<string, ConsoleColor> mapeamentoCores = new Dictionary<string, ConsoleColor>(StringComparer.OrdinalIgnoreCase)
        {
            { "preto", ConsoleColor.Black },
            { "azul", ConsoleColor.Blue },
            { "verde", ConsoleColor.Green },
            { "ciano", ConsoleColor.Cyan },
            { "vermelho", ConsoleColor.Red },
            { "magenta", ConsoleColor.Magenta },
            { "amarelo", ConsoleColor.Yellow },
            { "branco", ConsoleColor.White }
        };

    if (mapeamentoCores.TryGetValue(cor, out ConsoleColor corEnum))
    {
        return corEnum;
    }

    return ConsoleColor.Black;
}





















void Dado1()
{
    Console.WriteLine(" ___________");
    Console.WriteLine("|           |");
    Console.WriteLine("|           |");
    Console.WriteLine("|     *     |");
    Console.WriteLine("|           |");
    Console.WriteLine("|___________|");
}

void Dado2()
{
    Console.WriteLine(" ___________");
    Console.WriteLine("|           |");
    Console.WriteLine("|  *        |");
    Console.WriteLine("|           |");
    Console.WriteLine("|        *  |");
    Console.WriteLine("|___________|");
}

void Dado3()
{
    Console.WriteLine(" ___________");
    Console.WriteLine("|           |");
    Console.WriteLine("|  *        |");
    Console.WriteLine("|     *     |");
    Console.WriteLine("|        *  |");
    Console.WriteLine("|___________|");
}

void Dado4()
{
    Console.WriteLine(" ___________");
    Console.WriteLine("|           |");
    Console.WriteLine("|  *     *  |");
    Console.WriteLine("|           |");
    Console.WriteLine("|  *     *  |");
    Console.WriteLine("|___________|");
}

void Dado5()
{
    Console.WriteLine("____________");
    Console.WriteLine("|           |");
    Console.WriteLine("|   *    *  |");
    Console.WriteLine("|      *    |");
    Console.WriteLine("|   *    *  |");
    Console.WriteLine("|___________|");
}

void Dado6()
{
    Console.WriteLine(" ___________");
    Console.WriteLine("|           |");
    Console.WriteLine("|  *  *  *  |");
    Console.WriteLine("|           |");
    Console.WriteLine("|  *  *  *  |");
    Console.WriteLine("|___________|");
}
