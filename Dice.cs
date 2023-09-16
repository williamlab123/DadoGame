
  class Dice
  {
    static private Random randomSolution = new Random();
    static private Dictionary<int, String> exibitionDict = new Dictionary<int, string>
    {
      [1] = File.ReadAllText("dices/dice1.txt"),
      [2] = File.ReadAllText("dices/dice2.txt"),
      [3] = File.ReadAllText("dices/dice3.txt"),
      [4] = File.ReadAllText("dices/dice4.txt"),
      [5] = File.ReadAllText("dices/dice5.txt"),
      [6] = File.ReadAllText("dices/dice6.txt")
    };

    private int number;
    public int Number { get { return number; } private set { number = value; } }

    public Dice()
    {
      Roll(); // So number is never empty
    }

    public void Roll()
    {
      Number = randomSolution.Next(1, 7);
    }

    public void DrawDice()
    {
      Console.WriteLine(exibitionDict[Number]);
    }
  }


