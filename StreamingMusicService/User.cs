namespace StreamingMusicService
{
	public class User
	{
		private const int MAX_SONGS_PER_USER = 50;
		private string name;
		private string email;
		private string? address;
		private List<Song> songs;

        public User(string name, string email)
        {
            this.name = name;
			this.email = email;
			songs = new List<Song>();
        }

		public User(string name, string email, string address)
		{
			this.name = name;
			this.email = email;
			this.address = address;
			songs = new List<Song>();
		}
		public string GetName()
		{
			return name;
		}

		public void AddSongToFavourite(Song song)
		{
			if (!songs.Contains(song))
			{
				if (songs.Count < MAX_SONGS_PER_USER)
					songs.Add(song);
			}
			
			
		}

		public void RemoveSongFromFavourite(Song song)
		{
			songs.Remove(song);
		}
		public Song[] GetFavouriteSongs()
		{
			return songs.ToArray();
		}

		public override string ToString()
		{
			if (address != null)
				return $"{name} - Email: {email}, Address: {address}";
			else 
				return $"{name} - Email: {email}";
		}
	}
}
