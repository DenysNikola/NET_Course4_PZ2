namespace PZ2
{
    partial class MainForm
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
            GoToAnimeForm = new Button();
            GoToAnimeList = new Button();
            GoToUser = new Button();
            SuspendLayout();
            // 
            // GoToAnimeForm
            // 
            GoToAnimeForm.Location = new Point(75, 46);
            GoToAnimeForm.Margin = new Padding(2, 1, 2, 1);
            GoToAnimeForm.Name = "GoToAnimeForm";
            GoToAnimeForm.Size = new Size(81, 22);
            GoToAnimeForm.TabIndex = 0;
            GoToAnimeForm.Text = "button1";
            GoToAnimeForm.UseVisualStyleBackColor = true;
            GoToAnimeForm.Click += GoToAnimeForm_Click;
            // 
            // GoToAnimeList
            // 
            GoToAnimeList.Location = new Point(170, 46);
            GoToAnimeList.Margin = new Padding(2, 1, 2, 1);
            GoToAnimeList.Name = "GoToAnimeList";
            GoToAnimeList.Size = new Size(81, 22);
            GoToAnimeList.TabIndex = 1;
            GoToAnimeList.Text = "Show Anime List";
            GoToAnimeList.UseVisualStyleBackColor = true;
            GoToAnimeList.Click += GoToAnimeList_Click;
            // 
            // GoToUser
            // 
            GoToUser.Location = new Point(81, 91);
            GoToUser.Name = "GoToUser";
            GoToUser.Size = new Size(75, 23);
            GoToUser.TabIndex = 2;
            GoToUser.Text = "button1";
            GoToUser.UseVisualStyleBackColor = true;
            GoToUser.Click += GoToUser_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 211);
            Controls.Add(GoToUser);
            Controls.Add(GoToAnimeList);
            Controls.Add(GoToAnimeForm);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        private void GoToAnimeForm_Click(object sender, EventArgs e)
        {
            // Code to open the AnimeForm or perform any action when the button is clicked
            AnimeForm animeForm = new AnimeForm(); // Create an instance of the AnimeForm
            animeForm.Show(); // Show the AnimeForm
        }

        private void GoToAnimeList_Click(object sender, EventArgs e)
        {
            // Code to open the AnimeForm or perform any action when the button is clicked
            AnimeList animeList = new AnimeList(); // Create an instance of the AnimeForm
            animeList.Show(); // Show the AnimeForm
        }

        private void GoToUser_Click(object sender, EventArgs e)
        {
            // Code to open the AnimeForm or perform any action when the button is clicked
            Users userForm = new Users(); // Create an instance of the AnimeForm
            userForm.Show(); // Show the AnimeForm
        }
        #endregion

        private Button GoToAnimeForm;
        private Button GoToAnimeList;
        private Button GoToUser;
    }
}