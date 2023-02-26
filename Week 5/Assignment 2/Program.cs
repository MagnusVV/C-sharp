using Assignment_2;

//a:

//var cat = new Cat("Luna");

//Console.WriteLine($"{cat.Name} says: {cat.Speak()}");

//b:

//var luna = new Cat("Luna", false);
//var artemis = new Cat("Artemis", true);

//Console.WriteLine($"{luna.Name} says: {luna.Speak()}");
//Console.WriteLine($"{artemis.Name} says: {artemis.Speak()}");

//c:

var luna = new Cat("Luna", false);
var artemis = new Cat("Artemis", true);

Console.WriteLine($"{luna.Name} says: {luna.Speak()}");

artemis.Eat(luna);  // Artemis is a zombie cat, turning Luna into a zombie cat too!

Console.WriteLine($"{luna.Name} says: {luna.Speak()}");