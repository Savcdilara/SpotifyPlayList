using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyPlayList.Entities
{
    internal class Playlist
    {
        public Guid Id { get; set; }
        private List<Song> Songs { get; set; }

        private Random random;
        public Playlist(Song firstSong)
        {
            Songs = new List<Song>();
            random = new();
            AddSong(firstSong);
        }

        public void AddSong(Song song)
        {
            if (song != null)
            {
                Songs.Add(song);
            }
        }

        public string GetSongs()
        {
            return string.Join("\n ", Songs.Select(song => $"{song.Title} - {song.Composer}"));
        }

        public void ShuffleSongs()
        {
            int count = Songs.Count;

            while (count > 0)
            {
                count--;

                Song song = Songs[count];

                int randomIndex = random.Next(count);

                Songs[count] = Songs[randomIndex];

                Songs[randomIndex] = song;

            }

        }
    }
}
