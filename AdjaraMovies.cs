using Newtonsoft.Json;
using RestSharp;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.Helpers;
using System.Windows.Forms;
using System.Globalization;

namespace MoviesDB
{
    public partial class AdjaraMovies : Form
    {
        Button currPage;
        public AdjaraMovies()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            HomePage();
            ActiveControl = search_textBox;
            setTheme();
        }
        public void LightTheme()
        {
            BackColor = Color.LightGray;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel2.BackColor = Color.LightGray;
            for (int i = 3; i < MediaTypePnl.Controls.Count; i++)
            {
                MediaTypePnl.Controls[i].ForeColor = Color.Black;
            }
            MoviesLbl.ForeColor = Color.FromArgb(22, 131, 198);
            AllLbl.ForeColor = Color.FromArgb(22, 131, 198); 
            tvLbl.ForeColor = Color.FromArgb(22, 131, 198);
            search_textBox.BackColor = Color.White;
            search_textBox.ForeColor = Color.Black;

            ThemeCB.ForeColor = Color.FromArgb(60, 65, 70);

            sortByListBox.BackColor = Color.FromArgb(22, 131, 198);
            listBox1.BackColor = Color.FromArgb(22, 131, 198);
            HomeBtn.BackColor = Color.FromArgb(22, 131, 198);
            button1.BackColor = Color.FromArgb(22, 131, 198);
            button2.BackColor = Color.FromArgb(22, 131, 198);
            Paging(flowLayoutPanel2.Controls.Count);
            Properties.Settings.Default.DarkTheme = false;
            Properties.Settings.Default.Save();
        }
        public void DarkTheme()
        {
            BackColor = Color.FromArgb(11, 8, 23);
            flowLayoutPanel1.BackColor = Color.FromArgb(20, 17, 34);
            flowLayoutPanel2.BackColor = Color.FromArgb(11, 8, 23);
            foreach (Button btn in flowLayoutPanel2.Controls)
            {
                btn.BackColor = Color.FromArgb(17, 8, 41);
                btn.ForeColor = Color.White;
            }
            MoviesLbl.ForeColor = Color.FromArgb(94, 51, 212);
            AllLbl.ForeColor = Color.FromArgb(94, 51, 212);
            tvLbl.ForeColor = Color.FromArgb(94, 51, 212);
            for (int i = 3; i < MediaTypePnl.Controls.Count; i++)
            {
                MediaTypePnl.Controls[i].ForeColor = Color.Silver;
            }
            search_textBox.BackColor = Color.FromArgb(35, 16, 68);
            search_textBox.ForeColor = Color.White;

            ThemeCB.ForeColor = Color.White;

            sortByListBox.BackColor = Color.FromArgb(40, 16, 78);
            listBox1.BackColor = Color.FromArgb(40, 16, 78);

            HomeBtn.BackColor = Color.FromArgb(40, 16, 78);
            button1.BackColor =  Color.FromArgb(40, 16, 78);
            button2.BackColor = Color.FromArgb(40, 16, 78);
            Paging(flowLayoutPanel2.Controls.Count);

            Properties.Settings.Default.DarkTheme = true;
            Properties.Settings.Default.Save();
        }
        public void setTheme()
        {
            ThemeCB.Checked = Properties.Settings.Default.DarkTheme;
            if (ThemeCB.Checked)
            {
                DarkTheme();
            }
            else
            {
                LightTheme();
            }
        }
        public void Paging(int length)
        {
            flowLayoutPanel2.Controls.Clear();
            if (Properties.Settings.Default.DarkTheme)
            {
                for (int i = 0; i < length; i++)
                {
                    Button btn = new Button()
                    {
                        Text = (i + 1).ToString(),
                        ForeColor = Color.White,
                        BackColor = Color.FromArgb(17, 8, 41),
                        Size = new Size(50, 50),
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("", 15),
                    };
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(40, 16, 78);
                    btn.Click += Btn_Click;
                    flowLayoutPanel2.Controls.Add(btn);
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    Button btn = new Button()
                    {
                        Text = (i + 1).ToString(),
                        ForeColor = Color.FromArgb(60, 65, 70),
                        BackColor = Color.LightGray,
                        Size = new Size(50, 50),
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("", 15),
                    };
                    btn.FlatAppearance.BorderSize = 2;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(22, 131, 198);
                    btn.Click += Btn_Click;
                    flowLayoutPanel2.Controls.Add(btn);
                }
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            var i = ((Button)sender).Text;
            FetchApi api = new FetchApi(this);
            Default_State();
            if (Properties.Settings.Default.DarkTheme)
            {
                Button prevBtn = flowLayoutPanel2.Controls[int.Parse(currPage.Text) - 1] as Button;
                prevBtn.FlatAppearance.BorderSize = 1;
                prevBtn.BackColor = Color.FromArgb(17, 8, 41);
                int ind = int.Parse(i)-1;
                var item = flowLayoutPanel2.Controls[ind] as Button;
                item.FlatAppearance.BorderSize = 0;
                item.BackColor = Color.FromArgb(40, 16, 78);
                currPage = item;
            }
            else
            {
                foreach (Button child in flowLayoutPanel2.Controls)
                {
                    if (child.FlatAppearance.BorderSize == 0)
                    {
                        child.FlatAppearance.BorderSize = 2;
                        child.BackColor = Color.LightGray;
                        child.FlatAppearance.BorderColor = Color.FromArgb(22, 131, 198);
                        break;
                    }
                }
                int ind = int.Parse(i) - 1;
                var item = flowLayoutPanel2.Controls[ind] as Button;
                item.FlatAppearance.BorderSize = 0;
                item.BackColor = Color.FromArgb(22, 131, 198);
            }
            flowLayoutPanel1.Controls.Clear();

            string txt = flowLayoutPanel1.AccessibleDescription;
            int ina = txt.IndexOf("&page=");
            int num = int.Parse(i);
            int nash = txt.Length -ina;
            string fir = txt.Substring(ina, nash);
            string sec = txt.Substring(ina, 6) + num;
            string newstr = txt.Replace(fir,sec );

            Movie movies = api.GetAdjaraMovies(newstr);
            api.LoadAdjaraReq(movies.data);
            MediaTypeCount();
        }

        private void search_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FetchApi api = new FetchApi(this);
                if (search_textBox.Text != null && search_textBox.Text != "" && search_textBox.Text != " ")
                {
                    e.SuppressKeyPress = true;
                    flowLayoutPanel1.Controls.Clear();
                    var for_url = search_textBox.Text.Replace(" ", "%20");
                    string url = $"https://api.adjaranet.com/api/v1/search-advanced?movie_filters%5Bkeyword%5D={for_url}&movie_filters%5Binit%5D=true&movie_filters%5Bwith_actors%5D=3&movie_filters%5Bwith_directors%5D=1&filters%5Btype%5D=movie&keywords={for_url}&per_page=12&source=adjaranet&page=1";
                    Movie movies = api.GetAdjaraMovies(url);
                    api.LoadAdjaraReq(movies.data);
                    MoviesLbl.Visible = true;
                    tvLbl.Visible = true;
                    AllLbl.Visible = true;
                    MediaTypeCount();
                    Meta total_pages = (api.GetAdjaraMovies(url) as Movie).meta;
                    if (total_pages.pagination.total_pages<=10)
                    {
                        Paging(total_pages.pagination.total_pages);
                    }
                    else
                    {
                        Paging(10);
                    }
                    DiscoverStateLbl.Text = "Results For " + search_textBox.Text;
                }
                else
                {
                    e.SuppressKeyPress = true;
                    flowLayoutPanel1.Controls.Clear();
                    HomePage();
                }
                flowLayoutPanel2.Controls[0].BackColor = Color.FromArgb(40, 16, 78);
            }
        }
        public void MediaTypeCount()
        {
            delPrevLbl("tvShowCount");
            delPrevLbl("movieCount");
            delPrevLbl("AllCount");
            Label lbl = new Label()
            {
                Location = new Point(tvLbl.Location.X + 30, tvLbl.Location.Y + 30),
                Anchor = AnchorStyles.Bottom,
                Font = new Font("", 15),
                Name = "tvShowCount",
                AutoSize = false,
                Dock =DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            lbl.ForeColor = ThemeCB.Checked?Color.Silver:Color.FromArgb(60, 65, 70);
            MediaTypePnl.Controls.Add(lbl);
            Label movieLbl = new Label()
            {
                Location = new Point(MoviesLbl.Location.X + 20, MoviesLbl.Location.Y + 30),
                Anchor = AnchorStyles.Bottom,
                Font = new Font("", 15),
                Name = "movieCount",
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            movieLbl.ForeColor = ThemeCB.Checked ? Color.Silver : Color.FromArgb(60, 65, 70); 
            MediaTypePnl.Controls.Add(movieLbl);
            int allCount = 0;
            Label all_lbl = new Label()
            {
                Location = new Point(AllLbl.Location.X + 7, AllLbl.Location.Y + 30),
                Anchor= AnchorStyles.Bottom,
                ForeColor = Color.Silver,
                Font = new Font("", 15),
                Name = "AllCount",
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            all_lbl.ForeColor = ThemeCB.Checked ? Color.Silver : Color.FromArgb(60, 65, 70); 
            MediaTypePnl.Controls.Add(all_lbl);
            int tvCount = 0;
            int movieCount = 0;
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if (flowLayoutPanel1.Controls[i].Enabled == true)
                {
                    if (flowLayoutPanel1.Controls[i].Visible == true)
                    {
                        allCount++;
                        all_lbl.Text = allCount.ToString();
                    }
                    if (flowLayoutPanel1.Controls[i].Name.ToLower() =="true")
                    {
                        tvCount++;
                        lbl.Text = tvCount.ToString();
                    }
                    else if (flowLayoutPanel1.Controls[i].Name.ToLower() == "false")
                    {
                        movieCount++;
                        movieLbl.Text = movieCount.ToString();
                    }
                }
            }
            lbl.Text = lbl.Text == "" ? "0" : lbl.Text;
            movieLbl.Text = movieLbl.Text == ""? "0": movieLbl.Text;
        }
        public void delPrevLbl(string name)
        {
            var prevlbl = MediaTypePnl.Controls.Find(name, false);
            if (prevlbl.Length > 0)
            {
                prevlbl[0].Dispose();
            }
        }
        private void MoviesLbl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if (flowLayoutPanel1.Controls[i].Enabled == true)
                {
                    if (flowLayoutPanel1.Controls[i].Name.ToLower() == "false")
                    {
                        flowLayoutPanel1.Controls[i].Visible = true;
                    }
                    else
                    {
                        flowLayoutPanel1.Controls[i].Visible = false;
                    }

                }
            }
            Default_State();
        }

        private void AllLbl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if (flowLayoutPanel1.Controls[i].Enabled == true)
                {
                    flowLayoutPanel1.Controls[i].Visible = true;
                }
            }
            Default_State();
        }
        private void tvLbl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if (flowLayoutPanel1.Controls[i].Enabled == true)
                {
                    if (flowLayoutPanel1.Controls[i].Name.ToLower() == "true")
                    {
                        flowLayoutPanel1.Controls[i].Visible = true;
                    }
                    else
                    {
                        flowLayoutPanel1.Controls[i].Visible = false;
                    }
                }
            }
            Default_State();
        }



        //public bool CheckOnAdjara(string movie_title)
        //{
        //    var for_url = movie_title.Replace(" ", "%20");
        //    string url = $"https://api.adjaranet.com/api/v1/search-advanced?movie_filters%5Bkeyword%5D={for_url}&movie_filters%5Byear_range%5D=1900%2C2021&movie_filters%5Binit%5D=true&movie_filters%5Bwith_actors%5D=3&movie_filters%5Bwith_directors%5D=1&filters%5Btype%5D=movie&keywords={for_url}&page=1&per_page=15&source=adjaranet";
        //    var client = new RestClient(url);
        //    var request = new RestRequest(Method.GET);
        //    IRestResponse response = client.Execute(request);
        //    Movie[] movies = JsonConvert.DeserializeObject<Movie[]>(Json.Encode(Json.Decode(response.Content)["data"]));
        //    string tmdb_title = "";
        //    for (int i = 0; i < 2; i++)
        //    {
        //        string adjara_title = RemoveDiacritics(movies[i].secondaryName.ToLower().Replace(":", ""));
        //        tmdb_title = RemoveDiacritics(movie_title.ToLower().Replace(":", ""));
        //        if (adjara_title == tmdb_title)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public void NotFoundMessage()
        {
            Panel pnl = new Panel()
            {
                Location = new Point(350,150),
                Size = new Size(420,250),
                BackColor = Color.FromArgb(11,8,27),
                Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left),
            };
            Label lbl = new Label()
            {
                Text = "Not Found On Adjara",
                Font = new Font("",25),
                AutoSize = true,
                ForeColor = Color.White,
                Location = new Point(70,145),
                Anchor = AnchorStyles.Bottom,

            };
            Panel title_pnl = new Panel()
            {
                Size = new Size(pnl.Size.Width,90),
                Location = new Point(0,30),
                Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left),
            };
            Button close_btn = new Button()
            {
                Text = "X",
                Font = new Font("", 15),
                Location = new Point(370, 0),
                Size = new Size(45,45),
                ForeColor = Color.Red,
                FlatStyle = FlatStyle.Flat,
                Anchor = (AnchorStyles.Top | AnchorStyles.Right),
                BackColor = Color.FromArgb(50,50,50),
            };
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.Click += Close_btn_Click;
            pnl.Controls.Add(close_btn);
            pnl.Controls.Add(lbl);
            pnl.Controls.Add(title_pnl);
            Default_State();
            Controls.Add(pnl);
            pnl.BringToFront();
        }
        private void Close_btn_Click(object sender, EventArgs e)
        {
            (sender as Button).Parent.Visible = false ;
            Default_State();
        }
        public void ShowControls(bool show)
        {
            if (this is AdjaraMovies)
            {
                foreach (var item in Controls)
                {
                    if (!(item is MdiClient)&&!((item as Control) is ListBox))
                    {
                        (item as Control).Visible = show;
                    }
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiscoverStateLbl.Text = listBox1.Text;
            Default_State();
            FetchApi api = new FetchApi(this);
            switch (listBox1.Text)
            {
                case "Top Rated":
                    string adjara_url = "https://api.adjaranet.com/api/v1/movies?&per_page=15&filters%5Btype%5D=movie&filters%5Byear_range%5D=1900%2C2021&filters%5Binit%5D=true&filters%5Bsort%5D=-imdb_rating&filters%5Bwith_actors%5D=3&filters%5Bwith_directors%5D=1&filters%5Bwith_files%5D=yes&sort=-imdb_rating&source=adjaranet&page=1";
                    Movie revmovies = api.GetAdjaraMovies(adjara_url);
                    flowLayoutPanel1.Controls.Clear();
                    api.LoadAdjaraReq(revmovies.data);
                    Meta total_pages = (api.GetAdjaraMovies(adjara_url) as Movie).meta;
                    if (total_pages.pagination.total_pages <= 10)
                    {
                        Paging(total_pages.pagination.total_pages);
                    }
                    else
                    {
                        Paging(10);
                    }
                    break;
                case "Most Popular":
                    string most_pop = "https://api.adjaranet.com/api/v1/movies/top?type=movie&period=month&per_page=20&filters%5Bwith_actors%5D=3&filters%5Bwith_directors%5D=1&source=adjaranet&page=1";
                    Movie popmovies = api.GetAdjaraMovies(most_pop);
                    flowLayoutPanel1.Controls.Clear();
                    api.LoadAdjaraReq(popmovies.data);
                    Meta total_pages1 = (api.GetAdjaraMovies(most_pop) as Movie).meta;
                    if (total_pages1.pagination.total_pages <= 10)
                    {
                        Paging(total_pages1.pagination.total_pages);
                    }
                    else
                    {
                        Paging(10);
                    }
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == true)
            {
                listBox1.Visible = false;
            }
            else
            {
                listBox1.Visible = true;
            }
        }


        private void sortByListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FetchApi api = new FetchApi(this);
            sortByListBox.Visible = false;
            switch (sortByListBox.Text)
            {
                case "Alphabet":
                    Movie movies = api.GetAdjaraMovies(flowLayoutPanel1.AccessibleDescription);
                    var omovies = movies.data.OrderBy(m => m.secondaryName);
                    flowLayoutPanel1.Controls.Clear();
                    api.LoadAdjaraReq(omovies.ToArray());
                    break;
                case "Score":
                    Movie ratedmovies = api.GetAdjaraMovies(flowLayoutPanel1.AccessibleDescription);
                    var rmovies = ratedmovies.data.OrderBy(m => m.rating["imdb"]["score"]).Reverse();
                    flowLayoutPanel1.Controls.Clear();
                    api.LoadAdjaraReq(rmovies.ToArray());
                    break;
                case "Release Date":
                    Movie newmovies = api.GetAdjaraMovies(flowLayoutPanel1.AccessibleDescription);
                    var nmovies = newmovies.data.OrderBy(m => String.IsNullOrEmpty(m.releaseDate) ? m.year.ToString() : m.releaseDate).Reverse();
                    flowLayoutPanel1.Controls.Clear();
                    api.LoadAdjaraReq(nmovies.ToArray());
                    break;
                default:
                    break;
            }
        }
        public void Default_State()
        {
            listBox1.Visible = false;
            sortByListBox.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (sortByListBox.Visible == true)
            {
                sortByListBox.Visible = false;
            }
            else
            {
                sortByListBox.Visible = true;
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomePage();
        }
        private void HomePage()
        {
            FetchApi api = new FetchApi(this);
            flowLayoutPanel1.Controls.Clear();
            string url = "https://api.adjaranet.com/api/v1/movies?per_page=15&filters%5Btype%5D=movie&filters%5Byear_range%5D=1900%2C2021&filters%5Binit%5D=true&filters%5Bsort%5D=-year&filters%5Bwith_actors%5D=3&filters%5Bwith_directors%5D=1&filters%5Bwith_files%5D=yes&sort=-year&source=adjaranet&page=1";
            //string url = "https://api.adjaranet.com/api/v1/movies?per_page=15&filters%5Btype%5D=series&filters%5Byear_range%5D=1900%2C2021&filters%5Binit%5D=true&filters%5Bsort%5D=-upload_date&filters%5Bwith_actors%5D=3&filters%5Bwith_directors%5D=1&filters%5Bwith_files%5D=yes&sort=-upload_date&source=adjaranet&page=1";
            Movie movies = api.GetAdjaraMovies(url);
            //var omovies = movies.OrderBy(m => m.watchCount).Reverse();
            api.LoadAdjaraReq(movies.data);
            MediaTypeCount();
            Paging(5);
            DiscoverStateLbl.Text = "Most Popular";
            flowLayoutPanel2.Controls[0].BackColor = Properties.Settings.Default.DarkTheme ? Color.FromArgb(40, 16, 78): Color.FromArgb(22, 131, 198);
            currPage = flowLayoutPanel2.Controls[0] as Button;
            search_textBox.Text = "";
        }

        private void search_textBox_Click(object sender, EventArgs e)
        {
            Default_State();
        }

        private void AdjaraMovies_Click(object sender, EventArgs e)
        {
            Default_State();
        }

        private void ThemeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ThemeCB.Checked)
            {
                Properties.Settings.Default.DarkTheme = true;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.DarkTheme = false;
                Properties.Settings.Default.Save();
            }
            setTheme();
        }

        private void MediaTypePnl_Paint(object sender, PaintEventArgs e)
        {
                    }
    }
}
