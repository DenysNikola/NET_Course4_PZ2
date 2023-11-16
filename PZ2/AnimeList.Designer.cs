using Microsoft.EntityFrameworkCore;

namespace PZ2
{
    partial class AnimeList
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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1426, 550);
            dataGridView1.TabIndex = 0;
            // 
            // AnimeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 645);
            Controls.Add(dataGridView1);
            Name = "AnimeList";
            Text = "AnimeList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

            dbContext = new MyDbContext();
            LoadDataAndBindToDataGridView();
        }

        public void LoadDataAndBindToDataGridView()
        {


            using (var context = new MyDbContext())
            {
                var userAnimeListWithDetails = context.UserAnimeList
                    .Include(ual => ual.User) // Include the User navigation property
                    .Include(ual => ual.Anime) // Include the Anime navigation property
                    .Select(ual => new
                    {
                        UserName = ual.User.Username,
                        AnimeName = ual.Anime.Title, // Assuming AnimeName is the property for the Anime's name
                        Score = ual.Score, // Assuming Score is the property for the user's score
                        Status = ual.Status
                    })
                    .ToList();

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = userAnimeListWithDetails;
            }
        }

        private void LoadDataAndBindToDataGridView1()
        {
            try
            {
                // Query the database for Anime records
                List<UserAnimeList> user = dbContext.UserAnimeList.ToList();

                // Bind the data to the DataGridView
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = user;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        #endregion

        private DataGridView dataGridView1;

        private MyDbContext dbContext;

    }
}