using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesDB
{
    public partial class SeasonsForm : Form
    {
        public dynamic seasonData { get; set; }
        public int id { get; set; }

        public int currSeasonIndex;

        public dynamic currEpisodesData;

        public MovieDetails movie_details;

        public TableLayoutPanel currentEpBtn;
        public SeasonsForm()
        {
            InitializeComponent();
        }
        public SeasonsForm(MovieDetails mainForm)
        {
            InitializeComponent();
            movie_details = mainForm;
        }
        private void SeasonsForm_Load(object sender, EventArgs e)
        {
            LoadSeasons();
        }
        public void LoadSeasons()
        {
            for (int i = 0; i < seasonData.Count; i++)
            {
                Panel pnl = new Panel()
                {
                    BackColor = Color.FromArgb(20, 17, 34),
                    Size = new Size(0,EpChoosePanel.Height + 30),
                    Dock = DockStyle.Top,
                };
                Label lbl = new Label()
                {
                    Text = "Season "+(i+1),
                    Font = new Font("", 22),
                    AutoSize = true,
                    ForeColor = Color.White,
                    Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                };
                pnl.Click += Pnl_Click;
                lbl.Click += Pnl_Click;
                pnl.Controls.Add(lbl);


                SesEpFlow.Controls.Add(pnl);
                lbl.Location = new Point(pnl.Width / 2 - lbl.Width, pnl.Height / 2 - lbl.Height / 2 - 5);
            }
            SesEpFlow.AutoScroll = false;
            SesEpFlow.HorizontalScroll.Visible = false;
            SesEpFlow.HorizontalScroll.SmallChange = 0;
            SesEpFlow.HorizontalScroll.Maximum = 0;
            SesEpFlow.AutoScroll = true;
        }
        public void LoadEpisodes(int index)
        {
            FetchApi api = new FetchApi();
            SeasonFiles[] episodesData = api.GetMovieFiles(id, index);
            currEpisodesData = episodesData;
            for (int i = 0; i < episodesData.Length; i++)
            {
                TableLayoutPanel ep_table = new TableLayoutPanel()
                {
                    BackColor = Color.FromArgb(42, 36, 58),
                    Dock = DockStyle.Top,
                    Name = i.ToString(),
                };
                Label incLbl = new Label()
                {
                    Text = i + 1 + "",
                    ForeColor = Color.White,
                    Font = new Font("", 15),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                };
                PictureBox pic = new PictureBox()
                {
                    ImageLocation = string.IsNullOrEmpty(episodesData[i].covers["1920"].Value) ? episodesData[i].poster : episodesData[i].covers["1920"].Value,
                    Location = new Point(incLbl.Location.X + 45, 0),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Fill,
                    Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom,
                };
                Label lbl = new Label()
                {
                    Text = episodesData[i].title,
                    ForeColor = Color.White,
                    Font = new Font("", 25),
                    AutoSize = true,
                    Name = i.ToString(),
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                };
                ep_table.ColumnCount = 3;
                ep_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.6187F));
                ep_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.14389F));
                ep_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.23741F));
                ep_table.RowCount = 1;
                ep_table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                ep_table.Controls.Add(incLbl, 0, 0);
                ep_table.Controls.Add(pic, 1, 0);
                ep_table.Controls.Add(lbl, 2, 0);
                ep_table.Click += Ep_pnl_Click;
                lbl.Click += Ep_pnl_Click;
                SesEpFlow.Controls.Add(ep_table);
            }
        }


        /// 
        /// Drop Down Seasons
        /// 
        private void EpChoosePanel_Click(object sender, EventArgs e)
        {
            if (SesEpFlow.Visible == false)
            {
                DropDownBtn.ImageLocation = @"D:/My Documents/arrow/dropDownPurple.png";
                if (SesEpFlow.Controls.Count == 0 || SesEpFlow.Controls[0].Controls.Count > 2)
                {
                    LoadSeasons();
                }
                SesEpFlow.Visible = true;
            }
            else
            {
                SesEpFlow.Visible = false;
                DropDownBtn.ImageLocation = @"D:/My Documents/arrow/purple-arrow.png";
            }
        }
        /// 
        /// Click On Seasons
        /// 
        private void Pnl_Click(object sender, EventArgs e)
        {
            int index = sender is Label ? int.Parse((sender as Label).Text.Split()[1]) : int.Parse((sender as Panel).Controls[0].Text.Split()[1]);
            currSeasonIndex = index;
            SeasonNumLbl.Text = index.ToString();
            Button back_btn = new Button()
            {
                BackgroundImage = Image.FromFile(@"D:/My Documents/arrow/purblue.png"),
                BackgroundImageLayout = ImageLayout.Zoom,
                Size = new Size(50, 50),
                BackColor = Color.FromArgb(29, 24, 49),
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(5, 5),
                FlatStyle = FlatStyle.Flat,
            };
            back_btn.FlatAppearance.BorderSize = 0;

            SesEpFlow.Controls.Clear();
            back_btn.Click += Back_btn_Click;
            SesEpFlow.Controls.Add(back_btn);

            ///
            /// Episode List
            ///
            LoadEpisodes(index);
            currentEpBtn = SesEpFlow.Controls[1] as TableLayoutPanel;
            SesEpFlow.AutoScroll = false;
            SesEpFlow.HorizontalScroll.Visible = false;
            SesEpFlow.HorizontalScroll.SmallChange = 0;
            SesEpFlow.HorizontalScroll.Maximum = 0;
            SesEpFlow.AutoScroll = true;
        }


        private void Ep_pnl_Click(object sender, EventArgs e)
        {
            currentEpBtn.BackColor = Color.FromArgb(42, 36, 58);
            int index = sender is Label ? int.Parse((sender as Label).Name) : int.Parse((sender as TableLayoutPanel).Name);
            if (sender is Label||sender is PictureBox)
            {
                currentEpBtn = (sender as Control).Parent as TableLayoutPanel;
            }
            else
            {
                currentEpBtn = sender as TableLayoutPanel;
            }
            currentEpBtn.BackColor= Color.FromArgb(152, 52, 235);
            EpisodeNumLbl.Text = (index + 1).ToString();
            for (int i = 0; i < currEpisodesData[index].files.Count; i++)
            {
                file file = JsonConvert.DeserializeObject<file>(currEpisodesData[index].files[i].ToString());
                if (file.lang == "ENG")
                {
                    for (int j = 0; j < file.files.Count; j++)
                    {
                        if (file.files[j]["quality"].Value == "HIGH")
                        {
                            movie_details.changeVideoUrl(file.files[j]["src"].Value);
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("There is no English File");

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            SesEpFlow.Controls.Clear();
            LoadSeasons();
        }
    }
}
