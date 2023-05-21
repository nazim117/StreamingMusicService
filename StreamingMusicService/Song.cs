using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicService
{
	public class Song
	{
		private static int id = 1;
		private int songId;
		private string artist;
		private string title;
		private int durationInSeconds;
		private Genre genre;

        public Song( string artist, string title, int durationInSeconds, Genre genre)
        {
            songId = id++;
			this.artist = artist;
			this.title = title;
			this.durationInSeconds = durationInSeconds;
			this.genre = genre;
        }
		public int GetId()
		{
			return songId;
		}
		public string GetArtist()
		{
			return artist;
		}
		public string GetTitle()
		{
			return title;
		}

		public override string ToString()
		{
			return $"ID {songId}: {artist} - {title} ({durationInSeconds} seconds)";
		}


	}
}
