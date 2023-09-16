
Main();
void Main()
{
    // Dado1();
    // Dado2();
    // Dado3();
    // Dado4();
    // Dado5();
    // Dado6();
    // battle(PcBet(), 150);
    Console.Clear();
    System.Console.WriteLine("DiceGame");
    System.Console.WriteLine("Digite ? para ler as regras");
    System.Console.WriteLine("Se nao, qualquer tecla pra começar");

    string input = Console.ReadLine();

    int dinheiro = 1000;


    if (input == "?") regras();

    else start(dinheiro);



}


void start(int dinheiro)
{
    int dinheiroPc = 0;
    do
    {
         int aposta;


    System.Console.WriteLine("Quanto deseja apostar?");
    aposta = int.Parse(Console.ReadLine());
    dinheiro -= aposta;
    System.Console.WriteLine($"Voce apostou {aposta}");
    System.Console.WriteLine("Jogando os dados...");

    int resultado = battle(aposta, aposta);

    switch (resultado)
    {
        case 1:
            System.Console.WriteLine("Voce venceu!");
            dinheiro += PcBet();

            System.Console.WriteLine($"Agora voce tem {dinheiro} de dinheiro");
            start(dinheiro);
            break;
        case 2:
            System.Console.WriteLine("Voce perdeu!");
            System.Console.WriteLine($"Agora voce tem {dinheiro} de dinheiro");

            start(dinheiro);

            break;
        case 3:
            System.Console.WriteLine("Empate");
            System.Console.WriteLine("Seu dinheiro apostado voltou pro seu bolso!");

            dinheiro += aposta;
            break;
            start(dinheiro);
        default:
            System.Console.WriteLine("Erro");
            break;
    }

    } while(dinheiro > 0 || dinheiroPc > 0);

   

   




}






int PcBet()
{
    Random rnd = new Random();
    int bet = rnd.Next(1, 5);

    int[] avaliableBets = { 50, 100, 150, 200, 250 };

    int pcbet = avaliableBets[bet];
    return pcbet;

}


int battle(int pcbet, int userBet)
{

    int[] randomNumbersPc = Randoms();
    int[] randomNumbersUser = Randoms();
    Dice dice = new Dice();


    pcbet = PcBet();
    System.Console.WriteLine("aposta pc " + pcbet);


    int userScore = 0;
    int pcScore = 0;

    Console.WriteLine("numeros dos dados do pc");
    foreach (int _i in Enumerable.Range(1, 3))
    {
        dice.Roll();
        // Console.WriteLine($"O numero do dado agora é: {dice.Number}");
        pcScore += dice.Number;
        dice.DrawDice();
    }



    Console.WriteLine("numeros dos dados do usuário");
    foreach (int _i in Enumerable.Range(1, 3))
    {
        dice.Roll();
        // Console.WriteLine($"O numero do dado agora é: {dice.Number}");
        userScore += dice.Number;
        dice.DrawDice();
    }

    System.Console.WriteLine(userScore);
    System.Console.WriteLine(pcScore);




    if (userScore > pcScore)
    {
        return 1;

    }
    else if (userScore < pcScore)
    {
        return 2;
    }
    else
    {
        return 0;
    }

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
