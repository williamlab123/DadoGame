class Dice {
  static private Random randomSolution = new Random();
  static private Dictionary<int, String> exibitionDict = new Dictionary<int, string>{
    [1]=File.ReadAllText("txt/dice_01.txt"),
    [2]=File.ReadAllText("txt/dice_02.txt"),
    [3]=File.ReadAllText("txt/dice_03.txt"),
    [4]=File.ReadAllText("txt/dice_04.txt"),
    [5]=File.ReadAllText("txt/dice_05.txt"),
    [6]=File.ReadAllText("txt/dice_06.txt")
  };

  private int number;
  public int Number { get { return number; } private set { number = value; } }

  public Dice() {
    Roll(); // So number is never empty
  }

  public void Roll() {
    Number = randomSolution.Next(1, 7);
  }

  public void DrawDice(){
    Console.WriteLine(exibitionDict[Number]);
  }
}