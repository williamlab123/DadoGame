Dice dice = new Dice();

foreach(int _i in Enumerable.Range(1, 5)){
  dice.Roll();
  Console.WriteLine("Rolando o dado...");
  Console.WriteLine($"O numero do dado agora é: {dice.Number}");
  dice.DrawDice();
  Console.WriteLine("----------------------------");
}