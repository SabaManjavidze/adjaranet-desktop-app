using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace MoviesDB
{
    public class File
    {
        public dynamic Files { get; set; }
        public string Lang { get; set; }
    }
    public class FetchApi
    {
        public AdjaraMovies main_form;
        public FetchApi(AdjaraMovies movies)
        {
            main_form = movies;
        }
        public FetchApi()
        {

        }
        public  dynamic GetAdjaraMovies(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var som = Json.Decode(response.Content);
            var som1 = Json.Encode(som);
            Movie movies = JsonConvert.DeserializeObject<Movie>(som1);
            main_form.flowLayoutPanel1.AccessibleDescription = url;
            return movies;
        }
        public dynamic GetMovieFiles(int id,int season)
        {
            var client = new RestClient($"https://api.adjaranet.com/api/v1/movies/{id}/season-files/{season}?source=adjaranet");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            SeasonFiles[] movies = JsonConvert.DeserializeObject<SeasonFiles[]>(Json.Encode(Json.Decode(response.Content)["data"]));
            return movies;
        }
        public Data GetAdjaraMovie(string id)
        {
            string url = $"https://api.adjaranet.com/api/v1/movies/{id}?source=adjaranet";
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Data adj_movie = JsonConvert.DeserializeObject<Data>(Json.Encode(Json.Decode(response.Content)["data"]));
            return adj_movie;
        }
        public void LoadAdjaraReq(Data[] movies)
        {
            /*            WebClient wc = new WebClient();
                        byte[] bytes = wc.DownloadData("https://cdn.discordapp.com/attachments/851501058282750013/860541285243551794/notFound.png");
                        MemoryStream ms = new MemoryStream(bytes);
                        Image img = Image.FromStream(ms);
            */
            main_form.AllCountLbl.Text = movies.Length + "";
            main_form.MovieCountLbl.Text = "0";
            main_form.TvCountLbl.Text = "0";
            
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].adjaraId != null)
                {
                    PictureBox pic = new PictureBox()
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(250, 375),
                        /*ErrorImage = img,*/
                        Name = movies[i].adjaraId
                    };
                    if (!string.IsNullOrEmpty(movies[i].posters["data"]["240"].Value))
                    {
                        pic.ImageLocation = movies[i].posters["data"]["240"].Value;
                    }
                    else
                    {
                        pic.Image = null;
                    }
                    if (movies[i].isTvShow)
                    {
                        main_form.TvCountLbl.Text = (int.Parse(main_form.TvCountLbl.Text)+1)+"";
                    }
                    else
                    {
                        main_form.MovieCountLbl.Text =(int.Parse(main_form.MovieCountLbl.Text)+1)+"";
                    }
                    pic.Click += Pic_Click;
                    Label lbl = new Label()
                    {
                        TextAlign = ContentAlignment.BottomCenter,
                        Size = new Size(250, 60),
                        Font = new Font("", 15),
                        ForeColor = Color.FromArgb(155, 189, 255),
                    };
                    lbl.Text = movies[i].secondaryName;
                    FlowLayoutPanel pnl = new FlowLayoutPanel()
                    {
                        Size = new Size(255, 450),
                        FlowDirection = FlowDirection.TopDown,
                        Name = movies[i].isTvShow.ToString(),
                    };
                    pnl.Click += Pnl_Click;
                    pnl.Controls.Add(lbl);
                    pnl.Controls.Add(pic);
                    main_form.flowLayoutPanel1.Controls.Add(pnl);
                }
            }
        }

        private  void Pnl_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((FlowLayoutPanel)sender).Name);
        }

        private  void Pic_Click(object sender, EventArgs e)
        {
            main_form.Default_State();
            var pic = (PictureBox)sender;
            var lbl = pic.Parent.Controls[0] as Label;
            if (!string.IsNullOrEmpty(lbl.Text))
            {
                LoadAdjaraDetails(pic.Name);
            }
        }
        private  void LoadAdjaraDetails(string id)
        {
            var adj_movie = GetAdjaraMovie(id);
            if (adj_movie.watchCount == 0)
            {
                return;
            }
            MovieDetails movieDetails = new MovieDetails();
            movieDetails.title = adj_movie.secondaryName;
            movieDetails.Name = adj_movie.isTvShow.ToString();
            movieDetails.release_date = adj_movie.releaseDate;
            var seasons_data = adj_movie.seasons["data"];
            var movies = GetMovieFiles(adj_movie.id, (int)seasons_data[0]["number"].Value);
            for (int i = 0; i < movies[0].files.Count; i++)
            {
                File file = JsonConvert.DeserializeObject<File>(movies[0].files[i].ToString());
                if (file.Lang == "ENG")
                {
                    for (int j = 0; j < file.Files.Count; j++)
                    {
                        if (file.Files[j]["quality"].Value == "HIGH")
                        {
                            movieDetails.vid_url = file.Files[j]["src"];
                        }
                    }
                }
            }
            
            if (seasons_data.Count>0)
            {
                movieDetails.seasonData = seasons_data;
            }
            string data = adj_movie.covers["data"]["1920"].Value;
            movieDetails.poster = data;
            if (adj_movie.genres["data"].Count > 0)
            {
                for (int j = 0; j < adj_movie.genres["data"].Count; j++)
                {
                    movieDetails.genres += adj_movie.genres["data"][j]["secondaryName"].Value + " ";
                }
            }
            else
            {
                movieDetails.genres = "Genres Not Added";
            }
            movieDetails.desc = adj_movie.plot["data"]["description"].Value;
            movieDetails.adjara_url = adj_movie.adjaraId + "/" + adj_movie.secondaryName.Replace(" ", "-");
            movieDetails.id = adj_movie.id;
            main_form.IsMdiContainer = true;
            movieDetails.MdiParent = Form.ActiveForm;
            movieDetails.FormBorderStyle = FormBorderStyle.None;
            movieDetails.WindowState = FormWindowState.Normal;
            movieDetails.Dock = DockStyle.Fill;
            main_form.ShowControls(false);
            main_form.flowLayoutPanel1.Visible = false;
            movieDetails.Show();
            return;
            main_form.NotFoundMessage();
        }
    }
}
