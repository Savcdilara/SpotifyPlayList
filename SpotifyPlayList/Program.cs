using SpotifyPlayList.Entities;

Console.WriteLine("Spotify - Dilara's musics...");

var song1 = new Song("Dernière Danse", " Indila", "Adila Sedraïa");
var song2 = new Song("Tourner Dans Le Vide", " Indila", "Adila Sedraïa");
var song3 = new Song("Mockingbird", "Eminem", "Luis Resto");

var playlist1 = new Playlist(song1);
playlist1.AddSong(song2);
playlist1.AddSong(song3);

Console.WriteLine("\n\nBefore Shuffle:");
Console.WriteLine(playlist1.GetSongs());

playlist1.ShuffleSongs();

Console.WriteLine("\n\nAfter Shuffle:");
Console.WriteLine(playlist1.GetSongs());



