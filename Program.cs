// See https://aka.ms/new-console-template for more information

// music playlist manager
using System;
using System.Collections.Generic;
class MusicPlaylistManager
{
    LinkedList<string> playlist = new LinkedList<string>();

    SortedList<int, string> songRatings = new SortedList<int, string>();

    SortedDictionary<string, string> songGenres = new SortedDictionary<string, string>();

    public void Addsong(string song, int rating, string artist)
    {
        playlist.AddLast(song);
        songRatings[rating] = song;
        songGenres[song] = artist;
        Console.WriteLine($"Song'{song}' added");

    }

    public void RemoveSong(string song)
    {
        playlist.Remove(song);

        int KeyToRemove = -1;
        foreach (var kvp in songRatings)
        {
            if (kvp.Value == song)
            {
                KeyToRemove = kvp.Key;
                break;
            }
        }
        if (KeyToRemove != -1)
        {
            songRatings.Remove(KeyToRemove);
        }
        //remore from artist
        string artistToRemove = null;
        foreach (var kvp in songGenres)
        {
            if (kvp.Value == song)
            {
                artistToRemove = kvp.Key;
                break;
            }
        }

        if (artistToRemove != null)
        {
            songGenres.Remove(artistToRemove);
        }
            Console.WriteLine($"Song '{song}' removed");
     }

    //Display Playlist
    public void DisplayPlaylist()
    {
        Console.WriteLine("Playlist:");
        foreach (var song in playlist)
        {
            Console.WriteLine(song);
        }
    }

    //Display songs by rating
    public void DisplaySongsByRating()
    {
        Console.WriteLine("Songs by Rating:");
        foreach (var kvp in songRatings)
        {
            Console.WriteLine($"Rating: {kvp.Key}, Song: {kvp.Value}");
        }
    }

    //Display songs by genre
    public void DisplaySongsByGenre()
    {
        Console.WriteLine("Songs by Genre:");
        foreach (var kvp in songGenres)
        {
            Console.WriteLine($"Artist: {kvp.Key}, Song: {kvp.Value}");
        }



    }
}


class Program
{
    static void Main(string[] args)
    {
        MusicPlaylistManager manager = new MusicPlaylistManager();
        manager.Addsong("Song1", 5, "Artist1");
        manager.Addsong("Song2", 4, "Artist2");
        manager.Addsong("Song3", 3, "Artist3");
        manager.DisplayPlaylist();
        manager.DisplaySongsByRating();
        manager.DisplaySongsByGenre();
        manager.RemoveSong("Song2");
        manager.DisplayPlaylist();
        manager.DisplaySongsByRating();
        manager.DisplaySongsByGenre();
    }
}