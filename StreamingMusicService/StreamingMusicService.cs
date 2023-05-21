using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicService
{
	public class StreamingMusicService
	{
		private string name;
        private List<Song> songs;
        private List<User> users;
        private User? user;
        private Song? song;

        public StreamingMusicService(string name)
        {
            this.name = name;
            songs = new List<Song>();
            users = new List<User>();
        }
        public void AddUserNoAddress(string name, string email)
        {
            user = new User(name, email);
			users.Add(user);
		}

		public void AddUser(string name, string email, string address)
        {
            user = new User(name, email, address);
            
			users.Add(user);
		}
        public User? GetUser()
        {
            return user;
        }
        public User[] GetUsers()
        {
            return users.ToArray();
        }
        public void AddSong(string artist, string title, int durationInSeconds, Genre genre)
        {
            song = new Song(artist, title, durationInSeconds, genre);
            if (!songs.Contains(song))
            {
				songs.Add(song);
			}
		}

        public Song? GetSong()
        {
            return song;
        }

        public Song[] GetSongs()
        {
            return songs.ToArray();
        }
        public Song[]? GetSongs(string artist)
        {
            List<Song> songs2 = new List<Song>();
            foreach (Song song1 in songs)
            {
				if (artist == song1.GetArtist())
				{
					songs2.Add(song1);
				}
			}
            return songs2.ToArray();
		}
        public override string ToString()
        {
            return $"Streaming Music Service: {name} ({songs.Count} song/s & {users.Count} user/s)";
        }
    }
}
