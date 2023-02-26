using Assignment_3;

//a:

//var result = Die.Roll();

//Console.WriteLine($"The value is: {result}"); // The value is (some value between 1-6)

//b:

var megatron = new Robot("Megatron", 10);
var optimus = new Robot("Optimus Prime", 10);

//Console.WriteLine($"Name   : {megatron.Name}");
//Console.WriteLine($"Health : {megatron.Health}hp\n");

//Console.WriteLine($"Name   : {optimus.Name}");
//Console.WriteLine($"Health : {optimus.Health}hp\n");

//megatron.Attack(optimus);

//Console.WriteLine($"{megatron.Name}'s health: {megatron.Health}");
//Console.WriteLine($"{optimus.Name}'s health: {optimus.Health}");

var game = new RobotFightingGame(megatron, optimus);

while (!game.GameOver)
{
    game.NextRound();
}

if (game.Winner == null)
{
    Console.WriteLine("The game ends in a draw! What a disappointment!");
}
else
{
    Console.WriteLine($"{game.Winner} is the winner!");
}