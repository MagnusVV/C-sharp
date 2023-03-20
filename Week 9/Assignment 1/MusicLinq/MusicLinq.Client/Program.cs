using System.Collections.Generic;
using MusicLinq.Data;

JsonDatabase Database = JsonDatabase.Load();

//
// some example code!
//
// select all artists with an ArtistId less than 20, and sort them by lenght of name backwards
//
//var result = Database.Artists
//        .Where(artist => artist.ArtistID < 20)
//        .OrderByDescending(artist => artist.Name.Length);

//foreach (var artist in result)
//{
//    Console.WriteLine(artist.Name);
//}

// 1.

// List all artists that start with the letter "D" in alphabetical order

//var result = Database.Artists
//    .Where(artist => artist.Name.StartsWith("D")).ToArray()
//    .OrderBy(artist => artist.Name);

//foreach (var artist in result)
//{
//    Console.WriteLine(artist);
//}


//2.

//List all artists that have more than five albums in the database.

//var result = Database.Artists
//    .Where(album => album.Albums.Count > 5).ToArray();

//foreach (var artist in result)
//{
//    Console.WriteLine(artist);
//}

//3.

//List all artists that have a name with four or less characters, in alphabetical order.

//var result = Database.Artists
//    .Where(artist => artist.Name.Length < 5).ToArray()
//    .OrderBy(artist => artist.Name);

//foreach (var artist in result)
//{
//    Console.WriteLine(artist);
//}

//Exercise 4
//List the title of all albums that have exactly two tracks.

//var albumsWithTwoTracks = Database.Artists
//    .SelectMany(artist => artist.Albums)
//    .Where(album => album.Tracks.Count == 2);

//foreach (var album in albumsWithTwoTracks)
//{
//    Console.WriteLine(album);
//}

//Exercise 5
//Count how many tracks there are in the database in total.

//var totalTracks = Database.Artists
//    .SelectMany(artist => artist.Albums)
//    .SelectMany(album => album.Tracks).Count();

//Console.WriteLine(totalTracks);

//Exercise 6
//Count the number of unique track names.

//var totalUniqeTracks = Database.Artists
//    .SelectMany(artist => artist.Albums)
//    .SelectMany(album => album.Tracks)
//    .Select(tracks => tracks.Name).Distinct().Count();


//Console.WriteLine(totalUniqeTracks);

//Exercise 7
//Calculate the average file size in bytes.

//var averageTrackWeight = Database.Artists
//    .SelectMany(artist => artist.Albums)
//    .SelectMany(album => album.Tracks)
//    .Select(tracks => tracks.Bytes).Average();


//Console.WriteLine($"{(int)averageTrackWeight} bytes");

//Exercise 8
//List all albums where the artist is "Various Artists".

//var albumsVariousArtists = Database.Artists
//    .Where(artist => artist.Name == "Various Artists")
//    .SelectMany(artist => artist.Albums);

//foreach (var album in albumsVariousArtists)
//{
//    Console.WriteLine(album);
//}

//Exercise 9
//Calculate how many hours of music there is in the database.

//var hours = Database.Artists
//    .SelectMany(artists => artists.Albums)
//    .SelectMany(albums => albums.Tracks)
//    .Select(tracks => tracks.Milliseconds).Sum() / 3600000;

//    Console.WriteLine(hours);

//Exercise 10
//List the 10 artists with most albums in the database.

var topTen = Database.Artists
    .OrderByDescending(artist => artist.Albums.Count())
    .Take(10)
    ;

foreach (var topArtist in topTen)
{
    Console.WriteLine(topArtist);
}
