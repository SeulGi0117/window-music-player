using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random(); //셔플을 위한 랜덤 인스턴스 생성
        string[] files, paths; // 파일을 저장할 문자열 배열 생성
        string[] files1, paths1;
        string[] files2, paths2;   // 파일을 저장할 문자열 배열 생성
        int x;


        #region TapPage (Now Playing, Explore, PlayLists)
        private void btnPlaying_Click(object sender, EventArgs e)
        {
            indicator.Top = btnPlaying.Top + 10;
            bunifuPages1.SetPage(0);
        }
        private void btnExplore_Click(object sender, EventArgs e)
        {
            indicator.Top = btnExplore.Top + 10;
            bunifuPages1.SetPage(1);
        }
        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            indicator.Top = btnPlaylists.Top + 10;
            bunifuPages1.SetPage(2);
        }

        private void btnLyrics_Click(object sender, EventArgs e)
        {
            indicator.Top = btnLyrics.Top + 10;
            bunifuPages1.SetPage(3);
        }

        #endregion

        #region timer_Tick
        private void timer1_Tick(object sender, EventArgs e)
        {        
            if (repeat.Checked)
            {
                
                if (player.playState!=WMPLib.WMPPlayState.wmppsPaused&&player.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                        btn_next_Click(sender, e);
                }
            }
            if (repeat_once.Checked)
            {
                if (player.playState != WMPLib.WMPPlayState.wmppsPaused)
                {
                    player.Ctlcontrols.play();
                }
            }
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)player.Ctlcontrols.currentPosition;

                progressbar.Maximum= (int)player.Ctlcontrols.currentItem.duration;
                progressbar.Value = (int)player.Ctlcontrols.currentPosition;
            }
            try
            {
                lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString;
                lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
            }
            catch
            {

            }
        }
        #endregion

        #region 시작, 일시정지, 멈춤 버튼
        private void btn_playClick(object sender, EventArgs e) //play
        {
            player.Ctlcontrols.play();
        }
        private void btn_pause_Click(object sender, EventArgs e)//pause
        {
            player.Ctlcontrols.pause();
        }
        private void btnStop_Click(object sender, EventArgs e)// stop
        {
            player.Ctlcontrols.stop();
            p_bar.Value = 0;
        }

        #endregion

        #region 이전 곡, 다음 곡 버튼
        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (shuffle.Checked)
            {
                track_list.SelectedIndex = random.Next(0, track_list.Items.Count - 1);
            }
            else
            {
                if (track_list.SelectedIndex == 0)
                {
                    track_list.SelectedIndex = track_list.Items.Count - 1;
                }
                else if (track_list.SelectedIndex > 0)
                {
                    track_list.SelectedIndex = track_list.SelectedIndex - 1;
                }
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (shuffle.Checked)
            {
                track_list.SelectedIndex = random.Next(0, track_list.Items.Count - 1);
            }
            else
            {
                if (track_list.SelectedIndex == track_list.Items.Count - 1)
                {
                    track_list.SelectedIndex = 0;
                }
                else if (track_list.SelectedIndex < track_list.Items.Count - 1)
                {
                    track_list.SelectedIndex = track_list.SelectedIndex + 1;
                }
            }

        }
        #endregion

        #region volume control
        int sound = 0;
        private void volume_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e) //volume
        {
            player.settings.volume = volume.Value;
        }
        private void btnMute_Click(object sender, EventArgs e)
        {
            sound++;
            if (sound % 2 == 1)
            {
                player.settings.mute = true;
                volume.Value = 0;
            }
            else
            {
                player.settings.mute = false;
                volume.Value = player.settings.volume;
            }
        }
        private void btnMaxVol_Click(object sender, EventArgs e)
        {
            player.settings.volume = volume.Maximum;
            volume.Value = volume.Maximum;
        }
        #endregion        
        
        #region pro bar control
        private void progressBar1_MouseDown(object sender, MouseEventArgs e) //set location
        {
             player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }


        private void pro_bar_MouseDown(object sender, MouseEventArgs e)//set location
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / pro_bar.Width;
        }

        private void bunifuProgressBar1_MouseDown(object sender, MouseEventArgs e)//set location
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }
        #endregion


        #region 플레이리스트 music1
        private void btn_music1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Multiselect = true;
            if (ofd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files1 = ofd1.FileNames;
                paths1 = ofd1.FileNames;
                for (x = 0; x < files1.Length; x++)
                {
                    lst_m1playlist.Items.Add(files1[x]);
                }
            }
        }

        private void lst_m1playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths1[lst_m1playlist.SelectedIndex];
            player.Ctlcontrols.play();
            try
            {
                var file = TagLib.File.Create(paths1[lst_m1playlist.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            {

            }
        }
        #endregion

        #region 플레이리스트 music2
        private void btn_music2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.Multiselect = true;
            if (ofd2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files2 = ofd2.FileNames;
                paths2 = ofd2.FileNames;
                for (x = 0; x < files2.Length; x++)
                {
                    lst_m2playlist.Items.Add(files2[x]);
                }
            }
        }

        private void lst_m2playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths2[lst_m2playlist.SelectedIndex];
            player.Ctlcontrols.play();
            try
            {
                var file = TagLib.File.Create(paths2[lst_m2playlist.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            {

            }
        }
        #endregion

        #region Music Player Header
        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            lblHeader.Text = player.status;
        }

        int r = 255, g = 0, b = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (player.currentMedia != null)
            {
                lblHeader.ForeColor = Color.FromArgb(r, g, b);

                if (r > 0 && b == 0)
                {
                    r--;
                    g++;
                }
                if (g > 0 && r == 0)
                {
                    g--;
                    b++;
                }
                if (b > 0 && g == 0)
                {
                    b--;
                    r++;
                }
            }
        }
        #endregion

        #region Import (btn_open)
        private void btn_open_Click(object sender, EventArgs e) //파일 열기
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }
        }

        #endregion

        #region track_list SelectedIndexChanged
        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];
            player.Ctlcontrols.play();

            try
            {
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                var file2 = TagLib.File.Create(paths[track_list.SelectedIndex]);
                string title = file.Tag.Title;
                var album = file.Tag.Album;
                string[] artist = file.Tag.AlbumArtists;
                var lyrics = file.Tag.Lyrics;
                

                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                var bin2 = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
                pictureBox1.Image = Image.FromStream(new MemoryStream(bin2));

                SongTitle.Text = title;
                SongTitle2.Text = title;
                Album.Text = album;
                Artist.Text = file.Tag.FirstArtist;
                Artist2.Text = file.Tag.FirstArtist;
                richTextBox1.Text = lyrics;
            }
            catch
            {

            }
        }


        #endregion


        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // add fake data
        }

        private void indicator_ShapeChanged(object sender, Bunifu.UI.WinForms.BunifuShapes.ShapeChangedEventArgs e)
        {

        }
        private void pro_bar_Click(object sender, EventArgs e)
        {

        }
    }
}
