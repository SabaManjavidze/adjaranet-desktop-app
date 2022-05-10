using AxWMPLib;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesDB
{
    public partial class MovieDetails : MovieDetailsModel 
    {
        string base_url = "https://www.adjaranet.com/movies/";
        double FULL_SPEED = 2;
        double HALF_SPEED = 1.5;
        double NORMAL_SPEED = 1;
        double CURR_SPEED = 1;

        //Control[] controls;
        public MovieDetails()
        {
            InitializeComponent();
        }
        private void MovieDetails_Load(object sender, EventArgs e)
        {
            this.ActiveControl = PlayPicBox;
            this.Resize += MovieDetails_Resize;
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(poster);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);
            PlayPicBox.BackgroundImage = img;
            TitleLbl.Text = title;
            GenresLbl.Text = genres;
            if (bool.Parse(Name))
            {
                SeasonsForm seasons = new SeasonsForm(this);
                seasons.seasonData = seasonData;
                seasons.id = id;
                seasons.TopLevel = false;
                DetailsTable.Controls.Add(seasons);
                seasons.Dock = DockStyle.Fill;
                seasons.Show();
            }
            DescLbl.Text = "Description : " + desc;
            ReleaseDateLbl.Text = ReleaseDateLbl.Text+release_date;
        }

        private void MovieDetails_Resize(object sender, EventArgs e)
        {
            GenresLbl.MaximumSize = new Size(GenresPnl.Size.Width, 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(base_url+adjara_url);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var movies = (MdiParent as AdjaraMovies);
            this.Close();
            movies.IsMdiContainer = false;
            movies.flowLayoutPanel1.Visible = true;
            movies.ShowControls(true);
            this.Dispose();
        }

        private void Player_KeyDownEvent(object sender, _WMPOCXEvents_KeyDownEvent e)
        {
            AxWindowsMediaPlayer player = sender as AxWindowsMediaPlayer;
            if (player.playState == WMPLib.WMPPlayState.wmppsWaiting || player.playState == WMPLib.WMPPlayState.wmppsTransitioning)
                return;
            if (e.nKeyCode == 70)
            {
                if (!player.fullScreen)
                {
                    player.fullScreen = true;
                    player.Focus();
                }
                else
                {
                    player.fullScreen = false;
                    player.Focus();
                }
            }
            if (e.nKeyCode == 71)
            {
                if (CURR_SPEED == HALF_SPEED)
                {
                    CURR_SPEED=player.settings.rate = NORMAL_SPEED;
                }
                else
                {
                    CURR_SPEED=player.settings.rate = HALF_SPEED;
                }
            }
            if (e.nKeyCode == 72)
            {
                if (CURR_SPEED == FULL_SPEED)
                {
                     CURR_SPEED = player.settings.rate = NORMAL_SPEED;
                }
                else
                {
                     CURR_SPEED = player.settings.rate = FULL_SPEED;
                }
            }
            if (e.nKeyCode == 32)
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    player.Ctlcontrols.pause();
                    player.Focus();
                }
                else
                {
                    player.Ctlcontrols.play();
                    player.Focus();
                }
            }
            if (e.nKeyCode == 65)
            {
                player.Ctlcontrols.currentPosition -= 5;
            }
            else if (e.nKeyCode == 68)
            {
                player.Ctlcontrols.currentPosition += 5;
            }
        }

        private void PlayPicBox_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vid_url))
            {
                MessageBox.Show("Can't Play Video Or Video Is Not English");
                return;
            }
            (sender as PictureBox).Visible = false;
            createVidPlayer(vid_url);
        }
        public void createVidPlayer(string url)
        {
            AxWindowsMediaPlayer player = new AxWindowsMediaPlayer();
            player.KeyDownEvent += Player_KeyDownEvent;
            player.Name = "player";
            PosterPanel.Controls.Add(player);
            player.BringToFront();
            player.stretchToFit = true;
            player.Dock = DockStyle.Fill;
            player.URL = url;
            //var client = new RestClient(url);
            //var request = new RestRequest(Method.GET);
            //IRestResponse response = client.Execute(request);
            //MessageBox.Show(response.StatusCode.ToString());
        }
        public void changeVideoUrl(string url)
        {
            Control[] control = PosterPanel.Controls.Find("player", false);
            if (control.Count() <= 0)
            {
                createVidPlayer(url);
                return;
            }
            (control[0] as AxWindowsMediaPlayer).URL = url;
        }

        private void PlayPicBox_MouseHover(object sender, EventArgs e)
        {
            PlayPicBox.ImageLocation = @"D:/Desktop/AdjaraMovies/lastVerHover.png";
        }

        private void PlayPicBox_MouseLeave(object sender, EventArgs e)
        {
            PlayPicBox.ImageLocation = @"D:/Desktop/AdjaraMovies/lastVer.png";
        }

        //private void EpChoosePanel_Click(object sender, EventArgs e)
        //{
        //    if (SesEpFlow.Visible == false)
        //    {
        //        DropDownBtn.ImageLocation = @"D:/My Documents/arrow/dropDownPurple.png";
        //        if (SesEpFlow.Controls.Count == 0 || SesEpFlow.Controls[0].Controls.Count >2)
        //        {

        //            for (int i = 0; i < seasonData.Count; i++)
        //            {
        //                Panel pnl = new Panel()
        //                {
        //                    BackColor = EpChoosePanel.BackColor,
        //                    Size = new Size(SesEpFlow.Size.Width - 30, EpChoosePanel.MinimumSize.Height - 20),
        //                    Location = new Point(0, EpChoosePanel.MinimumSize.Height * (i + 1))
        //                };
        //                Label lbl = new Label()
        //                {
        //                    Text = seasonData[i]["name"],
        //                    Font = new Font("", 20),
        //                    Anchor = AnchorStyles.Top,
        //                    AutoSize = true,
        //                    Dock = DockStyle.Fill,
        //                    ForeColor = Color.White,
        //                };
        //                pnl.Click += Pnl_Click;
        //                lbl.Click += Pnl_Click;
        //                pnl.Controls.Add(lbl);
        //                SesEpFlow.Controls.Add(pnl);
        //            }
        //        }
        //        SesEpFlow.Visible = true;
        //        EpChoosePanel.AutoScroll = true;
        //    }
        //    else
        //    {
        //        SesEpFlow.Visible = false;
        //        DropDownBtn.ImageLocation = @"D:/My Documents/arrow/purple-arrow.png";
        //    }
        //}
        //private void Pnl_Click(object sender, EventArgs e)
        //{
        //        int index = sender is Label ? int.Parse((sender as Label).Text.Split()[1]): int.Parse((sender as Panel).Controls[0].Text.Split()[1]);
        //        Button btn = new Button()
        //        {
        //            BackgroundImage = Image.FromFile(@"D:/My Documents/arrow/purblue.png"),
        //            BackgroundImageLayout = ImageLayout.Zoom,
        //            Size = new Size(50, 50),
        //            BackColor = Color.FromArgb(79, 59, 130),
        //            Anchor = AnchorStyles.Top | AnchorStyles.Left,
        //            Location = new Point(5, 5),
        //            FlatStyle = FlatStyle.Flat,
        //        };
        //        btn.FlatAppearance.BorderSize = 0;

        //        SesEpFlow.Controls.Clear();
        //        SesEpFlow.Controls.Add(btn);

        //        FetchApi api = new FetchApi();
        //        SeasonFiles[] episodesData = api.GetMovieFiles(id, index);
        //        for (int i = 0; i < episodesData.Length; i++)
        //        {
        //            Panel ep_pnl = new Panel()
        //            {
        //                BackColor = Color.FromArgb(42, 36, 58),
        //                Size = new Size(SesEpFlow.Size.Width - 30, (sender as Control).Height+20),
        //                Location = new Point(20, (sender as Control).Height * (i + 2))
        //            };
        //            Label incLbl = new Label()
        //            {
        //                Text = i + 1 + "",
        //                ForeColor = Color.White,
        //                Font = new Font("", 15),
        //            };
        //            incLbl.Location = new Point(4, ep_pnl.Height / 2 - incLbl.Height / 2 - 5);
        //            Label lbl = new Label()
        //            {
        //                Text = episodesData[i].title,
        //                ForeColor = Color.White,
        //                Font = new Font("", 15),
        //                AutoSize = true,
        //                MaximumSize = new Size(ep_pnl.Width-5,ep_pnl.Height),
        //            };
        //            lbl.Location = new Point(ep_pnl.Width / 2 - lbl.Width, ep_pnl.Height / 2 - lbl.Height/2 - 5);
        //            ep_pnl.Controls.Add(incLbl);
        //            ep_pnl.Controls.Add(lbl);
        //            SesEpFlow.Controls.Add(ep_pnl);
        //        }
        //        SesEpFlow.AutoScroll = true;
        //}
    }
}
