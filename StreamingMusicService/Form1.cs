using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace StreamingMusicService
{
	public partial class Form1 : Form
	{
		private StreamingMusicService musicService = new StreamingMusicService("Spotifio");
		User? user;
		Song? song;
		public Form1()
		{
			InitializeComponent();
			cbbGenre.DataSource = Enum.GetValues(typeof(Genre));
			lblStreamingMusicService.Text = musicService.ToString();
			lblShowUser.Text = "No user selected";
			lblRemoveSong.Text = "No user selected";
		}

		private void btnCreateUser_Click(object sender, EventArgs e)
		{
			if (txtAddress.Text != string.Empty)
			{
				musicService.AddUser(txtName.Text, txtEmail.Text, txtAddress.Text);

				lbUsers.Items.Clear();

				lbUsers.Items.AddRange(musicService.GetUsers());
				cbbUsers.Items.Add(musicService.GetUser());
			}
			else if (txtName.Text != string.Empty && txtEmail.Text != string.Empty)
			{
				musicService.AddUserNoAddress(txtName.Text, txtEmail.Text);

				lbUsers.Items.Clear();

				lbUsers.Items.AddRange(musicService.GetUsers());
				cbbUsers.Items.Add(musicService.GetUser());
			}
			else
				MessageBox.Show("Fill in all the required fields!");

			lblStreamingMusicService.Text = musicService.ToString();
		}

		private void btnCreateSong_Click(object sender, EventArgs e)
		{
			if (txtTitle.Text != string.Empty && txtArtist.Text != string.Empty && txtDuration.Text != string.Empty)
			{

				musicService.AddSong(txtArtist.Text, txtTitle.Text, int.Parse(txtDuration.Text), (Genre)cbbGenre.SelectedValue);

				lbSongs.Items.Clear();

				lbSongs.Items.AddRange(musicService.GetSongs());
				cbbSongs.Items.Add(musicService.GetSong());
				cbbSearchSongs.Items.Add(musicService.GetSong().GetArtist());
			}
			else
				MessageBox.Show("Fill in all the required fields!");

			lblStreamingMusicService.Text = musicService.ToString();

		}

		private void btnAddSongToFavourite_Click(object sender, EventArgs e)
		{
			if (cbbUsers.SelectedItem != null && cbbSongs.SelectedItem != null)
			
			{
				user = (User)cbbUsers.SelectedItem;
				song = (Song)cbbSongs.SelectedItem;
				user.AddSongToFavourite(song);

				lbFavouriteSongs.Items.Clear();
				cbbRemoveSong.Items.Clear();

				lblShowUser.Text = $"{user.GetName()} here are you favourite songs";
				lblRemoveSong.Text = $"{user.GetName()} delete a song";

				lbFavouriteSongs.Items.AddRange(musicService.GetUser().GetFavouriteSongs());
				cbbRemoveSong.Items.AddRange(musicService.GetUser().GetFavouriteSongs());
			}
			else
			{
				MessageBox.Show("Fill in all the required fields!");
			}
			


		}

		private void btnRemoveSong_Click(object sender, EventArgs e)
		{
			if (cbbRemoveSong.SelectedItem != null)
			{
				user.RemoveSongFromFavourite((Song)cbbRemoveSong.SelectedItem);

				lbFavouriteSongs.Items.Clear();
				cbbRemoveSong.Items.Clear();
				cbbRemoveSong.Text = "";

				lbFavouriteSongs.Items.AddRange(musicService.GetUser().GetFavouriteSongs());
				cbbRemoveSong.Items.AddRange(musicService.GetUser().GetFavouriteSongs());
			}
			else
			{
				MessageBox.Show("Select a song to delete");
			}
			
		}

		private void btnSearchByArtist_Click(object sender, EventArgs e)
		{
		}

		private void btnSearchByArtist_Click_1(object sender, EventArgs e)
		{
			if (cbbSearchSongs.SelectedItem != null)
			{
				string? result = cbbSearchSongs.SelectedItem.ToString();
				lbSongs.Items.Clear();

				lbSongs.Items.AddRange(musicService.GetSongs(result));
			}
			else
				MessageBox.Show("Select a song to search for");
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}