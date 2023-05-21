namespace StreamingMusicService
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			lblAddress = new Label();
			lblEmail = new Label();
			lblName = new Label();
			btnCreateUser = new Button();
			txtAddress = new TextBox();
			txtEmail = new TextBox();
			txtName = new TextBox();
			tabPage2 = new TabPage();
			lblGenre = new Label();
			lblDuration = new Label();
			lblTitle = new Label();
			lblArtist = new Label();
			btnCreateSong = new Button();
			cbbGenre = new ComboBox();
			txtDuration = new TextBox();
			txtTitle = new TextBox();
			txtArtist = new TextBox();
			tabPage3 = new TabPage();
			lbUsers = new ListBox();
			tabPage4 = new TabPage();
			btnSearchByArtist = new Button();
			cbbSearchSongs = new ComboBox();
			lblSearchByArtist = new Label();
			lbSongs = new ListBox();
			tabPage5 = new TabPage();
			lblRemoveSong = new Label();
			lblShowUser = new Label();
			lblStreamingMusicService = new Label();
			btnRemoveSong = new Button();
			cbbRemoveSong = new ComboBox();
			lblChooseSong = new Label();
			lblChooseUser = new Label();
			lbFavouriteSongs = new ListBox();
			btnAddSongToFavourite = new Button();
			cbbSongs = new ComboBox();
			cbbUsers = new ComboBox();
			dataGridView1 = new DataGridView();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			tabPage3.SuspendLayout();
			tabPage4.SuspendLayout();
			tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Controls.Add(tabPage4);
			tabControl1.Controls.Add(tabPage5);
			tabControl1.Location = new Point(22, 12);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(740, 393);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.BackColor = Color.CornflowerBlue;
			tabPage1.Controls.Add(lblAddress);
			tabPage1.Controls.Add(lblEmail);
			tabPage1.Controls.Add(lblName);
			tabPage1.Controls.Add(btnCreateUser);
			tabPage1.Controls.Add(txtAddress);
			tabPage1.Controls.Add(txtEmail);
			tabPage1.Controls.Add(txtName);
			tabPage1.Location = new Point(4, 29);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(732, 360);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Add User";
			// 
			// lblAddress
			// 
			lblAddress.AutoSize = true;
			lblAddress.Location = new Point(138, 189);
			lblAddress.Name = "lblAddress";
			lblAddress.Size = new Size(132, 20);
			lblAddress.TabIndex = 6;
			lblAddress.Text = "Address (optional)";
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Location = new Point(138, 135);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(46, 20);
			lblEmail.TabIndex = 5;
			lblEmail.Text = "Email";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(138, 75);
			lblName.Name = "lblName";
			lblName.Size = new Size(49, 20);
			lblName.TabIndex = 4;
			lblName.Text = "Name";
			// 
			// btnCreateUser
			// 
			btnCreateUser.Location = new Point(310, 237);
			btnCreateUser.Name = "btnCreateUser";
			btnCreateUser.Size = new Size(94, 29);
			btnCreateUser.TabIndex = 3;
			btnCreateUser.Text = "Create User";
			btnCreateUser.UseVisualStyleBackColor = true;
			btnCreateUser.Click += btnCreateUser_Click;
			// 
			// txtAddress
			// 
			txtAddress.Location = new Point(295, 182);
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(125, 27);
			txtAddress.TabIndex = 2;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(295, 132);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(125, 27);
			txtEmail.TabIndex = 1;
			// 
			// txtName
			// 
			txtName.Location = new Point(295, 68);
			txtName.Name = "txtName";
			txtName.Size = new Size(125, 27);
			txtName.TabIndex = 0;
			// 
			// tabPage2
			// 
			tabPage2.BackColor = Color.CornflowerBlue;
			tabPage2.Controls.Add(lblGenre);
			tabPage2.Controls.Add(lblDuration);
			tabPage2.Controls.Add(lblTitle);
			tabPage2.Controls.Add(lblArtist);
			tabPage2.Controls.Add(btnCreateSong);
			tabPage2.Controls.Add(cbbGenre);
			tabPage2.Controls.Add(txtDuration);
			tabPage2.Controls.Add(txtTitle);
			tabPage2.Controls.Add(txtArtist);
			tabPage2.Location = new Point(4, 29);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(732, 360);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Add Song";
			// 
			// lblGenre
			// 
			lblGenre.AutoSize = true;
			lblGenre.Location = new Point(158, 216);
			lblGenre.Name = "lblGenre";
			lblGenre.Size = new Size(48, 20);
			lblGenre.TabIndex = 8;
			lblGenre.Text = "Genre";
			// 
			// lblDuration
			// 
			lblDuration.AutoSize = true;
			lblDuration.Location = new Point(158, 164);
			lblDuration.Name = "lblDuration";
			lblDuration.Size = new Size(67, 20);
			lblDuration.TabIndex = 7;
			lblDuration.Text = "Duration";
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Location = new Point(158, 117);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(38, 20);
			lblTitle.TabIndex = 6;
			lblTitle.Text = "Title";
			// 
			// lblArtist
			// 
			lblArtist.AutoSize = true;
			lblArtist.Location = new Point(158, 70);
			lblArtist.Name = "lblArtist";
			lblArtist.Size = new Size(44, 20);
			lblArtist.TabIndex = 5;
			lblArtist.Text = "Artist";
			// 
			// btnCreateSong
			// 
			btnCreateSong.Location = new Point(279, 265);
			btnCreateSong.Name = "btnCreateSong";
			btnCreateSong.Size = new Size(122, 29);
			btnCreateSong.TabIndex = 4;
			btnCreateSong.Text = "Create Song";
			btnCreateSong.UseVisualStyleBackColor = true;
			btnCreateSong.Click += btnCreateSong_Click;
			// 
			// cbbGenre
			// 
			cbbGenre.FormattingEnabled = true;
			cbbGenre.Location = new Point(256, 208);
			cbbGenre.Name = "cbbGenre";
			cbbGenre.Size = new Size(169, 28);
			cbbGenre.TabIndex = 3;
			// 
			// txtDuration
			// 
			txtDuration.Location = new Point(256, 157);
			txtDuration.Name = "txtDuration";
			txtDuration.Size = new Size(169, 27);
			txtDuration.TabIndex = 2;
			// 
			// txtTitle
			// 
			txtTitle.Location = new Point(256, 110);
			txtTitle.Name = "txtTitle";
			txtTitle.Size = new Size(169, 27);
			txtTitle.TabIndex = 1;
			// 
			// txtArtist
			// 
			txtArtist.Location = new Point(256, 63);
			txtArtist.Name = "txtArtist";
			txtArtist.Size = new Size(169, 27);
			txtArtist.TabIndex = 0;
			// 
			// tabPage3
			// 
			tabPage3.BackColor = Color.CornflowerBlue;
			tabPage3.Controls.Add(lbUsers);
			tabPage3.Location = new Point(4, 29);
			tabPage3.Name = "tabPage3";
			tabPage3.Size = new Size(732, 360);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "View Users";
			// 
			// lbUsers
			// 
			lbUsers.FormattingEnabled = true;
			lbUsers.ItemHeight = 20;
			lbUsers.Location = new Point(160, 49);
			lbUsers.Name = "lbUsers";
			lbUsers.Size = new Size(425, 224);
			lbUsers.TabIndex = 0;
			// 
			// tabPage4
			// 
			tabPage4.BackColor = Color.CornflowerBlue;
			tabPage4.Controls.Add(btnSearchByArtist);
			tabPage4.Controls.Add(cbbSearchSongs);
			tabPage4.Controls.Add(lblSearchByArtist);
			tabPage4.Controls.Add(lbSongs);
			tabPage4.Location = new Point(4, 29);
			tabPage4.Name = "tabPage4";
			tabPage4.Size = new Size(732, 360);
			tabPage4.TabIndex = 3;
			tabPage4.Text = "View Songs";
			// 
			// btnSearchByArtist
			// 
			btnSearchByArtist.Location = new Point(491, 299);
			btnSearchByArtist.Name = "btnSearchByArtist";
			btnSearchByArtist.Size = new Size(94, 29);
			btnSearchByArtist.TabIndex = 6;
			btnSearchByArtist.Text = "Search";
			btnSearchByArtist.UseVisualStyleBackColor = true;
			btnSearchByArtist.Click += btnSearchByArtist_Click_1;
			// 
			// cbbSearchSongs
			// 
			cbbSearchSongs.FormattingEnabled = true;
			cbbSearchSongs.Location = new Point(316, 300);
			cbbSearchSongs.Name = "cbbSearchSongs";
			cbbSearchSongs.Size = new Size(151, 28);
			cbbSearchSongs.TabIndex = 5;
			// 
			// lblSearchByArtist
			// 
			lblSearchByArtist.AutoSize = true;
			lblSearchByArtist.Location = new Point(160, 308);
			lblSearchByArtist.Name = "lblSearchByArtist";
			lblSearchByArtist.Size = new Size(150, 20);
			lblSearchByArtist.TabIndex = 4;
			lblSearchByArtist.Text = "Search Song By Artist";
			// 
			// lbSongs
			// 
			lbSongs.FormattingEnabled = true;
			lbSongs.ItemHeight = 20;
			lbSongs.Location = new Point(160, 49);
			lbSongs.Name = "lbSongs";
			lbSongs.Size = new Size(425, 224);
			lbSongs.TabIndex = 0;
			// 
			// tabPage5
			// 
			tabPage5.BackColor = Color.CornflowerBlue;
			tabPage5.Controls.Add(lblRemoveSong);
			tabPage5.Controls.Add(lblShowUser);
			tabPage5.Controls.Add(lblStreamingMusicService);
			tabPage5.Controls.Add(btnRemoveSong);
			tabPage5.Controls.Add(cbbRemoveSong);
			tabPage5.Controls.Add(lblChooseSong);
			tabPage5.Controls.Add(lblChooseUser);
			tabPage5.Controls.Add(lbFavouriteSongs);
			tabPage5.Controls.Add(btnAddSongToFavourite);
			tabPage5.Controls.Add(cbbSongs);
			tabPage5.Controls.Add(cbbUsers);
			tabPage5.Controls.Add(dataGridView1);
			tabPage5.Location = new Point(4, 29);
			tabPage5.Name = "tabPage5";
			tabPage5.Size = new Size(732, 360);
			tabPage5.TabIndex = 4;
			tabPage5.Text = "Add Song To Favourite";
			// 
			// lblRemoveSong
			// 
			lblRemoveSong.AutoSize = true;
			lblRemoveSong.Location = new Point(30, 222);
			lblRemoveSong.Name = "lblRemoveSong";
			lblRemoveSong.Size = new Size(50, 20);
			lblRemoveSong.TabIndex = 10;
			lblRemoveSong.Text = "label1";
			// 
			// lblShowUser
			// 
			lblShowUser.AutoSize = true;
			lblShowUser.BackColor = Color.DeepSkyBlue;
			lblShowUser.Location = new Point(387, 10);
			lblShowUser.Name = "lblShowUser";
			lblShowUser.Size = new Size(50, 20);
			lblShowUser.TabIndex = 9;
			lblShowUser.Text = "label1";
			// 
			// lblStreamingMusicService
			// 
			lblStreamingMusicService.AutoSize = true;
			lblStreamingMusicService.Location = new Point(3, 10);
			lblStreamingMusicService.Name = "lblStreamingMusicService";
			lblStreamingMusicService.Size = new Size(50, 20);
			lblStreamingMusicService.TabIndex = 8;
			lblStreamingMusicService.Text = "label1";
			// 
			// btnRemoveSong
			// 
			btnRemoveSong.Location = new Point(27, 301);
			btnRemoveSong.Name = "btnRemoveSong";
			btnRemoveSong.Size = new Size(212, 29);
			btnRemoveSong.TabIndex = 7;
			btnRemoveSong.Text = "Remove Song From Favourite";
			btnRemoveSong.UseVisualStyleBackColor = true;
			btnRemoveSong.Click += btnRemoveSong_Click;
			// 
			// cbbRemoveSong
			// 
			cbbRemoveSong.FormattingEnabled = true;
			cbbRemoveSong.Location = new Point(27, 250);
			cbbRemoveSong.Name = "cbbRemoveSong";
			cbbRemoveSong.Size = new Size(273, 28);
			cbbRemoveSong.TabIndex = 6;
			// 
			// lblChooseSong
			// 
			lblChooseSong.AutoSize = true;
			lblChooseSong.Location = new Point(27, 119);
			lblChooseSong.Name = "lblChooseSong";
			lblChooseSong.Size = new Size(43, 20);
			lblChooseSong.TabIndex = 5;
			lblChooseSong.Text = "Song";
			// 
			// lblChooseUser
			// 
			lblChooseUser.AutoSize = true;
			lblChooseUser.Location = new Point(32, 59);
			lblChooseUser.Name = "lblChooseUser";
			lblChooseUser.Size = new Size(38, 20);
			lblChooseUser.TabIndex = 4;
			lblChooseUser.Text = "User";
			// 
			// lbFavouriteSongs
			// 
			lbFavouriteSongs.FormattingEnabled = true;
			lbFavouriteSongs.ItemHeight = 20;
			lbFavouriteSongs.Location = new Point(387, 44);
			lbFavouriteSongs.Name = "lbFavouriteSongs";
			lbFavouriteSongs.Size = new Size(331, 264);
			lbFavouriteSongs.TabIndex = 3;
			// 
			// btnAddSongToFavourite
			// 
			btnAddSongToFavourite.Location = new Point(32, 164);
			btnAddSongToFavourite.Name = "btnAddSongToFavourite";
			btnAddSongToFavourite.Size = new Size(212, 29);
			btnAddSongToFavourite.TabIndex = 2;
			btnAddSongToFavourite.Text = "Add Song To Favourite";
			btnAddSongToFavourite.UseVisualStyleBackColor = true;
			btnAddSongToFavourite.Click += btnAddSongToFavourite_Click;
			// 
			// cbbSongs
			// 
			cbbSongs.FormattingEnabled = true;
			cbbSongs.Location = new Point(93, 111);
			cbbSongs.Name = "cbbSongs";
			cbbSongs.Size = new Size(212, 28);
			cbbSongs.TabIndex = 1;
			// 
			// cbbUsers
			// 
			cbbUsers.FormattingEnabled = true;
			cbbUsers.Location = new Point(93, 56);
			cbbUsers.Name = "cbbUsers";
			cbbUsers.Size = new Size(212, 28);
			cbbUsers.TabIndex = 0;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.DeepSkyBlue;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(375, 3);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(357, 320);
			dataGridView1.TabIndex = 11;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.RoyalBlue;
			ClientSize = new Size(800, 429);
			Controls.Add(tabControl1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Form1_Load;
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			tabPage3.ResumeLayout(false);
			tabPage4.ResumeLayout(false);
			tabPage4.PerformLayout();
			tabPage5.ResumeLayout(false);
			tabPage5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private TabPage tabPage4;
		private TabPage tabPage5;
		private Label lblAddress;
		private Label lblEmail;
		private Label lblName;
		private Button btnCreateUser;
		private TextBox txtAddress;
		private TextBox txtEmail;
		private TextBox txtName;
		private Label lblGenre;
		private Label lblDuration;
		private Label lblTitle;
		private Label lblArtist;
		private Button btnCreateSong;
		private ComboBox cbbGenre;
		private TextBox txtDuration;
		private TextBox txtTitle;
		private TextBox txtArtist;
		private ListBox lbUsers;
		private ListBox lbSongs;
		private Label lblChooseSong;
		private Label lblChooseUser;
		private ListBox lbFavouriteSongs;
		private Button btnAddSongToFavourite;
		private ComboBox cbbSongs;
		private ComboBox cbbUsers;
		private Button btnRemoveSong;
		private ComboBox cbbRemoveSong;
		private Label lblStreamingMusicService;
		private Button btnSearchByArtist;
		private ComboBox cbbSearchSongs;
		private Label lblSearchByArtist;
		private Label lblShowUser;
		private Label lblRemoveSong;
		private DataGridView dataGridView1;
	}
}