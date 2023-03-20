using Assignment_4;

var printMap = new PrintMap();

printMap.Draw(File.ReadAllLines("map.txt"));

printMap.LandAmount(File.ReadAllLines("map.txt"));

