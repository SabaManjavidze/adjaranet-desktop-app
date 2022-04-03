
namespace MoviesDB
{
    partial class AdjaraMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdjaraMovies));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.DiscoverStateLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sortByListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ThemeCB = new System.Windows.Forms.CheckBox();
            this.MediaTypePnl = new System.Windows.Forms.TableLayoutPanel();
            this.AllLbl = new System.Windows.Forms.Label();
            this.tvLbl = new System.Windows.Forms.Label();
            this.MoviesLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.MediaTypePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 135);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1324, 495);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // search_textBox
            // 
            this.search_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(16)))), ((int)(((byte)(68)))));
            this.search_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.search_textBox.ForeColor = System.Drawing.Color.White;
            this.search_textBox.Location = new System.Drawing.Point(1088, 15);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(222, 46);
            this.search_textBox.TabIndex = 1;
            this.search_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_textBox_KeyDown);
            // 
            // DiscoverStateLbl
            // 
            this.DiscoverStateLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DiscoverStateLbl.AutoSize = true;
            this.DiscoverStateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscoverStateLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.DiscoverStateLbl.Location = new System.Drawing.Point(550, 79);
            this.DiscoverStateLbl.Name = "DiscoverStateLbl";
            this.DiscoverStateLbl.Size = new System.Drawing.Size(256, 46);
            this.DiscoverStateLbl.TabIndex = 0;
            this.DiscoverStateLbl.Text = "Most Popular";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(16)))), ((int)(((byte)(78)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "Most Popular",
            "Top Rated"});
            this.listBox1.Location = new System.Drawing.Point(925, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 75);
            this.listBox1.TabIndex = 5;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(16)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(925, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Discover";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sortByListBox
            // 
            this.sortByListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortByListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(16)))), ((int)(((byte)(78)))));
            this.sortByListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sortByListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sortByListBox.ForeColor = System.Drawing.Color.White;
            this.sortByListBox.FormattingEnabled = true;
            this.sortByListBox.ItemHeight = 25;
            this.sortByListBox.Items.AddRange(new object[] {
            "Alphabet",
            "Score",
            "Release Date"});
            this.sortByListBox.Location = new System.Drawing.Point(527, 69);
            this.sortByListBox.Name = "sortByListBox";
            this.sortByListBox.Size = new System.Drawing.Size(132, 75);
            this.sortByListBox.TabIndex = 8;
            this.sortByListBox.Visible = false;
            this.sortByListBox.SelectedIndexChanged += new System.EventHandler(this.sortByListBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(16)))), ((int)(((byte)(78)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(527, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sorty By";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(16)))), ((int)(((byte)(78)))));
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Location = new System.Drawing.Point(12, 21);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(132, 55);
            this.HomeBtn.TabIndex = 10;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8308157F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 623);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.96491F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1324, 62);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(662, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 56);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // ThemeCB
            // 
            this.ThemeCB.Checked = true;
            this.ThemeCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ThemeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ThemeCB.ForeColor = System.Drawing.Color.White;
            this.ThemeCB.Location = new System.Drawing.Point(757, 27);
            this.ThemeCB.Name = "ThemeCB";
            this.ThemeCB.Size = new System.Drawing.Size(145, 40);
            this.ThemeCB.TabIndex = 13;
            this.ThemeCB.Text = "Dark Theme";
            this.ThemeCB.UseVisualStyleBackColor = true;
            this.ThemeCB.CheckedChanged += new System.EventHandler(this.ThemeCB_CheckedChanged);
            // 
            // MediaTypePnl
            // 
            this.MediaTypePnl.ColumnCount = 3;
            this.MediaTypePnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MediaTypePnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MediaTypePnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MediaTypePnl.Controls.Add(this.tvLbl, 2, 0);
            this.MediaTypePnl.Controls.Add(this.MoviesLbl, 1, 0);
            this.MediaTypePnl.Controls.Add(this.AllLbl, 0, 0);
            this.MediaTypePnl.Location = new System.Drawing.Point(182, 15);
            this.MediaTypePnl.Name = "MediaTypePnl";
            this.MediaTypePnl.RowCount = 2;
            this.MediaTypePnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.MediaTypePnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.MediaTypePnl.Size = new System.Drawing.Size(309, 85);
            this.MediaTypePnl.TabIndex = 14;
            // 
            // AllLbl
            // 
            this.AllLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AllLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(51)))), ((int)(((byte)(212)))));
            this.AllLbl.Location = new System.Drawing.Point(3, 0);
            this.AllLbl.Name = "AllLbl";
            this.AllLbl.Size = new System.Drawing.Size(96, 48);
            this.AllLbl.TabIndex = 17;
            this.AllLbl.Text = "ALL";
            this.AllLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tvLbl
            // 
            this.tvLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(51)))), ((int)(((byte)(212)))));
            this.tvLbl.Location = new System.Drawing.Point(208, 0);
            this.tvLbl.Name = "tvLbl";
            this.tvLbl.Size = new System.Drawing.Size(98, 48);
            this.tvLbl.TabIndex = 16;
            this.tvLbl.Text = "TvShows";
            this.tvLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoviesLbl
            // 
            this.MoviesLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(51)))), ((int)(((byte)(212)))));
            this.MoviesLbl.Location = new System.Drawing.Point(105, 0);
            this.MoviesLbl.Name = "MoviesLbl";
            this.MoviesLbl.Size = new System.Drawing.Size(97, 48);
            this.MoviesLbl.TabIndex = 15;
            this.MoviesLbl.Text = "Movies";
            this.MoviesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdjaraMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1324, 685);
            this.Controls.Add(this.MediaTypePnl);
            this.Controls.Add(this.ThemeCB);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sortByListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DiscoverStateLbl);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1340, 724);
            this.Name = "AdjaraMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdjaraMovies";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.AdjaraMovies_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MediaTypePnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Label DiscoverStateLbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox sortByListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox ThemeCB;
        private System.Windows.Forms.TableLayoutPanel MediaTypePnl;
        private System.Windows.Forms.Label tvLbl;
        private System.Windows.Forms.Label MoviesLbl;
        private System.Windows.Forms.Label AllLbl;
    }
}

