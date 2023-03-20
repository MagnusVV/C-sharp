using Assignment_1;

//var ship = new Spaceship("Planet Express", 10);

//ship.AddCargo(new Cargo("Bottles of Slurm", 3));
//ship.AddCargo(new Cargo("Space tomatos", 2));

//Console.WriteLine($"---- {ship.Name} ----");
//ship.ListCargo();

//Console.WriteLine();

//Cargo cargo;

//// while RemoveCargo doesn't return null
//while ((cargo = ship.RemoveCargo()) != null)
//{
//    Console.WriteLine($"Removed: {cargo.Description}");
//}

//Console.WriteLine();

//Console.WriteLine($"---- {ship.Name} ----");
//ship.ListCargo();

//Console.WriteLine();

//var spaceship = new Spaceship("Nostromo", 10);

//Console.WriteLine($"---- {spaceship.Name} ----");

//while (spaceship.AddCargo(new Cargo("Bottles of Slurm", 3)))
//{
//    Console.WriteLine("Cargo added successfully");
//}

//Console.WriteLine();

//Console.WriteLine($"---- {spaceship.Name} ----");
//spaceship.ListCargo();

var express = new Spaceship("Planet Express", 10);
var nostromo = new Spaceship("Nostromo", 50);

// add some strange alien eggs to Nostromo
nostromo.AddCargo(new Cargo("Alien eggs #1", 4));
nostromo.AddCargo(new Cargo("Alien eggs #2", 4));
nostromo.AddCargo(new Cargo("Alien eggs #3", 4));

// will move as much as possible from Nostromo to the Planet Express
nostromo.MoveCargoTo(spaceship: express);

Console.WriteLine();
Console.WriteLine($"---- {nostromo.Name} ----");
nostromo.ListCargo();

Console.WriteLine();
Console.WriteLine($"---- {express.Name} ----");
express.ListCargo();