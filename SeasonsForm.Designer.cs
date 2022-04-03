
namespace MoviesDB
{
    partial class SeasonsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeasonsForm));
            this.SesEpFlow = new System.Windows.Forms.TableLayoutPanel();
            this.EpChoosePanel = new System.Windows.Forms.Panel();
            this.seasonLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.EpisodeTxtLbl = new System.Windows.Forms.Label();
            this.EpisodeNumLbl = new System.Windows.Forms.Label();
            this.SeasonTxtLbl = new System.Windows.Forms.Label();
            this.SeasonNumLbl = new System.Windows.Forms.Label();
            this.DropDownBtn = new System.Windows.Forms.PictureBox();
            this.EpChoosePanel.SuspendLayout();
            this.seasonLayoutTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DropDownBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // SesEpFlow
            // 
            this.SesEpFlow.AutoScroll = true;
            this.SesEpFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(49)))));
            this.SesEpFlow.ColumnCount = 1;
            this.SesEpFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SesEpFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SesEpFlow.Location = new System.Drawing.Point(0, 65);
            this.SesEpFlow.Name = "SesEpFlow";
            this.SesEpFlow.RowCount = 1;
            this.SesEpFlow.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SesEpFlow.Size = new System.Drawing.Size(557, 172);
            this.SesEpFlow.TabIndex = 10;
            // 
            // EpChoosePanel
            // 
            this.EpChoosePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(49)))));
            this.EpChoosePanel.Controls.Add(this.seasonLayoutTable);
            this.EpChoosePanel.Controls.Add(this.DropDownBtn);
            this.EpChoosePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EpChoosePanel.ForeColor = System.Drawing.Color.Purple;
            this.EpChoosePanel.Location = new System.Drawing.Point(0, 0);
            this.EpChoosePanel.MinimumSize = new System.Drawing.Size(361, 65);
            this.EpChoosePanel.Name = "EpChoosePanel";
            this.EpChoosePanel.Size = new System.Drawing.Size(557, 65);
            this.EpChoosePanel.TabIndex = 9;
            this.EpChoosePanel.Click += new System.EventHandler(this.EpChoosePanel_Click);
            // 
            // seasonLayoutTable
            // 
            this.seasonLayoutTable.ColumnCount = 4;
            this.seasonLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.05597F));
            this.seasonLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.26399F));
            this.seasonLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.65998F));
            this.seasonLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.02006F));
            this.seasonLayoutTable.Controls.Add(this.EpisodeTxtLbl, 0, 0);
            this.seasonLayoutTable.Controls.Add(this.EpisodeNumLbl, 0, 0);
            this.seasonLayoutTable.Controls.Add(this.SeasonTxtLbl, 0, 0);
            this.seasonLayoutTable.Controls.Add(this.SeasonNumLbl, 0, 0);
            this.seasonLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonLayoutTable.Location = new System.Drawing.Point(0, 0);
            this.seasonLayoutTable.Name = "seasonLayoutTable";
            this.seasonLayoutTable.RowCount = 1;
            this.seasonLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.seasonLayoutTable.Size = new System.Drawing.Size(486, 65);
            this.seasonLayoutTable.TabIndex = 6;
            // 
            // EpisodeTxtLbl
            // 
            this.EpisodeTxtLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EpisodeTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EpisodeTxtLbl.ForeColor = System.Drawing.Color.White;
            this.EpisodeTxtLbl.Location = new System.Drawing.Point(251, 0);
            this.EpisodeTxtLbl.Name = "EpisodeTxtLbl";
            this.EpisodeTxtLbl.Size = new System.Drawing.Size(118, 65);
            this.EpisodeTxtLbl.TabIndex = 11;
            this.EpisodeTxtLbl.Text = "Episode :";
            this.EpisodeTxtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EpisodeNumLbl
            // 
            this.EpisodeNumLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EpisodeNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EpisodeNumLbl.ForeColor = System.Drawing.Color.White;
            this.EpisodeNumLbl.Location = new System.Drawing.Point(375, 0);
            this.EpisodeNumLbl.Name = "EpisodeNumLbl";
            this.EpisodeNumLbl.Size = new System.Drawing.Size(108, 65);
            this.EpisodeNumLbl.TabIndex = 13;
            this.EpisodeNumLbl.Text = "1";
            this.EpisodeNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SeasonTxtLbl
            // 
            this.SeasonTxtLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SeasonTxtLbl.ForeColor = System.Drawing.Color.White;
            this.SeasonTxtLbl.Location = new System.Drawing.Point(3, 0);
            this.SeasonTxtLbl.Name = "SeasonTxtLbl";
            this.SeasonTxtLbl.Size = new System.Drawing.Size(193, 65);
            this.SeasonTxtLbl.TabIndex = 10;
            this.SeasonTxtLbl.Text = "Season :";
            this.SeasonTxtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SeasonNumLbl
            // 
            this.SeasonNumLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SeasonNumLbl.ForeColor = System.Drawing.Color.White;
            this.SeasonNumLbl.Location = new System.Drawing.Point(202, 0);
            this.SeasonNumLbl.Name = "SeasonNumLbl";
            this.SeasonNumLbl.Size = new System.Drawing.Size(43, 65);
            this.SeasonNumLbl.TabIndex = 12;
            this.SeasonNumLbl.Text = "1";
            this.SeasonNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DropDownBtn
            // 
            this.DropDownBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DropDownBtn.Image = ((System.Drawing.Image)(resources.GetObject("DropDownBtn.Image")));
            this.DropDownBtn.Location = new System.Drawing.Point(486, 0);
            this.DropDownBtn.Name = "DropDownBtn";
            this.DropDownBtn.Size = new System.Drawing.Size(71, 65);
            this.DropDownBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DropDownBtn.TabIndex = 5;
            this.DropDownBtn.TabStop = false;
            this.DropDownBtn.Click += new System.EventHandler(this.EpChoosePanel_Click);
            // 
            // SeasonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(557, 237);
            this.Controls.Add(this.SesEpFlow);
            this.Controls.Add(this.EpChoosePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeasonsForm";
            this.Text = "SeasonsForm";
            this.Load += new System.EventHandler(this.SeasonsForm_Load);
            this.EpChoosePanel.ResumeLayout(false);
            this.seasonLayoutTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DropDownBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SesEpFlow;
        private System.Windows.Forms.Panel EpChoosePanel;
        private System.Windows.Forms.PictureBox DropDownBtn;
        private System.Windows.Forms.TableLayoutPanel seasonLayoutTable;
        private System.Windows.Forms.Label EpisodeTxtLbl;
        private System.Windows.Forms.Label EpisodeNumLbl;
        private System.Windows.Forms.Label SeasonTxtLbl;
        private System.Windows.Forms.Label SeasonNumLbl;
    }
}