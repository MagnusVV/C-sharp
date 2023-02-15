using Assignment_5;

var box1 = new Box()
{
    X = 3,
    Y = 2,
    Width = 7,
    Height = 4
};

var box2 = new Box()
{
    X = 17,
    Y = 4,
    Width = 13,
    Height = 8
};

box1.Draw(ConsoleColor.Blue);
box2.Draw(ConsoleColor.Red);