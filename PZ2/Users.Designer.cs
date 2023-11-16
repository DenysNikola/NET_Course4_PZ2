using Microsoft.EntityFrameworkCore;

namespace PZ2
{
    partial class Users
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
            Username = new TextBox();
            Password = new TextBox();
            Email = new TextBox();
            dataGridView1 = new DataGridView();
            AddUser = new Button();
            delete = new Button();
            UpdateUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Location = new Point(105, 66);
            Username.Name = "Username";
            Username.Size = new Size(133, 23);
            Username.TabIndex = 0;
            // 
            // Password
            // 
            Password.Location = new Point(105, 117);
            Password.Name = "Password";
            Password.Size = new Size(133, 23);
            Password.TabIndex = 1;
            // 
            // Email
            // 
            Email.Location = new Point(107, 171);
            Email.Name = "Email";
            Email.Size = new Size(131, 23);
            Email.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(270, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(518, 373);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            // 
            // AddUser
            // 
            AddUser.Location = new Point(109, 226);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(129, 23);
            AddUser.TabIndex = 4;
            AddUser.Text = "Add User";
            AddUser.UseVisualStyleBackColor = true;
            AddUser.Click += btnAddUser_Click;
            // 
            // delete
            // 
            delete.Location = new Point(109, 269);
            delete.Name = "delete";
            delete.Size = new Size(129, 23);
            delete.TabIndex = 6;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += btnDeleteUser_Click;
            // 
            // UpdateUser
            // 
            UpdateUser.Location = new Point(111, 311);
            UpdateUser.Name = "UpdateUser";
            UpdateUser.Size = new Size(127, 23);
            UpdateUser.TabIndex = 7;
            UpdateUser.Text = "Update";
            UpdateUser.UseVisualStyleBackColor = true;
            UpdateUser.Click += btnUpdateUser_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdateUser);
            Controls.Add(delete);
            Controls.Add(AddUser);
            Controls.Add(dataGridView1);
            Controls.Add(Email);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "Users";
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

            dbContext = new MyDbContext();
            userRepository = new UserRepository(dbContext);
            LoadDataAndBindToDataGridView();
        }

        private void LoadDataAndBindToDataGridView()
        {
            try
            {
                // Query the database for Anime records
                List<User> animeList = dbContext.User.ToList();

                // Bind the data to the DataGridView
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = animeList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string username = Username.Text;
            string email = Email.Text;
            string password = Password.Text;
            // Create
            User newUser = new User
            {
                Username = username,
                Email = email,
                Password = password,
                RegistrationDate = DateTime.Now
            };

            userRepository.AddUser(newUser);
            LoadDataAndBindToDataGridView();
        }

        private int selectedUserId;

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Assuming your DataGridView has a column named "UserID"
                selectedUserId = (int)dataGridView1.SelectedRows[0].Cells["UserID"].Value;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Assuming your DataGridView has a column named "UserID"
                selectedUserId = (int)dataGridView1.SelectedRows[0].Cells["UserID"].Value;
            }
            // Create
            userRepository.DeleteUser(selectedUserId);
            LoadDataAndBindToDataGridView();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Assuming your DataGridView has a column named "UserID"
                selectedUserId = (int)dataGridView1.SelectedRows[0].Cells["UserID"].Value;
            }
            // Get values from textboxes
            string username = Username.Text;
            string email = Email.Text;
            string password = Password.Text;
            // Create
            User newUser = new User
            {
                UserID = selectedUserId,
                Username = username,
                Email = email,
                Password = password,
                RegistrationDate = DateTime.Now
            };
            
            // Create
            userRepository.UpdateUser(newUser);
            LoadDataAndBindToDataGridView();
        }



        #endregion

        private TextBox Username;
        private TextBox Password;
        private TextBox Email;
        private DataGridView dataGridView1;
        private Button AddUser;

        MyDbContext dbContext;
        UserRepository userRepository;
        private Button delete;
        private Button UpdateUser;
    }
}